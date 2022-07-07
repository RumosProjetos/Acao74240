using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sapataria.PadroesDeProjeto.Builder.Exemplo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapataria.Tests.PadroesProjeto
{
    [TestClass]
    public class ExemploBuilder
    {
        [TestMethod]
        public void DeveMontarPropsotaDoTipoSeguroVida()
        {
            //arrange
            var apoliceGenericaExemplo = new SeguroVida();
            
            var proposta = new PropostaDeSeguro(apoliceGenericaExemplo);
            proposta.MontarProposta(10);

            //act

            //assert	
        }


        [TestMethod]
        public void DeveMontarPropostaDoTipoSeguroImovel()
        {
            //arrange
            var apoliceGenericaExemplo = new SeguroImovel();

            var proposta = new PropostaDeSeguro(apoliceGenericaExemplo);
            proposta.MontarProposta(10);

            //act

            //assert	
        }
    }
}
