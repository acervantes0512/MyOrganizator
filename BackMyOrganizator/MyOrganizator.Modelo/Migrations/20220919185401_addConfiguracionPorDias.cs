using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyOrganizator.Modelo.Migrations
{
    public partial class addConfiguracionPorDias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proyectos_AsignacionProyectos_AsignacionProyectoId",
                table: "Proyectos");

            migrationBuilder.DropTable(
                name: "AsignacionProyectos");

            migrationBuilder.DropTable(
                name: "AsignacionTipoProyectos");

            migrationBuilder.DropIndex(
                name: "IX_Proyectos_AsignacionProyectoId",
                table: "Proyectos");

            migrationBuilder.AddColumn<int>(
                name: "AsignacionProyectoPorDiaId",
                table: "Proyectos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AsignacionesTipoProyectoPorDia",
                columns: table => new
                {
                    AsignacionTipoProyectoPorDiaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoProyectoId = table.Column<int>(type: "int", nullable: false),
                    Dia = table.Column<int>(type: "int", nullable: false),
                    Porcentaje = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsignacionesTipoProyectoPorDia", x => x.AsignacionTipoProyectoPorDiaId);
                    table.ForeignKey(
                        name: "FK_AsignacionesTipoProyectoPorDia_TipoProyectos_TipoProyectoId",
                        column: x => x.TipoProyectoId,
                        principalTable: "TipoProyectos",
                        principalColumn: "TipoProyectoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Parametros",
                columns: table => new
                {
                    ParametrosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreación = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametros", x => x.ParametrosId);
                });

            migrationBuilder.CreateTable(
                name: "AsignacionesProyectoPorDia",
                columns: table => new
                {
                    AsignacionProyectoPorDiaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AsignacionTipoProyectoPorDiaId = table.Column<int>(type: "int", nullable: false),
                    Porcentaje = table.Column<int>(type: "int", nullable: false),
                    Dia = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsignacionesProyectoPorDia", x => x.AsignacionProyectoPorDiaId);
                    table.ForeignKey(
                        name: "FK_AsignacionesProyectoPorDia_AsignacionesTipoProyectoPorDia_AsignacionTipoProyectoPorDiaId",
                        column: x => x.AsignacionTipoProyectoPorDiaId,
                        principalTable: "AsignacionesTipoProyectoPorDia",
                        principalColumn: "AsignacionTipoProyectoPorDiaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Proyectos_AsignacionProyectoPorDiaId",
                table: "Proyectos",
                column: "AsignacionProyectoPorDiaId");

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionesProyectoPorDia_AsignacionTipoProyectoPorDiaId",
                table: "AsignacionesProyectoPorDia",
                column: "AsignacionTipoProyectoPorDiaId");

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionesTipoProyectoPorDia_TipoProyectoId",
                table: "AsignacionesTipoProyectoPorDia",
                column: "TipoProyectoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Proyectos_AsignacionesProyectoPorDia_AsignacionProyectoPorDiaId",
                table: "Proyectos",
                column: "AsignacionProyectoPorDiaId",
                principalTable: "AsignacionesProyectoPorDia",
                principalColumn: "AsignacionProyectoPorDiaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proyectos_AsignacionesProyectoPorDia_AsignacionProyectoPorDiaId",
                table: "Proyectos");

            migrationBuilder.DropTable(
                name: "AsignacionesProyectoPorDia");

            migrationBuilder.DropTable(
                name: "Parametros");

            migrationBuilder.DropTable(
                name: "AsignacionesTipoProyectoPorDia");

            migrationBuilder.DropIndex(
                name: "IX_Proyectos_AsignacionProyectoPorDiaId",
                table: "Proyectos");

            migrationBuilder.DropColumn(
                name: "AsignacionProyectoPorDiaId",
                table: "Proyectos");

            migrationBuilder.CreateTable(
                name: "AsignacionTipoProyectos",
                columns: table => new
                {
                    AsignacionTipoProyectoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    Porcentaje = table.Column<int>(type: "int", nullable: false),
                    TipoProyectoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsignacionTipoProyectos", x => x.AsignacionTipoProyectoId);
                    table.ForeignKey(
                        name: "FK_AsignacionTipoProyectos_TipoProyectos_TipoProyectoId",
                        column: x => x.TipoProyectoId,
                        principalTable: "TipoProyectos",
                        principalColumn: "TipoProyectoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AsignacionProyectos",
                columns: table => new
                {
                    AsignacionProyectoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AsignacionTipoProyectoId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    Porcentaje = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsignacionProyectos", x => x.AsignacionProyectoId);
                    table.ForeignKey(
                        name: "FK_AsignacionProyectos_AsignacionTipoProyectos_AsignacionTipoProyectoId",
                        column: x => x.AsignacionTipoProyectoId,
                        principalTable: "AsignacionTipoProyectos",
                        principalColumn: "AsignacionTipoProyectoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Proyectos_AsignacionProyectoId",
                table: "Proyectos",
                column: "AsignacionProyectoId");

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionProyectos_AsignacionTipoProyectoId",
                table: "AsignacionProyectos",
                column: "AsignacionTipoProyectoId");

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionTipoProyectos_TipoProyectoId",
                table: "AsignacionTipoProyectos",
                column: "TipoProyectoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Proyectos_AsignacionProyectos_AsignacionProyectoId",
                table: "Proyectos",
                column: "AsignacionProyectoId",
                principalTable: "AsignacionProyectos",
                principalColumn: "AsignacionProyectoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
