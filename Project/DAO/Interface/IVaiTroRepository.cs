﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Interface
{
    public interface IVaiTroRepository : IRepository<VaiTro>
    {
        string GetNameById(int id);
    }
}