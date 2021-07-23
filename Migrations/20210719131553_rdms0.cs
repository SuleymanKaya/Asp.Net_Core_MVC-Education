using Microsoft.EntityFrameworkCore.Migrations;

namespace Ders3.Migrations
{
    public partial class rdms0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "departmentId",
                table: "Personnels",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personnels_departmentId",
                table: "Personnels",
                column: "departmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personnels_Departments_departmentId",
                table: "Personnels",
                column: "departmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personnels_Departments_departmentId",
                table: "Personnels");

            migrationBuilder.DropIndex(
                name: "IX_Personnels_departmentId",
                table: "Personnels");

            migrationBuilder.DropColumn(
                name: "departmentId",
                table: "Personnels");
        }
    }
}
