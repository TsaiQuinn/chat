// *************************************************************
// * Copyirght：Copyright (C) 2014 -  All rights reserved
// * Solution：Chat
// * Project：Chat
// * File：Settings.cs
// * Author：CK
// * CreateDate：2014-07-18-11:22
// * ModifyDate：2014-07-18-11:52
// *************************************************************

#region

using agsXMPP.Xml.Dom;

#endregion

namespace Chat.Settings
{
    public class Settings : Element
    { 
        public Settings()
        {
            TagName = "Settings";
        }

        public Login Login
        {
            get { return (Login) SelectSingleElement(typeof(Login)); }
            set
            {
                RemoveTag(typeof(Login));
                if (value != null)
                    AddChild(value);
            }
        }
    }
}