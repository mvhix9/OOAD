using Common;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhanVienRepository : Repository<NhanVien>, INhanVienRepository
    {
        public NhanVienRepository(QuanLyPhongMachEntities context) : base(context)
        {

        }

        public QuanLyPhongMachEntities context
        {
            get { return Context as QuanLyPhongMachEntities; }
        }

        public IEnumerable<NhanVien> GetDoctor
        {
            get
            {
                var doctor = from n in context.NhanViens
                             where n.MaVaiTro == 2 && n.TrangThai==1
                             select n;
                return doctor.ToList();
            }
        }

        public IEnumerable<VaiTro> GetRoles
        {
            get
            {
                var roles = from v in context.VaiTroes
                            orderby v.MaVaiTro
                            select v;
                return roles.ToList(); 
            }
        }

        public NhanVien GetNhanVien(string username, string password)
        {
            NhanVien nv = new NhanVien();
            nv = context.NhanViens.Where(n => n.TenDangNhap == username).FirstOrDefault();
            if (nv != null)
            {
                string hashPassword = HashPassword.ComputeSha256Hash(password);
                if (HashPassword.CompareHash(hashPassword, nv.MatKhau))
                {
                    CacheUser(nv);
                    return nv;
                }
            }
            return null;
        }

        private void CacheUser(NhanVien nv)
        {
            UserCache.Name = nv.HoTen;
            UserCache.Id = nv.MaNhanVien;
            switch (nv.MaVaiTro)
            {
                case 1:
                    UserCache.Role = "Nhân viên";
                    UserCache.RoleId = 1;
                    break;
                case 2:
                    UserCache.Role = "Bác sĩ";
                    UserCache.RoleId = 2;
                    break;
                case 3:
                    UserCache.Role = "Quản trị viên";
                    UserCache.RoleId = 3;
                    break;
            }
        }

        public bool CheckExistedUsername(string username)
        {
            NhanVien usernameExisted = context.NhanViens.Where(nv => nv.TenDangNhap == username).FirstOrDefault();
            return String.IsNullOrEmpty(usernameExisted.TenDangNhap); 
        }

        public void Refresh(NhanVien entity)
        {
            context.Entry(entity).Reload();
        }
    }
}
