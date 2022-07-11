using Sapataria.PadroesDeProjeto.Builder.Exemplo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapataria.PadroesDeProjeto.Builder
{
    public class ExemploUso
    {

        public void MyNewMethod()
        {
            var apoliceGenericaExemplo = new SeguroImovel();

            var proposta = new PropostaDeSeguro(apoliceGenericaExemplo);
            proposta.MontarProposta(10M);            
        }
    }
}
