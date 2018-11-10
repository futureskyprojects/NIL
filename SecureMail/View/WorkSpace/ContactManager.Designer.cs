namespace SecureMail.WorkSpace
{
    partial class ContactManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NAMEXZ = new System.Windows.Forms.Label();
            this.NewMailAddress = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.MailList = new System.Windows.Forms.DataGridView();
            this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._Back = new Bunifu.Framework.UI.BunifuImageButton();
            this._loading = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MailList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._loading)).BeginInit();
            this.SuspendLayout();
            // 
            // NAMEXZ
            // 
            this.NAMEXZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAMEXZ.ForeColor = System.Drawing.Color.White;
            this.NAMEXZ.Location = new System.Drawing.Point(3, 10);
            this.NAMEXZ.Name = "NAMEXZ";
            this.NAMEXZ.Size = new System.Drawing.Size(594, 63);
            this.NAMEXZ.TabIndex = 0;
            this.NAMEXZ.Text = "CONTACTS MANAGE";
            this.NAMEXZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewMailAddress
            // 
            this.NewMailAddress.BackColor = System.Drawing.Color.White;
            this.NewMailAddress.BorderColorFocused = System.Drawing.Color.Transparent;
            this.NewMailAddress.BorderColorIdle = System.Drawing.Color.Transparent;
            this.NewMailAddress.BorderColorMouseHover = System.Drawing.Color.Transparent;
            this.NewMailAddress.BorderThickness = 3;
            this.NewMailAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NewMailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.NewMailAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NewMailAddress.isPassword = false;
            this.NewMailAddress.Location = new System.Drawing.Point(25, 87);
            this.NewMailAddress.Margin = new System.Windows.Forms.Padding(4);
            this.NewMailAddress.Name = "NewMailAddress";
            this.NewMailAddress.Padding = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.NewMailAddress.Size = new System.Drawing.Size(548, 51);
            this.NewMailAddress.TabIndex = 3;
            this.NewMailAddress.Text = "Add new contacts && Press \'Enter\'";
            this.NewMailAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NewMailAddress.TabStopChanged += new System.EventHandler(this.NewMailAddress_TabStopChanged);
            this.NewMailAddress.Click += new System.EventHandler(this.NewMailAddress_Click);
            this.NewMailAddress.Enter += new System.EventHandler(this.NewMailAddress_Enter);
            this.NewMailAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewMailAddress_KeyDown);
            this.NewMailAddress.Leave += new System.EventHandler(this.NewMailAddress_Leave);
            // 
            // MailList
            // 
            this.MailList.AllowUserToAddRows = false;
            this.MailList.AllowUserToDeleteRows = false;
            this.MailList.BackgroundColor = System.Drawing.Color.White;
            this.MailList.ColumnHeadersHeight = 40;
            this.MailList.ColumnHeadersVisible = false;
            this.MailList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmailAddress});
            this.MailList.Location = new System.Drawing.Point(25, 151);
            this.MailList.MultiSelect = false;
            this.MailList.Name = "MailList";
            this.MailList.ReadOnly = true;
            this.MailList.RowHeadersVisible = false;
            this.MailList.RowHeadersWidth = 50;
            this.MailList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MailList.Size = new System.Drawing.Size(548, 325);
            this.MailList.TabIndex = 4;
            this.MailList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MailList_CellDoubleClick);
            this.MailList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MailList_CellMouseClick);
            // 
            // EmailAddress
            // 
            this.EmailAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(30, 5, 5, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmailAddress.DefaultCellStyle = dataGridViewCellStyle1;
            this.EmailAddress.HeaderText = "EmailAddress";
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.ReadOnly = true;
            this.EmailAddress.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::SecureMail.Properties.Resources._;
            this.pictureBox1.Location = new System.Drawing.Point(32, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // _Back
            // 
            this._Back.BackColor = System.Drawing.Color.Transparent;
            this._Back.Image = global::SecureMail.Properties.Resources.back_white;
            this._Back.ImageActive = null;
            this._Back.Location = new System.Drawing.Point(543, 10);
            this._Back.Name = "_Back";
            this._Back.Size = new System.Drawing.Size(40, 40);
            this._Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._Back.TabIndex = 6;
            this._Back.TabStop = false;
            this._Back.Zoom = 10;
            this._Back.Click += new System.EventHandler(this._Back_Click);
            // 
            // _loading
            // 
            this._loading.BackColor = System.Drawing.Color.White;
            this._loading.Image = global::SecureMail.Properties.Resources.LOad;
            this._loading.Location = new System.Drawing.Point(529, 94);
            this._loading.Name = "_loading";
            this._loading.Size = new System.Drawing.Size(40, 40);
            this._loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._loading.TabIndex = 7;
            this._loading.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(286, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. \'Right click\' to delete mail address\r\n2. \'Double left click\' to send new mail " +
    " to selected mail address.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ContactManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label1);
            this.Controls.Add(this._loading);
            this.Controls.Add(this._Back);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MailList);
            this.Controls.Add(this.NewMailAddress);
            this.Controls.Add(this.NAMEXZ);
            this.Name = "ContactManager";
            this.Size = new System.Drawing.Size(600, 512);
            this.Load += new System.EventHandler(this.ContactManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MailList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._loading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NAMEXZ;
        private Bunifu.Framework.UI.BunifuMetroTextbox NewMailAddress;
        private System.Windows.Forms.DataGridView MailList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton _Back;
        private System.Windows.Forms.PictureBox _loading;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
        private System.Windows.Forms.Label label1;
    }
}
