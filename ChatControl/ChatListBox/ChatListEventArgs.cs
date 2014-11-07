namespace ChatControl.ChatListBox
{
    //自定义事件参数类
    public class ChatListEventArgs
    {
        #region Fields

        private readonly ChatListSubItem mouseOnSubItem;

        private readonly ChatListSubItem selectSubItem;

        #endregion

        #region Constructors and Destructors

        public ChatListEventArgs(ChatListSubItem mouseonsubitem, ChatListSubItem selectsubitem)
        {
            this.mouseOnSubItem = mouseonsubitem;
            this.selectSubItem = selectsubitem;
        }

        #endregion

        #region Public Properties

        public ChatListSubItem MouseOnSubItem
        {
            get
            {
                return this.mouseOnSubItem;
            }
        }

        public ChatListSubItem SelectSubItem
        {
            get
            {
                return this.selectSubItem;
            }
        }

        #endregion
    }
}