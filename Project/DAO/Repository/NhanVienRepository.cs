using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhanVienRepository : Repository<NhanVien>, INhanVienRepository
    {
        public NhanVienRepository(QuanLyPhongMachEntities context) : base(context)
        {

        }

        public QuanLyPhongMachEntities context
        {
            get { return Context as QuanLyPhongMachEntities; }
        }

        public IEnumerable<NhanVien> GetDoctor
        {
            get
            {
                var doctor = from n in context.NhanViens
                             where n.MaVaiTro == 2
                             select n;
                return doctor.ToList();
            }
        }

        public IEnumerable<VaiTro> GetRoles
        {
            get
            {
                var roles = from v in context.VaiTroes
                            orderby v.MaVaiTro
                            select v;
                return roles.ToList(); 
            }
        }
    }
}
