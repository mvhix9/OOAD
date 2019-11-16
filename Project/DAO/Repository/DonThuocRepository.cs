using DAO.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Repository
{
    public class DonThuocRepository : Repository<DonThuoc>, IDonThuocRepository
    {
        public DonThuocRepository(QuanLyPhongMachEntities context) : base(context)
        {

        }
        public QuanLyPhongMachEntities context
        {
            get { return Context as QuanLyPhongMachEntities; }
        }

        public DonThuoc GetByIdPhieuKham(int id)
        {
            var donthuoc = from t in context.DonThuocs
                        where t.MaDonThuoc == id
                        select t;
            return donthuoc as DonThuoc; 
        }
    }
}
