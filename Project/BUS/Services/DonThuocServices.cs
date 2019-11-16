using BUS.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Linq.Expressions;
using DAO.UnitOfWork;

namespace BUS.Services
{
    public class DonThuocServices : IDonThuocServices
    {
        private readonly UnitOfWork unitOfWork;

        public DonThuocServices(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Delete(DonThuoc entity)
        {
            unitOfWork.DonThuocs.Delete(entity);
            unitOfWork.Complete();
        }

        public void DeleteRange(IEnumerable<DonThuoc> entities)
        {
            unitOfWork.DonThuocs.DeleteRange(entities);
            unitOfWork.Complete();

        }

        public IEnumerable<DonThuoc> Find(Expression<Func<DonThuoc, bool>> predicate)
        {
            return unitOfWork.DonThuocs.Find(predicate);
        }

        public IEnumerable<DonThuoc> GetAll()
        {
            return unitOfWork.DonThuocs.GetAll();
        }

        public DonThuoc GetById(int id)
        {
            return unitOfWork.DonThuocs.GetById(id);
        }

        public void Insert(DonThuoc entity)
        {
            unitOfWork.DonThuocs.Insert(entity);
            unitOfWork.Complete();
        }

        public void InsertRange(IEnumerable<DonThuoc> entities)
        {
            unitOfWork.DonThuocs.InsertRange(entities);
            unitOfWork.Complete();
        }

        public void Update(DonThuoc entity)
        {
            var donthuoc = unitOfWork.DonThuocs.GetById(entity.MaDonThuoc);
            donthuoc.MaDonThuoc = entity.MaDonThuoc;
            donthuoc.MaPhieuKham = entity.MaPhieuKham;
            donthuoc.TongTien = entity.TongTien;
            unitOfWork.Complete();
        }

        DonThuoc IDonThuocServices.GetByIdPhieuKham(int id)
        {
            return unitOfWork.DonThuocs.GetByIdPhieuKham(id);
        }
    }
}
