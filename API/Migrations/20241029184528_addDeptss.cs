using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class addDeptss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Colleges_CollegeId1_CollegeName",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_CollegeId1_CollegeName",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "CollegeId1",
                table: "Departments");

            migrationBuilder.AlterColumn<string>(
                name: "CollegeName",
                table: "Departments",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "CollegeId",
                table: "Departments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_CollegeId_CollegeName",
                table: "Departments",
                columns: new[] { "CollegeId", "CollegeName" });

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Colleges_CollegeId_CollegeName",
                table: "Departments",
                columns: new[] { "CollegeId", "CollegeName" },
                principalTable: "Colleges",
                principalColumns: new[] { "Id", "Name" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Colleges_CollegeId_CollegeName",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_CollegeId_CollegeName",
                table: "Departments");

            migrationBuilder.AlterColumn<string>(
                name: "CollegeName",
                table: "Departments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CollegeId",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CollegeId1",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_CollegeId1_CollegeName",
                table: "Departments",
                columns: new[] { "CollegeId1", "CollegeName" });

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Colleges_CollegeId1_CollegeName",
                table: "Departments",
                columns: new[] { "CollegeId1", "CollegeName" },
                principalTable: "Colleges",
                principalColumns: new[] { "Id", "Name" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
