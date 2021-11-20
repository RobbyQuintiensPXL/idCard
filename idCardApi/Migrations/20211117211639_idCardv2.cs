using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace idCardApi.Migrations
{
    public partial class idCardv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "Lectors",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
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
                    StudentEmail = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "StudentPEs",
                columns: table => new
                {
                    StudentEmail = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PeId = table.Column<int>(type: "int", nullable: false),
                    Attented = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentPEs", x => new { x.StudentEmail, x.PeId });
                    table.ForeignKey(
                        name: "FK_StudentPEs_PEDates_PeId",
                        column: x => x.PeId,
                        principalTable: "PEDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentPEs_Students_StudentEmail",
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
                    { "jef.vandebroek@student.pxl.be", "Jef", 3, "Vandebroek", 0 },
                    { "jakie.Uitdebroek@student.pxl.be", "Jakie", 4, "Uitdebroek", 0 },
                    { "john.zonderbroek@student.pxl.be", "John", 5, "Zonderbroek", 0 }
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
                    { 2, 1, new DateTime(2021, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, 1, new DateTime(2021, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 3, 2, new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentEmail" },
                values: new object[,]
                {
                    { 1, "jaak.metdebroek@student.pxl.be" },
                    { 2, "jaak.metdebroek@student.pxl.be" },
                    { 1, "jos.indebroek@student.pxl.be" },
                    { 2, "jos.indebroek@student.pxl.be" },
                    { 1, "jef.vandebroek@student.pxl.be" },
                    { 2, "jef.vandebroek@student.pxl.be" },
                    { 1, "jakie.Uitdebroek@student.pxl.be" },
                    { 2, "jakie.Uitdebroek@student.pxl.be" },
                    { 1, "john.zonderbroek@student.pxl.be" },
                    { 2, "john.zonderbroek@student.pxl.be" }
                });

            migrationBuilder.InsertData(
                table: "StudentPEs",
                columns: new[] { "PeId", "StudentEmail", "Attented" },
                values: new object[,]
                {
                    { 1, "jaak.metdebroek@student.pxl.be", false },
                    { 3, "jef.vandebroek@student.pxl.be", false },
                    { 3, "jos.indebroek@student.pxl.be", false },
                    { 3, "jaak.metdebroek@student.pxl.be", false },
                    { 4, "john.zonderbroek@student.pxl.be", false },
                    { 4, "jakie.Uitdebroek@student.pxl.be", false },
                    { 4, "jef.vandebroek@student.pxl.be", false },
                    { 4, "jos.indebroek@student.pxl.be", false },
                    { 4, "jaak.metdebroek@student.pxl.be", false },
                    { 2, "john.zonderbroek@student.pxl.be", false },
                    { 2, "jakie.Uitdebroek@student.pxl.be", false },
                    { 2, "jef.vandebroek@student.pxl.be", false },
                    { 2, "jos.indebroek@student.pxl.be", false },
                    { 2, "jaak.metdebroek@student.pxl.be", false },
                    { 1, "john.zonderbroek@student.pxl.be", false },
                    { 1, "jakie.Uitdebroek@student.pxl.be", false },
                    { 1, "jef.vandebroek@student.pxl.be", false },
                    { 1, "jos.indebroek@student.pxl.be", false },
                    { 3, "jakie.Uitdebroek@student.pxl.be", false },
                    { 3, "john.zonderbroek@student.pxl.be", false }
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
                name: "IX_StudentPEs_PeId",
                table: "StudentPEs",
                column: "PeId");

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
                name: "StudentCourses");

            migrationBuilder.DropTable(
                name: "StudentPEs");

            migrationBuilder.DropTable(
                name: "PEDates");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
