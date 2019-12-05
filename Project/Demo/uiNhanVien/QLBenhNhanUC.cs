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
using Common;

namespace uiNhanVien
{
    public partial class QLBenhNhanUC : UserControl
    {
        BenhNhanServices benhNhanServices = new BenhNhanServices(new UnitOfWork(new QuanLyPhongMachEntities()));

        public QLBenhNhanUC()
        {
            InitializeComponent();
        }

        private void QLBenhNhanUC_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            benhNhanBindingSource.DataSource = benhNhanServices.Find(bn => bn.TrangThai==1).ToList();
            
        }

        private bool validInfo()
        {
            bool check = true;
            if (ValidateInput.isEmpty(txtHoTen))
            {
                check = false;
                MessageBox.Show("Họ và tên còn trống");
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (validInfo())
            {
                BenhNhan bn = new BenhNhan();
                bn.HoTen = txtHoTen.Text;
                bn.GioiTinh = cbGioiTinh.Text;
                bn.NgaySinh = Convert.ToDateTime(dtpNgaySinh.Text);
                bn.DiaChi = txtDiaChi.Text;
                bn.TrangThai = 1;
                benhNhanServices.Insert(bn);
                benhNhanBindingSource.DataSource = benhNhanServices.Find(benhnhan =>benhnhan.TrangThai ==1).ToList();
                MessageBox.Show("Thêm bệnh nhân thành công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (benhNhanBindingSource.Current == null)
                return;
            if (MessageBox.Show("Xác nhận xóa bệnh nhân ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BenhNhan bn = benhNhanBindingSource.Current as BenhNhan;
                bn.TrangThai = 0;
                benhNhanServices.Update(bn);
                benhNhanBindingSource.DataSource = benhNhanServices.Find(benhnhan => benhnhan.TrangThai == 1).ToList();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (validInfo())
            {
                BenhNhan bn = benhNhanBindingSource.Current as BenhNhan;
                bn.HoTen = txtHoTen.Text;
                bn.GioiTinh = cbGioiTinh.Text;
                bn.NgaySinh = Convert.ToDateTime(dtpNgaySinh.Text);
                bn.DiaChi = txtDiaChi.Text;
                bn.TrangThai = 1;
                benhNhanServices.Update(bn);
                benhNhanBindingSource.DataSource = benhNhanServices.Find(benhnhan=> benhnhan.TrangThai==1).ToList();
                MessageBox.Show("Sửa thông tin bệnh nhân thành công");
            }
        }

        private void dgvBenhNhan_CurrentCellChanged(object sender, EventArgs e)
        {
            BenhNhan bn = benhNhanBindingSource.Current as BenhNhan;
            if (bn != null)
            {
                txtHoTen.Text = bn.HoTen;
                txtDiaChi.Text = bn.DiaChi;
                cbGioiTinh.Text = bn.GioiTinh;
                dtpNgaySinh.Value = (DateTime)bn.NgaySinh;
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtDiaChi.Clear();
            cbGioiTinh.SelectedIndex = 0;
            dtpNgaySinh.Value = DateTime.Now;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            var list = benhNhanServices.Find(bn => bn.TrangThai == 1).ToList();
            if (!String.IsNullOrEmpty(txtTimKiem.Text))
            {
                list = benhNhanServices.Find(b => b.HoTen.ToLower().Contains(txtTimKiem.Text.ToLower())).ToList();
                if (list == null)
                {
                    list = null;
                }
            }
            benhNhanBindingSource.DataSource = list;
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLoc_Click(sender, e);
            }
        }
    }
}