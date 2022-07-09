using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapataria.PadroesDeProjeto.Structural.Adapter.Exemplo.Gateways
{
    /// <summary>
    /// Gateway de Pagamento Português
    /// </summary>
    public class SIBS
    {
        public double IBAN { get; set; }
        public int NIF { get; set; }
        public string Credenciais { get; set; }

        public void PagarEmEuros(decimal quantidade)
        {
            Console.WriteLine($"Pago {quantidade}");
        }
    }
}
