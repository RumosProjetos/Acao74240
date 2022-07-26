using Microsoft.EntityFrameworkCore;

namespace CodeFirstWebApi.Model
{
    public class PizzaDb : DbContext
    {
        public PizzaDb(DbContextOptions options) : base(options) { }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}
