
using DAO.Interface;
using DTO;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Repository
{
    public class ChiTietDonThuocRepository : Repository<ChiTietDonThuoc> , IChiTietDonThuocRepository
    {
        public ChiTietDonThuocRepository(QuanLyPhongMachEntities context) : base(context)
        {

        }
        public QuanLyPhongMachEntities context
        {
            get { return Context as QuanLyPhongMachEntities; }
        }

        public IEnumerable<ModelChiTietDonThuoc> GetModelByIdPhieuKham(int id)
        {
            var model = from t in context.Thuocs
                        join ctdt in context.ChiTietDonThuocs
                        on t.MaThuoc equals ctdt.MaThuoc
                        join dt in context.DonThuocs
                        on ctdt.MaDonThuoc equals dt.MaDonThuoc
                        join pk in context.PhieuKhams
                        on dt.MaPhieuKham equals pk.MaPhieuKham
                        where pk.MaPhieuKham == id
                        select new ModelChiTietDonThuoc
                        {
                            TenThuoc = t.TenThuoc,
                            SoLuong = ctdt.SoLuong.Value,
                            CachDung = ctdt.CachDung,
                            DonGia = t.DonGia.Value,
                            ThanhTien = ctdt.ThanhTien,
                            MaThuoc = t.MaThuoc,
                            DonVi = t.DonVi
                        };
            return model.ToList();
            
        }
    }
}
