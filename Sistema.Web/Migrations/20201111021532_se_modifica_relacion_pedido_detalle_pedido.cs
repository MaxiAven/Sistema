using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistema.Web.Migrations
{
    public partial class se_modifica_relacion_pedido_detalle_pedido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_DetallePedido_DetallePedidoId",
                table: "Pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Pedido_PedidoId",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_DetallePedidoId",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_PedidoId",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "DetallePedidoId",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "PedidoId",
                table: "Pedido");

            migrationBuilder.AddColumn<int>(
                name: "PedidosId",
                table: "DetallePedido",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedido_PedidosId",
                table: "DetallePedido",
                column: "PedidosId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetallePedido_Pedido_PedidosId",
                table: "DetallePedido",
                column: "PedidosId",
                principalTable: "Pedido",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallePedido_Pedido_PedidosId",
                table: "DetallePedido");

            migrationBuilder.DropIndex(
                name: "IX_DetallePedido_PedidosId",
                table: "DetallePedido");

            migrationBuilder.DropColumn(
                name: "PedidosId",
                table: "DetallePedido");

            migrationBuilder.AddColumn<int>(
                name: "DetallePedidoId",
                table: "Pedido",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PedidoId",
                table: "Pedido",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_DetallePedidoId",
                table: "Pedido",
                column: "DetallePedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_PedidoId",
                table: "Pedido",
                column: "PedidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_DetallePedido_DetallePedidoId",
                table: "Pedido",
                column: "DetallePedidoId",
                principalTable: "DetallePedido",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Pedido_PedidoId",
                table: "Pedido",
                column: "PedidoId",
                principalTable: "Pedido",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
