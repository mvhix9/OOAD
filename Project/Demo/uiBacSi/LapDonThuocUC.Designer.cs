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
            this.cbThuoc = new System.Windows.Forms.ComboBox();
            this.thuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dataGridViewPhieuKham = new System.Windows.Forms.DataGridView();
            this.maPhieuKhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrieuChung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBenhNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelPhieuKhamBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewChiTietDonThuoc = new System.Windows.Forms.DataGridView();
            this.MaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CachDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuuDonThuoc = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtCachDung = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radChuaLapDonThuoc = new System.Windows.Forms.RadioButton();
            this.radDaLapDonThuoc = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.thuocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhieuKham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelPhieuKhamBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietDonThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // cbThuoc
            // 
            this.cbThuoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbThuoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbThuoc.DataSource = this.thuocBindingSource;
            this.cbThuoc.DisplayMember = "TenThuoc";
            this.cbThuoc.FormattingEnabled = true;
            this.cbThuoc.Location = new System.Drawing.Point(95, 352);
            this.cbThuoc.Name = "cbThuoc";
            this.cbThuoc.Size = new System.Drawing.Size(144, 24);
            this.cbThuoc.TabIndex = 0;
            this.cbThuoc.ValueMember = "MaThuoc";
            // 
            // thuocBindingSource
            // 
            this.thuocBindingSource.DataSource = typeof(DTO.Thuoc);
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thuocBindingSource, "SoLuongTon", true));
            this.txtSoLuongTon.Enabled = false;
            this.txtSoLuongTon.Location = new System.Drawing.Point(95, 400);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.ReadOnly = true;
            this.txtSoLuongTon.Size = new System.Drawing.Size(144, 22);
            this.txtSoLuongTon.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(265, 342);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(265, 399);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dataGridViewPhieuKham
            // 
            this.dataGridViewPhieuKham.AllowUserToAddRows = false;
            this.dataGridViewPhieuKham.AllowUserToDeleteRows = false;
            this.dataGridViewPhieuKham.AutoGenerateColumns = false;
            this.dataGridViewPhieuKham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPhieuKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhieuKham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhieuKhamDataGridViewTextBoxColumn,
            this.tenNVDataGridViewTextBoxColumn,
            this.TrieuChung,
            this.NgayKham,
            this.MaNhanVien,
            this.MaBenhNhan});
            this.dataGridViewPhieuKham.DataSource = this.modelPhieuKhamBindingSource1;
            this.dataGridViewPhieuKham.Location = new System.Drawing.Point(16, 35);
            this.dataGridViewPhieuKham.Name = "dataGridViewPhieuKham";
            this.dataGridViewPhieuKham.ReadOnly = true;
            this.dataGridViewPhieuKham.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewPhieuKham.RowTemplate.Height = 24;
            this.dataGridViewPhieuKham.Size = new System.Drawing.Size(973, 284);
            this.dataGridViewPhieuKham.TabIndex = 4;
            this.dataGridViewPhieuKham.CurrentCellChanged += new System.EventHandler(this.dataGridViewPhieuKham_CurrentCellChanged);
            // 
            // maPhieuKhamDataGridViewTextBoxColumn
            // 
            this.maPhieuKhamDataGridViewTextBoxColumn.DataPropertyName = "MaPhieuKham";
            this.maPhieuKhamDataGridViewTextBoxColumn.HeaderText = "MaPhieuKham";
            this.maPhieuKhamDataGridViewTextBoxColumn.Name = "maPhieuKhamDataGridViewTextBoxColumn";
            this.maPhieuKhamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenNVDataGridViewTextBoxColumn
            // 
            this.tenNVDataGridViewTextBoxColumn.DataPropertyName = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.HeaderText = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.Name = "tenNVDataGridViewTextBoxColumn";
            this.tenNVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TrieuChung
            // 
            this.TrieuChung.DataPropertyName = "TrieuChung";
            this.TrieuChung.HeaderText = "TrieuChung";
            this.TrieuChung.Name = "TrieuChung";
            this.TrieuChung.ReadOnly = true;
            // 
            // NgayKham
            // 
            this.NgayKham.DataPropertyName = "NgayKham";
            this.NgayKham.HeaderText = "NgayKham";
            this.NgayKham.Name = "NgayKham";
            this.NgayKham.ReadOnly = true;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "MaNhanVien";
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            this.MaNhanVien.Visible = false;
            // 
            // MaBenhNhan
            // 
            this.MaBenhNhan.DataPropertyName = "MaBenhNhan";
            this.MaBenhNhan.HeaderText = "MaBenhNhan";
            this.MaBenhNhan.Name = "MaBenhNhan";
            this.MaBenhNhan.ReadOnly = true;
            this.MaBenhNhan.Visible = false;
            // 
            // modelPhieuKhamBindingSource1
            // 
            this.modelPhieuKhamBindingSource1.DataSource = typeof(DTO.Models.ModelPhieuKham);
            // 
            // dataGridViewChiTietDonThuoc
            // 
            this.dataGridViewChiTietDonThuoc.AllowUserToAddRows = false;
            this.dataGridViewChiTietDonThuoc.AllowUserToDeleteRows = false;
            this.dataGridViewChiTietDonThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChiTietDonThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiTietDonThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThuoc,
            this.TenThuoc,
            this.SoLuong,
            this.CachDung,
            this.DonGia,
            this.ThanhTien});
            this.dataGridViewChiTietDonThuoc.Location = new System.Drawing.Point(359, 342);
            this.dataGridViewChiTietDonThuoc.Name = "dataGridViewChiTietDonThuoc";
            this.dataGridViewChiTietDonThuoc.ReadOnly = true;
            this.dataGridViewChiTietDonThuoc.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewChiTietDonThuoc.RowTemplate.Height = 24;
            this.dataGridViewChiTietDonThuoc.Size = new System.Drawing.Size(631, 284);
            this.dataGridViewChiTietDonThuoc.TabIndex = 5;
            // 
            // MaThuoc
            // 
            this.MaThuoc.HeaderText = "Mã thuốc";
            this.MaThuoc.Name = "MaThuoc";
            this.MaThuoc.ReadOnly = true;
            this.MaThuoc.Visible = false;
            // 
            // TenThuoc
            // 
            this.TenThuoc.HeaderText = "Tên Thuốc";
            this.TenThuoc.Name = "TenThuoc";
            this.TenThuoc.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // CachDung
            // 
            this.CachDung.HeaderText = "Cách dùng";
            this.CachDung.Name = "CachDung";
            this.CachDung.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // btnLuuDonThuoc
            // 
            this.btnLuuDonThuoc.Location = new System.Drawing.Point(844, 648);
            this.btnLuuDonThuoc.Name = "btnLuuDonThuoc";
            this.btnLuuDonThuoc.Size = new System.Drawing.Size(146, 23);
            this.btnLuuDonThuoc.TabIndex = 6;
            this.btnLuuDonThuoc.Text = "Lưu Đơn Thuốc";
            this.btnLuuDonThuoc.UseVisualStyleBackColor = true;
            this.btnLuuDonThuoc.Click += new System.EventHandler(this.btnLuuDonThuoc_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(95, 452);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 22);
            this.txtSoLuong.TabIndex = 7;
            // 
            // txtCachDung
            // 
            this.txtCachDung.Location = new System.Drawing.Point(95, 494);
            this.txtCachDung.Name = "txtCachDung";
            this.txtCachDung.Size = new System.Drawing.Size(144, 22);
            this.txtCachDung.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Số lượng tồn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cách dùng";
            // 
            // radChuaLapDonThuoc
            // 
            this.radChuaLapDonThuoc.AutoSize = true;
            this.radChuaLapDonThuoc.Checked = true;
            this.radChuaLapDonThuoc.Location = new System.Drawing.Point(16, 8);
            this.radChuaLapDonThuoc.Name = "radChuaLapDonThuoc";
            this.radChuaLapDonThuoc.Size = new System.Drawing.Size(152, 21);
            this.radChuaLapDonThuoc.TabIndex = 13;
            this.radChuaLapDonThuoc.TabStop = true;
            this.radChuaLapDonThuoc.Text = "Chưa lập đơn thuốc";
            this.radChuaLapDonThuoc.UseVisualStyleBackColor = true;
            this.radChuaLapDonThuoc.CheckedChanged += new System.EventHandler(this.radChuaLapDonThuoc_CheckedChanged);
            // 
            // radDaLapDonThuoc
            // 
            this.radDaLapDonThuoc.AutoSize = true;
            this.radDaLapDonThuoc.Location = new System.Drawing.Point(177, 8);
            this.radDaLapDonThuoc.Name = "radDaLapDonThuoc";
            this.radDaLapDonThuoc.Size = new System.Drawing.Size(137, 21);
            this.radDaLapDonThuoc.TabIndex = 14;
            this.radDaLapDonThuoc.Text = "Đã lập đơn thuốc";
            this.radDaLapDonThuoc.UseVisualStyleBackColor = true;
            this.radDaLapDonThuoc.CheckedChanged += new System.EventHandler(this.radDaLapDonThuoc_CheckedChanged);
            // 
            // LapDonThuocUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.radDaLapDonThuoc);
            this.Controls.Add(this.radChuaLapDonThuoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCachDung);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.btnLuuDonThuoc);
            this.Controls.Add(this.dataGridViewChiTietDonThuoc);
            this.Controls.Add(this.dataGridViewPhieuKham);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSoLuongTon);
            this.Controls.Add(this.cbThuoc);
            this.Name = "LapDonThuocUC";
            this.Size = new System.Drawing.Size(1007, 733);
            this.Load += new System.EventHandler(this.LapDonThuocUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thuocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhieuKham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelPhieuKhamBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietDonThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbThuoc;
        private System.Windows.Forms.BindingSource thuocBindingSource;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dataGridViewPhieuKham;
        private System.Windows.Forms.DataGridView dataGridViewChiTietDonThuoc;
        private System.Windows.Forms.Button btnLuuDonThuoc;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtCachDung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource modelPhieuKhamBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieuKhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrieuChung;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn CachDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.RadioButton radChuaLapDonThuoc;
        private System.Windows.Forms.RadioButton radDaLapDonThuoc;
    }
}
