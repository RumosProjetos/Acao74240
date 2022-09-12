using Sapataria.PadroesDeProjeto.Structural.Adapter.Exemplo.Adaptadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapataria.PadroesDeProjeto.Structural.Adapter.Exemplo
{
    public class ExemploUso
    {
        public void Exemplo()
        {
            var pagamentos = new List<PagamentoAdapter>();
            pagamentos.Add(new BubblesAdapter());
            pagamentos.Add(new MercadoPagoAdapter());
            pagamentos.Add(new PaypalAdapter());
            /*...*/


            foreach (var item in pagamentos)
            {
                item.Pagar();
            }

        }
    }
}
