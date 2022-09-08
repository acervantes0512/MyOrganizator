using Microsoft.EntityFrameworkCore.Migrations;

namespace MyOrganizator.Modelo.Migrations
{
    public partial class addAllConstraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RolId",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "TipoProyectos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoProyectoId",
                table: "TipoActividads",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlanActividadId",
                table: "TiempoReals",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AsignacionProyectoId",
                table: "Proyectos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoProyectoId",
                table: "Proyectos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Proyectos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProyectoId",
                table: "PlanActividads",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoActividadId",
                table: "PlanActividads",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoTiempoId",
                table: "PlanActividads",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoProyectoId",
                table: "AsignacionTipoProyectos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AsignacionTipoProyectoId",
                table: "AsignacionProyectos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_RolId",
                table: "Usuarios",
                column: "RolId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoProyectos_UsuarioId",
                table: "TipoProyectos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoActividads_TipoProyectoId",
                table: "TipoActividads",
                column: "TipoProyectoId");

            migrationBuilder.CreateIndex(
                name: "IX_TiempoReals_PlanActividadId",
                table: "TiempoReals",
                column: "PlanActividadId");

            migrationBuilder.CreateIndex(
                name: "IX_Proyectos_AsignacionProyectoId",
                table: "Proyectos",
                column: "AsignacionProyectoId");

            migrationBuilder.CreateIndex(
                name: "IX_Proyectos_TipoProyectoId",
                table: "Proyectos",
                column: "TipoProyectoId");

            migrationBuilder.CreateIndex(
                name: "IX_Proyectos_UsuarioId",
                table: "Proyectos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanActividads_ProyectoId",
                table: "PlanActividads",
                column: "ProyectoId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanActividads_TipoActividadId",
                table: "PlanActividads",
                column: "TipoActividadId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanActividads_TipoTiempoId",
                table: "PlanActividads",
                column: "TipoTiempoId");

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionTipoProyectos_TipoProyectoId",
                table: "AsignacionTipoProyectos",
                column: "TipoProyectoId");

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionProyectos_AsignacionTipoProyectoId",
                table: "AsignacionProyectos",
                column: "AsignacionTipoProyectoId");

            migrationBuilder.AddForeignKey(
                name: "FK_AsignacionProyectos_AsignacionTipoProyectos_AsignacionTipoProyectoId",
                table: "AsignacionProyectos",
                column: "AsignacionTipoProyectoId",
                principalTable: "AsignacionTipoProyectos",
                principalColumn: "AsignacionTipoProyectoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AsignacionTipoProyectos_TipoProyectos_TipoProyectoId",
                table: "AsignacionTipoProyectos",
                column: "TipoProyectoId",
                principalTable: "TipoProyectos",
                principalColumn: "TipoProyectoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanActividads_Proyectos_ProyectoId",
                table: "PlanActividads",
                column: "ProyectoId",
                principalTable: "Proyectos",
                principalColumn: "ProyectoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanActividads_TipoActividads_TipoActividadId",
                table: "PlanActividads",
                column: "TipoActividadId",
                principalTable: "TipoActividads",
                principalColumn: "TipoActividadId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanActividads_TipoTiempos_TipoTiempoId",
                table: "PlanActividads",
                column: "TipoTiempoId",
                principalTable: "TipoTiempos",
                principalColumn: "TipoTiempoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Proyectos_AsignacionProyectos_AsignacionProyectoId",
                table: "Proyectos",
                column: "AsignacionProyectoId",
                principalTable: "AsignacionProyectos",
                principalColumn: "AsignacionProyectoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Proyectos_TipoProyectos_TipoProyectoId",
                table: "Proyectos",
                column: "TipoProyectoId",
                principalTable: "TipoProyectos",
                principalColumn: "TipoProyectoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Proyectos_Usuarios_UsuarioId",
                table: "Proyectos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TiempoReals_PlanActividads_PlanActividadId",
                table: "TiempoReals",
                column: "PlanActividadId",
                principalTable: "PlanActividads",
                principalColumn: "PlanActividadId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TipoActividads_TipoProyectos_TipoProyectoId",
                table: "TipoActividads",
                column: "TipoProyectoId",
                principalTable: "TipoProyectos",
                principalColumn: "TipoProyectoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TipoProyectos_Usuarios_UsuarioId",
                table: "TipoProyectos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Rols_RolId",
                table: "Usuarios",
                column: "RolId",
                principalTable: "Rols",
                principalColumn: "RolId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AsignacionProyectos_AsignacionTipoProyectos_AsignacionTipoProyectoId",
                table: "AsignacionProyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_AsignacionTipoProyectos_TipoProyectos_TipoProyectoId",
                table: "AsignacionTipoProyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanActividads_Proyectos_ProyectoId",
                table: "PlanActividads");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanActividads_TipoActividads_TipoActividadId",
                table: "PlanActividads");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanActividads_TipoTiempos_TipoTiempoId",
                table: "PlanActividads");

            migrationBuilder.DropForeignKey(
                name: "FK_Proyectos_AsignacionProyectos_AsignacionProyectoId",
                table: "Proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_Proyectos_TipoProyectos_TipoProyectoId",
                table: "Proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_Proyectos_Usuarios_UsuarioId",
                table: "Proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_TiempoReals_PlanActividads_PlanActividadId",
                table: "TiempoReals");

            migrationBuilder.DropForeignKey(
                name: "FK_TipoActividads_TipoProyectos_TipoProyectoId",
                table: "TipoActividads");

            migrationBuilder.DropForeignKey(
                name: "FK_TipoProyectos_Usuarios_UsuarioId",
                table: "TipoProyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Rols_RolId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_RolId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_TipoProyectos_UsuarioId",
                table: "TipoProyectos");

            migrationBuilder.DropIndex(
                name: "IX_TipoActividads_TipoProyectoId",
                table: "TipoActividads");

            migrationBuilder.DropIndex(
                name: "IX_TiempoReals_PlanActividadId",
                table: "TiempoReals");

            migrationBuilder.DropIndex(
                name: "IX_Proyectos_AsignacionProyectoId",
                table: "Proyectos");

            migrationBuilder.DropIndex(
                name: "IX_Proyectos_TipoProyectoId",
                table: "Proyectos");

            migrationBuilder.DropIndex(
                name: "IX_Proyectos_UsuarioId",
                table: "Proyectos");

            migrationBuilder.DropIndex(
                name: "IX_PlanActividads_ProyectoId",
                table: "PlanActividads");

            migrationBuilder.DropIndex(
                name: "IX_PlanActividads_TipoActividadId",
                table: "PlanActividads");

            migrationBuilder.DropIndex(
                name: "IX_PlanActividads_TipoTiempoId",
                table: "PlanActividads");

            migrationBuilder.DropIndex(
                name: "IX_AsignacionTipoProyectos_TipoProyectoId",
                table: "AsignacionTipoProyectos");

            migrationBuilder.DropIndex(
                name: "IX_AsignacionProyectos_AsignacionTipoProyectoId",
                table: "AsignacionProyectos");

            migrationBuilder.DropColumn(
                name: "RolId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "TipoProyectos");

            migrationBuilder.DropColumn(
                name: "TipoProyectoId",
                table: "TipoActividads");

            migrationBuilder.DropColumn(
                name: "PlanActividadId",
                table: "TiempoReals");

            migrationBuilder.DropColumn(
                name: "AsignacionProyectoId",
                table: "Proyectos");

            migrationBuilder.DropColumn(
                name: "TipoProyectoId",
                table: "Proyectos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Proyectos");

            migrationBuilder.DropColumn(
                name: "ProyectoId",
                table: "PlanActividads");

            migrationBuilder.DropColumn(
                name: "TipoActividadId",
                table: "PlanActividads");

            migrationBuilder.DropColumn(
                name: "TipoTiempoId",
                table: "PlanActividads");

            migrationBuilder.DropColumn(
                name: "TipoProyectoId",
                table: "AsignacionTipoProyectos");

            migrationBuilder.DropColumn(
                name: "AsignacionTipoProyectoId",
                table: "AsignacionProyectos");
        }
    }
}
