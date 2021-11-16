using Microsoft.EntityFrameworkCore.Migrations;

namespace idCardApi.Migrations
{
    public partial class idCardv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_PEDates_PEDateId1",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_PEDateId1",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "PEDateId1",
                table: "Students");

            migrationBuilder.CreateTable(
                name: "StudentPE",
                columns: table => new
                {
                    StudentEmail = table.Column<string>(nullable: false),
                    PeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentPE", x => new { x.StudentEmail, x.PeId });
                    table.ForeignKey(
                        name: "FK_StudentPE_PEDates_PeId",
                        column: x => x.PeId,
                        principalTable: "PEDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentPE_Students_StudentEmail",
                        column: x => x.StudentEmail,
                        principalTable: "Students",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentPE_PeId",
                table: "StudentPE",
                column: "PeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentPE");

            migrationBuilder.AddColumn<int>(
                name: "PEDateId1",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_PEDateId1",
                table: "Students",
                column: "PEDateId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_PEDates_PEDateId1",
                table: "Students",
                column: "PEDateId1",
                principalTable: "PEDates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
