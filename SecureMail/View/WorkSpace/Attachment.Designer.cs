namespace SecureMail.WorkSpace
{
    partial class Attachment
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
            this.Icon = new System.Windows.Forms.PictureBox();
            this.FileName = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // Icon
            // 
            this.Icon.Image = global::SecureMail.Properties.Resources._004_download_button;
            this.Icon.Location = new System.Drawing.Point(3, 11);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(38, 36);
            this.Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icon.TabIndex = 0;
            this.Icon.TabStop = false;
            this.Icon.Click += new System.EventHandler(this.FileName_Click);
            this.Icon.MouseLeave += new System.EventHandler(this.FileName_MouseLeave);
            this.Icon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FileName_MouseMove);
            // 
            // FileName
            // 
            this.FileName.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileName.ForeColor = System.Drawing.SystemColors.Window;
            this.FileName.Location = new System.Drawing.Point(47, 3);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(120, 52);
            this.FileName.TabIndex = 1;
            this.FileName.Text = "run.html";
            this.FileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FileName.Click += new System.EventHandler(this.FileName_Click);
            this.FileName.MouseLeave += new System.EventHandler(this.FileName_MouseLeave);
            this.FileName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FileName_MouseMove);
            // 
            // Attachment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.Icon);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Attachment";
            this.Size = new System.Drawing.Size(168, 55);
            this.Load += new System.EventHandler(this.Attachment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Icon;
        private Bunifu.Framework.UI.BunifuCustomLabel FileName;
    }
}
