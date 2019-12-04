using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Interface
{
    public interface IThuocServices : IServices<Thuoc>
    {
        IEnumerable<Thuoc> GetByName(string name);
        Double GetPriceById(int id);
    }
}
