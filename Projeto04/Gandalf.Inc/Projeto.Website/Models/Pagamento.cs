using System;
using System.Collections.Generic;

namespace Projeto.Website.Models
{
    public partial class Pagamento
    {
        public Pagamento()
        {
            Venda = new HashSet<Venda>();
        }

        public Guid Id { get; set; }
        public string? NumeroSequencialNota { get; set; }
        public decimal ValorTotalPago { get; set; }
        public DateTime? DataCriacao { get; set; }
        public Guid? LojaId { get; set; }
        public Guid? TipoPagamentoId { get; set; }

        public virtual Loja? Loja { get; set; }
        public virtual TiposDePagamento? TipoPagamento { get; set; }
        public virtual ICollection<Venda> Venda { get; set; }
    }
}
