using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistema.Web.Migrations
{
    public partial class se_vuelve_a_modifcar_relaciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Pedido_PedidoId",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_PedidoId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "PedidoId",
                table: "Clientes");

            migrationBuilder.AddColumn<int>(
                name: "ClientesId",
                table: "Pedido",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ClientesId",
                table: "Pedido",
                column: "ClientesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Clientes_ClientesId",
                table: "Pedido",
                column: "ClientesId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Clientes_ClientesId",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_ClientesId",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "ClientesId",
                table: "Pedido");

            migrationBuilder.AddColumn<int>(
                name: "PedidoId",
                table: "Clientes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_PedidoId",
                table: "Clientes",
                column: "PedidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Pedido_PedidoId",
                table: "Clientes",
                column: "PedidoId",
                principalTable: "Pedido",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
