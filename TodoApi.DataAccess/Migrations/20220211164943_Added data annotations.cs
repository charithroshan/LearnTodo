using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoApi.DataAccess.Migrations
{
    public partial class Addeddataannotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 2, 11, 22, 19, 43, 634, DateTimeKind.Local).AddTicks(4877), new DateTime(2022, 2, 16, 22, 19, 43, 634, DateTimeKind.Local).AddTicks(4888) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 2, 11, 22, 19, 43, 634, DateTimeKind.Local).AddTicks(4896), new DateTime(2022, 2, 18, 22, 19, 43, 634, DateTimeKind.Local).AddTicks(4897) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 2, 11, 22, 19, 43, 634, DateTimeKind.Local).AddTicks(4898), new DateTime(2022, 2, 14, 22, 19, 43, 634, DateTimeKind.Local).AddTicks(4898) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 2, 9, 23, 50, 54, 585, DateTimeKind.Local).AddTicks(4567), new DateTime(2022, 2, 14, 23, 50, 54, 585, DateTimeKind.Local).AddTicks(4574) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 2, 9, 23, 50, 54, 585, DateTimeKind.Local).AddTicks(4579), new DateTime(2022, 2, 16, 23, 50, 54, 585, DateTimeKind.Local).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 2, 9, 23, 50, 54, 585, DateTimeKind.Local).AddTicks(4581), new DateTime(2022, 2, 12, 23, 50, 54, 585, DateTimeKind.Local).AddTicks(4581) });
        }
    }
}
