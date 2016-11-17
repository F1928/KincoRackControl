using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace P2L
{
    [Function]
    public partial class RegisterKincoRack : DevExpress.XtraEditors.XtraForm
    {
        string RackVendor = "KINCO";
        public RegisterKincoRack()
        {
            InitializeComponent();

            this.Clear();
        }

        private decimal getSuggestAddress()
        {
            return LocatorManager.SuggestRackAddress(RackVendor);
        }

        private void Clear()
        {
            this.rackDataSet.Clear();
            this.txtRackCellCodePrefix.Text = RackVendor;
            this.txtRackParentLocatorCode.Text = string.Empty;
            decimal count = LocatorManager.GetRackCount(RackVendor);
            this.txtRackLocatorCode.Text = string.Format("{0}-{1}", this.RackVendor, (count + 1).ToString().PadLeft(3, '0'));
            decimal suggestAddress = getSuggestAddress();


            this.ckBackSide.Checked = true;
            this.ckFrontSide.Checked = true;
            
            this.nRackAddress.Value = suggestAddress;
            this.btCreate.Enabled = true;
            this.btSave.Enabled = false;
            this.txtRackLocatorCode.Focus();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            try
            {
                this.rackDataSet.Clear();

                this.txtRackLocatorCode.Text = this.txtRackLocatorCode.Text.Trim();

                string rackCode = this.txtRackLocatorCode.Text;

                if (string.IsNullOrEmpty(rackCode))
                {
                    MessageBox.Show(this, "請輸入貨架儲位號!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtRackLocatorCode.Focus();
                    return;
                }


                if (ckBackSide.Checked == false && ckFrontSide.Checked == false)
                {
                    MessageBox.Show(this, "請確定正面背面信息!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //if (string.IsNullOrEmpty(txtRackCellCodePrefix.Text.Trim()))
                //{
                //    MessageBox.Show(this, "請確定貨位編碼前綴!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    this.txtRackCellCodePrefix.Focus();
                //    return;
                //}

                if (string.IsNullOrEmpty(txtRackParentLocatorCode.Text.Trim()))
                {
                    MessageBox.Show(this, "請確定貨架的父級儲位編號!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtRackParentLocatorCode.Focus();
                    return;
                }

                decimal tmp = this.nRackAddress.Value;
                if (ckBackSide.Checked)
                    tmp = tmp + 1;

                bool rackAddressExists = LocatorManager.RackAddressExists(RackVendor, tmp);
                if (rackAddressExists)
                {

                    MessageBox.Show(this, "貨架地址編碼重覆了，請另設一個!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    decimal suggestAddress = getSuggestAddress();
                    DialogResult result = MessageBox.Show(this, string.Format("系統建議你將貨架地址設置為:{0},是否採納?", suggestAddress), "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.nRackAddress.Value = suggestAddress;
                    }
                    else
                    {
                        return;
                    }
                }

                decimal parentLocatorID = LocatorManager.GetLocatorID(txtRackParentLocatorCode.Text.Trim());

                RackDataSet.IMS_LOCATORRow newRow = LocatorManager.GetLocatorRow(rackCode);

                if (newRow == null)
                {
                    newRow = rackDataSet.IMS_LOCATOR.NewIMS_LOCATORRow();
                    newRow.ID = LocatorManager.NewID();
                    newRow.VERSION = 1;
                    newRow.SetENABLE_BILL_IDNull();
                    newRow.SetDISABLE_BILL_IDNull();
                    newRow.CODE = txtRackLocatorCode.Text.Trim();
                    newRow.NAME = txtRackLocatorCode.Text.Trim();
                    newRow.DESCRIPTION = this.RackVendor + " Intelligent Rack";
                    newRow.TYPE = 20; // 撿料區域
                    newRow.PARENT_ID = parentLocatorID;
                    rackDataSet.IMS_LOCATOR.AddIMS_LOCATORRow(newRow);
                    this.btCreate.Enabled = false;
                }
                else
                {
                    this.rackDataSet.IMS_LOCATOR.Merge(newRow.Table);
                }

                decimal rackAddress = this.nRackAddress.Value;
                if (this.ckFrontSide.Checked)
                {
                    this.CreateRackCellLocators(rackAddress, newRow.ID, this.nLevelStart.Value, this.nLevelEnd.Value, this.nColStart.Value, this.nColEnd.Value, true);
                }
                if (this.ckBackSide.Checked)
                {
                    this.CreateRackCellLocators(rackAddress + 1, newRow.ID, this.nLevelStart.Value, this.nLevelEnd.Value, this.nColStart.Value, this.nColEnd.Value, false);
                }
            }
            finally
            {

            }
        }

        private void CreateRackCellLocators(decimal rackAddress, decimal rackLocatorID, decimal levelStart, decimal levelEnd, decimal colStart, decimal colEnd, bool isFrontSide)
        {
            this.btCreate.Enabled = false;
            this.btSave.Enabled = true;
            decimal rackCellAddress = 0;
            string rackCellLocatorCode = string.Empty;
            int rackAddressLeght = (int)(nRackAddressLength.Value);
            int cellAddressLength = (int)(nCellCodeLeght.Value);
            for (decimal l = levelStart; l <= levelEnd; l++)
                for (decimal c = colStart; c <= colEnd; c++)
                {
                    rackCellLocatorCode = this.txtRackCellCodePrefix.Text;
                    rackCellAddress += 1;

                    rackCellLocatorCode = rackCellLocatorCode + rackAddress.ToString().PadLeft(rackAddressLeght, '0') + rackCellAddress.ToString().PadLeft(cellAddressLength, '0');
                    RackDataSet.IMS_LOCATORRow newLoc = this.rackDataSet.IMS_LOCATOR.NewIMS_LOCATORRow();
                    newLoc.ID = LocatorManager.NewID();
                    newLoc.VERSION = 1;
                    newLoc.SetENABLE_BILL_IDNull();
                    newLoc.SetDISABLE_BILL_IDNull();
                    newLoc.CODE = rackCellLocatorCode;
                    newLoc.NAME = rackCellLocatorCode;
                    newLoc.DESCRIPTION = string.Format("Intelligent Rack Cell.貨架:{0}面的第:{1}層,第:{2}列", isFrontSide ? "正" : "背", l, c);
                    newLoc.TYPE = 50; // 撿料區域
                    newLoc.PARENT_ID = rackLocatorID;
                    rackDataSet.IMS_LOCATOR.AddIMS_LOCATORRow(newLoc);

                    RackDataSet.IMS_INTELLIGENT_RACK_CELL_INFORow newRow = this.rackDataSet.IMS_INTELLIGENT_RACK_CELL_INFO.NewIMS_INTELLIGENT_RACK_CELL_INFORow();
                    newRow.ID = LocatorManager.NewID();
                    newRow.VERSION = 1;
                    newRow.SetENABLE_BILL_IDNull();
                    newRow.SetDISABLE_BILL_IDNull();
                    newRow.CODE = rackCellLocatorCode;
                    newRow.LOCATOR_ID = newLoc.ID;
                    newRow.ADDRESS = rackCellAddress;
                    newRow.ROW_NUM = l;
                    newRow.COL_NUM = c;
                    newRow.RACK_LOCATOR_ID = rackLocatorID;
                    newRow.RACK_ADDRESS = rackAddress;
                    newRow.RACK_VENDOR = this.RackVendor;
                    this.rackDataSet.IMS_INTELLIGENT_RACK_CELL_INFO.AddIMS_INTELLIGENT_RACK_CELL_INFORow(newRow);

                }

           // this.lbSubTotal.Text = string.Format("共產生:{0}個貨位信息", this.rackDataSet.IMS_INTELLIGENT_RACK_CELL_INFO.Count);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            using (EZ.DB.DBTransactionScope scope = new EZ.DB.DBTransactionScope())
            {
                try
                {
                    LocatorManager.SaveData(this.rackDataSet.IMS_LOCATOR);
                    LocatorManager.SaveData(this.rackDataSet.IMS_INTELLIGENT_RACK_CELL_INFO);
                    scope.Commit();
                }
                catch (Exception ex)
                {
                    scope.Rollback();
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.btSave.Enabled = false;
                this.btCreate.Enabled = true;
                this.Clear();
            }
        }

        private void nRackAddress_EditValueChanged(object sender, EventArgs e)
        {
            if (nRackAddress.Value % 2 == 0)
                nRackAddress.Value += 1;
        }
    }
}
