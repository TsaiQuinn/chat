namespace Chat
{
    partial class XtraFormSetting
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
            this.components = new System.ComponentModel.Container();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.checkBoxSSL = new System.Windows.Forms.CheckBox();
            this.numericUpDownPriority = new System.Windows.Forms.NumericUpDown();
            this.simpleButtonConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.textEditResource = new DevExpress.XtraEditors.TextEdit();
            this.labelControlResource = new DevExpress.XtraEditors.LabelControl();
            this.labelControlPriority = new DevExpress.XtraEditors.LabelControl();
            this.textEditServerPort = new DevExpress.XtraEditors.TextEdit();
            this.labelControlPort = new DevExpress.XtraEditors.LabelControl();
            this.textEditServerIP = new DevExpress.XtraEditors.TextEdit();
            this.labelControlServerIP = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPriority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditResource.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditServerPort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditServerIP.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2010 Blue";
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.checkBoxSSL);
            this.panelControl.Controls.Add(this.numericUpDownPriority);
            this.panelControl.Controls.Add(this.simpleButtonConfirm);
            this.panelControl.Controls.Add(this.textEditResource);
            this.panelControl.Controls.Add(this.labelControlResource);
            this.panelControl.Controls.Add(this.labelControlPriority);
            this.panelControl.Controls.Add(this.textEditServerPort);
            this.panelControl.Controls.Add(this.labelControlPort);
            this.panelControl.Controls.Add(this.textEditServerIP);
            this.panelControl.Controls.Add(this.labelControlServerIP);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(428, 212);
            this.panelControl.TabIndex = 0;
            // 
            // checkBoxSSL
            // 
            this.checkBoxSSL.AutoSize = true;
            this.checkBoxSSL.Location = new System.Drawing.Point(93, 132);
            this.checkBoxSSL.Name = "checkBoxSSL";
            this.checkBoxSSL.Size = new System.Drawing.Size(70, 18);
            this.checkBoxSSL.TabIndex = 11;
            this.checkBoxSSL.Text = "使用SSL";
            this.checkBoxSSL.UseVisualStyleBackColor = true;
            // 
            // numericUpDownPriority
            // 
            this.numericUpDownPriority.Location = new System.Drawing.Point(93, 86);
            this.numericUpDownPriority.Name = "numericUpDownPriority";
            this.numericUpDownPriority.Size = new System.Drawing.Size(100, 22);
            this.numericUpDownPriority.TabIndex = 9;
            this.numericUpDownPriority.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // simpleButtonConfirm
            // 
            this.simpleButtonConfirm.Location = new System.Drawing.Point(168, 168);
            this.simpleButtonConfirm.Name = "simpleButtonConfirm";
            this.simpleButtonConfirm.Size = new System.Drawing.Size(90, 32);
            this.simpleButtonConfirm.TabIndex = 8;
            this.simpleButtonConfirm.Text = "确定";
            this.simpleButtonConfirm.Click += new System.EventHandler(this.simpleButtonConfirm_Click);
            // 
            // textEditResource
            // 
            this.textEditResource.EditValue = "win8";
            this.textEditResource.Location = new System.Drawing.Point(278, 86);
            this.textEditResource.Name = "textEditResource";
            this.textEditResource.Size = new System.Drawing.Size(100, 22);
            this.textEditResource.TabIndex = 7;
            // 
            // labelControlResource
            // 
            this.labelControlResource.Location = new System.Drawing.Point(224, 86);
            this.labelControlResource.Name = "labelControlResource";
            this.labelControlResource.Size = new System.Drawing.Size(44, 14);
            this.labelControlResource.TabIndex = 6;
            this.labelControlResource.Text = "资  源：";
            // 
            // labelControlPriority
            // 
            this.labelControlPriority.Location = new System.Drawing.Point(39, 86);
            this.labelControlPriority.Name = "labelControlPriority";
            this.labelControlPriority.Size = new System.Drawing.Size(49, 14);
            this.labelControlPriority.TabIndex = 4;
            this.labelControlPriority.Text = "Priority：";
            // 
            // textEditServerPort
            // 
            this.textEditServerPort.EditValue = "5222";
            this.textEditServerPort.Location = new System.Drawing.Point(278, 38);
            this.textEditServerPort.Name = "textEditServerPort";
            this.textEditServerPort.Size = new System.Drawing.Size(100, 22);
            this.textEditServerPort.TabIndex = 3;
            // 
            // labelControlPort
            // 
            this.labelControlPort.Location = new System.Drawing.Point(224, 38);
            this.labelControlPort.Name = "labelControlPort";
            this.labelControlPort.Size = new System.Drawing.Size(44, 14);
            this.labelControlPort.TabIndex = 2;
            this.labelControlPort.Text = "端  口：";
            // 
            // textEditServerIP
            // 
            this.textEditServerIP.EditValue = "192.168.1.101";
            this.textEditServerIP.Location = new System.Drawing.Point(93, 38);
            this.textEditServerIP.Name = "textEditServerIP";
            this.textEditServerIP.Size = new System.Drawing.Size(100, 22);
            this.textEditServerIP.TabIndex = 1;
            // 
            // labelControlServerIP
            // 
            this.labelControlServerIP.Location = new System.Drawing.Point(39, 41);
            this.labelControlServerIP.Name = "labelControlServerIP";
            this.labelControlServerIP.Size = new System.Drawing.Size(48, 14);
            this.labelControlServerIP.TabIndex = 0;
            this.labelControlServerIP.Text = "服务器：";
            // 
            // XtraFormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 212);
            this.Controls.Add(this.panelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "XtraFormSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登陆设置";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPriority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditResource.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditServerPort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditServerIP.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private DevExpress.XtraEditors.LabelControl labelControlPort;
        private DevExpress.XtraEditors.TextEdit textEditServerIP;
        private DevExpress.XtraEditors.LabelControl labelControlServerIP;
        private DevExpress.XtraEditors.TextEdit textEditServerPort;
        private DevExpress.XtraEditors.LabelControl labelControlPriority;
        private DevExpress.XtraEditors.TextEdit textEditResource;
        private DevExpress.XtraEditors.LabelControl labelControlResource;
        private DevExpress.XtraEditors.SimpleButton simpleButtonConfirm;
        private System.Windows.Forms.NumericUpDown numericUpDownPriority;
        private System.Windows.Forms.CheckBox checkBoxSSL;
    }
}