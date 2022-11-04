namespace Projeto.Modelo
{
    public class DetalhesDaVenda
    {
        public Guid Id { get; set; }
        public int Sequencial { get; set; }
        public Produto? Produto { get; set; }
        public int Quantidade { get; set; }
        public int PrecoUnitario { get; set; }
        public decimal TotalPorItem { get; set; }
        public DateTime? DataCriacao { get; set; }
        public virtual Venda? Venda { get; set; }
    }
}


/*
Coca - cola  10   2.5   25€
Sandes        2     5   10€
----------------------------
Total                   35€	
*/