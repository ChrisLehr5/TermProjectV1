using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TermProjectV1.Migrations
{
    public partial class _1116Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Member Last Name",
                table: "Membership",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Member Last Name",
                table: "Membership",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "ID",
                keyValue: 1,
                column: "detailDate",
                value: new DateTime(2020, 11, 11, 18, 10, 14, 995, DateTimeKind.Local).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "ID",
                keyValue: 2,
                column: "detailDate",
                value: new DateTime(2020, 11, 11, 18, 10, 14, 998, DateTimeKind.Local).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "ID",
                keyValue: 3,
                column: "detailDate",
                value: new DateTime(2020, 11, 11, 18, 10, 14, 998, DateTimeKind.Local).AddTicks(3513));
        }
    }
}
