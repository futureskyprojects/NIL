namespace SecureMail.Options
{
    partial class Options
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.OptionsIcon = new System.Windows.Forms.PictureBox();
            this.NameOfUserControl_3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.AutoCheckInbox = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SwitchCheckIB = new Bunifu.Framework.UI.BunifuSwitch();
            this.TimeUpdate = new Bunifu.Framework.UI.BunifuSlider();
            this.autocheckXs = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SwitchRunBackgruond = new Bunifu.Framework.UI.BunifuSwitch();
            this.RunBackground = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.AutoDeleXday = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TimeDele = new Bunifu.Framework.UI.BunifuSlider();
            this.SwitchAutoDelete = new Bunifu.Framework.UI.BunifuSwitch();
            this.AutoDeleteSavedMails = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SwitchAutoDowloadAtt = new Bunifu.Framework.UI.BunifuSwitch();
            this.AutoDownloadAtt = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ButtonRadius = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SaveOptions = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.OptionsIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // OptionsIcon
            // 
            this.OptionsIcon.Image = global::SecureMail.Properties.Resources._003_settings_work_tool;
            this.OptionsIcon.Location = new System.Drawing.Point(17, 15);
            this.OptionsIcon.Name = "OptionsIcon";
            this.OptionsIcon.Size = new System.Drawing.Size(25, 25);
            this.OptionsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OptionsIcon.TabIndex = 18;
            this.OptionsIcon.TabStop = false;
            // 
            // NameOfUserControl_3
            // 
            this.NameOfUserControl_3.AutoSize = true;
            this.NameOfUserControl_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameOfUserControl_3.ForeColor = System.Drawing.Color.White;
            this.NameOfUserControl_3.Location = new System.Drawing.Point(48, 18);
            this.NameOfUserControl_3.Name = "NameOfUserControl_3";
            this.NameOfUserControl_3.Size = new System.Drawing.Size(75, 24);
            this.NameOfUserControl_3.TabIndex = 19;
            this.NameOfUserControl_3.Text = "Options";
            // 
            // AutoCheckInbox
            // 
            this.AutoCheckInbox.AutoSize = true;
            this.AutoCheckInbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoCheckInbox.ForeColor = System.Drawing.Color.White;
            this.AutoCheckInbox.Location = new System.Drawing.Point(48, 72);
            this.AutoCheckInbox.Name = "AutoCheckInbox";
            this.AutoCheckInbox.Size = new System.Drawing.Size(149, 18);
            this.AutoCheckInbox.TabIndex = 22;
            this.AutoCheckInbox.Text = "A. Auto check INBOX";
            // 
            // SwitchCheckIB
            // 
            this.SwitchCheckIB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SwitchCheckIB.BorderRadius = 0;
            this.SwitchCheckIB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwitchCheckIB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SwitchCheckIB.Location = new System.Drawing.Point(525, 73);
            this.SwitchCheckIB.Name = "SwitchCheckIB";
            this.SwitchCheckIB.Oncolor = System.Drawing.Color.SeaGreen;
            this.SwitchCheckIB.Onoffcolor = System.Drawing.Color.DarkGray;
            this.SwitchCheckIB.Size = new System.Drawing.Size(51, 19);
            this.SwitchCheckIB.TabIndex = 29;
            this.SwitchCheckIB.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SwitchCheckIB.Value = true;
            this.SwitchCheckIB.Click += new System.EventHandler(this.SwitchCheckIB_Click);
            // 
            // TimeUpdate
            // 
            this.TimeUpdate.BackColor = System.Drawing.Color.Transparent;
            this.TimeUpdate.BackgroudColor = System.Drawing.Color.DarkGray;
            this.TimeUpdate.BorderRadius = 0;
            this.TimeUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TimeUpdate.IndicatorColor = System.Drawing.Color.SeaGreen;
            this.TimeUpdate.Location = new System.Drawing.Point(240, 111);
            this.TimeUpdate.MaximumValue = 100;
            this.TimeUpdate.Name = "TimeUpdate";
            this.TimeUpdate.Size = new System.Drawing.Size(202, 30);
            this.TimeUpdate.TabIndex = 30;
            this.TimeUpdate.Value = 0;
            this.TimeUpdate.ValueChanged += new System.EventHandler(this.TimeUpdate_ValueChanged);
            // 
            // autocheckXs
            // 
            this.autocheckXs.AutoSize = true;
            this.autocheckXs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autocheckXs.ForeColor = System.Drawing.SystemColors.Control;
            this.autocheckXs.Location = new System.Drawing.Point(67, 114);
            this.autocheckXs.Name = "autocheckXs";
            this.autocheckXs.Size = new System.Drawing.Size(169, 15);
            this.autocheckXs.TabIndex = 31;
            this.autocheckXs.Text = "Update after every x minute(s)";
            // 
            // SwitchRunBackgruond
            // 
            this.SwitchRunBackgruond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SwitchRunBackgruond.BorderRadius = 0;
            this.SwitchRunBackgruond.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwitchRunBackgruond.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SwitchRunBackgruond.Location = new System.Drawing.Point(525, 160);
            this.SwitchRunBackgruond.Name = "SwitchRunBackgruond";
            this.SwitchRunBackgruond.Oncolor = System.Drawing.Color.SeaGreen;
            this.SwitchRunBackgruond.Onoffcolor = System.Drawing.Color.DarkGray;
            this.SwitchRunBackgruond.Size = new System.Drawing.Size(51, 19);
            this.SwitchRunBackgruond.TabIndex = 33;
            this.SwitchRunBackgruond.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SwitchRunBackgruond.Value = true;
            this.SwitchRunBackgruond.Click += new System.EventHandler(this.SwitchRunBackgruond_Click);
            // 
            // RunBackground
            // 
            this.RunBackground.AutoSize = true;
            this.RunBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunBackground.ForeColor = System.Drawing.Color.White;
            this.RunBackground.Location = new System.Drawing.Point(48, 159);
            this.RunBackground.Name = "RunBackground";
            this.RunBackground.Size = new System.Drawing.Size(226, 18);
            this.RunBackground.TabIndex = 32;
            this.RunBackground.Text = "B. Secure Mail run in background";
            // 
            // AutoDeleXday
            // 
            this.AutoDeleXday.AutoSize = true;
            this.AutoDeleXday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoDeleXday.ForeColor = System.Drawing.SystemColors.Control;
            this.AutoDeleXday.Location = new System.Drawing.Point(67, 264);
            this.AutoDeleXday.Name = "AutoDeleXday";
            this.AutoDeleXday.Size = new System.Drawing.Size(115, 15);
            this.AutoDeleXday.TabIndex = 37;
            this.AutoDeleXday.Text = "Delete after x day(s)";
            // 
            // TimeDele
            // 
            this.TimeDele.BackColor = System.Drawing.Color.Transparent;
            this.TimeDele.BackgroudColor = System.Drawing.Color.DarkGray;
            this.TimeDele.BorderRadius = 0;
            this.TimeDele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TimeDele.IndicatorColor = System.Drawing.Color.SeaGreen;
            this.TimeDele.Location = new System.Drawing.Point(240, 261);
            this.TimeDele.MaximumValue = 100;
            this.TimeDele.Name = "TimeDele";
            this.TimeDele.Size = new System.Drawing.Size(202, 30);
            this.TimeDele.TabIndex = 36;
            this.TimeDele.Value = 0;
            this.TimeDele.ValueChanged += new System.EventHandler(this.TimeDele_ValueChanged);
            // 
            // SwitchAutoDelete
            // 
            this.SwitchAutoDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SwitchAutoDelete.BorderRadius = 0;
            this.SwitchAutoDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwitchAutoDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SwitchAutoDelete.Location = new System.Drawing.Point(525, 223);
            this.SwitchAutoDelete.Name = "SwitchAutoDelete";
            this.SwitchAutoDelete.Oncolor = System.Drawing.Color.SeaGreen;
            this.SwitchAutoDelete.Onoffcolor = System.Drawing.Color.DarkGray;
            this.SwitchAutoDelete.Size = new System.Drawing.Size(51, 19);
            this.SwitchAutoDelete.TabIndex = 35;
            this.SwitchAutoDelete.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SwitchAutoDelete.Value = false;
            this.SwitchAutoDelete.Click += new System.EventHandler(this.SwitchAutoDelete_Click);
            // 
            // AutoDeleteSavedMails
            // 
            this.AutoDeleteSavedMails.AutoSize = true;
            this.AutoDeleteSavedMails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoDeleteSavedMails.ForeColor = System.Drawing.Color.White;
            this.AutoDeleteSavedMails.Location = new System.Drawing.Point(48, 222);
            this.AutoDeleteSavedMails.Name = "AutoDeleteSavedMails";
            this.AutoDeleteSavedMails.Size = new System.Drawing.Size(184, 18);
            this.AutoDeleteSavedMails.TabIndex = 34;
            this.AutoDeleteSavedMails.Text = "C. Auto delete Saved Mails";
            // 
            // SwitchAutoDowloadAtt
            // 
            this.SwitchAutoDowloadAtt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SwitchAutoDowloadAtt.BorderRadius = 0;
            this.SwitchAutoDowloadAtt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwitchAutoDowloadAtt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SwitchAutoDowloadAtt.Location = new System.Drawing.Point(525, 319);
            this.SwitchAutoDowloadAtt.Name = "SwitchAutoDowloadAtt";
            this.SwitchAutoDowloadAtt.Oncolor = System.Drawing.Color.SeaGreen;
            this.SwitchAutoDowloadAtt.Onoffcolor = System.Drawing.Color.DarkGray;
            this.SwitchAutoDowloadAtt.Size = new System.Drawing.Size(51, 19);
            this.SwitchAutoDowloadAtt.TabIndex = 39;
            this.SwitchAutoDowloadAtt.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SwitchAutoDowloadAtt.Value = false;
            this.SwitchAutoDowloadAtt.Click += new System.EventHandler(this.SwitchAutoDowloadAtt_Click);
            // 
            // AutoDownloadAtt
            // 
            this.AutoDownloadAtt.AutoSize = true;
            this.AutoDownloadAtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoDownloadAtt.ForeColor = System.Drawing.Color.White;
            this.AutoDownloadAtt.Location = new System.Drawing.Point(48, 318);
            this.AutoDownloadAtt.Name = "AutoDownloadAtt";
            this.AutoDownloadAtt.Size = new System.Drawing.Size(213, 18);
            this.AutoDownloadAtt.TabIndex = 38;
            this.AutoDownloadAtt.Text = "D. Auto download Attachemt(s)";
            // 
            // ButtonRadius
            // 
            this.ButtonRadius.ElipseRadius = 30;
            this.ButtonRadius.TargetControl = this.SaveOptions;
            // 
            // SaveOptions
            // 
            this.SaveOptions.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.SaveOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.SaveOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveOptions.BorderRadius = 0;
            this.SaveOptions.ButtonText = "       Save options";
            this.SaveOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveOptions.DisabledColor = System.Drawing.Color.Gray;
            this.SaveOptions.Iconcolor = System.Drawing.Color.Transparent;
            this.SaveOptions.Iconimage = null;
            this.SaveOptions.Iconimage_right = null;
            this.SaveOptions.Iconimage_right_Selected = null;
            this.SaveOptions.Iconimage_Selected = null;
            this.SaveOptions.IconMarginLeft = 0;
            this.SaveOptions.IconMarginRight = 0;
            this.SaveOptions.IconRightVisible = true;
            this.SaveOptions.IconRightZoom = 0D;
            this.SaveOptions.IconVisible = true;
            this.SaveOptions.IconZoom = 90D;
            this.SaveOptions.IsTab = false;
            this.SaveOptions.Location = new System.Drawing.Point(489, 458);
            this.SaveOptions.Name = "SaveOptions";
            this.SaveOptions.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.SaveOptions.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.SaveOptions.OnHoverTextColor = System.Drawing.Color.White;
            this.SaveOptions.selected = false;
            this.SaveOptions.Size = new System.Drawing.Size(126, 48);
            this.SaveOptions.TabIndex = 42;
            this.SaveOptions.Text = "       Save options";
            this.SaveOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveOptions.Textcolor = System.Drawing.Color.White;
            this.SaveOptions.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveOptions.Click += new System.EventHandler(this.SaveOptions_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.Controls.Add(this.SaveOptions);
            this.Controls.Add(this.SwitchAutoDowloadAtt);
            this.Controls.Add(this.AutoDownloadAtt);
            this.Controls.Add(this.AutoDeleXday);
            this.Controls.Add(this.TimeDele);
            this.Controls.Add(this.SwitchAutoDelete);
            this.Controls.Add(this.AutoDeleteSavedMails);
            this.Controls.Add(this.SwitchRunBackgruond);
            this.Controls.Add(this.RunBackground);
            this.Controls.Add(this.autocheckXs);
            this.Controls.Add(this.TimeUpdate);
            this.Controls.Add(this.SwitchCheckIB);
            this.Controls.Add(this.AutoCheckInbox);
            this.Controls.Add(this.NameOfUserControl_3);
            this.Controls.Add(this.OptionsIcon);
            this.Name = "Options";
            this.Size = new System.Drawing.Size(650, 556);
            this.Load += new System.EventHandler(this.Options_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OptionsIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox OptionsIcon;
        private Bunifu.Framework.UI.BunifuCustomLabel NameOfUserControl_3;
        private Bunifu.Framework.UI.BunifuCustomLabel AutoCheckInbox;
        private Bunifu.Framework.UI.BunifuSwitch SwitchCheckIB;
        private Bunifu.Framework.UI.BunifuSlider TimeUpdate;
        private Bunifu.Framework.UI.BunifuCustomLabel autocheckXs;
        private Bunifu.Framework.UI.BunifuSwitch SwitchRunBackgruond;
        private Bunifu.Framework.UI.BunifuCustomLabel RunBackground;
        private Bunifu.Framework.UI.BunifuCustomLabel AutoDeleXday;
        private Bunifu.Framework.UI.BunifuSlider TimeDele;
        private Bunifu.Framework.UI.BunifuSwitch SwitchAutoDelete;
        private Bunifu.Framework.UI.BunifuCustomLabel AutoDeleteSavedMails;
        private Bunifu.Framework.UI.BunifuSwitch SwitchAutoDowloadAtt;
        private Bunifu.Framework.UI.BunifuCustomLabel AutoDownloadAtt;
        private Bunifu.Framework.UI.BunifuElipse ButtonRadius;
        private Bunifu.Framework.UI.BunifuFlatButton SaveOptions;
    }
}
