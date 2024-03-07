using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyBaiGiuXe.Migrations
{
    /// <inheritdoc />
    public partial class InitialApplicationDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaiGiuXes",
                columns: table => new
                {
                    MaBaiGiuXe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenBaiGiuXe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SucChua = table.Column<int>(type: "int", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaiGiuXes", x => x.MaBaiGiuXe);
                });

            migrationBuilder.CreateTable(
                name: "TheGiuXes",
                columns: table => new
                {
                    MaTheGiuXe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ThoiGian = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaBaiGiuXe = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheGiuXes", x => x.MaTheGiuXe);
                    table.ForeignKey(
                        name: "FK_TheGiuXes_BaiGiuXes_MaBaiGiuXe",
                        column: x => x.MaBaiGiuXe,
                        principalTable: "BaiGiuXes",
                        principalColumn: "MaBaiGiuXe",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TheGiuXes_MaBaiGiuXe",
                table: "TheGiuXes",
                column: "MaBaiGiuXe");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TheGiuXes");

            migrationBuilder.DropTable(
                name: "BaiGiuXes");
        }
    }
}
