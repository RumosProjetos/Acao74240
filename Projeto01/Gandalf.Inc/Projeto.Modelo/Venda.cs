namespace Projeto.Modelo
{
    public class Venda
    {
        public Venda() => DetalhesDasVendas = new List<DetalhesDaVenda>();
        public Guid Id { get; set; }
        public DateTime? DataModificacao { get; set; }
        public DateTime? DataCriacao { get; set; }
        public bool? Pago { get; set; }
        public Loja? Loja { get; set; }
        public virtual PontoDeVenda? PontoDeVenda { get; set; }
        public virtual List<DetalhesDaVenda> DetalhesDasVendas { get; set; }
        public virtual Utilizador? Utilizador { get; set; }
    }
}
