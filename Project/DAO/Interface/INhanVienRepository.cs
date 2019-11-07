﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public interface INhanVienRepository : IRepository<NhanVien>
    {
        IEnumerable<VaiTro> GetRoles { get; }
        IEnumerable<NhanVien> GetDoctor { get; }
    }
    
}