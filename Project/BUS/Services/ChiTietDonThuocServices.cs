using BUS.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using DAO.UnitOfWork;
using DTO.Models;

namespace BUS.Services
{
    public class ChiTietDonThuocServices : IChiTietDonThuocServices
    {
        private readonly UnitOfWork unitOfWork;
        public ChiTietDonThuocServices(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Delete(ChiTietDonThuoc entity)
        {
            unitOfWork.ChiTietDonThuocs.Delete(entity);
            unitOfWork.Complete();
        }

        public void DeleteRange(IEnumerable<ChiTietDonThuoc> entities)
        {
            unitOfWork.ChiTietDonThuocs.DeleteRange(entities);
            unitOfWork.Complete();
        }

        public IEnumerable<ChiTietDonThuoc> Find(Expression<Func<ChiTietDonThuoc, bool>> predicate)
        {
            return unitOfWork.ChiTietDonThuocs.Find(predicate);
        }

        public IEnumerable<ChiTietDonThuoc> GetAll()
        {
            return unitOfWork.ChiTietDonThuocs.GetAll();
        }

        public ChiTietDonThuoc GetById(int id)
        {
            return unitOfWork.ChiTietDonThuocs.GetById(id);
        }

        public IEnumerable<ModelChiTietDonThuoc> GetModelByIdPhieuKham(int id)
        {
            return unitOfWork.ChiTietDonThuocs.GetModelByIdPhieuKham(id);
        }

        public void Insert(ChiTietDonThuoc entity)
        {
            unitOfWork.ChiTietDonThuocs.Insert(entity);
            unitOfWork.Complete();
        }

        public void InsertRange(IEnumerable<ChiTietDonThuoc> entities)
        {
            unitOfWork.ChiTietDonThuocs.InsertRange(entities);
            unitOfWork.Complete();
        }

        public void Update(ChiTietDonThuoc entity)
        {
            //ChiTietDonThuoc ctdt = unitOfWork.ChiTietDonThuocs.GetById(entity.MaDonThuoc);
            //unitOfWork.ChiTietDonThuocs.Update;
        }
    }
}
