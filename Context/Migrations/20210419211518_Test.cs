using Microsoft.EntityFrameworkCore.Migrations;

namespace Context.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Clave",
                table: "DeportistasNiveles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Clave",
                table: "DeportistasNiveles",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
