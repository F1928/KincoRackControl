using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using KincoLightManager;

namespace P2L
{
    [Function]
    public partial class SMTNRackControl : DevExpress.XtraEditors.XtraForm
    {
        StringBuilder messageLogs = new StringBuilder();
        RackLed tempLed;
        List<DevExpress.XtraEditors.CheckEdit> ckEditListForMultiRackControl = new List<DevExpress.XtraEditors.CheckEdit>();
        List<DevExpress.XtraEditors.CheckEdit> ckEditListForMultiLightsControl = new List<DevExpress.XtraEditors.CheckEdit>();
  
        List<KeyValuePair<ushort, ushort>> listForMultiLightsControl = new List<KeyValuePair<ushort, ushort>>();
        List<KeyValuePair<ushort, ushort>> listForFlashControl = new List<KeyValuePair<ushort, ushort>>();

        public SMTNRackControl()
        {
            InitializeComponent();
            this.Clear();
            this.Init();
        }

        private void Clear()
        {
            this.mmSelectedLightsForFlash.Text = string.Empty;
            this.mmSelectedLightsForMulti.Text = string.Empty;
            this.listForMultiLightsControl.Clear();
            this.listForFlashControl.Clear();

            this.rackDataSet.Clear();
            this.rackDataSet.IMS_RACK.Merge(LocatorManager.GetRackInfoTable("SMTN"));
            foreach (var x in this.rackDataSet.IMS_RACK)
            {
                x.CHECKED = false;
                x.CHECKED_BACK = false;
                x.CHECKED_FRONT = false;
            }
            this.bindingSource.Position = -1;

            this.ckEditListForMultiRackControl.Clear();
            this.ckEditListForMultiRackControl.Add(this.ckMutiRackControl0);
            this.ckEditListForMultiRackControl.Add(this.ckMutiRackControl1);

            foreach (var ck in this.ckEditListForMultiRackControl)
                ck.Checked = false;

            this.ckEditListForMultiLightsControl.Clear();
            this.ckEditListForMultiLightsControl.Add(this.ckLightOff);
            this.ckEditListForMultiLightsControl.Add(this.ckLightOn);
            foreach (var ck in this.ckEditListForMultiLightsControl)
                ck.Checked = false;


        }

        private void Init()
        {
            this.tableLayoutPanelFront.ColumnStyles.Clear();
            this.tableLayoutPanelFront.RowStyles.Clear();
            this.tableLayoutPanelFront.RowCount = 10;
            this.tableLayoutPanelFront.ColumnCount = 100;
            this.tableLayoutPanelBack.ColumnStyles.Clear();
            this.tableLayoutPanelBack.RowStyles.Clear();
            this.tableLayoutPanelBack.RowCount = 10;
            this.tableLayoutPanelBack.ColumnCount = 100;
            for (int i = 0; i < 10; i++)
            {
                this.tableLayoutPanelFront.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46));
                this.tableLayoutPanelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46));
            }
            for (int i = 0; i < 100; i++)
            {
                this.tableLayoutPanelFront.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34));
                this.tableLayoutPanelBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34));
            }

            foreach (var ck in this.ckEditListForMultiRackControl)
            {
                ck.CheckStateChanged -= new EventHandler(ckMutiRackControl_CheckStateChanged);
                ck.CheckStateChanged += new EventHandler(ckMutiRackControl_CheckStateChanged);
            }
            foreach (var ck in this.ckEditListForMultiLightsControl)
            {
                ck.CheckStateChanged -= new EventHandler(ckMutiLightsControl_CheckStateChanged);
                ck.CheckStateChanged += new EventHandler(ckMutiLightsControl_CheckStateChanged);
            }

            this.rackDataSet.IMS_RACK.ColumnChanged -= new DataColumnChangeEventHandler(IMS_RACK_ColumnChanged);
            this.rackDataSet.IMS_RACK.ColumnChanged += new DataColumnChangeEventHandler(IMS_RACK_ColumnChanged);
        }

        void IMS_RACK_ColumnChanged(object sender, DataColumnChangeEventArgs e)
        {
            if (e.Column == this.rackDataSet.IMS_RACK.CHECKEDColumn)
            {
                RackDataSet.IMS_RACKRow row = e.Row as RackDataSet.IMS_RACKRow;
                if (row.CHECKED)
                {
                    row.CHECKED_FRONT = true;
                    row.CHECKED_BACK = true;
                }
                else
                {
                    row.CHECKED_FRONT = false;
                    row.CHECKED_BACK = false;
                }
            }
        }

        void ckMutiRackControl_CheckStateChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.CheckEdit ckedit = sender as DevExpress.XtraEditors.CheckEdit;
            if (ckedit.Checked)
            {
                this.ckEditListForMultiRackControl.ForEach(f => { if (f.Name != ckedit.Name) f.Checked = false; });
            }
        }

        void ckMutiLightsControl_CheckStateChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.CheckEdit ckedit = sender as DevExpress.XtraEditors.CheckEdit;
            if (ckedit.Checked)
            {
                this.ckEditListForMultiLightsControl.ForEach(f => { if (f.Name != ckedit.Name) f.Checked = false; });
            }
        }



        private void ReadyForGenRack()
        {
            this.tableLayoutPanelFront.Visible = false;
            this.tableLayoutPanelBack.Visible = false;
            this.tableLayoutPanelFront.Controls.Clear();
            this.tableLayoutPanelBack.Controls.Clear();

            GC.Collect();

            if (bindingSource.Position < 0)
            {
                Messenger.ShowException("請選擇您要查看的貨架!");
                return;
            }
            RackDataSet.IMS_RACKRow rackRow = this.rackDataSet.IMS_RACK[bindingSource.Position];
            this.pageBack.Text = string.Format("背面--地址編號:{0}",rackRow.BACK_ADDRESS);
            this.pageFront.Text = string.Format("正面--地址編號:{0}", rackRow.FRONT_ADDRESS);
            GenRack(rackRow.CODE, rackRow.FRONT_ADDRESS, rackRow.BACK_ADDRESS);
        }

        private void GenRack(string rackLocatorCode,decimal frontAddress, decimal backAddress)
        {           

            Task myTask = new Task(() =>
            {
                this.rackDataSet.IMS_INTELLIGENT_RACK_CELL_INFO.Clear();
                this.rackDataSet.IMS_INTELLIGENT_RACK_CELL_INFO.Merge(LocatorManager.GetRackCellInfo(rackLocatorCode));
            });

            myTask.ContinueWith((task) =>
            {
                Action<ushort,bool> createLedList = ( rackAddress, isFrontSide) =>
                {
                    List<decimal> rows = this.rackDataSet.IMS_INTELLIGENT_RACK_CELL_INFO.Where(f => f.RACK_ADDRESS == rackAddress).Select(f => f.ROW_NUM).Distinct().ToList();
                    foreach (decimal r in rows)
                    {
                        var q = from x in this.rackDataSet.IMS_INTELLIGENT_RACK_CELL_INFO
                                where x.ROW_NUM == r && x.RACK_ADDRESS == rackAddress
                                orderby x.COL_NUM
                                select x;
                        foreach (var c in q)
                        {
                            RackLed led = new RackLed();
                            led.LocatorCode = c.CODE;
                            led.Address = (ushort)c.ADDRESS;
                            led.RackAddress = (ushort)c.RACK_ADDRESS;
                            led.ImageIndex = 0;
                            led.ImageList = this.imageCollectionOfMenu;
                            led.Hint = c.CODE;
                            led.Click += new EventHandler(led_Click);
                            if (isFrontSide)
                                this.tableLayoutPanelFront.Controls.Add(led, (int)c.COL_NUM-1, (int)c.ROW_NUM-1);
                            else
                                this.tableLayoutPanelBack.Controls.Add(led, (int)c.COL_NUM-1, (int)c.ROW_NUM-1);
                        }

                    }
                };

                this.Invoke(createLedList, (ushort)frontAddress,true);
                this.Invoke(createLedList, (ushort)backAddress,false);

            }).ContinueWith((task) =>
            {
                Action setVisible = () =>
                {
                    this.tableLayoutPanelFront.Visible = true;
                    this.tableLayoutPanelBack.Visible = true;
                };
                this.Invoke(setVisible);
            });


            myTask.Start();


        }

       
        void led_CommandSended(object sender, CommandEventArg e)
        {            
        }
             

        void led_Click(object sender, EventArgs e)
        {
            this.popupMenu.ShowPopup(MousePosition);
            tempLed = (sender as RackLed);
        }

        private void bbiTurnOffLED_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void bbiTurnOnGreenLED_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void bbiTurnOnRedLED_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void bbiSelect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            this.DoSelected();
        }

        private void bbiFlashGreen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LedFlashParamPicker frm = new LedFlashParamPicker();
            DialogResult result = frm.ShowDialog(this);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                
            }
           
        }

        private void bbiFlashRed_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LedFlashParamPicker frm = new LedFlashParamPicker();
            DialogResult result = frm.ShowDialog(this);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                
            }
        }


        private void DoSelected()
        {
            tempLed.DoSelected();

            if (this.tabControl.SelectedTabPage == pageMutiLightControl)
            {
                this.listForMultiLightsControl.Add(new KeyValuePair<ushort, ushort>(tempLed.RackAddress, tempLed.Address));
                StringBuilder sb = new StringBuilder();
                foreach (var addr in this.listForMultiLightsControl)
                {
                    sb.AppendFormat(" [{0},{1}] ", addr.Key, addr.Value);
                }
                this.mmSelectedLightsForMulti.Text = sb.ToString();
            }

            else if (this.tabControl.SelectedTabPage == pageLightFlashControl)
            {
                this.listForFlashControl.Add(new KeyValuePair<ushort, ushort>(tempLed.RackAddress, tempLed.Address));
                StringBuilder sb = new StringBuilder();
                foreach (var addr in this.listForFlashControl)
                {
                    sb.AppendFormat(" [{0},{1}] ", addr.Key, addr.Value);
                }
                this.mmSelectedLightsForFlash.Text = sb.ToString();
            }
        }


        private void SendMutiRackControlCmd()
        {
            var list = this.rackDataSet.IMS_RACK.Where(f => f.CHECKED);

            if (this.bindingSource.Position < 0 || list.Count()<=0 )
            {
                Messenger.ShowException("請勾選您要控制的貨架資料!");
                return;
            }
            bool cked=false;
            this.ckEditListForMultiRackControl.ForEach(f =>
            {
                if (f.Checked) cked = true;
            });
            if (cked == false)
            {
                Messenger.ShowException("請選擇您要進行多貨架控制的命令類型!");
                return;
            }

            RackTowerLedStatus toStatus = RackTowerLedStatus.RackLedOff_TowerWhiteOff;
            if (this.ckMutiRackControl0.Checked)
                toStatus = RackTowerLedStatus.RackLedOff_TowerWhiteOff;
            if (this.ckMutiRackControl1.Checked)
                toStatus = RackTowerLedStatus.RackGreenOn_TowerWhiteOn;

            
            List<ushort> rackAddressList = new List<ushort>();
            foreach (var row in list)
            {
                if (row.CHECKED_FRONT)
                    rackAddressList.Add((ushort)row.FRONT_ADDRESS);
                if (row.CHECKED_BACK)
                    rackAddressList.Add((ushort)row.BACK_ADDRESS);
                if (row.CHECKED_BACK == false && row.CHECKED_FRONT == false)
                {
                    rackAddressList.Add((ushort)row.FRONT_ADDRESS);
                    rackAddressList.Add((ushort)row.BACK_ADDRESS);
                }
            }

            KincoLightManager.Boss cmdBoss = new Boss();
            cmdBoss.SendRackControlCmd(toStatus, rackAddressList.ToArray());

        }

        private void SendMutiLightsControlCmd() 
        {
            if (this.listForMultiLightsControl.Count <= 0)
            {
                Messenger.ShowException("請選擇您要控制的燈!");
                return;
            }

            if (this.ckLightOff.Checked == false &&
                this.ckLightOn.Checked == false)
            {
                Messenger.ShowException("請選擇您要發送的命令類型!");
                return;
            }

            if (this.listForMultiLightsControl.Count > 0)
            {
                KincoLightManager.Boss cmdBoss = new Boss();
                LedOnOffStatus toStatus = LedOnOffStatus.Off;
                if (this.ckLightOff.Checked)
                    toStatus = LedOnOffStatus.Off;
                else if (this.ckLightOn.Checked)
                    toStatus = LedOnOffStatus.GreenOn;
                cmdBoss.SendLedOnOffControlCmd(toStatus, this.listForMultiLightsControl.ToArray());
            }
        }

        private void SendFlashControlCmd()
        {
            if (this.listForFlashControl.Count <= 0)
            {
                Messenger.ShowException("請選擇您要閃爍的燈!");
                return;
            }


            KincoLightManager.Boss cmdBoss = new Boss();
            LedFlashStatus toStatus = LedFlashStatus.Green_Flash;

            LedFlashParamPicker frm = new LedFlashParamPicker();
            DialogResult result = frm.ShowDialog(this);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                cmdBoss.SendLedFlashControlCmd(toStatus, frm.OnTime, frm.OffTime, frm.FlashCount, this.listForFlashControl.ToArray());
            }
        }


        private void btCreateRactCells_Click(object sender, EventArgs e)
        {
            ReadyForGenRack();
        }


        private void btSendCommand_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTabPage == pageMutiRackControl)
            {
                this.SendMutiRackControlCmd();
            }
            if (tabControl.SelectedTabPage == pageMutiLightControl)
            {
                this.SendMutiLightsControlCmd();
            }
            if (tabControl.SelectedTabPage == pageLightFlashControl)
            {
                this.SendFlashControlCmd();
            }
        }

        private void tabControl_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page == pageMutiRackControl)
                this.bbiSelect.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            else
                this.bbiSelect.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

      
       

        

       
        

       
    }
}
