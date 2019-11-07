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
    public class PhieuKhamRepository : Repository<PhieuKham> , IPhieuKhamRepository
    {
        public PhieuKhamRepository(QuanLyPhongMachEntities context) : base(context)
        {

        }
        public QuanLyPhongMachEntities context
        {
            get { return Context as QuanLyPhongMachEntities; }
        }

        public IEnumerable<ModelPhieuKham> GetModel()
        {
            var model = from m in context.PhieuKhams
                        join n in context.NhanViens
                        on m.MaNhanVien equals n.MaNhanVien
                        join b in context.BenhNhans
                        on m.MaBenhNhan equals b.MaBenhNhan
                        select new ModelPhieuKham
                        {
                            MaPhieuKham = m.MaPhieuKham,
                            MaNhanVien = n.MaNhanVien,
                            MaBenhNhan = b.MaBenhNhan,
                            TenNV = n.HoTen,
                            TenBN = b.HoTen,
                            TrieuChung = m.TrieuChung,
                            NgayKham = m.NgayKham
                        };
            return model.ToList();
        }

        
    }
}
