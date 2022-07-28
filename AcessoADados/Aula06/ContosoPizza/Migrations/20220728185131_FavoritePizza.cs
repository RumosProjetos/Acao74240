using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContosoPizza.Migrations
{
    public partial class FavoritePizza : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FavoritePizzaId",
                table: "Customers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_FavoritePizzaId",
                table: "Customers",
                column: "FavoritePizzaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Pizzas_FavoritePizzaId",
                table: "Customers",
                column: "FavoritePizzaId",
                principalTable: "Pizzas",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Pizzas_FavoritePizzaId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_FavoritePizzaId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "FavoritePizzaId",
                table: "Customers");
        }
    }
}
