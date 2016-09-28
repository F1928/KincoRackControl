namespace KincoP2L
{
    partial class Main
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btRegLocator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Image = global::KincoP2L.Properties.Resources.load;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(41, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 86);
            this.button1.TabIndex = 1;
            this.button1.Text = "線邊倉備料演示";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btRegLocator
            // 
            this.btRegLocator.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btRegLocator.Image = global::KincoP2L.Properties.Resources.location;
            this.btRegLocator.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btRegLocator.Location = new System.Drawing.Point(41, 15);
            this.btRegLocator.Name = "btRegLocator";
            this.btRegLocator.Size = new System.Drawing.Size(144, 86);
            this.btRegLocator.TabIndex = 0;
            this.btRegLocator.Text = "註冊貨架儲位";
            this.btRegLocator.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRegLocator.UseVisualStyleBackColor = true;
            this.btRegLocator.Click += new System.EventHandler(this.btRegLocator_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 556);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btRegLocator);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "步科智能電子貨架演示系統";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRegLocator;
        private System.Windows.Forms.Button button1;

    }
}

