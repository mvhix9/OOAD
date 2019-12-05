namespace uiBacSi
{
    partial class BacSiFRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BacSiFRM));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.topPanel = new System.Windows.Forms.Panel();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.menuPanel = new System.Windows.Forms.Panel();
            this.activePanel = new System.Windows.Forms.Panel();
            this.btnLapDonThuoc = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLapPhieuKham = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTuyChon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnIndex = new Bunifu.Framework.UI.BunifuFlatButton();
            lblName = new System.Windows.Forms.Label();
            this.lblNameInput = new System.Windows.Forms.Label();
            this.iconPicture = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.topPanel.SuspendLayout();
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
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(1168, 12);
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
            this.lblFormTitle.Size = new System.Drawing.Size(67, 25);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "BÁC SĨ";
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
            this.menuPanel.Controls.Add(this.btnLapDonThuoc);
            this.menuPanel.Controls.Add(this.btnLapPhieuKham);
            this.menuPanel.Controls.Add(this.btnTuyChon);
            this.menuPanel.Controls.Add(this.btnIndex);
            this.menuPanel.Controls.Add(lblName);
            this.menuPanel.Controls.Add(this.lblNameInput);
            this.menuPanel.Controls.Add(this.iconPicture);
            this.menuPanel.Controls.Add(this.btnLogout);
            this.bunifuTransition1.SetDecoration(this.menuPanel, BunifuAnimatorNS.DecorationType.None);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 54);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(240, 823);
            this.menuPanel.TabIndex = 2;
            // 
            // activePanel
            // 
            this.activePanel.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.activePanel, BunifuAnimatorNS.DecorationType.None);
            this.activePanel.Location = new System.Drawing.Point(0, 207);
            this.activePanel.Name = "activePanel";
            this.activePanel.Size = new System.Drawing.Size(10, 81);
            this.activePanel.TabIndex = 0;
            // 
            // btnLapDonThuoc
            // 
            this.btnLapDonThuoc.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(120)))), ((int)(((byte)(177)))));
            this.btnLapDonThuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLapDonThuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.btnLapDonThuoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLapDonThuoc.BorderRadius = 0;
            this.btnLapDonThuoc.ButtonText = "LẬP ĐƠN THUỐC";
            this.btnLapDonThuoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnLapDonThuoc, BunifuAnimatorNS.DecorationType.None);
            this.btnLapDonThuoc.DisabledColor = System.Drawing.Color.Gray;
            this.btnLapDonThuoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLapDonThuoc.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLapDonThuoc.Iconimage = null;
            this.btnLapDonThuoc.Iconimage_right = null;
            this.btnLapDonThuoc.Iconimage_right_Selected = null;
            this.btnLapDonThuoc.Iconimage_Selected = null;
            this.btnLapDonThuoc.IconMarginLeft = 0;
            this.btnLapDonThuoc.IconMarginRight = 0;
            this.btnLapDonThuoc.IconRightVisible = true;
            this.btnLapDonThuoc.IconRightZoom = 0D;
            this.btnLapDonThuoc.IconVisible = true;
            this.btnLapDonThuoc.IconZoom = 90D;
            this.btnLapDonThuoc.IsTab = true;
            this.btnLapDonThuoc.Location = new System.Drawing.Point(0, 363);
            this.btnLapDonThuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLapDonThuoc.Name = "btnLapDonThuoc";
            this.btnLapDonThuoc.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.btnLapDonThuoc.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(120)))), ((int)(((byte)(177)))));
            this.btnLapDonThuoc.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLapDonThuoc.selected = false;
            this.btnLapDonThuoc.Size = new System.Drawing.Size(240, 81);
            this.btnLapDonThuoc.TabIndex = 15;
            this.btnLapDonThuoc.TabStop = false;
            this.btnLapDonThuoc.Text = "LẬP ĐƠN THUỐC";
            this.btnLapDonThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLapDonThuoc.Textcolor = System.Drawing.Color.White;
            this.btnLapDonThuoc.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLapDonThuoc.Click += new System.EventHandler(this.btnLapDonThuoc_Click);
            // 
            // btnLapPhieuKham
            // 
            this.btnLapPhieuKham.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(120)))), ((int)(((byte)(177)))));
            this.btnLapPhieuKham.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLapPhieuKham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.btnLapPhieuKham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLapPhieuKham.BorderRadius = 0;
            this.btnLapPhieuKham.ButtonText = "LẬP PHIẾU KHÁM";
            this.btnLapPhieuKham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnLapPhieuKham, BunifuAnimatorNS.DecorationType.None);
            this.btnLapPhieuKham.DisabledColor = System.Drawing.Color.Gray;
            this.btnLapPhieuKham.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLapPhieuKham.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLapPhieuKham.Iconimage = null;
            this.btnLapPhieuKham.Iconimage_right = null;
            this.btnLapPhieuKham.Iconimage_right_Selected = null;
            this.btnLapPhieuKham.Iconimage_Selected = null;
            this.btnLapPhieuKham.IconMarginLeft = 0;
            this.btnLapPhieuKham.IconMarginRight = 0;
            this.btnLapPhieuKham.IconRightVisible = true;
            this.btnLapPhieuKham.IconRightZoom = 0D;
            this.btnLapPhieuKham.IconVisible = true;
            this.btnLapPhieuKham.IconZoom = 90D;
            this.btnLapPhieuKham.IsTab = true;
            this.btnLapPhieuKham.Location = new System.Drawing.Point(0, 285);
            this.btnLapPhieuKham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLapPhieuKham.Name = "btnLapPhieuKham";
            this.btnLapPhieuKham.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.btnLapPhieuKham.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(120)))), ((int)(((byte)(177)))));
            this.btnLapPhieuKham.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLapPhieuKham.selected = false;
            this.btnLapPhieuKham.Size = new System.Drawing.Size(240, 81);
            this.btnLapPhieuKham.TabIndex = 14;
            this.btnLapPhieuKham.TabStop = false;
            this.btnLapPhieuKham.Text = "LẬP PHIẾU KHÁM";
            this.btnLapPhieuKham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLapPhieuKham.Textcolor = System.Drawing.Color.White;
            this.btnLapPhieuKham.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLapPhieuKham.Click += new System.EventHandler(this.btnLapPhieuKham_Click);
            // 
            // btnTuyChon
            // 
            this.btnTuyChon.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(120)))), ((int)(((byte)(177)))));
            this.btnTuyChon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTuyChon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.btnTuyChon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTuyChon.BorderRadius = 0;
            this.btnTuyChon.ButtonText = "TUỲ CHỌN";
            this.btnTuyChon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnTuyChon, BunifuAnimatorNS.DecorationType.None);
            this.btnTuyChon.DisabledColor = System.Drawing.Color.Gray;
            this.btnTuyChon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTuyChon.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTuyChon.Iconimage = null;
            this.btnTuyChon.Iconimage_right = null;
            this.btnTuyChon.Iconimage_right_Selected = null;
            this.btnTuyChon.Iconimage_Selected = null;
            this.btnTuyChon.IconMarginLeft = 0;
            this.btnTuyChon.IconMarginRight = 0;
            this.btnTuyChon.IconRightVisible = true;
            this.btnTuyChon.IconRightZoom = 0D;
            this.btnTuyChon.IconVisible = true;
            this.btnTuyChon.IconZoom = 90D;
            this.btnTuyChon.IsTab = true;
            this.btnTuyChon.Location = new System.Drawing.Point(0, 441);
            this.btnTuyChon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTuyChon.Name = "btnTuyChon";
            this.btnTuyChon.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.btnTuyChon.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(120)))), ((int)(((byte)(177)))));
            this.btnTuyChon.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTuyChon.selected = false;
            this.btnTuyChon.Size = new System.Drawing.Size(240, 81);
            this.btnTuyChon.TabIndex = 13;
            this.btnTuyChon.TabStop = false;
            this.btnTuyChon.Text = "TUỲ CHỌN";
            this.btnTuyChon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTuyChon.Textcolor = System.Drawing.Color.White;
            this.btnTuyChon.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTuyChon.Click += new System.EventHandler(this.btnTuyChon_Click);
            // 
            // btnIndex
            // 
            this.btnIndex.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(120)))), ((int)(((byte)(177)))));
            this.btnIndex.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.btnIndex.Location = new System.Drawing.Point(0, 207);
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
            // lblName
            // 
            lblName.AutoSize = true;
            this.bunifuTransition1.SetDecoration(lblName, BunifuAnimatorNS.DecorationType.None);
            lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            lblName.Location = new System.Drawing.Point(82, 146);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(76, 20);
            lblName.TabIndex = 10;
            lblName.Text = "Họ và tên";
            lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNameInput
            // 
            this.lblNameInput.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblNameInput, BunifuAnimatorNS.DecorationType.None);
            this.lblNameInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNameInput.Location = new System.Drawing.Point(86, 117);
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
            this.btnLogout.Location = new System.Drawing.Point(0, 742);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(240, 81);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "THOÁT";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // contentPanel
            // 
            this.bunifuTransition1.SetDecoration(this.contentPanel, BunifuAnimatorNS.DecorationType.None);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(240, 54);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1007, 823);
            this.contentPanel.TabIndex = 3;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
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
            // BacSiFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1247, 877);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.topPanel);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BacSiFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BacSiFRM_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel topPanel;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Label lblFormTitle;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.PictureBox iconPicture;
        private System.Windows.Forms.Label lblNameInput;
        private Bunifu.Framework.UI.BunifuFlatButton btnIndex;
        private System.Windows.Forms.Panel activePanel;
        private Bunifu.Framework.UI.BunifuFlatButton btnTuyChon;
        private Bunifu.Framework.UI.BunifuFlatButton btnLapDonThuoc;
        private Bunifu.Framework.UI.BunifuFlatButton btnLapPhieuKham;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        public static System.Windows.Forms.Label lblName;
    }
}