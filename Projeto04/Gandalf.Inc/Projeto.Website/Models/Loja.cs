using System;
using System.Collections.Generic;

namespace Projeto.Website.Models
{
    public partial class Loja
    {
        public Loja()
        {
            Estoques = new HashSet<Estoque>();
            Pagamentos = new HashSet<Pagamento>();
            PontosDeVenda = new HashSet<PontosDeVenda>();
            Venda = new HashSet<Venda>();
        }

        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public bool? Ativa { get; set; }
        public DateTime? DataModificacao { get; set; }
        public DateTime? DataCriacao { get; set; }

        public virtual ICollection<Estoque> Estoques { get; set; }
        public virtual ICollection<Pagamento> Pagamentos { get; set; }
        public virtual ICollection<PontosDeVenda> PontosDeVenda { get; set; }
        public virtual ICollection<Venda> Venda { get; set; }
    }
}
