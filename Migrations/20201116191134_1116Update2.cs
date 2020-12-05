using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TermProjectV1.Migrations
{
    public partial class _1116Update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Member Last Name",
                table: "Membership",
                newName: "LastName");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Membership",
                newName: "Member Last Name");

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "ID",
                keyValue: 1,
                column: "detailDate",
                value: new DateTime(2020, 11, 16, 14, 5, 21, 614, DateTimeKind.Local).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "ID",
                keyValue: 2,
                column: "detailDate",
                value: new DateTime(2020, 11, 16, 14, 5, 21, 617, DateTimeKind.Local).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "ID",
                keyValue: 3,
                column: "detailDate",
                value: new DateTime(2020, 11, 16, 14, 5, 21, 617, DateTimeKind.Local).AddTicks(76));
        }
    }
}
