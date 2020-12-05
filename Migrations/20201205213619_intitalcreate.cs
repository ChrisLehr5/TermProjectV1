using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TermProjectV1.Migrations
{
    public partial class intitalcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Membership",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberFullName = table.Column<string>(name: "Member Full Name", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
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
                name: "References",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferenceId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 30, nullable: true),
                    LastName = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_References", x => x.ID);
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

            migrationBuilder.CreateTable(
                name: "MemberReference",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberID = table.Column<int>(nullable: false),
                    ReferenceID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberReference", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MemberReference_Membership_MemberID",
                        column: x => x.MemberID,
                        principalTable: "Membership",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MemberReference_References_ReferenceID",
                        column: x => x.ReferenceID,
                        principalTable: "References",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Membership",
                columns: new[] { "ID", "LastName", "address", "cell", "city", "email", "gender", "Member Full Name", "state", "zip" },
                values: new object[,]
                {
                    { 1, "Largent", null, null, null, null, null, "Tim", null, null },
                    { 2, "Lehr", null, null, null, "mlehr@mail.com", null, "Max", null, null },
                    { 3, "Macki", null, null, null, null, null, "Brett", null, null }
                });

            migrationBuilder.InsertData(
                table: "References",
                columns: new[] { "ID", "LastName", "Name", "ReferenceId" },
                values: new object[,]
                {
                    { 2, "Macki", "Brett", 1 },
                    { 3, "Largent", "Tim", 2 },
                    { 1, "Lehr", "Max ", 3 }
                });

            migrationBuilder.InsertData(
                table: "MemberReference",
                columns: new[] { "ID", "MemberID", "ReferenceID" },
                values: new object[,]
                {
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 1, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Statistics",
                columns: new[] { "ID", "MemberID", "age", "detailDate" },
                values: new object[,]
                {
                    { 1, 1, 34, new DateTime(2020, 12, 5, 16, 36, 19, 389, DateTimeKind.Local).AddTicks(2129) },
                    { 2, 2, 31, new DateTime(2020, 12, 5, 16, 36, 19, 392, DateTimeKind.Local).AddTicks(2131) },
                    { 3, 3, 37, new DateTime(2020, 12, 5, 16, 36, 19, 392, DateTimeKind.Local).AddTicks(2131) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MemberReference_MemberID",
                table: "MemberReference",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "IX_MemberReference_ReferenceID",
                table: "MemberReference",
                column: "ReferenceID");

            migrationBuilder.CreateIndex(
                name: "IX_Statistics_MemberID",
                table: "Statistics",
                column: "MemberID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemberReference");

            migrationBuilder.DropTable(
                name: "Statistics");

            migrationBuilder.DropTable(
                name: "References");

            migrationBuilder.DropTable(
                name: "Membership");
        }
    }
}
