namespace KincoP2L
{
    partial class RegKincoLocator
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
            this.components = new System.ComponentModel.Container();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRackParentLocatorCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nRackAddress = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRackLocatorCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btCreate = new System.Windows.Forms.Button();
            this.txtRackCellCodePrefix = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nColEnd = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nColStart = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nLevelEnd = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nLevelStart = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ckFrontSide = new System.Windows.Forms.CheckBox();
            this.ckBackSide = new System.Windows.Forms.CheckBox();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vERSIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNABLEBILLIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dISABLEBILLIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOCATORIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOWNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOLNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rACKLOCATORIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rACKADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aTTRIBUTE1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aTTRIBUTE2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aTTRIBUTE3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aTTRIBUTE4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aTTRIBUTE5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rackDataSet = new KincoP2L.RackDataSet();
            this.lbSubTotal = new System.Windows.Forms.Label();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nRackAddress)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nColEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nColStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLevelEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLevelStart)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rackDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.label9);
            this.gbInfo.Controls.Add(this.txtRackParentLocatorCode);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.nRackAddress);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.txtRackLocatorCode);
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbInfo.Location = new System.Drawing.Point(0, 0);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(749, 107);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "儲位信息";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(275, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(362, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "這裏只要設置貨架正面的地址編號即可,背面編號在此基礎上自動加1";
            // 
            // txtRackParentLocatorCode
            // 
            this.txtRackParentLocatorCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRackParentLocatorCode.Location = new System.Drawing.Point(187, 79);
            this.txtRackParentLocatorCode.Name = "txtRackParentLocatorCode";
            this.txtRackParentLocatorCode.Size = new System.Drawing.Size(293, 22);
            this.txtRackParentLocatorCode.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "父級儲位信息:";
            // 
            // nRackAddress
            // 
            this.nRackAddress.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nRackAddress.Location = new System.Drawing.Point(187, 22);
            this.nRackAddress.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nRackAddress.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nRackAddress.Name = "nRackAddress";
            this.nRackAddress.Size = new System.Drawing.Size(82, 22);
            this.nRackAddress.TabIndex = 1;
            this.nRackAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nRackAddress.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nRackAddress.ValueChanged += new System.EventHandler(this.nRackAddress_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "貨架地址編號:";
            // 
            // txtRackLocatorCode
            // 
            this.txtRackLocatorCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRackLocatorCode.Location = new System.Drawing.Point(187, 51);
            this.txtRackLocatorCode.Name = "txtRackLocatorCode";
            this.txtRackLocatorCode.Size = new System.Drawing.Size(293, 22);
            this.txtRackLocatorCode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "貨架儲位號:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSave);
            this.groupBox1.Controls.Add(this.ckBackSide);
            this.groupBox1.Controls.Add(this.ckFrontSide);
            this.groupBox1.Controls.Add(this.btCreate);
            this.groupBox1.Controls.Add(this.txtRackCellCodePrefix);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.nColEnd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nColStart);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.nLevelEnd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nLevelStart);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 137);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "批量生成貨位信息";
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(518, 90);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(100, 41);
            this.btCreate.TabIndex = 11;
            this.btCreate.Text = "產生貨位信息";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // txtRackCellCodePrefix
            // 
            this.txtRackCellCodePrefix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRackCellCodePrefix.Location = new System.Drawing.Point(188, 12);
            this.txtRackCellCodePrefix.Name = "txtRackCellCodePrefix";
            this.txtRackCellCodePrefix.Size = new System.Drawing.Size(292, 22);
            this.txtRackCellCodePrefix.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(102, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "貨位編碼前綴:";
            // 
            // nColEnd
            // 
            this.nColEnd.Location = new System.Drawing.Point(423, 67);
            this.nColEnd.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nColEnd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nColEnd.Name = "nColEnd";
            this.nColEnd.Size = new System.Drawing.Size(57, 22);
            this.nColEnd.TabIndex = 8;
            this.nColEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nColEnd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "終止列:";
            // 
            // nColStart
            // 
            this.nColStart.Location = new System.Drawing.Point(187, 67);
            this.nColStart.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nColStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nColStart.Name = "nColStart";
            this.nColStart.Size = new System.Drawing.Size(57, 22);
            this.nColStart.TabIndex = 7;
            this.nColStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nColStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "起始列:";
            // 
            // nLevelEnd
            // 
            this.nLevelEnd.Location = new System.Drawing.Point(423, 38);
            this.nLevelEnd.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nLevelEnd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nLevelEnd.Name = "nLevelEnd";
            this.nLevelEnd.Size = new System.Drawing.Size(57, 22);
            this.nLevelEnd.TabIndex = 6;
            this.nLevelEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nLevelEnd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "終止層:";
            // 
            // nLevelStart
            // 
            this.nLevelStart.Location = new System.Drawing.Point(187, 38);
            this.nLevelStart.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nLevelStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nLevelStart.Name = "nLevelStart";
            this.nLevelStart.Size = new System.Drawing.Size(57, 22);
            this.nLevelStart.TabIndex = 5;
            this.nLevelStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nLevelStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "起始層:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbSubTotal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 660);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 31);
            this.panel1.TabIndex = 2;
            // 
            // btSave
            // 
            this.btSave.Enabled = false;
            this.btSave.Location = new System.Drawing.Point(637, 90);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(100, 41);
            this.btSave.TabIndex = 12;
            this.btSave.Tag = " ";
            this.btSave.Text = "保  存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.vERSIONDataGridViewTextBoxColumn,
            this.eNABLEBILLIDDataGridViewTextBoxColumn,
            this.dISABLEBILLIDDataGridViewTextBoxColumn,
            this.cODEDataGridViewTextBoxColumn,
            this.lOCATORIDDataGridViewTextBoxColumn,
            this.aDDRESSDataGridViewTextBoxColumn,
            this.rOWNUMDataGridViewTextBoxColumn,
            this.cOLNUMDataGridViewTextBoxColumn,
            this.rACKLOCATORIDDataGridViewTextBoxColumn,
            this.rACKADDRESSDataGridViewTextBoxColumn,
            this.aTTRIBUTE1DataGridViewTextBoxColumn,
            this.aTTRIBUTE2DataGridViewTextBoxColumn,
            this.aTTRIBUTE3DataGridViewTextBoxColumn,
            this.aTTRIBUTE4DataGridViewTextBoxColumn,
            this.aTTRIBUTE5DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(749, 416);
            this.dataGridView1.TabIndex = 15;
            // 
            // ckFrontSide
            // 
            this.ckFrontSide.AutoSize = true;
            this.ckFrontSide.Location = new System.Drawing.Point(375, 101);
            this.ckFrontSide.Name = "ckFrontSide";
            this.ckFrontSide.Size = new System.Drawing.Size(48, 16);
            this.ckFrontSide.TabIndex = 9;
            this.ckFrontSide.Text = "正面";
            this.ckFrontSide.UseVisualStyleBackColor = true;
            // 
            // ckBackSide
            // 
            this.ckBackSide.AutoSize = true;
            this.ckBackSide.Location = new System.Drawing.Point(438, 101);
            this.ckBackSide.Name = "ckBackSide";
            this.ckBackSide.Size = new System.Drawing.Size(48, 16);
            this.ckBackSide.TabIndex = 10;
            this.ckBackSide.Text = "背面";
            this.ckBackSide.UseVisualStyleBackColor = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // vERSIONDataGridViewTextBoxColumn
            // 
            this.vERSIONDataGridViewTextBoxColumn.DataPropertyName = "VERSION";
            this.vERSIONDataGridViewTextBoxColumn.HeaderText = "VERSION";
            this.vERSIONDataGridViewTextBoxColumn.Name = "vERSIONDataGridViewTextBoxColumn";
            this.vERSIONDataGridViewTextBoxColumn.Visible = false;
            // 
            // eNABLEBILLIDDataGridViewTextBoxColumn
            // 
            this.eNABLEBILLIDDataGridViewTextBoxColumn.DataPropertyName = "ENABLE_BILL_ID";
            this.eNABLEBILLIDDataGridViewTextBoxColumn.HeaderText = "ENABLE_BILL_ID";
            this.eNABLEBILLIDDataGridViewTextBoxColumn.Name = "eNABLEBILLIDDataGridViewTextBoxColumn";
            this.eNABLEBILLIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dISABLEBILLIDDataGridViewTextBoxColumn
            // 
            this.dISABLEBILLIDDataGridViewTextBoxColumn.DataPropertyName = "DISABLE_BILL_ID";
            this.dISABLEBILLIDDataGridViewTextBoxColumn.HeaderText = "DISABLE_BILL_ID";
            this.dISABLEBILLIDDataGridViewTextBoxColumn.Name = "dISABLEBILLIDDataGridViewTextBoxColumn";
            this.dISABLEBILLIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cODEDataGridViewTextBoxColumn
            // 
            this.cODEDataGridViewTextBoxColumn.DataPropertyName = "CODE";
            this.cODEDataGridViewTextBoxColumn.HeaderText = "CODE";
            this.cODEDataGridViewTextBoxColumn.Name = "cODEDataGridViewTextBoxColumn";
            // 
            // lOCATORIDDataGridViewTextBoxColumn
            // 
            this.lOCATORIDDataGridViewTextBoxColumn.DataPropertyName = "LOCATOR_ID";
            this.lOCATORIDDataGridViewTextBoxColumn.HeaderText = "LOCATOR_ID";
            this.lOCATORIDDataGridViewTextBoxColumn.Name = "lOCATORIDDataGridViewTextBoxColumn";
            this.lOCATORIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // aDDRESSDataGridViewTextBoxColumn
            // 
            this.aDDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.Name = "aDDRESSDataGridViewTextBoxColumn";
            // 
            // rOWNUMDataGridViewTextBoxColumn
            // 
            this.rOWNUMDataGridViewTextBoxColumn.DataPropertyName = "ROW_NUM";
            this.rOWNUMDataGridViewTextBoxColumn.HeaderText = "ROW_NUM";
            this.rOWNUMDataGridViewTextBoxColumn.Name = "rOWNUMDataGridViewTextBoxColumn";
            // 
            // cOLNUMDataGridViewTextBoxColumn
            // 
            this.cOLNUMDataGridViewTextBoxColumn.DataPropertyName = "COL_NUM";
            this.cOLNUMDataGridViewTextBoxColumn.HeaderText = "COL_NUM";
            this.cOLNUMDataGridViewTextBoxColumn.Name = "cOLNUMDataGridViewTextBoxColumn";
            // 
            // rACKLOCATORIDDataGridViewTextBoxColumn
            // 
            this.rACKLOCATORIDDataGridViewTextBoxColumn.DataPropertyName = "RACK_LOCATOR_ID";
            this.rACKLOCATORIDDataGridViewTextBoxColumn.HeaderText = "RACK_LOCATOR_ID";
            this.rACKLOCATORIDDataGridViewTextBoxColumn.Name = "rACKLOCATORIDDataGridViewTextBoxColumn";
            this.rACKLOCATORIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // rACKADDRESSDataGridViewTextBoxColumn
            // 
            this.rACKADDRESSDataGridViewTextBoxColumn.DataPropertyName = "RACK_ADDRESS";
            this.rACKADDRESSDataGridViewTextBoxColumn.HeaderText = "RACK_ADDRESS";
            this.rACKADDRESSDataGridViewTextBoxColumn.Name = "rACKADDRESSDataGridViewTextBoxColumn";
            // 
            // aTTRIBUTE1DataGridViewTextBoxColumn
            // 
            this.aTTRIBUTE1DataGridViewTextBoxColumn.DataPropertyName = "ATTRIBUTE1";
            this.aTTRIBUTE1DataGridViewTextBoxColumn.HeaderText = "ATTRIBUTE1";
            this.aTTRIBUTE1DataGridViewTextBoxColumn.Name = "aTTRIBUTE1DataGridViewTextBoxColumn";
            this.aTTRIBUTE1DataGridViewTextBoxColumn.Visible = false;
            // 
            // aTTRIBUTE2DataGridViewTextBoxColumn
            // 
            this.aTTRIBUTE2DataGridViewTextBoxColumn.DataPropertyName = "ATTRIBUTE2";
            this.aTTRIBUTE2DataGridViewTextBoxColumn.HeaderText = "ATTRIBUTE2";
            this.aTTRIBUTE2DataGridViewTextBoxColumn.Name = "aTTRIBUTE2DataGridViewTextBoxColumn";
            this.aTTRIBUTE2DataGridViewTextBoxColumn.Visible = false;
            // 
            // aTTRIBUTE3DataGridViewTextBoxColumn
            // 
            this.aTTRIBUTE3DataGridViewTextBoxColumn.DataPropertyName = "ATTRIBUTE3";
            this.aTTRIBUTE3DataGridViewTextBoxColumn.HeaderText = "ATTRIBUTE3";
            this.aTTRIBUTE3DataGridViewTextBoxColumn.Name = "aTTRIBUTE3DataGridViewTextBoxColumn";
            this.aTTRIBUTE3DataGridViewTextBoxColumn.Visible = false;
            // 
            // aTTRIBUTE4DataGridViewTextBoxColumn
            // 
            this.aTTRIBUTE4DataGridViewTextBoxColumn.DataPropertyName = "ATTRIBUTE4";
            this.aTTRIBUTE4DataGridViewTextBoxColumn.HeaderText = "ATTRIBUTE4";
            this.aTTRIBUTE4DataGridViewTextBoxColumn.Name = "aTTRIBUTE4DataGridViewTextBoxColumn";
            this.aTTRIBUTE4DataGridViewTextBoxColumn.Visible = false;
            // 
            // aTTRIBUTE5DataGridViewTextBoxColumn
            // 
            this.aTTRIBUTE5DataGridViewTextBoxColumn.DataPropertyName = "ATTRIBUTE5";
            this.aTTRIBUTE5DataGridViewTextBoxColumn.HeaderText = "ATTRIBUTE5";
            this.aTTRIBUTE5DataGridViewTextBoxColumn.Name = "aTTRIBUTE5DataGridViewTextBoxColumn";
            this.aTTRIBUTE5DataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingSource
            // 
            this.bindingSource.DataMember = "IMS_INTELLIGENT_RACK_CELL_INFO";
            this.bindingSource.DataSource = this.rackDataSet;
            // 
            // rackDataSet
            // 
            this.rackDataSet.DataSetName = "RackDataSet";
            this.rackDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbSubTotal
            // 
            this.lbSubTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSubTotal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbSubTotal.ForeColor = System.Drawing.Color.Red;
            this.lbSubTotal.Location = new System.Drawing.Point(0, 0);
            this.lbSubTotal.Name = "lbSubTotal";
            this.lbSubTotal.Size = new System.Drawing.Size(749, 31);
            this.lbSubTotal.TabIndex = 0;
            this.lbSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RegKincoLocator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 691);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegKincoLocator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "步科電子貨架註冊";
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nRackAddress)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nColEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nColStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLevelEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLevelStart)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rackDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.NumericUpDown nRackAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRackLocatorCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRackParentLocatorCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nColEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nColStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nLevelEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nLevelStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.TextBox txtRackCellCodePrefix;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vERSIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNABLEBILLIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dISABLEBILLIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOCATORIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOWNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOLNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rACKLOCATORIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rACKADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aTTRIBUTE1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aTTRIBUTE2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aTTRIBUTE3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aTTRIBUTE4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aTTRIBUTE5DataGridViewTextBoxColumn;
        private RackDataSet rackDataSet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.CheckBox ckBackSide;
        private System.Windows.Forms.CheckBox ckFrontSide;
        private System.Windows.Forms.Label lbSubTotal;
    }
}