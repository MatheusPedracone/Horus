using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Horus.Migrations
{
    public partial class AddFantasyName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FantasyName",
                table: "Clients",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FantasyName",
                table: "Clients");
        }
    }
}
