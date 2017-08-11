namespace P2L
{
    partial class LedFlashParamPicker
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
            this.spFlashCount = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.spOnTime = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.spOffTime = new DevExpress.XtraEditors.SpinEdit();
            this.btOK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.spFlashCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spOnTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spOffTime.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // spFlashCount
            // 
            this.spFlashCount.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spFlashCount.Location = new System.Drawing.Point(125, 31);
            this.spFlashCount.Name = "spFlashCount";
            this.spFlashCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spFlashCount.Properties.MaxValue = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.spFlashCount.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spFlashCount.Size = new System.Drawing.Size(128, 20);
            this.spFlashCount.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "閃爍次數";
            // 
            // spOnTime
            // 
            this.spOnTime.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spOnTime.Location = new System.Drawing.Point(125, 76);
            this.spOnTime.Name = "spOnTime";
            this.spOnTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spOnTime.Properties.MaxValue = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.spOnTime.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spOnTime.Size = new System.Drawing.Size(128, 20);
            this.spOnTime.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(27, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "亮燈持續時間";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(27, 122);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(72, 14);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "滅燈持續時間";
            // 
            // spOffTime
            // 
            this.spOffTime.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spOffTime.Location = new System.Drawing.Point(125, 119);
            this.spOffTime.Name = "spOffTime";
            this.spOffTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spOffTime.Properties.MaxValue = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.spOffTime.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spOffTime.Size = new System.Drawing.Size(128, 20);
            this.spOffTime.TabIndex = 5;
            // 
            // btOK
            // 
            this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOK.Location = new System.Drawing.Point(166, 167);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(87, 44);
            this.btOK.TabIndex = 8;
            this.btOK.Text = "確    定";
            // 
            // LedFlashParamPicker
            // 
            this.AcceptButton = this.btOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 225);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.spOffTime);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.spOnTime);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.spFlashCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LedFlashParamPicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "參數設定";
            ((System.ComponentModel.ISupportInitialize)(this.spFlashCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spOnTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spOffTime.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SpinEdit spFlashCount;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit spOnTime;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SpinEdit spOffTime;
        private DevExpress.XtraEditors.SimpleButton btOK;
    }
}