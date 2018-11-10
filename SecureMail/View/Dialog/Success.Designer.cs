#pragma warning disable CS0108,CS1030, CS0219
namespace SecureMail.Dialog
{
    partial class Success
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
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Success));
            this.Left = new System.Windows.Forms.Panel();
            this.Right = new System.Windows.Forms.Panel();
            this.Bottom = new System.Windows.Forms.Panel();
            this.Top = new System.Windows.Forms.Panel();
            this.SuccessRedius = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.success_lb = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.appearance = new BunifuAnimatorNS.BunifuTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Left
            // 
            this.Left.BackColor = System.Drawing.Color.ForestGreen;
            this.appearance.SetDecoration(this.Left, BunifuAnimatorNS.DecorationType.None);
            this.Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.Left.Location = new System.Drawing.Point(0, 0);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(2, 120);
            this.Left.TabIndex = 0;
            // 
            // Right
            // 
            this.Right.BackColor = System.Drawing.Color.ForestGreen;
            this.appearance.SetDecoration(this.Right, BunifuAnimatorNS.DecorationType.None);
            this.Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.Right.Location = new System.Drawing.Point(551, 0);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(3, 120);
            this.Right.TabIndex = 1;
            // 
            // Bottom
            // 
            this.Bottom.BackColor = System.Drawing.Color.ForestGreen;
            this.appearance.SetDecoration(this.Bottom, BunifuAnimatorNS.DecorationType.None);
            this.Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bottom.Location = new System.Drawing.Point(2, 117);
            this.Bottom.Name = "Bottom";
            this.Bottom.Size = new System.Drawing.Size(549, 3);
            this.Bottom.TabIndex = 2;
            // 
            // Top
            // 
            this.Top.BackColor = System.Drawing.Color.ForestGreen;
            this.appearance.SetDecoration(this.Top, BunifuAnimatorNS.DecorationType.None);
            this.Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top.Location = new System.Drawing.Point(2, 0);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(549, 2);
            this.Top.TabIndex = 3;
            // 
            // SuccessRedius
            // 
            this.SuccessRedius.ElipseRadius = 0;
            this.SuccessRedius.TargetControl = this;
            // 
            // success_lb
            // 
            this.appearance.SetDecoration(this.success_lb, BunifuAnimatorNS.DecorationType.None);
            this.success_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.success_lb.ForeColor = System.Drawing.Color.SeaGreen;
            this.success_lb.Location = new System.Drawing.Point(122, 10);
            this.success_lb.Name = "success_lb";
            this.success_lb.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.success_lb.Size = new System.Drawing.Size(423, 100);
            this.success_lb.TabIndex = 5;
            this.success_lb.Text = "Successfully added!";
            this.success_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.appearance.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::SecureMail.Properties.Resources.success;
            this.pictureBox1.Location = new System.Drawing.Point(13, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // appearance
            // 
            this.appearance.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.appearance.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.appearance.DefaultAnimation = animation4;
            this.appearance.TimeStep = 0.008F;
            // 
            // Success
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(554, 120);
            this.Controls.Add(this.success_lb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Top);
            this.Controls.Add(this.Bottom);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Left);
            this.appearance.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Success";
            this.Opacity = 0.7D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Success";
            this.Load += new System.EventHandler(this.Success_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Left;
        private BunifuAnimatorNS.BunifuTransition appearance;
        private System.Windows.Forms.Panel Right;
        private System.Windows.Forms.Panel Bottom;
        private System.Windows.Forms.Panel Top;
        private Bunifu.Framework.UI.BunifuElipse SuccessRedius;
        private Bunifu.Framework.UI.BunifuCustomLabel success_lb;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}