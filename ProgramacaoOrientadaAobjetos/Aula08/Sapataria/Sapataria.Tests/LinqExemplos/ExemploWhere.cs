using Sapataria.Modelo.Estrutura.Pessoas;

namespace Sapataria.Tests.LinqExemplos
{
    public class ExemploWhere : LinqTests
    {

        #region Exemplos Clausula Where
        /// <summary>
        /// Limpa os recursos que foram utilizados durante a execucao dos testes
        /// </summary>
        [TestCleanup]
        public void LimparTestes()
        {
            //File.Delete(@"c:\temp\log.txt");
        }


        /// <summary>
        /// Verificar se é possível obter pelo nome
        /// </summary>
        [TestMethod]
        [TestCategory("Método")]
        public void ExemploFiltragemLinqTest()
        {
            //arrange
            //Mudamos para a preparacao PrepararOsTestes()

            //act
            var listaResultado = clientes.Where(cli => cli.Nome.StartsWith("J"));

            //assert
            Assert.IsNotNull(clientes);
            Assert.AreEqual(2, listaResultado.Count());
        }


        /// <summary>
        /// Verificar se é possível obter pelo nome
        /// </summary>
        [TestMethod]
        [TestCategory("Query")]
        public void ExemploFiltragemLinqComQueryTest()
        {
            //arrange
            //Mudamos para a preparacao PrepararOsTestes()


            //act
            var listaResultado = from cli in clientes
                                 where cli.Nome.StartsWith("J")
                                    && cli.Nome.EndsWith("o")
                                    && cli.Sexo == Sexo.Feminino
                                 select cli;

            //assert
            Assert.IsNotNull(clientes);
            Assert.AreEqual(0, listaResultado.Count());
        }


        /// <summary>
        /// Listar pessoas que moram em lisboa
        /// </summary>
        [TestMethod]
        public void ExemploFiltragemLinqComMetodoEObjetoComplexoTest()
        {
            //arrange

            //act
            var listaResultado = clientes.Where(x => x.Morada.Distrito == "Lisboa");


            //assert
            Assert.IsNotNull(clientes);
            Assert.AreEqual(1, listaResultado.Count());
            Assert.AreEqual("Joao", listaResultado.FirstOrDefault().Nome);
        }
        #endregion




    }
}
