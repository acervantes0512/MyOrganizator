using Microsoft.EntityFrameworkCore.Migrations;

namespace MyOrganizator.Modelo.Migrations
{
    public partial class campoSemanaId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DiaSemanaId",
                table: "AsignacionesTipoProyectoPorDia",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiaSemanaId",
                table: "AsignacionesTipoProyectoPorDia");
        }
    }
}
