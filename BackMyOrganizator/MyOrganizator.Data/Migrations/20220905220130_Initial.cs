using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyOrganizator.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    IdRol = table.Column<int>(type: "int", nullable: false),
                    NombreRol = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Rol__2A49584CB8B5884D", x => x.IdRol);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_Tiempo",
                columns: table => new
                {
                    IdTipoTiempo = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Tipo_Tie__3AF868254FF705F1", x => x.IdTipoTiempo);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    NombreUsuario = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    Clave = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "date", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    IdRol = table.Column<int>(type: "int", nullable: false),
                    PrimerNombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('PrimerNombre')"),
                    SegundoNombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('SegundoNombre')"),
                    PrimerApellido = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('PrimerApellido')"),
                    SegundoApellido = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('SegundoApellido')"),
                    Alias = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('Alias')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Usuario__5B65BF97C61B55D0", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_USUARIO_ROL",
                        column: x => x.IdRol,
                        principalTable: "Rol",
                        principalColumn: "IdRol",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_Proyecto",
                columns: table => new
                {
                    IdTipoProyecto = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    IdUsuario1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Tipo_Pro__6EFCA3D96E0DE853", x => x.IdTipoProyecto);
                    table.ForeignKey(
                        name: "FK_Tipo_Proyecto_Usuario_IdUsuario1",
                        column: x => x.IdUsuario1,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Asignacion_Tipo_Proyecto",
                columns: table => new
                {
                    IdAsignacionTipoProy = table.Column<int>(type: "int", nullable: false),
                    IdTipoProyecto = table.Column<int>(type: "int", nullable: false),
                    Porcentaje = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Asignaci__FB8453C836A76DE2", x => x.IdAsignacionTipoProy);
                    table.ForeignKey(
                        name: "FK_ASIGNACION_TIPO_PROY_TIPO_PROY",
                        column: x => x.IdTipoProyecto,
                        principalTable: "Tipo_Proyecto",
                        principalColumn: "IdTipoProyecto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_Actividad",
                columns: table => new
                {
                    IdTipoActividad = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    IdTipoProyecto = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Tipo_Act__3CFA6B037C38C880", x => x.IdTipoActividad);
                    table.ForeignKey(
                        name: "FK_Tipo_Actividad_Asignacion_Proyecto",
                        column: x => x.IdTipoActividad,
                        principalTable: "Tipo_Proyecto",
                        principalColumn: "IdTipoProyecto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Asignacion_Proyecto",
                columns: table => new
                {
                    IdAsignacionProyecto = table.Column<int>(type: "int", nullable: false),
                    IdAsignacionTipoProy = table.Column<int>(type: "int", nullable: false),
                    Porcentaje = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Asignaci__2AEDC5E705BE466B", x => x.IdAsignacionProyecto);
                    table.ForeignKey(
                        name: "FK_Asignacion_Proyecto_Asig_Tipo_Proy",
                        column: x => x.IdAsignacionProyecto,
                        principalTable: "Asignacion_Tipo_Proyecto",
                        principalColumn: "IdAsignacionTipoProy",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Plan_Actividad",
                columns: table => new
                {
                    IdPlanActividad = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    DuracionMinutos = table.Column<int>(type: "int", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime", nullable: false),
                    OrdenEjecucion = table.Column<int>(type: "int", nullable: false),
                    IdTipoTiempo = table.Column<int>(type: "int", nullable: false),
                    IdTipoActividad = table.Column<int>(type: "int", nullable: false),
                    IdProyecto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Plan_Act__1393B5D36306DCEA", x => x.IdPlanActividad);
                    table.ForeignKey(
                        name: "FK_Plan_Proyecto",
                        column: x => x.IdProyecto,
                        principalTable: "Asignacion_Proyecto",
                        principalColumn: "IdAsignacionProyecto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Plan_Tipo_Actividad",
                        column: x => x.IdTipoActividad,
                        principalTable: "Asignacion_Proyecto",
                        principalColumn: "IdAsignacionProyecto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Plan_Tipo_Tiempo",
                        column: x => x.IdTipoTiempo,
                        principalTable: "Tipo_Proyecto",
                        principalColumn: "IdTipoProyecto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Proyecto",
                columns: table => new
                {
                    IdProyecto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    Etiqueta = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime", nullable: false),
                    DuracionMinutos = table.Column<int>(type: "int", nullable: false),
                    IdTipoProyecto = table.Column<int>(type: "int", nullable: false),
                    IdAsignacionProyecto = table.Column<int>(type: "int", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Proyecto__F4888673BA610081", x => x.IdProyecto);
                    table.ForeignKey(
                        name: "FK_Asignacion_Proyecto",
                        column: x => x.IdAsignacionProyecto,
                        principalTable: "Asignacion_Proyecto",
                        principalColumn: "IdAsignacionProyecto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Proyecto_Tipo_Proyecto",
                        column: x => x.IdTipoProyecto,
                        principalTable: "Tipo_Proyecto",
                        principalColumn: "IdTipoProyecto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Usuario_Proyecto",
                        column: x => x.IdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tiempo_Real",
                columns: table => new
                {
                    IdTiempoReal = table.Column<int>(type: "int", nullable: false),
                    IdPlanActividad = table.Column<int>(type: "int", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime", nullable: true),
                    DuracionMinutos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Tiempo_R__3411891EE84AACE1", x => x.IdTiempoReal);
                    table.ForeignKey(
                        name: "FK_Tiempo_Real_Plan",
                        column: x => x.IdPlanActividad,
                        principalTable: "Plan_Actividad",
                        principalColumn: "IdPlanActividad",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asignacion_Tipo_Proyecto_IdTipoProyecto",
                table: "Asignacion_Tipo_Proyecto",
                column: "IdTipoProyecto");

            migrationBuilder.CreateIndex(
                name: "IX_Plan_Actividad_IdProyecto",
                table: "Plan_Actividad",
                column: "IdProyecto");

            migrationBuilder.CreateIndex(
                name: "IX_Plan_Actividad_IdTipoActividad",
                table: "Plan_Actividad",
                column: "IdTipoActividad");

            migrationBuilder.CreateIndex(
                name: "IX_Plan_Actividad_IdTipoTiempo",
                table: "Plan_Actividad",
                column: "IdTipoTiempo");

            migrationBuilder.CreateIndex(
                name: "IX_Proyecto_IdAsignacionProyecto",
                table: "Proyecto",
                column: "IdAsignacionProyecto");

            migrationBuilder.CreateIndex(
                name: "IX_Proyecto_IdTipoProyecto",
                table: "Proyecto",
                column: "IdTipoProyecto");

            migrationBuilder.CreateIndex(
                name: "IX_Proyecto_IdUsuario",
                table: "Proyecto",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Tiempo_Real_IdPlanActividad",
                table: "Tiempo_Real",
                column: "IdPlanActividad");

            migrationBuilder.CreateIndex(
                name: "IX_Tipo_Proyecto_IdUsuario1",
                table: "Tipo_Proyecto",
                column: "IdUsuario1");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_IdRol",
                table: "Usuario",
                column: "IdRol");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Proyecto");

            migrationBuilder.DropTable(
                name: "Tiempo_Real");

            migrationBuilder.DropTable(
                name: "Tipo_Actividad");

            migrationBuilder.DropTable(
                name: "Tipo_Tiempo");

            migrationBuilder.DropTable(
                name: "Plan_Actividad");

            migrationBuilder.DropTable(
                name: "Asignacion_Proyecto");

            migrationBuilder.DropTable(
                name: "Asignacion_Tipo_Proyecto");

            migrationBuilder.DropTable(
                name: "Tipo_Proyecto");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Rol");
        }
    }
}
