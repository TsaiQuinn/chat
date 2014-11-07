using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.SpellChecker;
using Entity;

namespace Chat
{
    public delegate void SendEventHandler(String xml);

    public partial class XtraFormDebug : BaseForm
    {
        public XtraFormDebug()
        {
            InitializeComponent();
            SendDataEvent += OnSendDataEvent;
            ReceiveEventHandler += OnReceiveEvent;
        }

        public readonly SendEventHandler SendDataEvent;

        public readonly EventHandler<ReceiveEventArg> ReceiveEventHandler;

        private void OnSendDataEvent(string xml)
        {
            if (this.chatRichTextBox.InvokeRequired)
            {
                chatRichTextBox.BeginInvoke(new SendEventHandler(OnSendDataEvent), new object[] { xml });
                return;
            }
            this.chatRichTextBox.SelectionStart = this.chatRichTextBox.Text.Length;
            this.chatRichTextBox.SelectionLength = 0;
            this.chatRichTextBox.SelectionColor = Color.Magenta;
            this.chatRichTextBox.AppendText(string.Format("({0})发送: ",
                DateTime.Now.ToString("yyyy年MM月dd日HH时mm分ss秒ffff")));
            this.chatRichTextBox.SelectionFont = new Font("Tahoma", 12, FontStyle.Regular);
            this.chatRichTextBox.AppendText(xml.Replace("><", ">\r\n<"));
            this.chatRichTextBox.AppendText("\r\n");
            this.chatRichTextBox.Refresh();
        }

        private void OnReceiveEvent(object sender, ReceiveEventArg eventArg)
        {
            if (chatRichTextBox.InvokeRequired)
            {
                chatRichTextBox.BeginInvoke(new EventHandler<ReceiveEventArg>(OnReceiveEvent),
                    new object[] {sender, eventArg});
                return;
            }
            this.chatRichTextBox.SelectionStart = this.chatRichTextBox.Text.Length;
            this.chatRichTextBox.SelectionLength = 0;
            this.chatRichTextBox.SelectionColor = Color.Lime;
            this.chatRichTextBox.AppendText(string.Format("({0})接收: ",
                DateTime.Now.ToString("yyyy年MM月dd日HH时mm分ss秒ffff")));
            this.chatRichTextBox.SelectionFont = new Font("Tahoma", 12, FontStyle.Regular);
            this.chatRichTextBox.AppendText(eventArg.xml.Replace("><", ">\r\n<"));
            this.chatRichTextBox.AppendText("\r\n");
            this.chatRichTextBox.Refresh();
        }

        private void simpleButtonFind_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textEdit.Text.Trim())&&
                !string.IsNullOrEmpty(chatRichTextBox.Text.Trim()))
            {

                int start = chatRichTextBox.Text.IndexOf(textEdit.Text.Trim(), StringComparison.Ordinal);
                }
        }
    }
}