namespace Convert2WebpGUI
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.dgvFileList = new System.Windows.Forms.DataGridView();
            this.colOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.selectFiles = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.radSource = new System.Windows.Forms.RadioButton();
            this.radOther = new System.Windows.Forms.RadioButton();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.saveFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnOption = new System.Windows.Forms.Button();
            this.groupMain = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupOption = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.nmDeFilter = new System.Windows.Forms.NumericUpDown();
            this.barDeFilter = new System.Windows.Forms.TrackBar();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nmMethod = new System.Windows.Forms.NumericUpDown();
            this.barMethod = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nmSharpness = new System.Windows.Forms.NumericUpDown();
            this.barSharpness = new System.Windows.Forms.TrackBar();
            this.cbPreset = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nmQuantity = new System.Windows.Forms.NumericUpDown();
            this.barQuanlity = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.radLossy = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radLossless = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileList)).BeginInit();
            this.groupMain.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDeFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDeFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMethod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barMethod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSharpness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barSharpness)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barQuanlity)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFileList
            // 
            this.dgvFileList.AllowUserToAddRows = false;
            this.dgvFileList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon;
            this.dgvFileList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFileList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvFileList.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvFileList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFileList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFileList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrder,
            this.colFile,
            this.colResult});
            this.dgvFileList.GridColor = System.Drawing.SystemColors.Control;
            this.dgvFileList.Location = new System.Drawing.Point(10, 72);
            this.dgvFileList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvFileList.Name = "dgvFileList";
            this.dgvFileList.ReadOnly = true;
            this.dgvFileList.RowHeadersVisible = false;
            this.dgvFileList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvFileList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.dgvFileList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            this.dgvFileList.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFileList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvFileList.Size = new System.Drawing.Size(689, 435);
            this.dgvFileList.TabIndex = 0;
            // 
            // colOrder
            // 
            this.colOrder.HeaderText = "Order";
            this.colOrder.MinimumWidth = 50;
            this.colOrder.Name = "colOrder";
            this.colOrder.ReadOnly = true;
            // 
            // colFile
            // 
            this.colFile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFile.HeaderText = "File";
            this.colFile.Name = "colFile";
            this.colFile.ReadOnly = true;
            // 
            // colResult
            // 
            this.colResult.HeaderText = "Result";
            this.colResult.MinimumWidth = 100;
            this.colResult.Name = "colResult";
            this.colResult.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(5, 74);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 35);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "&Add File";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvert.Location = new System.Drawing.Point(5, 124);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(112, 35);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "&Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(5, 174);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 35);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clea&r";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(5, 274);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 35);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // selectFiles
            // 
            this.selectFiles.Filter = "Image files (*.jpg, *.jpeg, *.png) |*.jpg; *.jpeg; *.png";
            this.selectFiles.Multiselect = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Output Folder:";
            // 
            // radSource
            // 
            this.radSource.AutoSize = true;
            this.radSource.Checked = true;
            this.radSource.Location = new System.Drawing.Point(126, 26);
            this.radSource.Name = "radSource";
            this.radSource.Size = new System.Drawing.Size(169, 24);
            this.radSource.TabIndex = 6;
            this.radSource.TabStop = true;
            this.radSource.Text = "Same as Source file";
            this.radSource.UseVisualStyleBackColor = true;
            // 
            // radOther
            // 
            this.radOther.AutoSize = true;
            this.radOther.Location = new System.Drawing.Point(301, 27);
            this.radOther.Name = "radOther";
            this.radOther.Size = new System.Drawing.Size(165, 24);
            this.radOther.TabIndex = 7;
            this.radOther.Text = "Select an Directory:";
            this.radOther.UseVisualStyleBackColor = true;
            this.radOther.CheckedChanged += new System.EventHandler(this.radOther_CheckedChanged);
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputFolder.Location = new System.Drawing.Point(472, 28);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.Size = new System.Drawing.Size(227, 26);
            this.txtOutputFolder.TabIndex = 8;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectFolder.Enabled = false;
            this.btnSelectFolder.Location = new System.Drawing.Point(5, 24);
            this.btnSelectFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(112, 35);
            this.btnSelectFolder.TabIndex = 9;
            this.btnSelectFolder.Text = "&Select Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnOption
            // 
            this.btnOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOption.Location = new System.Drawing.Point(5, 224);
            this.btnOption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(112, 35);
            this.btnOption.TabIndex = 10;
            this.btnOption.Text = "&Option";
            this.btnOption.UseVisualStyleBackColor = true;
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // groupMain
            // 
            this.groupMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupMain.Controls.Add(this.panel3);
            this.groupMain.Controls.Add(this.dgvFileList);
            this.groupMain.Controls.Add(this.txtOutputFolder);
            this.groupMain.Controls.Add(this.radOther);
            this.groupMain.Controls.Add(this.radSource);
            this.groupMain.Controls.Add(this.label1);
            this.groupMain.Location = new System.Drawing.Point(3, -5);
            this.groupMain.Name = "groupMain";
            this.groupMain.Size = new System.Drawing.Size(826, 505);
            this.groupMain.TabIndex = 11;
            this.groupMain.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel3.Controls.Add(this.btnSelectFolder);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.btnOption);
            this.panel3.Controls.Add(this.btnConvert);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Location = new System.Drawing.Point(702, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(126, 520);
            this.panel3.TabIndex = 12;
            // 
            // groupOption
            // 
            this.groupOption.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupOption.Controls.Add(this.label13);
            this.groupOption.Controls.Add(this.label14);
            this.groupOption.Controls.Add(this.nmDeFilter);
            this.groupOption.Controls.Add(this.barDeFilter);
            this.groupOption.Controls.Add(this.label15);
            this.groupOption.Controls.Add(this.label11);
            this.groupOption.Controls.Add(this.label12);
            this.groupOption.Controls.Add(this.nmMethod);
            this.groupOption.Controls.Add(this.barMethod);
            this.groupOption.Controls.Add(this.label10);
            this.groupOption.Controls.Add(this.label9);
            this.groupOption.Controls.Add(this.label8);
            this.groupOption.Controls.Add(this.nmSharpness);
            this.groupOption.Controls.Add(this.barSharpness);
            this.groupOption.Controls.Add(this.cbPreset);
            this.groupOption.Controls.Add(this.label7);
            this.groupOption.Controls.Add(this.label6);
            this.groupOption.Controls.Add(this.panel1);
            this.groupOption.Controls.Add(this.label5);
            this.groupOption.Controls.Add(this.label4);
            this.groupOption.Controls.Add(this.nmQuantity);
            this.groupOption.Controls.Add(this.barQuanlity);
            this.groupOption.Controls.Add(this.label3);
            this.groupOption.Controls.Add(this.radLossy);
            this.groupOption.Controls.Add(this.label2);
            this.groupOption.Controls.Add(this.radLossless);
            this.groupOption.Location = new System.Drawing.Point(3, 0);
            this.groupOption.Name = "groupOption";
            this.groupOption.Size = new System.Drawing.Size(825, 502);
            this.groupOption.TabIndex = 12;
            this.groupOption.TabStop = false;
            this.groupOption.Text = "Basic Option";
            this.groupOption.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.LightCoral;
            this.label13.Location = new System.Drawing.Point(523, 283);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 16);
            this.label13.TabIndex = 37;
            this.label13.Text = "smoother picture";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.LightCoral;
            this.label14.Location = new System.Drawing.Point(373, 283);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 16);
            this.label14.TabIndex = 36;
            this.label14.Text = "no filtering";
            // 
            // nmDeFilter
            // 
            this.nmDeFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nmDeFilter.Location = new System.Drawing.Point(649, 259);
            this.nmDeFilter.Name = "nmDeFilter";
            this.nmDeFilter.Size = new System.Drawing.Size(50, 26);
            this.nmDeFilter.TabIndex = 35;
            // 
            // barDeFilter
            // 
            this.barDeFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barDeFilter.Location = new System.Drawing.Point(368, 259);
            this.barDeFilter.Maximum = 100;
            this.barDeFilter.Name = "barDeFilter";
            this.barDeFilter.Size = new System.Drawing.Size(271, 45);
            this.barDeFilter.TabIndex = 34;
            this.barDeFilter.TickStyle = System.Windows.Forms.TickStyle.None;
            this.barDeFilter.ValueChanged += new System.EventHandler(this.barDeFilter_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Gray;
            this.label15.Location = new System.Drawing.Point(368, 226);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(211, 20);
            this.label15.TabIndex = 33;
            this.label15.Text = "Deblocking filter strength";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.LightCoral;
            this.label11.Location = new System.Drawing.Point(176, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 16);
            this.label11.TabIndex = 32;
            this.label11.Text = "slowest";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.LightCoral;
            this.label12.Location = new System.Drawing.Point(11, 283);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 16);
            this.label12.TabIndex = 31;
            this.label12.Text = "fastest";
            // 
            // nmMethod
            // 
            this.nmMethod.Location = new System.Drawing.Point(245, 259);
            this.nmMethod.Name = "nmMethod";
            this.nmMethod.Size = new System.Drawing.Size(50, 26);
            this.nmMethod.TabIndex = 30;
            // 
            // barMethod
            // 
            this.barMethod.Location = new System.Drawing.Point(6, 259);
            this.barMethod.Maximum = 6;
            this.barMethod.Name = "barMethod";
            this.barMethod.Size = new System.Drawing.Size(233, 45);
            this.barMethod.TabIndex = 29;
            this.barMethod.TickStyle = System.Windows.Forms.TickStyle.None;
            this.barMethod.ValueChanged += new System.EventHandler(this.barMethod_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(6, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "Compression method";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightCoral;
            this.label9.Location = new System.Drawing.Point(566, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "least sharp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightCoral;
            this.label8.Location = new System.Drawing.Point(377, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "sharpest";
            // 
            // nmSharpness
            // 
            this.nmSharpness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nmSharpness.Location = new System.Drawing.Point(649, 166);
            this.nmSharpness.Name = "nmSharpness";
            this.nmSharpness.Size = new System.Drawing.Size(50, 26);
            this.nmSharpness.TabIndex = 25;
            // 
            // barSharpness
            // 
            this.barSharpness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barSharpness.Location = new System.Drawing.Point(372, 170);
            this.barSharpness.Maximum = 7;
            this.barSharpness.Name = "barSharpness";
            this.barSharpness.Size = new System.Drawing.Size(271, 45);
            this.barSharpness.TabIndex = 24;
            this.barSharpness.TickStyle = System.Windows.Forms.TickStyle.None;
            this.barSharpness.ValueChanged += new System.EventHandler(this.barSharpness_ValueChanged);
            // 
            // cbPreset
            // 
            this.cbPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPreset.FormattingEnabled = true;
            this.cbPreset.Items.AddRange(new object[] {
            "default",
            "photo",
            "picture",
            "drawing",
            "icon",
            "text"});
            this.cbPreset.Location = new System.Drawing.Point(6, 170);
            this.cbPreset.Name = "cbPreset";
            this.cbPreset.Size = new System.Drawing.Size(289, 28);
            this.cbPreset.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(368, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Sharpness";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(6, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Preset Setting";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Location = new System.Drawing.Point(706, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 512);
            this.panel1.TabIndex = 20;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(3, 8);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 35);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Sav&e";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(3, 49);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Can&cel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightCoral;
            this.label5.Location = new System.Drawing.Point(597, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "better";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightCoral;
            this.label4.Location = new System.Drawing.Point(212, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "lower quanlity (smaller the size)";
            // 
            // nmQuantity
            // 
            this.nmQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nmQuantity.Location = new System.Drawing.Point(649, 75);
            this.nmQuantity.Name = "nmQuantity";
            this.nmQuantity.Size = new System.Drawing.Size(50, 26);
            this.nmQuantity.TabIndex = 17;
            // 
            // barQuanlity
            // 
            this.barQuanlity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barQuanlity.Location = new System.Drawing.Point(207, 79);
            this.barQuanlity.Maximum = 100;
            this.barQuanlity.Name = "barQuanlity";
            this.barQuanlity.Size = new System.Drawing.Size(436, 45);
            this.barQuanlity.TabIndex = 16;
            this.barQuanlity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.barQuanlity.ValueChanged += new System.EventHandler(this.barQuanlity_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Quanlity factor";
            // 
            // radLossy
            // 
            this.radLossy.AutoSize = true;
            this.radLossy.Checked = true;
            this.radLossy.Location = new System.Drawing.Point(372, 32);
            this.radLossy.Name = "radLossy";
            this.radLossy.Size = new System.Drawing.Size(68, 24);
            this.radLossy.TabIndex = 14;
            this.radLossy.TabStop = true;
            this.radLossy.Text = "Lossy";
            this.radLossy.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Compression mode";
            // 
            // radLossless
            // 
            this.radLossless.AutoSize = true;
            this.radLossless.Location = new System.Drawing.Point(216, 32);
            this.radLossless.Name = "radLossless";
            this.radLossless.Size = new System.Drawing.Size(89, 24);
            this.radLossless.TabIndex = 12;
            this.radLossless.Text = "Lossless";
            this.radLossless.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 513);
            this.Controls.Add(this.groupOption);
            this.Controls.Add(this.groupMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convert Image to Webp GUI TOOL";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileList)).EndInit();
            this.groupMain.ResumeLayout(false);
            this.groupMain.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupOption.ResumeLayout(false);
            this.groupOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDeFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDeFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMethod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barMethod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSharpness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barSharpness)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barQuanlity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFileList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResult;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.OpenFileDialog selectFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radSource;
        private System.Windows.Forms.RadioButton radOther;
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.FolderBrowserDialog saveFolder;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.GroupBox groupMain;
        private System.Windows.Forms.GroupBox groupOption;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmQuantity;
        private System.Windows.Forms.TrackBar barQuanlity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radLossy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radLossless;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nmDeFilter;
        private System.Windows.Forms.TrackBar barDeFilter;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nmMethod;
        private System.Windows.Forms.TrackBar barMethod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nmSharpness;
        private System.Windows.Forms.TrackBar barSharpness;
        private System.Windows.Forms.ComboBox cbPreset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

