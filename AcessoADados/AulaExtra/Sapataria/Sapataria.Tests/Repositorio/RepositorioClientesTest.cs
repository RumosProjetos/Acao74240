using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sapataria.Modelo.Estrutura.Pessoas;

namespace Sapataria.Modelo.Repositorio.Tests
{
    [TestClass()]
    public class RepositorioClientesTest
    {
        private const int numeroElementos = 1000;



        [TestMethod]
        public void DeveAdicionarClienteNoMongoDB()
        {
            //Arrange
            var cliente = new Cliente
            {
                Id = Guid.NewGuid().ToString(),
                Nome = "Marcelo",
                Morada = new Morada { Distrito = "Setúbal" }
            };

            var logica = new LogicaNegocio.LogicaCliente();

            //Act
            logica.AdicionarCliente(cliente);


            //Assert
            Assert.IsNotNull(cliente);
        }


        [TestMethod]
        public void DeveAtualizarClienteNoMongoDB()
        {
            //Arrange
            var idCliente = "2f7e1d3e-c0c4-4c56-9264-96376f8f3a29";
            var dadosNovos = new Cliente { Morada = new Morada { Distrito = "Lisboa", NumeroPorta = "30" } };

            var logica = new LogicaNegocio.LogicaCliente();

            //Act
            logica.AtualizarCliente(idCliente, dadosNovos);


            //Assert
        }




        [TestMethod]
        public void DeveListarClienteDoMongoDB()
        {
            //Arrange
            var logica = new LogicaNegocio.LogicaCliente();

            //Act
            var dados = logica.ListarClientes();


            //Assert
            Assert.IsNotNull(dados);
        }


        [TestMethod]
        public void DeveApagarClienteDoMongoDB()
        {
            //Arrange
            var idCliente = "2f7e1d3e-c0c4-4c56-9264-96376f8f3a29";
            var logica = new LogicaNegocio.LogicaCliente();

            //Act
            logica.ApagarCliente(idCliente);          
        }

    }
}