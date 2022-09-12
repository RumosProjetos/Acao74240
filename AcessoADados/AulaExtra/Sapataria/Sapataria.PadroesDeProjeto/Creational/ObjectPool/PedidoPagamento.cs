namespace Sapataria.PadroesDeProjeto.Creational.ObjectPool
{
    public class PedidoPagamento
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataGeracao { get; set; }
        public decimal ValorNominal { get; set; }
        public decimal IVA { get; set; }
    }
}
