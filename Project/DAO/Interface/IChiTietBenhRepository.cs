using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Interface
{
    public interface IChiTietBenhRepository : IRepository<ChiTietBenh>
    {
        IEnumerable<Benh> GetNameById(int a);
    }
}
