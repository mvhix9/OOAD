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
using DTO;
using DAO.UnitOfWork;
using DAO;
using System.Data.SqlClient;
using BUS;

namespace Demo.uiNhanVien
{
    public partial class NhanVienLapPhieuKhamUC : UserControl
    {
        public NhanVienLapPhieuKhamUC()
        {
            InitializeComponent();
        }
        BenhNhanServices benhNhanServices = new BenhNhanServices(new UnitOfWork(new QuanLyPhongMachEntities()));
        PhieuKhamServices phieuKhamServices = new PhieuKhamServices(new UnitOfWork(new QuanLyPhongMachEntities()));
        NhanVienServices nhanVienServices = new NhanVienServices(new UnitOfWork(new QuanLyPhongMachEntities()));
        private void LapPhieuKhamUC_Load(object sender, EventArgs e)
        {
            benhNhanBindingSource.DataSource = benhNhanServices.GetAll();
            nhanVienBindingSource.DataSource = nhanVienServices.GetDoctor;
            modelPhieuKhamBindingSource.DataSource = phieuKhamServices.GetModel();
        }

        private void btnThemPhieuKham_Click(object sender, EventArgs e)
        {
            if(txtMaBN.Text == null)
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân.");
                return;
            }
            if(txtMaBacSi.Text == null)
            {
                MessageBox.Show("Vui lòng chọn bác sĩ.");
                return;
            }
            PhieuKham pk = new PhieuKham();
            pk.MaBenhNhan = Int32.Parse(txtMaBN.Text);
            pk.MaNhanVien = Int32.Parse(txtMaBacSi.Text);
            pk.NgayKham = DateTime.Now;
            pk.TrangThai = "Đã lập";
            phieuKhamServices.Insert(pk);
            MessageBox.Show("Tạo phiếu khám thành công.");
            modelPhieuKhamBindingSource.DataSource = phieuKhamServices.GetModel();
        }

        private void btnSuaPhieuKham_Click(object sender, EventArgs e)
        {
            if (modelPhieuKhamBindingSource.Current == null)
                return;
            PhieuKham pk = new PhieuKham();
            pk.MaPhieuKham = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            pk.MaNhanVien = Int32.Parse(txtMaBacSi.Text);
            pk.MaBenhNhan = Int32.Parse(txtMaBN.Text);
            pk.NgayKham = DateTime.Now;
            pk.TrangThai = "Đã lập";
            phieuKhamServices.Update(pk);
            MessageBox.Show("Sửa phiếu khám thành công.");
            modelPhieuKhamBindingSource.DataSource = phieuKhamServices.GetModel();
        }
    }
}
