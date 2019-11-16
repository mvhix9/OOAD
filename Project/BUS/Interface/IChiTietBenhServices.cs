using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Interface
{
    public interface IChiTietBenhServices : IServices<ChiTietBenh>
    {
        IEnumerable<Benh> GetNameById(int a);
    }
}
