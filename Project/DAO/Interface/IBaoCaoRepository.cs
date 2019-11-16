using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Interface
{
    public interface IBaoCaoRepository : IRepository<ModelBaoCaoDoanhThu>
    {
        IEnumerable<ModelBaoCaoDoanhThu> GetModelDoanhThu(DateTime start, DateTime end);
        IEnumerable<ModelBaoCaoThuoc> GetModelThuoc(DateTime start, DateTime end);

    }
}
