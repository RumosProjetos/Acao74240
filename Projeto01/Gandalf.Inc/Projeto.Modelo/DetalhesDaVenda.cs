namespace Projeto.Modelo
{
    public class DetalhesDaVenda
    {
        public Guid Id { get; set; }
        public int Seq { get; set; }
        public Produto? Produto { get; set; }
        public int Quantidade { get; set; }
        public int PrecoUnitario { get; set; }
        public decimal TotalDaNota { get; set; }
        public DateTime? DataCriacao { get; set; }
        public virtual Venda? Venda { get; set; }
    }
}
