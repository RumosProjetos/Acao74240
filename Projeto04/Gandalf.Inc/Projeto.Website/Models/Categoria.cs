using System;
using System.Collections.Generic;

namespace Projeto.Website.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            Produtos = new HashSet<Produto>();
        }

        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
