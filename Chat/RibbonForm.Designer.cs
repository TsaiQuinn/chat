using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Chat
{
    partial class RibbonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonForm));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.labelName = new DevExpress.XtraEditors.LabelControl();
            this.labelPassword = new DevExpress.XtraEditors.LabelControl();
            this.textEditPassword = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonLogin = new DevExpress.XtraEditors.SimpleButton();
            this.progressPanel = new DevExpress.XtraWaitForm.ProgressPanel();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItem = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonItemSetting = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemFind = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageFriend = new DevExpress.XtraTab.XtraTabPage();
            this.chatListBoxFriend = new ChatControl.ChatListBox.ChatListBox();
            this.xtraTabPageGroup = new DevExpress.XtraTab.XtraTabPage();
            this.chatListBoxGroup = new ChatControl.ChatListBox.ChatListBox();
            this.xtraTabPageHistory = new DevExpress.XtraTab.XtraTabPage();
            this.chatListBoxHistory = new ChatControl.ChatListBox.ChatListBox();
            this.xtraTabPageService = new DevExpress.XtraTab.XtraTabPage();
            this.treeList = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumnName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumnValue = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.panelControlMiddler = new DevExpress.XtraEditors.PanelControl();
            this.panelControlButtom = new DevExpress.XtraEditors.PanelControl();
            this.textEditFind = new DevExpress.XtraEditors.TextEdit();
            this.panelControlTop = new DevExpress.XtraEditors.PanelControl();
            this.pictureHead = new DevExpress.XtraEditors.PictureEdit();
            this.labelControlName = new DevExpress.XtraEditors.LabelControl();
            this.errorProvider = new System.Windows.Forms.ErrorProvider();
            this.defaultToolTipController = new DevExpress.Utils.DefaultToolTipController();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.xtraTabControl.SuspendLayout();
            this.xtraTabPageFriend.SuspendLayout();
            this.xtraTabPageGroup.SuspendLayout();
            this.xtraTabPageHistory.SuspendLayout();
            this.xtraTabPageService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMiddler)).BeginInit();
            this.panelControlMiddler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlButtom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTop)).BeginInit();
            this.panelControlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHead.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // textEditName
            // 
            this.textEditName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditName.EditValue = "";
            this.textEditName.Location = new System.Drawing.Point(114, 191);
            this.textEditName.Name = "textEditName";
            this.textEditName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textEditName.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            this.textEditName.Properties.NullText = "请输入用户名";
            this.textEditName.Size = new System.Drawing.Size(158, 22);
            this.textEditName.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.Location = new System.Drawing.Point(64, 194);
            this.labelName.LookAndFeel.SkinName = "Office 2010 Blue";
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(36, 14);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "用户名";
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPassword.Location = new System.Drawing.Point(64, 244);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(32, 14);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "密  码";
            // 
            // textEditPassword
            // 
            this.textEditPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditPassword.Location = new System.Drawing.Point(114, 241);
            this.textEditPassword.Name = "textEditPassword";
            this.textEditPassword.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            this.textEditPassword.Properties.PasswordChar = '●';
            this.textEditPassword.Size = new System.Drawing.Size(158, 22);
            this.textEditPassword.TabIndex = 3;
            // 
            // simpleButtonLogin
            // 
            this.simpleButtonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonLogin.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButtonLogin.Appearance.Options.UseForeColor = true;
            this.simpleButtonLogin.Location = new System.Drawing.Point(114, 302);
            this.simpleButtonLogin.LookAndFeel.SkinName = "Office 2010 Blue";
            this.simpleButtonLogin.Name = "simpleButtonLogin";
            this.simpleButtonLogin.Size = new System.Drawing.Size(114, 30);
            this.simpleButtonLogin.TabIndex = 4;
            this.simpleButtonLogin.Text = "登陆";
            this.simpleButtonLogin.Click += new System.EventHandler(this.simpleButtonLogin_Click);
            // 
            // progressPanel
            // 
            this.progressPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.progressPanel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel.Appearance.Options.UseBackColor = true;
            this.progressPanel.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressPanel.AppearanceCaption.Options.UseFont = true;
            this.progressPanel.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progressPanel.AppearanceDescription.Options.UseFont = true;
            this.progressPanel.Caption = "登陆中●●●";
            this.progressPanel.Description = "正在处理一些事情....";
            this.progressPanel.Location = new System.Drawing.Point(105, 200);
            this.progressPanel.LookAndFeel.SkinName = "Office 2010 Blue";
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Size = new System.Drawing.Size(137, 68);
            this.progressPanel.TabIndex = 5;
            this.progressPanel.Text = "progressPanel";
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barCheckItem,
            this.barButtonItemSetting,
            this.barButtonItemFind,
            this.barButtonItem5});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.barButtonItem1);
            this.ribbon.PageHeaderItemLinks.Add(this.barButtonItem2);
            this.ribbon.PageHeaderItemLinks.Add(this.barCheckItem);
            this.ribbon.PageHeaderItemLinks.Add(this.barButtonItemSetting);
            this.ribbon.Size = new System.Drawing.Size(330, 53);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barCheckItem
            // 
            this.barCheckItem.Caption = "是否显示日志";
            this.barCheckItem.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.barCheckItem.Glyph = ((System.Drawing.Image)(resources.GetObject("barCheckItem.Glyph")));
            this.barCheckItem.Id = 7;
            this.barCheckItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barCheckItem.LargeGlyph")));
            this.barCheckItem.Name = "barCheckItem";
            this.barCheckItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            toolTipTitleItem1.Text = "是否显示日志";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "通过日志可以查看系统收发的数据";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.barCheckItem.SuperTip = superToolTip1;
            this.barCheckItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItem_ItemClick);
            // 
            // barButtonItemSetting
            // 
            this.barButtonItemSetting.Caption = "设置";
            this.barButtonItemSetting.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemSetting.Glyph")));
            this.barButtonItemSetting.Id = 3;
            this.barButtonItemSetting.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemSetting.LargeGlyph")));
            this.barButtonItemSetting.Name = "barButtonItemSetting";
            this.barButtonItemSetting.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)));
            toolTipTitleItem2.Text = "设置登录参数";
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "登录IP地址、端口号、域、资源名";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.barButtonItemSetting.SuperTip = superToolTip2;
            this.barButtonItemSetting.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSetting_ItemClick);
            // 
            // barButtonItemFind
            // 
            this.barButtonItemFind.Caption = "搜索";
            this.barButtonItemFind.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemFind.Glyph")));
            this.barButtonItemFind.Id = 4;
            this.barButtonItemFind.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemFind.LargeGlyph")));
            this.barButtonItemFind.Name = "barButtonItemFind";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.Glyph")));
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.LargeGlyph")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barButtonItemFind);
            this.ribbonStatusBar.ItemLinks.Add(this.barButtonItem5);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 597);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(330, 32);
            // 
            // panelControl
            // 
            this.defaultToolTipController.SetAllowHtmlText(this.panelControl, DevExpress.Utils.DefaultBoolean.Default);
            this.panelControl.Controls.Add(this.xtraTabControl);
            this.panelControl.Controls.Add(this.panelControlMiddler);
            this.panelControl.Controls.Add(this.panelControlTop);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 53);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(330, 544);
            this.panelControl.TabIndex = 2;
            // 
            // xtraTabControl
            // 
            this.xtraTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl.Location = new System.Drawing.Point(0, 135);
            this.xtraTabControl.Name = "xtraTabControl";
            this.xtraTabControl.SelectedTabPage = this.xtraTabPageFriend;
            this.xtraTabControl.Size = new System.Drawing.Size(330, 409);
            this.xtraTabControl.TabIndex = 2;
            this.xtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageFriend,
            this.xtraTabPageGroup,
            this.xtraTabPageHistory,
            this.xtraTabPageService});
            // 
            // xtraTabPageFriend
            // 
            this.xtraTabPageFriend.Controls.Add(this.chatListBoxFriend);
            this.xtraTabPageFriend.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPageFriend.Image")));
            this.xtraTabPageFriend.Name = "xtraTabPageFriend";
            this.xtraTabPageFriend.Size = new System.Drawing.Size(324, 362);
            this.xtraTabPageFriend.Text = "好友";
            // 
            // chatListBoxFriend
            // 
            this.defaultToolTipController.SetAllowHtmlText(this.chatListBoxFriend, DevExpress.Utils.DefaultBoolean.Default);
            this.chatListBoxFriend.BackColor = System.Drawing.Color.White;
            this.chatListBoxFriend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatListBoxFriend.ForeColor = System.Drawing.Color.DarkOrange;
            this.chatListBoxFriend.IconSizeMode = ChatControl.ChatListBox.ChatListItemIcon.Large;
            this.chatListBoxFriend.Location = new System.Drawing.Point(0, 0);
            this.chatListBoxFriend.Name = "chatListBoxFriend";
            this.chatListBoxFriend.Size = new System.Drawing.Size(324, 362);
            this.chatListBoxFriend.TabIndex = 0;
            this.chatListBoxFriend.DoubleClickSubItem += new ChatControl.ChatListBox.ChatListBox.ChatListEventHandler(this.chatListBoxFriend_DoubleClickSubItem);
            // 
            // xtraTabPageGroup
            // 
            this.xtraTabPageGroup.Controls.Add(this.chatListBoxGroup);
            this.xtraTabPageGroup.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPageGroup.Image")));
            this.xtraTabPageGroup.Name = "xtraTabPageGroup";
            this.xtraTabPageGroup.Size = new System.Drawing.Size(324, 366);
            this.xtraTabPageGroup.Text = "群组";
            // 
            // chatListBoxGroup
            // 
            this.defaultToolTipController.SetAllowHtmlText(this.chatListBoxGroup, DevExpress.Utils.DefaultBoolean.Default);
            this.chatListBoxGroup.BackColor = System.Drawing.Color.White;
            this.chatListBoxGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatListBoxGroup.ForeColor = System.Drawing.Color.DarkOrange;
            this.chatListBoxGroup.Location = new System.Drawing.Point(0, 0);
            this.chatListBoxGroup.Name = "chatListBoxGroup";
            this.chatListBoxGroup.Size = new System.Drawing.Size(324, 366);
            this.chatListBoxGroup.TabIndex = 0;
            // 
            // xtraTabPageHistory
            // 
            this.xtraTabPageHistory.Controls.Add(this.chatListBoxHistory);
            this.xtraTabPageHistory.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPageHistory.Image")));
            this.xtraTabPageHistory.Name = "xtraTabPageHistory";
            this.xtraTabPageHistory.Size = new System.Drawing.Size(324, 366);
            this.xtraTabPageHistory.Text = "会话";
            // 
            // chatListBoxHistory
            // 
            this.defaultToolTipController.SetAllowHtmlText(this.chatListBoxHistory, DevExpress.Utils.DefaultBoolean.Default);
            this.chatListBoxHistory.BackColor = System.Drawing.Color.White;
            this.chatListBoxHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatListBoxHistory.ForeColor = System.Drawing.Color.DarkOrange;
            this.chatListBoxHistory.Location = new System.Drawing.Point(0, 0);
            this.chatListBoxHistory.Name = "chatListBoxHistory";
            this.chatListBoxHistory.Size = new System.Drawing.Size(324, 366);
            this.chatListBoxHistory.TabIndex = 0;
            // 
            // xtraTabPageService
            // 
            this.xtraTabPageService.Controls.Add(this.treeList);
            this.xtraTabPageService.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPageService.Image")));
            this.xtraTabPageService.Name = "xtraTabPageService";
            this.xtraTabPageService.Size = new System.Drawing.Size(324, 366);
            this.xtraTabPageService.Text = "服务";
            // 
            // treeList
            // 
            this.treeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumnName,
            this.treeListColumnValue});
            this.treeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList.Location = new System.Drawing.Point(0, 0);
            this.treeList.Name = "treeList";
            this.treeList.OptionsBehavior.Editable = false;
            this.treeList.Size = new System.Drawing.Size(324, 366);
            this.treeList.TabIndex = 0;
            // 
            // treeListColumnName
            // 
            this.treeListColumnName.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("treeListColumnName.AppearanceHeader.Image")));
            this.treeListColumnName.AppearanceHeader.Options.UseImage = true;
            this.treeListColumnName.AppearanceHeader.Options.UseTextOptions = true;
            this.treeListColumnName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumnName.Caption = "服务名称";
            this.treeListColumnName.FieldName = "服务名称";
            this.treeListColumnName.MinWidth = 100;
            this.treeListColumnName.Name = "treeListColumnName";
            this.treeListColumnName.OptionsColumn.AllowEdit = false;
            this.treeListColumnName.Visible = true;
            this.treeListColumnName.VisibleIndex = 0;
            this.treeListColumnName.Width = 100;
            // 
            // treeListColumnValue
            // 
            this.treeListColumnValue.AppearanceHeader.Options.UseTextOptions = true;
            this.treeListColumnValue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumnValue.Caption = "双击查看";
            this.treeListColumnValue.FieldName = "双击查看";
            this.treeListColumnValue.MinWidth = 100;
            this.treeListColumnValue.Name = "treeListColumnValue";
            this.treeListColumnValue.OptionsColumn.AllowEdit = false;
            this.treeListColumnValue.Visible = true;
            this.treeListColumnValue.VisibleIndex = 1;
            this.treeListColumnValue.Width = 100;
            // 
            // panelControlMiddler
            // 
            this.defaultToolTipController.SetAllowHtmlText(this.panelControlMiddler, DevExpress.Utils.DefaultBoolean.Default);
            this.panelControlMiddler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControlMiddler.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControlMiddler.Controls.Add(this.panelControlButtom);
            this.panelControlMiddler.Controls.Add(this.textEditFind);
            this.panelControlMiddler.Location = new System.Drawing.Point(0, 107);
            this.panelControlMiddler.Name = "panelControlMiddler";
            this.panelControlMiddler.Size = new System.Drawing.Size(330, 29);
            this.panelControlMiddler.TabIndex = 1;
            // 
            // panelControlButtom
            // 
            this.defaultToolTipController.SetAllowHtmlText(this.panelControlButtom, DevExpress.Utils.DefaultBoolean.Default);
            this.panelControlButtom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControlButtom.Location = new System.Drawing.Point(0, 28);
            this.panelControlButtom.Name = "panelControlButtom";
            this.panelControlButtom.Size = new System.Drawing.Size(330, 407);
            this.panelControlButtom.TabIndex = 2;
            // 
            // textEditFind
            // 
            this.textEditFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEditFind.Location = new System.Drawing.Point(0, 0);
            this.textEditFind.MenuManager = this.ribbon;
            this.textEditFind.Name = "textEditFind";
            this.textEditFind.Size = new System.Drawing.Size(330, 22);
            this.textEditFind.TabIndex = 0;
            // 
            // panelControlTop
            // 
            this.defaultToolTipController.SetAllowHtmlText(this.panelControlTop, DevExpress.Utils.DefaultBoolean.Default);
            this.panelControlTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControlTop.Controls.Add(this.pictureHead);
            this.panelControlTop.Controls.Add(this.labelControlName);
            this.panelControlTop.Location = new System.Drawing.Point(0, 0);
            this.panelControlTop.Name = "panelControlTop";
            this.panelControlTop.Size = new System.Drawing.Size(330, 106);
            this.panelControlTop.TabIndex = 0;
            // 
            // pictureHead
            // 
            this.pictureHead.Location = new System.Drawing.Point(5, 5);
            this.pictureHead.MenuManager = this.ribbon;
            this.pictureHead.Name = "pictureHead";
            this.pictureHead.Size = new System.Drawing.Size(100, 96);
            this.pictureHead.TabIndex = 2;
            // 
            // labelControlName
            // 
            this.labelControlName.Location = new System.Drawing.Point(152, 39);
            this.labelControlName.Name = "labelControlName";
            this.labelControlName.Size = new System.Drawing.Size(36, 14);
            this.labelControlName.TabIndex = 1;
            this.labelControlName.Text = "用户名";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // RibbonForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.defaultToolTipController.SetAllowHtmlText(this, DevExpress.Utils.DefaultBoolean.Default);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 629);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.progressPanel);
            this.Controls.Add(this.simpleButtonLogin);
            this.Controls.Add(this.textEditPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textEditName);
            this.Controls.Add(this.ribbon);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(340, 630);
            this.Name = "RibbonForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "XMPP-CHAT";
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            this.xtraTabPageFriend.ResumeLayout(false);
            this.xtraTabPageGroup.ResumeLayout(false);
            this.xtraTabPageHistory.ResumeLayout(false);
            this.xtraTabPageService.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMiddler)).EndInit();
            this.panelControlMiddler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlButtom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTop)).EndInit();
            this.panelControlTop.ResumeLayout(false);
            this.panelControlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHead.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarCheckItem barCheckItem;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSetting;
        private DevExpress.XtraBars.BarButtonItem barButtonItemFind;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private DevExpress.XtraEditors.PanelControl panelControlTop;
        private DevExpress.XtraEditors.LabelControl labelControlName;
        private DevExpress.XtraEditors.PanelControl panelControlMiddler;
        private DevExpress.XtraEditors.TextEdit textEditFind;
        private DevExpress.XtraEditors.PanelControl panelControlButtom;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageFriend;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageGroup;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageHistory;
        #region 登陆窗体控件
        private DevExpress.XtraEditors.TextEdit textEditName;
        private DevExpress.XtraEditors.LabelControl labelName;
        private DevExpress.XtraEditors.LabelControl labelPassword;
        private DevExpress.XtraEditors.TextEdit textEditPassword;
        private DevExpress.XtraEditors.SimpleButton simpleButtonLogin;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel; 
        #endregion 登陆窗体控件
//        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private ChatControl.ChatListBox.ChatListBox chatListBoxFriend;
        private ChatControl.ChatListBox.ChatListBox chatListBoxGroup;
        private ChatControl.ChatListBox.ChatListBox chatListBoxHistory;
        private DevExpress.XtraEditors.PictureEdit pictureHead;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageService;
        private DevExpress.XtraTreeList.TreeList treeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnValue;
        private DevExpress.Utils.DefaultToolTipController defaultToolTipController;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
    }
}