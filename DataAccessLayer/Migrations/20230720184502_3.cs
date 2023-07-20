using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AlibabaPBYS.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class _3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "BrandId", "CarModelId", "CarType", "ExaminationDate", "ExaminationDuration", "IsExaminated", "NextExaminationDate", "Plate" },
                values: new object[,]
                {
                    { 1, 1, 1, "Otomobil", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "01ABS01" },
                    { 2, 1, 2, "Otomobil", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "01ABS01" },
                    { 3, 2, 3, "Otomobil", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "01ABS01" },
                    { 4, 2, 4, "Otomobil", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "01ABS01" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
