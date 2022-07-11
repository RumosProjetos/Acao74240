

namespace Projeto.Modelo
{
    public class TipoPagamento
    {
         public TipoPagamento() =>new List<Pagamento>();
        public Guid Id { get; set; }
        public string Descricao { get; set; }
         public virtual List<Pagamento> Pagamentos { get; set; }
    }
}
