using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class r : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Registred",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: true),
                    CourseId = table.Column<int>(type: "int", nullable: true),
                    LectsecId = table.Column<int>(type: "int", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registred", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registred_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Registred_LectSects_LectsecId",
                        column: x => x.LectsecId,
                        principalTable: "LectSects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Registred_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Registred_CourseId",
                table: "Registred",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Registred_LectsecId",
                table: "Registred",
                column: "LectsecId");

            migrationBuilder.CreateIndex(
                name: "IX_Registred_StudentId",
                table: "Registred",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
