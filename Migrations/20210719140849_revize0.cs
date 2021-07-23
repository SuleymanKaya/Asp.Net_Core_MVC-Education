using Microsoft.EntityFrameworkCore.Migrations;

namespace Ders3.Migrations
{
    public partial class revize0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personnels_Departments_departmentId",
                table: "Personnels");

            migrationBuilder.RenameColumn(
                name: "departmentId",
                table: "Personnels",
                newName: "DepartmentID");

            migrationBuilder.RenameIndex(
                name: "IX_Personnels_departmentId",
                table: "Personnels",
                newName: "IX_Personnels_DepartmentID");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentID",
                table: "Personnels",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Personnels_Departments_DepartmentID",
                table: "Personnels",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personnels_Departments_DepartmentID",
                table: "Personnels");

            migrationBuilder.RenameColumn(
                name: "DepartmentID",
                table: "Personnels",
                newName: "departmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Personnels_DepartmentID",
                table: "Personnels",
                newName: "IX_Personnels_departmentId");

            migrationBuilder.AlterColumn<int>(
                name: "departmentId",
                table: "Personnels",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Personnels_Departments_departmentId",
                table: "Personnels",
                column: "departmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
