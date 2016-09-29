namespace KincoP2L
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
            this.components = new System.ComponentModel.Container();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbRegRack = new DevExpress.XtraNavBar.NavBarItem();
            this.nbRackLEDControl = new DevExpress.XtraNavBar.NavBarItem();
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.ContentButtonHint = null;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbRegRack,
            this.nbRackLEDControl});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 189;
            this.navBarControl1.Size = new System.Drawing.Size(189, 465);
            this.navBarControl1.TabIndex = 1;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarControl1_LinkClicked);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "";
            this.navBarGroup1.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None;
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbRegRack),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbRackLEDControl)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // nbRegRack
            // 
            this.nbRegRack.CanDrag = false;
            this.nbRegRack.Caption = "註冊貨架儲位";
            this.nbRegRack.LargeImage = global::KincoP2L.Properties.Resources.settings;
            this.nbRegRack.Name = "nbRegRack";
            this.nbRegRack.SmallImage = global::KincoP2L.Properties.Resources.settings;
            this.nbRegRack.Tag = "RegisterKincoRack";
            // 
            // nbRackLEDControl
            // 
            this.nbRackLEDControl.Caption = "貨架燈控中心";
            this.nbRackLEDControl.LargeImage = global::KincoP2L.Properties.Resources._switch;
            this.nbRackLEDControl.Name = "nbRackLEDControl";
            this.nbRackLEDControl.SmallImage = global::KincoP2L.Properties.Resources._switch;
            this.nbRackLEDControl.Tag = "KincoRackControl";
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.MdiParent = this;
            this.xtraTabbedMdiManager.SetNextMdiChildMode = DevExpress.XtraTabbedMdi.SetNextMdiChildMode.Windows;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 465);
            this.Controls.Add(this.navBarControl1);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "步科智能電子貨架演示系統";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem nbRegRack;
        private DevExpress.XtraNavBar.NavBarItem nbRackLEDControl;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;

    }
}