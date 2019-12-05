using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS.Services;
using DAO.UnitOfWork;
using DTO;

namespace Demo.uiNhanVien
{
    public partial class QLBenhUC : UserControl
    {
        BenhServices benhServices = new BenhServices(new UnitOfWork(new QuanLyPhongMachEntities()));
        public QLBenhUC()
        {
            InitializeComponent();
        }

        private void QLBenhUC_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            benhBindingSource.DataSource = benhServices.Find(b=>b.TrangThai == 1).ToList();;
        }

        private void dtgvBenh_CurrentCellChanged(object sender, EventArgs e)
        {
            Benh benh = benhBindingSource.Current as Benh;
            if (benh != null)
            {
                txtTenBenh.Text = benh.TenBenh;
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            var list = benhServices.Find(b=>b.TrangThai == 1).ToList();;
            //IEnumerable<Benh> list = null;
            if (!String.IsNullOrEmpty(txtTimKiem.Text))
            {
                list = benhServices.Find(b => b.TenBenh.ToLower().Contains(txtTimKiem.Text.ToLower())).ToList();
                if (list == null)
                {
                    list = null;
                }
            }
            benhBindingSource.DataSource = list;
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLoc_Click(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(benhBindingSource.Current == null)
            {
                MessageBox.Show("Vui lòng chọn loại bệnh");
            }
            else
            {
                Benh benh = benhBindingSource.Current as Benh;
                benh.TrangThai = 0;
                benhServices.Update(benh);
                MessageBox.Show("Xóa thành công");
                benhBindingSource.DataSource = benhServices.Find(b => b.TrangThai == 1).ToList();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (benhBindingSource.Current == null)
            {
                MessageBox.Show("Vui lòng chọn loại bệnh");
            }
            else
            {
                Benh benh = new Benh();
                benh.TrangThai = 1;
                benh.TenBenh = txtTenBenh.Text;
                benh.MaBenh = Int32.Parse(dtgvBenh.CurrentRow.Cells["MaBenh"].Value.ToString());
                benhServices.Update(benh);
                MessageBox.Show("Sửa thành công");
                benhBindingSource.DataSource = benhServices.Find(b => b.TrangThai == 1).ToList();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtTenBenh.Text == null)
            {
                MessageBox.Show("Vui lòng nhập tên bệnh.");
            }
            else
            {
                Benh benh = new Benh();
                benh.TenBenh = txtTenBenh.Text;
                benh.TrangThai = 1;
                benhServices.Insert(benh);
                MessageBox.Show("Thêm bệnh thành công");
                benhBindingSource.DataSource = benhServices.Find(b => b.TrangThai == 1).ToList();
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtTenBenh.Clear();
        }
    }
}
