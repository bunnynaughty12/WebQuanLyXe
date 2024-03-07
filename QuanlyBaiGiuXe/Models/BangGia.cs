using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyBaiGiuXe.Models
{
    public class BangGia
    {
        [Key]
        public int MaGiaGiuXe { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal GiaGiuXe { get; set; }
        public ICollection<TheGiuXe> TheGiuXe { get; set;}
        public ICollection<LoaiHoiVien> LoaiHoiVien {  get; set; }  
    }
}
