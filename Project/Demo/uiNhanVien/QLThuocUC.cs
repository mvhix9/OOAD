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
using BUS.Services;
using DAO.UnitOfWork;
using Common;

namespace Demo.uiNhanVien
{
    public partial class QLThuocUC : UserControl
    {
        public QLThuocUC()
        {
            InitializeComponent();
        }
        ThuocServices thuocServices = new ThuocServices(new UnitOfWork(new QuanLyPhongMachEntities()));

        private void QLThuocUC_Load(object sender, EventArgs e)
        {
            thuocBindingSource.DataSource = thuocServices.Find(t=>t.TrangThai == 1).ToList();;
        }

        private bool validInfo()
        {
            bool check = true;
            if (ValidateInput.isEmpty(txtTenThuoc))
            {
                check = false;
                MessageBox.Show("Tên thuốc còn đang trống");
                txtTenThuoc.Focus();
            }
            else if (!ValidateInput.isNumber(txtSoLuongTon))
            {
                check = false;
                MessageBox.Show("Số lượng tồn không hợp lệ");
                txtSoLuongTon.Focus();
            }
            else if (ValidateInput.isEmpty(txtDonVi))
            {
                check = false;
                MessageBox.Show("Đơn vị còn đang trống");
                txtDonVi.Focus();
            }
            else if (!ValidateInput.isUnicode(txtDonVi))
            {
                check = false;
                MessageBox.Show("Đơn vị không hợp lệ");
                txtDonVi.Focus();
            }
            else if (!ValidateInput.isNumber(txtDonGia))
            {
                check = false;
                MessageBox.Show("Đơn giá không hợp lệ");
                txtDonGia.Focus();
            }
            return check;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (validInfo())
            {
                Thuoc t = new Thuoc();
                t.TenThuoc = txtTenThuoc.Text;
                t.SoLuongTon = Int32.Parse(txtSoLuongTon.Text);
                t.DonVi = txtDonVi.Text;
                t.DonGia = Double.Parse(txtDonGia.Text);
                thuocServices.Insert(t);
                thuocBindingSource.DataSource = thuocServices.Find(thuoc=>thuoc.TrangThai == 1).ToList();;
                MessageBox.Show("Thêm loại thuốc thành công");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (validInfo())
            {
                Thuoc t = thuocBindingSource.Current as Thuoc;
                t.TenThuoc = txtTenThuoc.Text;
                t.SoLuongTon = Int32.Parse(txtSoLuongTon.Text);
                t.DonVi = txtDonVi.Text;
                t.DonGia = Double.Parse(txtDonGia.Text);
                thuocServices.Update(t);
                thuocBindingSource.DataSource = thuocServices.Find(thuoc=>thuoc.TrangThai == 1).ToList();;
                MessageBox.Show("Sửa thông tin loại thuốc thành công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (thuocBindingSource.Current == null)
                return;
            if (MessageBox.Show("Xác nhận xóa loại thuốc ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Thuoc t = thuocBindingSource.Current as Thuoc;
                thuocServices.Delete(t);
                thuocBindingSource.DataSource = thuocServices.Find(thuoc=>thuoc.TrangThai == 1).ToList();;
            }
        }

        private void dgvThuoc_CurrentCellChanged(object sender, EventArgs e)
        {
            Thuoc t = thuocBindingSource.Current as Thuoc;
            if (t != null)
            {
                txtTenThuoc.Text = t.TenThuoc;
                txtSoLuongTon.Text = t.SoLuongTon.ToString();
                txtDonVi.Text = t.DonVi;
                txtDonGia.Text = t.DonGia.ToString();
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtTenThuoc.Clear();
            txtSoLuongTon.Clear();
            txtDonVi.Clear();
            txtDonGia.Clear();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            var list = thuocServices.Find(t=>t.TrangThai == 1).ToList();;
            if (!String.IsNullOrEmpty(txtTimKiem.Text))
            {
                list = thuocServices.Find(t => t.TenThuoc.ToLower().Contains(txtTimKiem.Text.ToLower())).ToList();
                if (list == null)
                {
                    list = null;
                }
            }
            thuocBindingSource.DataSource = list;
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
