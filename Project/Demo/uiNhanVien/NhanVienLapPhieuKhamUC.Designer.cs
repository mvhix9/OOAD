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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.modelPhieuKhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.benhNhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbTenBenhNhan = new System.Windows.Forms.ComboBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaBacSi = new System.Windows.Forms.TextBox();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbTenBacSi = new System.Windows.Forms.ComboBox();
            this.txtGioiTinhBS = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChiBS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThemPhieuKham = new System.Windows.Forms.Button();
            this.btnSuaPhieuKham = new System.Windows.Forms.Button();
            this.maPhieuKhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelPhieuKhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benhNhanBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhieuKhamDataGridViewTextBoxColumn,
            this.ngayKhamDataGridViewTextBoxColumn,
            this.tenBNDataGridViewTextBoxColumn,
            this.tenNVDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.modelPhieuKhamBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Size = new System.Drawing.Size(973, 409);
            this.dataGridView1.TabIndex = 0;
            // 
            // modelPhieuKhamBindingSource
            // 
            this.modelPhieuKhamBindingSource.DataSource = typeof(DTO.Models.ModelPhieuKham);
            // 
            // txtMaBN
            // 
            this.txtMaBN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.benhNhanBindingSource, "MaBenhNhan", true));
            this.txtMaBN.Enabled = false;
            this.txtMaBN.Location = new System.Drawing.Point(130, 94);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(111, 22);
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
            this.cbTenBenhNhan.FormattingEnabled = true;
            this.cbTenBenhNhan.Location = new System.Drawing.Point(130, 51);
            this.cbTenBenhNhan.Name = "cbTenBenhNhan";
            this.cbTenBenhNhan.Size = new System.Drawing.Size(121, 24);
            this.cbTenBenhNhan.TabIndex = 4;
            this.cbTenBenhNhan.ValueMember = "MaBenhNhan";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.benhNhanBindingSource, "GioiTinh", true));
            this.txtGioiTinh.Enabled = false;
            this.txtGioiTinh.Location = new System.Drawing.Point(322, 94);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(100, 22);
            this.txtGioiTinh.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.benhNhanBindingSource, "DiaChi", true));
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(322, 135);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(100, 22);
            this.txtDiaChi.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên Bệnh Nhân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Giới Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ngày Sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mã Bệnh Nhân";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM-dd-yyyy";
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.benhNhanBindingSource, "NgaySinh", true));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 135);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(111, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGioiTinh);
            this.groupBox2.Controls.Add(this.txtMaBN);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.cbTenBenhNhan);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(16, 450);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 190);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn Bệnh Nhân";
            // 
            // txtMaBacSi
            // 
            this.txtMaBacSi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "MaNhanVien", true));
            this.txtMaBacSi.Enabled = false;
            this.txtMaBacSi.Location = new System.Drawing.Point(103, 80);
            this.txtMaBacSi.Name = "txtMaBacSi";
            this.txtMaBacSi.Size = new System.Drawing.Size(111, 22);
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
            this.cbTenBacSi.FormattingEnabled = true;
            this.cbTenBacSi.Location = new System.Drawing.Point(103, 37);
            this.cbTenBacSi.Name = "cbTenBacSi";
            this.cbTenBacSi.Size = new System.Drawing.Size(121, 24);
            this.cbTenBacSi.TabIndex = 16;
            this.cbTenBacSi.ValueMember = "MaNhanVien";
            // 
            // txtGioiTinhBS
            // 
            this.txtGioiTinhBS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "GioiTinh", true));
            this.txtGioiTinhBS.Enabled = false;
            this.txtGioiTinhBS.Location = new System.Drawing.Point(305, 77);
            this.txtGioiTinhBS.Name = "txtGioiTinhBS";
            this.txtGioiTinhBS.Size = new System.Drawing.Size(100, 22);
            this.txtGioiTinhBS.TabIndex = 17;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "MM-dd-yyyy";
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nhanVienBindingSource, "NgaySinh", true));
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(103, 124);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(111, 22);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // txtDiaChiBS
            // 
            this.txtDiaChiBS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "DiaChi", true));
            this.txtDiaChiBS.Enabled = false;
            this.txtDiaChiBS.Location = new System.Drawing.Point(305, 121);
            this.txtDiaChiBS.Name = "txtDiaChiBS";
            this.txtDiaChiBS.Size = new System.Drawing.Size(100, 22);
            this.txtDiaChiBS.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tên Bác Sĩ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Mã Bác Sĩ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Ngày Sinh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Giới Tính";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(246, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Địa Chỉ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbTenBacSi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtMaBacSi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtGioiTinhBS);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDiaChiBS);
            this.groupBox1.Location = new System.Drawing.Point(522, 450);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 190);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Bác Sĩ";
            // 
            // btnThemPhieuKham
            // 
            this.btnThemPhieuKham.Location = new System.Drawing.Point(338, 667);
            this.btnThemPhieuKham.Name = "btnThemPhieuKham";
            this.btnThemPhieuKham.Size = new System.Drawing.Size(138, 23);
            this.btnThemPhieuKham.TabIndex = 20;
            this.btnThemPhieuKham.Text = "Thêm Phiếu Khám";
            this.btnThemPhieuKham.UseVisualStyleBackColor = true;
            this.btnThemPhieuKham.Click += new System.EventHandler(this.btnThemPhieuKham_Click);
            // 
            // btnSuaPhieuKham
            // 
            this.btnSuaPhieuKham.Location = new System.Drawing.Point(496, 667);
            this.btnSuaPhieuKham.Name = "btnSuaPhieuKham";
            this.btnSuaPhieuKham.Size = new System.Drawing.Size(138, 23);
            this.btnSuaPhieuKham.TabIndex = 21;
            this.btnSuaPhieuKham.Text = "Sửa Phiếu Khám";
            this.btnSuaPhieuKham.UseVisualStyleBackColor = true;
            this.btnSuaPhieuKham.Click += new System.EventHandler(this.btnSuaPhieuKham_Click);
            // 
            // maPhieuKhamDataGridViewTextBoxColumn
            // 
            this.maPhieuKhamDataGridViewTextBoxColumn.DataPropertyName = "MaPhieuKham";
            this.maPhieuKhamDataGridViewTextBoxColumn.HeaderText = "Mã Phiếu Khám";
            this.maPhieuKhamDataGridViewTextBoxColumn.Name = "maPhieuKhamDataGridViewTextBoxColumn";
            this.maPhieuKhamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayKhamDataGridViewTextBoxColumn
            // 
            this.ngayKhamDataGridViewTextBoxColumn.DataPropertyName = "NgayKham";
            this.ngayKhamDataGridViewTextBoxColumn.HeaderText = "Ngày Khám";
            this.ngayKhamDataGridViewTextBoxColumn.Name = "ngayKhamDataGridViewTextBoxColumn";
            this.ngayKhamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenBNDataGridViewTextBoxColumn
            // 
            this.tenBNDataGridViewTextBoxColumn.DataPropertyName = "TenBN";
            this.tenBNDataGridViewTextBoxColumn.HeaderText = "Tên Bệnh Nhân";
            this.tenBNDataGridViewTextBoxColumn.Name = "tenBNDataGridViewTextBoxColumn";
            this.tenBNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenNVDataGridViewTextBoxColumn
            // 
            this.tenNVDataGridViewTextBoxColumn.DataPropertyName = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.HeaderText = "Tên Nhân Viên";
            this.tenNVDataGridViewTextBoxColumn.Name = "tenNVDataGridViewTextBoxColumn";
            this.tenNVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // LapPhieuKhamUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btnSuaPhieuKham);
            this.Controls.Add(this.btnThemPhieuKham);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LapPhieuKhamUC";
            this.Size = new System.Drawing.Size(1007, 733);
            this.Load += new System.EventHandler(this.LapPhieuKhamUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelPhieuKhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benhNhanBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource modelPhieuKhamBindingSource;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.ComboBox cbTenBenhNhan;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource benhNhanBindingSource;
        private System.Windows.Forms.TextBox txtMaBacSi;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private System.Windows.Forms.ComboBox cbTenBacSi;
        private System.Windows.Forms.TextBox txtGioiTinhBS;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox txtDiaChiBS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThemPhieuKham;
        private System.Windows.Forms.Button btnSuaPhieuKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieuKhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNVDataGridViewTextBoxColumn;
    }
}
