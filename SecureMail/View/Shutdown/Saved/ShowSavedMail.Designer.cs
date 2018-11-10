namespace SecureMail.Saved
{
    partial class ShowSavedMail
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteSavedMsg = new Bunifu.Framework.UI.BunifuImageButton();
            this.DateTimeShow = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Decrypt = new Bunifu.Framework.UI.BunifuImageButton();
            this.senderX = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.back_button = new Bunifu.Framework.UI.BunifuImageButton();
            this.Attachments = new Bunifu.Framework.UI.BunifuImageButton();
            this.Subject = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MailKind = new System.Windows.Forms.PictureBox();
            this.ContentShow = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteSavedMsg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Decrypt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attachments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MailKind)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.DeleteSavedMsg);
            this.panel1.Controls.Add(this.DateTimeShow);
            this.panel1.Controls.Add(this.Decrypt);
            this.panel1.Controls.Add(this.senderX);
            this.panel1.Controls.Add(this.back_button);
            this.panel1.Controls.Add(this.Attachments);
            this.panel1.Controls.Add(this.Subject);
            this.panel1.Controls.Add(this.MailKind);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 71);
            this.panel1.TabIndex = 0;
            // 
            // DeleteSavedMsg
            // 
            this.DeleteSavedMsg.BackColor = System.Drawing.Color.Transparent;
            this.DeleteSavedMsg.Image = global::SecureMail.Properties.Resources.delete;
            this.DeleteSavedMsg.ImageActive = null;
            this.DeleteSavedMsg.Location = new System.Drawing.Point(569, 5);
            this.DeleteSavedMsg.Name = "DeleteSavedMsg";
            this.DeleteSavedMsg.Size = new System.Drawing.Size(30, 30);
            this.DeleteSavedMsg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DeleteSavedMsg.TabIndex = 25;
            this.DeleteSavedMsg.TabStop = false;
            this.DeleteSavedMsg.Zoom = 10;
            this.DeleteSavedMsg.Click += new System.EventHandler(this.DeleteSavedMsg_Click);
            // 
            // DateTimeShow
            // 
            this.DateTimeShow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DateTimeShow.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DateTimeShow.ForeColor = System.Drawing.Color.OldLace;
            this.DateTimeShow.Location = new System.Drawing.Point(393, 40);
            this.DateTimeShow.Name = "DateTimeShow";
            this.DateTimeShow.Size = new System.Drawing.Size(242, 25);
            this.DateTimeShow.TabIndex = 4;
            this.DateTimeShow.Text = "14/3/1998";
            this.DateTimeShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Decrypt
            // 
            this.Decrypt.BackColor = System.Drawing.Color.Transparent;
            this.Decrypt.Image = global::SecureMail.Properties.Resources.unlock;
            this.Decrypt.ImageActive = null;
            this.Decrypt.Location = new System.Drawing.Point(533, 5);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(30, 30);
            this.Decrypt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Decrypt.TabIndex = 26;
            this.Decrypt.TabStop = false;
            this.Decrypt.Zoom = 10;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // senderX
            // 
            this.senderX.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.senderX.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.senderX.ForeColor = System.Drawing.Color.OldLace;
            this.senderX.Location = new System.Drawing.Point(71, 40);
            this.senderX.Name = "senderX";
            this.senderX.Size = new System.Drawing.Size(258, 25);
            this.senderX.TabIndex = 3;
            this.senderX.Text = "From: tngroups98@gmail.com";
            this.senderX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Transparent;
            this.back_button.Image = global::SecureMail.Properties.Resources.back_white;
            this.back_button.ImageActive = null;
            this.back_button.Location = new System.Drawing.Point(605, 5);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(30, 30);
            this.back_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_button.TabIndex = 27;
            this.back_button.TabStop = false;
            this.back_button.Zoom = 10;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // Attachments
            // 
            this.Attachments.BackColor = System.Drawing.Color.Transparent;
            this.Attachments.Image = global::SecureMail.Properties.Resources.attachments;
            this.Attachments.ImageActive = null;
            this.Attachments.Location = new System.Drawing.Point(497, 5);
            this.Attachments.Name = "Attachments";
            this.Attachments.Size = new System.Drawing.Size(30, 30);
            this.Attachments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Attachments.TabIndex = 24;
            this.Attachments.TabStop = false;
            this.Attachments.Zoom = 10;
            // 
            // Subject
            // 
            this.Subject.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Subject.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Subject.ForeColor = System.Drawing.Color.OldLace;
            this.Subject.Location = new System.Drawing.Point(71, 5);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(405, 35);
            this.Subject.TabIndex = 2;
            this.Subject.Text = "Here will show content of mail subject.";
            // 
            // MailKind
            // 
            this.MailKind.Image = global::SecureMail.Properties.Resources._008_gmail;
            this.MailKind.Location = new System.Drawing.Point(5, 5);
            this.MailKind.Name = "MailKind";
            this.MailKind.Size = new System.Drawing.Size(60, 60);
            this.MailKind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MailKind.TabIndex = 1;
            this.MailKind.TabStop = false;
            this.MailKind.MouseLeave += new System.EventHandler(this.MailKind_MouseLeave);
            this.MailKind.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MailKind_MouseMove);
            // 
            // ContentShow
            // 
            this.ContentShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentShow.Location = new System.Drawing.Point(0, 71);
            this.ContentShow.MinimumSize = new System.Drawing.Size(20, 20);
            this.ContentShow.Name = "ContentShow";
            this.ContentShow.Size = new System.Drawing.Size(645, 485);
            this.ContentShow.TabIndex = 1;
            // 
            // ShowSavedMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContentShow);
            this.Controls.Add(this.panel1);
            this.Name = "ShowSavedMail";
            this.Size = new System.Drawing.Size(645, 556);
            this.Load += new System.EventHandler(this.ShowSavedMail_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DeleteSavedMsg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Decrypt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attachments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MailKind)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox MailKind;
        private Bunifu.Framework.UI.BunifuCustomLabel senderX;
        private Bunifu.Framework.UI.BunifuCustomLabel Subject;
        private Bunifu.Framework.UI.BunifuCustomLabel DateTimeShow;
        private Bunifu.Framework.UI.BunifuImageButton DeleteSavedMsg;
        private Bunifu.Framework.UI.BunifuImageButton Decrypt;
        private Bunifu.Framework.UI.BunifuImageButton Attachments;
        private System.Windows.Forms.WebBrowser ContentShow;
        private Bunifu.Framework.UI.BunifuImageButton back_button;
    }
}
