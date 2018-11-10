namespace SecureMail.Shutdown
{
    partial class Shutdown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shutdown));
            this.NameOfUserControl_5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ShutdownIcon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShutDownAllRunning = new Bunifu.Framework.UI.BunifuFlatButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TextShw = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CancelShutdown = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.ShutdownIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CancelShutdown)).BeginInit();
            this.SuspendLayout();
            // 
            // NameOfUserControl_5
            // 
            this.NameOfUserControl_5.AutoSize = true;
            this.NameOfUserControl_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameOfUserControl_5.ForeColor = System.Drawing.Color.White;
            this.NameOfUserControl_5.Location = new System.Drawing.Point(46, 20);
            this.NameOfUserControl_5.Name = "NameOfUserControl_5";
            this.NameOfUserControl_5.Size = new System.Drawing.Size(95, 24);
            this.NameOfUserControl_5.TabIndex = 21;
            this.NameOfUserControl_5.Text = "Shutdown";
            // 
            // ShutdownIcon
            // 
            this.ShutdownIcon.Image = global::SecureMail.Properties.Resources._001_shutdown;
            this.ShutdownIcon.Location = new System.Drawing.Point(15, 17);
            this.ShutdownIcon.Name = "ShutdownIcon";
            this.ShutdownIcon.Size = new System.Drawing.Size(25, 25);
            this.ShutdownIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShutdownIcon.TabIndex = 20;
            this.ShutdownIcon.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ShutDownAllRunning);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Location = new System.Drawing.Point(71, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 290);
            this.panel1.TabIndex = 22;
            // 
            // ShutDownAllRunning
            // 
            this.ShutDownAllRunning.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ShutDownAllRunning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ShutDownAllRunning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShutDownAllRunning.BorderRadius = 0;
            this.ShutDownAllRunning.ButtonText = "     SHUTTDOWN";
            this.ShutDownAllRunning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShutDownAllRunning.DisabledColor = System.Drawing.Color.Gray;
            this.ShutDownAllRunning.Iconcolor = System.Drawing.Color.Transparent;
            this.ShutDownAllRunning.Iconimage = global::SecureMail.Properties.Resources._001_shutdown;
            this.ShutDownAllRunning.Iconimage_right = null;
            this.ShutDownAllRunning.Iconimage_right_Selected = null;
            this.ShutDownAllRunning.Iconimage_Selected = null;
            this.ShutDownAllRunning.IconMarginLeft = 0;
            this.ShutDownAllRunning.IconMarginRight = 0;
            this.ShutDownAllRunning.IconRightVisible = true;
            this.ShutDownAllRunning.IconRightZoom = 0D;
            this.ShutDownAllRunning.IconVisible = true;
            this.ShutDownAllRunning.IconZoom = 40D;
            this.ShutDownAllRunning.IsTab = false;
            this.ShutDownAllRunning.Location = new System.Drawing.Point(168, 215);
            this.ShutDownAllRunning.Name = "ShutDownAllRunning";
            this.ShutDownAllRunning.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ShutDownAllRunning.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(168)))), ((int)(((byte)(165)))));
            this.ShutDownAllRunning.OnHoverTextColor = System.Drawing.Color.White;
            this.ShutDownAllRunning.selected = false;
            this.ShutDownAllRunning.Size = new System.Drawing.Size(166, 48);
            this.ShutDownAllRunning.TabIndex = 2;
            this.ShutDownAllRunning.Text = "     SHUTTDOWN";
            this.ShutDownAllRunning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShutDownAllRunning.Textcolor = System.Drawing.Color.White;
            this.ShutDownAllRunning.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShutDownAllRunning.Click += new System.EventHandler(this.ShutDownAllRunning_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(168)))), ((int)(((byte)(165)))));
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.TextShw);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(498, 41);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // TextShw
            // 
            this.TextShw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextShw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextShw.ForeColor = System.Drawing.Color.White;
            this.TextShw.Location = new System.Drawing.Point(3, 0);
            this.TextShw.Name = "TextShw";
            this.TextShw.Size = new System.Drawing.Size(497, 41);
            this.TextShw.TabIndex = 0;
            this.TextShw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(17, 56);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(464, 131);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = resources.GetString("bunifuCustomLabel2.Text");
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CancelShutdown
            // 
            this.CancelShutdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(168)))), ((int)(((byte)(165)))));
            this.CancelShutdown.Image = global::SecureMail.Properties.Resources._012_cancel;
            this.CancelShutdown.ImageActive = null;
            this.CancelShutdown.Location = new System.Drawing.Point(533, 110);
            this.CancelShutdown.Name = "CancelShutdown";
            this.CancelShutdown.Size = new System.Drawing.Size(30, 30);
            this.CancelShutdown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CancelShutdown.TabIndex = 1;
            this.CancelShutdown.TabStop = false;
            this.CancelShutdown.Zoom = 10;
            this.CancelShutdown.Click += new System.EventHandler(this.CancelShutdown_Click);
            // 
            // Shutdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.Controls.Add(this.CancelShutdown);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NameOfUserControl_5);
            this.Controls.Add(this.ShutdownIcon);
            this.Name = "Shutdown";
            this.Size = new System.Drawing.Size(650, 556);
            this.Load += new System.EventHandler(this.Shutdown_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShutdownIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CancelShutdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel NameOfUserControl_5;
        private System.Windows.Forms.PictureBox ShutdownIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel TextShw;
        private Bunifu.Framework.UI.BunifuFlatButton ShutDownAllRunning;
        private Bunifu.Framework.UI.BunifuImageButton CancelShutdown;
    }
}
