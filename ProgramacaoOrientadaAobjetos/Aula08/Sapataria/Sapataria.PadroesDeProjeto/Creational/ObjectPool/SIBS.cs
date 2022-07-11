using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapataria.PadroesDeProjeto.Creational.ObjectPool
{
    public class SIBS : FilaProcessamento<PedidoPagamento>
    {
        private Dictionary<PedidoPagamento, bool> _filaEmProcessamento { get; set; }
        private bool _pronto { get; set; }
        
        public SIBS(bool pronto, Dictionary<PedidoPagamento, bool> filaEmProcessamento) : base(pronto, filaEmProcessamento)
        {
            _filaEmProcessamento = filaEmProcessamento;
            _pronto = pronto;
        }
            
  
        public override PedidoPagamento Enfileirar(PedidoPagamento pedido)
        {
            _filaEmProcessamento.Add(pedido,false);
            return pedido;
        }

        public override void RemoverDaFila(PedidoPagamento pedido)
        {
            _filaEmProcessamento.Remove(pedido);
        }
    }
}
