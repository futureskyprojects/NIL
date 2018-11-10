#pragma warning disable
namespace SecureMail.WorkSpace.Compose
{
    partial class Gmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gmail));
            this.SendRadius = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SendBT = new Bunifu.Framework.UI.BunifuFlatButton();
            this.GmailRadius = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Bottom = new System.Windows.Forms.Panel();
            this.Content = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.BOXATT = new System.Windows.Forms.Panel();
            this.FileNameShow = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.@__COUNT = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.CryptType = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Password = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TurnOnUsePass = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.Attachment = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.PanelSubject = new System.Windows.Forms.Panel();
            this.Subject = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.SubjectLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PanelTo = new System.Windows.Forms.Panel();
            this.SendTo = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.ToLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Header = new System.Windows.Forms.Panel();
            this.CloseCompose = new Bunifu.Framework.UI.BunifuImageButton();
            this.Title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MainPanel.SuspendLayout();
            this.Bottom.SuspendLayout();
            this.BOXATT.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attachment)).BeginInit();
            this.PanelSubject.SuspendLayout();
            this.PanelTo.SuspendLayout();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseCompose)).BeginInit();
            this.SuspendLayout();
            // 
            // SendRadius
            // 
            this.SendRadius.ElipseRadius = 13;
            this.SendRadius.TargetControl = this.SendBT;
            // 
            // SendBT
            // 
            this.SendBT.Activecolor = System.Drawing.Color.Firebrick;
            this.SendBT.BackColor = System.Drawing.Color.Firebrick;
            this.SendBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SendBT.BorderRadius = 0;
            this.SendBT.ButtonText = "       Send";
            this.SendBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendBT.DisabledColor = System.Drawing.Color.Gray;
            this.SendBT.Iconcolor = System.Drawing.Color.Transparent;
            this.SendBT.Iconimage = null;
            this.SendBT.Iconimage_right = null;
            this.SendBT.Iconimage_right_Selected = null;
            this.SendBT.Iconimage_Selected = null;
            this.SendBT.IconMarginLeft = 0;
            this.SendBT.IconMarginRight = 0;
            this.SendBT.IconRightVisible = true;
            this.SendBT.IconRightZoom = 0D;
            this.SendBT.IconVisible = true;
            this.SendBT.IconZoom = 90D;
            this.SendBT.IsTab = false;
            this.SendBT.Location = new System.Drawing.Point(10, 10);
            this.SendBT.Name = "SendBT";
            this.SendBT.Normalcolor = System.Drawing.Color.Firebrick;
            this.SendBT.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SendBT.OnHoverTextColor = System.Drawing.Color.White;
            this.SendBT.selected = false;
            this.SendBT.Size = new System.Drawing.Size(84, 32);
            this.SendBT.TabIndex = 0;
            this.SendBT.Text = "       Send";
            this.SendBT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SendBT.Textcolor = System.Drawing.Color.White;
            this.SendBT.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendBT.Click += new System.EventHandler(this.SendBT_Click);
            // 
            // GmailRadius
            // 
            this.GmailRadius.ElipseRadius = 10;
            this.GmailRadius.TargetControl = this.MainPanel;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainPanel.Controls.Add(this.Bottom);
            this.MainPanel.Controls.Add(this.panel8);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.panel6);
            this.MainPanel.Controls.Add(this.PanelSubject);
            this.MainPanel.Controls.Add(this.panel4);
            this.MainPanel.Controls.Add(this.PanelTo);
            this.MainPanel.Controls.Add(this.Header);
            this.MainPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MainPanel.Location = new System.Drawing.Point(51, 3);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(497, 506);
            this.MainPanel.TabIndex = 1;
            // 
            // Bottom
            // 
            this.Bottom.Controls.Add(this.Content);
            this.Bottom.Controls.Add(this.BOXATT);
            this.Bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bottom.Location = new System.Drawing.Point(0, 153);
            this.Bottom.Name = "Bottom";
            this.Bottom.Size = new System.Drawing.Size(493, 299);
            this.Bottom.TabIndex = 5;
            // 
            // Content
            // 
            this.Content.BorderColor = System.Drawing.Color.SeaGreen;
            this.Content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Multiline = true;
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(493, 217);
            this.Content.TabIndex = 0;
            this.Content.TextChanged += new System.EventHandler(this.Content_TextChanged);
            this.Content.Leave += new System.EventHandler(this.Content_Leave);
            // 
            // BOXATT
            // 
            this.BOXATT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BOXATT.Controls.Add(this.FileNameShow);
            this.BOXATT.Controls.Add(this.panel7);
            this.BOXATT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BOXATT.Location = new System.Drawing.Point(0, 217);
            this.BOXATT.Name = "BOXATT";
            this.BOXATT.Size = new System.Drawing.Size(493, 82);
            this.BOXATT.TabIndex = 1;
            // 
            // FileNameShow
            // 
            this.FileNameShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileNameShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileNameShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileNameShow.Location = new System.Drawing.Point(0, 33);
            this.FileNameShow.Multiline = true;
            this.FileNameShow.Name = "FileNameShow";
            this.FileNameShow.ReadOnly = true;
            this.FileNameShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FileNameShow.Size = new System.Drawing.Size(493, 49);
            this.FileNameShow.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Silver;
            this.panel7.Controls.Add(this.@__COUNT);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(493, 33);
            this.panel7.TabIndex = 0;
            // 
            // __COUNT
            // 
            this.@__COUNT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.@__COUNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.@__COUNT.Location = new System.Drawing.Point(0, 0);
            this.@__COUNT.Name = "__COUNT";
            this.@__COUNT.Size = new System.Drawing.Size(493, 33);
            this.@__COUNT.TabIndex = 0;
            this.@__COUNT.Text = "SELECTED X FILE(S)";
            this.@__COUNT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.CryptType);
            this.panel8.Controls.Add(this.pictureBox2);
            this.panel8.Controls.Add(this.pictureBox1);
            this.panel8.Controls.Add(this.Password);
            this.panel8.Controls.Add(this.TurnOnUsePass);
            this.panel8.Controls.Add(this.Attachment);
            this.panel8.Controls.Add(this.SendBT);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 452);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(493, 50);
            this.panel8.TabIndex = 7;
            // 
            // CryptType
            // 
            this.CryptType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CryptType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CryptType.FormattingEnabled = true;
            this.CryptType.Items.AddRange(new object[] {
            "AES",
            "DES",
            "TwoFish",
            "BlowFish"});
            this.CryptType.Location = new System.Drawing.Point(340, 13);
            this.CryptType.Name = "CryptType";
            this.CryptType.Size = new System.Drawing.Size(106, 28);
            this.CryptType.TabIndex = 4;
            this.CryptType.SelectedIndexChanged += new System.EventHandler(this.CryptType_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SecureMail.Properties.Resources.locked_1234;
            this.pictureBox2.Location = new System.Drawing.Point(309, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SecureMail.Properties.Resources.door_key;
            this.pictureBox1.Location = new System.Drawing.Point(133, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Password
            // 
            this.Password.BorderColor = System.Drawing.Color.SeaGreen;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Password.Location = new System.Drawing.Point(164, 13);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(139, 26);
            this.Password.TabIndex = 2;
            this.Password.UseSystemPasswordChar = true;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // TurnOnUsePass
            // 
            this.TurnOnUsePass.BackColor = System.Drawing.Color.Transparent;
            this.TurnOnUsePass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TurnOnUsePass.BackgroundImage")));
            this.TurnOnUsePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TurnOnUsePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TurnOnUsePass.Location = new System.Drawing.Point(452, 16);
            this.TurnOnUsePass.Name = "TurnOnUsePass";
            this.TurnOnUsePass.OffColor = System.Drawing.Color.Gray;
            this.TurnOnUsePass.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.TurnOnUsePass.Size = new System.Drawing.Size(35, 20);
            this.TurnOnUsePass.TabIndex = 0;
            this.TurnOnUsePass.Value = false;
            this.TurnOnUsePass.OnValueChange += new System.EventHandler(this.TurnOnUsePass_OnValueChange);
            // 
            // Attachment
            // 
            this.Attachment.BackColor = System.Drawing.Color.Transparent;
            this.Attachment.Image = global::SecureMail.Properties.Resources.attachment_office_clipmark_attach_icon;
            this.Attachment.ImageActive = null;
            this.Attachment.Location = new System.Drawing.Point(100, 14);
            this.Attachment.Name = "Attachment";
            this.Attachment.Size = new System.Drawing.Size(25, 25);
            this.Attachment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Attachment.TabIndex = 1;
            this.Attachment.TabStop = false;
            this.Attachment.Zoom = 10;
            this.Attachment.Click += new System.EventHandler(this.Attachment_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 1);
            this.panel1.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 151);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(493, 1);
            this.panel6.TabIndex = 4;
            // 
            // PanelSubject
            // 
            this.PanelSubject.BackColor = System.Drawing.Color.White;
            this.PanelSubject.Controls.Add(this.Subject);
            this.PanelSubject.Controls.Add(this.SubjectLabel);
            this.PanelSubject.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubject.Location = new System.Drawing.Point(0, 101);
            this.PanelSubject.Name = "PanelSubject";
            this.PanelSubject.Size = new System.Drawing.Size(493, 50);
            this.PanelSubject.TabIndex = 3;
            // 
            // Subject
            // 
            this.Subject.BackColor = System.Drawing.Color.White;
            this.Subject.BorderColor = System.Drawing.Color.Transparent;
            this.Subject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject.Location = new System.Drawing.Point(68, 13);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(419, 22);
            this.Subject.TabIndex = 2;
            this.Subject.TextChanged += new System.EventHandler(this.Subject_TextChanged);
            this.Subject.Leave += new System.EventHandler(this.Subject_Leave);
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectLabel.Location = new System.Drawing.Point(7, 16);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(53, 16);
            this.SubjectLabel.TabIndex = 1;
            this.SubjectLabel.Text = "Subject";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(493, 1);
            this.panel4.TabIndex = 2;
            // 
            // PanelTo
            // 
            this.PanelTo.BackColor = System.Drawing.Color.White;
            this.PanelTo.Controls.Add(this.SendTo);
            this.PanelTo.Controls.Add(this.ToLabel);
            this.PanelTo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTo.Location = new System.Drawing.Point(0, 50);
            this.PanelTo.Name = "PanelTo";
            this.PanelTo.Size = new System.Drawing.Size(493, 50);
            this.PanelTo.TabIndex = 1;
            // 
            // SendTo
            // 
            this.SendTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SendTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SendTo.BorderColor = System.Drawing.Color.Transparent;
            this.SendTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SendTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendTo.Location = new System.Drawing.Point(68, 14);
            this.SendTo.Name = "SendTo";
            this.SendTo.Size = new System.Drawing.Size(419, 22);
            this.SendTo.TabIndex = 1;
            this.SendTo.TextChanged += new System.EventHandler(this.SendTo_TextChanged);
            this.SendTo.Leave += new System.EventHandler(this.SendTo_Leave);
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLabel.Location = new System.Drawing.Point(7, 17);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(25, 16);
            this.ToLabel.TabIndex = 0;
            this.ToLabel.Text = "To";
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Header.Controls.Add(this.CloseCompose);
            this.Header.Controls.Add(this.Title);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(493, 50);
            this.Header.TabIndex = 0;
            // 
            // CloseCompose
            // 
            this.CloseCompose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CloseCompose.Image = global::SecureMail.Properties.Resources._012_cancel;
            this.CloseCompose.ImageActive = null;
            this.CloseCompose.Location = new System.Drawing.Point(462, 12);
            this.CloseCompose.Name = "CloseCompose";
            this.CloseCompose.Size = new System.Drawing.Size(25, 25);
            this.CloseCompose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseCompose.TabIndex = 2;
            this.CloseCompose.TabStop = false;
            this.CloseCompose.Zoom = 10;
            this.CloseCompose.Click += new System.EventHandler(this.CloseCompose_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(11, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(131, 24);
            this.Title.TabIndex = 0;
            this.Title.Text = "New Message";
            // 
            // Gmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.MainPanel);
            this.Name = "Gmail";
            this.Size = new System.Drawing.Size(599, 530);
            this.Load += new System.EventHandler(this.Gmail_Load);
            this.MainPanel.ResumeLayout(false);
            this.Bottom.ResumeLayout(false);
            this.Bottom.PerformLayout();
            this.BOXATT.ResumeLayout(false);
            this.BOXATT.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attachment)).EndInit();
            this.PanelSubject.ResumeLayout(false);
            this.PanelSubject.PerformLayout();
            this.PanelTo.ResumeLayout(false);
            this.PanelTo.PerformLayout();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseCompose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse SendRadius;
        private Bunifu.Framework.UI.BunifuElipse GmailRadius;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Password;
        private Bunifu.Framework.UI.BunifuiOSSwitch TurnOnUsePass;
        private Bunifu.Framework.UI.BunifuImageButton Attachment;
        private Bunifu.Framework.UI.BunifuFlatButton SendBT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Bottom;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Content;
        private System.Windows.Forms.Panel BOXATT;
        private System.Windows.Forms.TextBox FileNameShow;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label __COUNT;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel PanelTo;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox SendTo;
        private Bunifu.Framework.UI.BunifuCustomLabel ToLabel;
        private System.Windows.Forms.Panel Header;
        private Bunifu.Framework.UI.BunifuImageButton CloseCompose;
        private Bunifu.Framework.UI.BunifuCustomLabel Title;
        private System.Windows.Forms.Panel PanelSubject;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Subject;
        private Bunifu.Framework.UI.BunifuCustomLabel SubjectLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox CryptType;
    }
}