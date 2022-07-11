using Sapataria.Modelo.Estrutura.Pessoas;

namespace Sapataria.Modelo.Repositorio.Tests
{
    [TestClass()]
    public class RepositorioClientesTest
    {
        private const int numeroElementos = 1000;

        [TestMethod()]
        public void ObterPorNomeTest()
        {
            //Arrange
            var repo = new RepositorioCliente();
            var cli1 = new Cliente("Maria");
            cli1.NumeroIdentificacaoFiscal = "123456789";
            repo.Adicionar(cli1);

            var cli2 = new Cliente("Joao");
            cli2.NumeroIdentificacaoFiscal = "987654321";
            repo.Adicionar(cli2);

            for (int i = 0; i < numeroElementos; i++)
            {
                repo.Adicionar(new Cliente("X"));
            }


            //Act
            var clienteLocalizado = repo.ObterPorNome("Joao");


            //Assert
            Assert.IsNotNull(clienteLocalizado);
            Assert.AreEqual(cli2.NumeroIdentificacaoFiscal, clienteLocalizado.NumeroIdentificacaoFiscal);
            Assert.AreEqual(cli2, clienteLocalizado);
        }



        [TestMethod()]
        public void ObterPorNomeUsandoLinqTest()
        {
            //Arrange
            var repo = new RepositorioCliente();
            var cli1 = new Cliente("Maria");
            cli1.NumeroIdentificacaoFiscal = "123456789";
            repo.Adicionar(cli1);

            var cli2 = new Cliente("Joao");
            cli2.NumeroIdentificacaoFiscal = "987654321";
            repo.Adicionar(cli2);

            for (int i = 0; i < numeroElementos; i++)
            {
                repo.Adicionar(new Cliente("X"));
            }


            //Act
            var clienteLocalizado = repo.ObterPorNomeUsandoLinq("Joao");


            //Assert
            Assert.IsNotNull(clienteLocalizado);
            Assert.AreEqual(cli2.NumeroIdentificacaoFiscal, clienteLocalizado.NumeroIdentificacaoFiscal);
            Assert.AreEqual(cli2, clienteLocalizado);
        }



        [TestMethod()]
        public void ObterPorNomeUsandoLinqLambdaExpressionTest()
        {
            //Arrange
            var repo = new RepositorioCliente();
            var cli1 = new Cliente("Maria");
            cli1.NumeroIdentificacaoFiscal = "123456789";
            repo.Adicionar(cli1);

            var cli2 = new Cliente("Joao");
            cli2.NumeroIdentificacaoFiscal = "987654321";
            repo.Adicionar(cli2);

            for (int i = 0; i < numeroElementos; i++)
            {
                repo.Adicionar(new Cliente("X"));
            }


            //Act
            var clienteLocalizado = repo.ObterPorNomeUsandoLinqLambdaExpression("Joao");


            //Assert
            Assert.IsNotNull(clienteLocalizado);
            Assert.AreEqual(cli2.NumeroIdentificacaoFiscal, clienteLocalizado.NumeroIdentificacaoFiscal);
            Assert.AreEqual(cli2, clienteLocalizado);
        }
    }
}