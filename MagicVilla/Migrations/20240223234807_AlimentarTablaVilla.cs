using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Detalle...", new DateTime(2024, 2, 23, 20, 48, 5, 824, DateTimeKind.Local).AddTicks(7410), new DateTime(2024, 2, 23, 20, 48, 5, 824, DateTimeKind.Local).AddTicks(7404), "", 50.0, "Villa Real", 5, 200.0 },
                    { 2, "", "Detalle...", new DateTime(2024, 2, 23, 20, 48, 5, 824, DateTimeKind.Local).AddTicks(7413), new DateTime(2024, 2, 23, 20, 48, 5, 824, DateTimeKind.Local).AddTicks(7412), "", 150.0, "Villa Delux", 10, 1500.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
