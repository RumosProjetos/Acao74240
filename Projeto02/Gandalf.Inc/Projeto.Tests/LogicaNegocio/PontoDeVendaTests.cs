namespace Projeto.Tests.LogicaNegocio
{
    [TestClass]
    public class PontoDeVendaTests
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


        //RN01 -  Each POS must have a login.
        [TestMethod]
        public void DeveExistirLoginNoPontoDeVendaTest()
        {
            //arrange
            var sessaoUtilizador = new SessaoUtilizador("Login", "PalavraPasse", new PontoDeVenda(), _listaParaTestes);

            //act

            //assert		
            Assert.IsNotNull(sessaoUtilizador);    
        }

        //RN01 -  Each POS must have a login.
        [TestMethod]
        public void DeveRetornarErroSeNaoExistirLoginNoPontoDeVendaTest()
        {
            //arrange
            var sessaoUtilizador = new SessaoUtilizador("", "", new PontoDeVenda(), _listaParaTestes);

            //act
            var resultado = sessaoUtilizador.ValidarUtilizador();

            //assert		
            Assert.IsNotNull(sessaoUtilizador);
            Assert.IsFalse(resultado);
        }

        //RN01 -  Each POS must have a login.
        [TestMethod]
        public void DeveRetornarDadosSeExistirUtilizadorComCredenciaisSelecionadasPontoDeVendaTest()
        {
            //arrange
            var sessaoUtilizador = new SessaoUtilizador("Login", "Senha", new PontoDeVenda(), _listaParaTestes);

            //act
            var resultado = sessaoUtilizador.ValidarUtilizador();

            //assert		
            Assert.IsNotNull(sessaoUtilizador);
            Assert.IsFalse(resultado);
        }
    }
}
