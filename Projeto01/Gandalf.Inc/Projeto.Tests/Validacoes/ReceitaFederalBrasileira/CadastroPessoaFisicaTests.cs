namespace Projeto.Tests.Validacoes.ReceitaFederalBrasileira
{
    [TestClass]
    public class CadastroPessoaFisicaTests
    {
        [TestMethod]
        public void CpfDeveEstarValido()
        {
            //arrange
            var cpf = new CadastroPessoaFisica();

            //act
            var valido = cpf.EstaValido("12345678909");

            //assert
            Assert.IsTrue(valido);
        }

        [TestMethod]
        public void CpfElementosIguaisNaoDeveEstarValido()
        {
            //arrange
            var cpf = new CadastroPessoaFisica();

            //act
            var naoEstaValido = !cpf.EstaValido("11111111111");

            //assert
            Assert.IsTrue(naoEstaValido);
        }


        [TestMethod]
        public void CpfElementosInsuficientesNaoDeveEstarValido()
        {
            //arrange
            var cpf = new CadastroPessoaFisica();

            //act
            var naoEstaValido = !cpf.EstaValido("1");

            //assert
            Assert.IsTrue(naoEstaValido);
        }


        [TestMethod]
        public void GeradorDeveGerarCpfValido()
        {
            //arrange
            var cpf = new CadastroPessoaFisica();

            //act
            var cpfTeste = cpf.GerarValorParaTestes();
            var estaValido = cpf.EstaValido(cpfTeste);

            //assert
            Assert.IsTrue(estaValido);
        }


        [TestMethod]
        public void DeveEstarFormatado()
        {
            //arrange
            var cpf = new CadastroPessoaFisica();

            //act
            var cpfFormatadoCalculado = cpf.ToStringFormatado("11111111111");
            const string cpfFormatadoComparacao = "111.111.111-11";

            //assert
            Assert.AreEqual(cpfFormatadoComparacao, cpfFormatadoCalculado);
        }


        [TestMethod]
        public void DeveEstarFormatadoStringBuilder()
        {
            //arrange
            var cpf = new CadastroPessoaFisica();

            //act
            var cpfFormatadoCalculado = cpf.ToStringFormatado(new StringBuilder("11111111111"));
            const string cpfFormatadoComparacao = "111.111.111-11";

            //assert
            Assert.AreEqual(cpfFormatadoComparacao, cpfFormatadoCalculado);
        }
    }
}
