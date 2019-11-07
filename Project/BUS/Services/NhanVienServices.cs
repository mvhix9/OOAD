using BUS.Interface;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using DAO.UnitOfWork;

namespace BUS
{
    public class NhanVienServices : INhanVienServices
    {
        private readonly UnitOfWork unitOfWork;
        public NhanVienServices(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<NhanVien> GetDoctor
        {
            get
            {
                return unitOfWork.Nhanviens.GetDoctor;
            }
        }

        public IEnumerable<VaiTro> GetRoles
        {
            get
            {
                return unitOfWork.Nhanviens.GetRoles;
            }
        }

        public void Delete(NhanVien entity)
        {
            unitOfWork.Nhanviens.Delete(entity);
            unitOfWork.Complete();
        }

        public void DeleteRange(IEnumerable<NhanVien> entities)
        {
            unitOfWork.Nhanviens.DeleteRange(entities);
            unitOfWork.Complete();
        }

        public IEnumerable<NhanVien> Find(Expression<Func<NhanVien, bool>> predicate)
        {
            return unitOfWork.Nhanviens.Find(predicate);
        }

        public IEnumerable<NhanVien> GetAll()
        {
            return unitOfWork.Nhanviens.GetAll();
        }

        public NhanVien GetById(int id)
        {
            return unitOfWork.Nhanviens.GetById(id);
        }

        public void Insert(NhanVien entity)
        {
            unitOfWork.Nhanviens.Insert(entity);
            unitOfWork.Complete();
        }

        public void InsertRange(IEnumerable<NhanVien> entities)
        {
            unitOfWork.Nhanviens.InsertRange(entities);
            unitOfWork.Complete();
        }

        public void Update(NhanVien entity)
        {
            var nv = unitOfWork.Nhanviens.GetById(entity.MaNhanVien);
            nv.HoTen = entity.HoTen;
            nv.GioiTinh = entity.GioiTinh;
            nv.DiaChi = entity.DiaChi;
            nv.MatKhau = entity.MatKhau;
            nv.MaVaiTro = entity.MaVaiTro;
            nv.NgaySinh = entity.NgaySinh;
            unitOfWork.Complete();
        }
    }
}
