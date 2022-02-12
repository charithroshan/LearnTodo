using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoApi.DataAccess.Migrations
{
    public partial class JobRoleFieldAddedToAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobRole",
                table: "Authors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "JobRole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "JobRole",
                value: "System Engineer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "JobRole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "JobRole",
                value: "QA");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 2, 13, 1, 16, 51, 618, DateTimeKind.Local).AddTicks(2601), new DateTime(2022, 2, 18, 1, 16, 51, 618, DateTimeKind.Local).AddTicks(2610) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 2, 13, 1, 16, 51, 618, DateTimeKind.Local).AddTicks(2615), new DateTime(2022, 2, 20, 1, 16, 51, 618, DateTimeKind.Local).AddTicks(2615) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 2, 13, 1, 16, 51, 618, DateTimeKind.Local).AddTicks(2617), new DateTime(2022, 2, 16, 1, 16, 51, 618, DateTimeKind.Local).AddTicks(2617) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobRole",
                table: "Authors");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 2, 11, 22, 43, 23, 311, DateTimeKind.Local).AddTicks(20), new DateTime(2022, 2, 16, 22, 43, 23, 311, DateTimeKind.Local).AddTicks(29) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 2, 11, 22, 43, 23, 311, DateTimeKind.Local).AddTicks(34), new DateTime(2022, 2, 18, 22, 43, 23, 311, DateTimeKind.Local).AddTicks(35) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 2, 11, 22, 43, 23, 311, DateTimeKind.Local).AddTicks(36), new DateTime(2022, 2, 14, 22, 43, 23, 311, DateTimeKind.Local).AddTicks(37) });
        }
    }
}
