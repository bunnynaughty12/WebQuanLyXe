using Microsoft.EntityFrameworkCore;
using QuanLyBaiGiuXe.Models;
using System.Diagnostics;

namespace QuanLyBaiGiuXe.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TheGiuXe>()
                .HasOne<BaiGiuXe>(s => s.BaiGiuXe)
                .WithMany(g => g.TheGiuXes)
                .HasForeignKey(s => s.MaBaiGiuXe);

            modelBuilder.Entity<TheGiuXe>()
                .HasOne<LoaiXe>(s => s.LoaiXe)
                .WithMany(g => g.TheGiuXe)
                .HasForeignKey(s => s.MaLoaiXe);

            modelBuilder.Entity<TheGiuXe>()
                .HasOne<BangGia>(s => s.BangGia)
                .WithMany(g => g.TheGiuXe)
                .HasForeignKey(s => s.MaGiaGiuXe);

            modelBuilder.Entity<HoiVien>()
                .HasOne<LoaiHoiVien>(s => s.LoaiHoiVien)
                .WithMany(g => g.HoiVien)
                .HasForeignKey(s => s.MaLoaiHoiVien);

            modelBuilder.Entity<LoaiHoiVien>()
                .HasOne<BangGia>(s => s.BangGia)
                .WithMany(g => g.LoaiHoiVien)
                .HasForeignKey(s => s.MaGia);

            modelBuilder.Entity<LoaiHoiVien>()
                .HasOne<LoaiXe>(s => s.LoaiXe)
                .WithMany(g => g.LoaiHoiVien)
                .HasForeignKey(s => s.MaLoaiXe);
        }

        public DbSet<BaiGiuXe> BaiGiuXe { get; set; }
        public DbSet<TheGiuXe> TheGiuXe { get; set; }

        public DbSet<BangGia> BangGia { get; set; }
        public DbSet<LoaiXe> LoaiXe { get; set;}
    }
}
