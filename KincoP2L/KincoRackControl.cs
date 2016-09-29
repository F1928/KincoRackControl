using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace KincoP2L
{
    [Function]
    public partial class KincoRackControl : DevExpress.XtraEditors.XtraForm
    {
        public KincoRackControl()
        {
            InitializeComponent();
            this.Init();
        }

        public void Init()
        {
            this.rackDataSet.Clear();
            this.rackDataSet.IMS_RACK.Merge(LocatorManager.GetRackInfoTable());
            this.tableLayoutPanel.RowStyles.Clear();
            this.tableLayoutPanel.ColumnStyles.Clear();
            this.tableLayoutPanel.Visible = false;
        }


        private void bindingSource_PositionChanged(object sender, EventArgs e)
        {
            GenRack();
        }

        private void GenRack()
        {
            this.tableLayoutPanel.Controls.Clear();
            this.tableLayoutPanel.RowStyles.Clear();
            this.tableLayoutPanel.ColumnStyles.Clear();

            this.rackDataSet.IMS_INTELLIGENT_RACK_CELL_INFO.Clear();
            if (bindingSource.Position < 0) return;
            RackDataSet.IMS_RACKRow rackRow = this.rackDataSet.IMS_RACK[bindingSource.Position];

            Task myTask = new Task(() =>
            {
                this.rackDataSet.IMS_INTELLIGENT_RACK_CELL_INFO.Merge(LocatorManager.GetRackCellInfo(rackRow.CODE, rackRow.FRONT_ADDRESS));
            });

            myTask.ContinueWith((task) =>
            {
                int colCount = (int)this.rackDataSet.IMS_INTELLIGENT_RACK_CELL_INFO.Max(f => f.COL_NUM);
                int rowCount = (int)this.rackDataSet.IMS_INTELLIGENT_RACK_CELL_INFO.Max(f => f.ROW_NUM);

                Action setStyle = () =>
                {
                    this.tableLayoutPanel.RowCount = rowCount+1;
                    this.tableLayoutPanel.ColumnCount = colCount;

                    for (int i = 0; i < rowCount; i++)
                        this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46));
                    for (int i = 0; i < colCount; i++)
                        this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34));
                };

                this.BeginInvoke(setStyle);

            }).ContinueWith((task) =>
            {
                List<decimal> rows = this.rackDataSet.IMS_INTELLIGENT_RACK_CELL_INFO.Select(f => f.ROW_NUM).Distinct().ToList();
                foreach (decimal r in rows)
                {
                    var q = from x in this.rackDataSet.IMS_INTELLIGENT_RACK_CELL_INFO
                            where x.ROW_NUM == r
                            orderby x.COL_NUM
                            select x;
                    foreach (var c in q)
                    {
                        Action<int, int,ushort, ushort,string> createLed = (int col, int row,ushort rackAddress, ushort address,string hint) =>
                        {
                            RackLed led = new RackLed();
                            led.Address = address;
                            led.RackAddress = rackAddress;
                            led.ImageIndex = 0;
                            led.ImageList = this.imageCollection;
                            led.Hint = hint;
                            led.Click += new EventHandler(led_Click);
                            this.tableLayoutPanel.Controls.Add(led, col, row);
                        };

                        this.BeginInvoke(createLed, (int)c.COL_NUM - 1, (int)r - 1, (ushort)c.RACK_ADDRESS, (ushort)c.ADDRESS, c.CODE);

                    }

                }
            }).ContinueWith((task) =>
            {
                Action setVisible = () =>
                {
                    this.tableLayoutPanel.Visible = true;
                };
                this.BeginInvoke(setVisible);
            });


            myTask.Start();


        }

        void led_Click(object sender, EventArgs e)
        {
            this.popupMenu.ShowPopup(MousePosition);
            tempLed = (sender as RackLed);
        }

        RackLed tempLed;

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
    }
}
