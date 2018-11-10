namespace SecureMail
{
    partial class AccountsList
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
            this.NameOfUserControl_1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.AccountsIcon = new System.Windows.Forms.PictureBox();
            this.ListOfAccount = new System.Windows.Forms.FlowLayoutPanel();
            this.AddNewAccount = new Bunifu.Framework.UI.BunifuImageButton();
            this.emptyX = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddNewAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // NameOfUserControl_1
            // 
            this.NameOfUserControl_1.AutoSize = true;
            this.NameOfUserControl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameOfUserControl_1.ForeColor = System.Drawing.Color.White;
            this.NameOfUserControl_1.Location = new System.Drawing.Point(46, 20);
            this.NameOfUserControl_1.Name = "NameOfUserControl_1";
            this.NameOfUserControl_1.Size = new System.Drawing.Size(163, 24);
            this.NameOfUserControl_1.TabIndex = 15;
            this.NameOfUserControl_1.Text = "Manage Accounts";
            // 
            // AccountsIcon
            // 
            this.AccountsIcon.Image = global::SecureMail.Properties.Resources._005_user_silhouette;
            this.AccountsIcon.Location = new System.Drawing.Point(15, 17);
            this.AccountsIcon.Name = "AccountsIcon";
            this.AccountsIcon.Size = new System.Drawing.Size(25, 25);
            this.AccountsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AccountsIcon.TabIndex = 14;
            this.AccountsIcon.TabStop = false;
            // 
            // ListOfAccount
            // 
            this.ListOfAccount.AutoScroll = true;
            this.ListOfAccount.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.ListOfAccount.Location = new System.Drawing.Point(46, 96);
            this.ListOfAccount.Name = "ListOfAccount";
            this.ListOfAccount.Size = new System.Drawing.Size(585, 448);
            this.ListOfAccount.TabIndex = 16;
            // 
            // AddNewAccount
            // 
            this.AddNewAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.AddNewAccount.Image = global::SecureMail.Properties.Resources.add_user;
            this.AddNewAccount.ImageActive = null;
            this.AddNewAccount.Location = new System.Drawing.Point(581, 17);
            this.AddNewAccount.Name = "AddNewAccount";
            this.AddNewAccount.Size = new System.Drawing.Size(50, 50);
            this.AddNewAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddNewAccount.TabIndex = 17;
            this.AddNewAccount.TabStop = false;
            this.AddNewAccount.Zoom = 10;
            this.AddNewAccount.Click += new System.EventHandler(this.AddNewAccount_Click);
            // 
            // emptyX
            // 
            this.emptyX.AutoSize = true;
            this.emptyX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyX.ForeColor = System.Drawing.Color.White;
            this.emptyX.Location = new System.Drawing.Point(233, 267);
            this.emptyX.Name = "emptyX";
            this.emptyX.Size = new System.Drawing.Size(138, 24);
            this.emptyX.TabIndex = 18;
            this.emptyX.Text = "Account Empty";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(15, 44);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(270, 18);
            this.bunifuCustomLabel1.TabIndex = 19;
            this.bunifuCustomLabel1.Text = "Left-Click to login | Right-Click to Delete";
            // 
            // AccountsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.emptyX);
            this.Controls.Add(this.AddNewAccount);
            this.Controls.Add(this.ListOfAccount);
            this.Controls.Add(this.NameOfUserControl_1);
            this.Controls.Add(this.AccountsIcon);
            this.Name = "AccountsList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(650, 556);
            this.Load += new System.EventHandler(this.Accounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AccountsIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddNewAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox AccountsIcon;
        private Bunifu.Framework.UI.BunifuCustomLabel NameOfUserControl_1;
        private System.Windows.Forms.FlowLayoutPanel ListOfAccount;
        private Bunifu.Framework.UI.BunifuImageButton AddNewAccount;
        private Bunifu.Framework.UI.BunifuCustomLabel emptyX;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}
