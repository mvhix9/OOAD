using DTO;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Interface
{
    public interface IChiTietDonThuocRepository : IRepository<ChiTietDonThuoc>
    {
        IEnumerable<ModelChiTietDonThuoc> GetModelByIdPhieuKham(int id);
    }
}
