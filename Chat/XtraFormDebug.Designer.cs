namespace Chat
{
    partial class XtraFormDebug
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
            this.simpleButtonFind = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit = new DevExpress.XtraEditors.TextEdit();
            this.chatRichTextBox = new ChatControl.ChatRichTextBox.ChatRichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButtonFind
            // 
            this.simpleButtonFind.Location = new System.Drawing.Point(300, 11);
            this.simpleButtonFind.Name = "simpleButtonFind";
            this.simpleButtonFind.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonFind.TabIndex = 2;
            this.simpleButtonFind.Text = "查找";
            this.simpleButtonFind.Click += new System.EventHandler(this.simpleButtonFind_Click);
            // 
            // textEdit
            // 
            this.textEdit.Location = new System.Drawing.Point(12, 10);
            this.textEdit.Name = "textEdit";
            this.textEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.textEdit.Properties.Appearance.Options.UseFont = true;
            this.textEdit.Size = new System.Drawing.Size(270, 24);
            this.textEdit.TabIndex = 1;
            this.textEdit.ToolTip = "输入进行查找";
            // 
            // chatRichTextBox
            // 
            this.chatRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatRichTextBox.BackColor = System.Drawing.Color.Black;
            this.chatRichTextBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatRichTextBox.Location = new System.Drawing.Point(0, 40);
            this.chatRichTextBox.Name = "chatRichTextBox";
            this.chatRichTextBox.Size = new System.Drawing.Size(728, 560);
            this.chatRichTextBox.TabIndex = 0;
            this.chatRichTextBox.Text = "";
            // 
            // XtraFormDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 601);
            this.ControlBox = false;
            this.Controls.Add(this.simpleButtonFind);
            this.Controls.Add(this.textEdit);
            this.Controls.Add(this.chatRichTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(436, 603);
            this.Name = "XtraFormDebug";
            this.Text = "XMPP 日志";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ChatControl.ChatRichTextBox.ChatRichTextBox chatRichTextBox;
        private DevExpress.XtraEditors.TextEdit textEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButtonFind;
         


    }
}