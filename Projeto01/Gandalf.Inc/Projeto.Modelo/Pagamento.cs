namespace Projeto.Modelo
{
    public class Pagamento
    {
        public Guid Id { get; set; }
        public string? Seq { get; set; }
        public decimal ValorPago { get; set; }
        public DateTime? DataCriacao { get; set; }
        public Loja? Loja { get; set; }
        public virtual TipoPagamento? TipoPagamento { get; set; }
    }
}
