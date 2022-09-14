using Microsoft.EntityFrameworkCore.Migrations;

namespace MyOrganizator.Modelo.Migrations
{
    public partial class fix_all_foreignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IdRol",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "IdTipoProyecto",
                table: "TipoActividads");

            migrationBuilder.DropColumn(
                name: "IdPlanActividad",
                table: "TiempoReals");

            migrationBuilder.DropColumn(
                name: "IdAsignacionProyecto",
                table: "Proyectos");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Proyectos");

            migrationBuilder.DropColumn(
                name: "IdTipoProyecto",
                table: "AsignacionTipoProyectos");

            migrationBuilder.DropColumn(
                name: "IdAsignacionTipoProy",
                table: "AsignacionProyectos");

            migrationBuilder.AlterColumn<int>(
                name: "RolId",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "TipoProyectos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TipoProyectoId",
                table: "TipoActividads",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PlanActividadId",
                table: "TiempoReals",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Proyectos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AsignacionProyectoId",
                table: "Proyectos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TipoTiempoId",
                table: "PlanActividads",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TipoActividadId",
                table: "PlanActividads",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProyectoId",
                table: "PlanActividads",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TipoProyectoId",
                table: "AsignacionTipoProyectos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AsignacionTipoProyectoId",
                table: "AsignacionProyectos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AsignacionProyectos_AsignacionTipoProyectos_AsignacionTipoProyectoId",
                table: "AsignacionProyectos",
                column: "AsignacionTipoProyectoId",
                principalTable: "AsignacionTipoProyectos",
                principalColumn: "AsignacionTipoProyectoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AsignacionTipoProyectos_TipoProyectos_TipoProyectoId",
                table: "AsignacionTipoProyectos",
                column: "TipoProyectoId",
                principalTable: "TipoProyectos",
                principalColumn: "TipoProyectoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanActividads_Proyectos_ProyectoId",
                table: "PlanActividads",
                column: "ProyectoId",
                principalTable: "Proyectos",
                principalColumn: "ProyectoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanActividads_TipoActividads_TipoActividadId",
                table: "PlanActividads",
                column: "TipoActividadId",
                principalTable: "TipoActividads",
                principalColumn: "TipoActividadId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanActividads_TipoTiempos_TipoTiempoId",
                table: "PlanActividads",
                column: "TipoTiempoId",
                principalTable: "TipoTiempos",
                principalColumn: "TipoTiempoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Proyectos_AsignacionProyectos_AsignacionProyectoId",
                table: "Proyectos",
                column: "AsignacionProyectoId",
                principalTable: "AsignacionProyectos",
                principalColumn: "AsignacionProyectoId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Proyectos_Usuarios_UsuarioId",
                table: "Proyectos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TiempoReals_PlanActividads_PlanActividadId",
                table: "TiempoReals",
                column: "PlanActividadId",
                principalTable: "PlanActividads",
                principalColumn: "PlanActividadId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TipoActividads_TipoProyectos_TipoProyectoId",
                table: "TipoActividads",
                column: "TipoProyectoId",
                principalTable: "TipoProyectos",
                principalColumn: "TipoProyectoId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TipoProyectos_Usuarios_UsuarioId",
                table: "TipoProyectos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Rols_RolId",
                table: "Usuarios",
                column: "RolId",
                principalTable: "Rols",
                principalColumn: "RolId",
                onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.AlterColumn<int>(
                name: "RolId",
                table: "Usuarios",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "IdRol",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "TipoProyectos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TipoProyectoId",
                table: "TipoActividads",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "IdTipoProyecto",
                table: "TipoActividads",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "PlanActividadId",
                table: "TiempoReals",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "IdPlanActividad",
                table: "TiempoReals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Proyectos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AsignacionProyectoId",
                table: "Proyectos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "IdAsignacionProyecto",
                table: "Proyectos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdUsuario",
                table: "Proyectos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "TipoTiempoId",
                table: "PlanActividads",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TipoActividadId",
                table: "PlanActividads",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProyectoId",
                table: "PlanActividads",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TipoProyectoId",
                table: "AsignacionTipoProyectos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "IdTipoProyecto",
                table: "AsignacionTipoProyectos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "AsignacionTipoProyectoId",
                table: "AsignacionProyectos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "IdAsignacionTipoProy",
                table: "AsignacionProyectos",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
