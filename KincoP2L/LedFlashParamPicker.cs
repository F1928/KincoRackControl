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
    public partial class LedFlashParamPicker : DevExpress.XtraEditors.XtraForm
    {
        public LedFlashParamPicker()
        {
            InitializeComponent();
        }

        public ushort FlashCount
        {
            get
            {
                return (ushort)this.spFlashCount.Value;
            }
        }

        public ushort OnTime
        {
            get
            {
                return (ushort)this.spOnTime.Value;
            }
        }

        public ushort OffTime
        {
            get
            {
                return (ushort)this.spOffTime.Value;
            }
        }
    }
}
