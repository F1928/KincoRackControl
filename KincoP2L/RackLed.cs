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

namespace P2L
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

        public string LocatorCode
        {
            get;
            set;
        }

        public UInt16 RackAddress
        {
            get;
            set;
        }

        private bool selected;
        public bool Selected
        {
            get { return this.selected; }
            set
            {
                this.selected = value;
                this.ImageIndex = 1;
            }
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


        public void DoSelected()
        {
            this.ImageIndex = 3;
        }


        private void btLedCommand_Click(object sender, EventArgs e)
        {
            if (this.Click != null)
                this.Click(this, e);
        }


        /*
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

        public void FlashGreen(ushort lightsOnTime, ushort lightsOffTime, ushort flashCount)
        {
            this.boss.FlashGreenLed(lightsOffTime, lightsOffTime, flashCount, new KeyValuePair<ushort, ushort>(this.RackAddress, this.Address));
            this.ImageIndex = 4;
        }

        public void FlashRed(ushort lightsOnTime, ushort lightsOffTime, ushort flashCount)
        {
            this.boss.FlashRedLed(lightsOffTime, lightsOffTime, flashCount, new KeyValuePair<ushort, ushort>(this.RackAddress, this.Address));
            this.ImageIndex = 5;
        }
         */

    }
}
