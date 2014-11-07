// *************************************************************
// * Copyirght：Copyright (C) 2014 -  All rights reserved
// * Solution：Chat
// * Project：Entity
// * File：SettingEventArg.cs
// * Author：CK
// * CreateDate：2014-07-17-21:56
// * ModifyDate：2014-07-17-21:58
// *************************************************************

#region

using System;

#endregion

namespace Chat.Settings
{
    public class SettingEventArg : EventArgs
    {  
        public Login Login { get; set; }
    }
}