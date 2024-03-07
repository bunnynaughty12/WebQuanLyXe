using System.ComponentModel.DataAnnotations;

namespace QuanLyBaiGiuXe.Models
{
    public class TheGiuXe
    {
        [Key]
        public int MaTheGiuXe { get; set; }
/*        public decimal Gia { get; set; }
*/        public DateTime ThoiGianVao { get; set; }
        public int MaBaiGiuXe { get; set; }
        public int MaLoaiXe { get; set; }   
        public int MaGiaGiuXe { get; set; }

        public bool TrangThaiXe { get; set; }
        public string? BienSoXe { get; set; }
        public BaiGiuXe BaiGiuXe { get; set; }
        public BangGia BangGia { get; set; }
        public LoaiXe LoaiXe { get; set; }
    }
}
