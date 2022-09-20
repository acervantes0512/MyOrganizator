using Microsoft.EntityFrameworkCore.Migrations;

namespace MyOrganizator.Modelo.Migrations
{
    public partial class addTableDiasSemana : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dia",
                table: "AsignacionesTipoProyectoPorDia");

            migrationBuilder.DropColumn(
                name: "Dia",
                table: "AsignacionesProyectoPorDia");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Dia",
                table: "AsignacionesTipoProyectoPorDia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Dia",
                table: "AsignacionesProyectoPorDia",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
