namespace SecureMail.Dialog
{
    partial class WarnDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarnDialog));
            this.WarningDialog = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.WarningLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WarningIcon = new System.Windows.Forms.PictureBox();
            this.ContentWarning = new System.Windows.Forms.Label();
            this.OKBT = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DragWarning = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarningIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // WarningDialog
            // 
            this.WarningDialog.ElipseRadius = 20;
            this.WarningDialog.TargetControl = this;
            // 
            // WarningLabel
            // 
            this.WarningLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.WarningLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningLabel.ForeColor = System.Drawing.Color.White;
            this.WarningLabel.Location = new System.Drawing.Point(0, 0);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(440, 58);
            this.WarningLabel.TabIndex = 1;
            this.WarningLabel.Text = "WARNING!";
            this.WarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.WarningIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(84, 197);
            this.panel1.TabIndex = 2;
            // 
            // WarningIcon
            // 
            this.WarningIcon.Image = global::SecureMail.Properties.Resources.warning;
            this.WarningIcon.Location = new System.Drawing.Point(33, 35);
            this.WarningIcon.Name = "WarningIcon";
            this.WarningIcon.Size = new System.Drawing.Size(51, 50);
            this.WarningIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WarningIcon.TabIndex = 0;
            this.WarningIcon.TabStop = false;
            // 
            // ContentWarning
            // 
            this.ContentWarning.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContentWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ContentWarning.Location = new System.Drawing.Point(84, 58);
            this.ContentWarning.Name = "ContentWarning";
            this.ContentWarning.Size = new System.Drawing.Size(356, 134);
            this.ContentWarning.TabIndex = 3;
            this.ContentWarning.Text = "Warning content will be here!";
            this.ContentWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OKBT
            // 
            this.OKBT.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.OKBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
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
            this.OKBT.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.OKBT.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.OKBT.OnHoverTextColor = System.Drawing.Color.White;
            this.OKBT.selected = false;
            this.OKBT.Size = new System.Drawing.Size(98, 48);
            this.OKBT.TabIndex = 4;
            this.OKBT.Text = "OK";
            this.OKBT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OKBT.Textcolor = System.Drawing.Color.White;
            this.OKBT.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKBT.Click += new System.EventHandler(this.OKBT_Click);
            // 
            // DragWarning
            // 
            this.DragWarning.Fixed = true;
            this.DragWarning.Horizontal = true;
            this.DragWarning.TargetControl = this.WarningLabel;
            this.DragWarning.Vertical = true;
            // 
            // WarnDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 255);
            this.Controls.Add(this.OKBT);
            this.Controls.Add(this.ContentWarning);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.WarningLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WarnDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WarnDialog";
            this.Load += new System.EventHandler(this.WarnDialog_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WarningIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse WarningDialog;
        private Bunifu.Framework.UI.BunifuCustomLabel WarningLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox WarningIcon;
        private System.Windows.Forms.Label ContentWarning;
        private Bunifu.Framework.UI.BunifuFlatButton OKBT;
        private Bunifu.Framework.UI.BunifuDragControl DragWarning;
    }
}