using System;
using System.Collections.Generic;

namespace Projeto.Website.Models
{
    public partial class Produto
    {
        public Produto()
        {
            DetalhesDasVenda = new HashSet<DetalhesDasVenda>();
            Estoques = new HashSet<Estoque>();
        }

        public Guid Id { get; set; }
        public string? CodigoBarras { get; set; }
        public string? Nome { get; set; }
        public string? UnidadeMedida { get; set; }
        public string? Marca { get; set; }
        public decimal QuantidadePorUnidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public bool? Descontinuado { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataModificacao { get; set; }
        public Guid? CategoriaId { get; set; }

        public virtual Categoria? Categoria { get; set; }
        public virtual ICollection<DetalhesDasVenda> DetalhesDasVenda { get; set; }
        public virtual ICollection<Estoque> Estoques { get; set; }
    }
}
