using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraNavBar;

namespace KincoP2L
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        public Main()
        {
            InitializeComponent();
        }


        private void ShowChildForm(NavBarItemLink navBarItem, string formTypeName)
        {
            foreach (Form existsChildForm in this.MdiChildren)
            {
                if (existsChildForm.Name == nbRegRack.Caption)
                {
                    this.ActivateMdiChild(existsChildForm);
                    existsChildForm.Activate();
                    return;
                }
            }

            Type[] types = this.GetType()
                               .Assembly
                               .GetTypes()
                               .Where(f =>
                               {
                                   object[] result = f.GetCustomAttributes(typeof(FunctionAttribute), false);
                                   if (result != null && result.Length > 0)
                                       return true;
                                   else
                                       return false;
                               })
                               .ToArray();
            Type formType =null;
            foreach (Type tp in types)
            {
                if (tp.FullName.EndsWith(formTypeName))
                {
                    formType = tp;
                    break;
                }
            }

            if (formType != null)
            {
                Form childForm = Activator.CreateInstance(formType) as Form;
                childForm.Name = navBarItem.Caption;
                childForm.MdiParent = this;
                childForm.Show();
            }
        }


        private void navBarControl1_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            if (e.Link.Item.Tag == null) return;
            ShowChildForm(e.Link, e.Link.Item.Tag.ToString());
        }
    }
}
