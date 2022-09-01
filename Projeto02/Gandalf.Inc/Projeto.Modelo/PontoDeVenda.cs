namespace Projeto.Modelo
{
    public class PontoDeVenda
    {
        public PontoDeVenda() => Vendas = new List<Venda>();
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? Localizacao { get; set; }
        public virtual Loja? Loja { get; set; }
        public virtual List<Venda> Vendas { get; set; }
    }
}
