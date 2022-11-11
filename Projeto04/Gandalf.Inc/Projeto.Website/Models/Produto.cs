using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

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

        [Display(Name = "Código de Barras")]
        public string? CodigoBarras { get; set; }
        public string? Nome { get; set; }

        [Display(Name = "Unidade de Medida")]
        public string? UnidadeMedida { get; set; }
        public string? Marca { get; set; }
        [Display(Name = "Quantidade por Unidade")]
        public decimal QuantidadePorUnidade { get; set; }

        [Display(Name = "Preço Unitário")]
        public decimal PrecoUnitario { get; set; }

        public bool? Descontinuado { get; set; }

        [Display(Name = "Data de Criação")]
        public DateTime? DataCriacao { get; set; }
        [Display(Name = "Data de Modificação")]
        public DateTime? DataModificacao { get; set; }

        [Display(Name = "Categoria")]
        public Guid? CategoriaId { get; set; }

        public virtual Categoria? Categoria { get; set; }
        public virtual ICollection<DetalhesDasVenda> DetalhesDasVenda { get; set; }
        public virtual ICollection<Estoque> Estoques { get; set; }
    }
}
