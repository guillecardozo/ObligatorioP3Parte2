using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repositorios.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fichas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FrecuenciaRiego = table.Column<string>(nullable: true),
                    TipoIluminacion = table.Column<string>(nullable: true),
                    Temperatura = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fichas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tasas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TasaImportacion = table.Column<decimal>(nullable: false),
                    TasaIva = table.Column<decimal>(nullable: false),
                    TasaArancelaria = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposPlantas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    Descripcion = table.Column<string>(maxLength: 200, nullable: true),
                    PlantasId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposPlantas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Rol = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCompra = table.Column<DateTime>(nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    TasasId = table.Column<int>(nullable: true),
                    CompraUsuarioId = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    ContinenteOrigen = table.Column<bool>(nullable: true),
                    MedidasSanitarias = table.Column<string>(nullable: true),
                    CostoFlete = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Compras_Tasas_TasasId",
                        column: x => x.TasasId,
                        principalTable: "Tasas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Plantas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCientifico = table.Column<string>(nullable: false),
                    NombreVulgar = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(maxLength: 500, nullable: true),
                    TipoAmbiente = table.Column<string>(nullable: true),
                    Altura = table.Column<decimal>(nullable: false),
                    Foto = table.Column<string>(nullable: false),
                    Precio = table.Column<decimal>(nullable: false),
                    FichaCuidadosId = table.Column<int>(nullable: true),
                    TipoPlantaId = table.Column<int>(nullable: true),
                    ItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plantas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plantas_Fichas_FichaCuidadosId",
                        column: x => x.FichaCuidadosId,
                        principalTable: "Fichas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Plantas_TiposPlantas_TipoPlantaId",
                        column: x => x.TipoPlantaId,
                        principalTable: "TiposPlantas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ComprasUsuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompraId = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComprasUsuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComprasUsuarios_Compras_CompraId",
                        column: x => x.CompraId,
                        principalTable: "Compras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComprasUsuarios_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantaId = table.Column<int>(nullable: false),
                    CompraId = table.Column<int>(nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    PrecioUnitario = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Compras_CompraId",
                        column: x => x.CompraId,
                        principalTable: "Compras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_Plantas_PlantaId",
                        column: x => x.PlantaId,
                        principalTable: "Plantas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Compras_TasasId",
                table: "Compras",
                column: "TasasId");

            migrationBuilder.CreateIndex(
                name: "IX_ComprasUsuarios_CompraId",
                table: "ComprasUsuarios",
                column: "CompraId");

            migrationBuilder.CreateIndex(
                name: "IX_ComprasUsuarios_UsuarioId",
                table: "ComprasUsuarios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CompraId",
                table: "Items",
                column: "CompraId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_PlantaId",
                table: "Items",
                column: "PlantaId");

            migrationBuilder.CreateIndex(
                name: "IX_Plantas_FichaCuidadosId",
                table: "Plantas",
                column: "FichaCuidadosId");

            migrationBuilder.CreateIndex(
                name: "IX_Plantas_TipoPlantaId",
                table: "Plantas",
                column: "TipoPlantaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComprasUsuarios");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropTable(
                name: "Plantas");

            migrationBuilder.DropTable(
                name: "Tasas");

            migrationBuilder.DropTable(
                name: "Fichas");

            migrationBuilder.DropTable(
                name: "TiposPlantas");
        }
    }
}
