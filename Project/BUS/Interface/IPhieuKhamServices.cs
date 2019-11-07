﻿using DTO;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Interface
{
    public interface IPhieuKhamServices : IServices<PhieuKham>
    {
        IEnumerable<ModelPhieuKham> GetModel();
    }
}
