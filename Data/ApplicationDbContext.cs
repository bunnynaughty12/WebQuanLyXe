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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-JD1MVM7\\SQLEXPRESS; Database=QuanLyXe; MultipleActiveResultSets = True; Trusted_connection = True; TrustServerCertificate = True;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TheGiuXe>()
                .HasOne<BaiGiuXe>(s => s.BaiGiuXe)
                .WithMany(g => g.TheGiuXes)
                .HasForeignKey(s => s.MaBaiGiuXe);
        }

        public DbSet<BaiGiuXe> BaiGiuXes { get; set; }
        public DbSet<TheGiuXe> TheGiuXes { get; set; }
    }
}
