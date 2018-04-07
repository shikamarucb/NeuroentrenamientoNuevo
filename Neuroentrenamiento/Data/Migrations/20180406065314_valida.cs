using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Neuroentrenamiento.Data.Migrations
{
    public partial class valida : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Periodo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Dia = table.Column<int>(nullable: false),
                    Semana = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Periodo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prueba",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prueba", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PruebaPeriodo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Id_Periodo = table.Column<int>(nullable: false),
                    Id_Prueba = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PruebaPeriodo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PruebaPeriodo_Periodo_Id_Periodo",
                        column: x => x.Id_Periodo,
                        principalTable: "Periodo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PruebaPeriodo_Prueba_Id_Prueba",
                        column: x => x.Id_Prueba,
                        principalTable: "Prueba",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Resultados",
                columns: table => new
                {
                    Id_PruebaPeriodo = table.Column<int>(nullable: false),
                    Id_ApplicationUser = table.Column<string>(nullable: false),
                    Puntaje = table.Column<int>(nullable: false),
                    Tiempo = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resultados", x => new { x.Id_PruebaPeriodo, x.Id_ApplicationUser });
                    table.ForeignKey(
                        name: "FK_Resultados_AspNetUsers_Id_ApplicationUser",
                        column: x => x.Id_ApplicationUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Resultados_PruebaPeriodo_Id_PruebaPeriodo",
                        column: x => x.Id_PruebaPeriodo,
                        principalTable: "PruebaPeriodo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PruebaPeriodo_Id_Periodo",
                table: "PruebaPeriodo",
                column: "Id_Periodo");

            migrationBuilder.CreateIndex(
                name: "IX_PruebaPeriodo_Id_Prueba",
                table: "PruebaPeriodo",
                column: "Id_Prueba");

            migrationBuilder.CreateIndex(
                name: "IX_Resultados_Id_ApplicationUser",
                table: "Resultados",
                column: "Id_ApplicationUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Resultados");

            migrationBuilder.DropTable(
                name: "PruebaPeriodo");

            migrationBuilder.DropTable(
                name: "Periodo");

            migrationBuilder.DropTable(
                name: "Prueba");
        }
    }
}
