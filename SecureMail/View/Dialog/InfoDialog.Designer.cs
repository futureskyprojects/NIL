namespace SecureMail.Dialog
{
    partial class InfoDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoDialog));
            this.InfoRadius = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.InfoLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InfoIcon = new System.Windows.Forms.PictureBox();
            this.ContentInfo = new System.Windows.Forms.Label();
            this.OKBT = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DragInfo = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoRadius
            // 
            this.InfoRadius.ElipseRadius = 20;
            this.InfoRadius.TargetControl = this;
            // 
            // InfoLabel
            // 
            this.InfoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.InfoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.ForeColor = System.Drawing.Color.White;
            this.InfoLabel.Location = new System.Drawing.Point(0, 0);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(440, 58);
            this.InfoLabel.TabIndex = 2;
            this.InfoLabel.Text = "INFOMATION";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.InfoIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(84, 197);
            this.panel1.TabIndex = 3;
            // 
            // InfoIcon
            // 
            this.InfoIcon.Image = global::SecureMail.Properties.Resources.info;
            this.InfoIcon.Location = new System.Drawing.Point(33, 35);
            this.InfoIcon.Name = "InfoIcon";
            this.InfoIcon.Size = new System.Drawing.Size(51, 50);
            this.InfoIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InfoIcon.TabIndex = 0;
            this.InfoIcon.TabStop = false;
            // 
            // ContentInfo
            // 
            this.ContentInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ContentInfo.Location = new System.Drawing.Point(84, 58);
            this.ContentInfo.Name = "ContentInfo";
            this.ContentInfo.Size = new System.Drawing.Size(356, 134);
            this.ContentInfo.TabIndex = 4;
            this.ContentInfo.Text = "Warning content will be here!";
            this.ContentInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OKBT
            // 
            this.OKBT.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.OKBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
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
            this.OKBT.Location = new System.Drawing.Point(330, 195);
            this.OKBT.Name = "OKBT";
            this.OKBT.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.OKBT.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.OKBT.OnHoverTextColor = System.Drawing.Color.White;
            this.OKBT.selected = false;
            this.OKBT.Size = new System.Drawing.Size(98, 48);
            this.OKBT.TabIndex = 5;
            this.OKBT.Text = "OK";
            this.OKBT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OKBT.Textcolor = System.Drawing.Color.White;
            this.OKBT.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKBT.Click += new System.EventHandler(this.OKBT_Click);
            // 
            // DragInfo
            // 
            this.DragInfo.Fixed = true;
            this.DragInfo.Horizontal = true;
            this.DragInfo.TargetControl = this.InfoLabel;
            this.DragInfo.Vertical = true;
            // 
            // InfoDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 255);
            this.Controls.Add(this.OKBT);
            this.Controls.Add(this.ContentInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InfoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InfoDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoDialog";
            this.Load += new System.EventHandler(this.InfoDialog_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InfoIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse InfoRadius;
        private Bunifu.Framework.UI.BunifuCustomLabel InfoLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox InfoIcon;
        private System.Windows.Forms.Label ContentInfo;
        private Bunifu.Framework.UI.BunifuFlatButton OKBT;
        private Bunifu.Framework.UI.BunifuDragControl DragInfo;
    }
}