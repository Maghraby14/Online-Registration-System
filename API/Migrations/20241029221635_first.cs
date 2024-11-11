using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Colleges_CollegeId_CollegeName",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_TAs_Colleges_CollegeId_CollegeName",
                table: "TAs");

            migrationBuilder.DropIndex(
                name: "IX_TAs_CollegeId_CollegeName",
                table: "TAs");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_CollegeId_CollegeName",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "CollegeId",
                table: "TAs");

            migrationBuilder.DropColumn(
                name: "CollegeName",
                table: "TAs");

            migrationBuilder.DropColumn(
                name: "CollegeId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "CollegeName",
                table: "Doctors");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CollegeId",
                table: "TAs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CollegeName",
                table: "TAs",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CollegeId",
                table: "Doctors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CollegeName",
                table: "Doctors",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TAs_CollegeId_CollegeName",
                table: "TAs",
                columns: new[] { "CollegeId", "CollegeName" });

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_CollegeId_CollegeName",
                table: "Doctors",
                columns: new[] { "CollegeId", "CollegeName" });

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Colleges_CollegeId_CollegeName",
                table: "Doctors",
                columns: new[] { "CollegeId", "CollegeName" },
                principalTable: "Colleges",
                principalColumns: new[] { "Id", "Name" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TAs_Colleges_CollegeId_CollegeName",
                table: "TAs",
                columns: new[] { "CollegeId", "CollegeName" },
                principalTable: "Colleges",
                principalColumns: new[] { "Id", "Name" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
