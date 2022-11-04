using System;
using System.Collections.Generic;

namespace Projeto.Website.Models
{
    public partial class PontosDeVenda
    {
        public PontosDeVenda()
        {
            Venda = new HashSet<Venda>();
        }

        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? Localizacao { get; set; }
        public Guid? LojaId { get; set; }

        public virtual Loja? Loja { get; set; }
        public virtual ICollection<Venda> Venda { get; set; }
    }
}
