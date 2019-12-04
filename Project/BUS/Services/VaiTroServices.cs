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
    public class VaiTroServices : IVaiTroServices
    {
        private readonly UnitOfWork unitOfWork;
        public VaiTroServices (UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public void Delete(VaiTro entity)
        {
            unitOfWork.VaiTroes.Delete(entity);
            unitOfWork.Complete();
        }

        public void DeleteRange(IEnumerable<VaiTro> entities)
        {
            unitOfWork.VaiTroes.DeleteRange(entities);
            unitOfWork.Complete();
        }

        public IEnumerable<VaiTro> Find(Expression<Func<VaiTro, bool>> predicate)
        {
            return unitOfWork.VaiTroes.Find(predicate);
        }

        public IEnumerable<VaiTro> GetAll()
        {
            return unitOfWork.VaiTroes.GetAll();
        }

        public VaiTro GetById(int id)
        {
            return unitOfWork.VaiTroes.GetById(id);
        }

        public string GetNameById(int id)
        {
            return unitOfWork.VaiTroes.GetNameById(id);
        }

        public void Insert(VaiTro entity)
        {
            unitOfWork.VaiTroes.Insert(entity);
            unitOfWork.Complete();
        }

        public void InsertRange(IEnumerable<VaiTro> entities)
        {
            unitOfWork.VaiTroes.InsertRange(entities);
            unitOfWork.Complete();
        }

        public void Update(VaiTro entity)
        {
            unitOfWork.VaiTroes.Update(entity);
            unitOfWork.Complete();
        }
    }
}
