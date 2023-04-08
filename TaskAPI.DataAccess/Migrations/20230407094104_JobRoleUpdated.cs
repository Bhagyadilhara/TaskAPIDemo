using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class JobRoleUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "AddressNo", "City", "FullName", "JobRole", "Street" },
                values: new object[] { 4, "666", "Piliyandala", "Bhathunu Bhagya", "System Engineer", "Street 4" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 4, 7, 15, 11, 4, 190, DateTimeKind.Local).AddTicks(1173), new DateTime(2023, 4, 12, 15, 11, 4, 190, DateTimeKind.Local).AddTicks(1187) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 4, 7, 15, 11, 4, 190, DateTimeKind.Local).AddTicks(1193), new DateTime(2023, 4, 12, 15, 11, 4, 190, DateTimeKind.Local).AddTicks(1193) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 4, 7, 15, 11, 4, 190, DateTimeKind.Local).AddTicks(1195), new DateTime(2023, 4, 12, 15, 11, 4, 190, DateTimeKind.Local).AddTicks(1196) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 4, 7, 9, 47, 29, 127, DateTimeKind.Local).AddTicks(3591), new DateTime(2023, 4, 12, 9, 47, 29, 127, DateTimeKind.Local).AddTicks(3602) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 4, 7, 9, 47, 29, 127, DateTimeKind.Local).AddTicks(3608), new DateTime(2023, 4, 12, 9, 47, 29, 127, DateTimeKind.Local).AddTicks(3609) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 4, 7, 9, 47, 29, 127, DateTimeKind.Local).AddTicks(3610), new DateTime(2023, 4, 12, 9, 47, 29, 127, DateTimeKind.Local).AddTicks(3611) });
        }
    }
}
