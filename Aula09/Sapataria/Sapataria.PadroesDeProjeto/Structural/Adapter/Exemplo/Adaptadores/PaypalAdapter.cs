using Sapataria.PadroesDeProjeto.Structural.Adapter.Exemplo.Gateways;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapataria.PadroesDeProjeto.Structural.Adapter.Exemplo.Adaptadores
{
    public class PaypalAdapter : PagamentoAdapter
    {
        public override void Pagar()
        {
            var credenciais = new CredenciaisPaypal
            {
                Pass = "######",
                User = "meuUserApplicacional"
            };

            var paypal = new PayPal();
            paypal.PagarEmDolar(ValorPago, credenciais);
        }
    }
}
