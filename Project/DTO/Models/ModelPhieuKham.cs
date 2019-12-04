using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{
    public class ModelPhieuKham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaPhieuKham { get; set; }
        public int MaBenhNhan { get; set; }
        public int MaNhanVien { get; set; }
        public string TenBN { get; set; }
        public string TenNV { get; set; }
        public string TrieuChung { get; set; }
        public IEnumerable<ChiTietBenh> ChiTietBenhs { get; set; }
        public string TenBenh { get; set; }
        public DateTime? NgayKham { get; set; }
        public string TrangThai { get; set; }
        
    }
}
