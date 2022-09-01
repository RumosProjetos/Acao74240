using Microsoft.EntityFrameworkCore;
using Projeto.Modelo;

namespace Projeto.Data
{
    public class GandalfContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB;Database=GandalfDB;Trusted_Connection=True;");
        }


        DbSet<Categoria>? Categorias { get; set; }
        DbSet<Cliente>? Clientes { get; set; }
        DbSet<DetalhesDaVenda>? DetalhesDasVendas { get; set; }
        DbSet<Estoque>? Estoques { get; set; }
        DbSet<Loja>? Lojas { get; set; }
        DbSet<Pagamento>? Pagamentos { get; set; }
        DbSet<PontoDeVenda>? PontosDeVendas { get; set; }
        DbSet<Produto>? Produtos { get; set; }
        DbSet<TipoPagamento>? TiposDePagamentos { get; set; }
        DbSet<Utilizador>? Utilizadores { get; set; }
        DbSet<Venda>? Vendas { get; set; }
    }
}