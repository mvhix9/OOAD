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
    public class ChiTietBenhServices : IChiTietBenhServices
    {
        private readonly UnitOfWork unitOfWork;
        public ChiTietBenhServices(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public void Delete(ChiTietBenh entity)
        {
            unitOfWork.ChiTietBenhs.Delete(entity);
            unitOfWork.Complete();
        }

        public void DeleteRange(IEnumerable<ChiTietBenh> entities)
        {
            unitOfWork.ChiTietBenhs.DeleteRange(entities);
            unitOfWork.Complete();
        }

        public IEnumerable<ChiTietBenh> Find(Expression<Func<ChiTietBenh, bool>> predicate)
        {
            return unitOfWork.ChiTietBenhs.Find(predicate);

        }

        public IEnumerable<ChiTietBenh> GetAll()
        {
            return unitOfWork.ChiTietBenhs.GetAll();
        }

        public ChiTietBenh GetById(int id)
        {
            return unitOfWork.ChiTietBenhs.GetById(id);
        }

        public IEnumerable<Benh> GetNameById(int a)
        {
            return unitOfWork.ChiTietBenhs.GetNameById(a);
        }

        public void Insert(ChiTietBenh entity)
        {
            unitOfWork.ChiTietBenhs.Insert(entity);
            unitOfWork.Complete();
        }

        public void InsertRange(IEnumerable<ChiTietBenh> entities)
        {
            unitOfWork.ChiTietBenhs.InsertRange(entities);
            unitOfWork.Complete();
        }

        public void Update(ChiTietBenh entity)
        {
            ChiTietBenh ctb = unitOfWork.ChiTietBenhs.GetById(entity.STT);
            ctb.MaBenh = entity.MaBenh;
            ctb.MaPhieuKham = entity.MaPhieuKham;
            unitOfWork.Complete();
        }
    }
}
