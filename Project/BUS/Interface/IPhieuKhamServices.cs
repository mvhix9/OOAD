using DTO;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Interface
{
    public interface IPhieuKhamServices : IServices<PhieuKham>
    {
        IEnumerable<ModelPhieuKham> GetModel();
        IEnumerable<ModelPhieuKham> GetModelUncompletedByIdDoctor(int id);
        IEnumerable<ModelPhieuKham> GetModelCompletedByIdDoctor(int id);
        IEnumerable<ModelTraCuuBenhNhan> GetModelTraCuu(int id, DateTime start, DateTime end);
        IEnumerable<ModelPhieuKham> GetModelHasDonThuocByIdDoctor(int id);
    }
}
