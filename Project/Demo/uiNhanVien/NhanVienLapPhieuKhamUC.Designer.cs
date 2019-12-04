namespace Demo.uiNhanVien
{
    partial class NhanVienLapPhieuKhamUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.modelPhieuKhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.benhNhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbTenBenhNhan = new System.Windows.Forms.ComboBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblHoTenBN = new System.Windows.Forms.Label();
            this.lblDiaChiBN = new System.Windows.Forms.Label();
            this.lblGioiTinhBN = new System.Windows.Forms.Label();
            this.lblNgaySinhBN = new System.Windows.Forms.Label();
            this.lblMaBN = new System.Windows.Forms.Label();
            this.dtpNgaySinhBN = new System.Windows.Forms.DateTimePicker();
            this.grpBoxBN = new System.Windows.Forms.GroupBox();
            this.txtMaBacSi = new System.Windows.Forms.TextBox();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbTenBacSi = new System.Windows.Forms.ComboBox();
            this.txtGioiTinhBS = new System.Windows.Forms.TextBox();
            this.dtpNgaySinhBS = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChiBS = new System.Windows.Forms.TextBox();
            this.lblHoTenBS = new System.Windows.Forms.Label();
            this.lblMaBS = new System.Windows.Forms.Label();
            this.lblNgaySinhBS = new System.Windows.Forms.Label();
            this.lblGioiTinhBS = new System.Windows.Forms.Label();
            this.lblDiaChiBS = new System.Windows.Forms.Label();
            this.grpBoxBS = new System.Windows.Forms.GroupBox();
            this.btnThemPhieuKham = new System.Windows.Forms.Button();
            this.btnSuaPhieuKham = new System.Windows.Forms.Button();
            this.dtgvPhieuKham = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.maPhieuKhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lbBoLoc = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.modelPhieuKhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benhNhanBindingSource)).BeginInit();
            this.grpBoxBN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.grpBoxBS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuKham)).BeginInit();
            this.SuspendLayout();
            // 
            // modelPhieuKhamBindingSource
            // 
            this.modelPhieuKhamBindingSource.DataSource = typeof(DTO.Models.ModelPhieuKham);
            // 
            // txtMaBN
            // 
            this.txtMaBN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.benhNhanBindingSource, "MaBenhNhan", true));
            this.txtMaBN.Enabled = false;
            this.txtMaBN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaBN.Location = new System.Drawing.Point(128, 71);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(81, 27);
            this.txtMaBN.TabIndex = 2;
            // 
            // benhNhanBindingSource
            // 
            this.benhNhanBindingSource.DataSource = typeof(DTO.BenhNhan);
            // 
            // cbTenBenhNhan
            // 
            this.cbTenBenhNhan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTenBenhNhan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTenBenhNhan.DataSource = this.benhNhanBindingSource;
            this.cbTenBenhNhan.DisplayMember = "HoTen";
            this.cbTenBenhNhan.DropDownWidth = 150;
            this.cbTenBenhNhan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbTenBenhNhan.FormattingEnabled = true;
            this.cbTenBenhNhan.Location = new System.Drawing.Point(127, 30);
            this.cbTenBenhNhan.Name = "cbTenBenhNhan";
            this.cbTenBenhNhan.Size = new System.Drawing.Size(185, 28);
            this.cbTenBenhNhan.TabIndex = 4;
            this.cbTenBenhNhan.ValueMember = "MaBenhNhan";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.benhNhanBindingSource, "GioiTinh", true));
            this.txtGioiTinh.Enabled = false;
            this.txtGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGioiTinh.Location = new System.Drawing.Point(341, 71);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(75, 27);
            this.txtGioiTinh.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.benhNhanBindingSource, "DiaChi", true));
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiaChi.Location = new System.Drawing.Point(341, 112);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(128, 77);
            this.txtDiaChi.TabIndex = 6;
            // 
            // lblHoTenBN
            // 
            this.lblHoTenBN.AutoSize = true;
            this.lblHoTenBN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHoTenBN.ForeColor = System.Drawing.Color.Black;
            this.lblHoTenBN.Location = new System.Drawing.Point(48, 33);
            this.lblHoTenBN.Name = "lblHoTenBN";
            this.lblHoTenBN.Size = new System.Drawing.Size(73, 20);
            this.lblHoTenBN.TabIndex = 7;
            this.lblHoTenBN.Text = "Họ và tên";
            // 
            // lblDiaChiBN
            // 
            this.lblDiaChiBN.AutoSize = true;
            this.lblDiaChiBN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiaChiBN.ForeColor = System.Drawing.Color.Black;
            this.lblDiaChiBN.Location = new System.Drawing.Point(280, 112);
            this.lblDiaChiBN.Name = "lblDiaChiBN";
            this.lblDiaChiBN.Size = new System.Drawing.Size(55, 20);
            this.lblDiaChiBN.TabIndex = 8;
            this.lblDiaChiBN.Text = "Địa chỉ";
            // 
            // lblGioiTinhBN
            // 
            this.lblGioiTinhBN.AutoSize = true;
            this.lblGioiTinhBN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGioiTinhBN.ForeColor = System.Drawing.Color.Black;
            this.lblGioiTinhBN.Location = new System.Drawing.Point(270, 74);
            this.lblGioiTinhBN.Name = "lblGioiTinhBN";
            this.lblGioiTinhBN.Size = new System.Drawing.Size(65, 20);
            this.lblGioiTinhBN.TabIndex = 9;
            this.lblGioiTinhBN.Text = "Giới tính";
            // 
            // lblNgaySinhBN
            // 
            this.lblNgaySinhBN.AutoSize = true;
            this.lblNgaySinhBN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgaySinhBN.ForeColor = System.Drawing.Color.Black;
            this.lblNgaySinhBN.Location = new System.Drawing.Point(47, 115);
            this.lblNgaySinhBN.Name = "lblNgaySinhBN";
            this.lblNgaySinhBN.Size = new System.Drawing.Size(74, 20);
            this.lblNgaySinhBN.TabIndex = 10;
            this.lblNgaySinhBN.Text = "Ngày sinh";
            // 
            // lblMaBN
            // 
            this.lblMaBN.AutoSize = true;
            this.lblMaBN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaBN.ForeColor = System.Drawing.Color.Black;
            this.lblMaBN.Location = new System.Drawing.Point(19, 74);
            this.lblMaBN.Name = "lblMaBN";
            this.lblMaBN.Size = new System.Drawing.Size(103, 20);
            this.lblMaBN.TabIndex = 11;
            this.lblMaBN.Text = "Mã bệnh nhân";
            // 
            // dtpNgaySinhBN
            // 
            this.dtpNgaySinhBN.CustomFormat = "MM-dd-yyyy";
            this.dtpNgaySinhBN.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.benhNhanBindingSource, "NgaySinh", true));
            this.dtpNgaySinhBN.Enabled = false;
            this.dtpNgaySinhBN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgaySinhBN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinhBN.Location = new System.Drawing.Point(128, 112);
            this.dtpNgaySinhBN.Name = "dtpNgaySinhBN";
            this.dtpNgaySinhBN.Size = new System.Drawing.Size(121, 27);
            this.dtpNgaySinhBN.TabIndex = 12;
            // 
            // grpBoxBN
            // 
            this.grpBoxBN.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxBN.Controls.Add(this.txtGioiTinh);
            this.grpBoxBN.Controls.Add(this.txtMaBN);
            this.grpBoxBN.Controls.Add(this.dtpNgaySinhBN);
            this.grpBoxBN.Controls.Add(this.cbTenBenhNhan);
            this.grpBoxBN.Controls.Add(this.lblMaBN);
            this.grpBoxBN.Controls.Add(this.txtDiaChi);
            this.grpBoxBN.Controls.Add(this.lblNgaySinhBN);
            this.grpBoxBN.Controls.Add(this.lblHoTenBN);
            this.grpBoxBN.Controls.Add(this.lblGioiTinhBN);
            this.grpBoxBN.Controls.Add(this.lblDiaChiBN);
            this.grpBoxBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBoxBN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpBoxBN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(174)))));
            this.grpBoxBN.Location = new System.Drawing.Point(16, 509);
            this.grpBoxBN.Name = "grpBoxBN";
            this.grpBoxBN.Size = new System.Drawing.Size(487, 205);
            this.grpBoxBN.TabIndex = 14;
            this.grpBoxBN.TabStop = false;
            this.grpBoxBN.Text = "Thông tin bệnh nhân";
            // 
            // txtMaBacSi
            // 
            this.txtMaBacSi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "MaNhanVien", true));
            this.txtMaBacSi.Enabled = false;
            this.txtMaBacSi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaBacSi.Location = new System.Drawing.Point(111, 71);
            this.txtMaBacSi.Name = "txtMaBacSi";
            this.txtMaBacSi.Size = new System.Drawing.Size(81, 27);
            this.txtMaBacSi.TabIndex = 15;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataSource = typeof(DTO.NhanVien);
            // 
            // cbTenBacSi
            // 
            this.cbTenBacSi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTenBacSi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTenBacSi.DataSource = this.nhanVienBindingSource;
            this.cbTenBacSi.DisplayMember = "HoTen";
            this.cbTenBacSi.DropDownWidth = 150;
            this.cbTenBacSi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbTenBacSi.FormattingEnabled = true;
            this.cbTenBacSi.Location = new System.Drawing.Point(111, 30);
            this.cbTenBacSi.Name = "cbTenBacSi";
            this.cbTenBacSi.Size = new System.Drawing.Size(185, 28);
            this.cbTenBacSi.TabIndex = 16;
            this.cbTenBacSi.ValueMember = "MaNhanVien";
            // 
            // txtGioiTinhBS
            // 
            this.txtGioiTinhBS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "GioiTinh", true));
            this.txtGioiTinhBS.Enabled = false;
            this.txtGioiTinhBS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGioiTinhBS.Location = new System.Drawing.Point(322, 71);
            this.txtGioiTinhBS.Name = "txtGioiTinhBS";
            this.txtGioiTinhBS.Size = new System.Drawing.Size(75, 27);
            this.txtGioiTinhBS.TabIndex = 17;
            // 
            // dtpNgaySinhBS
            // 
            this.dtpNgaySinhBS.CustomFormat = "MM-dd-yyyy";
            this.dtpNgaySinhBS.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nhanVienBindingSource, "NgaySinh", true));
            this.dtpNgaySinhBS.Enabled = false;
            this.dtpNgaySinhBS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgaySinhBS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinhBS.Location = new System.Drawing.Point(111, 112);
            this.dtpNgaySinhBS.Name = "dtpNgaySinhBS";
            this.dtpNgaySinhBS.Size = new System.Drawing.Size(111, 27);
            this.dtpNgaySinhBS.TabIndex = 13;
            // 
            // txtDiaChiBS
            // 
            this.txtDiaChiBS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "DiaChi", true));
            this.txtDiaChiBS.Enabled = false;
            this.txtDiaChiBS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiaChiBS.Location = new System.Drawing.Point(322, 114);
            this.txtDiaChiBS.Multiline = true;
            this.txtDiaChiBS.Name = "txtDiaChiBS";
            this.txtDiaChiBS.Size = new System.Drawing.Size(128, 77);
            this.txtDiaChiBS.TabIndex = 13;
            // 
            // lblHoTenBS
            // 
            this.lblHoTenBS.AutoSize = true;
            this.lblHoTenBS.BackColor = System.Drawing.Color.Transparent;
            this.lblHoTenBS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHoTenBS.ForeColor = System.Drawing.Color.Black;
            this.lblHoTenBS.Location = new System.Drawing.Point(32, 33);
            this.lblHoTenBS.Name = "lblHoTenBS";
            this.lblHoTenBS.Size = new System.Drawing.Size(73, 20);
            this.lblHoTenBS.TabIndex = 13;
            this.lblHoTenBS.Text = "Họ và tên";
            // 
            // lblMaBS
            // 
            this.lblMaBS.AutoSize = true;
            this.lblMaBS.BackColor = System.Drawing.Color.Transparent;
            this.lblMaBS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaBS.ForeColor = System.Drawing.Color.Black;
            this.lblMaBS.Location = new System.Drawing.Point(33, 74);
            this.lblMaBS.Name = "lblMaBS";
            this.lblMaBS.Size = new System.Drawing.Size(72, 20);
            this.lblMaBS.TabIndex = 18;
            this.lblMaBS.Text = "Mã bác sĩ";
            // 
            // lblNgaySinhBS
            // 
            this.lblNgaySinhBS.AutoSize = true;
            this.lblNgaySinhBS.BackColor = System.Drawing.Color.Transparent;
            this.lblNgaySinhBS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgaySinhBS.ForeColor = System.Drawing.Color.Black;
            this.lblNgaySinhBS.Location = new System.Drawing.Point(31, 115);
            this.lblNgaySinhBS.Name = "lblNgaySinhBS";
            this.lblNgaySinhBS.Size = new System.Drawing.Size(74, 20);
            this.lblNgaySinhBS.TabIndex = 13;
            this.lblNgaySinhBS.Text = "Ngày sinh";
            // 
            // lblGioiTinhBS
            // 
            this.lblGioiTinhBS.AutoSize = true;
            this.lblGioiTinhBS.BackColor = System.Drawing.Color.Transparent;
            this.lblGioiTinhBS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGioiTinhBS.ForeColor = System.Drawing.Color.Black;
            this.lblGioiTinhBS.Location = new System.Drawing.Point(251, 74);
            this.lblGioiTinhBS.Name = "lblGioiTinhBS";
            this.lblGioiTinhBS.Size = new System.Drawing.Size(65, 20);
            this.lblGioiTinhBS.TabIndex = 13;
            this.lblGioiTinhBS.Text = "Giới tính";
            // 
            // lblDiaChiBS
            // 
            this.lblDiaChiBS.AutoSize = true;
            this.lblDiaChiBS.BackColor = System.Drawing.Color.Transparent;
            this.lblDiaChiBS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiaChiBS.ForeColor = System.Drawing.Color.Black;
            this.lblDiaChiBS.Location = new System.Drawing.Point(259, 112);
            this.lblDiaChiBS.Name = "lblDiaChiBS";
            this.lblDiaChiBS.Size = new System.Drawing.Size(57, 20);
            this.lblDiaChiBS.TabIndex = 13;
            this.lblDiaChiBS.Text = "Địa Chỉ";
            // 
            // grpBoxBS
            // 
            this.grpBoxBS.Controls.Add(this.lblDiaChiBS);
            this.grpBoxBS.Controls.Add(this.cbTenBacSi);
            this.grpBoxBS.Controls.Add(this.lblGioiTinhBS);
            this.grpBoxBS.Controls.Add(this.txtMaBacSi);
            this.grpBoxBS.Controls.Add(this.lblNgaySinhBS);
            this.grpBoxBS.Controls.Add(this.txtGioiTinhBS);
            this.grpBoxBS.Controls.Add(this.lblMaBS);
            this.grpBoxBS.Controls.Add(this.dtpNgaySinhBS);
            this.grpBoxBS.Controls.Add(this.lblHoTenBS);
            this.grpBoxBS.Controls.Add(this.txtDiaChiBS);
            this.grpBoxBS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpBoxBS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(174)))));
            this.grpBoxBS.Location = new System.Drawing.Point(522, 509);
            this.grpBoxBS.Name = "grpBoxBS";
            this.grpBoxBS.Size = new System.Drawing.Size(469, 205);
            this.grpBoxBS.TabIndex = 19;
            this.grpBoxBS.TabStop = false;
            this.grpBoxBS.Text = "Thông tin bác sĩ";
            // 
            // btnThemPhieuKham
            // 
            this.btnThemPhieuKham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.btnThemPhieuKham.FlatAppearance.BorderSize = 0;
            this.btnThemPhieuKham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemPhieuKham.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemPhieuKham.ForeColor = System.Drawing.Color.White;
            this.btnThemPhieuKham.Location = new System.Drawing.Point(396, 738);
            this.btnThemPhieuKham.Name = "btnThemPhieuKham";
            this.btnThemPhieuKham.Size = new System.Drawing.Size(100, 40);
            this.btnThemPhieuKham.TabIndex = 20;
            this.btnThemPhieuKham.Text = "Thêm";
            this.btnThemPhieuKham.UseVisualStyleBackColor = false;
            this.btnThemPhieuKham.Click += new System.EventHandler(this.btnThemPhieuKham_Click);
            // 
            // btnSuaPhieuKham
            // 
            this.btnSuaPhieuKham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.btnSuaPhieuKham.FlatAppearance.BorderSize = 0;
            this.btnSuaPhieuKham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaPhieuKham.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaPhieuKham.ForeColor = System.Drawing.Color.White;
            this.btnSuaPhieuKham.Location = new System.Drawing.Point(511, 738);
            this.btnSuaPhieuKham.Name = "btnSuaPhieuKham";
            this.btnSuaPhieuKham.Size = new System.Drawing.Size(100, 40);
            this.btnSuaPhieuKham.TabIndex = 21;
            this.btnSuaPhieuKham.Text = "Sửa";
            this.btnSuaPhieuKham.UseVisualStyleBackColor = false;
            this.btnSuaPhieuKham.Click += new System.EventHandler(this.btnSuaPhieuKham_Click);
            // 
            // dtgvPhieuKham
            // 
            this.dtgvPhieuKham.AllowUserToAddRows = false;
            this.dtgvPhieuKham.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvPhieuKham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvPhieuKham.AutoGenerateColumns = false;
            this.dtgvPhieuKham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPhieuKham.BackgroundColor = System.Drawing.Color.White;
            this.dtgvPhieuKham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvPhieuKham.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgvPhieuKham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPhieuKham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvPhieuKham.ColumnHeadersHeight = 40;
            this.dtgvPhieuKham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhieuKhamDataGridViewTextBoxColumn,
            this.ngayKhamDataGridViewTextBoxColumn,
            this.tenBNDataGridViewTextBoxColumn,
            this.tenNVDataGridViewTextBoxColumn});
            this.dtgvPhieuKham.DataSource = this.modelPhieuKhamBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvPhieuKham.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvPhieuKham.DoubleBuffered = true;
            this.dtgvPhieuKham.EnableHeadersVisualStyles = false;
            this.dtgvPhieuKham.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.dtgvPhieuKham.HeaderForeColor = System.Drawing.Color.White;
            this.dtgvPhieuKham.Location = new System.Drawing.Point(15, 61);
            this.dtgvPhieuKham.Name = "dtgvPhieuKham";
            this.dtgvPhieuKham.ReadOnly = true;
            this.dtgvPhieuKham.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvPhieuKham.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtgvPhieuKham.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvPhieuKham.RowTemplate.DividerHeight = 1;
            this.dtgvPhieuKham.RowTemplate.Height = 30;
            this.dtgvPhieuKham.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvPhieuKham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPhieuKham.Size = new System.Drawing.Size(976, 427);
            this.dtgvPhieuKham.TabIndex = 22;
            this.dtgvPhieuKham.CurrentCellChanged += new System.EventHandler(this.dtgvPhieuKham_CurrentCellChanged);
            // 
            // maPhieuKhamDataGridViewTextBoxColumn
            // 
            this.maPhieuKhamDataGridViewTextBoxColumn.DataPropertyName = "MaPhieuKham";
            this.maPhieuKhamDataGridViewTextBoxColumn.HeaderText = "Mã phiếu khám";
            this.maPhieuKhamDataGridViewTextBoxColumn.Name = "maPhieuKhamDataGridViewTextBoxColumn";
            this.maPhieuKhamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayKhamDataGridViewTextBoxColumn
            // 
            this.ngayKhamDataGridViewTextBoxColumn.DataPropertyName = "NgayKham";
            this.ngayKhamDataGridViewTextBoxColumn.HeaderText = "Ngày khám";
            this.ngayKhamDataGridViewTextBoxColumn.Name = "ngayKhamDataGridViewTextBoxColumn";
            this.ngayKhamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenBNDataGridViewTextBoxColumn
            // 
            this.tenBNDataGridViewTextBoxColumn.DataPropertyName = "TenBN";
            this.tenBNDataGridViewTextBoxColumn.HeaderText = "Tên bệnh nhân";
            this.tenBNDataGridViewTextBoxColumn.Name = "tenBNDataGridViewTextBoxColumn";
            this.tenBNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenNVDataGridViewTextBoxColumn
            // 
            this.tenNVDataGridViewTextBoxColumn.DataPropertyName = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.HeaderText = "Tên bác sĩ";
            this.tenNVDataGridViewTextBoxColumn.Name = "tenNVDataGridViewTextBoxColumn";
            this.tenNVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.dtgvPhieuKham;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(70, 17);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(206, 27);
            this.txtTimKiem.TabIndex = 22;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            // 
            // lbBoLoc
            // 
            this.lbBoLoc.AutoSize = true;
            this.lbBoLoc.BackColor = System.Drawing.Color.Transparent;
            this.lbBoLoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbBoLoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(174)))));
            this.lbBoLoc.Location = new System.Drawing.Point(12, 20);
            this.lbBoLoc.Name = "lbBoLoc";
            this.lbBoLoc.Size = new System.Drawing.Size(52, 20);
            this.lbBoLoc.TabIndex = 21;
            this.lbBoLoc.Text = "Bộ lọc";
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.btnLoc.FlatAppearance.BorderSize = 0;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLoc.ForeColor = System.Drawing.Color.White;
            this.btnLoc.Location = new System.Drawing.Point(282, 17);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(75, 27);
            this.btnLoc.TabIndex = 39;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // NhanVienLapPhieuKhamUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lbBoLoc);
            this.Controls.Add(this.dtgvPhieuKham);
            this.Controls.Add(this.btnSuaPhieuKham);
            this.Controls.Add(this.btnThemPhieuKham);
            this.Controls.Add(this.grpBoxBS);
            this.Controls.Add(this.grpBoxBN);
            this.Name = "NhanVienLapPhieuKhamUC";
            this.Size = new System.Drawing.Size(1007, 823);
            this.Load += new System.EventHandler(this.LapPhieuKhamUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modelPhieuKhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benhNhanBindingSource)).EndInit();
            this.grpBoxBN.ResumeLayout(false);
            this.grpBoxBN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.grpBoxBS.ResumeLayout(false);
            this.grpBoxBS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuKham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource modelPhieuKhamBindingSource;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.ComboBox cbTenBenhNhan;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblHoTenBN;
        private System.Windows.Forms.Label lblDiaChiBN;
        private System.Windows.Forms.Label lblGioiTinhBN;
        private System.Windows.Forms.Label lblNgaySinhBN;
        private System.Windows.Forms.Label lblMaBN;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhBN;
        private System.Windows.Forms.GroupBox grpBoxBN;
        private System.Windows.Forms.BindingSource benhNhanBindingSource;
        private System.Windows.Forms.TextBox txtMaBacSi;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private System.Windows.Forms.ComboBox cbTenBacSi;
        private System.Windows.Forms.TextBox txtGioiTinhBS;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhBS;
        private System.Windows.Forms.TextBox txtDiaChiBS;
        private System.Windows.Forms.Label lblHoTenBS;
        private System.Windows.Forms.Label lblMaBS;
        private System.Windows.Forms.Label lblNgaySinhBS;
        private System.Windows.Forms.Label lblGioiTinhBS;
        private System.Windows.Forms.Label lblDiaChiBS;
        private System.Windows.Forms.GroupBox grpBoxBS;
        private System.Windows.Forms.Button btnThemPhieuKham;
        private System.Windows.Forms.Button btnSuaPhieuKham;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgvPhieuKham;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lbBoLoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieuKhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnLoc;
    }
}
