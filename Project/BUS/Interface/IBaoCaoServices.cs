using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Interface
{
    public interface IBaoCaoServices
    {
        IEnumerable<ModelBaoCaoDoanhThu> GetModelDoanhThu(DateTime start, DateTime end);
        IEnumerable<ModelBaoCaoThuoc> GetModelThuoc(DateTime start, DateTime end);
    }
}
