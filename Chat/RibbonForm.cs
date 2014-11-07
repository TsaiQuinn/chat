// *************************************************************
// * Copyirght：Copyright (C) 2014 -  All rights reserved
// * Solution：Chat
// * Project：Chat
// * File：RibbonForm.cs
// * Author：CK
// * CreateDate：2014-07-16-19:48
// * ModifyDate：2014-07-23-10:56
// *************************************************************

#region

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using agsXMPP;
using agsXMPP.net;
using agsXMPP.protocol.Base;
using agsXMPP.protocol.client;
using agsXMPP.protocol.extensions.si;
using agsXMPP.protocol.iq.disco;
using agsXMPP.protocol.iq.roster;
using agsXMPP.protocol.iq.vcard;
using agsXMPP.protocol.x;
using agsXMPP.protocol.x.data;
using agsXMPP.Xml.Dom;
using Chat.Settings;
using ChatControl.ChatListBox;
using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Nodes;
using Entity;
using Message = agsXMPP.protocol.client.Message;
using RosterItem = agsXMPP.protocol.iq.roster.RosterItem;
using Uri = agsXMPP.Uri;
using XMPPFile = agsXMPP.protocol.extensions.filetransfer.File;
using XMPPVersion = agsXMPP.protocol.iq.version.Version;

#endregion

namespace Chat
{
    public partial class RibbonForm :DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly XmppClientConnection _connection;

        private readonly DiscoManager _discoManager;

        private readonly XtraFormDebug _formDebug;

        private XtraFormSetting _setXtraForm;

        private Dictionary<Jid, string> _friendDictionary = new Dictionary<Jid, string>();

        private string _packetId;

        private RosterManager _rosterManager;

        public RibbonForm()
        {
            InitializeComponent();
            panelControl.Visible = false;
            progressPanel.Visible = false;
            _connection = new XmppClientConnection {SocketConnectionType = SocketConnectionType.Direct};
            _connection.OnReadXml += _connection_OnReadXml;
            _connection.OnWriteXml += _connection_OnWriteXml;
            _connection.OnRosterStart += _connection_OnRosterStart;
            _connection.OnRosterEnd += _connection_OnRosterEnd;
            _connection.OnRosterItem += _connection_OnRosterItem;
            _connection.OnLogin += _connection_OnLogin;
            _connection.OnClose += _connection_OnClose;
            _connection.OnError += _connection_OnError;
            _connection.OnPresence += _connection_OnPresence;
            _connection.OnMessage += _connection_OnMessage;
            _connection.OnIq += _connection_OnIq;
            _connection.OnAuthError += _connection_OnAuthError;
            _connection.OnSocketError += _connection_OnSocketError;
            _connection.OnStreamError += _connection_OnStreamError;
            _discoManager = new DiscoManager(_connection);
            _rosterManager = new RosterManager(_connection);
            _formDebug = new XtraFormDebug();
        }

        private Login Login { get; set; }

        private void _connection_OnStreamError(object sender, Element e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new ErrorHandler(_connection_OnSocketError), new[] {sender, e});
            }
//            XtraMessageBox.Show(string.Format("链接错误！"), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            progressPanel.Visible = false;
//            ControlVisible(true);
        }

        private void _connection_OnSocketError(object sender, Exception ex)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new ErrorHandler(_connection_OnSocketError), new[] {sender, ex});
                return;
            }
            XtraMessageBox.Show(string.Format("Socket Error!\r\n{0}", ex.Message), "错误", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            progressPanel.Visible = false;
            ControlVisible(true);
        }

        private void _connection_OnAuthError(object sender, Element e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new XmppElementHandler(_connection_OnAuthError), new[] {sender, e});
                return;
            }
            if (_connection.XmppConnectionState != XmppConnectionState.Disconnected)
                _connection.Close();
            XtraMessageBox.Show(@"用户名或密码错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            progressPanel.Visible = false;
            ControlVisible(true);
        }

        private void _connection_OnIq(object sender, IQ iq)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new IqHandler(_connection_OnIq), new[] {sender, iq});
                return;
            }
            if (iq != null)
            {
                if (iq.HasTag(typeof (SI)))
                {
                    if (iq.Type == IqType.set)
                    {
                        SI si = iq.SelectSingleElement(typeof (SI)) as SI;
                        if (si != null)
                        {
                            XMPPFile file = si.File;
                            if (file != null)
                            {
                                //todo:文件传输
                            }
                        }
                    }
                }
                else
                {
                    Element query = iq.Query;
                    if (query != null)
                    {
                        if (query.GetType() == typeof (XMPPVersion))
                        {
                            XMPPVersion version = query as XMPPVersion;
                            if (iq.Type == IqType.get && version != null)
                            {
                                iq.SwitchDirection();
                                iq.Type = IqType.result;
                                version.Name = "XMPP";
                                version.Ver = "1.0";
                                version.Os = Environment.OSVersion.ToString();
                                _connection.Send(iq);
                            }
                        }
                    }
                }
            }
        }

        private void _connection_OnMessage(object sender, Message msg)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new OnMessageDelegate(_connection_OnMessage), new[] {sender, msg});
                return;
            }
            if (msg.Type == MessageType.groupchat)
                return;
            if (msg.Type == MessageType.error)
            {
                return;
            }
            if (msg.HasTag(typeof (Data)))
            {
                Element e = msg.SelectSingleElement(typeof (Data));
                Data xdata = e as Data;
                if (xdata != null && xdata.Type == XDataFormType.form)
                {
                    //TODO:xdata
                }
            }
            else if (msg.HasTag(typeof (agsXMPP.protocol.extensions.ibb.Data)))
            {
            }
            else
            {
                if (msg.Body != null)
                {
                    RibbonFormChat formChat = null;
                    if (Util.ChatFormHashtable.Contains(msg.From.Bare))
                    {
                        formChat = (RibbonFormChat) Util.ChatFormHashtable[msg.From.Bare];
                    }
                    else
                    {
                        formChat = new RibbonFormChat(_connection, msg.From, msg.From.User);
                    }
                    formChat.Show();
                    formChat.IncomingMessage(msg);
                }
            }
        }

        private void _connection_OnPresence(object sender, Presence pres)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new OnPresenceDelegate(_connection_OnPresence), new[] {sender, pres});
                return;
            }
            if (pres.Type == PresenceType.subscribe)
            {
                //todo:添加好友
            }
            else if (pres.Type == PresenceType.subscribed)
            {
            }
            else if (pres.Type == PresenceType.unsubscribe)
            {
            }
            else if (pres.Type == PresenceType.unsubscribed)
            {
            }
            else
            {
                try
                {
                    new Thread(() =>
                    {
                        string group =
                            (from pair in _friendDictionary where pair.Key.User == pres.From.User select pair.Value)
                                .FirstOrDefault();
                        if (group != null)
                        {
                            foreach (
                                ChatListItem item in
                                    chatListBoxFriend.Items.Cast<ChatListItem>().Where(item => item.Text == group))
                            {
                                foreach (
                                    ChatListSubItem userSubItem in
                                        item.SubItems.Cast<ChatListSubItem>()
                                            .Where(userSubItem => userSubItem.JidUser == pres.From.Bare))
                                {
                                    userSubItem.Status = pres.Type == PresenceType.unavailable
                                        ? ChatListSubItem.UserStatus.OffLine
                                        : ChatListSubItem.UserStatus.Online;
                                    userSubItem.Resource = string.IsNullOrEmpty(pres.From.Resource)
                                        ? null
                                        : pres.From.Resource;
                                    break;
                                }
                                break;
                            }
                        }
                    }).Start();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void _connection_OnError(object sender, Exception ex)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new ErrorHandler(_connection_OnError), new[] {sender, ex});
            }
        }

        private void _connection_OnClose(object sender)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new ObjectHandler(_connection_OnClose), new[] {sender});
                return;
            }
            XtraMessageBox.Show("连接关闭!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            progressPanel.Visible = false;
            panelControl.Visible = false;
            ControlVisible(true);
        }

        private void _connection_OnLogin(object sender)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new ObjectHandler(_connection_OnLogin), new[] {sender});
                return;
            }
            VcardIq myIq = new VcardIq(IqType.get, null, _connection.MyJID);
            _packetId = myIq.Id;
            _connection.IqGrabber.SendIq(myIq, OnVcardResult, null);
            _discoManager.DiscoverItems(new Jid(_connection.Server), OnDiscoServerResult, null);
        }

        private void OnDiscoServerResult(object sender, IQ iq, object data)
        {
            if (iq.Type == IqType.result)
            {
                Element query = iq.Query;
                if (query != null && query.GetType() == typeof (DiscoItems))
                {
                    DiscoItems items = query as DiscoItems;
                    if (items != null)
                    {
                        DiscoItem[] itms = items.GetDiscoItems();
                        foreach (DiscoItem itm in itms)
                        {
                            if (itm.Jid != null)
                            {
                                _discoManager.DiscoverInformation(itm.Jid, OnDiscoInfoResult, itm);
                                if (itm.Jid.Bare == "conference.ck")
                                { 
                                    this.treeList.BeginUnboundLoad();
                                    this.treeList.AppendNode(new object[] { itm.Name, itm.Jid }, -1);
                                    this.treeList.EndUnboundLoad(); } 
                            } 
                        }
                    }
                }
            }
        }

        private void OnDiscoInfoResult(object sender, IQ iq, object data)
        {
            if (iq.Type == IqType.result)
            {
                if (iq.Query is DiscoInfo)
                {
                    DiscoInfo di = iq.Query as DiscoInfo;
                    Jid jid = iq.From;
                    if (di.HasFeature(Uri.IQ_SEARCH))
                    {
                        if (!Util.Services.Search.Contains(jid))
                        {
                            Util.Services.Search.Add(jid);
                        }
                    }
                    else if (di.HasFeature(Uri.BYTESTREAMS))
                    {
                        if (!Util.Services.Proxy.Contains(jid))
                        {
                            Util.Services.Proxy.Add(jid);
                        }
                    }
                }
            }
        }

        private void OnVcardResult(object sender, IQ iq, object data)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new IqCB(OnVcardResult), new[] {sender, iq, data});
                return;
            }
            if (iq.Type == IqType.result && iq.HasTag(typeof (Vcard)))
            {
                Vcard vcard = iq.Vcard;
                if (vcard != null)
                {
                    if (iq.Id == _packetId)
                    {
                        pictureHead.Image = vcard.Photo.Image;
                        labelControlName.Text = vcard.Nickname;
                    }
                    else
                    {
                        ChatListItem item =
                            chatListBoxFriend.Items.Cast<ChatListItem>().FirstOrDefault(c => c.Text == data.ToString());
                        if (item != null)
                        {
                            ChatListSubItem subItem =
                                item.SubItems.Cast<ChatListSubItem>().FirstOrDefault(sub => sub.JidUser == iq.From.Bare);
                            if (subItem != null)
                            {
                                subItem.HeadImage = vcard.Photo.Image;
                                subItem.NicName = vcard.Name.Given;
                                subItem.DisplayName = vcard.Nickname;
                                subItem.PersonalMsg = null;
                            }
                        }
                    }
                }
            }
        }

        private void _connection_OnRosterEnd(object sender)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new ObjectHandler(_connection_OnRosterEnd), new[] {sender});
                return;
            }
            if (_friendDictionary.Count > 0)
            {
                foreach (KeyValuePair<Jid, string> pair in _friendDictionary)
                {
                    _connection.IqGrabber.SendIq(new VcardIq(IqType.get, pair.Key, _connection.MyJID), OnVcardResult,
                        pair.Value);
                }
            }
            foreach (
                ChatListItem item in
                    _friendDictionary.Select(d => d.Value)
                        .ToList()
                        .Distinct()
                        .Select(@group => new ChatListItem(@group) {IsOpen = false}))
            {
                chatListBoxFriend.Items.Add(item);
            }
            foreach (ChatListItem item in chatListBoxFriend.Items)
            {
                List<Jid> list = (from d in _friendDictionary where d.Value == item.Text select d.Key).ToList();
                foreach (
                    ChatListSubItem subItem in
                        list.Select(
                            jid => new ChatListSubItem {JidUser = jid.Bare, Status = ChatListSubItem.UserStatus.OffLine})
                    )
                {
                    item.SubItems.Add(subItem);
                }
            }
            ControlVisible(false);
            progressPanel.Visible = false;
            panelControl.Visible = true;
        }

        private void _connection_OnRosterItem(object sender, RosterItem item)
        {
            if (InvokeRequired)
            {
                BeginInvoke(
                    new XmppClientConnection.RosterHandler(_connection_OnRosterItem), new[] {sender, item});
                return;
            }
            if (item.Subscription == SubscriptionType.none)
            {
                return;
            }
            if (item.Subscription != SubscriptionType.remove)
            {
                string group = SystermConst.DefaultGroupName;
                if (item.GetGroups().Count > 0)
                {
                    string name = ((Group) item.GetGroups().Item(0)).Name;
                    group = string.IsNullOrEmpty(name) ? SystermConst.DefaultGroupName : name;
                }
                _friendDictionary.Add(item.Jid, group);
            }
        }

        private void _connection_OnRosterStart(object sender)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new ObjectHandler(_connection_OnRosterStart), sender);
                return;
            }
            ChatListItem item = new ChatListItem(SystermConst.DefaultGroupName);
            chatListBoxFriend.Items.Add(item);
        }

        /// <summary>
        ///     发送数据
        /// </summary>
        private void _connection_OnWriteXml(object sender, string xml)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new XmlHandler(_connection_OnWriteXml), new[] {sender, xml});
                return;
            }
            if (_formDebug.SendDataEvent != null)
            {
                _formDebug.SendDataEvent(xml);
            }
        }

        /// <summary>
        ///     收取数据
        /// </summary>
        private void _connection_OnReadXml(object sender, string xml)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new XmlHandler(_connection_OnReadXml), new[] {sender, xml});
                return;
            }
            if (_formDebug.ReceiveEventHandler != null)
            {
                _formDebug.ReceiveEventHandler(this, new ReceiveEventArg {xml = xml});
            }
        }

        /// <summary>
        ///     服务器设置
        /// </summary>
        private void barButtonItemSetting_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_setXtraForm == null)
            {
                _setXtraForm = new XtraFormSetting();
                _setXtraForm.SettingSaveEvent += (o, arg) => { Login = arg.Login; };
                _setXtraForm.Show();
            }
            else
            {
                _setXtraForm.Focus();
            }
        }

        /// <summary>
        ///     登陆按钮
        /// </summary>
        private void simpleButtonLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textEditName.Text.Trim()) || textEditName.Text.Trim().IndexOf('@') == -1)
            {
                errorProvider.Clear();
                errorProvider.SetError(textEditName, "请输入用户名，如：user@servername");
                errorProvider.SetIconAlignment(textEditName, ErrorIconAlignment.MiddleRight);
                errorProvider.SetIconPadding(textEditName, 10);
                return;
            }
            if (String.IsNullOrEmpty(textEditPassword.Text.Trim()))
            {
                errorProvider.Clear();
                errorProvider.SetError(textEditPassword, "请输入用户名");
                errorProvider.SetIconAlignment(textEditPassword, ErrorIconAlignment.MiddleRight);
                errorProvider.SetIconPadding(textEditPassword, 10);
            }
            errorProvider.Clear();
            ControlVisible(false);
            progressPanel.Visible = true;
            if (Login == null)
            {
                string file = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Settings.xml";
                if (File.Exists(file))
                {
                    Document document = new Document();
                    document.LoadFile(file);
                    Login login = document.RootElement.SelectSingleElement(typeof (Login)) as Login;
                    if (login != null)
                    {
                        _connection.Resource = login.Resource;
                        _connection.Port = login.Port;
                        _connection.Priority = login.Priority;
                        _connection.UseSSL = login.Ssl;
                        _connection.ConnectServer = login.Address;
                    }
                    else
                    {
                        XtraMessageBox.Show("请先设置登陆参数!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            else
            {
                _connection.Resource = Login.Resource;
                _connection.Priority = Login.Priority;
                _connection.Port = Login.Port;
                _connection.UseSSL = Login.Ssl;
                _connection.ConnectServer = Login.Address;
            }
            Jid jid = new Jid(textEditName.Text.Trim());
            _connection.Username = jid.User;
            _connection.Server = jid.Server;
            _connection.Password = textEditPassword.Text.Trim();
            _connection.AutoResolveConnectServer = false;
            _connection.UseCompression = false;
            // _connection.SocketConnectionType=agsXMPP.net.SocketConnectionType.Bosh;
            // _connection.ConnectServer = "http://vm-2k:8080/http-bind/";            
            _connection.ClientVersion = "1.0";
            _connection.EnableCapabilities = true;
            _connection.Capabilities.Node = "http://www.ag-software.de/miniclient/caps";
            //connection.SocketConnectionType = agsXMPP.net.SocketConnectionType.HttpPolling;
            _connection.DiscoInfo.AddIdentity(new DiscoIdentity("PC", "WIN8", "Client"));
            _connection.DiscoInfo.AddFeature(new DiscoFeature(Uri.DISCO_INFO));
            _connection.DiscoInfo.AddFeature(new DiscoFeature(Uri.DISCO_ITEMS));
            _connection.DiscoInfo.AddFeature(new DiscoFeature(Uri.MUC));
            _connection.DiscoInfo.AddFeature(new DiscoFeature(Uri.BYTESTREAMS));
            _connection.DiscoInfo.AddFeature(new DiscoFeature(Uri.SI_FILE_TRANSFER));
            _connection.DiscoInfo.AddFeature(new DiscoFeature(Uri.COMMANDS));
            _connection.DiscoInfo.AddFeature(new DiscoFeature(Uri.SI));
            Thread thread = new Thread(() => _connection.Open());
            thread.Start();
        }

        private void barCheckItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (barCheckItem.Checked)
            {
                _formDebug.Show();
            }
            else
            {
                _formDebug.Hide();
            }
        }

        private void ControlVisible(bool flag)
        {
            labelName.Visible =
                labelPassword.Visible =
                    textEditName.Visible = textEditPassword.Visible = simpleButtonLogin.Visible = flag;
        }

        private void chatListBoxFriend_DoubleClickSubItem(object sender, ChatListEventArgs e)
        {
            ChatListSubItem subItem = e.SelectSubItem;
            if (!Util.ChatFormHashtable.ContainsKey(subItem.JidUser))
            {
                RibbonFormChat formChat = new RibbonFormChat(_connection,
                    new Jid(subItem.JidUser) {Resource = subItem.Resource}, subItem.NicName);
                formChat.Show();
            }
        }

        private delegate void OnMessageDelegate(object sender, Message msg);

        private delegate void OnPresenceDelegate(object sender, Presence pres);
    }
}