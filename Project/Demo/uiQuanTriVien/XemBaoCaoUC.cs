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
using BUS.Interface;
using DAO.UnitOfWork;
using DTO;
using DTO.Models;

namespace uiQuanTriVien
{
    public partial class XemBaoCaoUC : UserControl
    {
        public XemBaoCaoUC()
        {
            InitializeComponent();
        }
        IBaoCaoServices baoCaoServices = new BaoCaoServices(new UnitOfWork(new QuanLyPhongMachEntities()));
        private void XemBaoCaoUC_Load(object sender, EventArgs e)
        {
            cbBaoCao.SelectedIndex = 0;
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            DateTime start = Convert.ToDateTime(dtpStart.Text.ToString());
            DateTime end = Convert.ToDateTime(dtpEnd.Text.ToString());
            string choice = cbBaoCao.SelectedItem.ToString();
            if (choice == "Doanh Thu" )
            {
                dataGridView2.Visible = false;
                dataGridView1.Visible = true;
                modelBaoCaoDoanhThuBindingSource.DataSource = baoCaoServices.GetModelDoanhThu(start, end);

                double? TongDoanhThu = 0;
                foreach(ModelBaoCaoDoanhThu baocao in baoCaoServices.GetModelDoanhThu(start, end))
                {
                    TongDoanhThu += baocao.TongTien;
                }

                lbTongDoanhThu.Visible = true;
                txtTongDoanhThu.Visible = true;
                txtTongDoanhThu.Text = TongDoanhThu.ToString();
            }
            if(choice == "Thuốc")
            {
                dataGridView1.Visible = false;
                dataGridView2.Visible = true;
                modelBaoCaoThuocBindingSource.DataSource = baoCaoServices.GetModelThuoc(start, end);
                lbTongDoanhThu.Visible = false;
                txtTongDoanhThu.Visible = false;
            }
        }
    }
}
