using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace KincoP2L
{
    public static class Messenger
    {
        public static void ShowException(string message)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show( message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowMessage( string message)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public static void ShowException(IWin32Window owner,string message)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show(owner, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);       
        }

        public static void ShowMessage(IWin32Window owner, string message)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show(owner, message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
