using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class addednewww : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_TAs_CollegeId_CollegeName",
                table: "TAs",
                columns: new[] { "CollegeId", "CollegeName" });

            migrationBuilder.AddForeignKey(
                name: "FK_TAs_Colleges_CollegeId_CollegeName",
                table: "TAs",
                columns: new[] { "CollegeId", "CollegeName" },
                principalTable: "Colleges",
                principalColumns: new[] { "Id", "Name" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TAs_Colleges_CollegeId_CollegeName",
                table: "TAs");

            migrationBuilder.DropIndex(
                name: "IX_TAs_CollegeId_CollegeName",
                table: "TAs");

            migrationBuilder.DropColumn(
                name: "CollegeId",
                table: "TAs");

            migrationBuilder.DropColumn(
                name: "CollegeName",
                table: "TAs");
        }
    }
}
