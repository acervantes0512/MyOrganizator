using Microsoft.EntityFrameworkCore.Migrations;

namespace MyOrganizator.Modelo.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoProyectos",
                columns: table => new
                {
                    TipoProyectoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoProyectos", x => x.TipoProyectoId);
                });

            migrationBuilder.CreateTable(
                name: "TipoActividad",
                columns: table => new
                {
                    TipoActividadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdTipoProyecto = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    TipoProyectoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoActividad", x => x.TipoActividadId);
                    table.ForeignKey(
                        name: "FK_TipoActividad_TipoProyectos_TipoProyectoId",
                        column: x => x.TipoProyectoId,
                        principalTable: "TipoProyectos",
                        principalColumn: "TipoProyectoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TipoActividad_TipoProyectoId",
                table: "TipoActividad",
                column: "TipoProyectoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TipoActividad");

            migrationBuilder.DropTable(
                name: "TipoProyectos");
        }
    }
}
