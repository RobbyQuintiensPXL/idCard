using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace idCardApi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Email = table.Column<string>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    Firstname = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Role = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "Lectors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Role = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    CourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lectors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lectors_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PEDates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    CourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PEDates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PEDates_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourses",
                columns: table => new
                {
                    StudentEmail = table.Column<string>(nullable: false),
                    CourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourses", x => new { x.StudentEmail, x.CourseId });
                    table.ForeignKey(
                        name: "FK_StudentCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCourses_Students_StudentEmail",
                        column: x => x.StudentEmail,
                        principalTable: "Students",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, ".Net Expert" },
                    { 2, "Java Expert" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Email", "Firstname", "Id", "Name", "Role" },
                values: new object[,]
                {
                    { "jaak.metdebroek@student.pxl.be", "Jaak", 1, "Metdebroek", 0 },
                    { "jos.indebroek@student.pxl.be", "Jos", 2, "Indebroek", 0 },
                    { "jef.vandebroek@student.pxl.be", "Jef", 3, "Vandebroek", 0 }
                });

            migrationBuilder.InsertData(
                table: "Lectors",
                columns: new[] { "Id", "CourseId", "Email", "Firstname", "Name", "Role" },
                values: new object[] { 1, 1, "kris.hermans@pxl.be", "Kris", "Hermans", 1 });

            migrationBuilder.InsertData(
                table: "Lectors",
                columns: new[] { "Id", "CourseId", "Email", "Firstname", "Name", "Role" },
                values: new object[] { 2, 2, "tom.schuyten@pxl.be", "Tom", "Schuyten", 1 });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "StudentEmail", "CourseId" },
                values: new object[] { "jaak.metdebroek@student.pxl.be", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Lectors_CourseId",
                table: "Lectors",
                column: "CourseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PEDates_CourseId",
                table: "PEDates",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_CourseId",
                table: "StudentCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Email",
                table: "Students",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lectors");

            migrationBuilder.DropTable(
                name: "PEDates");

            migrationBuilder.DropTable(
                name: "StudentCourses");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
