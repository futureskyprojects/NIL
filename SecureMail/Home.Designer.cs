namespace SecureMail
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.Home = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Leftbar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.BT_Shutdown = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BT_Support = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BT_Options = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BT_SavedEmail = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BT_Accounts = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ApplicationName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BT_Minimun = new Bunifu.Framework.UI.BunifuImageButton();
            this.BT_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.DragHome = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TransitionWhenStartPanel = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.AccountListShow = new SecureMail.AccountsList();
            this.ShutdownShow = new SecureMail.Shutdown.Shutdown();
            this.SuportShow = new SecureMail.Support.Support();
            this.OptionsShow = new SecureMail.Options.Options();
            this.SavedMailsShow = new SecureMail.Saved.Saved();
            this.Leftbar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BT_Minimun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BT_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.ElipseRadius = 5;
            this.Home.TargetControl = this;
            // 
            // Leftbar
            // 
            this.Leftbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(59)))));
            this.Leftbar.Controls.Add(this.panel1);
            this.Leftbar.Controls.Add(this.BT_Shutdown);
            this.Leftbar.Controls.Add(this.BT_Support);
            this.Leftbar.Controls.Add(this.BT_Options);
            this.Leftbar.Controls.Add(this.BT_SavedEmail);
            this.Leftbar.Controls.Add(this.BT_Accounts);
            this.TransitionWhenStartPanel.SetDecoration(this.Leftbar, BunifuAnimatorNS.DecorationType.None);
            this.Leftbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Leftbar.Location = new System.Drawing.Point(0, 44);
            this.Leftbar.Name = "Leftbar";
            this.Leftbar.Size = new System.Drawing.Size(250, 556);
            this.Leftbar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.Logo);
            this.TransitionWhenStartPanel.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 162);
            this.panel1.TabIndex = 6;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Silver;
            this.TransitionWhenStartPanel.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.Logo.Image = global::SecureMail.Properties.Resources.NUL_LOGO;
            this.Logo.Location = new System.Drawing.Point(0, 45);
            this.Logo.Name = "Logo";
            this.Logo.Padding = new System.Windows.Forms.Padding(10);
            this.Logo.Size = new System.Drawing.Size(250, 76);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // BT_Shutdown
            // 
            this.BT_Shutdown.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(163)))), ((int)(((byte)(167)))));
            this.BT_Shutdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(59)))));
            this.BT_Shutdown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_Shutdown.BorderRadius = 0;
            this.BT_Shutdown.ButtonText = "       SHUTDOWN";
            this.BT_Shutdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransitionWhenStartPanel.SetDecoration(this.BT_Shutdown, BunifuAnimatorNS.DecorationType.None);
            this.BT_Shutdown.DisabledColor = System.Drawing.Color.Gray;
            this.BT_Shutdown.Iconcolor = System.Drawing.Color.Transparent;
            this.BT_Shutdown.Iconimage = global::SecureMail.Properties.Resources._001_shutdown;
            this.BT_Shutdown.Iconimage_right = null;
            this.BT_Shutdown.Iconimage_right_Selected = null;
            this.BT_Shutdown.Iconimage_Selected = null;
            this.BT_Shutdown.IconMarginLeft = 0;
            this.BT_Shutdown.IconMarginRight = 0;
            this.BT_Shutdown.IconRightVisible = true;
            this.BT_Shutdown.IconRightZoom = 0D;
            this.BT_Shutdown.IconVisible = true;
            this.BT_Shutdown.IconZoom = 40D;
            this.BT_Shutdown.IsTab = true;
            this.BT_Shutdown.Location = new System.Drawing.Point(0, 377);
            this.BT_Shutdown.Name = "BT_Shutdown";
            this.BT_Shutdown.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(59)))));
            this.BT_Shutdown.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.BT_Shutdown.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.BT_Shutdown.selected = false;
            this.BT_Shutdown.Size = new System.Drawing.Size(250, 48);
            this.BT_Shutdown.TabIndex = 5;
            this.BT_Shutdown.Text = "       SHUTDOWN";
            this.BT_Shutdown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Shutdown.Textcolor = System.Drawing.Color.White;
            this.BT_Shutdown.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Shutdown.Click += new System.EventHandler(this.BT_Shutdown_Click);
            // 
            // BT_Support
            // 
            this.BT_Support.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(163)))), ((int)(((byte)(167)))));
            this.BT_Support.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(59)))));
            this.BT_Support.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_Support.BorderRadius = 0;
            this.BT_Support.ButtonText = "       SUPPORT";
            this.BT_Support.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransitionWhenStartPanel.SetDecoration(this.BT_Support, BunifuAnimatorNS.DecorationType.None);
            this.BT_Support.DisabledColor = System.Drawing.Color.Gray;
            this.BT_Support.Iconcolor = System.Drawing.Color.Transparent;
            this.BT_Support.Iconimage = global::SecureMail.Properties.Resources._002_customer_service;
            this.BT_Support.Iconimage_right = null;
            this.BT_Support.Iconimage_right_Selected = null;
            this.BT_Support.Iconimage_Selected = null;
            this.BT_Support.IconMarginLeft = 0;
            this.BT_Support.IconMarginRight = 0;
            this.BT_Support.IconRightVisible = true;
            this.BT_Support.IconRightZoom = 0D;
            this.BT_Support.IconVisible = true;
            this.BT_Support.IconZoom = 40D;
            this.BT_Support.IsTab = true;
            this.BT_Support.Location = new System.Drawing.Point(0, 323);
            this.BT_Support.Name = "BT_Support";
            this.BT_Support.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(59)))));
            this.BT_Support.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.BT_Support.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.BT_Support.selected = false;
            this.BT_Support.Size = new System.Drawing.Size(250, 48);
            this.BT_Support.TabIndex = 4;
            this.BT_Support.Text = "       SUPPORT";
            this.BT_Support.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Support.Textcolor = System.Drawing.Color.White;
            this.BT_Support.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Support.Click += new System.EventHandler(this.BT_Support_Click);
            // 
            // BT_Options
            // 
            this.BT_Options.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(163)))), ((int)(((byte)(167)))));
            this.BT_Options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(59)))));
            this.BT_Options.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_Options.BorderRadius = 0;
            this.BT_Options.ButtonText = "       OPTIONS";
            this.BT_Options.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransitionWhenStartPanel.SetDecoration(this.BT_Options, BunifuAnimatorNS.DecorationType.None);
            this.BT_Options.DisabledColor = System.Drawing.Color.Gray;
            this.BT_Options.Iconcolor = System.Drawing.Color.Transparent;
            this.BT_Options.Iconimage = global::SecureMail.Properties.Resources._003_settings_work_tool;
            this.BT_Options.Iconimage_right = null;
            this.BT_Options.Iconimage_right_Selected = null;
            this.BT_Options.Iconimage_Selected = null;
            this.BT_Options.IconMarginLeft = 0;
            this.BT_Options.IconMarginRight = 0;
            this.BT_Options.IconRightVisible = true;
            this.BT_Options.IconRightZoom = 0D;
            this.BT_Options.IconVisible = true;
            this.BT_Options.IconZoom = 40D;
            this.BT_Options.IsTab = true;
            this.BT_Options.Location = new System.Drawing.Point(0, 269);
            this.BT_Options.Name = "BT_Options";
            this.BT_Options.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(59)))));
            this.BT_Options.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.BT_Options.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.BT_Options.selected = false;
            this.BT_Options.Size = new System.Drawing.Size(250, 48);
            this.BT_Options.TabIndex = 3;
            this.BT_Options.Text = "       OPTIONS";
            this.BT_Options.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Options.Textcolor = System.Drawing.Color.White;
            this.BT_Options.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Options.Click += new System.EventHandler(this.BT_Options_Click);
            // 
            // BT_SavedEmail
            // 
            this.BT_SavedEmail.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(163)))), ((int)(((byte)(167)))));
            this.BT_SavedEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(59)))));
            this.BT_SavedEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_SavedEmail.BorderRadius = 0;
            this.BT_SavedEmail.ButtonText = "       SAVED MAILS";
            this.BT_SavedEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransitionWhenStartPanel.SetDecoration(this.BT_SavedEmail, BunifuAnimatorNS.DecorationType.None);
            this.BT_SavedEmail.DisabledColor = System.Drawing.Color.Gray;
            this.BT_SavedEmail.Iconcolor = System.Drawing.Color.Transparent;
            this.BT_SavedEmail.Iconimage = global::SecureMail.Properties.Resources._004_download_button;
            this.BT_SavedEmail.Iconimage_right = null;
            this.BT_SavedEmail.Iconimage_right_Selected = null;
            this.BT_SavedEmail.Iconimage_Selected = null;
            this.BT_SavedEmail.IconMarginLeft = 0;
            this.BT_SavedEmail.IconMarginRight = 0;
            this.BT_SavedEmail.IconRightVisible = true;
            this.BT_SavedEmail.IconRightZoom = 0D;
            this.BT_SavedEmail.IconVisible = true;
            this.BT_SavedEmail.IconZoom = 40D;
            this.BT_SavedEmail.IsTab = true;
            this.BT_SavedEmail.Location = new System.Drawing.Point(0, 215);
            this.BT_SavedEmail.Name = "BT_SavedEmail";
            this.BT_SavedEmail.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(59)))));
            this.BT_SavedEmail.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.BT_SavedEmail.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.BT_SavedEmail.selected = false;
            this.BT_SavedEmail.Size = new System.Drawing.Size(250, 48);
            this.BT_SavedEmail.TabIndex = 2;
            this.BT_SavedEmail.Text = "       SAVED MAILS";
            this.BT_SavedEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_SavedEmail.Textcolor = System.Drawing.Color.White;
            this.BT_SavedEmail.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_SavedEmail.Click += new System.EventHandler(this.BT_SavedEmail_Click);
            // 
            // BT_Accounts
            // 
            this.BT_Accounts.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(163)))), ((int)(((byte)(167)))));
            this.BT_Accounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(163)))), ((int)(((byte)(167)))));
            this.BT_Accounts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_Accounts.BorderRadius = 0;
            this.BT_Accounts.ButtonText = "       ACCOUNTS";
            this.BT_Accounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransitionWhenStartPanel.SetDecoration(this.BT_Accounts, BunifuAnimatorNS.DecorationType.None);
            this.BT_Accounts.DisabledColor = System.Drawing.Color.Gray;
            this.BT_Accounts.Iconcolor = System.Drawing.Color.Transparent;
            this.BT_Accounts.Iconimage = global::SecureMail.Properties.Resources._005_user_silhouette;
            this.BT_Accounts.Iconimage_right = null;
            this.BT_Accounts.Iconimage_right_Selected = null;
            this.BT_Accounts.Iconimage_Selected = null;
            this.BT_Accounts.IconMarginLeft = 0;
            this.BT_Accounts.IconMarginRight = 0;
            this.BT_Accounts.IconRightVisible = true;
            this.BT_Accounts.IconRightZoom = 0D;
            this.BT_Accounts.IconVisible = true;
            this.BT_Accounts.IconZoom = 40D;
            this.BT_Accounts.IsTab = true;
            this.BT_Accounts.Location = new System.Drawing.Point(0, 161);
            this.BT_Accounts.Name = "BT_Accounts";
            this.BT_Accounts.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(59)))));
            this.BT_Accounts.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.BT_Accounts.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.BT_Accounts.selected = true;
            this.BT_Accounts.Size = new System.Drawing.Size(250, 48);
            this.BT_Accounts.TabIndex = 1;
            this.BT_Accounts.Text = "       ACCOUNTS";
            this.BT_Accounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Accounts.Textcolor = System.Drawing.Color.White;
            this.BT_Accounts.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Accounts.Click += new System.EventHandler(this.BT_Accounts_Click);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(168)))), ((int)(((byte)(165)))));
            this.Header.Controls.Add(this.pictureBox1);
            this.Header.Controls.Add(this.ApplicationName);
            this.Header.Controls.Add(this.BT_Minimun);
            this.Header.Controls.Add(this.BT_Close);
            this.TransitionWhenStartPanel.SetDecoration(this.Header, BunifuAnimatorNS.DecorationType.None);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(900, 44);
            this.Header.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.TransitionWhenStartPanel.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::SecureMail.Properties.Resources.NUL_LOGO_SMALL;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ApplicationName
            // 
            this.ApplicationName.AutoSize = true;
            this.TransitionWhenStartPanel.SetDecoration(this.ApplicationName, BunifuAnimatorNS.DecorationType.None);
            this.ApplicationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationName.ForeColor = System.Drawing.Color.White;
            this.ApplicationName.Location = new System.Drawing.Point(48, 12);
            this.ApplicationName.Name = "ApplicationName";
            this.ApplicationName.Size = new System.Drawing.Size(217, 25);
            this.ApplicationName.TabIndex = 3;
            this.ApplicationName.Text = "Secure Mail (Beta v4.0)";
            // 
            // BT_Minimun
            // 
            this.BT_Minimun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(168)))), ((int)(((byte)(165)))));
            this.TransitionWhenStartPanel.SetDecoration(this.BT_Minimun, BunifuAnimatorNS.DecorationType.None);
            this.BT_Minimun.Image = global::SecureMail.Properties.Resources._004_download_button1;
            this.BT_Minimun.ImageActive = null;
            this.BT_Minimun.Location = new System.Drawing.Point(842, 12);
            this.BT_Minimun.Name = "BT_Minimun";
            this.BT_Minimun.Size = new System.Drawing.Size(20, 20);
            this.BT_Minimun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BT_Minimun.TabIndex = 2;
            this.BT_Minimun.TabStop = false;
            this.BT_Minimun.Zoom = 10;
            this.BT_Minimun.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // BT_Close
            // 
            this.BT_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(168)))), ((int)(((byte)(165)))));
            this.TransitionWhenStartPanel.SetDecoration(this.BT_Close, BunifuAnimatorNS.DecorationType.None);
            this.BT_Close.Image = global::SecureMail.Properties.Resources._012_cancel;
            this.BT_Close.ImageActive = null;
            this.BT_Close.Location = new System.Drawing.Point(868, 12);
            this.BT_Close.Name = "BT_Close";
            this.BT_Close.Size = new System.Drawing.Size(20, 20);
            this.BT_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BT_Close.TabIndex = 1;
            this.BT_Close.TabStop = false;
            this.BT_Close.Zoom = 10;
            this.BT_Close.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // DragHome
            // 
            this.DragHome.Fixed = true;
            this.DragHome.Horizontal = true;
            this.DragHome.TargetControl = this.Header;
            this.DragHome.Vertical = true;
            // 
            // TransitionWhenStartPanel
            // 
            this.TransitionWhenStartPanel.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.TransitionWhenStartPanel.Cursor = null;
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
            this.TransitionWhenStartPanel.DefaultAnimation = animation1;
            this.TransitionWhenStartPanel.TimeStep = 0.0074F;
            // 
            // AccountListShow
            // 
            this.AccountListShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.TransitionWhenStartPanel.SetDecoration(this.AccountListShow, BunifuAnimatorNS.DecorationType.None);
            this.AccountListShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountListShow.Location = new System.Drawing.Point(250, 44);
            this.AccountListShow.Name = "AccountListShow";
            this.AccountListShow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AccountListShow.Size = new System.Drawing.Size(650, 556);
            this.AccountListShow.TabIndex = 2;
            // 
            // ShutdownShow
            // 
            this.ShutdownShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.TransitionWhenStartPanel.SetDecoration(this.ShutdownShow, BunifuAnimatorNS.DecorationType.None);
            this.ShutdownShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShutdownShow.Location = new System.Drawing.Point(0, 0);
            this.ShutdownShow.Name = "ShutdownShow";
            this.ShutdownShow.Size = new System.Drawing.Size(900, 600);
            this.ShutdownShow.TabIndex = 6;
            // 
            // SuportShow
            // 
            this.SuportShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.TransitionWhenStartPanel.SetDecoration(this.SuportShow, BunifuAnimatorNS.DecorationType.None);
            this.SuportShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SuportShow.Location = new System.Drawing.Point(0, 0);
            this.SuportShow.Name = "SuportShow";
            this.SuportShow.Size = new System.Drawing.Size(900, 600);
            this.SuportShow.TabIndex = 5;
            // 
            // OptionsShow
            // 
            this.OptionsShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.TransitionWhenStartPanel.SetDecoration(this.OptionsShow, BunifuAnimatorNS.DecorationType.None);
            this.OptionsShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OptionsShow.Location = new System.Drawing.Point(0, 0);
            this.OptionsShow.Name = "OptionsShow";
            this.OptionsShow.Size = new System.Drawing.Size(900, 600);
            this.OptionsShow.TabIndex = 4;
            // 
            // SavedMailsShow
            // 
            this.SavedMailsShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.TransitionWhenStartPanel.SetDecoration(this.SavedMailsShow, BunifuAnimatorNS.DecorationType.None);
            this.SavedMailsShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SavedMailsShow.Location = new System.Drawing.Point(0, 0);
            this.SavedMailsShow.Name = "SavedMailsShow";
            this.SavedMailsShow.Size = new System.Drawing.Size(900, 600);
            this.SavedMailsShow.TabIndex = 3;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.AccountListShow);
            this.Controls.Add(this.Leftbar);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.ShutdownShow);
            this.Controls.Add(this.SuportShow);
            this.Controls.Add(this.OptionsShow);
            this.Controls.Add(this.SavedMailsShow);
            this.TransitionWhenStartPanel.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomePage_FormClosing);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.Leftbar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BT_Minimun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BT_Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Home;
        private System.Windows.Forms.Panel Leftbar;
        private System.Windows.Forms.Panel Header;
        private Bunifu.Framework.UI.BunifuFlatButton BT_Accounts;
        private Bunifu.Framework.UI.BunifuFlatButton BT_SavedEmail;
        private Bunifu.Framework.UI.BunifuFlatButton BT_Options;
        private Bunifu.Framework.UI.BunifuFlatButton BT_Support;
        private Bunifu.Framework.UI.BunifuFlatButton BT_Shutdown;
        private Bunifu.Framework.UI.BunifuImageButton BT_Close;
        private Bunifu.Framework.UI.BunifuImageButton BT_Minimun;
        private Bunifu.Framework.UI.BunifuDragControl DragHome;
        private Bunifu.Framework.UI.BunifuCustomLabel ApplicationName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AccountsList AccountListShow;
        private Saved.Saved SavedMailsShow;
        private Options.Options OptionsShow;
        private Shutdown.Shutdown ShutdownShow;
        private Support.Support SuportShow;
        private BunifuAnimatorNS.BunifuTransition TransitionWhenStartPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Logo;
    }
}

