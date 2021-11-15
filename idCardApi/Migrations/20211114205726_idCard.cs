using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace idCardApi.Migrations
{
    public partial class idCard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PEDates",
                columns: new[] { "Id", "CourseId", "Date", "Type" },
                values: new object[] { 1, 1, new DateTime(2021, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PEDates",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
