using DAO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Models;
using DTO;
using System.Data.Entity;

namespace DAO.Repository
{
    public class BaoCaoRepository : Repository<ModelBaoCaoDoanhThu> , IBaoCaoRepository
    {
        public BaoCaoRepository(QuanLyPhongMachEntities context) : base (context)
        {

        }
        public QuanLyPhongMachEntities context
        {
            get
            {
                return Context as QuanLyPhongMachEntities;
            }
        }
        public IEnumerable<ModelBaoCaoDoanhThu> GetModelDoanhThu(DateTime start, DateTime end)
        {
            var model = from donthuoc in context.DonThuocs
                        join pk in context.PhieuKhams
                        on donthuoc.MaPhieuKham equals pk.MaPhieuKham
                        where (DbFunctions.TruncateTime(pk.NgayKham) >= start.Date && DbFunctions.TruncateTime(pk.NgayKham) <= end.Date)
                        select new
                        {
                            pk,
                            donthuoc
                        } into temp
                        group temp by temp.pk.NgayKham into result
                        select new ModelBaoCaoDoanhThu
                        {
                            NgayKham = result.FirstOrDefault().pk.NgayKham,
                            TongTien = result.Sum(a => a.donthuoc.TongTien)
                        };
            return model.ToList();
        }

        public IEnumerable<ModelBaoCaoThuoc> GetModelThuoc(DateTime start, DateTime end)
        {
            var model = from thuoc in context.Thuocs
                        join ctdt in context.ChiTietDonThuocs
                        on thuoc.MaThuoc equals ctdt.MaThuoc
                        select new
                        {
                            ctdt,
                            thuoc
                        } into temp
                        group temp by temp.ctdt.MaThuoc into result

                        select new ModelBaoCaoThuoc
                        {
                            SoLuong = result.Sum(a => a.ctdt.SoLuong),
                            TenThuoc = result.FirstOrDefault().thuoc.TenThuoc
                        };
            return model.ToList();
        }
    }
}
