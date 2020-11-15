using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistema.Web.Migrations
{
    public partial class se_sube_base_de_datos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RazonSocial = table.Column<string>(maxLength: 50, nullable: false),
                    Documento = table.Column<int>(maxLength: 20, nullable: false),
                    Telefono = table.Column<int>(maxLength: 20, nullable: false),
                    Email = table.Column<string>(maxLength: 20, nullable: false),
                    Direccion = table.Column<string>(maxLength: 100, nullable: false),
                    Localidad = table.Column<string>(maxLength: 20, nullable: false),
                    Provincia = table.Column<string>(maxLength: 20, nullable: false),
                    CodigoPostal = table.Column<int>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
