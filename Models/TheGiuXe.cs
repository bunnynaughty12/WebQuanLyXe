using System.ComponentModel.DataAnnotations;

namespace QuanLyBaiGiuXe.Models
{
    public class TheGiuXe
    {
        [Key]
        public int MaTheGiuXe { get; set; }
        public decimal Gia { get; set; }
        public DateTime ThoiGian { get; set; }
        public int MaBaiGiuXe { get; set; }

        public BaiGiuXe BaiGiuXe { get; set; }
    }
}
