using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KincoLightManager;
using EZ.DB;

namespace KincoP2L
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btRegLocator_Click(object sender, EventArgs e)
        {
            RegKincoLocator frmReg = new RegKincoLocator();
            frmReg.Location = new Point(this.Location.X + this.Width + 5, this.Location.Y);
            frmReg.ShowDialog(this);
        }


        /*
        private void button1_Click(object sender, EventArgs e)
        {
            string cmd = KincoLightManager.g.CreateLightsFlashControlCmd(LightsFlashStatus.Green_Flash,
                1500, 500, 10,
                new KeyValuePair<UInt16, UInt16>(1, 1),
                new KeyValuePair<UInt16, UInt16>(257, 257));

            MessageBox.Show(cmd);

            cmd = KincoLightManager.g.CreateLightsOnOffControlCmd(LightsOnOffStatus.GreenOn,
                new KeyValuePair<UInt16, UInt16>(1, 1),
                new KeyValuePair<UInt16, UInt16>(257, 257));

            MessageBox.Show(cmd);


            cmd = KincoLightManager.g.CreateRackControlCmd(RackTowerLightsStatus.RackGreenOn_TowerWhiteOn,
                1, 2, 3, 260, 261);
            MessageBox.Show(cmd);

        } */

    }
}
