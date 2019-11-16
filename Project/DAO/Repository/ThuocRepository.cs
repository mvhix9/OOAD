using DAO.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO.Repository
{
    public class ThuocRepository : Repository<Thuoc> , IThuocRepository
    {
        public ThuocRepository(QuanLyPhongMachEntities context) : base(context)
        {

        }

        public QuanLyPhongMachEntities context
        {
            get { return Context as QuanLyPhongMachEntities; }
        }

        public IEnumerable<Thuoc> GetByName(string name)
        {
            return context.Thuocs.Where(t => t.TenThuoc.Contains(name)).ToList();
        }

        public double GetPriceById(int id)
        {
            double dongia = context.Thuocs.Where(t => t.MaThuoc == id).FirstOrDefault().DonGia;
            return dongia;
        }
    }
}
