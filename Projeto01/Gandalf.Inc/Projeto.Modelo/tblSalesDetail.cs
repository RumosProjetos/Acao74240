
namespace Projeto.Modelo
{
    public class DetalhesDaVenda
    {
        public Guid Id { get; set; }
        public int Seq { get; set; }

        public int Product { get; set; }
        public int Quantity { get; set; }

        public int UnitPrice { get; set; }

        public decimal LineTotal { get; set; }

        public DateTime? DateCreated { get; set; }

        public virtual Venda Venda { get; set; }
    }
}
