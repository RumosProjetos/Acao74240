using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapataria.Modelo.Infraestrutura
{
    public class ImpressoraPDF : IImpressora
    {
        public void Imprimir(byte[] dados)
        {
            File.WriteAllBytes(@"c:\temp\exemplopdf.pdf", dados);
        }

        public void Imprimir(string dados)
        {
            File.WriteAllText(@"c:\temp\exemplopdf.pdf", dados);
        }
    }
}
