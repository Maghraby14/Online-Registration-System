using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class hihii : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LectSects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorId = table.Column<int>(type: "int", nullable: true),
                    TAId = table.Column<int>(type: "int", nullable: true),
                    GroupId = table.Column<int>(type: "int", nullable: true),
                    RoomId = table.Column<int>(type: "int", nullable: true),
                    CoursesId = table.Column<int>(type: "int", nullable: true),
                    LectFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LectTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Lectday = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SectFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SectTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sectday = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LectSects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LectSects_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LectSects_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LectSects_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LectSects_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LectSects_TAs_TAId",
                        column: x => x.TAId,
                        principalTable: "TAs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LectSects_CoursesId",
                table: "LectSects",
                column: "CoursesId");

            migrationBuilder.CreateIndex(
                name: "IX_LectSects_DoctorId",
                table: "LectSects",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_LectSects_GroupId",
                table: "LectSects",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_LectSects_RoomId",
                table: "LectSects",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_LectSects_TAId",
                table: "LectSects",
                column: "TAId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LectSects");
        }
    }
}
