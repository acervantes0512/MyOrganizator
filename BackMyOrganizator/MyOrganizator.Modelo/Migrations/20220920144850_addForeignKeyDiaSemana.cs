using Microsoft.EntityFrameworkCore.Migrations;

namespace MyOrganizator.Modelo.Migrations
{
    public partial class addForeignKeyDiaSemana : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_AsignacionesTipoProyectoPorDia_DiaSemanaId",
                table: "AsignacionesTipoProyectoPorDia",
                column: "DiaSemanaId");

            migrationBuilder.AddForeignKey(
                name: "FK_AsignacionesTipoProyectoPorDia_DiaSemana_DiaSemanaId",
                table: "AsignacionesTipoProyectoPorDia",
                column: "DiaSemanaId",
                principalTable: "DiaSemana",
                principalColumn: "DiaSemanaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AsignacionesTipoProyectoPorDia_DiaSemana_DiaSemanaId",
                table: "AsignacionesTipoProyectoPorDia");

            migrationBuilder.DropIndex(
                name: "IX_AsignacionesTipoProyectoPorDia_DiaSemanaId",
                table: "AsignacionesTipoProyectoPorDia");
        }
    }
}
