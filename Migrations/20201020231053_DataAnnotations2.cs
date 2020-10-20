using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TermProjectV1.Migrations
{
    public partial class DataAnnotations2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_References",
                table: "References");

            migrationBuilder.RenameColumn(
                name: "detailDate",
                table: "Statistics",
                newName: "Date Enrolled");

            migrationBuilder.AlterColumn<int>(
                name: "ReferenceId",
                table: "References",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "References",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_References",
                table: "References",
                column: "ReferenceId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_References",
                table: "References");

            migrationBuilder.RenameColumn(
                name: "Date Enrolled",
                table: "Statistics",
                newName: "detailDate");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "References",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "ReferenceId",
                table: "References",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_References",
                table: "References",
                column: "ID");

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "ID",
                keyValue: 1,
                column: "detailDate",
                value: new DateTime(2020, 10, 20, 18, 39, 36, 844, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "ID",
                keyValue: 2,
                column: "detailDate",
                value: new DateTime(2020, 10, 20, 18, 39, 36, 846, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "ID",
                keyValue: 3,
                column: "detailDate",
                value: new DateTime(2020, 10, 20, 18, 39, 36, 846, DateTimeKind.Local).AddTicks(681));
        }
    }
}
