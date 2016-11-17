using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace P2L
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message + "\r\n" + e.Exception.StackTrace, "異常", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
