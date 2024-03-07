using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyBaiGiuXe.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gia",
                table: "TheGiuXe");

            migrationBuilder.AddColumn<int>(
                name: "MaGiaGiuXe",
                table: "TheGiuXe",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaLoaiXe",
                table: "TheGiuXe",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BangGia",
                columns: table => new
                {
                    MaGiaGiuXe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GiaGiuXe = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BangGia", x => x.MaGiaGiuXe);
                });

            migrationBuilder.CreateTable(
                name: "LoaiXe",
                columns: table => new
                {
                    MaLoaiXe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiXe = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiXe", x => x.MaLoaiXe);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TheGiuXe_MaGiaGiuXe",
                table: "TheGiuXe",
                column: "MaGiaGiuXe");

            migrationBuilder.CreateIndex(
                name: "IX_TheGiuXe_MaLoaiXe",
                table: "TheGiuXe",
                column: "MaLoaiXe");

            migrationBuilder.AddForeignKey(
                name: "FK_TheGiuXe_BangGia_MaGiaGiuXe",
                table: "TheGiuXe",
                column: "MaGiaGiuXe",
                principalTable: "BangGia",
                principalColumn: "MaGiaGiuXe",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TheGiuXe_LoaiXe_MaLoaiXe",
                table: "TheGiuXe",
                column: "MaLoaiXe",
                principalTable: "LoaiXe",
                principalColumn: "MaLoaiXe",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TheGiuXe_BangGia_MaGiaGiuXe",
                table: "TheGiuXe");

            migrationBuilder.DropForeignKey(
                name: "FK_TheGiuXe_LoaiXe_MaLoaiXe",
                table: "TheGiuXe");

            migrationBuilder.DropTable(
                name: "BangGia");

            migrationBuilder.DropTable(
                name: "LoaiXe");

            migrationBuilder.DropIndex(
                name: "IX_TheGiuXe_MaGiaGiuXe",
                table: "TheGiuXe");

            migrationBuilder.DropIndex(
                name: "IX_TheGiuXe_MaLoaiXe",
                table: "TheGiuXe");

            migrationBuilder.DropColumn(
                name: "MaGiaGiuXe",
                table: "TheGiuXe");

            migrationBuilder.DropColumn(
                name: "MaLoaiXe",
                table: "TheGiuXe");

            migrationBuilder.AddColumn<decimal>(
                name: "Gia",
                table: "TheGiuXe",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
