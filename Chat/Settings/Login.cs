using System;
using agsXMPP.Xml.Dom;

namespace Chat.Settings
{
    public class Login:Element
    {
        public Login()
        {
            this.TagName = "Login";
            this.Namespace = null;
        }

        /// <summary>
        /// IP地址
        /// </summary>
        public String Address
        {
            get { return GetTag("Address"); }
            set { SetTag("Address",value);}
        }
        /// <summary>
        /// 端口
        /// </summary>
        public int Port
        {
            get { return GetTagInt("Port"); }
            set { SetTag("Port",value);}
        }

        /// <summary>
        /// Priority
        /// </summary>
        public int Priority
        {
            get { return GetTagInt("Priority"); }
            set { SetTag("Priority", value); }
        }
        /// <summary>
        /// 资源名
        /// </summary>
        public String Resource
        {
            get { return GetTag("Resource"); }
            set { SetTag("Resource", value); }
        }
        /// <summary>
        /// 使用SSL
        /// </summary>
        public bool Ssl
        {
            get { return GetTagBool("Ssl"); }
            set { SetTag("Ssl", value); }
        }
    }
}
