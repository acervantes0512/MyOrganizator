using Microsoft.EntityFrameworkCore.Migrations;

namespace MyOrganizator.Data.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          migrationBuilder.AddColumn<int>(
              name: "IdUsuario",
              table: "Tipo_Proyecto",
              type: "int",
              nullable: true);
    }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
