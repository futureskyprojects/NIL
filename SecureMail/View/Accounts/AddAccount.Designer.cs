namespace SecureMail.Accounts
{
    partial class AddNew
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNew));
            this.AccountMailAddress = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CircleShapeAvatar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AccountAvatar = new Bunifu.Framework.UI.BunifuImageButton();
            this.Unread = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.UnreadRadius = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.WorkSpaceStartTransiton = new BunifuAnimatorNS.BunifuTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AccountAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountMailAddress
            // 
            this.AccountMailAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AccountMailAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.AccountMailAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WorkSpaceStartTransiton.SetDecoration(this.AccountMailAddress, BunifuAnimatorNS.DecorationType.None);
            this.AccountMailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountMailAddress.ForeColor = System.Drawing.Color.White;
            this.AccountMailAddress.Location = new System.Drawing.Point(0, 130);
            this.AccountMailAddress.Name = "AccountMailAddress";
            this.AccountMailAddress.Size = new System.Drawing.Size(170, 40);
            this.AccountMailAddress.TabIndex = 19;
            this.AccountMailAddress.Text = "Add new account";
            this.AccountMailAddress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AccountMailAddress.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AccountMailAddress_MouseClick);
            this.AccountMailAddress.MouseLeave += new System.EventHandler(this.AccountMailAddress_MouseLeave);
            this.AccountMailAddress.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AccountMailAddress_MouseUp);
            // 
            // CircleShapeAvatar
            // 
            this.CircleShapeAvatar.ElipseRadius = 130;
            this.CircleShapeAvatar.TargetControl = this.AccountAvatar;
            // 
            // AccountAvatar
            // 
            this.AccountAvatar.BackColor = System.Drawing.Color.Silver;
            this.AccountAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WorkSpaceStartTransiton.SetDecoration(this.AccountAvatar, BunifuAnimatorNS.DecorationType.None);
            this.AccountAvatar.Image = global::SecureMail.Properties.Resources.no_avatar;
            this.AccountAvatar.ImageActive = null;
            this.AccountAvatar.Location = new System.Drawing.Point(25, 6);
            this.AccountAvatar.Name = "AccountAvatar";
            this.AccountAvatar.Size = new System.Drawing.Size(120, 120);
            this.AccountAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AccountAvatar.TabIndex = 18;
            this.AccountAvatar.TabStop = false;
            this.AccountAvatar.Tag = "Avatar";
            this.AccountAvatar.Zoom = 10;
            this.AccountAvatar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AccountMailAddress_MouseClick);
            this.AccountAvatar.MouseLeave += new System.EventHandler(this.AccountMailAddress_MouseLeave);
            this.AccountAvatar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AccountMailAddress_MouseUp);
            // 
            // Unread
            // 
            this.Unread.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Unread.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.WorkSpaceStartTransiton.SetDecoration(this.Unread, BunifuAnimatorNS.DecorationType.None);
            this.Unread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unread.ForeColor = System.Drawing.Color.White;
            this.Unread.Location = new System.Drawing.Point(115, 5);
            this.Unread.Name = "Unread";
            this.Unread.Size = new System.Drawing.Size(40, 30);
            this.Unread.TabIndex = 20;
            this.Unread.Text = "1998";
            this.Unread.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Unread.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AccountMailAddress_MouseClick);
            this.Unread.MouseLeave += new System.EventHandler(this.AccountMailAddress_MouseLeave);
            this.Unread.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AccountMailAddress_MouseUp);
            // 
            // UnreadRadius
            // 
            this.UnreadRadius.ElipseRadius = 40;
            this.UnreadRadius.TargetControl = this.Unread;
            // 
            // WorkSpaceStartTransiton
            // 
            this.WorkSpaceStartTransiton.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.WorkSpaceStartTransiton.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0.5F;
            animation1.RotateLimit = 0.2F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.WorkSpaceStartTransiton.DefaultAnimation = animation1;
            // 
            // AddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.Controls.Add(this.Unread);
            this.Controls.Add(this.AccountMailAddress);
            this.Controls.Add(this.AccountAvatar);
            this.WorkSpaceStartTransiton.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "AddNew";
            this.Size = new System.Drawing.Size(170, 170);
            this.Load += new System.EventHandler(this.AddNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AccountAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel AccountMailAddress;
        private Bunifu.Framework.UI.BunifuImageButton AccountAvatar;
        private Bunifu.Framework.UI.BunifuElipse CircleShapeAvatar;
        private Bunifu.Framework.UI.BunifuCustomLabel Unread;
        private Bunifu.Framework.UI.BunifuElipse UnreadRadius;
        private BunifuAnimatorNS.BunifuTransition WorkSpaceStartTransiton;
    }
}
