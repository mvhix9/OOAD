﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using DAO.Interface;
using DAO.Repository;

namespace DAO.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly QuanLyPhongMachEntities context = new QuanLyPhongMachEntities();
        public UnitOfWork(QuanLyPhongMachEntities context)
        {
            this.context = context;
            Nhanviens = new NhanVienRepository(context);
            Thuocs = new ThuocRepository(context);
            VaiTroes = new VaiTroRepository(context);
            PhieuKhams = new PhieuKhamRepository(context);
            BenhNhans = new BenhNhanRepository(context);
            Benhs = new BenhRepository(context);
            ChiTietBenhs = new ChiTietBenhRepository(context);
            ChiTietDonThuocs = new ChiTietDonThuocRepository(context);
            DonThuocs = new DonThuocRepository(context);
            BaoCaos = new BaoCaoRepository(context);
        }
        public INhanVienRepository Nhanviens  {get; private set;}

        public IPhieuKhamRepository PhieuKhams { get; private set; }

        public IBenhNhanRepository BenhNhans { get; private set; }

        public IThuocRepository Thuocs { get; private set; }

        public IVaiTroRepository VaiTroes
        {
            get; private set;
        }

        public IVaiTroRepository Vaitroes { get; private set; }

        public IChiTietBenhRepository ChiTietBenhs { get; private set; }
        
        public IBenhRepository Benhs { get; private set; }

        public IChiTietDonThuocRepository ChiTietDonThuocs
        {
            get; private set; 
        }

        public IDonThuocRepository DonThuocs
        {
            get; private set;
        }

        public IBaoCaoRepository BaoCaos {get; private set;}

        public int Complete()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
