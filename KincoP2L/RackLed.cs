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
            this.boss = new Boss();
        }

        private Boss boss;

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

        public event EventHandler<CommandEventArg> CommandSended
        {
            add
            {
                this.boss.AfterCommandSend += value;
            }
            remove
            {
                this.boss.AfterCommandSend -= value;
            }
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

        public void TurnOffLed()
        {
            this.boss.TurnOffLed(new KeyValuePair<ushort, ushort>(this.RackAddress, this.Address));
            this.ImageIndex = 0;          
        }

        public void TurnOnGreenLed()
        {
            this.boss.TurnOnGreenLed(new KeyValuePair<ushort, ushort>(this.RackAddress, this.Address));
            this.ImageIndex = 1;
        }

        public void TurnOnRedLed()
        {
            this.boss.TurnOnRedLed(new KeyValuePair<ushort, ushort>(this.RackAddress, this.Address));
            this.ImageIndex = 2;
        }

       

    }
}
