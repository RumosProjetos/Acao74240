namespace Projeto.Tests.Modelo
{
    [TestClass]
    public class CategoriaTests
    {
        [TestMethod]
        public void DeveInstanciarUmObjetoCategoriaTest()
        {
            //arrange
            var categoria = new Categoria();

            //act

            //assert
            Assert.IsNotNull(categoria);
            Assert.AreEqual(typeof(Categoria), categoria.GetType());
        }

        [TestMethod]
        public void DeveInstanciarUmObjetoCategoriaEaceitarPropriedadesTest()
        {
            //arrange
            var categoria = new Categoria
            {
                Descricao = "descricao",
                Nome = "Nome",
                Id = Guid.NewGuid()
            };

            //act
            var categoria2 = categoria;

            //assert
            Assert.IsNotNull(categoria);
            Assert.AreEqual(typeof(Categoria), categoria.GetType());
            Assert.AreEqual(categoria, categoria2);
            Assert.AreEqual(categoria.Id, categoria2.Id);
            Assert.AreEqual(categoria.Nome, categoria2.Nome);
            Assert.AreEqual(categoria.Descricao, categoria2.Descricao);
        }


        [TestMethod]
        public void DeveInstanciarUmObjetoCategoriaComProdutosTest()
        {
            //arrange
            var categoria = new Categoria();

            //act

            //assert
            Assert.IsNotNull(categoria.Produtos);
            Assert.AreEqual(0, categoria.Produtos.Count);
            Assert.AreEqual(typeof(List<Produto>), categoria.Produtos.GetType());
        }


        [TestMethod]
        public void DeveInstanciarUmObjetoCategoriaEAdicionarProdutosTest()
        {
            //arrange
            var categoria = new Categoria();

            //act
            categoria.Produtos.Add(new Produto());
            categoria.Produtos.Add(new Produto());

            //assert
            Assert.IsNotNull(categoria.Produtos);
            Assert.AreEqual(2, categoria.Produtos.Count);
            Assert.AreEqual(typeof(List<Produto>), categoria.Produtos.GetType());
        }
    }
}
