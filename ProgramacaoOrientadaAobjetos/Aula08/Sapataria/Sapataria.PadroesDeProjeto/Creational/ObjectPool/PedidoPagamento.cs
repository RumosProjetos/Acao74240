using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapataria.PadroesDeProjeto.Creational.ObjectPool
{
    public class PedidoPagamento
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataGeracao { get; set; }
        public decimal ValorNominal { get; set; }
        public decimal IVA { get; set; }
    }
}
