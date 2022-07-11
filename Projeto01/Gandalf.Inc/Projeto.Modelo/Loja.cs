namespace Projeto.Modelo
{
    public class Loja
    {
        public Loja()
        {
            PontoDeVendas = new List<PontoDeVenda>();
            Estoques = new List<Estoque>();
        }
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public bool? Ativa { get; set; }
        public DateTime? DataModificacao { get; set; }
        public DateTime? DataCriacao { get; set; }
        public virtual List<PontoDeVenda> PontoDeVendas { get; set; }
        public virtual List<Estoque> Estoques { get; set; }
    }
}
