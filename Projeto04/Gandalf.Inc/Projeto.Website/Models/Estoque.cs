using System;
using System.Collections.Generic;

namespace Projeto.Website.Models
{
    public partial class Estoque
    {
        public Guid Id { get; set; }
        public int Quantidade { get; set; }
        public int QuantidadeMinima { get; set; }
        public DateTime? DataModificacao { get; set; }
        public DateTime? DataCriacao { get; set; }
        public Guid? ProdutoId { get; set; }
        public Guid? LojaId { get; set; }

        public virtual Loja? Loja { get; set; }
        public virtual Produto? Produto { get; set; }
    }
}
