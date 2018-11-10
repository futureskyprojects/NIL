namespace SecureMail.WorkSpace
{
    partial class Record
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Record));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SenderName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SUB = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Subject = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TimeRecived = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Effect = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Important = new Bunifu.Framework.UI.BunifuImageButton();
            this.Starred = new Bunifu.Framework.UI.BunifuImageButton();
            this.Attachment = new Bunifu.Framework.UI.BunifuImageButton();
            this.SenderAvt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Important)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Starred)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attachment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SenderAvt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(176)))), ((int)(((byte)(220)))));
            this.Effect.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 91);
            this.panel1.TabIndex = 0;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShortText_MouseClick);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // SenderName
            // 
            this.SenderName.BackColor = System.Drawing.Color.Transparent;
            this.Effect.SetDecoration(this.SenderName, BunifuAnimatorNS.DecorationType.None);
            this.SenderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SenderName.Location = new System.Drawing.Point(45, 5);
            this.SenderName.Name = "SenderName";
            this.SenderName.Size = new System.Drawing.Size(176, 30);
            this.SenderName.TabIndex = 2;
            this.SenderName.Text = "TNshield Nghĩa";
            this.SenderName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SenderName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShortText_MouseClick);
            this.SenderName.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.SenderName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // SUB
            // 
            this.SUB.AutoSize = true;
            this.SUB.BackColor = System.Drawing.Color.Transparent;
            this.Effect.SetDecoration(this.SUB, BunifuAnimatorNS.DecorationType.None);
            this.SUB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUB.Location = new System.Drawing.Point(7, 38);
            this.SUB.Name = "SUB";
            this.SUB.Size = new System.Drawing.Size(56, 16);
            this.SUB.TabIndex = 3;
            this.SUB.Text = "Subject:";
            this.SUB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShortText_MouseClick);
            this.SUB.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.SUB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Subject
            // 
            this.Subject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Subject.BackColor = System.Drawing.Color.Transparent;
            this.Effect.SetDecoration(this.Subject, BunifuAnimatorNS.DecorationType.None);
            this.Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject.Location = new System.Drawing.Point(63, 38);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(183, 46);
            this.Subject.TabIndex = 5;
            this.Subject.Text = "Google Anoucement";
            this.Subject.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShortText_MouseClick);
            this.Subject.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.Subject.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // TimeRecived
            // 
            this.TimeRecived.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimeRecived.BackColor = System.Drawing.Color.Transparent;
            this.Effect.SetDecoration(this.TimeRecived, BunifuAnimatorNS.DecorationType.None);
            this.TimeRecived.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeRecived.Location = new System.Drawing.Point(211, 0);
            this.TimeRecived.Name = "TimeRecived";
            this.TimeRecived.Size = new System.Drawing.Size(66, 17);
            this.TimeRecived.TabIndex = 6;
            this.TimeRecived.Text = "2:14 AM";
            this.TimeRecived.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.TimeRecived.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShortText_MouseClick);
            this.TimeRecived.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.TimeRecived.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.Effect.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 1);
            this.panel2.TabIndex = 7;
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShortText_MouseClick);
            this.panel2.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Effect
            // 
            this.Effect.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.Effect.Cursor = null;
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
            this.Effect.DefaultAnimation = animation1;
            // 
            // Important
            // 
            this.Important.BackColor = System.Drawing.Color.Transparent;
            this.Effect.SetDecoration(this.Important, BunifuAnimatorNS.DecorationType.None);
            this.Important.Image = global::SecureMail.Properties.Resources.important_icon;
            this.Important.ImageActive = null;
            this.Important.Location = new System.Drawing.Point(252, 55);
            this.Important.Name = "Important";
            this.Important.Size = new System.Drawing.Size(25, 25);
            this.Important.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Important.TabIndex = 10;
            this.Important.TabStop = false;
            this.Important.Zoom = 10;
            this.Important.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShortText_MouseClick);
            this.Important.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.Important.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Starred
            // 
            this.Starred.BackColor = System.Drawing.Color.Transparent;
            this.Effect.SetDecoration(this.Starred, BunifuAnimatorNS.DecorationType.None);
            this.Starred.Image = global::SecureMail.Properties.Resources.star;
            this.Starred.ImageActive = null;
            this.Starred.Location = new System.Drawing.Point(252, 24);
            this.Starred.Name = "Starred";
            this.Starred.Size = new System.Drawing.Size(25, 25);
            this.Starred.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Starred.TabIndex = 9;
            this.Starred.TabStop = false;
            this.Starred.Zoom = 10;
            this.Starred.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShortText_MouseClick);
            this.Starred.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.Starred.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Attachment
            // 
            this.Attachment.BackColor = System.Drawing.Color.Transparent;
            this.Effect.SetDecoration(this.Attachment, BunifuAnimatorNS.DecorationType.None);
            this.Attachment.Image = global::SecureMail.Properties.Resources.attachments;
            this.Attachment.ImageActive = null;
            this.Attachment.Location = new System.Drawing.Point(11, 59);
            this.Attachment.Name = "Attachment";
            this.Attachment.Size = new System.Drawing.Size(25, 25);
            this.Attachment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Attachment.TabIndex = 8;
            this.Attachment.TabStop = false;
            this.Attachment.Zoom = 10;
            this.Attachment.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShortText_MouseClick);
            this.Attachment.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.Attachment.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // SenderAvt
            // 
            this.SenderAvt.BackColor = System.Drawing.Color.Transparent;
            this.Effect.SetDecoration(this.SenderAvt, BunifuAnimatorNS.DecorationType.None);
            this.SenderAvt.Image = global::SecureMail.Properties.Resources.add_user;
            this.SenderAvt.Location = new System.Drawing.Point(11, 5);
            this.SenderAvt.Name = "SenderAvt";
            this.SenderAvt.Size = new System.Drawing.Size(30, 30);
            this.SenderAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SenderAvt.TabIndex = 1;
            this.SenderAvt.TabStop = false;
            this.SenderAvt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShortText_MouseClick);
            this.SenderAvt.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.SenderAvt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.Important);
            this.Controls.Add(this.Starred);
            this.Controls.Add(this.Attachment);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TimeRecived);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.SUB);
            this.Controls.Add(this.SenderName);
            this.Controls.Add(this.SenderAvt);
            this.Controls.Add(this.panel1);
            this.Effect.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Record";
            this.Size = new System.Drawing.Size(280, 91);
            this.Load += new System.EventHandler(this.Record_Load);
            this.TabIndexChanged += new System.EventHandler(this.Record_TabIndexChanged);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ShortText_MouseClick);
            this.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Important)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Starred)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attachment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SenderAvt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox SenderAvt;
        private Bunifu.Framework.UI.BunifuCustomLabel SenderName;
        private Bunifu.Framework.UI.BunifuCustomLabel SUB;
        private Bunifu.Framework.UI.BunifuCustomLabel Subject;
        private Bunifu.Framework.UI.BunifuCustomLabel TimeRecived;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton Attachment;
        private Bunifu.Framework.UI.BunifuImageButton Starred;
        private Bunifu.Framework.UI.BunifuImageButton Important;
        private BunifuAnimatorNS.BunifuTransition Effect;
    }
}
