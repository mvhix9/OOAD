namespace uiBacSi
{
    partial class LapDonThuocUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.thuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelPhieuKhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLuuDonThuoc = new System.Windows.Forms.Button();
            this.radChuaLapDonThuoc = new System.Windows.Forms.RadioButton();
            this.radDaLapDonThuoc = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTenThuoc = new System.Windows.Forms.Label();
            this.txtCachDung = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.cbThuoc = new System.Windows.Forms.ComboBox();
            this.dtgvChiTietDT = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.MaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CachDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvPhieuKham = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.maPhieuKhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBenhNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trieuChungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.thuocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelPhieuKhamBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuKham)).BeginInit();
            this.SuspendLayout();
            // 
            // thuocBindingSource
            // 
            this.thuocBindingSource.DataSource = typeof(DTO.Thuoc);
            // 
            // modelPhieuKhamBindingSource
            // 
            this.modelPhieuKhamBindingSource.DataSource = typeof(DTO.Models.ModelPhieuKham);
            // 
            // btnLuuDonThuoc
            // 
            this.btnLuuDonThuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuuDonThuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.btnLuuDonThuoc.FlatAppearance.BorderSize = 0;
            this.btnLuuDonThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuDonThuoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuuDonThuoc.ForeColor = System.Drawing.Color.White;
            this.btnLuuDonThuoc.Location = new System.Drawing.Point(429, 765);
            this.btnLuuDonThuoc.Name = "btnLuuDonThuoc";
            this.btnLuuDonThuoc.Size = new System.Drawing.Size(146, 40);
            this.btnLuuDonThuoc.TabIndex = 6;
            this.btnLuuDonThuoc.Text = "Lưu đơn thuốc";
            this.btnLuuDonThuoc.UseVisualStyleBackColor = false;
            this.btnLuuDonThuoc.Click += new System.EventHandler(this.btnLuuDonThuoc_Click);
            // 
            // radChuaLapDonThuoc
            // 
            this.radChuaLapDonThuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radChuaLapDonThuoc.AutoSize = true;
            this.radChuaLapDonThuoc.Checked = true;
            this.radChuaLapDonThuoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radChuaLapDonThuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(174)))));
            this.radChuaLapDonThuoc.Location = new System.Drawing.Point(16, 20);
            this.radChuaLapDonThuoc.Name = "radChuaLapDonThuoc";
            this.radChuaLapDonThuoc.Size = new System.Drawing.Size(166, 24);
            this.radChuaLapDonThuoc.TabIndex = 13;
            this.radChuaLapDonThuoc.TabStop = true;
            this.radChuaLapDonThuoc.Text = "Chưa lập đơn thuốc";
            this.radChuaLapDonThuoc.UseVisualStyleBackColor = true;
            this.radChuaLapDonThuoc.CheckedChanged += new System.EventHandler(this.radChuaLapDonThuoc_CheckedChanged);
            // 
            // radDaLapDonThuoc
            // 
            this.radDaLapDonThuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radDaLapDonThuoc.AutoSize = true;
            this.radDaLapDonThuoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radDaLapDonThuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(174)))));
            this.radDaLapDonThuoc.Location = new System.Drawing.Point(188, 20);
            this.radDaLapDonThuoc.Name = "radDaLapDonThuoc";
            this.radDaLapDonThuoc.Size = new System.Drawing.Size(149, 24);
            this.radDaLapDonThuoc.TabIndex = 14;
            this.radDaLapDonThuoc.Text = "Đã lập đơn thuốc";
            this.radDaLapDonThuoc.UseVisualStyleBackColor = true;
            this.radDaLapDonThuoc.CheckedChanged += new System.EventHandler(this.radDaLapDonThuoc_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblTongTien);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblTenThuoc);
            this.groupBox1.Controls.Add(this.txtCachDung);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtSoLuongTon);
            this.groupBox1.Controls.Add(this.cbThuoc);
            this.groupBox1.Controls.Add(this.dtgvChiTietDT);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(174)))));
            this.groupBox1.Location = new System.Drawing.Point(16, 367);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(974, 379);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thuốc";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Black;
            this.lblTongTien.Location = new System.Drawing.Point(489, 337);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(72, 20);
            this.lblTongTien.TabIndex = 39;
            this.lblTongTien.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(567, 334);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(144, 27);
            this.txtTongTien.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(733, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Cách dùng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(743, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(717, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Số lượng tồn";
            // 
            // lblTenThuoc
            // 
            this.lblTenThuoc.AutoSize = true;
            this.lblTenThuoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenThuoc.ForeColor = System.Drawing.Color.Black;
            this.lblTenThuoc.Location = new System.Drawing.Point(739, 69);
            this.lblTenThuoc.Name = "lblTenThuoc";
            this.lblTenThuoc.Size = new System.Drawing.Size(73, 20);
            this.lblTenThuoc.TabIndex = 34;
            this.lblTenThuoc.Text = "Tên thuốc";
            // 
            // txtCachDung
            // 
            this.txtCachDung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCachDung.Location = new System.Drawing.Point(818, 208);
            this.txtCachDung.Name = "txtCachDung";
            this.txtCachDung.Size = new System.Drawing.Size(144, 27);
            this.txtCachDung.TabIndex = 33;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoLuong.Location = new System.Drawing.Point(818, 160);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 27);
            this.txtSoLuong.TabIndex = 32;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(862, 256);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 40);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(747, 256);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 40);
            this.btnThem.TabIndex = 30;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thuocBindingSource, "SoLuongTon", true));
            this.txtSoLuongTon.Enabled = false;
            this.txtSoLuongTon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoLuongTon.Location = new System.Drawing.Point(818, 114);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.ReadOnly = true;
            this.txtSoLuongTon.Size = new System.Drawing.Size(144, 27);
            this.txtSoLuongTon.TabIndex = 29;
            // 
            // cbThuoc
            // 
            this.cbThuoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbThuoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbThuoc.DataSource = this.thuocBindingSource;
            this.cbThuoc.DisplayMember = "TenThuoc";
            this.cbThuoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbThuoc.FormattingEnabled = true;
            this.cbThuoc.Location = new System.Drawing.Point(818, 66);
            this.cbThuoc.Name = "cbThuoc";
            this.cbThuoc.Size = new System.Drawing.Size(144, 28);
            this.cbThuoc.TabIndex = 28;
            this.cbThuoc.ValueMember = "MaThuoc";
            // 
            // dtgvChiTietDT
            // 
            this.dtgvChiTietDT.AllowUserToAddRows = false;
            this.dtgvChiTietDT.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvChiTietDT.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvChiTietDT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvChiTietDT.BackgroundColor = System.Drawing.Color.White;
            this.dtgvChiTietDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvChiTietDT.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgvChiTietDT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvChiTietDT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvChiTietDT.ColumnHeadersHeight = 40;
            this.dtgvChiTietDT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThuoc,
            this.TenThuoc,
            this.SoLuong,
            this.DonVi,
            this.CachDung,
            this.DonGia,
            this.ThanhTien});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvChiTietDT.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvChiTietDT.DoubleBuffered = true;
            this.dtgvChiTietDT.EnableHeadersVisualStyles = false;
            this.dtgvChiTietDT.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.dtgvChiTietDT.HeaderForeColor = System.Drawing.Color.White;
            this.dtgvChiTietDT.Location = new System.Drawing.Point(13, 33);
            this.dtgvChiTietDT.Name = "dtgvChiTietDT";
            this.dtgvChiTietDT.ReadOnly = true;
            this.dtgvChiTietDT.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvChiTietDT.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtgvChiTietDT.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvChiTietDT.RowTemplate.DividerHeight = 1;
            this.dtgvChiTietDT.RowTemplate.Height = 30;
            this.dtgvChiTietDT.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvChiTietDT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvChiTietDT.Size = new System.Drawing.Size(698, 292);
            this.dtgvChiTietDT.TabIndex = 25;
            // 
            // MaThuoc
            // 
            this.MaThuoc.HeaderText = "MaThuoc";
            this.MaThuoc.Name = "MaThuoc";
            this.MaThuoc.ReadOnly = true;
            this.MaThuoc.Visible = false;
            // 
            // TenThuoc
            // 
            this.TenThuoc.HeaderText = "Tên thuốc";
            this.TenThuoc.Name = "TenThuoc";
            this.TenThuoc.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // DonVi
            // 
            this.DonVi.HeaderText = "Đơn vị";
            this.DonVi.Name = "DonVi";
            this.DonVi.ReadOnly = true;
            // 
            // CachDung
            // 
            this.CachDung.HeaderText = "Cách dùng";
            this.CachDung.Name = "CachDung";
            this.CachDung.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // dtgvPhieuKham
            // 
            this.dtgvPhieuKham.AllowUserToAddRows = false;
            this.dtgvPhieuKham.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dtgvPhieuKham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvPhieuKham.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtgvPhieuKham.AutoGenerateColumns = false;
            this.dtgvPhieuKham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPhieuKham.BackgroundColor = System.Drawing.Color.White;
            this.dtgvPhieuKham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvPhieuKham.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgvPhieuKham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPhieuKham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvPhieuKham.ColumnHeadersHeight = 40;
            this.dtgvPhieuKham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhieuKhamDataGridViewTextBoxColumn,
            this.MaBenhNhan,
            this.MaNhanVien,
            this.tenBNDataGridViewTextBoxColumn,
            this.trieuChungDataGridViewTextBoxColumn,
            this.TenBenh,
            this.ngayKhamDataGridViewTextBoxColumn});
            this.dtgvPhieuKham.DataSource = this.modelPhieuKhamBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvPhieuKham.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvPhieuKham.DoubleBuffered = true;
            this.dtgvPhieuKham.EnableHeadersVisualStyles = false;
            this.dtgvPhieuKham.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.dtgvPhieuKham.HeaderForeColor = System.Drawing.Color.White;
            this.dtgvPhieuKham.Location = new System.Drawing.Point(16, 50);
            this.dtgvPhieuKham.Name = "dtgvPhieuKham";
            this.dtgvPhieuKham.ReadOnly = true;
            this.dtgvPhieuKham.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvPhieuKham.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtgvPhieuKham.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvPhieuKham.RowTemplate.DividerHeight = 1;
            this.dtgvPhieuKham.RowTemplate.Height = 30;
            this.dtgvPhieuKham.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvPhieuKham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPhieuKham.Size = new System.Drawing.Size(974, 299);
            this.dtgvPhieuKham.TabIndex = 24;
            this.dtgvPhieuKham.CurrentCellChanged += new System.EventHandler(this.dtgvPhieuKham_CurrentCellChanged);
            // 
            // maPhieuKhamDataGridViewTextBoxColumn
            // 
            this.maPhieuKhamDataGridViewTextBoxColumn.DataPropertyName = "MaPhieuKham";
            this.maPhieuKhamDataGridViewTextBoxColumn.HeaderText = "Mã phiếu khám";
            this.maPhieuKhamDataGridViewTextBoxColumn.Name = "maPhieuKhamDataGridViewTextBoxColumn";
            this.maPhieuKhamDataGridViewTextBoxColumn.ReadOnly = true;
            this.maPhieuKhamDataGridViewTextBoxColumn.Visible = false;
            // 
            // MaBenhNhan
            // 
            this.MaBenhNhan.DataPropertyName = "MaBenhNhan";
            this.MaBenhNhan.HeaderText = "MaBenhNhan";
            this.MaBenhNhan.Name = "MaBenhNhan";
            this.MaBenhNhan.ReadOnly = true;
            this.MaBenhNhan.Visible = false;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "MaNhanVien";
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            this.MaNhanVien.Visible = false;
            // 
            // tenBNDataGridViewTextBoxColumn
            // 
            this.tenBNDataGridViewTextBoxColumn.DataPropertyName = "TenBN";
            this.tenBNDataGridViewTextBoxColumn.HeaderText = "Tên bệnh nhân";
            this.tenBNDataGridViewTextBoxColumn.Name = "tenBNDataGridViewTextBoxColumn";
            this.tenBNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trieuChungDataGridViewTextBoxColumn
            // 
            this.trieuChungDataGridViewTextBoxColumn.DataPropertyName = "TrieuChung";
            this.trieuChungDataGridViewTextBoxColumn.HeaderText = "Triệu chứng";
            this.trieuChungDataGridViewTextBoxColumn.Name = "trieuChungDataGridViewTextBoxColumn";
            this.trieuChungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TenBenh
            // 
            this.TenBenh.DataPropertyName = "TenBenh";
            this.TenBenh.HeaderText = "Bệnh";
            this.TenBenh.Name = "TenBenh";
            this.TenBenh.ReadOnly = true;
            // 
            // ngayKhamDataGridViewTextBoxColumn
            // 
            this.ngayKhamDataGridViewTextBoxColumn.DataPropertyName = "NgayKham";
            this.ngayKhamDataGridViewTextBoxColumn.HeaderText = "Ngày khám";
            this.ngayKhamDataGridViewTextBoxColumn.Name = "ngayKhamDataGridViewTextBoxColumn";
            this.ngayKhamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // LapDonThuocUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.dtgvPhieuKham);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radDaLapDonThuoc);
            this.Controls.Add(this.radChuaLapDonThuoc);
            this.Controls.Add(this.btnLuuDonThuoc);
            this.Name = "LapDonThuocUC";
            this.Size = new System.Drawing.Size(1007, 823);
            this.Load += new System.EventHandler(this.LapDonThuocUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thuocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelPhieuKhamBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuKham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource thuocBindingSource;
        private System.Windows.Forms.Button btnLuuDonThuoc;
        private System.Windows.Forms.BindingSource modelPhieuKhamBindingSource;
        private System.Windows.Forms.RadioButton radChuaLapDonThuoc;
        private System.Windows.Forms.RadioButton radDaLapDonThuoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTenThuoc;
        private System.Windows.Forms.TextBox txtCachDung;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.ComboBox cbThuoc;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgvPhieuKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieuKhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trieuChungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKhamDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgvChiTietDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CachDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}
