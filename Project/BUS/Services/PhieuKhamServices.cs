using BUS.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Linq.Expressions;
using DAO.UnitOfWork;
using DTO.Models;

namespace BUS.Services
{
    public class PhieuKhamServices : IPhieuKhamServices
    {
        private readonly UnitOfWork unitOfWork;
        public PhieuKhamServices(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Delete(PhieuKham entity)
        {
            unitOfWork.PhieuKhams.Delete(entity);
            unitOfWork.Complete();
        }

        public void DeleteRange(IEnumerable<PhieuKham> entities)
        {
            unitOfWork.PhieuKhams.DeleteRange(entities);
            unitOfWork.Complete();
        }

        public IEnumerable<PhieuKham> Find(Expression<Func<PhieuKham, bool>> predicate)
        {
            return unitOfWork.PhieuKhams.Find(predicate);
        }

        public IEnumerable<PhieuKham> GetAll()
        {
            return unitOfWork.PhieuKhams.GetAll();
        }

        public PhieuKham GetById(int id)
        {
            return unitOfWork.PhieuKhams.GetById(id);
        }

        //public List<string> GetChiTietBenhById(int id, DateTime start, DateTime end)
        //{
        //    return unitOfWork.PhieuKhams.GetChiTietBenhById(id, start, end);
        //}

        public IEnumerable<ModelPhieuKham> GetModel()
        {
            return unitOfWork.PhieuKhams.GetModel();
        }


        public IEnumerable<ModelPhieuKham> GetModelCompletedByIdDoctor(int id)
        {
            return unitOfWork.PhieuKhams.GetModelCompletedByIdDoctor(id);
        }

        public IEnumerable<ModelPhieuKham> GetModelHasDonThuocByIdDoctor(int id)
        {
            return unitOfWork.PhieuKhams.GetModelHasDonThuocByIdDoctor(id);
        }

        public IEnumerable<ModelTraCuuBenhNhan> GetModelTraCuu(int id, DateTime start, DateTime end)
        {
            return unitOfWork.PhieuKhams.GetModelTraCuu(id,start,end);
        }

        public IEnumerable<ModelPhieuKham> GetModelUncompletedByIdDoctor(int id)
        {
            return unitOfWork.PhieuKhams.GetModelUncompletedByIdDoctor(id);
        }

        public void Insert(PhieuKham entity)
        {
            unitOfWork.PhieuKhams.Insert(entity);
            unitOfWork.Complete();
        }

        public void InsertRange(IEnumerable<PhieuKham> entities)
        {
            unitOfWork.PhieuKhams.InsertRange(entities);
        }

        public void Update(PhieuKham entity)
        {
            var pk = unitOfWork.PhieuKhams.GetById(entity.MaPhieuKham);
            pk.NgayKham = entity.NgayKham;
            pk.MaBenhNhan = entity.MaBenhNhan;
            pk.MaNhanVien = entity.MaNhanVien;
            pk.TrieuChung = entity.TrieuChung;
            pk.TrangThai = entity.TrangThai;
            unitOfWork.Complete();
        }
    }
}
