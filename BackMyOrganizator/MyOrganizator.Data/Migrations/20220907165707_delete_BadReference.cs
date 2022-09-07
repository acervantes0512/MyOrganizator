using Microsoft.EntityFrameworkCore.Migrations;

namespace MyOrganizator.Data.Migrations
{
    public partial class delete_BadReference : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plan_Proyecto",
                table: "Plan_Actividad");
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
