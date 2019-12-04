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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.modelPhieuKhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.benhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radPKDaLap = new System.Windows.Forms.RadioButton();
            this.radPKHoanThanh = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTrieuChung = new System.Windows.Forms.Label();
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.btnLuuPhieuKham = new System.Windows.Forms.Button();
            this.listBenh = new System.Windows.Forms.ListBox();
            this.btnXoaLoaiBenh = new System.Windows.Forms.Button();
            this.btnThemLoaiBenh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvChiTietBenh = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Benh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDSLB = new System.Windows.Forms.Label();
            this.dtgvPhieuKham = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.maPhieuKhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBenhNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trieuChungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.modelPhieuKhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benhBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietBenh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuKham)).BeginInit();
            this.SuspendLayout();
            // 
            // modelPhieuKhamBindingSource
            // 
            this.modelPhieuKhamBindingSource.DataSource = typeof(DTO.Models.ModelPhieuKham);
            // 
            // benhBindingSource
            // 
            this.benhBindingSource.DataSource = typeof(DTO.Benh);
            // 
            // radPKDaLap
            // 
            this.radPKDaLap.AutoSize = true;
            this.radPKDaLap.BackColor = System.Drawing.Color.Transparent;
            this.radPKDaLap.Checked = true;
            this.radPKDaLap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPKDaLap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(174)))));
            this.radPKDaLap.Location = new System.Drawing.Point(17, 20);
            this.radPKDaLap.Name = "radPKDaLap";
            this.radPKDaLap.Size = new System.Drawing.Size(143, 24);
            this.radPKDaLap.TabIndex = 11;
            this.radPKDaLap.TabStop = true;
            this.radPKDaLap.Text = "Phiếu khám mới";
            this.radPKDaLap.UseVisualStyleBackColor = false;
            this.radPKDaLap.CheckedChanged += new System.EventHandler(this.radPKDaLap_CheckedChanged);
            // 
            // radPKHoanThanh
            // 
            this.radPKHoanThanh.AutoSize = true;
            this.radPKHoanThanh.BackColor = System.Drawing.Color.Transparent;
            this.radPKHoanThanh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radPKHoanThanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(174)))));
            this.radPKHoanThanh.Location = new System.Drawing.Point(166, 20);
            this.radPKHoanThanh.Name = "radPKHoanThanh";
            this.radPKHoanThanh.Size = new System.Drawing.Size(132, 24);
            this.radPKHoanThanh.TabIndex = 12;
            this.radPKHoanThanh.Text = "Phiếu khám cũ";
            this.radPKHoanThanh.UseVisualStyleBackColor = false;
            this.radPKHoanThanh.CheckedChanged += new System.EventHandler(this.radPKHoanThanh_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblTrieuChung);
            this.groupBox1.Controls.Add(this.txtTrieuChung);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(174)))));
            this.groupBox1.Location = new System.Drawing.Point(17, 468);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 165);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin triệu chứng";
            // 
            // lblTrieuChung
            // 
            this.lblTrieuChung.AutoSize = true;
            this.lblTrieuChung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTrieuChung.ForeColor = System.Drawing.Color.Black;
            this.lblTrieuChung.Location = new System.Drawing.Point(86, 57);
            this.lblTrieuChung.Name = "lblTrieuChung";
            this.lblTrieuChung.Size = new System.Drawing.Size(86, 20);
            this.lblTrieuChung.TabIndex = 17;
            this.lblTrieuChung.Text = "Triệu chứng";
            // 
            // txtTrieuChung
            // 
            this.txtTrieuChung.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelPhieuKhamBindingSource, "TrieuChung", true));
            this.txtTrieuChung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTrieuChung.Location = new System.Drawing.Point(178, 54);
            this.txtTrieuChung.Multiline = true;
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.Size = new System.Drawing.Size(136, 56);
            this.txtTrieuChung.TabIndex = 11;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.btnTraCuu.FlatAppearance.BorderSize = 0;
            this.btnTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTraCuu.ForeColor = System.Drawing.Color.White;
            this.btnTraCuu.Location = new System.Drawing.Point(516, 770);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(148, 40);
            this.btnTraCuu.TabIndex = 17;
            this.btnTraCuu.Text = "Tra cứu bệnh nhân";
            this.btnTraCuu.UseVisualStyleBackColor = false;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // btnLuuPhieuKham
            // 
            this.btnLuuPhieuKham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.btnLuuPhieuKham.FlatAppearance.BorderSize = 0;
            this.btnLuuPhieuKham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuPhieuKham.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuuPhieuKham.ForeColor = System.Drawing.Color.White;
            this.btnLuuPhieuKham.Location = new System.Drawing.Point(343, 770);
            this.btnLuuPhieuKham.Name = "btnLuuPhieuKham";
            this.btnLuuPhieuKham.Size = new System.Drawing.Size(157, 40);
            this.btnLuuPhieuKham.TabIndex = 15;
            this.btnLuuPhieuKham.Text = "Lưu phiếu khám";
            this.btnLuuPhieuKham.UseVisualStyleBackColor = false;
            this.btnLuuPhieuKham.Click += new System.EventHandler(this.btnLuuPhieuKham_Click);
            // 
            // listBenh
            // 
            this.listBenh.DataSource = this.benhBindingSource;
            this.listBenh.DisplayMember = "TenBenh";
            this.listBenh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listBenh.FormattingEnabled = true;
            this.listBenh.ItemHeight = 20;
            this.listBenh.Location = new System.Drawing.Point(360, 65);
            this.listBenh.MultiColumn = true;
            this.listBenh.Name = "listBenh";
            this.listBenh.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBenh.Size = new System.Drawing.Size(165, 164);
            this.listBenh.TabIndex = 21;
            this.listBenh.ValueMember = "MaBenh";
            // 
            // btnXoaLoaiBenh
            // 
            this.btnXoaLoaiBenh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.btnXoaLoaiBenh.FlatAppearance.BorderSize = 0;
            this.btnXoaLoaiBenh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaLoaiBenh.ForeColor = System.Drawing.Color.White;
            this.btnXoaLoaiBenh.Location = new System.Drawing.Point(289, 143);
            this.btnXoaLoaiBenh.Name = "btnXoaLoaiBenh";
            this.btnXoaLoaiBenh.Size = new System.Drawing.Size(53, 40);
            this.btnXoaLoaiBenh.TabIndex = 20;
            this.btnXoaLoaiBenh.Text = ">";
            this.btnXoaLoaiBenh.UseVisualStyleBackColor = false;
            this.btnXoaLoaiBenh.Click += new System.EventHandler(this.btnXoaLoaiBenh_Click);
            // 
            // btnThemLoaiBenh
            // 
            this.btnThemLoaiBenh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.btnThemLoaiBenh.FlatAppearance.BorderSize = 0;
            this.btnThemLoaiBenh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemLoaiBenh.ForeColor = System.Drawing.Color.White;
            this.btnThemLoaiBenh.Location = new System.Drawing.Point(289, 97);
            this.btnThemLoaiBenh.Name = "btnThemLoaiBenh";
            this.btnThemLoaiBenh.Size = new System.Drawing.Size(53, 40);
            this.btnThemLoaiBenh.TabIndex = 19;
            this.btnThemLoaiBenh.Text = "<";
            this.btnThemLoaiBenh.UseVisualStyleBackColor = false;
            this.btnThemLoaiBenh.Click += new System.EventHandler(this.btnThemLoaiBenh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dtgvChiTietBenh);
            this.groupBox2.Controls.Add(this.lblDSLB);
            this.groupBox2.Controls.Add(this.listBenh);
            this.groupBox2.Controls.Add(this.btnXoaLoaiBenh);
            this.groupBox2.Controls.Add(this.btnThemLoaiBenh);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(174)))));
            this.groupBox2.Location = new System.Drawing.Point(434, 468);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 283);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin loại bệnh";
            // 
            // dtgvChiTietBenh
            // 
            this.dtgvChiTietBenh.AllowUserToAddRows = false;
            this.dtgvChiTietBenh.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvChiTietBenh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvChiTietBenh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvChiTietBenh.BackgroundColor = System.Drawing.Color.White;
            this.dtgvChiTietBenh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvChiTietBenh.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgvChiTietBenh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvChiTietBenh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvChiTietBenh.ColumnHeadersHeight = 40;
            this.dtgvChiTietBenh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Benh,
            this.MaBenh});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvChiTietBenh.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvChiTietBenh.DoubleBuffered = true;
            this.dtgvChiTietBenh.EnableHeadersVisualStyles = false;
            this.dtgvChiTietBenh.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.dtgvChiTietBenh.HeaderForeColor = System.Drawing.Color.White;
            this.dtgvChiTietBenh.Location = new System.Drawing.Point(29, 32);
            this.dtgvChiTietBenh.Name = "dtgvChiTietBenh";
            this.dtgvChiTietBenh.ReadOnly = true;
            this.dtgvChiTietBenh.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvChiTietBenh.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtgvChiTietBenh.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvChiTietBenh.RowTemplate.DividerHeight = 1;
            this.dtgvChiTietBenh.RowTemplate.Height = 30;
            this.dtgvChiTietBenh.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvChiTietBenh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvChiTietBenh.Size = new System.Drawing.Size(240, 219);
            this.dtgvChiTietBenh.TabIndex = 24;
            // 
            // Benh
            // 
            this.Benh.HeaderText = "Bệnh";
            this.Benh.Name = "Benh";
            this.Benh.ReadOnly = true;
            // 
            // MaBenh
            // 
            this.MaBenh.HeaderText = "MaBenh";
            this.MaBenh.Name = "MaBenh";
            this.MaBenh.ReadOnly = true;
            this.MaBenh.Visible = false;
            // 
            // lblDSLB
            // 
            this.lblDSLB.AutoSize = true;
            this.lblDSLB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDSLB.ForeColor = System.Drawing.Color.Black;
            this.lblDSLB.Location = new System.Drawing.Point(356, 42);
            this.lblDSLB.Name = "lblDSLB";
            this.lblDSLB.Size = new System.Drawing.Size(169, 20);
            this.lblDSLB.TabIndex = 18;
            this.lblDSLB.Text = "Danh sách các loại bệnh";
            // 
            // dtgvPhieuKham
            // 
            this.dtgvPhieuKham.AllowUserToAddRows = false;
            this.dtgvPhieuKham.AllowUserToDeleteRows = false;
            this.dtgvPhieuKham.AllowUserToOrderColumns = true;
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
            this.maPhieuKhamDataGridViewTextBoxColumn,
            this.MaBenhNhan,
            this.MaNhanVien,
            this.tenBNDataGridViewTextBoxColumn,
            this.trieuChungDataGridViewTextBoxColumn,
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
            this.dtgvPhieuKham.Location = new System.Drawing.Point(17, 53);
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
            this.dtgvPhieuKham.Size = new System.Drawing.Size(968, 399);
            this.dtgvPhieuKham.TabIndex = 23;
            this.dtgvPhieuKham.CurrentCellChanged += new System.EventHandler(this.dtgvPhieuKham_CurrentCellChanged);
            // 
            // maPhieuKhamDataGridViewTextBoxColumn
            // 
            this.maPhieuKhamDataGridViewTextBoxColumn.DataPropertyName = "MaPhieuKham";
            this.maPhieuKhamDataGridViewTextBoxColumn.HeaderText = "Mã phiếu khám";
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
            // ngayKhamDataGridViewTextBoxColumn
            // 
            this.ngayKhamDataGridViewTextBoxColumn.DataPropertyName = "NgayKham";
            this.ngayKhamDataGridViewTextBoxColumn.HeaderText = "Ngày khám";
            this.ngayKhamDataGridViewTextBoxColumn.Name = "ngayKhamDataGridViewTextBoxColumn";
            this.ngayKhamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BacSiLapPhieuKhamUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.dtgvPhieuKham);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.btnLuuPhieuKham);
            this.Controls.Add(this.radPKHoanThanh);
            this.Controls.Add(this.radPKDaLap);
            this.Name = "BacSiLapPhieuKhamUC";
            this.Size = new System.Drawing.Size(1007, 823);
            this.Load += new System.EventHandler(this.BacSiLapPhieuKhamUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modelPhieuKhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benhBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietBenh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuKham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource modelPhieuKhamBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiTietBenhDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource benhBindingSource;
        private System.Windows.Forms.RadioButton radPKDaLap;
        private System.Windows.Forms.RadioButton radPKHoanThanh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Button btnLuuPhieuKham;
        private System.Windows.Forms.TextBox txtTrieuChung;
        private System.Windows.Forms.Label lblTrieuChung;
        private System.Windows.Forms.ListBox listBenh;
        private System.Windows.Forms.Button btnXoaLoaiBenh;
        private System.Windows.Forms.Button btnThemLoaiBenh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDSLB;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgvPhieuKham;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgvChiTietBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieuKhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trieuChungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Benh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBenh;
    }
}
