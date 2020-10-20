using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TermProjectV1.Migrations
{
    public partial class DataAnnotations3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date Enrolled",
                value: new DateTime(2020, 10, 20, 19, 13, 58, 856, DateTimeKind.Local).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date Enrolled",
                value: new DateTime(2020, 10, 20, 19, 13, 58, 859, DateTimeKind.Local).AddTicks(85));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date Enrolled",
                value: new DateTime(2020, 10, 20, 19, 13, 58, 859, DateTimeKind.Local).AddTicks(85));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date Enrolled",
                value: new DateTime(2020, 10, 20, 19, 10, 53, 579, DateTimeKind.Local).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date Enrolled",
                value: new DateTime(2020, 10, 20, 19, 10, 53, 582, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date Enrolled",
                value: new DateTime(2020, 10, 20, 19, 10, 53, 582, DateTimeKind.Local).AddTicks(4113));
        }
    }
}
