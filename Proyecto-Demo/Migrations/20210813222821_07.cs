using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto_Demo.Migrations
{
    public partial class _07 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "unomas",
                table: "Productos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "unomas",
                table: "Productos");
        }
    }
}
