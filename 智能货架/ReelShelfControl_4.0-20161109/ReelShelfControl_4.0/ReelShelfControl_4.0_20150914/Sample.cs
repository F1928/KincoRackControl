using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using ReelShelfControl.ServiceContract;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Data.SqlClient;
using System.Collections;
using ReelShelfControl;

namespace TestReelShelfControl
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent(); 
        }


        private void btnSingleLightOut_Click(object sender, EventArgs e)
        {
            try
            {
                LedControlProxy.ReelShelfControlService.SingleLightingControl(txtHWCode.Text.Trim(), 1, 0, 0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLightHouseLightOut_Click(object sender, EventArgs e)
        {
            LedControlProxy.ReelShelfControlService.LightHouseControl(1, 1);
        }

        private void btnSingleLightOff_Click(object sender, EventArgs e)
        {
            LedControlProxy.ReelShelfControlService.SingleLightingControl(txtHWCode.Text.Trim(), 0, 0, 0, 0);
        }

        private void btnSingleLightFlash_Click(object sender, EventArgs e)
        {
            LedControlProxy.ReelShelfControlService.SingleLightingControl(txtHWCode.Text.Trim(), 2, 5, 5,2);
        }

        private void btnMultiLightOut_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList arrHWCode = new ArrayList();
                string[] HWCode = txtHWCode.Text.Trim().Split(',');
                for (int i = 0; i < HWCode.Length; i++)
                {
                    arrHWCode.Add(HWCode[i]);
                }
                LedControlProxy.ReelShelfControlService.MultiLightingControl(arrHWCode, 1, 0, 0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void btnMultiLightOff_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList arrHWCode = new ArrayList();
                string[] HWCode = txtHWCode.Text.Trim().Split(',');
                for (int i = 0; i < HWCode.Length; i++)
                {
                    arrHWCode.Add(HWCode[i]);
                }
                LedControlProxy.ReelShelfControlService.MultiLightingControl(arrHWCode,0, 0, 0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnMultiLightFlash_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList arrHWCode = new ArrayList();
                string[] HWCode = txtHWCode.Text.Trim().Split(',');
                for (int i = 0; i < HWCode.Length; i++)
                {
                    arrHWCode.Add(HWCode[i]);
                }
                LedControlProxy.ReelShelfControlService.MultiLightingControl(arrHWCode, 2, 5, 5, 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLightHouseLightOff_Click(object sender, EventArgs e)
        {
            LedControlProxy.ReelShelfControlService.LightHouseControl(1, 0);
        }

        private void btnLightHouseLightFlash_Click(object sender, EventArgs e)
        {
            LedControlProxy.ReelShelfControlService.LightHouseControl(1, 2);
        }

        private void btnTurnOnAll_Click(object sender, EventArgs e)
        {
            ArrayList arrBoard = new ArrayList();
            arrBoard.Add("001");
            LedControlProxy.ReelShelfControlService.TurnOnAll(arrBoard);
        }

        private void btnTurnOffAll_Click(object sender, EventArgs e)
        {
            ArrayList arrBoard = new ArrayList();
            arrBoard.Add("001");
            LedControlProxy.ReelShelfControlService.TurnOffAll(arrBoard);
        }

    }
}
