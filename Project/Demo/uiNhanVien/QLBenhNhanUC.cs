using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAO.UnitOfWork;
using DTO;
using BUS.Services;

namespace uiNhanVien
{
    public partial class QLBenhNhanUC : UserControl
    {
        public QLBenhNhanUC()
        {
            InitializeComponent();
        }
        BenhNhanServices benhNhanServices = new BenhNhanServices(new UnitOfWork(new QuanLyPhongMachEntities()));
        private void btnThem_Click(object sender, EventArgs e)
        {
            BenhNhan bn = new BenhNhan();
            bn.HoTen = txtHoTen.Text;
            bn.GioiTinh = cbGioiTinh.Text;
            bn.NgaySinh = Convert.ToDateTime(dtpNgaySinh.Text);
            bn.DiaChi = txtDiaChi.Text;
            benhNhanServices.Insert(bn);
            benhNhanBindingSource.DataSource = benhNhanServices.GetAll();
            MessageBox.Show("Thêm bệnh nhân thành công");
        }

        private void QLBenhNhanUC_Load(object sender, EventArgs e)
        {
            benhNhanBindingSource.DataSource = benhNhanServices.GetAll();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (benhNhanBindingSource.Current == null)
                return;
            if(MessageBox.Show("Xác nhận xóa bệnh nhân?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            { BenhNhan bn = benhNhanBindingSource.Current as BenhNhan;
            benhNhanServices.Delete(bn);
            benhNhanBindingSource.DataSource = benhNhanServices.GetAll();}
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            BenhNhan bn = new BenhNhan();
            bn.MaBenhNhan = Int32.Parse(txtMaBN.Text);
            bn.HoTen = txtHoTen.Text;
            bn.GioiTinh = cbGioiTinh.Text;
            bn.NgaySinh = Convert.ToDateTime(dtpNgaySinh.Text);
            bn.DiaChi = txtDiaChi.Text;
            benhNhanServices.Update(bn);
            benhNhanBindingSource.DataSource = benhNhanServices.GetAll();
            MessageBox.Show("Sửa thông tin bệnh nhân thành công.");
        }

        

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            BenhNhan bn = benhNhanBindingSource.Current as BenhNhan;
            txtHoTen.Text = bn.HoTen;
            txtMaBN.Text = bn.MaBenhNhan.ToString();
            txtDiaChi.Text = bn.DiaChi;
            cbGioiTinh.Text = bn.GioiTinh;
            dtpNgaySinh.Value = bn.NgaySinh;
        }
    }
}
