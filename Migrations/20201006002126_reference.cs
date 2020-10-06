using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TermProjectV1.Migrations
{
    public partial class reference : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "References",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferenceId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_References", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "References",
                columns: new[] { "ID", "Name", "ReferenceId" },
                values: new object[,]
                {
                    { 2, "Brett Macki", 1 },
                    { 3, "Tim Largent", 2 },
                    { 1, "Max Lehr", 3 }
                });

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "ID",
                keyValue: 1,
                column: "detailDate",
                value: new DateTime(2020, 10, 5, 20, 21, 26, 131, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "ID",
                keyValue: 2,
                column: "detailDate",
                value: new DateTime(2020, 10, 5, 20, 21, 26, 134, DateTimeKind.Local).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "ID",
                keyValue: 3,
                column: "detailDate",
                value: new DateTime(2020, 10, 5, 20, 21, 26, 134, DateTimeKind.Local).AddTicks(2));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "References");

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "ID",
                keyValue: 1,
                column: "detailDate",
                value: new DateTime(2020, 9, 21, 11, 29, 36, 500, DateTimeKind.Local).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "ID",
                keyValue: 2,
                column: "detailDate",
                value: new DateTime(2020, 9, 21, 11, 29, 36, 502, DateTimeKind.Local).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "ID",
                keyValue: 3,
                column: "detailDate",
                value: new DateTime(2020, 9, 21, 11, 29, 36, 502, DateTimeKind.Local).AddTicks(6779));
        }
    }
}
