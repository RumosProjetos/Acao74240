using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapataria.PadroesDeProjeto.Structural.Adapter.Exemplo.Gateways
{
    /// <summary>
    /// Gateway de Pagamento Universal
    /// </summary>
    public class PayPal
    {
        public void PagarEmDolar(decimal Valor, CredenciaisPaypal credenciais)
        {
            Console.WriteLine($"Foi pago {Valor} por {credenciais.User}");
        }
    }


    public class CredenciaisPaypal
    {
        public string User { get; set; }
        public string Pass { get; set; }
    }
}
