using DAO.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Repository
{
    public class BenhNhanRepository : Repository<BenhNhan>, IBenhNhanRepository
    {
        public BenhNhanRepository(QuanLyPhongMachEntities context) : base (context)
        { }
        public QuanLyPhongMachEntities context
        {
            get { return Context as QuanLyPhongMachEntities; }
        }
    }
}
