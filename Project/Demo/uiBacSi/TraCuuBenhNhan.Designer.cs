namespace uiBacSi
{
    partial class TraCuuBenhNhan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.modelTraCuuBenhNhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnXem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.benhNhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.dtpNgaySinhBN = new System.Windows.Forms.DateTimePicker();
            this.cbTenBenhNhan = new System.Windows.Forms.ComboBox();
            this.lblMaBN = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblNgaySinhBN = new System.Windows.Forms.Label();
            this.lblHoTenBN = new System.Windows.Forms.Label();
            this.lblGioiTinhBN = new System.Windows.Forms.Label();
            this.lblDiaChiBN = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtgvPhieuKham = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ngayKhamDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trieuChungDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.benhDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhieuKhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.modelTraCuuBenhNhanBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.benhNhanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuKham)).BeginInit();
            this.SuspendLayout();
            // 
            // modelTraCuuBenhNhanBindingSource
            // 
            this.modelTraCuuBenhNhanBindingSource.DataSource = typeof(DTO.Models.ModelTraCuuBenhNhan);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(209, 283);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(120, 27);
            this.dtpFrom.TabIndex = 1;
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(368, 283);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(120, 27);
            this.dtpTo.TabIndex = 2;
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.btnXem.FlatAppearance.BorderSize = 0;
            this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Location = new System.Drawing.Point(528, 278);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(100, 40);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGioiTinh);
            this.groupBox1.Controls.Add(this.txtMaBN);
            this.groupBox1.Controls.Add(this.dtpNgaySinhBN);
            this.groupBox1.Controls.Add(this.cbTenBenhNhan);
            this.groupBox1.Controls.Add(this.lblMaBN);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.lblNgaySinhBN);
            this.groupBox1.Controls.Add(this.lblHoTenBN);
            this.groupBox1.Controls.Add(this.lblGioiTinhBN);
            this.groupBox1.Controls.Add(this.lblDiaChiBN);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(174)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 231);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bệnh nhân";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.benhNhanBindingSource, "GioiTinh", true));
            this.txtGioiTinh.Enabled = false;
            this.txtGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGioiTinh.Location = new System.Drawing.Point(504, 79);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(100, 27);
            this.txtGioiTinh.TabIndex = 5;
            // 
            // benhNhanBindingSource
            // 
            this.benhNhanBindingSource.DataSource = typeof(DTO.BenhNhan);
            // 
            // txtMaBN
            // 
            this.txtMaBN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.benhNhanBindingSource, "MaBenhNhan", true));
            this.txtMaBN.Enabled = false;
            this.txtMaBN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaBN.Location = new System.Drawing.Point(260, 79);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(111, 27);
            this.txtMaBN.TabIndex = 2;
            // 
            // dtpNgaySinhBN
            // 
            this.dtpNgaySinhBN.CustomFormat = "MM-dd-yyyy";
            this.dtpNgaySinhBN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.benhNhanBindingSource, "NgaySinh", true));
            this.dtpNgaySinhBN.Enabled = false;
            this.dtpNgaySinhBN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgaySinhBN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinhBN.Location = new System.Drawing.Point(260, 120);
            this.dtpNgaySinhBN.Name = "dtpNgaySinhBN";
            this.dtpNgaySinhBN.Size = new System.Drawing.Size(111, 27);
            this.dtpNgaySinhBN.TabIndex = 12;
            // 
            // cbTenBenhNhan
            // 
            this.cbTenBenhNhan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTenBenhNhan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTenBenhNhan.DataSource = this.benhNhanBindingSource;
            this.cbTenBenhNhan.DisplayMember = "HoTen";
            this.cbTenBenhNhan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbTenBenhNhan.FormattingEnabled = true;
            this.cbTenBenhNhan.Location = new System.Drawing.Point(260, 36);
            this.cbTenBenhNhan.Name = "cbTenBenhNhan";
            this.cbTenBenhNhan.Size = new System.Drawing.Size(161, 28);
            this.cbTenBenhNhan.TabIndex = 4;
            this.cbTenBenhNhan.ValueMember = "MaBenhNhan";
            // 
            // lblMaBN
            // 
            this.lblMaBN.AutoSize = true;
            this.lblMaBN.BackColor = System.Drawing.Color.Transparent;
            this.lblMaBN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaBN.ForeColor = System.Drawing.Color.Black;
            this.lblMaBN.Location = new System.Drawing.Point(151, 82);
            this.lblMaBN.Name = "lblMaBN";
            this.lblMaBN.Size = new System.Drawing.Size(103, 20);
            this.lblMaBN.TabIndex = 11;
            this.lblMaBN.Text = "Mã bệnh nhân";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.benhNhanBindingSource, "DiaChi", true));
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiaChi.Location = new System.Drawing.Point(504, 120);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(145, 89);
            this.txtDiaChi.TabIndex = 6;
            // 
            // lblNgaySinhBN
            // 
            this.lblNgaySinhBN.AutoSize = true;
            this.lblNgaySinhBN.BackColor = System.Drawing.Color.Transparent;
            this.lblNgaySinhBN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgaySinhBN.ForeColor = System.Drawing.Color.Black;
            this.lblNgaySinhBN.Location = new System.Drawing.Point(180, 123);
            this.lblNgaySinhBN.Name = "lblNgaySinhBN";
            this.lblNgaySinhBN.Size = new System.Drawing.Size(74, 20);
            this.lblNgaySinhBN.TabIndex = 10;
            this.lblNgaySinhBN.Text = "Ngày sinh";
            // 
            // lblHoTenBN
            // 
            this.lblHoTenBN.AutoSize = true;
            this.lblHoTenBN.BackColor = System.Drawing.Color.Transparent;
            this.lblHoTenBN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHoTenBN.ForeColor = System.Drawing.Color.Black;
            this.lblHoTenBN.Location = new System.Drawing.Point(181, 39);
            this.lblHoTenBN.Name = "lblHoTenBN";
            this.lblHoTenBN.Size = new System.Drawing.Size(73, 20);
            this.lblHoTenBN.TabIndex = 7;
            this.lblHoTenBN.Text = "Họ và tên";
            // 
            // lblGioiTinhBN
            // 
            this.lblGioiTinhBN.AutoSize = true;
            this.lblGioiTinhBN.BackColor = System.Drawing.Color.Transparent;
            this.lblGioiTinhBN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGioiTinhBN.ForeColor = System.Drawing.Color.Black;
            this.lblGioiTinhBN.Location = new System.Drawing.Point(433, 82);
            this.lblGioiTinhBN.Name = "lblGioiTinhBN";
            this.lblGioiTinhBN.Size = new System.Drawing.Size(65, 20);
            this.lblGioiTinhBN.TabIndex = 9;
            this.lblGioiTinhBN.Text = "Giới tính";
            // 
            // lblDiaChiBN
            // 
            this.lblDiaChiBN.AutoSize = true;
            this.lblDiaChiBN.BackColor = System.Drawing.Color.Transparent;
            this.lblDiaChiBN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiaChiBN.ForeColor = System.Drawing.Color.Black;
            this.lblDiaChiBN.Location = new System.Drawing.Point(441, 123);
            this.lblDiaChiBN.Name = "lblDiaChiBN";
            this.lblDiaChiBN.Size = new System.Drawing.Size(55, 20);
            this.lblDiaChiBN.TabIndex = 8;
            this.lblDiaChiBN.Text = "Địa chỉ";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(174)))));
            this.lblFrom.Location = new System.Drawing.Point(205, 260);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(28, 20);
            this.lblFrom.TabIndex = 16;
            this.lblFrom.Text = "Từ";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.BackColor = System.Drawing.Color.Transparent;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(174)))));
            this.lblTo.Location = new System.Drawing.Point(364, 260);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(37, 20);
            this.lblTo.TabIndex = 17;
            this.lblTo.Text = "Đến";
            // 
            // dtgvPhieuKham
            // 
            this.dtgvPhieuKham.AllowUserToAddRows = false;
            this.dtgvPhieuKham.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dtgvPhieuKham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
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
            this.ngayKhamDataGridViewTextBoxColumn1,
            this.trieuChungDataGridViewTextBoxColumn1,
            this.benhDataGridViewTextBoxColumn1,
            this.maPhieuKhamDataGridViewTextBoxColumn});
            this.dtgvPhieuKham.DataSource = this.modelTraCuuBenhNhanBindingSource;
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
            this.dtgvPhieuKham.Location = new System.Drawing.Point(16, 337);
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
            this.dtgvPhieuKham.Size = new System.Drawing.Size(800, 314);
            this.dtgvPhieuKham.TabIndex = 24;
            // 
            // ngayKhamDataGridViewTextBoxColumn1
            // 
            this.ngayKhamDataGridViewTextBoxColumn1.DataPropertyName = "NgayKham";
            this.ngayKhamDataGridViewTextBoxColumn1.HeaderText = "Ngày khám";
            this.ngayKhamDataGridViewTextBoxColumn1.Name = "ngayKhamDataGridViewTextBoxColumn1";
            this.ngayKhamDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // trieuChungDataGridViewTextBoxColumn1
            // 
            this.trieuChungDataGridViewTextBoxColumn1.DataPropertyName = "TrieuChung";
            this.trieuChungDataGridViewTextBoxColumn1.HeaderText = "Triệu chứng";
            this.trieuChungDataGridViewTextBoxColumn1.Name = "trieuChungDataGridViewTextBoxColumn1";
            this.trieuChungDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // benhDataGridViewTextBoxColumn1
            // 
            this.benhDataGridViewTextBoxColumn1.DataPropertyName = "Benh";
            this.benhDataGridViewTextBoxColumn1.HeaderText = "Bệnh";
            this.benhDataGridViewTextBoxColumn1.Name = "benhDataGridViewTextBoxColumn1";
            this.benhDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // maPhieuKhamDataGridViewTextBoxColumn
            // 
            this.maPhieuKhamDataGridViewTextBoxColumn.DataPropertyName = "MaPhieuKham";
            this.maPhieuKhamDataGridViewTextBoxColumn.HeaderText = "Mã phiếu khám";
            this.maPhieuKhamDataGridViewTextBoxColumn.Name = "maPhieuKhamDataGridViewTextBoxColumn";
            this.maPhieuKhamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TraCuuBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(832, 683);
            this.Controls.Add(this.dtgvPhieuKham);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Name = "TraCuuBenhNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu bệnh nhân";
            this.Load += new System.EventHandler(this.TraCuuBenhNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modelTraCuuBenhNhanBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.benhNhanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuKham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.BindingSource benhNhanBindingSource;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhBN;
        private System.Windows.Forms.ComboBox cbTenBenhNhan;
        private System.Windows.Forms.Label lblMaBN;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblNgaySinhBN;
        private System.Windows.Forms.Label lblHoTenBN;
        private System.Windows.Forms.Label lblGioiTinhBN;
        private System.Windows.Forms.Label lblDiaChiBN;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource modelTraCuuBenhNhanBindingSource;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgvPhieuKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKhamDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn trieuChungDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn benhDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieuKhamDataGridViewTextBoxColumn;
    }
}