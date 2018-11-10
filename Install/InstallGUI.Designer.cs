namespace Install
{
    partial class InstallGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallGUI));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelx = new System.Windows.Forms.Panel();
            this.closeWD = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this._4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this._3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this._2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this._1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.localX = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.install = new System.Windows.Forms.Button();
            this.progress = new Bunifu.Framework.UI.BunifuProgressBar();
            this.statusbox = new System.Windows.Forms.TextBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Change = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeWD)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelx
            // 
            this.panelx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.panelx.Controls.Add(this.closeWD);
            this.panelx.Controls.Add(this.bunifuCustomLabel1);
            this.panelx.Controls.Add(this.panel2);
            this.panelx.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelx.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelx.Location = new System.Drawing.Point(0, 0);
            this.panelx.Name = "panelx";
            this.panelx.Size = new System.Drawing.Size(530, 49);
            this.panelx.TabIndex = 1;
            // 
            // closeWD
            // 
            this.closeWD.BackColor = System.Drawing.Color.Transparent;
            this.closeWD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeWD.Image = ((System.Drawing.Image)(resources.GetObject("closeWD.Image")));
            this.closeWD.ImageActive = null;
            this.closeWD.Location = new System.Drawing.Point(495, 8);
            this.closeWD.Name = "closeWD";
            this.closeWD.Size = new System.Drawing.Size(30, 30);
            this.closeWD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeWD.TabIndex = 4;
            this.closeWD.TabStop = false;
            this.closeWD.Zoom = 10;
            this.closeWD.Click += new System.EventHandler(this.closeWD_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(50, 11);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(88, 25);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "INSTALL";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 40);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox2.Image = global::Install.Properties.Resources._004_download_button;
            this.pictureBox2.Location = new System.Drawing.Point(7, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 90;
            this.bunifuElipse2.TargetControl = this.panel2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this._4);
            this.panel3.Controls.Add(this._3);
            this.panel3.Controls.Add(this._2);
            this.panel3.Controls.Add(this._1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 290);
            this.panel3.TabIndex = 3;
            // 
            // _4
            // 
            this._4.AutoSize = true;
            this._4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._4.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._4.ForeColor = System.Drawing.Color.White;
            this._4.Location = new System.Drawing.Point(-1, 171);
            this._4.Name = "_4";
            this._4.Padding = new System.Windows.Forms.Padding(10);
            this._4.Size = new System.Drawing.Size(143, 45);
            this._4.TabIndex = 9;
            this._4.Text = "4. Complete";
            // 
            // _3
            // 
            this._3.AutoSize = true;
            this._3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._3.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._3.ForeColor = System.Drawing.Color.White;
            this._3.Location = new System.Drawing.Point(-1, 126);
            this._3.Name = "_3";
            this._3.Padding = new System.Windows.Forms.Padding(10);
            this._3.Size = new System.Drawing.Size(154, 45);
            this._3.TabIndex = 8;
            this._3.Text = "3. Finishing...";
            // 
            // _2
            // 
            this._2.AutoSize = true;
            this._2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._2.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._2.ForeColor = System.Drawing.Color.White;
            this._2.Location = new System.Drawing.Point(-1, 81);
            this._2.Name = "_2";
            this._2.Padding = new System.Windows.Forms.Padding(10);
            this._2.Size = new System.Drawing.Size(158, 45);
            this._2.TabIndex = 7;
            this._2.Text = "2. Coppying...";
            // 
            // _1
            // 
            this._1.AutoSize = true;
            this._1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._1.ForeColor = System.Drawing.Color.White;
            this._1.Location = new System.Drawing.Point(-1, 36);
            this._1.Name = "_1";
            this._1.Padding = new System.Windows.Forms.Padding(10);
            this._1.Size = new System.Drawing.Size(163, 45);
            this._1.TabIndex = 6;
            this._1.Text = "1. Extracting...";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.panel4.Controls.Add(this.bunifuCustomLabel2);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel4.Location = new System.Drawing.Point(0, -20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(160, 53);
            this.panel4.TabIndex = 0;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(51, 23);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(57, 25);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "STEP";
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 40;
            this.bunifuElipse3.TargetControl = this.panel4;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(210, 64);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(181, 21);
            this.bunifuCustomLabel7.TabIndex = 4;
            this.bunifuCustomLabel7.Text = "Select your install local";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(166, 52);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // localX
            // 
            this.localX.BorderColor = System.Drawing.Color.SeaGreen;
            this.localX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.localX.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.localX.Location = new System.Drawing.Point(168, 91);
            this.localX.Name = "localX";
            this.localX.Size = new System.Drawing.Size(273, 26);
            this.localX.TabIndex = 6;
            // 
            // install
            // 
            this.install.Cursor = System.Windows.Forms.Cursors.Hand;
            this.install.Location = new System.Drawing.Point(447, 91);
            this.install.Name = "install";
            this.install.Size = new System.Drawing.Size(78, 26);
            this.install.TabIndex = 7;
            this.install.Text = "INSTALL";
            this.install.UseVisualStyleBackColor = true;
            this.install.Click += new System.EventHandler(this.install_Click);
            // 
            // progress
            // 
            this.progress.BackColor = System.Drawing.Color.Silver;
            this.progress.BorderRadius = 5;
            this.progress.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.progress.Location = new System.Drawing.Point(168, 123);
            this.progress.MaximumValue = 100;
            this.progress.Name = "progress";
            this.progress.ProgressColor = System.Drawing.Color.Teal;
            this.progress.Size = new System.Drawing.Size(357, 30);
            this.progress.TabIndex = 8;
            this.progress.Value = 0;
            // 
            // statusbox
            // 
            this.statusbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.statusbox.Location = new System.Drawing.Point(168, 159);
            this.statusbox.Multiline = true;
            this.statusbox.Name = "statusbox";
            this.statusbox.ReadOnly = true;
            this.statusbox.Size = new System.Drawing.Size(357, 168);
            this.statusbox.TabIndex = 9;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelx;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Change
            // 
            this.Change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Change.Location = new System.Drawing.Point(389, 59);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(52, 26);
            this.Change.TabIndex = 10;
            this.Change.Text = "Change";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = global::Install.Properties.Resources.NUL_LOGO_SMALL;
            this.pictureBox1.Location = new System.Drawing.Point(473, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // InstallGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 339);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.statusbox);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.install);
            this.Controls.Add(this.localX);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelx);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InstallGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InstallGUI_FormClosed);
            this.Load += new System.EventHandler(this.InstallGUI_Load);
            this.panelx.ResumeLayout(false);
            this.panelx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeWD)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelx;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuImageButton closeWD;
        private Bunifu.Framework.UI.BunifuCustomLabel _4;
        private Bunifu.Framework.UI.BunifuCustomLabel _3;
        private Bunifu.Framework.UI.BunifuCustomLabel _2;
        private Bunifu.Framework.UI.BunifuCustomLabel _1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.Button install;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox localX;
        private Bunifu.Framework.UI.BunifuProgressBar progress;
        private System.Windows.Forms.TextBox statusbox;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

