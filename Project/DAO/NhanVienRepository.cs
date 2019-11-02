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
        public NhanVienRepository(Context context) : base(context)
        {}

        public Context context
        {
            get { return context as Context; }
        }
    }
}
