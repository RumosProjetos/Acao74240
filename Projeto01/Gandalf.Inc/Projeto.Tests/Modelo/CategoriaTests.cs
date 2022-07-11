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
                Id = Guid.NewGuid()
            };

            //act

            //assert
            Assert.IsNotNull(categoria);
            Assert.AreEqual(typeof(Categoria), categoria.GetType());
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
