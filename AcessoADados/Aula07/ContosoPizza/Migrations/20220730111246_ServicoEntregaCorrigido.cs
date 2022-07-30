using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContosoPizza.Migrations
{
    public partial class ServicoEntregaCorrigido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Carriers_CarrierModeloDoCarro",
                table: "Pizzas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carriers",
                table: "Carriers");

            migrationBuilder.RenameTable(
                name: "Carriers",
                newName: "Entregadores");

            migrationBuilder.RenameColumn(
                name: "DiaDeFolga",
                table: "Entregadores",
                newName: "FolgaDoEntregador");

            migrationBuilder.RenameColumn(
                name: "DataContratacao",
                table: "Entregadores",
                newName: "Data De Assinatura De Contrato");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Entregadores",
                table: "Entregadores",
                column: "ModeloDoCarro");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Entregadores_CarrierModeloDoCarro",
                table: "Pizzas",
                column: "CarrierModeloDoCarro",
                principalTable: "Entregadores",
                principalColumn: "ModeloDoCarro");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Entregadores_CarrierModeloDoCarro",
                table: "Pizzas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Entregadores",
                table: "Entregadores");

            migrationBuilder.RenameTable(
                name: "Entregadores",
                newName: "Carriers");

            migrationBuilder.RenameColumn(
                name: "FolgaDoEntregador",
                table: "Carriers",
                newName: "DiaDeFolga");

            migrationBuilder.RenameColumn(
                name: "Data De Assinatura De Contrato",
                table: "Carriers",
                newName: "DataContratacao");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carriers",
                table: "Carriers",
                column: "ModeloDoCarro");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Carriers_CarrierModeloDoCarro",
                table: "Pizzas",
                column: "CarrierModeloDoCarro",
                principalTable: "Carriers",
                principalColumn: "ModeloDoCarro");
        }
    }
}
