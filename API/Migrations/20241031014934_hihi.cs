using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class hihi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "prequisiteId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "prequisiteId",
                table: "Courses");
        }
    }
}
