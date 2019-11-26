using BUS.Services;
using DAO.UnitOfWork;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uiBacSi
{
    public partial class TraCuuBenhNhan : Form
    {
        public TraCuuBenhNhan()
        {
            InitializeComponent();
        }
        BenhNhanServices benhNhanServices = new BenhNhanServices(new UnitOfWork(new QuanLyPhongMachEntities()));
        PhieuKhamServices phieuKhamServices = new PhieuKhamServices(new UnitOfWork(new QuanLyPhongMachEntities())); 

        private void TraCuuBenhNhan_Load(object sender, EventArgs e)
        {
            benhNhanBindingSource.DataSource = benhNhanServices.Find(b =>b.TrangThai ==1).ToList();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            modelTraCuuBenhNhanBindingSource.DataSource = phieuKhamServices.GetModelTraCuu(Int32.Parse(txtMaBN.Text),Convert.ToDateTime(dtpFrom.Text), Convert.ToDateTime(dtpTo.Text));
            //modelTraCuuBenhNhanBindingSource.DataSource = phieuKhamServices.GetChiTietBenhById(Int32.Parse(txtMaBN.Text), Convert.ToDateTime(dtpFrom.Text), Convert.ToDateTime(dtpTo.Text));

        }
    }
}
