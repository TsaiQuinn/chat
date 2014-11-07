using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;

namespace Chat
{
    public partial class Test : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Test()
        {
            InitializeComponent();
        }

        private void simpleButtonLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.textEditName.Text.Trim()))
            {
                this.errorProvider.Clear();
//                this.errorProvider.SetError(this.textEditName, "请输入用户名", ErrorType.Critical);
                this.errorProvider.SetError(this.textEditName, "请输入用户名");
                this.errorProvider.SetIconAlignment(this.textEditName,ErrorIconAlignment.MiddleRight);
                this.errorProvider.SetIconPadding(this.textEditName,10);
              return;
            } if (String.IsNullOrEmpty(this.textEditPassword.Text.Trim()))
            {
                this.errorProvider.Clear();
//                this.errorProvider.SetError(this.textEditPassword, "请输入密码", ErrorType.Critical);
                return;
            }
            else
            {
//                this.errorProvider.ClearErrors();
            }
        }
    }
}