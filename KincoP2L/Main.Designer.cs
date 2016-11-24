namespace P2L
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbRegRack = new DevExpress.XtraNavBar.NavBarItem();
            this.nbRackLEDControl = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemRegSMTN = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemSMTNLedControl = new DevExpress.XtraNavBar.NavBarItem();
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.ContentButtonHint = null;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbRegRack,
            this.nbRackLEDControl,
            this.navBarItemRegSMTN,
            this.navBarItemSMTNLedControl});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 189;
            this.navBarControl1.Size = new System.Drawing.Size(194, 437);
            this.navBarControl1.TabIndex = 1;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarControl1_LinkClicked);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "深圳步科";
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
            this.nbRegRack.LargeImage = global::P2L.Properties.Resources.settings;
            this.nbRegRack.Name = "nbRegRack";
            this.nbRegRack.SmallImage = global::P2L.Properties.Resources.settings;
            this.nbRegRack.Tag = "RegisterKincoRack";
            // 
            // nbRackLEDControl
            // 
            this.nbRackLEDControl.Caption = "貨架燈控中心";
            this.nbRackLEDControl.LargeImage = global::P2L.Properties.Resources._switch;
            this.nbRackLEDControl.Name = "nbRackLEDControl";
            this.nbRackLEDControl.SmallImage = global::P2L.Properties.Resources._switch;
            this.nbRackLEDControl.Tag = "KincoRackControl";
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "蘇州立宇";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemRegSMTN),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemSMTNLedControl)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarItemRegSMTN
            // 
            this.navBarItemRegSMTN.CanDrag = false;
            this.navBarItemRegSMTN.Caption = "註冊貨架儲位";
            this.navBarItemRegSMTN.LargeImage = global::P2L.Properties.Resources.settings;
            this.navBarItemRegSMTN.Name = "navBarItemRegSMTN";
            this.navBarItemRegSMTN.SmallImage = global::P2L.Properties.Resources.settings;
            this.navBarItemRegSMTN.Tag = "RegisterSMTNRack";
            // 
            // navBarItemSMTNLedControl
            // 
            this.navBarItemSMTNLedControl.Caption = "貨架燈控中心";
            this.navBarItemSMTNLedControl.LargeImage = global::P2L.Properties.Resources._switch;
            this.navBarItemSMTNLedControl.Name = "navBarItemSMTNLedControl";
            this.navBarItemSMTNLedControl.SmallImage = global::P2L.Properties.Resources._switch;
            this.navBarItemSMTNLedControl.Tag = "SMTNRackControl";
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.MdiParent = this;
            this.xtraTabbedMdiManager.SetNextMdiChildMode = DevExpress.XtraTabbedMdi.SetNextMdiChildMode.Windows;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("5de82a82-ac21-4cf7-a7a4-b3e71b93128c");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Options.AllowDockBottom = false;
            this.dockPanel1.Options.AllowDockFill = false;
            this.dockPanel1.Options.AllowDockTop = false;
            this.dockPanel1.Options.AllowFloating = false;
            this.dockPanel1.Options.FloatOnDblClick = false;
            this.dockPanel1.Options.ShowCloseButton = false;
            this.dockPanel1.Options.ShowMaximizeButton = false;
            this.dockPanel1.Size = new System.Drawing.Size(200, 465);
            this.dockPanel1.Text = "功能導航";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.navBarControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(194, 437);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 465);
            this.Controls.Add(this.dockPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "智能電子貨架演示系統";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem nbRegRack;
        private DevExpress.XtraNavBar.NavBarItem nbRackLEDControl;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navBarItemRegSMTN;
        private DevExpress.XtraNavBar.NavBarItem navBarItemSMTNLedControl;

    }
}