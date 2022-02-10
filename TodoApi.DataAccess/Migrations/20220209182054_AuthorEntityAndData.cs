using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoApi.DataAccess.Migrations
{
    public partial class AuthorEntityAndData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Todos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { 1, "John Doe" },
                    { 2, "Willim Max " },
                    { 3, "Charith Roshan" },
                    { 4, "Allon Mark " }
                });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Created", "Description", "Due" },
                values: new object[] { 1, new DateTime(2022, 2, 9, 23, 50, 54, 585, DateTimeKind.Local).AddTicks(4567), "Learn C# from tutorial", new DateTime(2022, 2, 14, 23, 50, 54, 585, DateTimeKind.Local).AddTicks(4574) });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 2, 1, new DateTime(2022, 2, 9, 23, 50, 54, 585, DateTimeKind.Local).AddTicks(4579), "Learn bootstrap from tutorial", new DateTime(2022, 2, 16, 23, 50, 54, 585, DateTimeKind.Local).AddTicks(4580), 0, "Learn bootstrap" });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 3, 2, new DateTime(2022, 2, 9, 23, 50, 54, 585, DateTimeKind.Local).AddTicks(4581), "Learn Anguler from tutorial", new DateTime(2022, 2, 12, 23, 50, 54, 585, DateTimeKind.Local).AddTicks(4581), 0, "Learn Anguler" });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos");

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Todos");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Description", "Due" },
                values: new object[] { new DateTime(2022, 2, 9, 21, 42, 2, 74, DateTimeKind.Local).AddTicks(905), "Learn C# from tutorial - DB", new DateTime(2022, 2, 14, 21, 42, 2, 74, DateTimeKind.Local).AddTicks(916) });
        }
    }
}
