﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Interface
{
    public interface IBenhNhanRepository : IRepository<BenhNhan>
    {
        IEnumerable<string> GetName { get; }
        List<int> GetId { get; }
    }
}
