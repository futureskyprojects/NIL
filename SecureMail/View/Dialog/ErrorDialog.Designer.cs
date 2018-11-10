namespace SecureMail.Dialog
{
    partial class ErrorDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorDialog));
            this.ErrorRadius = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DragError = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ErrorLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ContentError = new System.Windows.Forms.Label();
            this.OKBT = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Header = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // ErrorRadius
            // 
            this.ErrorRadius.ElipseRadius = 20;
            this.ErrorRadius.TargetControl = this;
            // 
            // DragError
            // 
            this.DragError.Fixed = true;
            this.DragError.Horizontal = true;
            this.DragError.TargetControl = this.ErrorLabel;
            this.DragError.Vertical = true;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.White;
            this.ErrorLabel.Location = new System.Drawing.Point(0, 0);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(440, 58);
            this.ErrorLabel.TabIndex = 0;
            this.ErrorLabel.Text = "ERROR";
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SecureMail.Properties.Resources.cancel;
            this.pictureBox1.Location = new System.Drawing.Point(33, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(84, 197);
            this.panel1.TabIndex = 1;
            // 
            // ContentError
            // 
            this.ContentError.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContentError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ContentError.Location = new System.Drawing.Point(84, 58);
            this.ContentError.Name = "ContentError";
            this.ContentError.Size = new System.Drawing.Size(356, 134);
            this.ContentError.TabIndex = 2;
            this.ContentError.Text = "Error content will be here!";
            this.ContentError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OKBT
            // 
            this.OKBT.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.OKBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.OKBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OKBT.BorderRadius = 0;
            this.OKBT.ButtonText = "OK";
            this.OKBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OKBT.DisabledColor = System.Drawing.Color.Gray;
            this.OKBT.Iconcolor = System.Drawing.Color.Transparent;
            this.OKBT.Iconimage = ((System.Drawing.Image)(resources.GetObject("OKBT.Iconimage")));
            this.OKBT.Iconimage_right = null;
            this.OKBT.Iconimage_right_Selected = null;
            this.OKBT.Iconimage_Selected = null;
            this.OKBT.IconMarginLeft = 0;
            this.OKBT.IconMarginRight = 0;
            this.OKBT.IconRightVisible = true;
            this.OKBT.IconRightZoom = 0D;
            this.OKBT.IconVisible = true;
            this.OKBT.IconZoom = 90D;
            this.OKBT.IsTab = false;
            this.OKBT.Location = new System.Drawing.Point(331, 195);
            this.OKBT.Name = "OKBT";
            this.OKBT.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.OKBT.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.OKBT.OnHoverTextColor = System.Drawing.Color.White;
            this.OKBT.selected = false;
            this.OKBT.Size = new System.Drawing.Size(98, 48);
            this.OKBT.TabIndex = 3;
            this.OKBT.Text = "OK";
            this.OKBT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OKBT.Textcolor = System.Drawing.Color.White;
            this.OKBT.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKBT.Click += new System.EventHandler(this.OKBT_Click);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.Header.Controls.Add(this.ErrorLabel);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(440, 58);
            this.Header.TabIndex = 0;
            // 
            // ErrorDialog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(440, 255);
            this.Controls.Add(this.OKBT);
            this.Controls.Add(this.ContentError);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ErrorDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ErrorDialog";
            this.Load += new System.EventHandler(this.ErrorDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ErrorRadius;
        private Bunifu.Framework.UI.BunifuDragControl DragError;
        private Bunifu.Framework.UI.BunifuFlatButton OKBT;
        private System.Windows.Forms.Label ContentError;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Header;
        private Bunifu.Framework.UI.BunifuCustomLabel ErrorLabel;
    }
}