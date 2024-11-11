using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class h : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "departmentId",
                table: "LectSects",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LectSects_departmentId",
                table: "LectSects",
                column: "departmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_LectSects_Departments_departmentId",
                table: "LectSects",
                column: "departmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LectSects_Departments_departmentId",
                table: "LectSects");

            migrationBuilder.DropIndex(
                name: "IX_LectSects_departmentId",
                table: "LectSects");

            migrationBuilder.DropColumn(
                name: "departmentId",
                table: "LectSects");
        }
    }
}
