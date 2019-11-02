using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAO
{
    public class Context : DbContext
    {
        public Context() : base("name=QuanLyPhongMachEntities")// la s chưa b nữa
        { }
        public DbSet<NhanVien> NhanViens { get; set; }
    }
}
