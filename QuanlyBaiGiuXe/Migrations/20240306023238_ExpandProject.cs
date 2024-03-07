using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyBaiGiuXe.Migrations
{
    /// <inheritdoc />
    public partial class ExpandProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoaiHoiVien",
                columns: table => new
                {
                    MaLoaiHoiVien = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiHoiVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaGia = table.Column<int>(type: "int", nullable: false),
                    MaLoaiXe = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiHoiVien", x => x.MaLoaiHoiVien);
                    table.ForeignKey(
                        name: "FK_LoaiHoiVien_BangGia_MaGia",
                        column: x => x.MaGia,
                        principalTable: "BangGia",
                        principalColumn: "MaGiaGiuXe",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoaiHoiVien_LoaiXe_MaLoaiXe",
                        column: x => x.MaLoaiXe,
                        principalTable: "LoaiXe",
                        principalColumn: "MaLoaiXe",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoiVien",
                columns: table => new
                {
                    MaHoiVien = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhachHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThoiGianDangKy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThaiHoiVien = table.Column<bool>(type: "bit", nullable: false),
                    MaLoaiHoiVien = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoiVien", x => x.MaHoiVien);
                    table.ForeignKey(
                        name: "FK_HoiVien_LoaiHoiVien_MaLoaiHoiVien",
                        column: x => x.MaLoaiHoiVien,
                        principalTable: "LoaiHoiVien",
                        principalColumn: "MaLoaiHoiVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HoiVien_MaLoaiHoiVien",
                table: "HoiVien",
                column: "MaLoaiHoiVien");

            migrationBuilder.CreateIndex(
                name: "IX_LoaiHoiVien_MaGia",
                table: "LoaiHoiVien",
                column: "MaGia");

            migrationBuilder.CreateIndex(
                name: "IX_LoaiHoiVien_MaLoaiXe",
                table: "LoaiHoiVien",
                column: "MaLoaiXe");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoiVien");

            migrationBuilder.DropTable(
                name: "LoaiHoiVien");
        }
    }
}
