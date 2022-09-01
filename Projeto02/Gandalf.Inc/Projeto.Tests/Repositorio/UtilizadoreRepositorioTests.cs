using Projeto.Repositorio.Repositorio;

namespace Projeto.Tests.Repositorio
{
    [TestClass()]
    public class UtilizadoreRepositorioTests
    {

        private List<Utilizador> _listaParaTestes;
        [TestInitialize]
        public void Inicializador()
        {
            _listaParaTestes = new List<Utilizador> {
                new Utilizador {Id = new Guid("fbb6741d-b294-4e22-9f4f-fc30d3c31101"), Nome = "teste 01", Login = "teste", Senha = "senha"},
                new Utilizador {Id = new Guid("a60a4f8d-8d17-4c82-afbd-f23fefc823e9"), Nome = "teste 02", Login = "teste2", Senha = "PalavraPasse"}
            };
        }


        [TestMethod()]
        public void DeveCriarUtilizadorNoRepositorioTest()
        {
            //arrange
            var utilizador = new Utilizador
            {
                Id = Guid.NewGuid(),
                Nome = "Utilizador",
                Login = "Login",
                Senha = "Senha"
            };

            //act
            var repo = new UtilizadorRepositorio(_listaParaTestes);
            repo.InserirNovo(utilizador);

            //assert
            Assert.IsNotNull(utilizador);
            Assert.IsNotNull(repo);
        }

        [TestMethod()]
        public void DeveCriarUtilizadorESalvarNoRepositorioTest()
        {
            //arrange
            var utilizador = new Utilizador
            {
                Id = Guid.NewGuid(),
                Nome = "Utilizador",
                Login = "Login",
                Senha = "Senha"
            };

            //act
            var repo = new UtilizadorRepositorio(_listaParaTestes);
            repo.InserirNovo(utilizador);
            var caminho = @"c:\temp\testes\utilizador.json";
            repo.Salvar(caminho);

            //assert
            Assert.IsNotNull(utilizador);
            Assert.IsNotNull(repo);
        }


        [TestMethod()]
        public void DeveCriarUtilizadorESalvarEBuscarDoRepositorioTest()
        {
            //arrange
            var utilizador = new Utilizador
            {
                Id = Guid.NewGuid(),
                Nome = "Utilizador",
                Login = "Login",
                Senha = "Senha"
            };
            var repo = new UtilizadorRepositorio(_listaParaTestes);

            //act
            var contagemInicial = repo.ObterTodos().Count;
            repo.InserirNovo(utilizador);
            var caminho = @"c:\temp\testes\utilizador.json";
            repo.Salvar(caminho);
            var contagemFinal = repo.ObterTodos().Count;

            //assert
            Assert.IsNotNull(utilizador);
            Assert.IsNotNull(repo);
            Assert.IsTrue(contagemFinal > contagemInicial);
        }




        [TestMethod()]
        public void ApagarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AtualizarTest()
        {
            Assert.Fail();
        }


        [TestMethod()]
        public void ListarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SalvarTest()
        {
            Assert.Fail();
        }
    }
}