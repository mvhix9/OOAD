namespace Demo.NhanVien
{
    partial class NhanVienFRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVienFRM));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.topPanel = new System.Windows.Forms.Panel();
            this.btnRestore = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMaximize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.menuPanel = new System.Windows.Forms.Panel();
            this.activePanel = new System.Windows.Forms.Panel();
            this.button3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQLNV = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnIndex = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRoleInput = new System.Windows.Forms.Label();
            this.lblNameInput = new System.Windows.Forms.Label();
            this.iconPicture = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(174)))));
            this.topPanel.Controls.Add(this.btnRestore);
            this.topPanel.Controls.Add(this.btnMaximize);
            this.topPanel.Controls.Add(this.btnMinimize);
            this.topPanel.Controls.Add(this.btnClose);
            this.topPanel.Controls.Add(this.lblFormTitle);
            this.bunifuTransition1.SetDecoration(this.topPanel, BunifuAnimatorNS.DecorationType.None);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1247, 54);
            this.topPanel.TabIndex = 1;
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btnRestore, BunifuAnimatorNS.DecorationType.None);
            this.btnRestore.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.Image")));
            this.btnRestore.ImageActive = null;
            this.btnRestore.Location = new System.Drawing.Point(1168, 12);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(30, 30);
            this.btnRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRestore.TabIndex = 5;
            this.btnRestore.TabStop = false;
            this.btnRestore.Visible = false;
            this.btnRestore.Zoom = 10;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btnMaximize, BunifuAnimatorNS.DecorationType.None);
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.ImageActive = null;
            this.btnMaximize.Location = new System.Drawing.Point(1168, 12);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 30);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Zoom = 10;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(1132, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1204, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.lblFormTitle, BunifuAnimatorNS.DecorationType.None);
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(11, 16);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(111, 25);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "NHÂN VIÊN";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.topPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.menuPanel.Controls.Add(this.activePanel);
            this.menuPanel.Controls.Add(this.button3);
            this.menuPanel.Controls.Add(this.button2);
            this.menuPanel.Controls.Add(this.btnQLNV);
            this.menuPanel.Controls.Add(this.btnIndex);
            this.menuPanel.Controls.Add(this.lblRole);
            this.menuPanel.Controls.Add(this.lblName);
            this.menuPanel.Controls.Add(this.lblRoleInput);
            this.menuPanel.Controls.Add(this.lblNameInput);
            this.menuPanel.Controls.Add(this.iconPicture);
            this.menuPanel.Controls.Add(this.btnLogout);
            this.menuPanel.Controls.Add(this.shapeContainer2);
            this.bunifuTransition1.SetDecoration(this.menuPanel, BunifuAnimatorNS.DecorationType.None);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 54);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(240, 733);
            this.menuPanel.TabIndex = 2;
            // 
            // activePanel
            // 
            this.activePanel.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.activePanel, BunifuAnimatorNS.DecorationType.None);
            this.activePanel.Location = new System.Drawing.Point(0, 187);
            this.activePanel.Name = "activePanel";
            this.activePanel.Size = new System.Drawing.Size(10, 81);
            this.activePanel.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(120)))), ((int)(((byte)(177)))));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.BorderRadius = 0;
            this.button3.ButtonText = "BUTTON 3";
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.button3, BunifuAnimatorNS.DecorationType.None);
            this.button3.DisabledColor = System.Drawing.Color.Gray;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.Iconcolor = System.Drawing.Color.Transparent;
            this.button3.Iconimage = null;
            this.button3.Iconimage_right = null;
            this.button3.Iconimage_right_Selected = null;
            this.button3.Iconimage_Selected = null;
            this.button3.IconMarginLeft = 0;
            this.button3.IconMarginRight = 0;
            this.button3.IconRightVisible = true;
            this.button3.IconRightZoom = 0D;
            this.button3.IconVisible = true;
            this.button3.IconZoom = 90D;
            this.button3.IsTab = true;
            this.button3.Location = new System.Drawing.Point(0, 427);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.button3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(120)))), ((int)(((byte)(177)))));
            this.button3.OnHoverTextColor = System.Drawing.Color.White;
            this.button3.selected = false;
            this.button3.Size = new System.Drawing.Size(240, 81);
            this.button3.TabIndex = 1;
            this.button3.TabStop = false;
            this.button3.Text = "BUTTON 3";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button3.Textcolor = System.Drawing.Color.White;
            this.button3.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(120)))), ((int)(((byte)(177)))));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.BorderRadius = 0;
            this.button2.ButtonText = "BUTTON 2";
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.button2.DisabledColor = System.Drawing.Color.Gray;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.Iconcolor = System.Drawing.Color.Transparent;
            this.button2.Iconimage = null;
            this.button2.Iconimage_right = null;
            this.button2.Iconimage_right_Selected = null;
            this.button2.Iconimage_Selected = null;
            this.button2.IconMarginLeft = 0;
            this.button2.IconMarginRight = 0;
            this.button2.IconRightVisible = true;
            this.button2.IconRightZoom = 0D;
            this.button2.IconVisible = true;
            this.button2.IconZoom = 90D;
            this.button2.IsTab = true;
            this.button2.Location = new System.Drawing.Point(0, 347);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.button2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(120)))), ((int)(((byte)(177)))));
            this.button2.OnHoverTextColor = System.Drawing.Color.White;
            this.button2.selected = false;
            this.button2.Size = new System.Drawing.Size(240, 81);
            this.button2.TabIndex = 1;
            this.button2.TabStop = false;
            this.button2.Text = "BUTTON 2";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button2.Textcolor = System.Drawing.Color.White;
            this.button2.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnQLNV
            // 
            this.btnQLNV.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(120)))), ((int)(((byte)(177)))));
            this.btnQLNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.btnQLNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQLNV.BorderRadius = 0;
            this.btnQLNV.ButtonText = "QLNV(Demo)";
            this.btnQLNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnQLNV, BunifuAnimatorNS.DecorationType.None);
            this.btnQLNV.DisabledColor = System.Drawing.Color.Gray;
            this.btnQLNV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLNV.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQLNV.Iconimage = null;
            this.btnQLNV.Iconimage_right = null;
            this.btnQLNV.Iconimage_right_Selected = null;
            this.btnQLNV.Iconimage_Selected = null;
            this.btnQLNV.IconMarginLeft = 0;
            this.btnQLNV.IconMarginRight = 0;
            this.btnQLNV.IconRightVisible = true;
            this.btnQLNV.IconRightZoom = 0D;
            this.btnQLNV.IconVisible = true;
            this.btnQLNV.IconZoom = 90D;
            this.btnQLNV.IsTab = true;
            this.btnQLNV.Location = new System.Drawing.Point(0, 267);
            this.btnQLNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.btnQLNV.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(120)))), ((int)(((byte)(177)))));
            this.btnQLNV.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQLNV.selected = false;
            this.btnQLNV.Size = new System.Drawing.Size(240, 81);
            this.btnQLNV.TabIndex = 12;
            this.btnQLNV.TabStop = false;
            this.btnQLNV.Text = "QLNV(Demo)";
            this.btnQLNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQLNV.Textcolor = System.Drawing.Color.White;
            this.btnQLNV.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLNV.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIndex
            // 
            this.btnIndex.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(120)))), ((int)(((byte)(177)))));
            this.btnIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.btnIndex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIndex.BorderRadius = 0;
            this.btnIndex.ButtonText = "TRANG CHỦ";
            this.btnIndex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnIndex, BunifuAnimatorNS.DecorationType.None);
            this.btnIndex.DisabledColor = System.Drawing.Color.Gray;
            this.btnIndex.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnIndex.Iconcolor = System.Drawing.Color.Transparent;
            this.btnIndex.Iconimage = null;
            this.btnIndex.Iconimage_right = null;
            this.btnIndex.Iconimage_right_Selected = null;
            this.btnIndex.Iconimage_Selected = null;
            this.btnIndex.IconMarginLeft = 0;
            this.btnIndex.IconMarginRight = 0;
            this.btnIndex.IconRightVisible = true;
            this.btnIndex.IconRightZoom = 0D;
            this.btnIndex.IconVisible = true;
            this.btnIndex.IconZoom = 90D;
            this.btnIndex.IsTab = true;
            this.btnIndex.Location = new System.Drawing.Point(0, 187);
            this.btnIndex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.btnIndex.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(120)))), ((int)(((byte)(177)))));
            this.btnIndex.OnHoverTextColor = System.Drawing.Color.White;
            this.btnIndex.selected = false;
            this.btnIndex.Size = new System.Drawing.Size(240, 81);
            this.btnIndex.TabIndex = 0;
            this.btnIndex.TabStop = false;
            this.btnIndex.Text = "TRANG CHỦ";
            this.btnIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIndex.Textcolor = System.Drawing.Color.White;
            this.btnIndex.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnIndex.Click += new System.EventHandler(this.btnIndex_Click);
            // 
            // lblRole
            // 
            this.bunifuTransition1.SetDecoration(this.lblRole, BunifuAnimatorNS.DecorationType.None);
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRole.Location = new System.Drawing.Point(105, 146);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(84, 20);
            this.lblRole.TabIndex = 11;
            this.lblRole.Text = "Tên vai trò";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.bunifuTransition1.SetDecoration(this.lblName, BunifuAnimatorNS.DecorationType.None);
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblName.Location = new System.Drawing.Point(109, 117);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(85, 20);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Họ và tên";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRoleInput
            // 
            this.bunifuTransition1.SetDecoration(this.lblRoleInput, BunifuAnimatorNS.DecorationType.None);
            this.lblRoleInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRoleInput.Location = new System.Drawing.Point(49, 146);
            this.lblRoleInput.Name = "lblRoleInput";
            this.lblRoleInput.Size = new System.Drawing.Size(59, 20);
            this.lblRoleInput.TabIndex = 5;
            this.lblRoleInput.Text = "Vai trò :";
            this.lblRoleInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNameInput
            // 
            this.bunifuTransition1.SetDecoration(this.lblNameInput, BunifuAnimatorNS.DecorationType.None);
            this.lblNameInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNameInput.Location = new System.Drawing.Point(45, 117);
            this.lblNameInput.Name = "lblNameInput";
            this.lblNameInput.Size = new System.Drawing.Size(69, 20);
            this.lblNameInput.TabIndex = 0;
            this.lblNameInput.Text = "Xin chào,";
            this.lblNameInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconPicture
            // 
            this.bunifuTransition1.SetDecoration(this.iconPicture, BunifuAnimatorNS.DecorationType.None);
            this.iconPicture.Image = ((System.Drawing.Image)(resources.GetObject("iconPicture.Image")));
            this.iconPicture.Location = new System.Drawing.Point(69, 8);
            this.iconPicture.Name = "iconPicture";
            this.iconPicture.Size = new System.Drawing.Size(100, 100);
            this.iconPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPicture.TabIndex = 0;
            this.iconPicture.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.bunifuTransition1.SetDecoration(this.btnLogout, BunifuAnimatorNS.DecorationType.None);
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.Location = new System.Drawing.Point(0, 652);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(240, 81);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "THOÁT";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // shapeContainer2
            // 
            this.bunifuTransition1.SetDecoration(this.shapeContainer2, BunifuAnimatorNS.DecorationType.None);
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(240, 733);
            this.shapeContainer2.TabIndex = 7;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.White;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 23;
            this.lineShape1.X2 = 217;
            this.lineShape1.Y1 = 177;
            this.lineShape1.Y2 = 177;
            // 
            // contentPanel
            // 
            this.bunifuTransition1.SetDecoration(this.contentPanel, BunifuAnimatorNS.DecorationType.None);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(240, 54);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1007, 733);
            this.contentPanel.TabIndex = 3;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.bunifuTransition1.Cursor = null;
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
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // NhanVienFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1247, 787);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.topPanel);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhanVienFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.NhanVienFRM_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel topPanel;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Label lblFormTitle;
        private Bunifu.Framework.UI.BunifuImageButton btnRestore;
        private Bunifu.Framework.UI.BunifuImageButton btnMaximize;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.PictureBox iconPicture;
        private System.Windows.Forms.Label lblNameInput;
        private System.Windows.Forms.Label lblRoleInput;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRole;
        private Bunifu.Framework.UI.BunifuFlatButton btnIndex;
        private Bunifu.Framework.UI.BunifuFlatButton button2;
        private Bunifu.Framework.UI.BunifuFlatButton btnQLNV;
        private Bunifu.Framework.UI.BunifuFlatButton button3;
        private System.Windows.Forms.Panel activePanel;
    }
}