﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Interface
{
    public interface INhanVienServices : IServices<NhanVien>
    {
        IEnumerable<VaiTro> GetRoles { get;}
        IEnumerable<NhanVien> GetDoctor { get; }
    }
}
