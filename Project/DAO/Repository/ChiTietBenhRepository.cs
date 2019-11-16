using DAO.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Repository
{
    public class ChiTietBenhRepository : Repository<ChiTietBenh>, IChiTietBenhRepository
    {
        
        public ChiTietBenhRepository(QuanLyPhongMachEntities context) : base(context)
        {

        }
        public QuanLyPhongMachEntities context
        {
            get { return Context as QuanLyPhongMachEntities; }
        }

        public IEnumerable<Benh> GetNameById(int a)
        {
            var benh = from pk in context.PhieuKhams
                    join ctb in context.ChiTietBenhs
                    on pk.MaPhieuKham equals ctb.MaPhieuKham
                    join be in context.Benhs
                    on ctb.MaBenh equals be.MaBenh
                    where pk.MaPhieuKham == a
                    select be;
            return benh.ToList();
        }
    }
}
