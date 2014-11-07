namespace Chat
{
    sealed partial class RibbonFormChat
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
            Util.ChatFormHashtable.Remove(_jid.Bare.ToLower());
            _connection.MessageGrabber.Remove(_jid);
			_connection = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonFormChat));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemFile = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemAudio = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.chatRichTextBoxShow = new ChatControl.ChatRichTextBox.ChatRichTextBox();
            this.chatRichTextBoxSend = new ChatControl.ChatRichTextBox.ChatRichTextBox();
            this.barButtonItemImage = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemSend = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItemFile,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItemAudio,
            this.barButtonItemSend});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 14;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.barButtonItem1);
            this.ribbon.PageHeaderItemLinks.Add(this.barButtonItem2);
            this.ribbon.PageHeaderItemLinks.Add(this.barButtonItem3);
            this.ribbon.Size = new System.Drawing.Size(492, 50);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barButtonItemFile
            // 
            this.barButtonItemFile.Caption = "发送文件";
            this.barButtonItemFile.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemFile.Glyph")));
            this.barButtonItemFile.Id = 2;
            this.barButtonItemFile.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemFile.LargeGlyph")));
            this.barButtonItemFile.Name = "barButtonItemFile";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 7;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 8;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItemAudio
            // 
            this.barButtonItemAudio.Caption = "语音";
            this.barButtonItemAudio.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemAudio.Glyph")));
            this.barButtonItemAudio.GlyphDisabled = ((System.Drawing.Image)(resources.GetObject("barButtonItemAudio.GlyphDisabled")));
            this.barButtonItemAudio.Id = 12;
            this.barButtonItemAudio.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemAudio.LargeGlyph")));
            this.barButtonItemAudio.LargeGlyphDisabled = ((System.Drawing.Image)(resources.GetObject("barButtonItemAudio.LargeGlyphDisabled")));
            this.barButtonItemAudio.Name = "barButtonItemAudio";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barButtonItemAudio);
            this.ribbonStatusBar.ItemLinks.Add(this.barButtonItemFile);
            this.ribbonStatusBar.ItemLinks.Add(this.barButtonItemSend);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 478);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(492, 31);
            // 
            // splitContainerControl
            // 
            this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl.Horizontal = false;
            this.splitContainerControl.Location = new System.Drawing.Point(0, 50);
            this.splitContainerControl.Name = "splitContainerControl";
            this.splitContainerControl.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl.Panel1.Controls.Add(this.chatRichTextBoxShow);
            this.splitContainerControl.Panel1.MinSize = 250;
            this.splitContainerControl.Panel1.Text = "PanelTop";
            this.splitContainerControl.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl.Panel2.Controls.Add(this.chatRichTextBoxSend);
            this.splitContainerControl.Panel2.Text = "Panel";
            this.splitContainerControl.Size = new System.Drawing.Size(492, 428);
            this.splitContainerControl.SplitterPosition = 257;
            this.splitContainerControl.TabIndex = 2;
            this.splitContainerControl.Text = "splitContainerControl";
            // 
            // chatRichTextBoxShow
            // 
            this.chatRichTextBoxShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatRichTextBoxShow.Location = new System.Drawing.Point(0, 0);
            this.chatRichTextBoxShow.Name = "chatRichTextBoxShow";
            this.chatRichTextBoxShow.Size = new System.Drawing.Size(488, 253);
            this.chatRichTextBoxShow.TabIndex = 0;
            this.chatRichTextBoxShow.Text = "";
            // 
            // chatRichTextBoxSend
            // 
            this.chatRichTextBoxSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatRichTextBoxSend.Location = new System.Drawing.Point(0, 0);
            this.chatRichTextBoxSend.Name = "chatRichTextBoxSend";
            this.chatRichTextBoxSend.Size = new System.Drawing.Size(488, 162);
            this.chatRichTextBoxSend.TabIndex = 0;
            this.chatRichTextBoxSend.Text = "";
            // 
            // barButtonItemImage
            // 
            this.barButtonItemImage.Caption = "发送图片";
            this.barButtonItemImage.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemImage.Glyph")));
            this.barButtonItemImage.Id = 1;
            this.barButtonItemImage.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemImage.LargeGlyph")));
            this.barButtonItemImage.Name = "barButtonItemImage";
            // 
            // barButtonItemSend
            // 
            this.barButtonItemSend.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItemSend.Caption = "发送";
            this.barButtonItemSend.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemSend.Glyph")));
            this.barButtonItemSend.GlyphDisabled = ((System.Drawing.Image)(resources.GetObject("barButtonItemSend.GlyphDisabled")));
            this.barButtonItemSend.Id = 13;
            this.barButtonItemSend.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemSend.LargeGlyph")));
            this.barButtonItemSend.LargeGlyphDisabled = ((System.Drawing.Image)(resources.GetObject("barButtonItemSend.LargeGlyphDisabled")));
            this.barButtonItemSend.Name = "barButtonItemSend";
            this.barButtonItemSend.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSend_ItemClick);
            // 
            // RibbonFormChat
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 509);
            this.Controls.Add(this.splitContainerControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.MinimumSize = new System.Drawing.Size(480, 510);
            this.Name = "RibbonFormChat";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "RibbonFormChat";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl;
        private DevExpress.XtraBars.BarButtonItem barButtonItemFile;
        private ChatControl.ChatRichTextBox.ChatRichTextBox chatRichTextBoxShow;
        private ChatControl.ChatRichTextBox.ChatRichTextBox chatRichTextBoxSend;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItemImage;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAudio;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSend;
    }
}