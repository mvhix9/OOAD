using DAO.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Repository
{
    public class VaiTroRepository : Repository<VaiTro>, IVaiTroRepository
    {
        public VaiTroRepository(QuanLyPhongMachEntities context) : base(context)
        {

        }

        public QuanLyPhongMachEntities context
        {
            get
            {
                return Context as QuanLyPhongMachEntities;
            }
        }
        public string GetNameById(int id)
        {
            string name = context.VaiTroes.Where(n => n.MaVaiTro == id).Select(n => n.TenVaiTro).FirstOrDefault();
            return name;
        }
    }
}
