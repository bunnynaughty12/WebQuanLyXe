using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyBaiGiuXe.Migrations
{
    /// <inheritdoc />
    public partial class AddColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TheGiuXes_BaiGiuXes_MaBaiGiuXe",
                table: "TheGiuXes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TheGiuXes",
                table: "TheGiuXes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BaiGiuXes",
                table: "BaiGiuXes");

            migrationBuilder.RenameTable(
                name: "TheGiuXes",
                newName: "TheGiuXe");

            migrationBuilder.RenameTable(
                name: "BaiGiuXes",
                newName: "BaiGiuXe");

            migrationBuilder.RenameColumn(
                name: "ThoiGian",
                table: "TheGiuXe",
                newName: "ThoiGianVao");

            migrationBuilder.RenameIndex(
                name: "IX_TheGiuXes_MaBaiGiuXe",
                table: "TheGiuXe",
                newName: "IX_TheGiuXe_MaBaiGiuXe");

            migrationBuilder.AddColumn<string>(
                name: "BienSoXe",
                table: "TheGiuXe",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TrangThaiXe",
                table: "TheGiuXe",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TheGiuXe",
                table: "TheGiuXe",
                column: "MaTheGiuXe");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BaiGiuXe",
                table: "BaiGiuXe",
                column: "MaBaiGiuXe");

            migrationBuilder.AddForeignKey(
                name: "FK_TheGiuXe_BaiGiuXe_MaBaiGiuXe",
                table: "TheGiuXe",
                column: "MaBaiGiuXe",
                principalTable: "BaiGiuXe",
                principalColumn: "MaBaiGiuXe",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TheGiuXe_BaiGiuXe_MaBaiGiuXe",
                table: "TheGiuXe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TheGiuXe",
                table: "TheGiuXe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BaiGiuXe",
                table: "BaiGiuXe");

            migrationBuilder.DropColumn(
                name: "BienSoXe",
                table: "TheGiuXe");

            migrationBuilder.DropColumn(
                name: "TrangThaiXe",
                table: "TheGiuXe");

            migrationBuilder.RenameTable(
                name: "TheGiuXe",
                newName: "TheGiuXes");

            migrationBuilder.RenameTable(
                name: "BaiGiuXe",
                newName: "BaiGiuXes");

            migrationBuilder.RenameColumn(
                name: "ThoiGianVao",
                table: "TheGiuXes",
                newName: "ThoiGian");

            migrationBuilder.RenameIndex(
                name: "IX_TheGiuXe_MaBaiGiuXe",
                table: "TheGiuXes",
                newName: "IX_TheGiuXes_MaBaiGiuXe");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TheGiuXes",
                table: "TheGiuXes",
                column: "MaTheGiuXe");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BaiGiuXes",
                table: "BaiGiuXes",
                column: "MaBaiGiuXe");

            migrationBuilder.AddForeignKey(
                name: "FK_TheGiuXes_BaiGiuXes_MaBaiGiuXe",
                table: "TheGiuXes",
                column: "MaBaiGiuXe",
                principalTable: "BaiGiuXes",
                principalColumn: "MaBaiGiuXe",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
