using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class JobRoleFieldAdded : Migration
    {
        /// <inheritdoc />
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
                value: "QA");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "JobRole",
                value: "Developer");

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

        /// <inheritdoc />
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
                values: new object[] { new DateTime(2023, 3, 24, 13, 32, 9, 44, DateTimeKind.Local).AddTicks(9659), new DateTime(2023, 3, 29, 13, 32, 9, 44, DateTimeKind.Local).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 3, 24, 13, 32, 9, 44, DateTimeKind.Local).AddTicks(9676), new DateTime(2023, 3, 29, 13, 32, 9, 44, DateTimeKind.Local).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 3, 24, 13, 32, 9, 44, DateTimeKind.Local).AddTicks(9678), new DateTime(2023, 3, 29, 13, 32, 9, 44, DateTimeKind.Local).AddTicks(9678) });
        }
    }
}
