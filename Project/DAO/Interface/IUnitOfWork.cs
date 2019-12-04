using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DAO.Interface;

namespace DAO.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        INhanVienRepository Nhanviens { get; }
        IThuocRepository Thuocs { get; }
        IVaiTroRepository VaiTroes { get; }
        IPhieuKhamRepository PhieuKhams { get; }
        IBenhNhanRepository BenhNhans { get; }
        IChiTietBenhRepository ChiTietBenhs { get; }
        IBenhRepository Benhs { get; }
        IChiTietDonThuocRepository ChiTietDonThuocs { get; }
        IDonThuocRepository DonThuocs { get; }
        IBaoCaoRepository BaoCaos { get; }
        int Complete();
    }
}
