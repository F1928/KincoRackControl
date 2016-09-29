using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using KincoLightManager;

namespace KincoP2L
{
    public partial class RackLed : XtraUserControl
    {
        public RackLed()
        {
            InitializeComponent();
        }

        public UInt16 Address
        {
            get
            {
                return UInt16.Parse(this.lbAddress.Text);
            }
            set
            {
                this.lbAddress.Text = value.ToString();
            }
        }

        public UInt16 RackAddress
        {
            get;
            set;
        }

        public new event EventHandler Click;

        public object ImageList
        {
            get { return this.btLedCommand.ImageList; }
            set { this.btLedCommand.ImageList = value; }
        }

        public int ImageIndex
        {
            get
            {
                return this.btLedCommand.ImageIndex;
            }
            set
            {
                this.btLedCommand.ImageIndex = value;
            }
        }

        public string Hint
        {
            get
            {
                return this.btLedCommand.ToolTip;
            }
            set
            {
                this.btLedCommand.ToolTip = value;
            }
        }

        private void btLedCommand_Click(object sender, EventArgs e)
        {
            if (this.Click != null)
                this.Click(this, e);
        }

        public void TurnOffLed()
        {
            string cmd = KincoLightManager.g.CreateCmd_TurnOffLed(new KeyValuePair<ushort, ushort>(this.RackAddress, this.Address));
            this.ImageIndex = 0;
            KincoLightManager.g.SendCommand(cmd);            
            //XtraMessageBox.Show(this, "您發送了一條【關閉貨位指示燈】指令:{0}".FormatWith(cmd), "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void TurnOnGreenLed()
        {
            string cmd = KincoLightManager.g.CreateCmd_TurnOnGreenLed(new KeyValuePair<ushort, ushort>(this.RackAddress, this.Address));
            this.ImageIndex = 1;
            KincoLightManager.g.SendCommand(cmd);
            //XtraMessageBox.Show(this, "您發送了一條【打開貨位綠色指示燈】:{0}".FormatWith(cmd), "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void TurnOnRedLed()
        {
            string cmd = KincoLightManager.g.CreateCmd_TurnOnRedLed(new KeyValuePair<ushort, ushort>(this.RackAddress, this.Address));
            this.ImageIndex = 2;
            KincoLightManager.g.SendCommand(cmd);
            //XtraMessageBox.Show(this, "您發送了一條【打開貨位紅色指示燈】:{0}".FormatWith(cmd), "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       

    }
}
