using System;
using System.Collections.Generic;

namespace Projeto.Website.Models
{
    public partial class DetalhesDasVenda
    {
        public Guid Id { get; set; }
        public int Sequencial { get; set; }
        public Guid? ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public int PrecoUnitario { get; set; }
        public decimal TotalPorItem { get; set; }
        public DateTime? DataCriacao { get; set; }
        public Guid? VendaId { get; set; }

        public virtual Produto? Produto { get; set; }
        public virtual Venda? Venda { get; set; }
    }
}
