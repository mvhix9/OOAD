using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using DAO.UnitOfWork;
using Common;
using uiNhanVien;
using uiBacSi;
using uiQuanTriVien;

namespace Demo
{
    public partial class TuyChonUC : UserControl
    {
        NhanVienServices nhanVienServices = new NhanVienServices(new UnitOfWork(new QuanLyPhongMachEntities()));

        public TuyChonUC()
        {
            InitializeComponent();
        }

        private void TuyChonUC_Load(object sender, EventArgs e)
        {
            getInfo();
        }

        private void getInfo()
        {
            NhanVien nv = nhanVienServices.GetById(UserCache.Id);
            txtTenDangNhap.Text = nv.TenDangNhap;
            txtHoTen.Text = nv.HoTen;
            cbGioiTinh.Text = nv.GioiTinh;
            dpNgaySinh.Value = (DateTime) nv.NgaySinh;
            txtDiaChi.Text = nv.DiaChi;
        }

        private void btnNhapLaiTTNV_Click(object sender, EventArgs e)
        {
            txtTenDangNhap.Clear();
            txtHoTen.Clear();
            cbGioiTinh.SelectedIndex = 0;
            dpNgaySinh.Value = DateTime.Now;
            txtDiaChi.Clear();
        }

        private bool validInfo()
        {
            bool check = true;
            if (ValidateInput.isEmpty(txtTenDangNhap))
            {
                check = false;
                MessageBox.Show("Tên đăng nhập còn đang trống");
                txtTenDangNhap.Focus();
            }
            else if (!ValidateInput.isAlphanumeric(txtTenDangNhap))
            {
                check = false;
                MessageBox.Show("Tên đăng nhập không hợp lệ");
                txtTenDangNhap.Focus();
            }
            else if (ValidateInput.isEmpty(txtHoTen))
            {
                check = false;
                MessageBox.Show("Họ và tên còn đang trống");
                txtHoTen.Focus();
            }
            else if (!ValidateInput.isUnicode(txtHoTen))
            {
                check = false;
                MessageBox.Show("Họ và tên không hợp lệ");
                txtHoTen.Focus();
            }
            else if (ValidateInput.isEmpty(txtDiaChi))
            {
                check = false;
                MessageBox.Show("Địa chỉ còn đang trống");
                txtDiaChi.Focus();
            }
            return check;
        }

        private bool validPassword()
        {
            bool check = true;
            if (ValidateInput.isEmpty(txtMKCu) || ValidateInput.isEmpty(txtMKMoi) || ValidateInput.isEmpty(txtNhapLaiMKMoi))
            {
                check = false;
                MessageBox.Show("Thông tin mật khẩu chưa được nhập đầy đủ");
                txtMKCu.Focus();
            }
            else if (!ValidateInput.isPassword(txtMKMoi))
            {
                check = false;
                MessageBox.Show("Mật khẩu phải từ 6 ký tự trở lên");
                txtMKMoi.Focus();
            }
            return check;
        }

        internal void btnDoiTTNV_Click(object sender, EventArgs e)
        {
            if (validInfo())
            {
                if (MessageBox.Show("Xác nhận đổi thông tin ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NhanVien newNV = new NhanVien();
                    NhanVien oldNV = nhanVienServices.GetById(UserCache.Id);
                    newNV.MaNhanVien = UserCache.Id;
                    newNV.MaVaiTro = oldNV.MaVaiTro;
                    newNV.HoTen = txtHoTen.Text;
                    newNV.GioiTinh = cbGioiTinh.Text;
                    newNV.NgaySinh = (DateTime)dpNgaySinh.Value;
                    newNV.DiaChi = txtDiaChi.Text;
                    newNV.TenDangNhap = txtTenDangNhap.Text;
                    newNV.MatKhau = oldNV.MatKhau;
                    nhanVienServices.Update(newNV);
                    MessageBox.Show("Đổi thông tin nhân viên thành công");
                    UserCache.Name = newNV.HoTen;
                    switch (UserCache.RoleId)
                    {
                        case 1:
                            NhanVienFRM.lblName.Text = UserCache.Name;
                            int leftNVFRM = (NhanVienFRM.lblName.Parent.Width - NhanVienFRM.lblName.Width) / 2;
                            BacSiFRM.centerLocation(NhanVienFRM.lblName, leftNVFRM, 146);
                            break;
                        case 2:
                            BacSiFRM.lblName.Text = UserCache.Name;
                            int leftBSFRM = (BacSiFRM.lblName.Parent.Width - BacSiFRM.lblName.Width) / 2;
                            BacSiFRM.centerLocation(BacSiFRM.lblName, leftBSFRM, 146);
                            break;
                        case 3:
                            QuanTriVienFRM.lblName.Text = UserCache.Name;
                            int leftQTVFRM = (QuanTriVienFRM.lblName.Parent.Width - QuanTriVienFRM.lblName.Width) / 2;
                            QuanTriVienFRM.centerLocation(QuanTriVienFRM.lblName, leftQTVFRM, 146);
                            break;
                    }
                }
            }
        }

        private void btnDoiMKNV_Click(object sender, EventArgs e)
        {
            if (validPassword())
            {
                if (MessageBox.Show("Xác nhận đổi mật khẩu ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txtNhapLaiMKMoi.Text == txtMKMoi.Text)
                    {
                        NhanVien newNV = new NhanVien();
                        NhanVien oldNV = nhanVienServices.GetById(UserCache.Id);
                        string oldPassword = HashPassword.ComputeSha256Hash(txtMKCu.Text);
                        if (HashPassword.CompareHash(oldPassword, oldNV.MatKhau))
                        {
                            newNV.MaNhanVien = UserCache.Id;
                            newNV.MaVaiTro = oldNV.MaVaiTro;
                            newNV.HoTen = txtHoTen.Text;
                            newNV.GioiTinh = cbGioiTinh.Text;
                            newNV.NgaySinh = (DateTime)dpNgaySinh.Value;
                            newNV.DiaChi = txtDiaChi.Text;
                            newNV.TenDangNhap = txtTenDangNhap.Text;
                            newNV.MatKhau = HashPassword.ComputeSha256Hash(txtMKMoi.Text);
                            nhanVienServices.Update(newNV);
                            MessageBox.Show("Đổi mật khẩu nhân viên thành công");
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu cũ không đúng");
                            txtMKCu.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không trùng khớp");
                        txtMKMoi.Focus();
                    }
                }
            }
        }

        private void btnNhapLaiMKNV_Click(object sender, EventArgs e)
        {
            txtMKCu.Clear();
            txtMKMoi.Clear();
            txtNhapLaiMKMoi.Clear();
        }
    }
}
