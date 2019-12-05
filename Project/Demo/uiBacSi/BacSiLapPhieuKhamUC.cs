﻿using System;
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
using Common;

namespace uiBacSi
{
    public partial class BacSiLapPhieuKhamUC : UserControl
    {
        PhieuKhamServices phieuKhamServices = new PhieuKhamServices(new UnitOfWork(new QuanLyPhongMachEntities()));
        BenhServices benhServices = new BenhServices(new UnitOfWork(new QuanLyPhongMachEntities()));
        ChiTietBenhServices chiTietBenhServices = new ChiTietBenhServices(new UnitOfWork(new QuanLyPhongMachEntities()));
        public BacSiLapPhieuKhamUC()
        {
            InitializeComponent();
        }

        private void BacSiLapPhieuKhamUC_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            modelPhieuKhamBindingSource.DataSource = phieuKhamServices.GetModelUncompletedByIdDoctor(UserCache.Id);
            benhBindingSource.DataSource = benhServices.Find(b => b.TrangThai == 1).ToList();
        }

        private void btnThemLoaiBenh_Click(object sender, EventArgs e)
        {
            //Chi Them Vao datagirdView
            if (listBenh.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn bệnh");
                return;
            }
            if(dtgvPhieuKham.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân");
                return;
            }
            
            foreach(Benh selecteditem in listBenh.SelectedItems)
            {
                if(CheckDiseaseName(selecteditem.TenBenh.ToString()))
                {
                    //MessageBox.Show(selecteditem.MaBenh.ToString());
                    dtgvChiTietBenh.Rows.Add(selecteditem.TenBenh,selecteditem.MaBenh);
                }
            }
            listBenh.ClearSelected();
            MessageBox.Show("Thêm chi tiết bệnh thành công.");
        }
        bool CheckDiseaseName(string tenbenh)
        {
            foreach(DataGridViewRow row in dtgvChiTietBenh.Rows)
            {
                if (row.Cells[0].Value.ToString() == tenbenh)
                    return false;
            }
            return true;
        }

        private void btnXoaLoaiBenh_Click(object sender, EventArgs e)
        {
            //Chi Xoa o Datgirdview
            if (dtgvPhieuKham.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân");
                return;
            }
           
            if (dtgvChiTietBenh.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn bệnh");
                return;
            }
            
            foreach (DataGridViewRow item in dtgvChiTietBenh.SelectedRows)
            {
                dtgvChiTietBenh.Rows.RemoveAt(item.Index);
            }
            MessageBox.Show("Xóa thành công");
        }

        private void btnLuuPhieuKham_Click(object sender, EventArgs e)
        {
            if (dtgvPhieuKham.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân");
                return;
            }
            if(txtTrieuChung.Text == "")
            {
                MessageBox.Show("Vui lòng nhập triệu chứng");
                return;
            }
            //PhieuKham current = modelPhieuKhamBindingSource.Current as PhieuKham;
            //Cập nhật phiếu khám
            PhieuKham pk = new PhieuKham();
            pk.MaPhieuKham = Int32.Parse(dtgvPhieuKham.CurrentRow.Cells[0].Value.ToString());
            pk.MaBenhNhan = Int32.Parse(dtgvPhieuKham.CurrentRow.Cells["MaBenhNhan"].Value.ToString());
            pk.MaNhanVien = Int32.Parse(dtgvPhieuKham.CurrentRow.Cells["MaNhanVien"].Value.ToString());
            pk.NgayKham = Convert.ToDateTime(dtgvPhieuKham.CurrentRow.Cells[5].Value.ToString());
            pk.TrieuChung = txtTrieuChung.Text;
            pk.TrangThai = "Đã chẩn đoán";
            phieuKhamServices.Update(pk);

            //Cập nhật chi tiết bệnh
            foreach (DataGridViewRow row in dtgvChiTietBenh.Rows)
            {
                ChiTietBenh ctb = new ChiTietBenh();               
                int mabenh = Int32.Parse(row.Cells["MaBenh"].Value.ToString());
                ctb.MaBenh = mabenh;
                ctb.MaPhieuKham = pk.MaPhieuKham;
                chiTietBenhServices.Insert(ctb);
            }
            modelPhieuKhamBindingSource.DataSource = phieuKhamServices.GetModelUncompletedByIdDoctor(UserCache.Id);
            MessageBox.Show("Lưu thành công");
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            TraCuuBenhNhan frm = new TraCuuBenhNhan();
            frm.Show();
        }


        private void dtgvPhieuKham_CurrentCellChanged(object sender, EventArgs e)
        {
            dtgvChiTietBenh.Rows.Clear();
            if (radPKHoanThanh.Checked == true)
            {
                if (dtgvPhieuKham.CurrentRow != null)
                {
                    int maPK = Int32.Parse(dtgvPhieuKham.CurrentRow.Cells[0].Value.ToString());
                    IEnumerable<Benh> dsBenh = chiTietBenhServices.GetNameById(maPK);
                    foreach (Benh b in dsBenh)
                    {
                        dtgvChiTietBenh.Rows.Add(b.TenBenh.ToString(), b.MaBenh.ToString());
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
                    modelPhieuKhamBindingSource.DataSource = phieuKhamServices.GetModelUncompletedByIdDoctor(UserCache.Id);
                    btnLuuPhieuKham.Enabled = true;
                    btnThemLoaiBenh.Enabled = true;
                    btnXoaLoaiBenh.Enabled = true;
                    txtTrieuChung.Enabled = true;
                    txtTrieuChung.ReadOnly = false;
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
                    modelPhieuKhamBindingSource.DataSource = phieuKhamServices.GetModelCompletedByIdDoctor(UserCache.Id);
                    btnLuuPhieuKham.Enabled = false;
                    btnThemLoaiBenh.Enabled = false;
                    btnXoaLoaiBenh.Enabled = false;
                    txtTrieuChung.Enabled = false;
                    txtTrieuChung.ReadOnly = true;
                }
            }
        }
    }
}
