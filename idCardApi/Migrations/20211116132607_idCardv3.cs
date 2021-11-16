using Microsoft.EntityFrameworkCore.Migrations;

namespace idCardApi.Migrations
{
    public partial class idCardv3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Attented",
                table: "StudentPE",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "StudentPE",
                columns: new[] { "StudentEmail", "PeId", "Attented" },
                values: new object[,]
                {
                    { "jaak.metdebroek@student.pxl.be", 1, false },
                    { "jef.vandebroek@student.pxl.be", 4, false },
                    { "jos.indebroek@student.pxl.be", 4, false },
                    { "jaak.metdebroek@student.pxl.be", 4, false },
                    { "john.zonderbroek@student.pxl.be", 3, false },
                    { "jakie.Uitdebroek@student.pxl.be", 3, false },
                    { "jef.vandebroek@student.pxl.be", 3, false },
                    { "jos.indebroek@student.pxl.be", 3, false },
                    { "jaak.metdebroek@student.pxl.be", 3, false },
                    { "john.zonderbroek@student.pxl.be", 2, false },
                    { "jakie.Uitdebroek@student.pxl.be", 2, false },
                    { "jef.vandebroek@student.pxl.be", 2, false },
                    { "jos.indebroek@student.pxl.be", 2, false },
                    { "jaak.metdebroek@student.pxl.be", 2, false },
                    { "john.zonderbroek@student.pxl.be", 1, false },
                    { "jakie.Uitdebroek@student.pxl.be", 1, false },
                    { "jef.vandebroek@student.pxl.be", 1, false },
                    { "jos.indebroek@student.pxl.be", 1, false },
                    { "jakie.Uitdebroek@student.pxl.be", 4, false },
                    { "john.zonderbroek@student.pxl.be", 4, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentPE",
                keyColumns: new[] { "StudentEmail", "PeId" },
                keyValues: new object[] { "jaak.metdebroek@student.pxl.be", 1 });

            migrationBuilder.DeleteData(
                table: "StudentPE",
                keyColumns: new[] { "StudentEmail", "PeId" },
                keyValues: new object[] { "jaak.metdebroek@student.pxl.be", 2 });

            migrationBuilder.DeleteData(
                table: "StudentPE",
                keyColumns: new[] { "StudentEmail", "PeId" },
                keyValues: new object[] { "jaak.metdebroek@student.pxl.be", 3 });

            migrationBuilder.DeleteData(
                table: "StudentPE",
                keyColumns: new[] { "StudentEmail", "PeId" },
                keyValues: new object[] { "jaak.metdebroek@student.pxl.be", 4 });

            migrationBuilder.DeleteData(
                table: "StudentPE",
                keyColumns: new[] { "StudentEmail", "PeId" },
                keyValues: new object[] { "jakie.Uitdebroek@student.pxl.be", 1 });

            migrationBuilder.DeleteData(
                table: "StudentPE",
                keyColumns: new[] { "StudentEmail", "PeId" },
                keyValues: new object[] { "jakie.Uitdebroek@student.pxl.be", 2 });

            migrationBuilder.DeleteData(
                table: "StudentPE",
                keyColumns: new[] { "StudentEmail", "PeId" },
                keyValues: new object[] { "jakie.Uitdebroek@student.pxl.be", 3 });

            migrationBuilder.DeleteData(
                table: "StudentPE",
                keyColumns: new[] { "StudentEmail", "PeId" },
                keyValues: new object[] { "jakie.Uitdebroek@student.pxl.be", 4 });

            migrationBuilder.DeleteData(
                table: "StudentPE",
                keyColumns: new[] { "StudentEmail", "PeId" },
                keyValues: new object[] { "jef.vandebroek@student.pxl.be", 1 });

            migrationBuilder.DeleteData(
                table: "StudentPE",
                keyColumns: new[] { "StudentEmail", "PeId" },
                keyValues: new object[] { "jef.vandebroek@student.pxl.be", 2 });

            migrationBuilder.DeleteData(
                table: "StudentPE",
                keyColumns: new[] { "StudentEmail", "PeId" },
                keyValues: new object[] { "jef.vandebroek@student.pxl.be", 3 });

            migrationBuilder.DeleteData(
                table: "StudentPE",
                keyColumns: new[] { "StudentEmail", "PeId" },
                keyValues: new object[] { "jef.vandebroek@student.pxl.be", 4 });

            migrationBuilder.DeleteData(
                table: "StudentPE",
                keyColumns: new[] { "StudentEmail", "PeId" },
                keyValues: new object[] { "john.zonderbroek@student.pxl.be", 1 });

            migrationBuilder.DeleteData(
                table: "StudentPE",
                keyColumns: new[] { "StudentEmail", "PeId" },
                keyValues: new object[] { "john.zonderbroek@student.pxl.be", 2 });

            migrationBuilder.DeleteData(
                table: "StudentPE",
                keyColumns: new[] { "StudentEmail", "PeId" },
                keyValues: new object[] { "john.zonderbroek@student.pxl.be", 3 });

            migrationBuilder.DeleteData(
                table: "StudentPE",
                keyColumns: new[] { "StudentEmail", "PeId" },
                keyValues: new object[] { "john.zonderbroek@student.pxl.be", 4 });

            migrationBuilder.DeleteData(
                table: "StudentPE",
                keyColumns: new[] { "StudentEmail", "PeId" },
                keyValues: new object[] { "jos.indebroek@student.pxl.be", 1 });

            migrationBuilder.DeleteData(
                table: "StudentPE",
                keyColumns: new[] { "StudentEmail", "PeId" },
                keyValues: new object[] { "jos.indebroek@student.pxl.be", 2 });

            migrationBuilder.DeleteData(
                table: "StudentPE",
                keyColumns: new[] { "StudentEmail", "PeId" },
                keyValues: new object[] { "jos.indebroek@student.pxl.be", 3 });

            migrationBuilder.DeleteData(
                table: "StudentPE",
                keyColumns: new[] { "StudentEmail", "PeId" },
                keyValues: new object[] { "jos.indebroek@student.pxl.be", 4 });

            migrationBuilder.DropColumn(
                name: "Attented",
                table: "StudentPE");
        }
    }
}
