namespace Chat
{
    partial class FormMain
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
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.panelControlBottom = new DevExpress.XtraEditors.PanelControl();
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageFriend = new DevExpress.XtraTab.XtraTabPage();
            this.chatListBoxFriend = new ChatControl.ChatListBox.ChatListBox();
            this.xtraTabPageGroup = new DevExpress.XtraTab.XtraTabPage();
            this.chatListBoxGroup = new ChatControl.ChatListBox.ChatListBox();
            this.xtraTabPageHistory = new DevExpress.XtraTab.XtraTabPage();
            this.chatListBoxHistory = new ChatControl.ChatListBox.ChatListBox();
            this.panelControlCenter = new DevExpress.XtraEditors.PanelControl();
            this.textEditFind = new DevExpress.XtraEditors.TextEdit();
            this.panelControlTop = new DevExpress.XtraEditors.PanelControl();
            this.pictureHead = new System.Windows.Forms.PictureBox();
            this.labName = new DevExpress.XtraEditors.LabelControl();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.labelName = new DevExpress.XtraEditors.LabelControl();
            this.labelPassword = new DevExpress.XtraEditors.LabelControl();
            this.textEditPassword = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonLogin = new DevExpress.XtraEditors.SimpleButton();
            this.progressPanel = new DevExpress.XtraWaitForm.ProgressPanel();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBottom)).BeginInit();
            this.panelControlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.xtraTabControl.SuspendLayout();
            this.xtraTabPageFriend.SuspendLayout();
            this.xtraTabPageGroup.SuspendLayout();
            this.xtraTabPageHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlCenter)).BeginInit();
            this.panelControlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTop)).BeginInit();
            this.panelControlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2010 Blue";
            // 
            // panelControl
            // 
            this.panelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl.ContentImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.panelControl.Controls.Add(this.panelControlBottom);
            this.panelControl.Controls.Add(this.panelControlCenter);
            this.panelControl.Controls.Add(this.panelControlTop);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(301, 590);
            this.panelControl.TabIndex = 2;
            // 
            // panelControlBottom
            // 
            this.panelControlBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControlBottom.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControlBottom.Controls.Add(this.xtraTabControl);
            this.panelControlBottom.Location = new System.Drawing.Point(5, 155);
            this.panelControlBottom.MinimumSize = new System.Drawing.Size(200, 350);
            this.panelControlBottom.Name = "panelControlBottom";
            this.panelControlBottom.Size = new System.Drawing.Size(291, 430);
            this.panelControlBottom.TabIndex = 2;
            // 
            // xtraTabControl
            // 
            this.xtraTabControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl.Name = "xtraTabControl";
            this.xtraTabControl.SelectedTabPage = this.xtraTabPageFriend;
            this.xtraTabControl.Size = new System.Drawing.Size(291, 430);
            this.xtraTabControl.TabIndex = 0;
            this.xtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageFriend,
            this.xtraTabPageGroup,
            this.xtraTabPageHistory});
            // 
            // xtraTabPageFriend
            // 
            this.xtraTabPageFriend.Controls.Add(this.chatListBoxFriend);
            this.xtraTabPageFriend.Name = "xtraTabPageFriend";
            this.xtraTabPageFriend.Size = new System.Drawing.Size(285, 401);
            this.xtraTabPageFriend.Text = "联系人";
            // 
            // chatListBoxFriend
            // 
            this.chatListBoxFriend.BackColor = System.Drawing.Color.White;
            this.chatListBoxFriend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatListBoxFriend.ForeColor = System.Drawing.Color.DarkOrange;
            this.chatListBoxFriend.Location = new System.Drawing.Point(0, 0);
            this.chatListBoxFriend.Name = "chatListBoxFriend";
            this.chatListBoxFriend.Size = new System.Drawing.Size(285, 401);
            this.chatListBoxFriend.TabIndex = 0;
            this.chatListBoxFriend.Text = "chatListBox1";
            // 
            // xtraTabPageGroup
            // 
            this.xtraTabPageGroup.Controls.Add(this.chatListBoxGroup);
            this.xtraTabPageGroup.Name = "xtraTabPageGroup";
            this.xtraTabPageGroup.Size = new System.Drawing.Size(285, 401);
            this.xtraTabPageGroup.Text = "我的群组";
            // 
            // chatListBoxGroup
            // 
            this.chatListBoxGroup.BackColor = System.Drawing.Color.White;
            this.chatListBoxGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatListBoxGroup.ForeColor = System.Drawing.Color.DarkOrange;
            this.chatListBoxGroup.Location = new System.Drawing.Point(0, 0);
            this.chatListBoxGroup.Name = "chatListBoxGroup";
            this.chatListBoxGroup.Size = new System.Drawing.Size(285, 401);
            this.chatListBoxGroup.TabIndex = 0;
            this.chatListBoxGroup.Text = "chatListBox2";
            // 
            // xtraTabPageHistory
            // 
            this.xtraTabPageHistory.Controls.Add(this.chatListBoxHistory);
            this.xtraTabPageHistory.Name = "xtraTabPageHistory";
            this.xtraTabPageHistory.Size = new System.Drawing.Size(285, 401);
            this.xtraTabPageHistory.Text = "历史会话";
            // 
            // chatListBoxHistory
            // 
            this.chatListBoxHistory.BackColor = System.Drawing.Color.White;
            this.chatListBoxHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatListBoxHistory.ForeColor = System.Drawing.Color.DarkOrange;
            this.chatListBoxHistory.Location = new System.Drawing.Point(0, 0);
            this.chatListBoxHistory.Name = "chatListBoxHistory";
            this.chatListBoxHistory.Size = new System.Drawing.Size(285, 401);
            this.chatListBoxHistory.TabIndex = 0;
            this.chatListBoxHistory.Text = "chatListBox3";
            // 
            // panelControlCenter
            // 
            this.panelControlCenter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControlCenter.Controls.Add(this.textEditFind);
            this.panelControlCenter.Location = new System.Drawing.Point(5, 116);
            this.panelControlCenter.Name = "panelControlCenter";
            this.panelControlCenter.Size = new System.Drawing.Size(291, 33);
            this.panelControlCenter.TabIndex = 1;
            // 
            // textEditFind
            // 
            this.textEditFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEditFind.Location = new System.Drawing.Point(2, 2);
            this.textEditFind.Name = "textEditFind";
            this.textEditFind.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.textEditFind.Properties.Appearance.Options.UseFont = true;
            this.textEditFind.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEditFind.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            this.textEditFind.Size = new System.Drawing.Size(287, 28);
            this.textEditFind.TabIndex = 0;
            this.textEditFind.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            // 
            // panelControlTop
            // 
            this.panelControlTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControlTop.Controls.Add(this.pictureHead);
            this.panelControlTop.Controls.Add(this.labName);
            this.panelControlTop.Location = new System.Drawing.Point(5, 5);
            this.panelControlTop.Name = "panelControlTop";
            this.panelControlTop.Size = new System.Drawing.Size(291, 105);
            this.panelControlTop.TabIndex = 0;
            // 
            // pictureHead
            // 
            this.pictureHead.Location = new System.Drawing.Point(3, 5);
            this.pictureHead.Name = "pictureHead";
            this.pictureHead.Size = new System.Drawing.Size(108, 95);
            this.pictureHead.TabIndex = 2;
            this.pictureHead.TabStop = false;
            // 
            // labName
            // 
            this.labName.Location = new System.Drawing.Point(158, 30);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(0, 14);
            this.labName.TabIndex = 1;
            // 
            // textEditName
            // 
            this.textEditName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditName.EditValue = "";
            this.textEditName.Location = new System.Drawing.Point(114, 191);
            this.textEditName.Name = "textEditName";
            this.textEditName.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.textEditName.Properties.Appearance.BackColor2 = System.Drawing.Color.White;
            this.textEditName.Properties.Appearance.BorderColor = System.Drawing.Color.White;
            this.textEditName.Properties.Appearance.Options.UseBackColor = true;
            this.textEditName.Properties.Appearance.Options.UseBorderColor = true;
            this.textEditName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White;
            this.textEditName.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White;
            this.textEditName.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.White;
            this.textEditName.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White;
            this.textEditName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.textEditName.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.textEditName.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.textEditName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textEditName.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            this.textEditName.Properties.NullText = "请输入用户名";
            this.textEditName.Size = new System.Drawing.Size(128, 22);
            this.textEditName.TabIndex = 0;
            this.textEditName.ToolTip = "请输入用户名";
            this.textEditName.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
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
            this.textEditPassword.Size = new System.Drawing.Size(128, 22);
            this.textEditPassword.TabIndex = 3;
            this.textEditPassword.ToolTip = "请输入密码";
            this.textEditPassword.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
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
            this.simpleButtonLogin.Size = new System.Drawing.Size(84, 30);
            this.simpleButtonLogin.TabIndex = 4;
            this.simpleButtonLogin.Text = "登陆";
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
            this.progressPanel.Description = "";
            this.progressPanel.Location = new System.Drawing.Point(85, 359);
            this.progressPanel.LookAndFeel.SkinName = "Office 2010 Blue";
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.ShowDescription = false;
            this.progressPanel.Size = new System.Drawing.Size(137, 66);
            this.progressPanel.TabIndex = 5;
            this.progressPanel.Text = "progressPanel";
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 590);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.progressPanel);
            this.Controls.Add(this.simpleButtonLogin);
            this.Controls.Add(this.textEditPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textEditName);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.MinimumSize = new System.Drawing.Size(316, 629);
            this.Name = "FormMain";
            this.Text = "XMPP";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBottom)).EndInit();
            this.panelControlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            this.xtraTabPageFriend.ResumeLayout(false);
            this.xtraTabPageGroup.ResumeLayout(false);
            this.xtraTabPageHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlCenter)).EndInit();
            this.panelControlCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEditFind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTop)).EndInit();
            this.panelControlTop.ResumeLayout(false);
            this.panelControlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private DevExpress.XtraEditors.PanelControl panelControlBottom;
        private DevExpress.XtraEditors.PanelControl panelControlCenter;
        private DevExpress.XtraEditors.PanelControl panelControlTop;
        private DevExpress.XtraEditors.LabelControl labName;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageFriend;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageGroup;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageHistory;
        private System.Windows.Forms.PictureBox pictureHead;
        private DevExpress.XtraEditors.TextEdit textEditFind;
        private ChatControl.ChatListBox.ChatListBox chatListBoxFriend;
        private ChatControl.ChatListBox.ChatListBox chatListBoxGroup;
        private ChatControl.ChatListBox.ChatListBox chatListBoxHistory;




        #region 登陆窗体控件
        private DevExpress.XtraEditors.TextEdit textEditName;
        private DevExpress.XtraEditors.LabelControl labelName;
        private DevExpress.XtraEditors.LabelControl labelPassword;
        private DevExpress.XtraEditors.TextEdit textEditPassword;
        private DevExpress.XtraEditors.SimpleButton simpleButtonLogin;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        #endregion 登陆窗体控件

    }
}