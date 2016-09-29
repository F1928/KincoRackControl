namespace KincoP2L
{
    partial class RackLed
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btLedCommand = new DevExpress.XtraEditors.SimpleButton();
            this.lbAddress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btLedCommand
            // 
            this.btLedCommand.Appearance.Options.UseTextOptions = true;
            this.btLedCommand.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btLedCommand.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.btLedCommand.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btLedCommand.Dock = System.Windows.Forms.DockStyle.Top;
            this.btLedCommand.ImageIndex = 0;
            this.btLedCommand.Location = new System.Drawing.Point(0, 0);
            this.btLedCommand.Margin = new System.Windows.Forms.Padding(0);
            this.btLedCommand.Name = "btLedCommand";
            this.btLedCommand.Size = new System.Drawing.Size(34, 31);
            this.btLedCommand.TabIndex = 0;
            this.btLedCommand.Click += new System.EventHandler(this.btLedCommand_Click);
            // 
            // lbAddress
            // 
            this.lbAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAddress.Location = new System.Drawing.Point(0, 31);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(34, 15);
            this.lbAddress.TabIndex = 1;
            this.lbAddress.Text = "150";
            this.lbAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RackLed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.btLedCommand);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "RackLed";
            this.Size = new System.Drawing.Size(34, 46);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btLedCommand;
        private System.Windows.Forms.Label lbAddress;
    }
}
