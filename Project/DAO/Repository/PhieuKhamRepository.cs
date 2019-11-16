using DAO.Interface;
using DTO;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO.Repository
{
    public class PhieuKhamRepository : Repository<PhieuKham> , IPhieuKhamRepository
    {
        public PhieuKhamRepository(QuanLyPhongMachEntities context) : base(context)
        {

        }
        public QuanLyPhongMachEntities context
        {
            get { return Context as QuanLyPhongMachEntities; }
        }

        public IEnumerable<ModelPhieuKham> GetModel()
        {
            var model = from m in context.PhieuKhams
                        join n in context.NhanViens
                        on m.MaNhanVien equals n.MaNhanVien
                        join b in context.BenhNhans
                        on m.MaBenhNhan equals b.MaBenhNhan
                        select new ModelPhieuKham
                        {
                            MaPhieuKham = m.MaPhieuKham,
                            MaNhanVien = n.MaNhanVien,
                            MaBenhNhan = b.MaBenhNhan,
                            TenNV = n.HoTen,
                            TenBN = b.HoTen,
                            TrieuChung = m.TrieuChung,
                            NgayKham = m.NgayKham,
                            ChiTietBenhs = m.ChiTietBenhs,
                            TrangThai = m.TrangThai,
                        };
            return model.ToList();
        }

        public IEnumerable<ModelPhieuKham> GetModelByIdDoctor(int id)
        {
            var model = from m in context.PhieuKhams
                        join n in context.NhanViens
                        on m.MaNhanVien equals n.MaNhanVien
                        join b in context.BenhNhans
                        on m.MaBenhNhan equals b.MaBenhNhan
                        where m.MaNhanVien == id
                        select new ModelPhieuKham
                        {
                            MaPhieuKham = m.MaPhieuKham,
                            MaNhanVien = n.MaNhanVien,
                            MaBenhNhan = b.MaBenhNhan,
                            TenNV = n.HoTen,
                            TenBN = b.HoTen,
                            TrieuChung = m.TrieuChung,
                            NgayKham = m.NgayKham,
                            ChiTietBenhs = m.ChiTietBenhs
                        };
            return model.ToList();
        }
        public List<ModelTraCuuBenhNhan> GetModelTraCuu(int id,DateTime start,DateTime end)
        {
            List<ModelRowBenh> Rows = new List<ModelRowBenh>();
            List<ModelTraCuuBenhNhan> TraCuu = new List<ModelTraCuuBenhNhan>();
            var model = from pk in context.PhieuKhams
                        join c in context.ChiTietBenhs
                        on pk.MaPhieuKham equals c.MaPhieuKham
                        join b in context.Benhs
                        on c.MaBenh equals b.MaBenh
                        where pk.MaBenhNhan == id
                        && (DbFunctions.TruncateTime(pk.NgayKham) >= start.Date && DbFunctions.TruncateTime(pk.NgayKham) <= end.Date)
                        select new ModelRowBenh
                        {
                            MaPhieuKham = pk.MaPhieuKham,
                            NgayKham = pk.NgayKham,
                            TrieuChung = pk.TrieuChung,
                            TenBenh = b.TenBenh,
                        };
            Rows = model.ToList();
            string benhs = "";
            for (int i = 0; i < Rows.Count(); i++)
            {
                if (i == Rows.Count() - 1)
                {
                    ModelTraCuuBenhNhan tracuu = new ModelTraCuuBenhNhan();
                    tracuu.NgayKham = Rows[i].NgayKham;
                    tracuu.TrieuChung = Rows[i].TrieuChung;
                    tracuu.Benh = benhs + Rows[i].TenBenh;
                    tracuu.MaPhieuKham = Rows[i].MaPhieuKham;
                    benhs = "";
                    TraCuu.Add(tracuu);
                }
                else if (i == 0)
                {
                    benhs += Rows[i].TenBenh + ", ";
                }
                else if (Rows[i].MaPhieuKham == Rows[i + 1].MaPhieuKham)
                {
                    benhs += Rows[i].TenBenh.ToString() + ", ";
                }
                else if (Rows[i].MaPhieuKham == Rows[i - 1].MaPhieuKham)
                {
                    benhs += Rows[i].TenBenh.ToString() + ", ";
                    ModelTraCuuBenhNhan tracuu = new ModelTraCuuBenhNhan();
                    tracuu.NgayKham = Rows[i].NgayKham;
                    tracuu.TrieuChung = Rows[i].TrieuChung;
                    tracuu.Benh = benhs.Remove(benhs.Length -2);
                    tracuu.MaPhieuKham = Rows[i].MaPhieuKham;
                    benhs = "";
                    TraCuu.Add(tracuu);
                }
                else if(Rows[i].MaPhieuKham != Rows[i - 1].MaPhieuKham && Rows[i].MaPhieuKham != Rows[i + 1].MaPhieuKham)
                {
                    ModelTraCuuBenhNhan tracuu = new ModelTraCuuBenhNhan();
                    tracuu.NgayKham = Rows[i].NgayKham;
                    tracuu.TrieuChung = Rows[i].TrieuChung;
                    tracuu.Benh = Rows[i].TenBenh;
                    tracuu.MaPhieuKham = Rows[i].MaPhieuKham;
                    benhs = "";
                    TraCuu.Add(tracuu);
                }
                else
                {
                    ModelTraCuuBenhNhan tracuu = new ModelTraCuuBenhNhan();
                    tracuu.NgayKham = Rows[i].NgayKham;
                    tracuu.TrieuChung = Rows[i].TrieuChung;
                    tracuu.Benh = benhs.Remove(benhs.Length - 2);
                    tracuu.MaPhieuKham = Rows[i].MaPhieuKham;
                    benhs = "";
                    benhs += Rows[i].TenBenh + ", ";
                    TraCuu.Add(tracuu);
                }
            }
            return TraCuu;
        }

        public IEnumerable<ModelPhieuKham> GetModelUncompletedByIdDoctor(int id)
        {
            var model = from m in context.PhieuKhams
                        join n in context.NhanViens
                        on m.MaNhanVien equals n.MaNhanVien
                        join b in context.BenhNhans
                        on m.MaBenhNhan equals b.MaBenhNhan
                        where m.MaNhanVien == id && m.TrangThai.Equals("Đã lập")
                        select new ModelPhieuKham
                        {
                            MaPhieuKham = m.MaPhieuKham,
                            MaNhanVien = n.MaNhanVien,
                            MaBenhNhan = b.MaBenhNhan,
                            TenNV = n.HoTen,
                            TenBN = b.HoTen,
                            TrieuChung = m.TrieuChung,
                            NgayKham = m.NgayKham,
                            ChiTietBenhs = m.ChiTietBenhs,
                            TrangThai = m.TrangThai
                        };
            return model.ToList();
        }
        public IEnumerable<ModelPhieuKham> GetModelCompletedByIdDoctor(int id)
        {
            var model = from m in context.PhieuKhams
                        join n in context.NhanViens
                        on m.MaNhanVien equals n.MaNhanVien
                        join b in context.BenhNhans
                        on m.MaBenhNhan equals b.MaBenhNhan
                        where m.MaNhanVien == id && m.TrangThai.Equals("Đã chẩn đoán")
                        select new ModelPhieuKham
                        {
                            MaPhieuKham = m.MaPhieuKham,
                            MaNhanVien = n.MaNhanVien,
                            MaBenhNhan = b.MaBenhNhan,
                            TenNV = n.HoTen,
                            TenBN = b.HoTen,
                            TrieuChung = m.TrieuChung,
                            NgayKham = m.NgayKham,
                            ChiTietBenhs = m.ChiTietBenhs,
                            TrangThai = m.TrangThai
                        };
            return model.ToList();
        }
        public IEnumerable<ModelPhieuKham> GetModelHasDonThuocByIdDoctor(int id)
        {
            var model = from m in context.PhieuKhams
                        join n in context.NhanViens
                        on m.MaNhanVien equals n.MaNhanVien
                        join b in context.BenhNhans
                        on m.MaBenhNhan equals b.MaBenhNhan
                        where m.MaNhanVien == id && m.TrangThai.Equals("Đã lập đơn thuốc")
                        select new ModelPhieuKham
                        {
                            MaPhieuKham = m.MaPhieuKham,
                            MaNhanVien = n.MaNhanVien,
                            MaBenhNhan = b.MaBenhNhan,
                            TenNV = n.HoTen,
                            TenBN = b.HoTen,
                            TrieuChung = m.TrieuChung,
                            NgayKham = m.NgayKham,
                            ChiTietBenhs = m.ChiTietBenhs,
                            TrangThai = m.TrangThai
                        };
            return model.ToList();
        }
    }
}
