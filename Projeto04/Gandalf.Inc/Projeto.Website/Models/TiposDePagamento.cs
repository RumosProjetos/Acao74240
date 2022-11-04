using System;
using System.Collections.Generic;

namespace Projeto.Website.Models
{
    public partial class TiposDePagamento
    {
        public TiposDePagamento()
        {
            Pagamentos = new HashSet<Pagamento>();
        }

        public Guid Id { get; set; }
        public string? Descricao { get; set; }

        public virtual ICollection<Pagamento> Pagamentos { get; set; }
    }
}
