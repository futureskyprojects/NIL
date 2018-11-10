namespace SecureMail.WorkSpace
{
    partial class EnterKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterKey));
            this.EnterKeyRadius = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Header = new System.Windows.Forms.Panel();
            this.ClosePop = new Bunifu.Framework.UI.BunifuImageButton();
            this.EnterKeyLB = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.accept = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DragEnterKey = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Password = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CryptType = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // EnterKeyRadius
            // 
            this.EnterKeyRadius.ElipseRadius = 5;
            this.EnterKeyRadius.TargetControl = this;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Header.Controls.Add(this.pictureBox3);
            this.Header.Controls.Add(this.ClosePop);
            this.Header.Controls.Add(this.EnterKeyLB);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(378, 50);
            this.Header.TabIndex = 0;
            // 
            // ClosePop
            // 
            this.ClosePop.BackColor = System.Drawing.Color.Transparent;
            this.ClosePop.Image = global::SecureMail.Properties.Resources._012_cancel;
            this.ClosePop.ImageActive = null;
            this.ClosePop.Location = new System.Drawing.Point(350, 3);
            this.ClosePop.Name = "ClosePop";
            this.ClosePop.Size = new System.Drawing.Size(25, 25);
            this.ClosePop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClosePop.TabIndex = 1;
            this.ClosePop.TabStop = false;
            this.ClosePop.Zoom = 10;
            this.ClosePop.Click += new System.EventHandler(this.ClosePop_Click);
            // 
            // EnterKeyLB
            // 
            this.EnterKeyLB.AutoSize = true;
            this.EnterKeyLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterKeyLB.ForeColor = System.Drawing.Color.White;
            this.EnterKeyLB.Location = new System.Drawing.Point(133, 9);
            this.EnterKeyLB.Name = "EnterKeyLB";
            this.EnterKeyLB.Size = new System.Drawing.Size(128, 29);
            this.EnterKeyLB.TabIndex = 0;
            this.EnterKeyLB.Text = "DECRYPT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SecureMail.Properties.Resources.door_key;
            this.pictureBox1.Location = new System.Drawing.Point(8, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // accept
            // 
            this.accept.ActiveBorderThickness = 1;
            this.accept.ActiveCornerRadius = 20;
            this.accept.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.accept.ActiveForecolor = System.Drawing.Color.White;
            this.accept.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.accept.BackColor = System.Drawing.SystemColors.Control;
            this.accept.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("accept.BackgroundImage")));
            this.accept.ButtonText = "Decrypt";
            this.accept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accept.ForeColor = System.Drawing.Color.SeaGreen;
            this.accept.IdleBorderThickness = 1;
            this.accept.IdleCornerRadius = 20;
            this.accept.IdleFillColor = System.Drawing.Color.White;
            this.accept.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.accept.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.accept.Location = new System.Drawing.Point(183, 162);
            this.accept.Margin = new System.Windows.Forms.Padding(5);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(181, 61);
            this.accept.TabIndex = 2;
            this.accept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // DragEnterKey
            // 
            this.DragEnterKey.Fixed = true;
            this.DragEnterKey.Horizontal = true;
            this.DragEnterKey.TargetControl = this.Header;
            this.DragEnterKey.Vertical = true;
            // 
            // Password
            // 
            this.Password.BorderColor = System.Drawing.Color.SeaGreen;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(49, 126);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(317, 31);
            this.Password.TabIndex = 3;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password.UseSystemPasswordChar = true;
            this.Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_KeyDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SecureMail.Properties.Resources.locked_1234;
            this.pictureBox2.Location = new System.Drawing.Point(8, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // CryptType
            // 
            this.CryptType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CryptType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.CryptType.FormattingEnabled = true;
            this.CryptType.Items.AddRange(new object[] {
            "AES",
            "DES",
            "TwoFish",
            "BlowFish"});
            this.CryptType.Location = new System.Drawing.Point(49, 70);
            this.CryptType.Name = "CryptType";
            this.CryptType.Size = new System.Drawing.Size(317, 33);
            this.CryptType.TabIndex = 5;
            this.CryptType.SelectedIndexChanged += new System.EventHandler(this.CryptType_SelectedIndexChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SecureMail.Properties.Resources.NUL_LOGO_SMALL;
            this.pictureBox3.Location = new System.Drawing.Point(8, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // EnterKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 237);
            this.Controls.Add(this.CryptType);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnterKey";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnterKey";
            this.Load += new System.EventHandler(this.EnterKey_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse EnterKeyRadius;
        private System.Windows.Forms.Panel Header;
        private Bunifu.Framework.UI.BunifuCustomLabel EnterKeyLB;
        private Bunifu.Framework.UI.BunifuThinButton2 accept;
        private Bunifu.Framework.UI.BunifuImageButton ClosePop;
        private Bunifu.Framework.UI.BunifuDragControl DragEnterKey;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox CryptType;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}