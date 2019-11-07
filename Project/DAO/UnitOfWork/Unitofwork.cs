using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using DAO.Interface;
using DAO.Repository;

namespace DAO.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly QuanLyPhongMachEntities context = new QuanLyPhongMachEntities();
        public UnitOfWork(QuanLyPhongMachEntities context)
        {
            this.context = context;
            Nhanviens = new NhanVienRepository(context);
            Thuocs = new ThuocRepository(context);
            Vaitroes = new VaiTroRepository(context);
            PhieuKhams = new PhieuKhamRepository(context);
            BenhNhans = new BenhNhanRepository(context);
        }
        public INhanVienRepository Nhanviens  {get; private set;}

        public IPhieuKhamRepository PhieuKhams { get; private set; }

        public IBenhNhanRepository BenhNhans { get; private set; }

        public IThuocRepository Thuocs { get; private set; }



        public IVaiTroRepository VaiTroes
        {
            get; private set;
        }

        public IVaiTroRepository Vaitroes { get; private set; }
        public int Complete()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
