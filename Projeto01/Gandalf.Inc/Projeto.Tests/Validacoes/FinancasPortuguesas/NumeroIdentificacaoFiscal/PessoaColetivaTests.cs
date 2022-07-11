using Validadores.FinancasPortuguesas;

namespace Validadores.Tests.FinancasPortuguesas.NumeroIdentificacaoFiscal
{
    [TestClass]
    public class PessoaColetivaTests
    {
        [TestMethod]
        public void NifPessoaColetivaDeveEstarValido()
        {
            //arrange
            var nif = new PessoaColetiva();

            //act
            var valido = nif.EstaValido("520727703");

            //assert
            Assert.IsTrue(valido);
        }

        [TestMethod]
        public void NifPessoaSingularNaoDeveEstarValido()
        {
            //arrange
            var nif = new PessoaColetiva();

            //act
            var invalido = !nif.EstaValido("201648016");

            //assert
            Assert.IsTrue(invalido);
        }

        [TestMethod]
        public void NifElementosIguaisNaoDeveEstarValido()
        {
            //arrange
            var nif = new PessoaColetiva();

            //act
            var naoEstaValido = !nif.EstaValido("555555555");

            //assert
            Assert.IsTrue(naoEstaValido);
        }

        [TestMethod]
        public void NifElementosNumeroMinimoNaoDeveEstarValido()
        {
            //arrange
            var nif = new PessoaColetiva();

            //act
            var naoEstaValido = !nif.EstaValido("5");

            //assert
            Assert.IsTrue(naoEstaValido);
        }

        [TestMethod]
        public void GeradorDeveGerarNifValido()
        {
            //arrange
            var nif = new PessoaColetiva();

            //act
            var nifTeste = nif.GerarValorParaTestes();
            var estaValido = nif.EstaValido(nifTeste);

            //assert
            Assert.IsTrue(estaValido);
        }



        [TestMethod]
        public void DeveEstarFormatado()
        {
            //arrange
            var nif = new PessoaColetiva();

            //act
            var nifFormatadoCalculado = nif.ToStringFormatado("555555555");
            const string nifFormatadoComparacao = "555 555 555";

            //assert
            Assert.AreEqual(nifFormatadoComparacao, nifFormatadoCalculado);
        }
    }
}
