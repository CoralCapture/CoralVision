namespace CoralVision
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCameraControl = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelImageSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelFrameRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTimestamp = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.photographer = new System.ComponentModel.BackgroundWorker();
            this.recordButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cancelRecordButton = new System.Windows.Forms.Button();
            this.frameCount = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.jogCount = new System.Windows.Forms.NumericUpDown();
            this.xInput = new System.Windows.Forms.Label();
            this.yInput = new System.Windows.Forms.Label();
            this.xJogInput = new System.Windows.Forms.NumericUpDown();
            this.yJogInput = new System.Windows.Forms.NumericUpDown();
            this.recAndMove = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.reportYLabel = new System.Windows.Forms.TextBox();
            this.reportXLabel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.homingButton = new System.Windows.Forms.Button();
            this.moveOnlyButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.stageWorker = new System.ComponentModel.BackgroundWorker();
            this.stageMoverX = new System.ComponentModel.BackgroundWorker();
            this.stageMoverY = new System.ComponentModel.BackgroundWorker();
            this.homingXWorker = new System.ComponentModel.BackgroundWorker();
            this.homingYWorker = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xJogInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yJogInput)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonStart,
            this.toolStripSeparator3,
            this.toolStripButtonStop,
            this.toolStripSeparator1,
            this.toolStripButtonCameraControl,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(937, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonStart
            // 
            this.toolStripButtonStart.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonStart.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStart.Image")));
            this.toolStripButtonStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStart.Name = "toolStripButtonStart";
            this.toolStripButtonStart.Size = new System.Drawing.Size(115, 24);
            this.toolStripButtonStart.Tag = "";
            this.toolStripButtonStart.Text = "&Start Feed";
            this.toolStripButtonStart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripButtonStart.Click += new System.EventHandler(this.toolStripButtonStart_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonStop
            // 
            this.toolStripButtonStop.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonStop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStop.Image")));
            this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStop.Name = "toolStripButtonStop";
            this.toolStripButtonStop.Size = new System.Drawing.Size(124, 24);
            this.toolStripButtonStop.Text = "&Pause Feed";
            this.toolStripButtonStop.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripButtonStop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripButtonStop.Click += new System.EventHandler(this.toolStripButtonStop_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonCameraControl
            // 
            this.toolStripButtonCameraControl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonCameraControl.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCameraControl.Image")));
            this.toolStripButtonCameraControl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCameraControl.Name = "toolStripButtonCameraControl";
            this.toolStripButtonCameraControl.Size = new System.Drawing.Size(297, 24);
            this.toolStripButtonCameraControl.Text = "Set Camera && Trigger Parameters";
            this.toolStripButtonCameraControl.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripButtonCameraControl.Click += new System.EventHandler(this.toolStripButtonCameraControl_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelImageSize,
            this.toolStripStatusLabelFrameRate,
            this.toolStripStatusLabelTimestamp});
            this.statusStrip1.Location = new System.Drawing.Point(0, 842);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(937, 23);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelImageSize
            // 
            this.toolStripStatusLabelImageSize.Name = "toolStripStatusLabelImageSize";
            this.toolStripStatusLabelImageSize.Size = new System.Drawing.Size(112, 17);
            this.toolStripStatusLabelImageSize.Text = "Image Size: 0x0";
            // 
            // toolStripStatusLabelFrameRate
            // 
            this.toolStripStatusLabelFrameRate.Name = "toolStripStatusLabelFrameRate";
            this.toolStripStatusLabelFrameRate.Size = new System.Drawing.Size(135, 17);
            this.toolStripStatusLabelFrameRate.Text = "Frequency: 0.00 Hz";
            // 
            // toolStripStatusLabelTimestamp
            // 
            this.toolStripStatusLabelTimestamp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelTimestamp.Name = "toolStripStatusLabelTimestamp";
            this.toolStripStatusLabelTimestamp.Size = new System.Drawing.Size(159, 17);
            this.toolStripStatusLabelTimestamp.Text = "Camera Is Not Enabled";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(937, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(49, 21);
            this.fileToolStripMenuItem.Text = "Quit";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.exitToolStripMenuItem.Text = "Close CoralCapture";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(9, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 514);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(5, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(903, 502);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 582);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Camera View Port";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // photographer
            // 
            this.photographer.WorkerReportsProgress = true;
            this.photographer.WorkerSupportsCancellation = true;
            this.photographer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.photographer_DoWork);
            this.photographer.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.photographer_ProgressChanged);
            this.photographer.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.photographer_RunWorkerCompleted);
            // 
            // recordButton
            // 
            this.recordButton.Image = ((System.Drawing.Image)(resources.GetObject("recordButton.Image")));
            this.recordButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recordButton.Location = new System.Drawing.Point(16, 90);
            this.recordButton.Margin = new System.Windows.Forms.Padding(4);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(101, 38);
            this.recordButton.TabIndex = 6;
            this.recordButton.Text = "&Capture";
            this.recordButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.recordButton.UseVisualStyleBackColor = true;
            this.recordButton.Click += new System.EventHandler(this.recordButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(19, 816);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(240, 12);
            this.progressBar1.TabIndex = 7;
            // 
            // cancelRecordButton
            // 
            this.cancelRecordButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelRecordButton.Image")));
            this.cancelRecordButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelRecordButton.Location = new System.Drawing.Point(135, 90);
            this.cancelRecordButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelRecordButton.Name = "cancelRecordButton";
            this.cancelRecordButton.Size = new System.Drawing.Size(89, 38);
            this.cancelRecordButton.TabIndex = 8;
            this.cancelRecordButton.Text = "&Cancel";
            this.cancelRecordButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelRecordButton.UseVisualStyleBackColor = true;
            this.cancelRecordButton.Click += new System.EventHandler(this.cancelRecordButton_Click);
            // 
            // frameCount
            // 
            this.frameCount.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frameCount.Location = new System.Drawing.Point(135, 54);
            this.frameCount.Margin = new System.Windows.Forms.Padding(4);
            this.frameCount.Name = "frameCount";
            this.frameCount.Size = new System.Drawing.Size(89, 23);
            this.frameCount.TabIndex = 9;
            this.frameCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "JPG",
            "PNG",
            "BMP",
            "PGM"});
            this.comboBox1.Location = new System.Drawing.Point(135, 15);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(89, 24);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Tag = "Change File Format";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "File Format";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Frame Count";
            // 
            // connectButton
            // 
            this.connectButton.Image = ((System.Drawing.Image)(resources.GetObject("connectButton.Image")));
            this.connectButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.connectButton.Location = new System.Drawing.Point(11, 11);
            this.connectButton.Margin = new System.Windows.Forms.Padding(4);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(179, 37);
            this.connectButton.TabIndex = 13;
            this.connectButton.Text = "&Connect to Stage";
            this.connectButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Jog Count";
            // 
            // jogCount
            // 
            this.jogCount.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jogCount.Location = new System.Drawing.Point(327, 12);
            this.jogCount.Margin = new System.Windows.Forms.Padding(4);
            this.jogCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.jogCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.jogCount.Name = "jogCount";
            this.jogCount.Size = new System.Drawing.Size(133, 23);
            this.jogCount.TabIndex = 14;
            this.jogCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.jogCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // xInput
            // 
            this.xInput.AutoSize = true;
            this.xInput.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xInput.Location = new System.Drawing.Point(212, 41);
            this.xInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xInput.Name = "xInput";
            this.xInput.Size = new System.Drawing.Size(86, 18);
            this.xInput.TabIndex = 16;
            this.xInput.Text = "X Jog [mm]";
            // 
            // yInput
            // 
            this.yInput.AutoSize = true;
            this.yInput.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yInput.Location = new System.Drawing.Point(212, 70);
            this.yInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yInput.Name = "yInput";
            this.yInput.Size = new System.Drawing.Size(86, 18);
            this.yInput.TabIndex = 17;
            this.yInput.Text = "Y Jog [mm]";
            // 
            // xJogInput
            // 
            this.xJogInput.DecimalPlaces = 3;
            this.xJogInput.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xJogInput.Location = new System.Drawing.Point(327, 41);
            this.xJogInput.Margin = new System.Windows.Forms.Padding(4);
            this.xJogInput.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.xJogInput.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            -2147483648});
            this.xJogInput.Name = "xJogInput";
            this.xJogInput.Size = new System.Drawing.Size(133, 23);
            this.xJogInput.TabIndex = 18;
            // 
            // yJogInput
            // 
            this.yJogInput.DecimalPlaces = 3;
            this.yJogInput.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yJogInput.Location = new System.Drawing.Point(327, 69);
            this.yJogInput.Margin = new System.Windows.Forms.Padding(4);
            this.yJogInput.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.yJogInput.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            -2147483648});
            this.yJogInput.Name = "yJogInput";
            this.yJogInput.Size = new System.Drawing.Size(133, 23);
            this.yJogInput.TabIndex = 19;
            // 
            // recAndMove
            // 
            this.recAndMove.BackColor = System.Drawing.SystemColors.ControlLight;
            this.recAndMove.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recAndMove.Image = ((System.Drawing.Image)(resources.GetObject("recAndMove.Image")));
            this.recAndMove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recAndMove.Location = new System.Drawing.Point(11, 58);
            this.recAndMove.Margin = new System.Windows.Forms.Padding(4);
            this.recAndMove.Name = "recAndMove";
            this.recAndMove.Size = new System.Drawing.Size(179, 38);
            this.recAndMove.TabIndex = 20;
            this.recAndMove.Text = "&Start Sequence";
            this.recAndMove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.recAndMove.UseVisualStyleBackColor = false;
            this.recAndMove.Click += new System.EventHandler(this.recAndMove_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(11, 133);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 38);
            this.button2.TabIndex = 21;
            this.button2.Text = "&Cancel Sequence";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.frameCount);
            this.panel2.Controls.Add(this.cancelRecordButton);
            this.panel2.Controls.Add(this.recordButton);
            this.panel2.Location = new System.Drawing.Point(19, 640);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 168);
            this.panel2.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Strobe Off";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 25);
            this.button3.TabIndex = 26;
            this.button3.Text = "Strobe On";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.reportYLabel);
            this.panel3.Controls.Add(this.reportXLabel);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.homingButton);
            this.panel3.Controls.Add(this.moveOnlyButton);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.recAndMove);
            this.panel3.Controls.Add(this.yJogInput);
            this.panel3.Controls.Add(this.xJogInput);
            this.panel3.Controls.Add(this.yInput);
            this.panel3.Controls.Add(this.xInput);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.jogCount);
            this.panel3.Controls.Add(this.connectButton);
            this.panel3.Location = new System.Drawing.Point(427, 640);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(492, 186);
            this.panel3.TabIndex = 23;
            // 
            // reportYLabel
            // 
            this.reportYLabel.Enabled = false;
            this.reportYLabel.Location = new System.Drawing.Point(397, 98);
            this.reportYLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportYLabel.Name = "reportYLabel";
            this.reportYLabel.Size = new System.Drawing.Size(63, 22);
            this.reportYLabel.TabIndex = 26;
            // 
            // reportXLabel
            // 
            this.reportXLabel.Enabled = false;
            this.reportXLabel.Location = new System.Drawing.Point(327, 98);
            this.reportXLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportXLabel.Name = "reportXLabel";
            this.reportXLabel.Size = new System.Drawing.Size(67, 22);
            this.reportXLabel.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(212, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "Position (X,Y)";
            // 
            // homingButton
            // 
            this.homingButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homingButton.Image = ((System.Drawing.Image)(resources.GetObject("homingButton.Image")));
            this.homingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homingButton.Location = new System.Drawing.Point(327, 133);
            this.homingButton.Margin = new System.Windows.Forms.Padding(4);
            this.homingButton.Name = "homingButton";
            this.homingButton.Size = new System.Drawing.Size(133, 38);
            this.homingButton.TabIndex = 23;
            this.homingButton.Text = "&Home";
            this.homingButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homingButton.UseVisualStyleBackColor = true;
            this.homingButton.Click += new System.EventHandler(this.homingButton_Click);
            // 
            // moveOnlyButton
            // 
            this.moveOnlyButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveOnlyButton.Image = ((System.Drawing.Image)(resources.GetObject("moveOnlyButton.Image")));
            this.moveOnlyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.moveOnlyButton.Location = new System.Drawing.Point(213, 133);
            this.moveOnlyButton.Margin = new System.Windows.Forms.Padding(4);
            this.moveOnlyButton.Name = "moveOnlyButton";
            this.moveOnlyButton.Size = new System.Drawing.Size(105, 38);
            this.moveOnlyButton.TabIndex = 22;
            this.moveOnlyButton.Text = "&Move";
            this.moveOnlyButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.moveOnlyButton.UseVisualStyleBackColor = true;
            this.moveOnlyButton.Click += new System.EventHandler(this.moveOnlyButton_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(19, 610);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(901, 1);
            this.label5.TabIndex = 24;
            // 
            // stageWorker
            // 
            this.stageWorker.WorkerReportsProgress = true;
            this.stageWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.stageWorker_DoWork);
            this.stageWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.stageWorker_ProgressChanged);
            this.stageWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.stageWorker_RunWorkerCompleted);
            // 
            // stageMoverX
            // 
            this.stageMoverX.WorkerReportsProgress = true;
            this.stageMoverX.WorkerSupportsCancellation = true;
            this.stageMoverX.DoWork += new System.ComponentModel.DoWorkEventHandler(this.stageMoverX_DoWork);
            this.stageMoverX.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.stageMoverX_RunWorkerCompleted);
            // 
            // stageMoverY
            // 
            this.stageMoverY.WorkerReportsProgress = true;
            this.stageMoverY.WorkerSupportsCancellation = true;
            this.stageMoverY.DoWork += new System.ComponentModel.DoWorkEventHandler(this.stageMoverY_DoWork);
            this.stageMoverY.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.stageMoverY_RunWorkerCompleted);
            // 
            // homingXWorker
            // 
            this.homingXWorker.WorkerSupportsCancellation = true;
            this.homingXWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.homingXWorker_DoWork);
            this.homingXWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.homingXWorker_RunWorkerCompleted);
            // 
            // homingYWorker
            // 
            this.homingYWorker.WorkerSupportsCancellation = true;
            this.homingYWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.homingYWorker_DoWork);
            this.homingYWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.homingYWorker_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 865);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xJogInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yJogInput)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTimestamp;
        private System.Windows.Forms.ToolStripButton toolStripButtonStart;
        private System.Windows.Forms.ToolStripButton toolStripButtonStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonCameraControl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelImageSize;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFrameRate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button cancelRecordButton;
        private System.Windows.Forms.NumericUpDown frameCount;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown jogCount;
        private System.Windows.Forms.Label xInput;
        private System.Windows.Forms.Label yInput;
        private System.Windows.Forms.NumericUpDown xJogInput;
        private System.Windows.Forms.NumericUpDown yJogInput;
        private System.Windows.Forms.Button recAndMove;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker stageWorker;
        private System.ComponentModel.BackgroundWorker stageMoverX;
        private System.Windows.Forms.Button moveOnlyButton;
        private System.ComponentModel.BackgroundWorker stageMoverY;
        private System.Windows.Forms.Button homingButton;
        private System.ComponentModel.BackgroundWorker homingXWorker;
        private System.ComponentModel.BackgroundWorker homingYWorker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox reportYLabel;
        private System.Windows.Forms.TextBox reportXLabel;
        public System.ComponentModel.BackgroundWorker photographer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

