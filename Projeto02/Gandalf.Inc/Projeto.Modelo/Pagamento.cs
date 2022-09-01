namespace Projeto.Modelo
{
    public class Pagamento
    {
        public Guid Id { get; set; }
        public string? NumeroSequencialNota { get; set; }
        public decimal ValorTotalPago { get; set; }
        public DateTime? DataCriacao { get; set; }
        public Loja? Loja { get; set; }
        public virtual TipoPagamento? TipoPagamento { get; set; }
    }
}
