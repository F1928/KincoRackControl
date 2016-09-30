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
    public class MessageEventArg : EventArgs
    {
        public string Message { get; set; }
    }
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
        public event EventHandler<MessageEventArg> CommandSended;

        private void FireCommandSended(string cmd,string cmdDescription)
        {
            string msg = genMessage(cmd, cmdDescription);
            if (this.CommandSended != null)
                this.CommandSended(this, new MessageEventArg { Message = msg });
        }

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

        private string genMessage(string cmd, string cmdDescription)
        {
            int rackNo = (this.RackAddress % 2) == 0 ? (this.RackAddress - 1) : this.RackAddress;
            string msg = string.Format("{0},向貨架{1}: {2} 第 {3} 號燈 發送【{4}】指令:{5}", 
                                       DateTime.Now.ToLongTimeString(), 
                                       rackNo.ToString().PadLeft(3,'0'), 
                                       this.RackAddress % 2 == 0 ? "背面" : "正面", 
                                       this.Address.ToString().PadLeft(3, '0'),
                                       cmdDescription, 
                                       cmd);
            return msg;
        }



        public void TurnOffLed()
        {
            string cmd = KincoLightManager.g.CreateCmd_TurnOffLed(new KeyValuePair<ushort, ushort>(this.RackAddress, this.Address));
            this.ImageIndex = 0;
            KincoLightManager.g.SendCommand(cmd);
            FireCommandSended(cmd,"關閉貨位指示燈");           
        }

        public void TurnOnGreenLed()
        {
            string cmd = KincoLightManager.g.CreateCmd_TurnOnGreenLed(new KeyValuePair<ushort, ushort>(this.RackAddress, this.Address));
            this.ImageIndex = 1;
            KincoLightManager.g.SendCommand(cmd);
            FireCommandSended(cmd, "打開貨位綠色指示燈");
        }

        public void TurnOnRedLed()
        {
            string cmd = KincoLightManager.g.CreateCmd_TurnOnRedLed(new KeyValuePair<ushort, ushort>(this.RackAddress, this.Address));
            this.ImageIndex = 2;
            KincoLightManager.g.SendCommand(cmd);
            FireCommandSended(cmd,"打開貨位紅色指示燈");
        }

       

    }
}
