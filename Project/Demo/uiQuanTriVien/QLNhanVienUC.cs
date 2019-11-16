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
using DTO;
using BUS.Interface;
using BUS.Services;
using DAO.UnitOfWork;

namespace uiQuanTriVien
{
    public partial class QLNhanVienUC : UserControl
    {
        NhanVienServices nhanVienServices = new NhanVienServices(new UnitOfWork(new QuanLyPhongMachEntities()));
        VaiTroServices vaiTroServices = new VaiTroServices(new UnitOfWork(new QuanLyPhongMachEntities()));
        public QLNhanVienUC()
        {
            InitializeComponent();
        }

        private void QLNhanVienUC_Load(object sender, EventArgs e)
        {
            nhanVienBindingSource.DataSource = nhanVienServices.GetAll();
            vaiTroBindingSource.DataSource = vaiTroServices.GetAll();
        }

        private void getCbVaiTroData(AutoCompleteStringCollection data)
        {
            var roles = nhanVienServices.GetRoles;
            foreach (var role in roles)
            {
                data.Add(role.MaVaiTro.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.HoTen = txtHoTen.Text;
            nv.TenDangNhap = txtTenDangNhap.Text;
            nv.MatKhau = txtMatKhau.Text;
            nv.MaVaiTro = Int32.Parse(cbVaiTro.SelectedValue.ToString());
            nv.GioiTinh = cbGioiTinh.Text;
            nv.NgaySinh = Convert.ToDateTime(dtpNgaySinh.Text);
            nv.DiaChi = txtDiaChi.Text;
            nhanVienServices.Insert(nv);
            nhanVienBindingSource.DataSource= nhanVienServices.GetAll();
            MessageBox.Show("Thanh cong");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (nhanVienBindingSource.Current == null)
                return;

            if (MessageBox.Show("Xác nhận xóa Nhân Viên?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NhanVien nv = new NhanVien();
                nv = nhanVienBindingSource.Current as NhanVien;
                nhanVienServices.Delete(nv);
                nhanVienBindingSource.DataSource = nhanVienServices.GetAll();
                MessageBox.Show("Thanh cong");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.MaNhanVien = Int32.Parse(txtMaNV.Text);
            nv.HoTen = txtHoTen.Text;
            nv.TenDangNhap = txtTenDangNhap.Text;
            nv.MatKhau = txtMatKhau.Text;
            nv.MaVaiTro = Int32.Parse(cbVaiTro.SelectedValue.ToString());
            nv.GioiTinh = cbGioiTinh.Text;
            nv.NgaySinh = Convert.ToDateTime(dtpNgaySinh.Text);
            nv.DiaChi = txtDiaChi.Text;
            nhanVienServices.Update(nv);
            nhanVienBindingSource.DataSource = nhanVienServices.GetAll();
            MessageBox.Show("Thanh cong");
        }
    }
}
