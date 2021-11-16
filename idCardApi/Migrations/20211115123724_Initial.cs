using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace idCardApi.Migrations
{
    public partial class Initial : Migration
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
                name: "Lectors",
                columns: table => new
                {
                    Email = table.Column<string>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    Firstname = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Role = table.Column<int>(nullable: false),
                    CourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lectors", x => x.Email);
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
                name: "Students",
                columns: table => new
                {
                    Email = table.Column<string>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    Firstname = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Role = table.Column<int>(nullable: false),
                    PEDateId = table.Column<int>(nullable: true),
                    PEDateId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Email);
                    table.ForeignKey(
                        name: "FK_Students_PEDates_PEDateId",
                        column: x => x.PEDateId,
                        principalTable: "PEDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_PEDates_PEDateId1",
                        column: x => x.PEDateId1,
                        principalTable: "PEDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                columns: new[] { "Email", "Firstname", "Id", "Name", "PEDateId", "PEDateId1", "Role" },
                values: new object[,]
                {
                    { "jaak.metdebroek@student.pxl.be", "Jaak", 1, "Metdebroek", null, null, 0 },
                    { "jos.indebroek@student.pxl.be", "Jos", 2, "Indebroek", null, null, 0 },
                    { "jef.vandebroek@student.pxl.be", "Jef", 3, "Vandebroek", null, null, 0 },
                    { "jakie.Uitdebroek@student.pxl.be", "Jakie", 4, "Uitdebroek", null, null, 0 },
                    { "john.zonderbroek@student.pxl.be", "John", 5, "Zonderbroek", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Lectors",
                columns: new[] { "Email", "CourseId", "Firstname", "Id", "Name", "Role" },
                values: new object[,]
                {
                    { "kris.hermans@pxl.be", 1, "Kris", 1, "Hermans", 1 },
                    { "tom.schuyten@pxl.be", 2, "Tom", 2, "Schuyten", 1 }
                });

            migrationBuilder.InsertData(
                table: "PEDates",
                columns: new[] { "Id", "CourseId", "Date", "Type" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2, 1, new DateTime(2021, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "StudentEmail", "CourseId" },
                values: new object[,]
                {
                    { "jaak.metdebroek@student.pxl.be", 1 },
                    { "jaak.metdebroek@student.pxl.be", 2 },
                    { "jos.indebroek@student.pxl.be", 1 },
                    { "jos.indebroek@student.pxl.be", 2 },
                    { "jef.vandebroek@student.pxl.be", 1 },
                    { "jef.vandebroek@student.pxl.be", 2 },
                    { "jakie.Uitdebroek@student.pxl.be", 1 },
                    { "jakie.Uitdebroek@student.pxl.be", 2 },
                    { "john.zonderbroek@student.pxl.be", 1 },
                    { "john.zonderbroek@student.pxl.be", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lectors_CourseId",
                table: "Lectors",
                column: "CourseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lectors_Email",
                table: "Lectors",
                column: "Email",
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

            migrationBuilder.CreateIndex(
                name: "IX_Students_PEDateId",
                table: "Students",
                column: "PEDateId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_PEDateId1",
                table: "Students",
                column: "PEDateId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lectors");

            migrationBuilder.DropTable(
                name: "StudentCourses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "PEDates");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
