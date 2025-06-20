using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PIII_TrabajoFinal_BilleteraVirtual.Migrations
{
    /// <inheritdoc />
    public partial class crearDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Moneda",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    simbolo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moneda", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    clave = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Cartera",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuarioid = table.Column<int>(type: "int", nullable: false),
                    monedaid = table.Column<int>(type: "int", nullable: false),
                    resumensaldo = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cartera", x => x.id);
                    table.ForeignKey(
                        name: "FK_Cartera_Moneda_monedaid",
                        column: x => x.monedaid,
                        principalTable: "Moneda",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Cartera_Usuarios_usuarioid",
                        column: x => x.usuarioid,
                        principalTable: "Usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Transacciones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    carteraid = table.Column<int>(type: "int", nullable: false),
                    monedaid = table.Column<int>(type: "int", nullable: false),
                    monto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cambio = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transacciones", x => x.id);
                    table.ForeignKey(
                        name: "FK_Transacciones_Cartera_carteraid",
                        column: x => x.carteraid,
                        principalTable: "Cartera",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Transacciones_Moneda_monedaid",
                        column: x => x.monedaid,
                        principalTable: "Moneda",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cartera_monedaid",
                table: "Cartera",
                column: "monedaid");

            migrationBuilder.CreateIndex(
                name: "IX_Cartera_usuarioid",
                table: "Cartera",
                column: "usuarioid");

            migrationBuilder.CreateIndex(
                name: "IX_Transacciones_carteraid",
                table: "Transacciones",
                column: "carteraid");

            migrationBuilder.CreateIndex(
                name: "IX_Transacciones_monedaid",
                table: "Transacciones",
                column: "monedaid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transacciones");

            migrationBuilder.DropTable(
                name: "Cartera");

            migrationBuilder.DropTable(
                name: "Moneda");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
