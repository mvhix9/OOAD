using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Interface
{
    public interface IVaiTroServices : IServices<VaiTro>
    {
        string GetNameById(int id);
    }
}
