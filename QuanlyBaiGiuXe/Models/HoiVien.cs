using System.ComponentModel.DataAnnotations;

namespace QuanLyBaiGiuXe.Models
{
    public class HoiVien
    {
        [Key]
        public int MaHoiVien { get; set; }  
        public string TenKhachHang { get; set; }
        public string SoDienThoai { get; set; }
        public string Gmail { get; set; }
        public DateTime ThoiGianDangKy { get; set; }
        public bool TrangThaiHoiVien { get; set; }  
        public int MaLoaiHoiVien { get; set; }
        public LoaiHoiVien LoaiHoiVien { get; set; }
    }
}
