using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TermProjectV1.Migrations
{
    public partial class MemberReference : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_References",
                table: "References");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "References",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "ReferenceId",
                table: "References",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_References",
                table: "References",
                column: "ID");

            migrationBuilder.UpdateData(
                table: "Membership",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "LastName", "Member Full Name" },
                values: new object[] { "Largent", "Tim" });

            migrationBuilder.UpdateData(
                table: "Membership",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "LastName", "Member Full Name" },
                values: new object[] { "Lehr", "Max" });

            migrationBuilder.UpdateData(
                table: "Membership",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "LastName", "Member Full Name" },
                values: new object[] { "Macki", "Brett" });

            migrationBuilder.UpdateData(
                table: "References",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "LastName", "Name" },
                values: new object[] { "Lehr", "Max " });

            migrationBuilder.UpdateData(
                table: "References",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "LastName", "Name" },
                values: new object[] { "Macki", "Brett" });

            migrationBuilder.UpdateData(
                table: "References",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "LastName", "Name" },
                values: new object[] { "Largent", "Tim" });

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "ID",
                keyValue: 1,
                column: "detailDate",
                value: new DateTime(2020, 11, 16, 16, 20, 8, 373, DateTimeKind.Local).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "ID",
                keyValue: 2,
                column: "detailDate",
                value: new DateTime(2020, 11, 16, 16, 20, 8, 376, DateTimeKind.Local).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "ID",
                keyValue: 3,
                column: "detailDate",
                value: new DateTime(2020, 11, 16, 16, 20, 8, 376, DateTimeKind.Local).AddTicks(5438));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_References",
                table: "References");

            migrationBuilder.AlterColumn<int>(
                name: "ReferenceId",
                table: "References",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "References",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_References",
                table: "References",
                column: "ReferenceId");

            migrationBuilder.UpdateData(
                table: "Membership",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "LastName", "Member Full Name" },
                values: new object[] { "Frank", "Tim Largent" });

            migrationBuilder.UpdateData(
                table: "Membership",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "LastName", "Member Full Name" },
                values: new object[] { "Frank", "Max Lehr" });

            migrationBuilder.UpdateData(
                table: "Membership",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "LastName", "Member Full Name" },
                values: new object[] { "Frank", "Brett Macki" });

            migrationBuilder.UpdateData(
                table: "References",
                keyColumn: "ReferenceId",
                keyValue: 1,
                columns: new[] { "LastName", "Name" },
                values: new object[] { "Frank", "Brett Macki" });

            migrationBuilder.UpdateData(
                table: "References",
                keyColumn: "ReferenceId",
                keyValue: 2,
                columns: new[] { "LastName", "Name" },
                values: new object[] { "Frank", "Tim Largent" });

            migrationBuilder.UpdateData(
                table: "References",
                keyColumn: "ReferenceId",
                keyValue: 3,
                columns: new[] { "LastName", "Name" },
                values: new object[] { "Frank", "Max Lehr" });

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
    }
}
