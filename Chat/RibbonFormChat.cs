using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using agsXMPP;
using agsXMPP.protocol.client;
using Message = agsXMPP.protocol.client.Message;

namespace Chat
{
    public sealed partial class RibbonFormChat : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private XmppClientConnection _connection;

        private string _nickName;

        private Jid _jid;

        private RibbonFormChat()
        {
            InitializeComponent();
        }

        public RibbonFormChat(XmppClientConnection connection,Jid jid, string nickName):this()
        {
            this._connection = connection;
            this._jid = jid;
            this._nickName = nickName;
            this.Text = @"与"+nickName+@"聊天中";
            Util.ChatFormHashtable.Add(jid.Bare,this);
            _connection.MessageGrabber.Add(jid,MessageCallBack,null);
        }

        private void MessageCallBack(object sender, Message msg, object data)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new MessageCB(MessageCallBack), new object[] {sender, msg, data});
                return;
            }
            if (msg.Body != null)
            {
                IncomingMessage(msg);
            } 
        }

        public void IncomingMessage(Message message)
        {
            chatRichTextBoxShow.SelectionColor = Color.Indigo;
            chatRichTextBoxShow.AppendText(_nickName+" said:");
            chatRichTextBoxShow.SelectionColor = Color.Olive;
            chatRichTextBoxShow.AppendText(message.Body);
            chatRichTextBoxShow.AppendText("\r\n");
        }
        private void OutMessage(Message message)
        {
            chatRichTextBoxShow.SelectionColor = Color.MidnightBlue;
            chatRichTextBoxShow.AppendText("Me said:");
            chatRichTextBoxShow.SelectionColor = Color.RosyBrown;
            chatRichTextBoxShow.AppendText(message.Body);
            chatRichTextBoxShow.AppendText("\r\n");
        }

        private void barButtonItemSend_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!string.IsNullOrEmpty(this.chatRichTextBoxSend.Text.Trim()))
            {
                Message message = new Message(this._jid) { Type = MessageType.chat, Body = this.chatRichTextBoxSend.Text.Trim() };
                _connection.Send(message);
                OutMessage(message);
                this.chatRichTextBoxSend.Clear();
            } 
        }
    }
}