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
    public class BenhNhanServices : IBenhNhanServices
    {
        private readonly UnitOfWork unitOfWork;

        public BenhNhanServices(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public IEnumerable<string> GetName
        {
            get
            {
                return unitOfWork.BenhNhans.GetName;
            }
        }

        public void Delete(BenhNhan entity)
        {
            unitOfWork.BenhNhans.Delete(entity);
            unitOfWork.Complete();
        }

        public void DeleteRange(IEnumerable<BenhNhan> entities)
        {
            unitOfWork.BenhNhans.DeleteRange(entities);
            unitOfWork.Complete();
        }

        public IEnumerable<BenhNhan> Find(Expression<Func<BenhNhan, bool>> predicate)
        {
            return unitOfWork.BenhNhans.Find(predicate);
        }

        public IEnumerable<BenhNhan> GetAll()
        {
            return unitOfWork.BenhNhans.GetAll();
        }

        public BenhNhan GetById(int id)
        {
            return unitOfWork.BenhNhans.GetById(id);
        }

        public void Insert(BenhNhan entity)
        {
            unitOfWork.BenhNhans.Insert(entity);
            unitOfWork.Complete();
        }

        public void InsertRange(IEnumerable<BenhNhan> entities)
        {
            unitOfWork.BenhNhans.InsertRange(entities);
            unitOfWork.Complete();
        }

        public void Update(BenhNhan entity)
        {
            BenhNhan nv = unitOfWork.BenhNhans.GetById(entity.MaBenhNhan);
            nv.HoTen = entity.HoTen;
            nv.NgaySinh = entity.NgaySinh;
            nv.GioiTinh = entity.GioiTinh;
            nv.DiaChi = entity.DiaChi;
            unitOfWork.Complete();
        }
    }
}
