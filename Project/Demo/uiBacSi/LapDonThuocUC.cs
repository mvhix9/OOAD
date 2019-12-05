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
using System.Text.RegularExpressions;
using DTO.Models;
using Common;

namespace uiBacSi
{
    public partial class LapDonThuocUC : UserControl
    {
        public LapDonThuocUC()
        {
            InitializeComponent();
        }
        PhieuKhamServices phieuKhamServices = new PhieuKhamServices(new UnitOfWork(new QuanLyPhongMachEntities()));
        ChiTietDonThuocServices chiTietDonThuocServices = new ChiTietDonThuocServices(new UnitOfWork(new QuanLyPhongMachEntities()));
        ThuocServices thuocServices = new ThuocServices(new UnitOfWork(new QuanLyPhongMachEntities()));
        DonThuocServices donThuocServices = new DonThuocServices(new UnitOfWork(new QuanLyPhongMachEntities()));
        private void LapDonThuocUC_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            modelPhieuKhamBindingSource.DataSource = phieuKhamServices.GetModelCompletedByIdDoctor(UserCache.Id);
            thuocBindingSource.DataSource = thuocServices.Find(t => t.TrangThai.Equals(1)).ToList();
        }

        bool CheckTextBox()
        {
            
            if(cbThuoc.Text == null)
            {
                MessageBox.Show("Vui lòng chọn thuốc.");
                return false;
            }
            else if(Int32.Parse(txtSoLuongTon.Text.ToString()) == 0)
            {
                MessageBox.Show("Thuốc trong kho đã hết.");
                return false;
            }
            else if(txtSoLuong.Text == null)
            {
                MessageBox.Show("Vui lòng chọn số lượng");
                txtSoLuong.Focus();
                return false;
            }
            else if(!Regex.IsMatch(txtSoLuong.Text , "^[0-9]+$" ))
            {
                MessageBox.Show("Chỉ được nhập số ở Số Lượng");
                txtSoLuong.Focus();
                return false;
            }
            else if(txtCachDung.Text == null)
            {
                MessageBox.Show("Vui lòng nhập cách dùng");
                txtCachDung.Focus();
                return false;
            }
            else if(Int32.Parse(txtSoLuongTon.Text) < Int32.Parse(txtSoLuong.Text))
            {
                MessageBox.Show("Số lượng thuốc không đủ");
                return false;
            }
            return true;
        }

        private void caculateTotal()
        {
            double tongTien = 0;
            foreach (DataGridViewRow row in dtgvChiTietDT.Rows)
            {
                tongTien += Double.Parse(row.Cells["ThanhTien"].Value.ToString());
            }
            txtTongTien.Text = tongTien.ToString();
            txtTongTien.TextAlign = HorizontalAlignment.Right;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dtgvPhieuKham.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu khám.");
                return;
            }
            if (CheckTextBox() == true)
            {
                string tenthuoc = cbThuoc.Text;
                int mathuoc = Int32.Parse(cbThuoc.SelectedValue.ToString());
                string cachdung = txtCachDung.Text;
                double dongia = thuocServices.GetPriceById(mathuoc);
                int soluong = Int32.Parse(txtSoLuong.Text.ToString());
                double thanhtien = dongia * soluong;
                string donvi = thuocServices.GetById(mathuoc).DonVi;
                dtgvChiTietDT.Rows.Add(mathuoc, tenthuoc, soluong, donvi, cachdung, dongia, thanhtien);
                caculateTotal();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dtgvChiTietDT.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn chi tiết đơn thuốc");
                return;
            }
            dtgvChiTietDT.Rows.RemoveAt(dtgvChiTietDT.CurrentRow.Index);
            caculateTotal();
            MessageBox.Show("Xóa thành công");
        }

        private void btnLuuDonThuoc_Click(object sender, EventArgs e)
        {
            if(dtgvPhieuKham.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu khám.");
                txtTongTien.Text= "";
                return;
            }

            if (dtgvChiTietDT.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm thuốc trước khi lưu đơn thuốc");
                return;
            }
            else
            {
                //Cập nhật trạng thái phiếu khám
                int id = Int32.Parse(dtgvPhieuKham.CurrentRow.Cells[0].Value.ToString());
                PhieuKham pk = phieuKhamServices.GetById(id);
                pk.TrangThai = "Đã lập đơn thuốc";
                phieuKhamServices.Update(pk);

                //Tạo đơn thuốc mới
                DonThuoc donthuoc = new DonThuoc();
                donthuoc.MaPhieuKham = Int32.Parse(dtgvPhieuKham.CurrentRow.Cells[0].Value.ToString());
                donThuocServices.Insert(donthuoc);

                //Tạo chi tiết đơn thuốc
                double tongTien = 0;
                foreach (DataGridViewRow row in dtgvChiTietDT.Rows)
                {
                    ChiTietDonThuoc ctdt = new ChiTietDonThuoc();
                    ctdt.MaDonThuoc = donthuoc.MaDonThuoc;
                    ctdt.MaThuoc = Int32.Parse(row.Cells["MaThuoc"].Value.ToString());
                    ctdt.SoLuong = Int32.Parse(row.Cells["SoLuong"].Value.ToString());
                    ctdt.ThanhTien = Double.Parse(row.Cells["ThanhTien"].Value.ToString());
                    ctdt.CachDung = row.Cells["CachDung"].Value.ToString();
                    chiTietDonThuocServices.Insert(ctdt);
                    tongTien += Int32.Parse(ctdt.ThanhTien.ToString());

                    //Cập nhật số lượng tồn cho thuốc
                    Thuoc t = thuocServices.GetById(ctdt.MaThuoc);
                    t.SoLuongTon -= ctdt.SoLuong;
                    thuocServices.Update(t);
                }

                //Cập nhật tổng tiền cho đơn thuốc
                donthuoc.TongTien = tongTien;
                donThuocServices.Update(donthuoc);

                thuocBindingSource.DataSource = thuocServices.GetAll();
                modelPhieuKhamBindingSource.DataSource = phieuKhamServices.GetModelCompletedByIdDoctor(UserCache.Id);
                dtgvChiTietDT.Rows.Clear();
                dtgvChiTietDT.Refresh();
                MessageBox.Show("Lập đơn thuốc thành công");
            }
        }

        private void dtgvPhieuKham_CurrentCellChanged(object sender, EventArgs e)
        {
            dtgvChiTietDT.Rows.Clear();
            if (radDaLapDonThuoc.Checked == false)
            {
                return;
            }
            if (dtgvPhieuKham.CurrentRow != null)
            {
                int maPK = Int32.Parse(dtgvPhieuKham.CurrentRow.Cells[0].Value.ToString());
                IEnumerable<ModelChiTietDonThuoc> models = chiTietDonThuocServices.GetModelByIdPhieuKham(maPK);
                double? total = 0;
                foreach (ModelChiTietDonThuoc model in models)
                {
                    total += model.ThanhTien;
                    dtgvChiTietDT.Rows.Add(model.MaThuoc.ToString(), model.TenThuoc.ToString(), 
                        model.SoLuong.ToString(), model.DonVi.ToString(), model.CachDung.ToString(), model.DonGia.ToString(), model.ThanhTien.ToString());
                }
                txtTongTien.Text = total.ToString();
                txtTongTien.TextAlign = HorizontalAlignment.Right;
            }
        }

        private void radChuaLapDonThuoc_CheckedChanged(object sender, EventArgs e)
        {
            txtTongTien.Clear();
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    modelPhieuKhamBindingSource.DataSource = phieuKhamServices.GetModelCompletedByIdDoctor(UserCache.Id);
                    btnThem.Enabled = true;
                    btnXoa.Enabled = true;
                    btnLuuDonThuoc.Enabled = true;
                }
            }
        }

        private void radDaLapDonThuoc_CheckedChanged(object sender, EventArgs e)
        {
            txtTongTien.Clear();
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    modelPhieuKhamBindingSource.DataSource = phieuKhamServices.GetModelHasDonThuocByIdDoctor(UserCache.Id);
                    btnThem.Enabled = false;
                    btnXoa.Enabled = false;
                    btnLuuDonThuoc.Enabled = false;
                }
            }
        }
    }
}
