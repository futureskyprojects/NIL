namespace SecureMail.Saved
{
    partial class Record
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
            this.Subject = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.From = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MailKind = new System.Windows.Forms.PictureBox();
            this.DeleteMsg = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.MailKind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteMsg)).BeginInit();
            this.SuspendLayout();
            // 
            // Subject
            // 
            this.Subject.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Subject.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Subject.ForeColor = System.Drawing.Color.OldLace;
            this.Subject.Location = new System.Drawing.Point(71, 3);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(464, 24);
            this.Subject.TabIndex = 1;
            this.Subject.Text = "Here will show content of mail subject.";
            this.Subject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Subject.Click += new System.EventHandler(this.Subject_Click);
            this.Subject.MouseLeave += new System.EventHandler(this.From_MouseLeave);
            this.Subject.MouseMove += new System.Windows.Forms.MouseEventHandler(this.From_MouseMove);
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.From.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.From.Location = new System.Drawing.Point(72, 27);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(191, 16);
            this.From.TabIndex = 2;
            this.From.Text = "Here will Show sender email";
            this.From.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.From.Click += new System.EventHandler(this.Subject_Click);
            this.From.MouseLeave += new System.EventHandler(this.From_MouseLeave);
            this.From.MouseMove += new System.Windows.Forms.MouseEventHandler(this.From_MouseMove);
            // 
            // MailKind
            // 
            this.MailKind.Image = global::SecureMail.Properties.Resources._008_gmail;
            this.MailKind.Location = new System.Drawing.Point(15, 0);
            this.MailKind.Name = "MailKind";
            this.MailKind.Size = new System.Drawing.Size(50, 50);
            this.MailKind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MailKind.TabIndex = 0;
            this.MailKind.TabStop = false;
            this.MailKind.Click += new System.EventHandler(this.Subject_Click);
            this.MailKind.MouseLeave += new System.EventHandler(this.From_MouseLeave);
            this.MailKind.MouseMove += new System.Windows.Forms.MouseEventHandler(this.From_MouseMove);
            // 
            // DeleteMsg
            // 
            this.DeleteMsg.BackColor = System.Drawing.Color.Transparent;
            this.DeleteMsg.Image = global::SecureMail.Properties.Resources.delete;
            this.DeleteMsg.ImageActive = null;
            this.DeleteMsg.Location = new System.Drawing.Point(577, 11);
            this.DeleteMsg.Name = "DeleteMsg";
            this.DeleteMsg.Size = new System.Drawing.Size(30, 30);
            this.DeleteMsg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DeleteMsg.TabIndex = 22;
            this.DeleteMsg.TabStop = false;
            this.DeleteMsg.Zoom = 10;
            this.DeleteMsg.Click += new System.EventHandler(this.DeleteMsg_Click);
            // 
            // Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.Controls.Add(this.DeleteMsg);
            this.Controls.Add(this.From);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.MailKind);
            this.Name = "Record";
            this.Size = new System.Drawing.Size(610, 50);
            this.Load += new System.EventHandler(this.Record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MailKind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteMsg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MailKind;
        private Bunifu.Framework.UI.BunifuCustomLabel Subject;
        private Bunifu.Framework.UI.BunifuCustomLabel From;
        private Bunifu.Framework.UI.BunifuImageButton DeleteMsg;
    }
}
