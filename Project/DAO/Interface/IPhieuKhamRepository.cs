using DTO;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Interface
{
    public interface IPhieuKhamRepository : IRepository<PhieuKham>
    { 
        IEnumerable<ModelPhieuKham> GetModel();
        IEnumerable<ModelPhieuKham> Find(Expression<Func<ModelPhieuKham, bool>> predicate);
        IEnumerable<ModelPhieuKham> GetModelByIdDoctor(int id);
        IEnumerable<ModelPhieuKham> GetModelUncompletedByIdDoctor(int id);
        IEnumerable<ModelPhieuKham> GetModelCompletedByIdDoctor(int id);
        IEnumerable<ModelPhieuKham> GetModelHasDonThuocByIdDoctor(int id);
        List<ModelTraCuuBenhNhan> GetModelTraCuu(int id, DateTime from, DateTime to);
    }
}
