namespace uiQuanTriVien
{
    partial class XemBaoCaoUC
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
            this.modelBaoCaoDoanhThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.cbBaoCao = new System.Windows.Forms.ComboBox();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.lbTongDoanhThu = new System.Windows.Forms.Label();
            this.modelBaoCaoThuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTongDoanhThu = new System.Windows.Forms.TextBox();
            this.lblLoaiBaoCao = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtgvBaoCaoSLT = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.tenThuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvBaoCaoDT = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ngayKhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.modelBaoCaoDoanhThuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBaoCaoThuocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBaoCaoSLT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBaoCaoDT)).BeginInit();
            this.SuspendLayout();
            // 
            // modelBaoCaoDoanhThuBindingSource
            // 
            this.modelBaoCaoDoanhThuBindingSource.DataSource = typeof(DTO.Models.ModelBaoCaoDoanhThu);
            // 
            // dtpStart
            // 
            this.dtpStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpStart.CustomFormat = "dd-MM-yyyy";
            this.dtpStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(357, 48);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(131, 27);
            this.dtpStart.TabIndex = 16;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpEnd.CustomFormat = "dd-MM-yyyy";
            this.dtpEnd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(509, 48);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(131, 27);
            this.dtpEnd.TabIndex = 17;
            // 
            // cbBaoCao
            // 
            this.cbBaoCao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbBaoCao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbBaoCao.FormattingEnabled = true;
            this.cbBaoCao.Items.AddRange(new object[] {
            "Chọn loại báo cáo",
            "Doanh thu",
            "Số lượng thuốc"});
            this.cbBaoCao.Location = new System.Drawing.Point(183, 47);
            this.cbBaoCao.Name = "cbBaoCao";
            this.cbBaoCao.Size = new System.Drawing.Size(150, 28);
            this.cbBaoCao.TabIndex = 18;
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXemBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.btnXemBaoCao.FlatAppearance.BorderSize = 0;
            this.btnXemBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemBaoCao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXemBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnXemBaoCao.Location = new System.Drawing.Point(674, 43);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(152, 37);
            this.btnXemBaoCao.TabIndex = 19;
            this.btnXemBaoCao.Text = "Xem báo cáo";
            this.btnXemBaoCao.UseVisualStyleBackColor = false;
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);
            // 
            // lbTongDoanhThu
            // 
            this.lbTongDoanhThu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTongDoanhThu.AutoSize = true;
            this.lbTongDoanhThu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTongDoanhThu.ForeColor = System.Drawing.Color.Black;
            this.lbTongDoanhThu.Location = new System.Drawing.Point(725, 695);
            this.lbTongDoanhThu.Name = "lbTongDoanhThu";
            this.lbTongDoanhThu.Size = new System.Drawing.Size(114, 20);
            this.lbTongDoanhThu.TabIndex = 20;
            this.lbTongDoanhThu.Text = "Tổng doanh thu";
            this.lbTongDoanhThu.Visible = false;
            // 
            // modelBaoCaoThuocBindingSource
            // 
            this.modelBaoCaoThuocBindingSource.DataSource = typeof(DTO.Models.ModelBaoCaoThuoc);
            // 
            // txtTongDoanhThu
            // 
            this.txtTongDoanhThu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTongDoanhThu.Enabled = false;
            this.txtTongDoanhThu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongDoanhThu.Location = new System.Drawing.Point(845, 692);
            this.txtTongDoanhThu.Name = "txtTongDoanhThu";
            this.txtTongDoanhThu.ReadOnly = true;
            this.txtTongDoanhThu.Size = new System.Drawing.Size(144, 27);
            this.txtTongDoanhThu.TabIndex = 23;
            this.txtTongDoanhThu.Visible = false;
            // 
            // lblLoaiBaoCao
            // 
            this.lblLoaiBaoCao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLoaiBaoCao.AutoSize = true;
            this.lblLoaiBaoCao.BackColor = System.Drawing.Color.Transparent;
            this.lblLoaiBaoCao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLoaiBaoCao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(174)))));
            this.lblLoaiBaoCao.Location = new System.Drawing.Point(180, 17);
            this.lblLoaiBaoCao.Name = "lblLoaiBaoCao";
            this.lblLoaiBaoCao.Size = new System.Drawing.Size(96, 20);
            this.lblLoaiBaoCao.TabIndex = 24;
            this.lblLoaiBaoCao.Text = "Loại báo cáo";
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(174)))));
            this.lblStartDate.Location = new System.Drawing.Point(354, 20);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(28, 20);
            this.lblStartDate.TabIndex = 25;
            this.lblStartDate.Text = "Từ";
            // 
            // lblEndDate
            // 
            this.lblEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(174)))));
            this.lblEndDate.Location = new System.Drawing.Point(506, 20);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(37, 20);
            this.lblEndDate.TabIndex = 26;
            this.lblEndDate.Text = "Đến";
            // 
            // dtgvBaoCaoSLT
            // 
            this.dtgvBaoCaoSLT.AllowUserToAddRows = false;
            this.dtgvBaoCaoSLT.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvBaoCaoSLT.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvBaoCaoSLT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtgvBaoCaoSLT.AutoGenerateColumns = false;
            this.dtgvBaoCaoSLT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBaoCaoSLT.BackgroundColor = System.Drawing.Color.White;
            this.dtgvBaoCaoSLT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvBaoCaoSLT.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgvBaoCaoSLT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBaoCaoSLT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvBaoCaoSLT.ColumnHeadersHeight = 40;
            this.dtgvBaoCaoSLT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenThuocDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn});
            this.dtgvBaoCaoSLT.DataSource = this.modelBaoCaoThuocBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvBaoCaoSLT.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvBaoCaoSLT.DoubleBuffered = true;
            this.dtgvBaoCaoSLT.EnableHeadersVisualStyles = false;
            this.dtgvBaoCaoSLT.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.dtgvBaoCaoSLT.HeaderForeColor = System.Drawing.Color.White;
            this.dtgvBaoCaoSLT.Location = new System.Drawing.Point(18, 100);
            this.dtgvBaoCaoSLT.Name = "dtgvBaoCaoSLT";
            this.dtgvBaoCaoSLT.ReadOnly = true;
            this.dtgvBaoCaoSLT.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvBaoCaoSLT.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtgvBaoCaoSLT.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvBaoCaoSLT.RowTemplate.DividerHeight = 1;
            this.dtgvBaoCaoSLT.RowTemplate.Height = 30;
            this.dtgvBaoCaoSLT.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvBaoCaoSLT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvBaoCaoSLT.Size = new System.Drawing.Size(971, 580);
            this.dtgvBaoCaoSLT.TabIndex = 27;
            // 
            // tenThuocDataGridViewTextBoxColumn
            // 
            this.tenThuocDataGridViewTextBoxColumn.DataPropertyName = "TenThuoc";
            this.tenThuocDataGridViewTextBoxColumn.HeaderText = "Tên thuốc";
            this.tenThuocDataGridViewTextBoxColumn.Name = "tenThuocDataGridViewTextBoxColumn";
            this.tenThuocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtgvBaoCaoDT
            // 
            this.dtgvBaoCaoDT.AllowUserToAddRows = false;
            this.dtgvBaoCaoDT.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dtgvBaoCaoDT.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvBaoCaoDT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtgvBaoCaoDT.AutoGenerateColumns = false;
            this.dtgvBaoCaoDT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBaoCaoDT.BackgroundColor = System.Drawing.Color.White;
            this.dtgvBaoCaoDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvBaoCaoDT.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgvBaoCaoDT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBaoCaoDT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvBaoCaoDT.ColumnHeadersHeight = 40;
            this.dtgvBaoCaoDT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ngayKhamDataGridViewTextBoxColumn,
            this.Column1,
            this.tongTienDataGridViewTextBoxColumn});
            this.dtgvBaoCaoDT.DataSource = this.modelBaoCaoDoanhThuBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvBaoCaoDT.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvBaoCaoDT.DoubleBuffered = true;
            this.dtgvBaoCaoDT.EnableHeadersVisualStyles = false;
            this.dtgvBaoCaoDT.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.dtgvBaoCaoDT.HeaderForeColor = System.Drawing.Color.White;
            this.dtgvBaoCaoDT.Location = new System.Drawing.Point(18, 100);
            this.dtgvBaoCaoDT.Name = "dtgvBaoCaoDT";
            this.dtgvBaoCaoDT.ReadOnly = true;
            this.dtgvBaoCaoDT.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvBaoCaoDT.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtgvBaoCaoDT.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvBaoCaoDT.RowTemplate.DividerHeight = 1;
            this.dtgvBaoCaoDT.RowTemplate.Height = 30;
            this.dtgvBaoCaoDT.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvBaoCaoDT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvBaoCaoDT.Size = new System.Drawing.Size(971, 580);
            this.dtgvBaoCaoDT.TabIndex = 28;
            // 
            // ngayKhamDataGridViewTextBoxColumn
            // 
            this.ngayKhamDataGridViewTextBoxColumn.DataPropertyName = "NgayKham";
            this.ngayKhamDataGridViewTextBoxColumn.HeaderText = "Ngày khám";
            this.ngayKhamDataGridViewTextBoxColumn.Name = "ngayKhamDataGridViewTextBoxColumn";
            this.ngayKhamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "STT";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // tongTienDataGridViewTextBoxColumn
            // 
            this.tongTienDataGridViewTextBoxColumn.DataPropertyName = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.HeaderText = "Tổng tiền";
            this.tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            this.tongTienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // XemBaoCaoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblLoaiBaoCao);
            this.Controls.Add(this.txtTongDoanhThu);
            this.Controls.Add(this.lbTongDoanhThu);
            this.Controls.Add(this.btnXemBaoCao);
            this.Controls.Add(this.cbBaoCao);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.dtgvBaoCaoSLT);
            this.Controls.Add(this.dtgvBaoCaoDT);
            this.Name = "XemBaoCaoUC";
            this.Size = new System.Drawing.Size(1007, 823);
            this.Load += new System.EventHandler(this.XemBaoCaoUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modelBaoCaoDoanhThuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBaoCaoThuocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBaoCaoSLT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBaoCaoDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn maDonThuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource modelBaoCaoDoanhThuBindingSource;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.ComboBox cbBaoCao;
        private System.Windows.Forms.Button btnXemBaoCao;
        private System.Windows.Forms.Label lbTongDoanhThu;
        private System.Windows.Forms.BindingSource modelBaoCaoThuocBindingSource;
        private System.Windows.Forms.TextBox txtTongDoanhThu;
        private System.Windows.Forms.Label lblLoaiBaoCao;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgvBaoCaoSLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenThuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgvBaoCaoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
    }
}
