using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class addDepts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Colleges_CollegeId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_CollegeId",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Colleges",
                table: "Colleges");

            migrationBuilder.AddColumn<int>(
                name: "CollegeId1",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CollegeName",
                table: "Departments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colleges",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Colleges",
                table: "Colleges",
                columns: new[] { "Id", "Name" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Colleges_CollegeId1_CollegeName",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_CollegeId1_CollegeName",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Colleges",
                table: "Colleges");

            migrationBuilder.DropColumn(
                name: "CollegeId1",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "CollegeName",
                table: "Departments");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colleges",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Colleges",
                table: "Colleges",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_CollegeId",
                table: "Departments",
                column: "CollegeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Colleges_CollegeId",
                table: "Departments",
                column: "CollegeId",
                principalTable: "Colleges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
