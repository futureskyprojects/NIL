namespace SecureMail.Dialog
{
    partial class SelectAccountsKind
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectAccountsKind));
            this.AccountsKind = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Header = new System.Windows.Forms.Panel();
            this.CloseBT = new Bunifu.Framework.UI.BunifuImageButton();
            this.LoginWithAsk = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DragAccountKind = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.HotMail = new Bunifu.Framework.UI.BunifuImageButton();
            this.YahooMail = new Bunifu.Framework.UI.BunifuImageButton();
            this.Gmail = new Bunifu.Framework.UI.BunifuImageButton();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HotMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YahooMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gmail)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountsKind
            // 
            this.AccountsKind.ElipseRadius = 20;
            this.AccountsKind.TargetControl = this;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(168)))), ((int)(((byte)(165)))));
            this.Header.Controls.Add(this.CloseBT);
            this.Header.Controls.Add(this.LoginWithAsk);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(440, 46);
            this.Header.TabIndex = 0;
            // 
            // CloseBT
            // 
            this.CloseBT.BackColor = System.Drawing.Color.Transparent;
            this.CloseBT.Image = global::SecureMail.Properties.Resources._012_cancel;
            this.CloseBT.ImageActive = null;
            this.CloseBT.Location = new System.Drawing.Point(393, 7);
            this.CloseBT.Name = "CloseBT";
            this.CloseBT.Size = new System.Drawing.Size(30, 30);
            this.CloseBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseBT.TabIndex = 1;
            this.CloseBT.TabStop = false;
            this.CloseBT.Zoom = 10;
            this.CloseBT.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // LoginWithAsk
            // 
            this.LoginWithAsk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginWithAsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginWithAsk.ForeColor = System.Drawing.Color.White;
            this.LoginWithAsk.Location = new System.Drawing.Point(0, 0);
            this.LoginWithAsk.Name = "LoginWithAsk";
            this.LoginWithAsk.Size = new System.Drawing.Size(440, 46);
            this.LoginWithAsk.TabIndex = 0;
            this.LoginWithAsk.Text = "Login With?";
            this.LoginWithAsk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DragAccountKind
            // 
            this.DragAccountKind.Fixed = true;
            this.DragAccountKind.Horizontal = true;
            this.DragAccountKind.TargetControl = this.LoginWithAsk;
            this.DragAccountKind.Vertical = true;
            // 
            // HotMail
            // 
            this.HotMail.BackColor = System.Drawing.Color.Transparent;
            this.HotMail.Image = global::SecureMail.Properties.Resources.Live_Hotmail;
            this.HotMail.ImageActive = null;
            this.HotMail.Location = new System.Drawing.Point(311, 89);
            this.HotMail.Name = "HotMail";
            this.HotMail.Size = new System.Drawing.Size(80, 80);
            this.HotMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HotMail.TabIndex = 3;
            this.HotMail.TabStop = false;
            this.HotMail.Zoom = 10;
            this.HotMail.Click += new System.EventHandler(this.HotMail_Click);
            // 
            // YahooMail
            // 
            this.YahooMail.BackColor = System.Drawing.Color.Transparent;
            this.YahooMail.Image = global::SecureMail.Properties.Resources._007_yahoo;
            this.YahooMail.ImageActive = null;
            this.YahooMail.Location = new System.Drawing.Point(178, 89);
            this.YahooMail.Name = "YahooMail";
            this.YahooMail.Size = new System.Drawing.Size(80, 80);
            this.YahooMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.YahooMail.TabIndex = 2;
            this.YahooMail.TabStop = false;
            this.YahooMail.Zoom = 10;
            this.YahooMail.Click += new System.EventHandler(this.YahooMail_Click);
            // 
            // Gmail
            // 
            this.Gmail.BackColor = System.Drawing.Color.Transparent;
            this.Gmail.Image = global::SecureMail.Properties.Resources._008_gmail;
            this.Gmail.ImageActive = null;
            this.Gmail.Location = new System.Drawing.Point(47, 89);
            this.Gmail.Name = "Gmail";
            this.Gmail.Size = new System.Drawing.Size(80, 80);
            this.Gmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Gmail.TabIndex = 1;
            this.Gmail.TabStop = false;
            this.Gmail.Zoom = 10;
            this.Gmail.Click += new System.EventHandler(this.Gmail_Click);
            // 
            // SelectAccountsKind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(440, 236);
            this.Controls.Add(this.HotMail);
            this.Controls.Add(this.YahooMail);
            this.Controls.Add(this.Gmail);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectAccountsKind";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectAccountsKind";
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HotMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YahooMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gmail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse AccountsKind;
        private System.Windows.Forms.Panel Header;
        private Bunifu.Framework.UI.BunifuImageButton Gmail;
        private Bunifu.Framework.UI.BunifuCustomLabel LoginWithAsk;
        private Bunifu.Framework.UI.BunifuImageButton HotMail;
        private Bunifu.Framework.UI.BunifuImageButton YahooMail;
        private Bunifu.Framework.UI.BunifuImageButton CloseBT;
        private Bunifu.Framework.UI.BunifuDragControl DragAccountKind;
    }
}