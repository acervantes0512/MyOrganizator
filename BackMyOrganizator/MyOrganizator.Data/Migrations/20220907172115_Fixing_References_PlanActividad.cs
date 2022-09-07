using Microsoft.EntityFrameworkCore.Migrations;

namespace MyOrganizator.Data.Migrations
{
    public partial class Fixing_References_PlanActividad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plan_Actividad_Tipo_Actividad_IdTipoActividadNavigateIdTipoActividad",
                table: "Plan_Actividad");

            migrationBuilder.DropForeignKey(
                name: "FK_Plan_Tipo_Actividad",
                table: "Plan_Actividad");

            migrationBuilder.DropForeignKey(
                name: "FK_Plan_Tipo_Tiempo",
                table: "Plan_Actividad");

            migrationBuilder.DropColumn(
                name: "IdProyecto",
                table: "Plan_Actividad");

            migrationBuilder.DropColumn(
                name: "IdTipoActividad",
                table: "Plan_Actividad");

            migrationBuilder.DropColumn(
                name: "IdTipoTiempo",
                table: "Plan_Actividad");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plan_Actividad_Asignacion_Proyecto_AsignacionProyectoIdAsignacionProyecto1",
                table: "Plan_Actividad");

            migrationBuilder.DropForeignKey(
                name: "FK_Plan_Actividad_Tipo_Proyecto_TipoProyectoIdTipoProyecto",
                table: "Plan_Actividad");

            migrationBuilder.DropIndex(
                name: "IX_Plan_Actividad_AsignacionProyectoIdAsignacionProyecto1",
                table: "Plan_Actividad");

            migrationBuilder.DropColumn(
                name: "AsignacionProyectoIdAsignacionProyecto1",
                table: "Plan_Actividad");

            migrationBuilder.RenameColumn(
                name: "TipoProyectoIdTipoProyecto",
                table: "Plan_Actividad",
                newName: "IdTipoActividadNavigateIdTipoActividad");

            migrationBuilder.RenameIndex(
                name: "IX_Plan_Actividad_TipoProyectoIdTipoProyecto",
                table: "Plan_Actividad",
                newName: "IX_Plan_Actividad_IdTipoActividadNavigateIdTipoActividad");

            migrationBuilder.AddColumn<int>(
                name: "IdProyecto",
                table: "Plan_Actividad",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdTipoActividad",
                table: "Plan_Actividad",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdTipoTiempo",
                table: "Plan_Actividad",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Plan_Actividad_IdTipoActividad",
                table: "Plan_Actividad",
                column: "IdTipoActividad");

            migrationBuilder.CreateIndex(
                name: "IX_Plan_Actividad_IdTipoTiempo",
                table: "Plan_Actividad",
                column: "IdTipoTiempo");

            migrationBuilder.AddForeignKey(
                name: "FK_Plan_Actividad_Tipo_Actividad_IdTipoActividadNavigateIdTipoActividad",
                table: "Plan_Actividad",
                column: "IdTipoActividadNavigateIdTipoActividad",
                principalTable: "Tipo_Actividad",
                principalColumn: "IdTipoActividad",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Plan_Tipo_Actividad",
                table: "Plan_Actividad",
                column: "IdTipoActividad",
                principalTable: "Asignacion_Proyecto",
                principalColumn: "IdAsignacionProyecto",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Plan_Tipo_Tiempo",
                table: "Plan_Actividad",
                column: "IdTipoTiempo",
                principalTable: "Tipo_Proyecto",
                principalColumn: "IdTipoProyecto",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
