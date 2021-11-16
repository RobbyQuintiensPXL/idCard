using Microsoft.EntityFrameworkCore.Migrations;

namespace idCardApi.Migrations
{
    public partial class idCardv4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentPE_PEDates_PeId",
                table: "StudentPE");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentPE_Students_StudentEmail",
                table: "StudentPE");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_PEDates_PEDateId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_PEDateId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentPE",
                table: "StudentPE");

            migrationBuilder.DropColumn(
                name: "PEDateId",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "StudentPE",
                newName: "StudentPEs");

            migrationBuilder.RenameIndex(
                name: "IX_StudentPE_PeId",
                table: "StudentPEs",
                newName: "IX_StudentPEs_PeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentPEs",
                table: "StudentPEs",
                columns: new[] { "StudentEmail", "PeId" });

            migrationBuilder.AddForeignKey(
                name: "FK_StudentPEs_PEDates_PeId",
                table: "StudentPEs",
                column: "PeId",
                principalTable: "PEDates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentPEs_Students_StudentEmail",
                table: "StudentPEs",
                column: "StudentEmail",
                principalTable: "Students",
                principalColumn: "Email",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentPEs_PEDates_PeId",
                table: "StudentPEs");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentPEs_Students_StudentEmail",
                table: "StudentPEs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentPEs",
                table: "StudentPEs");

            migrationBuilder.RenameTable(
                name: "StudentPEs",
                newName: "StudentPE");

            migrationBuilder.RenameIndex(
                name: "IX_StudentPEs_PeId",
                table: "StudentPE",
                newName: "IX_StudentPE_PeId");

            migrationBuilder.AddColumn<int>(
                name: "PEDateId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentPE",
                table: "StudentPE",
                columns: new[] { "StudentEmail", "PeId" });

            migrationBuilder.CreateIndex(
                name: "IX_Students_PEDateId",
                table: "Students",
                column: "PEDateId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentPE_PEDates_PeId",
                table: "StudentPE",
                column: "PeId",
                principalTable: "PEDates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentPE_Students_StudentEmail",
                table: "StudentPE",
                column: "StudentEmail",
                principalTable: "Students",
                principalColumn: "Email",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_PEDates_PEDateId",
                table: "Students",
                column: "PEDateId",
                principalTable: "PEDates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
