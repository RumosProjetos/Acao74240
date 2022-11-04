using System;
using System.Collections.Generic;

namespace Projeto.Website.Models
{
    public partial class Venda
    {
        public Venda()
        {
            DetalhesDasVenda = new HashSet<DetalhesDasVenda>();
        }

        public Guid Id { get; set; }
        public DateTime? DataModificacao { get; set; }
        public DateTime? DataCriacao { get; set; }
        public bool? Pago { get; set; }
        public Guid? LojaId { get; set; }
        public Guid? PagamentoId { get; set; }
        public Guid? PontoDeVendaId { get; set; }
        public Guid? UtilizadorId { get; set; }
        public Guid? ClienteId { get; set; }

        public virtual Pessoa? Cliente { get; set; }
        public virtual Loja? Loja { get; set; }
        public virtual Pagamento? Pagamento { get; set; }
        public virtual PontosDeVenda? PontoDeVenda { get; set; }
        public virtual Pessoa? Utilizador { get; set; }
        public virtual ICollection<DetalhesDasVenda> DetalhesDasVenda { get; set; }
    }
}
