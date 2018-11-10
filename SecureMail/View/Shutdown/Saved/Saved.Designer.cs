namespace SecureMail.Saved
{
    partial class Saved
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
            this.ListSavedMails = new System.Windows.Forms.FlowLayoutPanel();
            this.NameOfUserControl_2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SavedIcon = new System.Windows.Forms.PictureBox();
            this.EmptySavedMails = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ShowMailContents = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.SavedIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // ListSavedMails
            // 
            this.ListSavedMails.AutoScroll = true;
            this.ListSavedMails.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ListSavedMails.Location = new System.Drawing.Point(3, 80);
            this.ListSavedMails.Name = "ListSavedMails";
            this.ListSavedMails.Size = new System.Drawing.Size(642, 463);
            this.ListSavedMails.TabIndex = 1;
            this.ListSavedMails.WrapContents = false;
            // 
            // NameOfUserControl_2
            // 
            this.NameOfUserControl_2.AutoSize = true;
            this.NameOfUserControl_2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameOfUserControl_2.ForeColor = System.Drawing.Color.White;
            this.NameOfUserControl_2.Location = new System.Drawing.Point(46, 20);
            this.NameOfUserControl_2.Name = "NameOfUserControl_2";
            this.NameOfUserControl_2.Size = new System.Drawing.Size(118, 22);
            this.NameOfUserControl_2.TabIndex = 17;
            this.NameOfUserControl_2.Text = "Saved Mails";
            // 
            // SavedIcon
            // 
            this.SavedIcon.Image = global::SecureMail.Properties.Resources._004_download_button;
            this.SavedIcon.Location = new System.Drawing.Point(15, 17);
            this.SavedIcon.Name = "SavedIcon";
            this.SavedIcon.Size = new System.Drawing.Size(25, 25);
            this.SavedIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SavedIcon.TabIndex = 16;
            this.SavedIcon.TabStop = false;
            // 
            // EmptySavedMails
            // 
            this.EmptySavedMails.AutoSize = true;
            this.EmptySavedMails.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmptySavedMails.ForeColor = System.Drawing.Color.White;
            this.EmptySavedMails.Location = new System.Drawing.Point(276, 286);
            this.EmptySavedMails.Name = "EmptySavedMails";
            this.EmptySavedMails.Size = new System.Drawing.Size(68, 22);
            this.EmptySavedMails.TabIndex = 18;
            this.EmptySavedMails.Text = "Empty";
            // 
            // ShowMailContents
            // 
            this.ShowMailContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowMailContents.Location = new System.Drawing.Point(0, 0);
            this.ShowMailContents.Name = "ShowMailContents";
            this.ShowMailContents.Size = new System.Drawing.Size(650, 556);
            this.ShowMailContents.TabIndex = 19;
            // 
            // Saved
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.Controls.Add(this.ShowMailContents);
            this.Controls.Add(this.EmptySavedMails);
            this.Controls.Add(this.ListSavedMails);
            this.Controls.Add(this.NameOfUserControl_2);
            this.Controls.Add(this.SavedIcon);
            this.Name = "Saved";
            this.Size = new System.Drawing.Size(650, 556);
            this.Load += new System.EventHandler(this.Saved_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SavedIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel NameOfUserControl_2;
        private System.Windows.Forms.PictureBox SavedIcon;
        private System.Windows.Forms.FlowLayoutPanel ListSavedMails;
        private Bunifu.Framework.UI.BunifuCustomLabel EmptySavedMails;
        private System.Windows.Forms.FlowLayoutPanel ShowMailContents;
    }
}
