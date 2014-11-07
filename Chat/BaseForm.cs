using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Chat
{
    public partial class BaseForm : DevExpress.XtraEditors.XtraForm
    {
        public static DevExpress.LookAndFeel.DefaultLookAndFeel DefaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel();
        public BaseForm()
        {
            InitializeComponent();
        }
    }
}