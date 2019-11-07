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
            thuocBindingSource.DataSource = thuocServices.GetAll();
            thuocBindingSource1.DataSource = thuocServices.GetAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckTxtBox() == true)
            {
                Thuoc t = new Thuoc();
                t.TenThuoc = txtTenThuoc.Text;
                t.DonGia = Int32.Parse(txtDonGia.Text);
                thuocServices.Insert(t);
                dataGridView1.DataSource = thuocServices.GetAll();
            }
        }
        bool CheckTxtBox()
        {
            if (txtTenThuoc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên thuốc ?");
                txtTenThuoc.Focus();
                return false;
            }
            if (txtDonGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đơn giá ?");
                txtDonGia.Focus();
                return false;
            }
            return true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckTxtBox() == true)
            {
                Thuoc t = new Thuoc();
                t.MaThuoc = Int32.Parse(txtMaThuoc.Text);
                t.TenThuoc = txtTenThuoc.Text;
                t.DonGia = Int32.Parse(txtDonGia.Text);
                thuocServices.Update(t);
                thuocBindingSource.DataSource = thuocServices.GetAll();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (thuocBindingSource.Current == null)
                return;
            if (MessageBox.Show("Xác nhận xóa thuốc.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Thuoc t = new Thuoc();
                t = thuocBindingSource.Current as Thuoc;
                thuocServices.Delete(t);
                thuocBindingSource.DataSource = thuocServices.GetAll();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            thuocBindingSource.DataSource = thuocServices.GetByName(txtTimKiem.Text);
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            Thuoc t = thuocBindingSource.Current as Thuoc;
            txtTenThuoc.Text = t.TenThuoc;
            txtMaThuoc.Text = t.MaThuoc.ToString();
            txtDonGia.Text = t.DonGia.ToString();

        }
    }
}
