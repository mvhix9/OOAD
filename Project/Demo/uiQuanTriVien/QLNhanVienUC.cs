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
using Common;

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
            nhanVienBindingSource.DataSource = nhanVienServices.Find(nv => nv.MaNhanVien != UserCache.Id).ToList();
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

        private void dtgvPhieuKham_CurrentCellChanged(object sender, EventArgs e)
        {
            NhanVien nv = nhanVienBindingSource.Current as NhanVien;
            txtHoTen.Text = nv.HoTen;
            cbGioiTinh.Text = nv.GioiTinh;
            dtpNgaySinh.Value = (DateTime)nv.NgaySinh;
            cbVaiTro.SelectedValue = nv.MaVaiTro;
            txtDiaChi.Text = nv.DiaChi;
        }
        
        private bool validInfo()
        {
            bool check = true;
            if (ValidateInput.isEmpty(txtHoTen))
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
            return check;
        }

        private string autoCreateUsername(int roleId, int newestUserId)
        {
            string username = "";
            switch (roleId)
            {
                case 1:
                    username = "nhanvien" + newestUserId;
                    break;
                case 2:
                    username = "bacsi" + newestUserId;
                    break;
            }
            return username;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (validInfo())
            {
                NhanVien nv = new NhanVien();
                nv.MaVaiTro = Int32.Parse(cbVaiTro.SelectedValue.ToString());
                nv.HoTen = txtHoTen.Text;
                nv.GioiTinh = cbGioiTinh.Text;
                nv.NgaySinh = dtpNgaySinh.Value;
                nv.DiaChi = txtDiaChi.Text;
                nv.TenDangNhap = "user";
                nv.MatKhau = HashPassword.ComputeSha256Hash("123456");
                nhanVienServices.Insert(nv);

                // update TenDangNhap
                NhanVien updateNV = nhanVienServices.GetById(nv.MaNhanVien);
                updateNV.TenDangNhap = autoCreateUsername(nv.MaVaiTro, nv.MaNhanVien);
                nhanVienServices.Update(updateNV);
                MessageBox.Show("Thêm nhân viên mới thành công");
                nhanVienBindingSource.DataSource = nhanVienServices.Find(n => n.MaNhanVien != UserCache.Id).ToList();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (nhanVienBindingSource.Current == null)
                return;

            if (MessageBox.Show("Xác nhận xóa Nhân Viên?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NhanVien nv = nhanVienBindingSource.Current as NhanVien;
                nhanVienServices.Delete(nv);
                nhanVienBindingSource.DataSource = nhanVienServices.Find(n => n.MaNhanVien != UserCache.Id).ToList();
                MessageBox.Show("Xoá nhân viên thành công");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (validInfo())
            {
                NhanVien nv = nhanVienBindingSource.Current as NhanVien;
                nv.MaVaiTro = Int32.Parse(cbVaiTro.SelectedValue.ToString());
                nv.HoTen = txtHoTen.Text;
                nv.GioiTinh = cbGioiTinh.Text;
                nv.NgaySinh = dtpNgaySinh.Value;
                nv.DiaChi = txtDiaChi.Text;
                nv.TenDangNhap = autoCreateUsername(nv.MaVaiTro, nv.MaNhanVien);
                nhanVienServices.Update(nv);
                MessageBox.Show("Sửa thông tin nhân viên thành công");
                nhanVienBindingSource.DataSource = nhanVienServices.Find(n => n.MaNhanVien != UserCache.Id).ToList();
            }
        }
    }
}
