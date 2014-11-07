// *************************************************************
// * Copyirght：Copyright (C) 2014 -  All rights reserved
// * Solution：Chat
// * Project：Chat
// * File：Util.cs
// * Author：CK
// * CreateDate：2014-07-20-17:48
// * ModifyDate：2014-07-20-17:48
// *************************************************************

using System.Collections;
using System.Collections.Generic;
using agsXMPP;

namespace Chat
{
    public class Util
    {
        public  static Hashtable ChatFormHashtable=new Hashtable();
        public static Hashtable GroupChatHashtable=new Hashtable();
        public class XmppServices
        {
            public XmppServices()
            {
            }

            public List<Jid> Search = new List<Jid>();
            public List<Jid> Proxy = new List<Jid>(); 
        }

        public static XmppServices Services = new XmppServices(); 
    }
}