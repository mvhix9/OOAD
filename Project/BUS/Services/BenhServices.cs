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
    public class BenhServices : IBenhServices
    {
        private readonly UnitOfWork unitOfWork;
        public BenhServices (UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public void Delete(Benh entity)
        {
            unitOfWork.Benhs.Delete(entity);
            unitOfWork.Complete();
        }

        public void DeleteRange(IEnumerable<Benh> entities)
        {
            unitOfWork.Benhs.DeleteRange(entities);
            unitOfWork.Complete();
        }

        public IEnumerable<Benh> Find(Expression<Func<Benh, bool>> predicate)
        {
            return unitOfWork.Benhs.Find(predicate);
            
        }

        public IEnumerable<Benh> GetAll()
        {
            return unitOfWork.Benhs.GetAll();
        }

        public Benh GetById(int id)
        {
            return unitOfWork.Benhs.GetById(id);
        }

        public Benh GetByName(string name)
        {
            return unitOfWork.Benhs.GetByName(name);
        }

        public void Insert(Benh entity)
        {
            unitOfWork.Benhs.Insert(entity);
            unitOfWork.Complete();
        }

        public void InsertRange(IEnumerable<Benh> entities)
        {
            unitOfWork.Benhs.InsertRange(entities);
            unitOfWork.Complete();
        }

        public void Update(Benh entity)
        {
            Benh b = unitOfWork.Benhs.GetById(entity.MaBenh);
            b.TenBenh = entity.TenBenh;
            unitOfWork.Complete();
        }
    }
}
