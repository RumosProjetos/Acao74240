using Sapataria.PadroesDeProjeto.Builder.Exemplo;

namespace Sapataria.Tests.PadroesProjeto
{
    [TestClass]
    public class ExemploBuilder
    {
        [TestMethod]
        public void DeveMontarPropostaDoTipoSeguroVida()
        {
            //arrange
            var apoliceGenericaExemplo = new SeguroVida();            
            var proposta = new PropostaDeSeguro(apoliceGenericaExemplo);

            //act
            proposta.MontarProposta(10);

            //assert	
            Assert.IsNotNull(proposta);
            Assert.AreEqual(typeof(SeguroVida), apoliceGenericaExemplo.GetType());
        }


        [TestMethod]
        public void DeveMontarPropostaDoTipoSeguroImovel()
        {
            //arrange
            var apoliceGenericaExemplo = new SeguroImovel();

            var proposta = new PropostaDeSeguro(apoliceGenericaExemplo);

            //act
            proposta.MontarProposta(10);

            //assert	
            Assert.IsNotNull(proposta);
            Assert.AreEqual(typeof(SeguroImovel), apoliceGenericaExemplo.GetType());
        }
    }
}
