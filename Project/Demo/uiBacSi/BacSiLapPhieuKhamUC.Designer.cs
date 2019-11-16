namespace uiBacSi
{
    partial class BacSiLapPhieuKhamUC
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
            this.dataGridViewPhieuKham = new System.Windows.Forms.DataGridView();
            this.maPhieuKhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBenhNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trieuChungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelPhieuKhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.dataGridViewChiTietBenh = new System.Windows.Forms.DataGridView();
            this.TenBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.benhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnThemLoaiBenh = new System.Windows.Forms.Button();
            this.btnXoaLoaiBenh = new System.Windows.Forms.Button();
            this.btnLuuPhieuKham = new System.Windows.Forms.Button();
            this.listBenh = new System.Windows.Forms.ListBox();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.radPKDaLap = new System.Windows.Forms.RadioButton();
            this.radPKHoanThanh = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhieuKham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelPhieuKhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietBenh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benhBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPhieuKham
            // 
            this.dataGridViewPhieuKham.AllowUserToAddRows = false;
            this.dataGridViewPhieuKham.AllowUserToDeleteRows = false;
            this.dataGridViewPhieuKham.AutoGenerateColumns = false;
            this.dataGridViewPhieuKham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPhieuKham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhieuKhamDataGridViewTextBoxColumn,
            this.MaBenhNhan,
            this.MaNhanVien,
            this.ngayKhamDataGridViewTextBoxColumn,
            this.tenNVDataGridViewTextBoxColumn,
            this.trieuChungDataGridViewTextBoxColumn});
            this.dataGridViewPhieuKham.DataSource = this.modelPhieuKhamBindingSource;
            this.dataGridViewPhieuKham.Location = new System.Drawing.Point(17, 67);
            this.dataGridViewPhieuKham.Name = "dataGridViewPhieuKham";
            this.dataGridViewPhieuKham.ReadOnly = true;
            this.dataGridViewPhieuKham.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewPhieuKham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPhieuKham.Size = new System.Drawing.Size(973, 284);
            this.dataGridViewPhieuKham.TabIndex = 2;
            this.dataGridViewPhieuKham.CurrentCellChanged += new System.EventHandler(this.dataGridViewPhieuKham_CurrentCellChanged);
            // 
            // maPhieuKhamDataGridViewTextBoxColumn
            // 
            this.maPhieuKhamDataGridViewTextBoxColumn.DataPropertyName = "MaPhieuKham";
            this.maPhieuKhamDataGridViewTextBoxColumn.HeaderText = "MaPhieuKham";
            this.maPhieuKhamDataGridViewTextBoxColumn.Name = "maPhieuKhamDataGridViewTextBoxColumn";
            this.maPhieuKhamDataGridViewTextBoxColumn.ReadOnly = true;
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
            // ngayKhamDataGridViewTextBoxColumn
            // 
            this.ngayKhamDataGridViewTextBoxColumn.DataPropertyName = "NgayKham";
            this.ngayKhamDataGridViewTextBoxColumn.HeaderText = "NgayKham";
            this.ngayKhamDataGridViewTextBoxColumn.Name = "ngayKhamDataGridViewTextBoxColumn";
            this.ngayKhamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenNVDataGridViewTextBoxColumn
            // 
            this.tenNVDataGridViewTextBoxColumn.DataPropertyName = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.HeaderText = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.Name = "tenNVDataGridViewTextBoxColumn";
            this.tenNVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trieuChungDataGridViewTextBoxColumn
            // 
            this.trieuChungDataGridViewTextBoxColumn.DataPropertyName = "TrieuChung";
            this.trieuChungDataGridViewTextBoxColumn.HeaderText = "TrieuChung";
            this.trieuChungDataGridViewTextBoxColumn.Name = "trieuChungDataGridViewTextBoxColumn";
            this.trieuChungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelPhieuKhamBindingSource
            // 
            this.modelPhieuKhamBindingSource.DataSource = typeof(DTO.Models.ModelPhieuKham);
            // 
            // txtTrieuChung
            // 
            this.txtTrieuChung.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelPhieuKhamBindingSource, "TrieuChung", true));
            this.txtTrieuChung.Location = new System.Drawing.Point(17, 378);
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.Size = new System.Drawing.Size(136, 22);
            this.txtTrieuChung.TabIndex = 3;
            // 
            // dataGridViewChiTietBenh
            // 
            this.dataGridViewChiTietBenh.AllowUserToAddRows = false;
            this.dataGridViewChiTietBenh.AllowUserToDeleteRows = false;
            this.dataGridViewChiTietBenh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChiTietBenh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiTietBenh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenBenh,
            this.colMaBenh});
            this.dataGridViewChiTietBenh.Location = new System.Drawing.Point(17, 416);
            this.dataGridViewChiTietBenh.Name = "dataGridViewChiTietBenh";
            this.dataGridViewChiTietBenh.ReadOnly = true;
            this.dataGridViewChiTietBenh.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewChiTietBenh.RowTemplate.Height = 24;
            this.dataGridViewChiTietBenh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChiTietBenh.Size = new System.Drawing.Size(240, 191);
            this.dataGridViewChiTietBenh.TabIndex = 4;
            // 
            // TenBenh
            // 
            this.TenBenh.HeaderText = "Bệnh";
            this.TenBenh.Name = "TenBenh";
            this.TenBenh.ReadOnly = true;
            // 
            // colMaBenh
            // 
            this.colMaBenh.HeaderText = "Mã bệnh";
            this.colMaBenh.Name = "colMaBenh";
            this.colMaBenh.ReadOnly = true;
            this.colMaBenh.Visible = false;
            // 
            // benhBindingSource
            // 
            this.benhBindingSource.DataSource = typeof(DTO.Benh);
            // 
            // btnThemLoaiBenh
            // 
            this.btnThemLoaiBenh.Location = new System.Drawing.Point(272, 469);
            this.btnThemLoaiBenh.Name = "btnThemLoaiBenh";
            this.btnThemLoaiBenh.Size = new System.Drawing.Size(121, 23);
            this.btnThemLoaiBenh.TabIndex = 6;
            this.btnThemLoaiBenh.Text = "Thêm Loại Bệnh";
            this.btnThemLoaiBenh.UseVisualStyleBackColor = true;
            this.btnThemLoaiBenh.Click += new System.EventHandler(this.btnThemLoaiBenh_Click);
            // 
            // btnXoaLoaiBenh
            // 
            this.btnXoaLoaiBenh.Location = new System.Drawing.Point(272, 498);
            this.btnXoaLoaiBenh.Name = "btnXoaLoaiBenh";
            this.btnXoaLoaiBenh.Size = new System.Drawing.Size(121, 23);
            this.btnXoaLoaiBenh.TabIndex = 7;
            this.btnXoaLoaiBenh.Text = "Xóa Loại bệnh";
            this.btnXoaLoaiBenh.UseVisualStyleBackColor = true;
            this.btnXoaLoaiBenh.Click += new System.EventHandler(this.btnXoaLoaiBenh_Click);
            // 
            // btnLuuPhieuKham
            // 
            this.btnLuuPhieuKham.Location = new System.Drawing.Point(272, 527);
            this.btnLuuPhieuKham.Name = "btnLuuPhieuKham";
            this.btnLuuPhieuKham.Size = new System.Drawing.Size(121, 23);
            this.btnLuuPhieuKham.TabIndex = 8;
            this.btnLuuPhieuKham.Text = "Lưu phiếu khám";
            this.btnLuuPhieuKham.UseVisualStyleBackColor = true;
            this.btnLuuPhieuKham.Click += new System.EventHandler(this.btnLuuPhieuKham_Click);
            // 
            // listBenh
            // 
            this.listBenh.DataSource = this.benhBindingSource;
            this.listBenh.DisplayMember = "TenBenh";
            this.listBenh.FormattingEnabled = true;
            this.listBenh.ItemHeight = 16;
            this.listBenh.Location = new System.Drawing.Point(272, 379);
            this.listBenh.MultiColumn = true;
            this.listBenh.Name = "listBenh";
            this.listBenh.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBenh.Size = new System.Drawing.Size(120, 84);
            this.listBenh.TabIndex = 9;
            this.listBenh.ValueMember = "MaBenh";
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(410, 615);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(142, 23);
            this.btnTraCuu.TabIndex = 10;
            this.btnTraCuu.Text = "Tra Cứu Bệnh Nhân";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // radPKDaLap
            // 
            this.radPKDaLap.AutoSize = true;
            this.radPKDaLap.Checked = true;
            this.radPKDaLap.Location = new System.Drawing.Point(17, 30);
            this.radPKDaLap.Name = "radPKDaLap";
            this.radPKDaLap.Size = new System.Drawing.Size(129, 21);
            this.radPKDaLap.TabIndex = 11;
            this.radPKDaLap.TabStop = true;
            this.radPKDaLap.Text = "Phiếu khám mới";
            this.radPKDaLap.UseVisualStyleBackColor = true;
            this.radPKDaLap.CheckedChanged += new System.EventHandler(this.radPKDaLap_CheckedChanged);
            // 
            // radPKHoanThanh
            // 
            this.radPKHoanThanh.AutoSize = true;
            this.radPKHoanThanh.Location = new System.Drawing.Point(152, 30);
            this.radPKHoanThanh.Name = "radPKHoanThanh";
            this.radPKHoanThanh.Size = new System.Drawing.Size(122, 21);
            this.radPKHoanThanh.TabIndex = 12;
            this.radPKHoanThanh.Text = "Phiếu khám cũ";
            this.radPKHoanThanh.UseVisualStyleBackColor = true;
            this.radPKHoanThanh.CheckedChanged += new System.EventHandler(this.radPKHoanThanh_CheckedChanged);
            // 
            // BacSiLapPhieuKhamUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.radPKHoanThanh);
            this.Controls.Add(this.radPKDaLap);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.listBenh);
            this.Controls.Add(this.btnLuuPhieuKham);
            this.Controls.Add(this.btnXoaLoaiBenh);
            this.Controls.Add(this.btnThemLoaiBenh);
            this.Controls.Add(this.dataGridViewChiTietBenh);
            this.Controls.Add(this.txtTrieuChung);
            this.Controls.Add(this.dataGridViewPhieuKham);
            this.Name = "BacSiLapPhieuKhamUC";
            this.Size = new System.Drawing.Size(1007, 733);
            this.Load += new System.EventHandler(this.BacSiLapPhieuKhamUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhieuKham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelPhieuKhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietBenh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benhBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPhieuKham;
        private System.Windows.Forms.BindingSource modelPhieuKhamBindingSource;
        private System.Windows.Forms.TextBox txtTrieuChung;
        private System.Windows.Forms.DataGridView dataGridViewChiTietBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiTietBenhDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnThemLoaiBenh;
        private System.Windows.Forms.Button btnXoaLoaiBenh;
        private System.Windows.Forms.Button btnLuuPhieuKham;
        private System.Windows.Forms.BindingSource benhBindingSource;
        private System.Windows.Forms.ListBox listBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieuKhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trieuChungDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.RadioButton radPKDaLap;
        private System.Windows.Forms.RadioButton radPKHoanThanh;
    }
}
