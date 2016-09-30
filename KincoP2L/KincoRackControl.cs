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

namespace KincoP2L
{
    [Function]
    public partial class KincoRackControl : DevExpress.XtraEditors.XtraForm
    {
        StringBuilder messageLogs = new StringBuilder();
        RackLed tempLed;
        List<DevExpress.XtraEditors.CheckEdit> ckEditList = new List<DevExpress.XtraEditors.CheckEdit>();

        public KincoRackControl()
        {
            InitializeComponent();
            this.Clear();
            this.Init();
        }

        private void Clear()
        {
            this.rackDataSet.Clear();
            this.rackDataSet.IMS_RACK.Merge(LocatorManager.GetRackInfoTable());
            foreach (var x in this.rackDataSet.IMS_RACK)
            {
                x.CHECKED = false;
                x.CHECKED_BACK = false;
                x.CHECKED_FRONT = false;
            }
            this.bindingSource.Position = -1;

            this.ckEditList.Clear();
            this.ckEditList.Add(this.ckMutiRackControl0);
            this.ckEditList.Add(this.ckMutiRackControl1);
            this.ckEditList.Add(this.ckMutiRackControl2);
            this.ckEditList.Add(this.ckMutiRackControl3);
            this.ckEditList.Add(this.ckMutiRackControl4);
            this.ckEditList.Add(this.ckMutiRackControl5);
            this.ckEditList.Add(this.ckMutiRackControl6);
            this.ckMutiRackControl0.Checked = false;
            this.ckMutiRackControl1.Checked = false;
            this.ckMutiRackControl2.Checked = false;
            this.ckMutiRackControl3.Checked = false;
            this.ckMutiRackControl4.Checked = false;
            this.ckMutiRackControl5.Checked = false;
            this.ckMutiRackControl6.Checked = false;
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

            this.ckMutiRackControl0.CheckStateChanged -= new EventHandler(ckMutiRackControl_CheckStateChanged);
            this.ckMutiRackControl1.CheckStateChanged -= new EventHandler(ckMutiRackControl_CheckStateChanged);
            this.ckMutiRackControl2.CheckStateChanged -= new EventHandler(ckMutiRackControl_CheckStateChanged);
            this.ckMutiRackControl3.CheckStateChanged -= new EventHandler(ckMutiRackControl_CheckStateChanged);
            this.ckMutiRackControl4.CheckStateChanged -= new EventHandler(ckMutiRackControl_CheckStateChanged);
            this.ckMutiRackControl5.CheckStateChanged -= new EventHandler(ckMutiRackControl_CheckStateChanged);
            this.ckMutiRackControl6.CheckStateChanged -= new EventHandler(ckMutiRackControl_CheckStateChanged);

            this.ckMutiRackControl0.CheckStateChanged += new EventHandler(ckMutiRackControl_CheckStateChanged);
            this.ckMutiRackControl1.CheckStateChanged += new EventHandler(ckMutiRackControl_CheckStateChanged);
            this.ckMutiRackControl2.CheckStateChanged += new EventHandler(ckMutiRackControl_CheckStateChanged);
            this.ckMutiRackControl3.CheckStateChanged += new EventHandler(ckMutiRackControl_CheckStateChanged);
            this.ckMutiRackControl4.CheckStateChanged += new EventHandler(ckMutiRackControl_CheckStateChanged);
            this.ckMutiRackControl5.CheckStateChanged += new EventHandler(ckMutiRackControl_CheckStateChanged);
            this.ckMutiRackControl6.CheckStateChanged += new EventHandler(ckMutiRackControl_CheckStateChanged);

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
                this.ckEditList.ForEach(f => { if (f.Name != ckedit.Name) f.Checked = false; });
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
                            led.Address = (ushort)c.ADDRESS;
                            led.RackAddress = (ushort)c.RACK_ADDRESS;
                            led.ImageIndex = 0;
                            led.ImageList = this.imageCollection;
                            led.Hint = c.CODE;
                            led.Click += new EventHandler(led_Click);
                            led.CommandSended += new EventHandler<MessageEventArg>(led_CommandSended);
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

       
        void led_CommandSended(object sender, MessageEventArg e)
        {
            this.messageLogs.Insert(0, e.Message+"\r\n");
            this.mmLog.Text = this.messageLogs.ToString();
        }
             

        void led_Click(object sender, EventArgs e)
        {
            this.popupMenu.ShowPopup(MousePosition);
            tempLed = (sender as RackLed);
        }

        private void bbiTurnOffLED_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tempLed.TurnOffLed();
        }

        private void bbiTurnOnGreenLED_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tempLed.TurnOnGreenLed();
        }

        private void bbiTurnOnRedLED_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tempLed.TurnOnRedLed();
        }

        private void SendMutiRackControlCmd()
        {
            if (this.bindingSource.Position < 0)
            {
                Messenger.ShowException("請選擇您要控制的貨架資料!");
                return;
            }
            bool cked=false;
            this.ckEditList.ForEach(f =>
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
            if (this.ckMutiRackControl2.Checked)
                toStatus = RackTowerLedStatus.RackRedOn_TowerWhiteOn;
            if (this.ckMutiRackControl3.Checked)
                toStatus = RackTowerLedStatus.Tower_RedOff_GreenOff;
            if (this.ckMutiRackControl4.Checked)
                toStatus = RackTowerLedStatus.Tower_RedOn;
            if (this.ckMutiRackControl5.Checked)
                toStatus = RackTowerLedStatus.Tower_GreenOn;
            if (this.ckMutiRackControl6.Checked)
                toStatus = RackTowerLedStatus.Tower_RedOn_GreenOn;

        }

        private void btCreateRactCells_Click(object sender, EventArgs e)
        {
            ReadyForGenRack();
        }


        private void btSendCommand_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTabPage == pageMutiRackControl)
            {

            }
        }

       
        

       
    }
}
