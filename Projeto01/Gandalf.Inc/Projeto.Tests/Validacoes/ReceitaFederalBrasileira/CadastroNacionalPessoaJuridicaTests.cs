namespace Projeto.Tests.Validacoes.ReceitaFederalBrasileira
{
    [TestClass]
    public class CadastroNacionalPessoaJuridicaTests
    {
        [TestMethod]
        public void CnpjDeveEstarValido()
        {
            //arrange
            var cnpj = new CadastroNacionalPessoaJuridica();

            //act
            var valido = cnpj.EstaValido("84845061000140");

            //assert
            Assert.IsTrue(valido);
        }

        [TestMethod]
        public void CnpjElementosIguaisNaoDeveEstarValido()
        {
            //arrange
            var cnpj = new CadastroNacionalPessoaJuridica();

            //act
            var naoEstaValido = !cnpj.EstaValido("11111111111111");

            //assert
            Assert.IsTrue(naoEstaValido);
        }


        [TestMethod]
        public void CnpjElementosSemElementosMinimoNaoDeveEstarValido()
        {
            //arrange
            var cnpj = new CadastroNacionalPessoaJuridica();

            //act
            var naoEstaValido = !cnpj.EstaValido("1");

            //assert
            Assert.IsTrue(naoEstaValido);
        }



        [TestMethod]
        public void GeradorDeveGerarCnpjValido()
        {
            //arrange
            var cnpj = new CadastroNacionalPessoaJuridica();

            //act
            var cnpjTeste = cnpj.GerarValorParaTestes();
            var estaValido = cnpj.EstaValido(cnpjTeste);

            //assert
            Assert.IsTrue(estaValido);
        }

        [TestMethod]
        public void DeveEstarFormatado()
        {
            //arrange
            var cnpj = new CadastroNacionalPessoaJuridica();

            //act
            var cnpjFormatadoCalculado = cnpj.ToStringFormatado("84845061000140");
            const string cnpjFormatadoComparacao = "84.845.061/0001-40";

            //assert
            Assert.AreEqual(cnpjFormatadoComparacao, cnpjFormatadoCalculado);
        }

    }

}
