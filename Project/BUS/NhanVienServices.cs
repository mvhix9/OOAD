using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public static class NhanVienServices
    {
        static Context context; //sai cho nay hay sao á tạo mà ko dùng

        static INhanVienRepository repository;
        static NhanVienServices()
        {
            context = new Context();
            repository = new NhanVienRepository(context);
        }
        public static IEnumerable<NhanVien> GetAll()
        {
            return repository.GetAll();
        }
        public static NhanVien GetById(int id)
        {
            return repository.GetById(id);
        }
        public static void Insert(NhanVien nhanvien)
        {
            repository.Insert(nhanvien);
        }
        public static void Delete(NhanVien nhanvien)
        {
            repository.Delete(nhanvien);
        }
        public static void Update(NhanVien nhanvien)
        {
            repository.Update(nhanvien);
        }
    }
}
