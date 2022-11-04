using Microsoft.EntityFrameworkCore;
using Projeto.Modelo;

namespace Projeto.Data
{
    public class GandalfContext : DbContext
    {
        private readonly string _connectionString;
        public GandalfContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Caminho Martelado apenas para testar
             //optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB;Database=GandalfDB;Trusted_Connection=True;");
            optionsBuilder.UseSqlServer(_connectionString);
        }


        public DbSet<Pessoa>? Pessoas { get; set; }
        public DbSet<Categoria>? Categorias { get; set; }
        public DbSet<Cliente>? Clientes { get; set; }
        public DbSet<DetalhesDaVenda>? DetalhesDasVendas { get; set; }
        public DbSet<Estoque>? Estoques { get; set; }
        public DbSet<Loja>? Lojas { get; set; }
        public DbSet<Pagamento>? Pagamentos { get; set; }
        public DbSet<PontoDeVenda>? PontosDeVendas { get; set; }
        public DbSet<Produto>? Produtos { get; set; }
        public DbSet<TipoPagamento>? TiposDePagamentos { get; set; }
        public DbSet<Utilizador>? Utilizadores { get; set; }
        public DbSet<Venda>? Vendas { get; set; }
    }
}