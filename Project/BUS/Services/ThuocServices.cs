using BUS.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using DAO.UnitOfWork;

namespace BUS.Services
{
    public class ThuocServices : IThuocServices
    {
        private readonly UnitOfWork unitOfWork;
        public ThuocServices(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }


        public void Delete(Thuoc entity)
        {
            unitOfWork.Thuocs.Delete(entity);
            unitOfWork.Complete();
        }

        public void DeleteRange(IEnumerable<Thuoc> entities)
        {
            unitOfWork.Thuocs.DeleteRange(entities);
            unitOfWork.Complete();
        }

        public IEnumerable<Thuoc> Find(Expression<Func<Thuoc, bool>> predicate)
        {
            return unitOfWork.Thuocs.Find(predicate);
        }

        public IEnumerable<Thuoc> GetAll()
        {
            return unitOfWork.Thuocs.GetAll();
        }

        public Thuoc GetById(int id)
        {
            return unitOfWork.Thuocs.GetById(id);
        }

        public IEnumerable<Thuoc> GetByName(string name)
        {
            return unitOfWork.Thuocs.GetByName(name);
        }

        public double GetPriceById(int id)
        {
            return unitOfWork.Thuocs.GetPriceById(id);
        }

        public void Insert(Thuoc entity)
        {
            unitOfWork.Thuocs.Insert(entity);
            unitOfWork.Complete();
        }

        public void InsertRange(IEnumerable<Thuoc> entities)
        {
            unitOfWork.Thuocs.InsertRange(entities);
            unitOfWork.Complete();
        }

        public void Update(Thuoc entity)
        {
            var t = unitOfWork.Thuocs.GetById(entity.MaThuoc);
            t.TenThuoc = entity.TenThuoc;
            t.DonGia = entity.DonGia;
            unitOfWork.Complete();
        }

    }
}
