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
    public partial class FormMain : DevExpress.XtraEditors.XtraForm 
    {
        public FormMain()
        {
            InitializeComponent();
            this.panelControl.Visible = false;
            this.progressPanel.Visible = false;
        } 
    }
}