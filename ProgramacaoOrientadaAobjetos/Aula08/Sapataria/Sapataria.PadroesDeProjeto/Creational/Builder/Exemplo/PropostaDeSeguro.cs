using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapataria.PadroesDeProjeto.Builder.Exemplo
{
    public class PropostaDeSeguro
    {
        private ApoliceBuilder _builder;

        public PropostaDeSeguro(ApoliceBuilder builder)
        {
            _builder = builder;
        }

        public void MontarProposta(decimal valorNominal)
        {
            _builder.InicializarPropostaSeguro(valorNominal);
            _builder.CalcularValorCobertura();
            _builder.ObterApoliceSeguro();
        }
    }
}
