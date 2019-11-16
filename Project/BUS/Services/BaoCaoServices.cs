using BUS.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Models;
using DAO.UnitOfWork;

namespace BUS.Services
{
    public class BaoCaoServices : IBaoCaoServices
    {
        private readonly UnitOfWork unitOfWork;
        public BaoCaoServices(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public IEnumerable<ModelBaoCaoDoanhThu> GetModelDoanhThu(DateTime start, DateTime end)
        {
            return unitOfWork.BaoCaos.GetModelDoanhThu(start, end);
        }

        public IEnumerable<ModelBaoCaoThuoc> GetModelThuoc(DateTime start, DateTime end)
        {
            return unitOfWork.BaoCaos.GetModelThuoc(start, end);
        }
    }
}
