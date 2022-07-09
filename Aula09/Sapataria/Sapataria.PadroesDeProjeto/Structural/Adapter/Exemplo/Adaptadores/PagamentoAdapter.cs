using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapataria.PadroesDeProjeto.Structural.Adapter.Exemplo.Adaptadores
{
    public abstract class PagamentoAdapter
    {
        public string NomeCliente { get; set; }
        public string NumeroFiscal { get; set; }
        public decimal ValorPago { get; set; }
        public DateTime DataPagamento { get; set; }

        public abstract void Pagar();

        public DateTime DataProcessamento { get; set; }
    }
}
