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
        BaoCaoServices baoCaoServices = new BaoCaoServices(new UnitOfWork(new QuanLyPhongMachEntities()));

        private void XemBaoCaoUC_Load(object sender, EventArgs e)
        {
            cbBaoCao.SelectedIndex = 0;
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            DateTime start = Convert.ToDateTime(dtpStart.Text.ToString());
            DateTime end = Convert.ToDateTime(dtpEnd.Text.ToString());
            int choice = cbBaoCao.SelectedIndex;
            switch (choice)
            {
                case 1:
                    dtgvBaoCaoSLT.Visible = false;
                    dtgvBaoCaoDT.Visible = true;
                    modelBaoCaoDoanhThuBindingSource.DataSource = baoCaoServices.GetModelDoanhThu(start, end);

                    double? tongDoanhThu = 0;
                    foreach(ModelBaoCaoDoanhThu baocao in baoCaoServices.GetModelDoanhThu(start, end))
                    {
                        tongDoanhThu += baocao.TongTien;
                    }

                    lbTongDoanhThu.Visible = true;
                    txtTongDoanhThu.Visible = true;
                    txtTongDoanhThu.Text = tongDoanhThu.ToString();
                    txtTongDoanhThu.TextAlign = HorizontalAlignment.Right;
                    break;
                case 2:
                    dtgvBaoCaoDT.Visible = false;
                    dtgvBaoCaoSLT.Visible = true;
                    modelBaoCaoThuocBindingSource.DataSource = baoCaoServices.GetModelThuoc(start, end);
                    lbTongDoanhThu.Visible = false;
                    txtTongDoanhThu.Visible = false;
                    break;
                default:
                    MessageBox.Show("Hãy chọn loại báo cáo cần xem");
                    cbBaoCao.Focus();
                    break;
            }
        }

       
    }
}
