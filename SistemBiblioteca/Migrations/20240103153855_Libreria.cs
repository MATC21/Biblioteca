using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemBiblioteca.Migrations
{
    /// <inheritdoc />
    public partial class Libreria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autor",
                columns: table => new
                {
                    idAutor = table.Column<int>(type: "int", nullable: false),
                    nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    apellido = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__autor__5FC3872DFC917D3F", x => x.idAutor);
                });
            
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    idCategoria = table.Column<int>(type: "int", nullable: false),
                    categoria = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__categori__CD54BC5AF16FA706", x => x.idCategoria);
                });

            migrationBuilder.CreateTable(
                name: "Editorial",
                columns: table => new
                {
                    idEditorial = table.Column<int>(type: "int", nullable: false),
                    nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__editoria__10C1DD0237D2AB48", x => x.idEditorial);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    idRol = table.Column<int>(type: "int", nullable: false),
                    nombreRol = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__roles__C73330E7158EC04F", x => x.idRol);
                });

            migrationBuilder.CreateTable(
                name: "Libro",
                columns: table => new
                {
                    idLibro = table.Column<int>(type: "int", nullable: false),
                    idCategoria = table.Column<int>(type: "int", nullable: true),
                    titulo = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    anio = table.Column<int>(type: "int", nullable: true),
                    estado = table.Column<bool>(type: "bit", nullable: true),
                    precio = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    fechaRegistro = table.Column<DateTime>(type: "date", nullable: true),
                    idAutor = table.Column<int>(type: "int", nullable: true),
                    urlLibro = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    idEditorial = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__libro__EC09C24E87E2C89D", x => x.idLibro);
                    table.ForeignKey(
                        name: "FK__libro__id_autor__49C3F6B7",
                        column: x => x.idAutor,
                        principalTable: "Autor",
                        principalColumn: "idAutor");
                    table.ForeignKey(
                        name: "FK__libro__id_catego__398D8EEE",
                        column: x => x.idCategoria,
                        principalTable: "Categoria",
                        principalColumn: "idCategoria");
                    table.ForeignKey(
                        name: "FK__libro__id_editor__4AB81AF0",
                        column: x => x.idEditorial,
                        principalTable: "Editorial",
                        principalColumn: "idEditorial");
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    idUsuario = table.Column<int>(type: "int", nullable: false),
                    idRol = table.Column<int>(type: "int", nullable: true),
                    nombreUsuario = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    cedula = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    correo = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    telefono = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    contasena = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__usuario__4E3E04AD30DD6C50", x => x.idUsuario);
                    table.ForeignKey(
                        name: "FK_Usuario_Roles",
                        column: x => x.idRol,
                        principalTable: "Roles",
                        principalColumn: "idRol");
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    idVenta = table.Column<int>(type: "int", nullable: false),
                    idUsuario = table.Column<int>(type: "int", nullable: true),
                    subtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    descuento = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    iva = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    total = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    fechaVenta = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ventas__459533BFAE3B2B28", x => x.idVenta);
                    table.ForeignKey(
                        name: "FK__ventas__id_usuar__44FF419A",
                        column: x => x.idUsuario,
                        principalTable: "Usuario",
                        principalColumn: "idUsuario");
                });

            migrationBuilder.CreateTable(
                name: "DetalleVenta",
                columns: table => new
                {
                    idDetalleVenta = table.Column<int>(type: "int", nullable: false),
                    idVenta = table.Column<int>(type: "int", nullable: true),
                    idLibro = table.Column<int>(type: "int", nullable: true),
                    cantidad = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__detalle___5B265D474B79C795", x => x.idDetalleVenta);
                    table.ForeignKey(
                        name: "FK__detalle_v__id_li__48CFD27E",
                        column: x => x.idLibro,
                        principalTable: "Libro",
                        principalColumn: "idLibro");
                    table.ForeignKey(
                        name: "FK__detalle_v__id_ve__47DBAE45",
                        column: x => x.idVenta,
                        principalTable: "Ventas",
                        principalColumn: "idVenta");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVenta_idLibro",
                table: "DetalleVenta",
                column: "idLibro");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVenta_idVenta",
                table: "DetalleVenta",
                column: "idVenta");

            migrationBuilder.CreateIndex(
                name: "IX_Libro_idAutor",
                table: "Libro",
                column: "idAutor");

            migrationBuilder.CreateIndex(
                name: "IX_Libro_idCategoria",
                table: "Libro",
                column: "idCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Libro_idEditorial",
                table: "Libro",
                column: "idEditorial");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_idRol",
                table: "Usuario",
                column: "idRol");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_idUsuario",
                table: "Ventas",
                column: "idUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalleVenta");

            migrationBuilder.DropTable(
                name: "Libro");

            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "Autor");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Editorial");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
