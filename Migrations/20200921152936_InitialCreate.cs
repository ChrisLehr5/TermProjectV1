using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TermProjectV1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Membership",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(maxLength: 30, nullable: false),
                    gender = table.Column<string>(nullable: true),
                    address = table.Column<string>(maxLength: 50, nullable: true),
                    city = table.Column<string>(maxLength: 30, nullable: true),
                    state = table.Column<string>(maxLength: 2, nullable: true),
                    zip = table.Column<string>(maxLength: 10, nullable: true),
                    email = table.Column<string>(nullable: true),
                    cell = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membership", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Statistics",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    detailDate = table.Column<DateTime>(nullable: false),
                    age = table.Column<int>(nullable: false),
                    MemberID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistics", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Statistics_Membership_MemberID",
                        column: x => x.MemberID,
                        principalTable: "Membership",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Membership",
                columns: new[] { "ID", "address", "cell", "city", "email", "gender", "name", "state", "zip" },
                values: new object[] { 1, null, null, null, null, null, "Tim Largent", null, null });

            migrationBuilder.InsertData(
                table: "Membership",
                columns: new[] { "ID", "address", "cell", "city", "email", "gender", "name", "state", "zip" },
                values: new object[] { 2, null, null, null, "mlehr@mail.com", null, "Max Lehr", null, null });

            migrationBuilder.InsertData(
                table: "Membership",
                columns: new[] { "ID", "address", "cell", "city", "email", "gender", "name", "state", "zip" },
                values: new object[] { 3, null, null, null, null, null, "Brett Macki", null, null });

            migrationBuilder.InsertData(
                table: "Statistics",
                columns: new[] { "ID", "MemberID", "age", "detailDate" },
                values: new object[] { 1, 1, 34, new DateTime(2020, 9, 21, 11, 29, 36, 500, DateTimeKind.Local).AddTicks(6778) });

            migrationBuilder.InsertData(
                table: "Statistics",
                columns: new[] { "ID", "MemberID", "age", "detailDate" },
                values: new object[] { 2, 2, 31, new DateTime(2020, 9, 21, 11, 29, 36, 502, DateTimeKind.Local).AddTicks(6779) });

            migrationBuilder.InsertData(
                table: "Statistics",
                columns: new[] { "ID", "MemberID", "age", "detailDate" },
                values: new object[] { 3, 3, 37, new DateTime(2020, 9, 21, 11, 29, 36, 502, DateTimeKind.Local).AddTicks(6779) });

            migrationBuilder.CreateIndex(
                name: "IX_Statistics_MemberID",
                table: "Statistics",
                column: "MemberID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Statistics");

            migrationBuilder.DropTable(
                name: "Membership");
        }
    }
}
