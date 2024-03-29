﻿using DAO.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Repository
{
    public class BenhRepository : Repository<Benh>, IBenhRepository
    {
        public BenhRepository(QuanLyPhongMachEntities context) : base(context)
        {

        }
        public QuanLyPhongMachEntities context
        {
            get { return Context as QuanLyPhongMachEntities; }
        }

        public Benh GetByName (string name)
        {
           
                var benh = from b in context.Benhs
                           where b.TenBenh.Equals(name)
                           select b;
                return benh as Benh;
            
        }
    }
}
