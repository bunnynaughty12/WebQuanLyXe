using System.ComponentModel.DataAnnotations;

namespace QuanLyBaiGiuXe.Models
{
    public class LoaiHoiVien
    {
        [Key]
        public int MaLoaiHoiVien {  get; set; }
        public string TenLoaiHoiVien { get; set; }
        public int MaGia { get; set; }  
        public int MaLoaiXe { get; set; }

        public BangGia BangGia { get; set; }
        public LoaiXe LoaiXe { get; set; }
          
        public ICollection<HoiVien> HoiVien { get; set;}

    }
}
