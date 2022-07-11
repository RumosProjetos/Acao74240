using Sapataria.Modelo.Estrutura.Pessoas;

namespace Sapataria.Tests
{
    [TestClass]
    public class PessoaTests
    {
        [TestMethod]
        public void DeveriaRejeitarNifComMaisDeNoveCaracteres()
        {
            //Arrange - Preparacao do Teste
            var cliente = new Cliente();
            cliente.NumeroIdentificacaoFiscal = "1234567890";

            //Act - Execucao
            var valorObtido = cliente.ValidarNif();

            //Assert - Verificacao
            Assert.IsNotNull(cliente);
            Assert.IsFalse(valorObtido);
        }

        [TestMethod]
        public void DeveriaRejeitarNifComMenosDeNoveCaracteres()
        {
            //Arrange - Preparacao do Teste
            var cliente = new Cliente();
            cliente.NumeroIdentificacaoFiscal = "12345678";

            //Act - Execucao
            var valorObtido = cliente.ValidarNif();

            //Assert - Verificacao
            Assert.IsNotNull(cliente);
            Assert.IsFalse(valorObtido);
        }

        [TestMethod]
        public void DeveriaRejeitarNifComLetrasNaUltimaPosicao()
        {
            //Arrange - Preparacao do Teste
            var cliente = new Cliente();
            cliente.NumeroIdentificacaoFiscal = "12345678A";

            //Act - Execucao
            var valorObtido = cliente.ValidarNif();

            //Assert - Verificacao
            Assert.IsNotNull(cliente);
            Assert.IsFalse(valorObtido);
        }


        [TestMethod]
        public void DeveriaRejeitarNifComLetrasNaPrimeiraPosicao()
        {
            //Arrange - Preparacao do Teste
            var cliente = new Cliente();
            cliente.NumeroIdentificacaoFiscal = "A12345678";

            //Act - Execucao
            var valorObtido = cliente.ValidarNif();

            //Assert - Verificacao
            Assert.IsNotNull(cliente);
            Assert.IsFalse(valorObtido);
        }


        [TestMethod]
        public void DeveriaRejeitarNifComLetrasEmQualquerPosicao()
        {
            //Arrange - Preparacao do Teste
            var cliente = new Cliente();
            cliente.NumeroIdentificacaoFiscal = "1234B5678";

            //Act - Execucao
            var valorObtido = cliente.ValidarNif();

            //Assert - Verificacao
            Assert.IsNotNull(cliente);
            Assert.IsFalse(valorObtido);
        }

        [TestMethod]
        public void DeveriaRejeitarNifComecandoComDigitoInvalido()
        {
            //Arrange - Preparacao do Teste
            var cliente = new Cliente();
            cliente.NumeroIdentificacaoFiscal = "923456789";

            //Act - Execucao
            var valorObtido = cliente.ValidarNif();

            //Assert - Verificacao
            Assert.IsNotNull(cliente);
            Assert.IsFalse(valorObtido);
        }
    }
}
