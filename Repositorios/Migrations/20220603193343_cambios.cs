using Microsoft.EntityFrameworkCore.Migrations;

namespace Repositorios.Migrations
{
    public partial class cambios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlantasId",
                table: "TiposPlantas");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Plantas");

            migrationBuilder.DropColumn(
                name: "CompraUsuarioId",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Compras");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlantasId",
                table: "TiposPlantas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "Plantas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompraUsuarioId",
                table: "Compras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "Compras",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
