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
            this.dataGridViewTraCuu = new System.Windows.Forms.DataGridView();
            this.benhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trieuChungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelTraCuuBenhNhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnXem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.benhNhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.cbTenBenhNhan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.MaPhieuKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTraCuu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelTraCuuBenhNhanBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.benhNhanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTraCuu
            // 
            this.dataGridViewTraCuu.AllowUserToAddRows = false;
            this.dataGridViewTraCuu.AllowUserToDeleteRows = false;
            this.dataGridViewTraCuu.AutoGenerateColumns = false;
            this.dataGridViewTraCuu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTraCuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTraCuu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.benhDataGridViewTextBoxColumn,
            this.ngayKhamDataGridViewTextBoxColumn,
            this.trieuChungDataGridViewTextBoxColumn,
            this.MaPhieuKham});
            this.dataGridViewTraCuu.DataSource = this.modelTraCuuBenhNhanBindingSource;
            this.dataGridViewTraCuu.Location = new System.Drawing.Point(10, 293);
            this.dataGridViewTraCuu.Name = "dataGridViewTraCuu";
            this.dataGridViewTraCuu.ReadOnly = true;
            this.dataGridViewTraCuu.RowTemplate.Height = 24;
            this.dataGridViewTraCuu.Size = new System.Drawing.Size(470, 366);
            this.dataGridViewTraCuu.TabIndex = 0;
            // 
            // benhDataGridViewTextBoxColumn
            // 
            this.benhDataGridViewTextBoxColumn.DataPropertyName = "Benh";
            this.benhDataGridViewTextBoxColumn.HeaderText = "Benh";
            this.benhDataGridViewTextBoxColumn.Name = "benhDataGridViewTextBoxColumn";
            this.benhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayKhamDataGridViewTextBoxColumn
            // 
            this.ngayKhamDataGridViewTextBoxColumn.DataPropertyName = "NgayKham";
            this.ngayKhamDataGridViewTextBoxColumn.HeaderText = "NgayKham";
            this.ngayKhamDataGridViewTextBoxColumn.Name = "ngayKhamDataGridViewTextBoxColumn";
            this.ngayKhamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trieuChungDataGridViewTextBoxColumn
            // 
            this.trieuChungDataGridViewTextBoxColumn.DataPropertyName = "TrieuChung";
            this.trieuChungDataGridViewTextBoxColumn.HeaderText = "TrieuChung";
            this.trieuChungDataGridViewTextBoxColumn.Name = "trieuChungDataGridViewTextBoxColumn";
            this.trieuChungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelTraCuuBenhNhanBindingSource
            // 
            this.modelTraCuuBenhNhanBindingSource.DataSource = typeof(DTO.Models.ModelTraCuuBenhNhan);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(12, 221);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 22);
            this.dtpFrom.TabIndex = 1;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(274, 221);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 22);
            this.dtpTo.TabIndex = 2;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(205, 264);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "XEM";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGioiTinh);
            this.groupBox2.Controls.Add(this.txtMaBN);
            this.groupBox2.Controls.Add(this.dateTimePicker3);
            this.groupBox2.Controls.Add(this.cbTenBenhNhan);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 190);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn Bệnh Nhân";
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
            // benhNhanBindingSource
            // 
            this.benhNhanBindingSource.DataSource = typeof(DTO.BenhNhan);
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
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "MM-dd-yyyy";
            this.dateTimePicker3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.benhNhanBindingSource, "NgaySinh", true));
            this.dateTimePicker3.Enabled = false;
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(130, 135);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(111, 22);
            this.dateTimePicker3.TabIndex = 12;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mã Bệnh Nhân";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ngày Sinh";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Giới Tính";
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
            // MaPhieuKham
            // 
            this.MaPhieuKham.DataPropertyName = "MaPhieuKham";
            this.MaPhieuKham.HeaderText = "MaPhieuKham";
            this.MaPhieuKham.Name = "MaPhieuKham";
            this.MaPhieuKham.ReadOnly = true;
            // 
            // TraCuuBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(492, 659);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.dataGridViewTraCuu);
            this.Name = "TraCuuBenhNhan";
            this.Text = "TraCuuBenhNhan";
            this.Load += new System.EventHandler(this.TraCuuBenhNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTraCuu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelTraCuuBenhNhanBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.benhNhanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTraCuu;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.BindingSource benhNhanBindingSource;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.ComboBox cbTenBenhNhan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn benhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trieuChungDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource modelTraCuuBenhNhanBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuKham;
    }
}