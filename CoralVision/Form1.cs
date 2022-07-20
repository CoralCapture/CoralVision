//dll files of these must be in ./bin64/Debug/
using FlyCapture2Managed;
using FlyCapture2Managed.Gui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using Thorlabs.MotionControl.Benchtop.DCServoCLI;

//dll files for thorlabs stage must be in ./bin64/Debug
using Thorlabs.MotionControl.DeviceManagerCLI;
using Thorlabs.MotionControl.GenericMotorCLI.Settings;


namespace CoralVision
{
    public partial class Form1 : Form
    {
        //declare and intitialize classes used with constructors
        private FlyCapture2Managed.Gui.CameraControlDialog cameraCtrlDlg;
        private ManagedCameraBase camera = null;
        private ManagedImage rawImage;
        private ManagedImage processedImage;
        private bool grabImages;
        private AutoResetEvent grabThreadExited;
        private BackgroundWorker grabThread;
        private TriggerMode triggerMode;

        //setup of the servo channels (stage serial is 101254364)
        private static readonly string serialNo = "101254364";
        private static BenchtopDCServo fullStage = BenchtopDCServo.CreateBenchtopDCServo(serialNo);
        private static DCServoChannel xChannel = fullStage.GetChannel(1);
        private static DCServoChannel yChannel = fullStage.GetChannel(2);


        public Form1()
        {
            InitializeComponent();
            // create new objects from the following classes
            rawImage = new ManagedImage();
            processedImage = new ManagedImage();
            cameraCtrlDlg = new CameraControlDialog();
            grabThreadExited = new AutoResetEvent(false);
            triggerMode = new TriggerMode();


            //UI controls setup
            homingButton.Enabled = false;
            moveOnlyButton.Enabled = false;
            recAndMove.Enabled = false;
            button2.Enabled = false;
            comboBox1.SelectedIndex = 0;

        }

        private void refreshUI(object sender, ProgressChangedEventArgs e)
        {
            refreshStatusbar();
            pictureBox1.Image = processedImage.bitmap;
            pictureBox1.Invalidate();
        }

        private void refreshStatusbar()
        {
            //insert pixel size to status bar
            String statusInfo = String.Format("Image Size: {0} x {1}", rawImage.cols, rawImage.rows);
            toolStripStatusLabelImageSize.Text = statusInfo;

            //insert frame rate to status bar
            try
            {
                statusInfo = String.Format("Frame Rate: {0} Hz", camera.GetProperty(PropertyType.FrameRate).absValue);
            }
            catch (FC2Exception ex)
            {
                statusInfo = "Frame rate is 0.00 Hz";
                Debug.WriteLine(ex.Message);
            }
            toolStripStatusLabelFrameRate.Text = statusInfo;

            //insert time stamp to status bar
            TimeStamp timeStamp;
            lock (this)
            {
                timeStamp = rawImage.timeStamp;
            }
            statusInfo = String.Format("Timestamp: {0:000}.{1:000}.{2:000}", timeStamp.cycleSeconds, timeStamp.cycleCount, timeStamp.cycleOffset);
            toolStripStatusLabelTimestamp.Text = statusInfo;

            //force refresh of entire status strip
            statusStrip1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //hide form 1 first to the user so that camera selection can take place
            Hide();

            //create new instance of camera selection dialog to prompt user to select it
            CameraSelectionDialog cameraSlnDlg = new CameraSelectionDialog();

            bool show2user = cameraSlnDlg.ShowModal();
            //if "OK" was pressed then then show2user returns "true", therefore.
            if (show2user)
            {
                try
                {
                    ManagedPGRGuid[] chosenOne = cameraSlnDlg.GetSelectedCameraGuids();
                    //line for debugging if no camera was chosen, output a statement and close the form
                    if (chosenOne.Length == 0)
                    {
                        MessageBox.Show("No camera was selected. Restart the application and try again.",
                            "No Camera Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Close();
                        return;
                    }
                    //assign the guid to be used as the one that was chosen in the dialog
                    ManagedPGRGuid usedOne = chosenOne[0];

                    //create a instance of busmanager
                    ManagedBusManager busManager = new ManagedBusManager();
                    InterfaceType UIstyle = busManager.GetInterfaceTypeFromGuid(usedOne);

                    /*check interface (if Gigabit ethernet or otherwise)
                    we will generally use USB2 or USB3 -- GigE is also available*/
                    if (UIstyle == InterfaceType.GigE)
                    {
                        camera = new ManagedGigECamera();
                    }
                    else
                    {
                        camera = new ManagedCamera();
                    }

                    //connect to the first selected guid and connect to the control dialog
                    camera.Connect(usedOne);
                    cameraCtrlDlg.Connect(camera);

                    //CameraInfo cameraInfo = new CameraInfo();
                    CameraInfo cameraInfo = camera.GetCameraInfo();
                    //output the camera caption to the form header for easier reading
                    refreshFormTitle(cameraInfo);

                    //set the timestamp that is embedded on the form also
                    EmbeddedImageInfo embeddedImageInfo = camera.GetEmbeddedImageInfo();
                    embeddedImageInfo.timestamp.onOff = true;


                    //camera params setup
                    FC2Config fc2config = new FC2Config();
                    fc2config.grabMode = GrabMode.BufferFrames;
                    fc2config.numBuffers = 50;
                    //fc2config.highPerformanceRetrieveBuffer = true;
                    fc2config.grabTimeout = 1000;
                    
                    camera.GetTriggerMode();
                    triggerMode.onOff = false;
                    triggerMode.mode = 0;
                    triggerMode.parameter = 0;
                    triggerMode.source = 7;
                    
                    camera.SetConfiguration(fc2config);
                    camera.SetEmbeddedImageInfo(embeddedImageInfo);
                    camera.SetTriggerMode(triggerMode);

                    camera.StartCapture();
                    grabImages = true;

                    //start picking the images
                    startPickingLoop();
                }
                catch (FC2Exception ex)
                {
                    Debug.WriteLine("Failed to initialize the form properly: " + ex.Message);
                }
                toolStripButtonStart.Enabled = false;
                toolStripButtonStop.Enabled = true;
            }
            else
            {
                MessageBox.Show("Thank you for using CoralCapture. Until next time!", "Application Closing");
                Close();
                //Show();
            }
            Show();
        }

        //following function updates the form title of coralcapture to include vendorname, model name, serialnumber and IP address of the camera
        private void refreshFormTitle(CameraInfo cameraInfo)
        {
            String formTitle = String.Format("CoralCapture - Camera: {0} {1} {2} {3}",
                cameraInfo.vendorName,
                cameraInfo.modelName,
                cameraInfo.serialNumber,
                cameraInfo.ipAddress);
            this.Text = formTitle;
            label1.Text = String.Format("Camera View Port of {0}", cameraInfo.modelName);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Before you Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //Environment.Exit(0);
                toolStripButtonStop_Click(sender, e);
                triggerMode.onOff = true;
                camera.SetTriggerMode(triggerMode);
                camera.Disconnect();
                fullStage.Disconnect(true);
            }
            catch (FC2Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        //function starts the picking loopdo_
        private void startPickingLoop()
        {
            grabThread = new BackgroundWorker();
            //here we write the code to update the UI with progress made so far
            grabThread.ProgressChanged += new ProgressChangedEventHandler(refreshUI);
            //here we do the time consuming event
            grabThread.DoWork += new DoWorkEventHandler(pickingLoop);
            grabThread.WorkerReportsProgress = true;
            grabThread.RunWorkerAsync();
        }

        private void pickingLoop(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker hardWorker = sender as BackgroundWorker;
            while (grabImages)
            {
                try
                {
                    camera.RetrieveBuffer(rawImage);
                }
                catch (FC2Exception ex)
                {
                    Debug.WriteLine("There was an error: " + ex.Message);
                    continue;
                }
                lock (this)
                {
                    rawImage.Convert(PixelFormat.PixelFormatBgr, processedImage);
                }
                //required for ininite loop -> force the progress to be zero 
                hardWorker.ReportProgress(0);
            }
            grabThreadExited.Set();
        }

        private void toolStripButtonStop_Click(object sender, EventArgs e)
        {
            grabImages = false;
            try
            {
                camera.StopCapture();
            }
            catch (Exception ex)
            {
                Debug.Write("The camera could not be interrupted: " + ex.Message);
            }
            toolStripButtonStart.Enabled = true;
            toolStripButtonStop.Enabled = false;
        }

        private void toolStripButtonStart_Click(object sender, EventArgs e)
        {
            camera.StartCapture();
            grabImages = true;
            startPickingLoop();
            toolStripButtonStart.Enabled = false;
            toolStripButtonStop.Enabled = true;
        }

        //function on what to do when we click the camera control (cog wheel) in the tool bar
        private void toolStripButtonCameraControl_Click(object sender, EventArgs e)
        {
            if (cameraCtrlDlg.IsVisible())
            {
                cameraCtrlDlg.Hide();
                toolStripButtonCameraControl.Checked = false;
            }
            else
            {
                cameraCtrlDlg.Show();
                toolStripButtonCameraControl.Checked = true;
            }
        }

        //function on what to do when clicking on File->New Camera in tool strip 
        private void newCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (grabImages == true)
            {
                toolStripButtonCameraControl_Click(sender, e);
                cameraCtrlDlg.Hide();
                cameraCtrlDlg.Disconnect();
                camera.Disconnect();
            }
            Form1_Load(sender, e);
        }

        private void  photographer_DoWork(object sender, DoWorkEventArgs e)
        {
            grabImages = false;
            recordButton.Enabled = false;
            int counter = (int)(frameCount.Value);

            List<ManagedImage> imageStack = new List<ManagedImage>();
            List<String> imageNames = new List<String>();
            ManagedImage _rawImage = new ManagedImage();

            for (int i = 0; i < counter; i++)
            {
                try
                {   
                    camera.RetrieveBuffer(_rawImage);
                }
                catch (FC2Exception ex)
                {
                    Debug.Write(ex.Message);
                    continue;
                }
                string _pictureTime = String.Format("{0:000}.{1:000}.{2:000}", _rawImage.timeStamp.cycleSeconds, _rawImage.timeStamp.cycleCount, _rawImage.timeStamp.cycleOffset);
                ManagedImage _tempImage = new ManagedImage(_rawImage);
                imageStack.Add(_tempImage);
                imageNames.Add(_pictureTime);
            }
       
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    for (int i = 0; i < counter; i++)
                    {
                        ManagedImage _convertedImage = new ManagedImage();
                        imageStack[i].Convert(PixelFormat.PixelFormatRgb, _convertedImage);
                        string fileName = String.Format("PIV_FRAME_{0}_TS_{1}.JPEG", (i + 1).ToString(), imageNames[i]);
                        _convertedImage.Save(fileName, ImageFileFormat.Jpeg);
                    }
                    break;
                case 1:
                    for (int i = 0; i < counter; i++)
                    {
                        ManagedImage _convertedImage = new ManagedImage();
                        imageStack[i].Convert(PixelFormat.PixelFormatRgb, _convertedImage);
                        string fileName = String.Format("PIV_Image_Frame_{0}_{1}.PNG", (i + 1).ToString(), imageNames[i]);
                        _convertedImage.Save(fileName, ImageFileFormat.Png);
                    }
                    break;
                case 2:
                    for (int i = 0; i < counter; i++)
                    {
                        ManagedImage _convertedImage = new ManagedImage();
                        imageStack[i].Convert(PixelFormat.PixelFormatRgb, _convertedImage);
                        string fileName = String.Format("PIV_Image_Frame_{0}_{1}.BMP", (i + 1).ToString(), imageNames[i]);
                        _convertedImage.Save(fileName, ImageFileFormat.Bmp);
                    }
                    break;
                case 3:
                    for (int i = 0; i < counter; i++)
                    {
                        ManagedImage _convertedImage = new ManagedImage();
                        imageStack[i].Convert(PixelFormat.PixelFormatRgb, _convertedImage);
                        string fileName = String.Format("PIV_Image_Frame_{0}_{1}.PGM", (i + 1).ToString(), imageNames[i]);
                        _convertedImage.Save(fileName, ImageFileFormat.Pgm);
                    }
                    break;
                case 4:
                    for (int i = 0; i < counter; i++)
                    {
                        ManagedImage _convertedImage = new ManagedImage();
                        imageStack[i].Convert(PixelFormat.PixelFormatRgb, _convertedImage);
                        string fileName = String.Format("PIV_Image_Frame_{0}_{1}.RAW", (i + 1).ToString(), imageNames[i]);
                        _convertedImage.Save(fileName, ImageFileFormat.Raw);
                    }
                    break;
            }
            
            imageStack.Clear();
            imageNames.Clear();
            //photographer.ReportProgress(0);
            recordButton.Enabled = true;
            grabImages = true;
            startPickingLoop();
        }

        private void photographer_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                progressBar1.Value = e.ProgressPercentage;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void photographer_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (fullStage.IsConnected)
            {
                this.reportXLabel.Text = xChannel.Position.ToString();
                this.reportYLabel.Text = yChannel.Position.ToString();
            }
        }

        private void recordButton_Click(object sender, EventArgs e)
        {
            photographer.RunWorkerAsync();
        }

        private void cancelRecordButton_Click(object sender, EventArgs e)
        {
            if (photographer.IsBusy)
            {
                photographer.CancelAsync();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void stageWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            DeviceManagerCLI.BuildDeviceList();
            List<string> devices = DeviceManagerCLI.GetDeviceList(101);
            fullStage.Connect(serialNo);

            if (!xChannel.IsSettingsInitialized() && !yChannel.IsSettingsInitialized())
            {
                try
                {
                    xChannel.WaitForSettingsInitialized(5000);
                    yChannel.WaitForSettingsInitialized(5000);
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.Message);
                }
            }
            Thread.Sleep(500);
            MotorConfiguration xMotorconfig = xChannel.LoadMotorConfiguration(xChannel.DeviceID);
            MotorConfiguration yMotorconfig = yChannel.LoadMotorConfiguration(yChannel.DeviceID);
            if (fullStage.IsConnected)
            {
                homingButton.Enabled = true;
                moveOnlyButton.Enabled = true;
                recAndMove.Enabled = true;
                button2.Enabled = true;
            }
            xChannel.EnableDevice();
            yChannel.EnableDevice();
            Thread.Sleep(1000);
            /*
            xChannel.StartPolling(50);
            yChannel.StartPolling(50);
            */
            if (xChannel.IsEnabled && yChannel.IsEnabled) {
                connectButton.Enabled = false;
            }
            
        }

        private void stageWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void stageWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.reportXLabel.Text = xChannel.Position.ToString();
            this.reportYLabel.Text = yChannel.Position.ToString();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            stageWorker.RunWorkerAsync();
        }

        private void recAndMove_Click(object sender, EventArgs e)
        {
            FC2Config config = new FC2Config();
            config.grabMode = GrabMode.BufferFrames;
            config.numBuffers = (uint)(frameCount.Value);
            //fc2config.highPerformanceRetrieveBuffer = true;
            config.grabTimeout = 1000;
            camera.SetConfiguration(config);
            reportXLabel.Text = xChannel.Position.ToString();
            reportYLabel.Text = yChannel.Position.ToString();
            grabImages = false;
            int iterations = (int)jogCount.Value;
            int counter = (int)frameCount.Value;
            List<ManagedImage> allImages = new List<ManagedImage>();
            List<String> allImageNames = new List<String>();

            for (int i = 0; i < iterations; i++)
            {
                ManagedImage rawImage = new ManagedImage();
                
                for (int j = 0; j < counter; j++)
                {
                    try
                    {
                        camera.RetrieveBuffer(rawImage);
                    }
                    catch (FC2Exception ex)
                    {
                        Debug.Write(ex.Message);
                        continue;
                    }
                    ManagedImage tempImage = new ManagedImage(rawImage);
                    allImages.Add(tempImage);
                    string pictureTime = String.Format("CUT_{0}_{1:000}.{2:000}.{3:000}", i, rawImage.timeStamp.cycleSeconds, rawImage.timeStamp.cycleCount, rawImage.timeStamp.cycleOffset);                    
                    allImageNames.Add(pictureTime);
                    /* string pictureTime = String.Format("{0:000}.{1:000}.{2:000}", tempImage.timeStamp.cycleSeconds, tempImage.timeStamp.cycleCount, tempImage.timeStamp.cycleOffset);
                    tempImage.Convert(PixelFormat.PixelFormatRgb, convertedImage);
                    string fileName = String.Format("PIV_CUT_{0}_FRAME_{1}_TIME_{2}.BMP", i.ToString(), j.ToString(), pictureTime);
                    convertedImage.Save(fileName, ImageFileFormat.Bmp);
                    */
                }
                rawImage.ReleaseBuffer();
                rawImage.Dispose();
                triggerMode.onOff = true;
                camera.SetTriggerMode(triggerMode);
                camera.StopCapture();
                decimal xtarget = (decimal)((i + 1) * xJogInput.Value);
                decimal ytarget = (decimal)((i + 1) * yJogInput.Value);
                xChannel.MoveTo(xChannel.Position+xtarget, 6000);
                yChannel.MoveTo(yChannel.Position+ytarget, 6000);
                reportXLabel.Text = xChannel.Position.ToString();
                reportYLabel.Text = yChannel.Position.ToString();
                Thread.Sleep(5000);
                triggerMode.onOff = false;
                camera.SetTriggerMode(triggerMode);
                Thread.Sleep(5000);
                camera.StartCapture();
            }

            //save routine
            for (int k = 0; k < allImages.Count; k++)
            {
                //convert images
                ManagedImage convertedImage = new ManagedImage();
                allImages[k].Convert(PixelFormat.PixelFormatBgr, convertedImage);
                string fileName = String.Format("PIV_Image_Frame_{0}_{1}.BMP", k + 1, allImageNames[k]);
                convertedImage.Save(fileName, ImageFileFormat.Bmp);
                convertedImage.Dispose();
            }

            /*
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    for (int i = 0; i < allImages.Count; i++)
                    {
                        //convert images
                        ManagedImage convertedImage = new ManagedImage();
                        allImages[i].Convert(PixelFormat.PixelFormatBgr, convertedImage);
                        string fileName = String.Format("PIV_Image_Frame_{0}.JPEG", i + 1);
                        convertedImage.Save(fileName, ImageFileFormat.Jpeg);
                        photographer.ReportProgress(i + 1);
                    }
                    break;
                case 1:
                    for (int i = 0; i < imageSeries.Count; i++)
                    {
                        imageSeries[i].Convert(PixelFormat.PixelFormatBgr, convertedImage);
                        string fileName = String.Format("PIV_Image_Frame_{0}.PNG", i + 1);
                        convertedImage.Save(fileName, ImageFileFormat.Png);
                        photographer.ReportProgress(i + 1);
                    }
                    break;
                case 2:
                    for (int i = 0; i < imageSeries.Count; i++)
                    {
                        imageSeries[i].Convert(PixelFormat.PixelFormatBgr, convertedImage);
                        string fileName = String.Format("PIV_Image_Frame_{0}.BMP", i + 1);
                        convertedImage.Save(fileName, ImageFileFormat.Bmp);
                        photographer.ReportProgress(i + 1); ;
                    }
                    break;
                case 3:
                    for (int i = 0; i < imageSeries.Count; i++)
                    {
                        imageSeries[i].Convert(PixelFormat.PixelFormatBgr, convertedImage);
                        string fileName = String.Format("PIV_Image_Frame_{0}.PGM", i + 1);
                        convertedImage.Save(fileName, ImageFileFormat.Pgm);
                        photographer.ReportProgress(i + 1);
                    }
                    break;
                case 4:
                    for (int i = 0; i < imageSeries.Count; i++)
                    {
                        imageSeries[i].Convert(PixelFormat.PixelFormatBgr, convertedImage);
                        string fileName = String.Format("PIV_Image_Frame_{0}.RAW", i + 1);
                        convertedImage.Save(fileName, ImageFileFormat.Raw);
                        photographer.ReportProgress(i + 1);
                    }
                    break;
            }
            */
            grabImages = true;
            startPickingLoop();
        }

        private void stageMoverX_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.reportXLabel.Text = xChannel.Position.ToString();
        }

        private void stageMoverY_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.reportYLabel.Text = yChannel.Position.ToString();
        }

        private void stageMoverX_DoWork(object sender, DoWorkEventArgs e)
        {
            decimal xInterval = xJogInput.Value;
            int iterations = (int)jogCount.Value;

            for (int i = 1; i < iterations + 1; i++)
            {
                xChannel.MoveTo(xInterval * i, 60000);
            }
        }

        private void stageMoverY_DoWork(object sender, DoWorkEventArgs e)
        {
            decimal yInterval = yJogInput.Value;
            int iterations = (int)jogCount.Value;

            for (int i = 1; i < iterations + 1; i++)
            {
                yChannel.MoveTo(yInterval * i, 60000);
            }
        }

        private void homingButton_Click(object sender, EventArgs e)
        {
            homingXWorker.RunWorkerAsync();
            homingYWorker.RunWorkerAsync();
        }

        private void homingXWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            xChannel.Home(60000);
        }

        private void homingYWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            yChannel.Home(60000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (homingXWorker.IsBusy || homingYWorker.IsBusy || photographer.IsBusy || stageMoverX.IsBusy || stageMoverY.IsBusy)
            {
                homingXWorker.CancelAsync();
                homingYWorker.CancelAsync();
                photographer.CancelAsync();
                stageMoverX.CancelAsync();
                stageMoverY.CancelAsync();
            }
        }

        private void moveOnlyButton_Click(object sender, EventArgs e)
        {
            stageMoverX.RunWorkerAsync();
            stageMoverY.RunWorkerAsync();
        }

        private void homingXWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.reportXLabel.Text = xChannel.Position.ToString();
        }

        private void homingYWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.reportYLabel.Text = yChannel.Position.ToString();
        }

        private void saveFiles_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            triggerMode.onOff = true;
            camera.SetTriggerMode(triggerMode);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            triggerMode.onOff = false;
            camera.SetTriggerMode(triggerMode);
        }
    }
}