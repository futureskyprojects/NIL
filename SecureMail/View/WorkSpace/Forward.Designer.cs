namespace SecureMail.WorkSpace
{
    partial class ForwardS
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
            this.MailAddressList = new System.Windows.Forms.DataGridView();
            this.MailAddressX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MailAddress = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.Add = new System.Windows.Forms.Button();
            this.ForWardAccept = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.MailAddressList)).BeginInit();
            this.SuspendLayout();
            // 
            // MailAddressList
            // 
            this.MailAddressList.AllowUserToAddRows = false;
            this.MailAddressList.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.MailAddressList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MailAddressList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MailAddressList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MailAddressX});
            this.MailAddressList.EnableHeadersVisualStyles = false;
            this.MailAddressList.Location = new System.Drawing.Point(3, 85);
            this.MailAddressList.MultiSelect = false;
            this.MailAddressList.Name = "MailAddressList";
            this.MailAddressList.RowHeadersVisible = false;
            this.MailAddressList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MailAddressList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MailAddressList.Size = new System.Drawing.Size(227, 139);
            this.MailAddressList.TabIndex = 100;
            this.MailAddressList.TabStop = false;
            this.MailAddressList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MailAddressList_CellMouseClick);
            // 
            // MailAddressX
            // 
            this.MailAddressX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MailAddressX.DefaultCellStyle = dataGridViewCellStyle1;
            this.MailAddressX.HeaderText = "List added mail address";
            this.MailAddressX.Name = "MailAddressX";
            // 
            // MailAddress
            // 
            this.MailAddress.AccessibleDescription = "Input destination here";
            this.MailAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.MailAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.MailAddress.BorderColor = System.Drawing.Color.SeaGreen;
            this.MailAddress.Location = new System.Drawing.Point(3, 9);
            this.MailAddress.Name = "MailAddress";
            this.MailAddress.Size = new System.Drawing.Size(146, 20);
            this.MailAddress.TabIndex = 0;
            this.MailAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MailAddress_KeyDown);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(155, 9);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 20);
            this.Add.TabIndex = 2;
            this.Add.TabStop = false;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // ForWardAccept
            // 
            this.ForWardAccept.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ForWardAccept.BackColor = System.Drawing.Color.Teal;
            this.ForWardAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ForWardAccept.BorderRadius = 0;
            this.ForWardAccept.ButtonText = "FORWARD";
            this.ForWardAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForWardAccept.DisabledColor = System.Drawing.Color.Gray;
            this.ForWardAccept.Iconcolor = System.Drawing.Color.Transparent;
            this.ForWardAccept.Iconimage = global::SecureMail.Properties.Resources.forward_right_arrow_button;
            this.ForWardAccept.Iconimage_right = null;
            this.ForWardAccept.Iconimage_right_Selected = null;
            this.ForWardAccept.Iconimage_Selected = null;
            this.ForWardAccept.IconMarginLeft = 0;
            this.ForWardAccept.IconMarginRight = 0;
            this.ForWardAccept.IconRightVisible = true;
            this.ForWardAccept.IconRightZoom = 0D;
            this.ForWardAccept.IconVisible = true;
            this.ForWardAccept.IconZoom = 50D;
            this.ForWardAccept.IsTab = false;
            this.ForWardAccept.Location = new System.Drawing.Point(3, 35);
            this.ForWardAccept.Name = "ForWardAccept";
            this.ForWardAccept.Normalcolor = System.Drawing.Color.Teal;
            this.ForWardAccept.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ForWardAccept.OnHoverTextColor = System.Drawing.Color.White;
            this.ForWardAccept.selected = false;
            this.ForWardAccept.Size = new System.Drawing.Size(227, 46);
            this.ForWardAccept.TabIndex = 1;
            this.ForWardAccept.Text = "FORWARD";
            this.ForWardAccept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ForWardAccept.Textcolor = System.Drawing.Color.White;
            this.ForWardAccept.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForWardAccept.Click += new System.EventHandler(this.ForWardAccept_Click);
            // 
            // ForwardS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Controls.Add(this.ForWardAccept);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.MailAddress);
            this.Controls.Add(this.MailAddressList);
            this.Name = "ForwardS";
            this.Size = new System.Drawing.Size(233, 229);
            this.Load += new System.EventHandler(this.ForwardS_Load);
            this.SizeChanged += new System.EventHandler(this.ForwardS_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.MailAddressList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MailAddressList;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox MailAddress;
        private System.Windows.Forms.Button Add;
        private Bunifu.Framework.UI.BunifuFlatButton ForWardAccept;
        private System.Windows.Forms.DataGridViewTextBoxColumn MailAddressX;
    }
}
