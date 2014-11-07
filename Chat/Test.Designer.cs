namespace Chat
{
    partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.labelName = new DevExpress.XtraEditors.LabelControl();
            this.labelPassword = new DevExpress.XtraEditors.LabelControl();
            this.textEditPassword = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonLogin = new DevExpress.XtraEditors.SimpleButton();
            this.progressPanel = new DevExpress.XtraWaitForm.ProgressPanel();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem2 = new DevExpress.XtraBars.BarCheckItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.errorProvider = new System.Windows.Forms.ErrorProvider();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textEditName
            // 
            this.textEditName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditName.EditValue = "";
            this.textEditName.Location = new System.Drawing.Point(63, 24);
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
            this.textEditName.Size = new System.Drawing.Size(178, 22);
            this.textEditName.TabIndex = 0;
            this.textEditName.ToolTip = "请输入用户名";
            this.textEditName.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.Location = new System.Drawing.Point(13, 27);
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
            this.labelPassword.Location = new System.Drawing.Point(13, 77);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(32, 14);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "密  码";
            // 
            // textEditPassword
            // 
            this.textEditPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditPassword.Location = new System.Drawing.Point(63, 74);
            this.textEditPassword.Name = "textEditPassword";
            this.textEditPassword.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            this.textEditPassword.Properties.PasswordChar = '●';
            this.textEditPassword.Size = new System.Drawing.Size(178, 22);
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
            this.simpleButtonLogin.Location = new System.Drawing.Point(46, 179);
            this.simpleButtonLogin.LookAndFeel.SkinName = "Office 2010 Blue";
            this.simpleButtonLogin.Name = "simpleButtonLogin";
            this.simpleButtonLogin.Size = new System.Drawing.Size(180, 30);
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
            this.progressPanel.Description = "请稍后";
            this.progressPanel.Location = new System.Drawing.Point(82, 445);
            this.progressPanel.LookAndFeel.SkinName = "Office 2010 Blue";
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Size = new System.Drawing.Size(123, 53);
            this.progressPanel.TabIndex = 5;
            this.progressPanel.Text = "progressPanel";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.barCheckItem1,
            this.barCheckItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageHeaderItemLinks.Add(this.barButtonItem1);
            this.ribbonControl1.PageHeaderItemLinks.Add(this.barCheckItem1);
            this.ribbonControl1.PageHeaderItemLinks.Add(this.barCheckItem2);
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(332, 148);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "是否显示日志";
            this.barCheckItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.barCheckItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barCheckItem1.Glyph")));
            this.barCheckItem1.Id = 6;
            this.barCheckItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barCheckItem1.LargeGlyph")));
            this.barCheckItem1.Name = "barCheckItem1";
            this.barCheckItem1.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)));
            // 
            // barCheckItem2
            // 
            this.barCheckItem2.Caption = "是否显示日志";
            this.barCheckItem2.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.barCheckItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barCheckItem2.Glyph")));
            this.barCheckItem2.Id = 7;
            this.barCheckItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barCheckItem2.LargeGlyph")));
            this.barCheckItem2.Name = "barCheckItem2";
            this.barCheckItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            toolTipTitleItem1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            toolTipTitleItem1.Appearance.Options.UseImage = true;
            toolTipTitleItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem1.Image")));
            toolTipTitleItem1.Text = "是否\r\n显示\r\n日志";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.barCheckItem2.SuperTip = superToolTip1;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "菜单";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 558);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(332, 32);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.simpleButtonLogin);
            this.panelControl1.Controls.Add(this.textEditPassword);
            this.panelControl1.Controls.Add(this.textEditName);
            this.panelControl1.Controls.Add(this.labelName);
            this.panelControl1.Controls.Add(this.labelPassword);
            this.panelControl1.Location = new System.Drawing.Point(36, 190);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(261, 249);
            this.panelControl1.TabIndex = 13;
            // 
            // Test
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 590);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.progressPanel);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Test";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Test";
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEditName;
        private DevExpress.XtraEditors.LabelControl labelName;
        private DevExpress.XtraEditors.LabelControl labelPassword;
        private DevExpress.XtraEditors.TextEdit textEditPassword;
        private DevExpress.XtraEditors.SimpleButton simpleButtonLogin;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.BarCheckItem barCheckItem2;
        private DevExpress.XtraEditors.PanelControl panelControl1;

    }
}