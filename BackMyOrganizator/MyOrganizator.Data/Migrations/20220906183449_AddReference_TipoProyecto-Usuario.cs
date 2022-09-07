using Microsoft.EntityFrameworkCore.Migrations;

namespace MyOrganizator.Data.Migrations
{
    public partial class AddReference_TipoProyectoUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoProyectoIdTipoProyecto",
                table: "Usuario",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdUsuario",
                table: "Tipo_Proyecto",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_TipoProyectoIdTipoProyecto",
                table: "Usuario",
                column: "TipoProyectoIdTipoProyecto");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Tipo_Proyecto_TipoProyectoIdTipoProyecto",
                table: "Usuario",
                column: "TipoProyectoIdTipoProyecto",
                principalTable: "Tipo_Proyecto",
                principalColumn: "IdTipoProyecto",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Tipo_Proyecto_TipoProyectoIdTipoProyecto",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_TipoProyectoIdTipoProyecto",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "TipoProyectoIdTipoProyecto",
                table: "Usuario");

            migrationBuilder.AlterColumn<int>(
                name: "IdUsuario",
                table: "Tipo_Proyecto",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
