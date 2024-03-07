using System.ComponentModel.DataAnnotations;

namespace QuanLyBaiGiuXe.Models
{
    public class BaiGiuXe
    {
        [Key]
        public int MaBaiGiuXe { get; set; }
        public string TenBaiGiuXe { get; set; }
        public int SucChua { get; set; }
        public string DiaChi { get; set; }

        public ICollection<TheGiuXe> TheGiuXes { get; set; }

    }
}
