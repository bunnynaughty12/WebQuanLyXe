using System.ComponentModel.DataAnnotations;

namespace QuanLyBaiGiuXe.Models
{
    public class LoaiXe
    {
        [Key]
        public int MaLoaiXe {  get; set; }  
        public string TenLoaiXe { get; set; }

        public ICollection<TheGiuXe> TheGiuXe { get; set; }
        public ICollection<LoaiHoiVien> LoaiHoiVien { get; set; }   

    }
}
