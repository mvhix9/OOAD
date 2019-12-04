using DTO;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Interface
{
    public interface IPhieuKhamServices : IServices<PhieuKham>
    {
        IEnumerable<ModelPhieuKham> GetModel();
        IEnumerable<ModelPhieuKham> Find(Expression<Func<ModelPhieuKham, bool>> predicate);
        IEnumerable<ModelPhieuKham> GetModelUncompletedByIdDoctor(int id);
        IEnumerable<ModelPhieuKham> GetModelCompletedByIdDoctor(int id);
        IEnumerable<ModelTraCuuBenhNhan> GetModelTraCuu(int id, DateTime start, DateTime end);
        IEnumerable<ModelPhieuKham> GetModelHasDonThuocByIdDoctor(int id);
    }
}
