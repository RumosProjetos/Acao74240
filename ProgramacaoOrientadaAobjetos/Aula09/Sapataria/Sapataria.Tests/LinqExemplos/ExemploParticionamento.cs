namespace Sapataria.Tests.LinqExemplos
{
    [TestClass]
    public class ExemploParticionamento : LinqTests
    {

        /// <summary>
        /// Obter os tres primeiros elementos da lista
        /// </summary>
        [TestMethod]
        public void ExemploLinqObter3ElementosDaListaTest()
        {
            //arrange

            //act
            var listaParticionada = clientes.OrderByDescending(x => x.Nome).Take(3);

            //assert
            Assert.IsNotNull(listaParticionada);
            Assert.AreEqual(3, listaParticionada.Count());
            Assert.AreEqual("Sasha", listaParticionada.FirstOrDefault().Nome);
        }


        /// <summary>
        /// Obter os tres primeiros elementos da lista
        /// </summary>
        [TestMethod]
        public void ExemploLinqObter3ElementosDaListaEscapandoOprimeiroTest()
        {
            //arrange

            //act
            var listaParticionada = clientes.OrderByDescending(x => x.Nome).Skip(1).Take(3);

            //assert
            Assert.IsNotNull(listaParticionada);
            Assert.AreEqual(3, listaParticionada.Count());
            Assert.AreEqual("Maria", listaParticionada.FirstOrDefault().Nome);
        }
    }
}
