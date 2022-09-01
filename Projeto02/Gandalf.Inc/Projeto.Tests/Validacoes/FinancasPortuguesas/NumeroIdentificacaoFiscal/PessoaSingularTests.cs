namespace Projeto.Tests.Validacoes.FinancasPortuguesas.NumeroIdentificacaoFiscal
{
    [TestClass]
    public class PessoaSingularTests
    {
        [TestMethod]
        public void NifDeveEstarValido()
        {
            //arrange
            var nif = new PessoaSingular();

            //act
            var valido = nif.EstaValido("201648016");

            //assert
            Assert.IsTrue(valido);
        }

        [TestMethod]
        public void NifPessoaColetivaNaoDeveEstarValido()
        {
            //arrange
            var nif = new PessoaSingular();

            //act
            var invalido = !nif.EstaValido("520727703");

            //assert
            Assert.IsTrue(invalido);
        }


        [TestMethod]
        public void NifElementosIguaisNaoDeveEstarValido()
        {
            //arrange
            var nif = new PessoaSingular();

            //act
            var naoEstaValido = !nif.EstaValido("111111111");

            //assert
            Assert.IsTrue(naoEstaValido);
        }

        [TestMethod]
        public void NifElementosNumeroMinimoNaoDeveEstarValido()
        {
            //arrange
            var nif = new PessoaSingular();

            //act
            var naoEstaValido = !nif.EstaValido("1");

            //assert
            Assert.IsTrue(naoEstaValido);
        }

        [TestMethod]
        public void GeradorDeveGerarNifValido()
        {
            //arrange
            var nif = new PessoaSingular();

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
            var nif = new PessoaSingular();

            //act
            var nifFormatadoCalculado = nif.ToStringFormatado("111111111");
            const string nifFormatadoComparacao = "111 111 111";

            //assert
            Assert.AreEqual(nifFormatadoComparacao, nifFormatadoCalculado);
        }
    }
}
