using Microsoft.EntityFrameworkCore.Migrations;

namespace MyOrganizator.Modelo.Migrations
{
    public partial class prueba_FK_Ajuste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proyectos_TipoProyectos_TipoProyectoId",
                table: "Proyectos");

            migrationBuilder.DropColumn(
                name: "IdTipoProyecto",
                table: "Proyectos");

            migrationBuilder.AlterColumn<int>(
                name: "TipoProyectoId",
                table: "Proyectos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Proyectos_TipoProyectos_TipoProyectoId",
                table: "Proyectos",
                column: "TipoProyectoId",
                principalTable: "TipoProyectos",
                principalColumn: "TipoProyectoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proyectos_TipoProyectos_TipoProyectoId",
                table: "Proyectos");

            migrationBuilder.AlterColumn<int>(
                name: "TipoProyectoId",
                table: "Proyectos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "IdTipoProyecto",
                table: "Proyectos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Proyectos_TipoProyectos_TipoProyectoId",
                table: "Proyectos",
                column: "TipoProyectoId",
                principalTable: "TipoProyectos",
                principalColumn: "TipoProyectoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
