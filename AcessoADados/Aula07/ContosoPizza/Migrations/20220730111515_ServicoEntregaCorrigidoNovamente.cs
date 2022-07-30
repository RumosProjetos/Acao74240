using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContosoPizza.Migrations
{
    public partial class ServicoEntregaCorrigidoNovamente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Data De Assinatura De Contrato",
                table: "Entregadores",
                newName: "DataDeAssinaturaDeContrato");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataDeAssinaturaDeContrato",
                table: "Entregadores",
                newName: "Data De Assinatura De Contrato");
        }
    }
}
