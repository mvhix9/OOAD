using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{
    public class ModelChiTietDonThuoc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int STT { get; set; }
        public int MaThuoc { get; set; }
        public string TenThuoc { get; set; }
        public string CachDung { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }
        public double? ThanhTien { get; set; } 
    }
}
