using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapataria.PadroesDeProjeto.Structural.Adapter.Exemplo.Gateways
{
    /// <summary>
    /// Gateway Brasileiro
    /// </summary>
    public class MercadoLivre
    {
        public void PagarEmReais(decimal valor, DateTime dataProcessamento)
        {
            Console.WriteLine($"Foram pagos {valor} no dia {dataProcessamento}");
        }
    }
}
