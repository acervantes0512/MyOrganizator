using Microsoft.EntityFrameworkCore.Migrations;

namespace MyOrganizator.Data.Migrations
{
    public partial class addReference_PlanActividad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdTipoActividadNavigateIdTipoActividad",
                table: "Plan_Actividad",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Plan_Actividad_IdTipoActividadNavigateIdTipoActividad",
                table: "Plan_Actividad",
                column: "IdTipoActividadNavigateIdTipoActividad");

            migrationBuilder.AddForeignKey(
                name: "FK_Plan_Actividad_Tipo_Actividad_IdTipoActividadNavigateIdTipoActividad",
                table: "Plan_Actividad",
                column: "IdTipoActividadNavigateIdTipoActividad",
                principalTable: "Tipo_Actividad",
                principalColumn: "IdTipoActividad",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plan_Actividad_Tipo_Actividad_IdTipoActividadNavigateIdTipoActividad",
                table: "Plan_Actividad");

            migrationBuilder.DropIndex(
                name: "IX_Plan_Actividad_IdTipoActividadNavigateIdTipoActividad",
                table: "Plan_Actividad");

            migrationBuilder.DropColumn(
                name: "IdTipoActividadNavigateIdTipoActividad",
                table: "Plan_Actividad");
        }
    }
}
