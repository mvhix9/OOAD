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


namespace uiBacSi
{
    public partial class BacSiLapPhieuKhamUC : UserControl
    {

        public BacSiLapPhieuKhamUC()
        {
            InitializeComponent();
        }
        PhieuKhamServices phieuKhamServices = new PhieuKhamServices(new UnitOfWork(new QuanLyPhongMachEntities()));
        BenhServices benhServices = new BenhServices(new UnitOfWork(new QuanLyPhongMachEntities()));
        ChiTietBenhServices chiTietBenhServices = new ChiTietBenhServices(new UnitOfWork(new QuanLyPhongMachEntities()));
        private void btnThemLoaiBenh_Click(object sender, EventArgs e)
        {
            //Chi Them Vao datagirdView
            if (listBenh.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn bệnh");
                return;
            }
            if(dataGridViewPhieuKham.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân");
                return;
            }
            
            foreach(Benh selecteditem in listBenh.SelectedItems)
            {
                if(CheckDiseaseName(selecteditem.TenBenh.ToString()))
                {
                    MessageBox.Show(selecteditem.MaBenh.ToString());
                    dataGridViewChiTietBenh.Rows.Add(selecteditem.TenBenh,selecteditem.MaBenh);
                }
            }
            listBenh.ClearSelected();
            MessageBox.Show("Thêm chi tiết bệnh thành công.");
        }
        bool CheckDiseaseName(string tenbenh)
        {
            foreach(DataGridViewRow row in dataGridViewChiTietBenh.Rows)
            {
                if (row.Cells[0].Value.ToString() == tenbenh)
                    return false;
            }
            return true;
        }

        private void btnXoaLoaiBenh_Click(object sender, EventArgs e)
        {
            //Chi Xoa o Datgirdview
            if (dataGridViewPhieuKham.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân");
                return;
            }
           
            if (dataGridViewChiTietBenh.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn bệnh");
                return;
            }
            //Them DeleteRange
            //ChiTietBenh ctb = new ChiTietBenh();
            //ctb.MaBenh = Int32.Parse(dataGridViewChiTietBenh.CurrentRow.Cells[1].Value.ToString());
            //ctb.MaPhieuKham = Int32.Parse(dataGridViewPhieuKham.CurrentRow.Cells[0].Value.ToString());
            //MessageBox.Show(ctb.MaPhieuKham.ToString());
            //MessageBox.Show(ctb.MaBenh.ToString());
            //chiTietBenhServices.Delete(ctb);
            foreach (DataGridViewRow item in dataGridViewChiTietBenh.SelectedRows)
            {
                dataGridViewChiTietBenh.Rows.RemoveAt(item.Index);
            }
            MessageBox.Show("Xóa thành công");
        }

        private void btnLuuPhieuKham_Click(object sender, EventArgs e)
        {
            if (dataGridViewPhieuKham.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân");
                return;
            }
            if(txtTrieuChung.Text == "")
            {
                MessageBox.Show("Vui lòng nhập triệu chứng");
                return;
            }
            PhieuKham pk = new PhieuKham();
            pk.MaPhieuKham = Int32.Parse(dataGridViewPhieuKham.CurrentRow.Cells[0].Value.ToString());
            pk.MaBenhNhan = Int32.Parse(dataGridViewPhieuKham.CurrentRow.Cells[1].Value.ToString());
            pk.MaNhanVien = Int32.Parse(dataGridViewPhieuKham.CurrentRow.Cells[2].Value.ToString());
            pk.NgayKham = Convert.ToDateTime(dataGridViewPhieuKham.CurrentRow.Cells[3].Value.ToString());
            pk.TrieuChung = txtTrieuChung.Text;
            pk.TrangThai = "Đã chẩn đoán";
            phieuKhamServices.Update(pk);
            int mapk = Int32.Parse(dataGridViewPhieuKham.CurrentRow.Cells[0].Value.ToString());
            foreach (DataGridViewRow row in dataGridViewChiTietBenh.Rows)
            {
                ChiTietBenh ctb = new ChiTietBenh();               
                int mabenh = Int32.Parse(row.Cells[1].Value.ToString());
                ctb.MaBenh = mabenh;
                ctb.MaPhieuKham = mapk;
                chiTietBenhServices.Insert(ctb);
            }
            modelPhieuKhamBindingSource.DataSource = phieuKhamServices.GetModelUncompletedByIdDoctor(2);
            MessageBox.Show("Lưu thành công");
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            //TODO
            TraCuuBenhNhan frm = new TraCuuBenhNhan();
            frm.Show();
        }

        

        private void BacSiLapPhieuKhamUC_Load(object sender, EventArgs e)
        {
            modelPhieuKhamBindingSource.DataSource = phieuKhamServices.GetModelUncompletedByIdDoctor(2);
            benhBindingSource.DataSource = benhServices.GetAll();
        }

        private void dataGridViewPhieuKham_CurrentCellChanged(object sender, EventArgs e)
        {
            dataGridViewChiTietBenh.Rows.Clear();
            if (radPKHoanThanh.Checked == true)
            {
                if (dataGridViewPhieuKham.CurrentRow != null)
                {
                    int maPK = Int32.Parse(dataGridViewPhieuKham.CurrentRow.Cells[0].Value.ToString());
                    IEnumerable<Benh> dsBenh = chiTietBenhServices.GetNameById(maPK);
                    foreach (Benh b in dsBenh)
                    {
                        dataGridViewChiTietBenh.Rows.Add(b.TenBenh.ToString(), b.MaBenh.ToString());
                    }
                }
            }
        }

        private void radPKDaLap_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    modelPhieuKhamBindingSource.DataSource = phieuKhamServices.GetModelUncompletedByIdDoctor(2);
                }
            }
        }

        private void radPKHoanThanh_CheckedChanged(object sender, EventArgs e)
        {
            
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    modelPhieuKhamBindingSource.DataSource = phieuKhamServices.GetModelCompletedByIdDoctor(2);
                }
            }
        }
    }
}
