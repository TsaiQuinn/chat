using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using agsXMPP.Xml.Dom;
using Chat.Settings;
using DevExpress.XtraEditors; 

namespace Chat
{
    public partial class XtraFormSetting : DevExpress.XtraEditors.XtraForm
    { 
        public event EventHandler<SettingEventArg> SettingSaveEvent;

        public XtraFormSetting()
        {
            InitializeComponent();
            LoadSetting();
        }

        /// <summary>
        /// 配置文件路径
        /// </summary>
        private string SettingFileName
        {
            get
            {
                return Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Settings.xml";
            }
        }

        private void simpleButtonConfirm_Click(object sender, EventArgs e)
        {
            Document document = new Document();
            Settings.Settings settings = new Settings.Settings();
            Login login = new Login(){
                Address = this.textEditServerIP.Text.Trim(),
                Resource = this.textEditResource.Text.Trim(),
                Port = int.Parse(textEditServerPort.Text.Trim()),
                Priority = Convert.ToInt32(numericUpDownPriority.Value),
                Ssl = this.checkBoxSSL.Checked
            };
            document.ChildNodes.Add(settings);
            settings.Login = login;
            document.Save(SettingFileName);
            if (SettingSaveEvent != null)
            {
                SettingSaveEvent(this, new SettingEventArg() { Login = login });
            }
            this.Close();
        }
        /// <summary> 加载配置
        /// </summary>
        private void LoadSetting()
        {
            if (File.Exists(SettingFileName))
            {
                Document document = new Document();
                document.LoadFile(SettingFileName);
                Login login = document.RootElement.SelectSingleElement(typeof(Login)) as Login;
                if (login != null)
                {
                    this.textEditResource.Text = login.Resource;
                    this.textEditServerIP.Text = login.Address; 
                    this.numericUpDownPriority.Value = login.Priority;
                    this.checkBoxSSL.Checked = login.Ssl;
                }
            }
        } 
    }
}