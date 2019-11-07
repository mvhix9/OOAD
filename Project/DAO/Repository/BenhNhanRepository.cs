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

        public List<int> GetId
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        IEnumerable<string> IBenhNhanRepository.GetName
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        IEnumerable<string> GetName
        {
            get
            {
                var name = context.BenhNhans.Select(b => b.HoTen);
                return name.ToList();
            }
        }
    }
}
