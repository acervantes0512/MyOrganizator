using Microsoft.EntityFrameworkCore.Migrations;

namespace MyOrganizator.Data.Migrations
{
    public partial class addReferenceTipoActividad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoActividadIdTipoActividad",
                table: "Plan_Actividad",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Plan_Actividad_TipoActividadIdTipoActividad",
                table: "Plan_Actividad",
                column: "TipoActividadIdTipoActividad");

            migrationBuilder.AddForeignKey(
                name: "FK_Plan_Actividad_Tipo_Actividad_TipoActividadIdTipoActividad",
                table: "Plan_Actividad",
                column: "TipoActividadIdTipoActividad",
                principalTable: "Tipo_Actividad",
                principalColumn: "IdTipoActividad",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plan_Actividad_Tipo_Actividad_TipoActividadIdTipoActividad",
                table: "Plan_Actividad");

            migrationBuilder.DropIndex(
                name: "IX_Plan_Actividad_TipoActividadIdTipoActividad",
                table: "Plan_Actividad");

            migrationBuilder.DropColumn(
                name: "TipoActividadIdTipoActividad",
                table: "Plan_Actividad");
        }
    }
}
