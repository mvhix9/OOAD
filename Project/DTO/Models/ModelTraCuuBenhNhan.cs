using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{
    public class ModelTraCuuBenhNhan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Benh { get; set; }
        public DateTime? NgayKham { get; set; }
        public string TrieuChung { get; set; }
        public int MaPhieuKham { get; set; }
    }
}
