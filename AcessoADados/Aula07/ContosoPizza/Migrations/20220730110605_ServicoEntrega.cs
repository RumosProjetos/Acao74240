using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContosoPizza.Migrations
{
    public partial class ServicoEntrega : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CarrierModeloDoCarro",
                table: "Pizzas",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Carriers",
                columns: table => new
                {
                    ModeloDoCarro = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeEntregador = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DataContratacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DiaDeFolga = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carriers", x => x.ModeloDoCarro);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_CarrierModeloDoCarro",
                table: "Pizzas",
                column: "CarrierModeloDoCarro");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Carriers_CarrierModeloDoCarro",
                table: "Pizzas",
                column: "CarrierModeloDoCarro",
                principalTable: "Carriers",
                principalColumn: "ModeloDoCarro");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Carriers_CarrierModeloDoCarro",
                table: "Pizzas");

            migrationBuilder.DropTable(
                name: "Carriers");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_CarrierModeloDoCarro",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "CarrierModeloDoCarro",
                table: "Pizzas");
        }
    }
}
