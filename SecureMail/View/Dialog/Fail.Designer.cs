#pragma warning disable CS0108,CS1030, CS0219
namespace SecureMail.Dialog
{
    partial class Fail
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fail));
            this.FailRadius = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.success_lb = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Top = new System.Windows.Forms.Panel();
            this.Bottom = new System.Windows.Forms.Panel();
            this.Right = new System.Windows.Forms.Panel();
            this.Left = new System.Windows.Forms.Panel();
            this.appearance = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FailRadius
            // 
            this.FailRadius.ElipseRadius = 0;
            this.FailRadius.TargetControl = this;
            // 
            // success_lb
            // 
            this.success_lb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.appearance.SetDecoration(this.success_lb, BunifuAnimatorNS.DecorationType.None);
            this.success_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.success_lb.ForeColor = System.Drawing.Color.Firebrick;
            this.success_lb.Location = new System.Drawing.Point(126, 7);
            this.success_lb.Name = "success_lb";
            this.success_lb.Size = new System.Drawing.Size(404, 100);
            this.success_lb.TabIndex = 11;
            this.success_lb.Text = "Failure!";
            this.success_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Top
            // 
            this.Top.BackColor = System.Drawing.Color.Maroon;
            this.appearance.SetDecoration(this.Top, BunifuAnimatorNS.DecorationType.None);
            this.Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top.Location = new System.Drawing.Point(4, 0);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(545, 4);
            this.Top.TabIndex = 9;
            // 
            // Bottom
            // 
            this.Bottom.BackColor = System.Drawing.Color.Maroon;
            this.appearance.SetDecoration(this.Bottom, BunifuAnimatorNS.DecorationType.None);
            this.Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bottom.Location = new System.Drawing.Point(4, 116);
            this.Bottom.Name = "Bottom";
            this.Bottom.Size = new System.Drawing.Size(545, 4);
            this.Bottom.TabIndex = 8;
            // 
            // Right
            // 
            this.Right.BackColor = System.Drawing.Color.Maroon;
            this.appearance.SetDecoration(this.Right, BunifuAnimatorNS.DecorationType.None);
            this.Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.Right.Location = new System.Drawing.Point(549, 0);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(5, 120);
            this.Right.TabIndex = 7;
            // 
            // Left
            // 
            this.Left.BackColor = System.Drawing.Color.Maroon;
            this.appearance.SetDecoration(this.Left, BunifuAnimatorNS.DecorationType.None);
            this.Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.Left.Location = new System.Drawing.Point(0, 0);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(4, 120);
            this.Left.TabIndex = 6;
            // 
            // appearance
            // 
            this.appearance.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.appearance.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.appearance.DefaultAnimation = animation1;
            this.appearance.TimeStep = 0.008F;
            // 
            // pictureBox1
            // 
            this.appearance.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::SecureMail.Properties.Resources.Fail;
            this.pictureBox1.Location = new System.Drawing.Point(20, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Fail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(554, 120);
            this.Controls.Add(this.success_lb);
            this.Controls.Add(this.Top);
            this.Controls.Add(this.Bottom);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.pictureBox1);
            this.appearance.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fail";
            this.Opacity = 0.7D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fail";
            this.Load += new System.EventHandler(this.Fail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse FailRadius;
        private Bunifu.Framework.UI.BunifuCustomLabel success_lb;
        private BunifuAnimatorNS.BunifuTransition appearance;
        private System.Windows.Forms.Panel Top;
        private System.Windows.Forms.Panel Bottom;
        private System.Windows.Forms.Panel Right;
        private System.Windows.Forms.Panel Left;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}