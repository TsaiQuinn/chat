using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ChatControl.ChatListBox
{
    //有待解决
    //[TypeConverter(typeof(ExpandableObjectConverter))]
    public class ChatListSubItem : IComparable
    {
        #region Fields

        private Rectangle bounds;

        private string displayName;
        private string resource;
        private Image headImage;

        private string ipAddress;

        private bool isTwinkle;

        private string nicName;

        private ChatListItem ownerListItem;

        private string personalMsg;

        private UserStatus status;

        #endregion

        #region Constructors and Destructors

        public ChatListSubItem()
        {
            this.status = UserStatus.Online;
            this.displayName = "displayName";
            this.nicName = "nicName";
            this.personalMsg = "Personal Message ...";
        }

        public ChatListSubItem(string nicname)
        {
            this.nicName = nicname;
        }

        public ChatListSubItem(string nicname, UserStatus status)
        {
            this.nicName = nicname;
            this.status = status;
        }

        public ChatListSubItem(string nicname, string displayname, string personalmsg)
        {
            this.nicName = nicname;
            this.displayName = displayname;
            this.personalMsg = personalmsg;
        }

        public ChatListSubItem(string nicname, string displayname, string personalmsg, UserStatus status)
        {
            this.nicName = nicname;
            this.displayName = displayname;
            this.personalMsg = personalmsg;
            this.status = status;
        }

        public ChatListSubItem(
            int id, string nicname, string displayname, string personalmsg, UserStatus status, Bitmap head)
        {
            this.Id = id;
            this.nicName = nicname;
            this.displayName = displayname;
            this.personalMsg = personalmsg;
            this.status = status;
            this.headImage = head;
        }

        #endregion

        //在线状态

        #region Enums

        public enum UserStatus
        {
            QMe,

            Online,

            Away,

            Busy,

            DontDisturb,

            OffLine //貌似对于列表而言 没有隐身状态
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     获取列表子项显示区域
        /// </summary>
        [Browsable(false)]
        public Rectangle Bounds
        {
            get
            {
                return this.bounds;
            }
            internal set
            {
                this.bounds = value;
            }
        }

        /// <summary>
        ///     获取或者设置用户备注名称
        /// </summary>
        public string DisplayName
        {
            get
            {
                return this.displayName;
            }
            set
            {
                this.displayName = value;
                this.RedrawSubItem();
            }
        }

        /// <summary>
        ///     获取或者设置用户头像
        /// </summary>
        public Image HeadImage
        {
            get
            {
                return this.headImage;
            }
            set
            {
                this.headImage = value;
                this.RedrawSubItem();
            }
        }

        /// <summary>
        ///     获取头像显示区域
        /// </summary>
        [Browsable(false)]
        public Rectangle HeadRect { get; internal set; }

        /// <summary>
        ///     获取或者设置用户账号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 账号 Jid
        /// </summary>
        public string JidUser { get; set; }

        /// <summary>
        /// 获取或者设置用户IP地址
        /// </summary>
        public string IpAddress
        {
            get
            {
                return this.ipAddress;
            }
            set
            {
                if (!this.CheckIpAddress(value))
                {
                    throw new ArgumentException("Cannot format " + value + " to IPAddress");
                }
                this.ipAddress = value;
            }
        }

        /// <summary>
        ///     获取或者设置是否闪动
        /// </summary>
        public bool IsTwinkle
        {
            get
            {
                return this.isTwinkle;
            }
            set
            {
                if (this.isTwinkle == value)
                {
                    return;
                }
                if (this.ownerListItem == null)
                {
                    return;
                }
                this.isTwinkle = value;
                if (this.isTwinkle)
                {
                    this.ownerListItem.TwinkleSubItemNumber++;
                }
                else
                {
                    this.ownerListItem.TwinkleSubItemNumber--;
                }
            }
        }

        /// <summary>
        ///     获取或者设置用户昵称
        /// </summary>
        public string NicName
        {
            get
            {
                return this.nicName;
            }
            set
            {
                this.nicName = value;
                this.RedrawSubItem();
            }
        }

        /// <summary>
        ///     获取当前列表子项所在的列表项
        /// </summary>
        [Browsable(false)]
        public ChatListItem OwnerListItem
        {
            get
            {
                return this.ownerListItem;
            }
            internal set
            {
                this.ownerListItem = value;
            }
        }

        /// <summary>
        ///     获取或者设置用户签名信息
        /// </summary>
        public string PersonalMsg
        {
            get
            {
                return this.personalMsg;
            }
            set
            {
                this.personalMsg = value;
                this.RedrawSubItem();
            }
        }

        /// <summary>
        ///     获取或者设置用户当前状态
        /// </summary>
        public UserStatus Status
        {
            get
            {
                return this.status;
            }
            set
            {
                if (this.status == value)
                {
                    return;
                }
                this.status = value;
                if (this.ownerListItem != null)
                {
                    this.ownerListItem.SubItems.Sort();
                }
            }
        }

        /// <summary>
        ///     获取或者设置用户Tcp端口
        /// </summary>
        public int TcpPort { get; set; }

        /// <summary>
        ///     获取或者设置用户Upd端口
        /// </summary>
        public int UpdPort { get; set; }
        public string Resource
        {
            get
            {
                return this.resource;
            }
            set
            {
                this.resource = value;
                this.RedrawSubItem();
            }
        }
        #endregion

        #region Properties

        internal bool IsTwinkleHide { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     获取当前用户的黑白头像
        /// </summary>
        /// <returns>黑白头像</returns>
        public Bitmap GetDarkImage()
        {
            var b = new Bitmap(this.headImage);
            Bitmap bmp = b.Clone(
                new Rectangle(0, 0, this.headImage.Width, this.headImage.Height), PixelFormat.Format24bppRgb);
            b.Dispose();
            BitmapData bmpData = bmp.LockBits(
                new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, bmp.PixelFormat);
            var byColorInfo = new byte[bmp.Height * bmpData.Stride];
            Marshal.Copy(bmpData.Scan0, byColorInfo, 0, byColorInfo.Length);
            for (int x = 0, xLen = bmp.Width; x < xLen; x++)
            {
                for (int y = 0, yLen = bmp.Height; y < yLen; y++)
                {
                    byColorInfo[y * bmpData.Stride + x * 3] =
                        byColorInfo[y * bmpData.Stride + x * 3 + 1] =
                        byColorInfo[y * bmpData.Stride + x * 3 + 2] =
                        this.GetAvg(
                            byColorInfo[y * bmpData.Stride + x * 3],
                            byColorInfo[y * bmpData.Stride + x * 3 + 1],
                            byColorInfo[y * bmpData.Stride + x * 3 + 2]);
                }
            }
            Marshal.Copy(byColorInfo, 0, bmpData.Scan0, byColorInfo.Length);
            bmp.UnlockBits(bmpData);
            return bmp;
        }

        #endregion

        #region Explicit Interface Methods

        int IComparable.CompareTo(object obj)
        {
            if (!(obj is ChatListSubItem))
            {
                throw new NotImplementedException("obj is not ChatListSubItem");
            }
            var subItem = obj as ChatListSubItem;
            return (this.status).CompareTo(subItem.status);
        }

        #endregion

        #region Methods

        private bool CheckIpAddress(string str)
        {
            string[] strIp = str.Split('.');
            if (strIp.Length != 4)
            {
                return false;
            }
            for (int i = 0; i < 4; i++)
            {
                try
                {
                    if (Convert.ToInt32(str[i]) > 255)
                    {
                        return false;
                    }
                }
                catch (FormatException)
                {
                    return false;
                }
            }
            return true;
        }

        private byte GetAvg(byte b, byte g, byte r)
        {
            return (byte)((r + g + b) / 3);
        }

        private void RedrawSubItem()
        {
            if (this.ownerListItem != null)
            {
                if (this.ownerListItem.OwnerChatListBox != null)
                {
                    this.ownerListItem.OwnerChatListBox.Invalidate(this.bounds);
                }
            }
        }

        #endregion
    }
}