using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TermProjectV1.Migrations
{
    public partial class _1116Update3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "ID",
                keyValue: 1,
                column: "detailDate",
                value: new DateTime(2020, 11, 16, 14, 29, 1, 134, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "ID",
                keyValue: 2,
                column: "detailDate",
                value: new DateTime(2020, 11, 16, 14, 29, 1, 136, DateTimeKind.Local).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "ID",
                keyValue: 3,
                column: "detailDate",
                value: new DateTime(2020, 11, 16, 14, 29, 1, 136, DateTimeKind.Local).AddTicks(1995));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "ID",
                keyValue: 1,
                column: "detailDate",
                value: new DateTime(2020, 11, 16, 14, 11, 34, 580, DateTimeKind.Local).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "ID",
                keyValue: 2,
                column: "detailDate",
                value: new DateTime(2020, 11, 16, 14, 11, 34, 582, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "ID",
                keyValue: 3,
                column: "detailDate",
                value: new DateTime(2020, 11, 16, 14, 11, 34, 582, DateTimeKind.Local).AddTicks(3400));
        }
    }
}
