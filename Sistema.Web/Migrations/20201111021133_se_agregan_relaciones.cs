using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistema.Web.Migrations
{
    public partial class se_agregan_relaciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Documento",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Localidad",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Provincia",
                table: "Clientes");

            migrationBuilder.AddColumn<int>(
                name: "DocumentoId",
                table: "Clientes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocalidadId",
                table: "Clientes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PedidoId",
                table: "Clientes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProvinciaId",
                table: "Clientes",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DetallePedido",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cantidad = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallePedido", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Documento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Localidad",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localidad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provincia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(maxLength: 100, nullable: false),
                    ProvinciaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Provincia_Provincia_ProvinciaId",
                        column: x => x.ProvinciaId,
                        principalTable: "Provincia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Fecha = table.Column<DateTime>(nullable: false),
                    DetallePedidoId = table.Column<int>(nullable: true),
                    PedidoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedido_DetallePedido_DetallePedidoId",
                        column: x => x.DetallePedidoId,
                        principalTable: "DetallePedido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedido_Pedido_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_DocumentoId",
                table: "Clientes",
                column: "DocumentoId",
                unique: true,
                filter: "[DocumentoId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_LocalidadId",
                table: "Clientes",
                column: "LocalidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_PedidoId",
                table: "Clientes",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ProvinciaId",
                table: "Clientes",
                column: "ProvinciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_DetallePedidoId",
                table: "Pedido",
                column: "DetallePedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_PedidoId",
                table: "Pedido",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Provincia_ProvinciaId",
                table: "Provincia",
                column: "ProvinciaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Documento_DocumentoId",
                table: "Clientes",
                column: "DocumentoId",
                principalTable: "Documento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Localidad_LocalidadId",
                table: "Clientes",
                column: "LocalidadId",
                principalTable: "Localidad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Pedido_PedidoId",
                table: "Clientes",
                column: "PedidoId",
                principalTable: "Pedido",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Provincia_ProvinciaId",
                table: "Clientes",
                column: "ProvinciaId",
                principalTable: "Provincia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Documento_DocumentoId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Localidad_LocalidadId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Pedido_PedidoId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Provincia_ProvinciaId",
                table: "Clientes");

            migrationBuilder.DropTable(
                name: "Documento");

            migrationBuilder.DropTable(
                name: "Localidad");

            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "Provincia");

            migrationBuilder.DropTable(
                name: "DetallePedido");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_DocumentoId",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_LocalidadId",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_PedidoId",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_ProvinciaId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "DocumentoId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "LocalidadId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "PedidoId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "ProvinciaId",
                table: "Clientes");

            migrationBuilder.AddColumn<string>(
                name: "Documento",
                table: "Clientes",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Localidad",
                table: "Clientes",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Provincia",
                table: "Clientes",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }
    }
}
