using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class Coursess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LectSects_Rooms_RoomId",
                table: "LectSects");

            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "LectSects",
                newName: "RoomSId");

            migrationBuilder.RenameIndex(
                name: "IX_LectSects_RoomId",
                table: "LectSects",
                newName: "IX_LectSects_RoomSId");

            migrationBuilder.AddColumn<int>(
                name: "RoomLId",
                table: "LectSects",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Term",
                table: "LectSects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LectSects_RoomLId",
                table: "LectSects",
                column: "RoomLId");

            migrationBuilder.AddForeignKey(
                name: "FK_LectSects_Rooms_RoomLId",
                table: "LectSects",
                column: "RoomLId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LectSects_Rooms_RoomSId",
                table: "LectSects",
                column: "RoomSId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LectSects_Rooms_RoomLId",
                table: "LectSects");

            migrationBuilder.DropForeignKey(
                name: "FK_LectSects_Rooms_RoomSId",
                table: "LectSects");

            migrationBuilder.DropIndex(
                name: "IX_LectSects_RoomLId",
                table: "LectSects");

            migrationBuilder.DropColumn(
                name: "RoomLId",
                table: "LectSects");

            migrationBuilder.DropColumn(
                name: "Term",
                table: "LectSects");

            migrationBuilder.RenameColumn(
                name: "RoomSId",
                table: "LectSects",
                newName: "RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_LectSects_RoomSId",
                table: "LectSects",
                newName: "IX_LectSects_RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_LectSects_Rooms_RoomId",
                table: "LectSects",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
