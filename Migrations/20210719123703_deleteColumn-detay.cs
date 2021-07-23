using Microsoft.EntityFrameworkCore.Migrations;

namespace Ders3.Migrations
{
    public partial class deleteColumndetay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Detay",
                table: "Departments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Detay",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
