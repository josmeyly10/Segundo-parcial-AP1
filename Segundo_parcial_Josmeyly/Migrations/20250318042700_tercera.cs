using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Segundo_parcial_Josmeyly.Migrations
{
    /// <inheritdoc />
    public partial class tercera : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ciudades",
                columns: table => new
                {
                    CiudadesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Monto = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudades", x => x.CiudadesId);
                });

            migrationBuilder.CreateTable(
                name: "Encuesta",
                columns: table => new
                {
                    EncuestaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Asignatura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Monto = table.Column<double>(type: "float", nullable: false),
                    CiudadesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Encuesta", x => x.EncuestaId);
                    table.ForeignKey(
                        name: "FK_Encuesta_Ciudades_CiudadesId",
                        column: x => x.CiudadesId,
                        principalTable: "Ciudades",
                        principalColumn: "CiudadesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetalleCiudad",
                columns: table => new
                {
                    DetalleCiudadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MontoCuenta = table.Column<double>(type: "float", nullable: false),
                    EncuestaId = table.Column<int>(type: "int", nullable: false),
                    CiudadesId = table.Column<int>(type: "int", nullable: true),
                    CiudadesId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleCiudad", x => x.DetalleCiudadId);
                    table.ForeignKey(
                        name: "FK_DetalleCiudad_Ciudades_CiudadesId1",
                        column: x => x.CiudadesId1,
                        principalTable: "Ciudades",
                        principalColumn: "CiudadesId");
                    table.ForeignKey(
                        name: "FK_DetalleCiudad_Encuesta_CiudadesId",
                        column: x => x.CiudadesId,
                        principalTable: "Encuesta",
                        principalColumn: "EncuestaId");
                    table.ForeignKey(
                        name: "FK_DetalleCiudad_Encuesta_EncuestaId",
                        column: x => x.EncuestaId,
                        principalTable: "Encuesta",
                        principalColumn: "EncuestaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ciudades",
                columns: new[] { "CiudadesId", "Monto", "Nombres" },
                values: new object[,]
                {
                    { 1, 0.0, "Villa Arriba" },
                    { 2, 0.0, "San francisco" },
                    { 3, 0.0, "San Pedro de macoris" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCiudad_CiudadesId",
                table: "DetalleCiudad",
                column: "CiudadesId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCiudad_CiudadesId1",
                table: "DetalleCiudad",
                column: "CiudadesId1");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCiudad_EncuestaId",
                table: "DetalleCiudad",
                column: "EncuestaId");

            migrationBuilder.CreateIndex(
                name: "IX_Encuesta_CiudadesId",
                table: "Encuesta",
                column: "CiudadesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalleCiudad");

            migrationBuilder.DropTable(
                name: "Encuesta");

            migrationBuilder.DropTable(
                name: "Ciudades");
        }
    }
}
