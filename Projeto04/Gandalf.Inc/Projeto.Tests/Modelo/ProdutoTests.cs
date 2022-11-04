namespace Projeto.Tests.Modelo
{
    [TestClass]
    public class ProdutoTests
    {
        [TestMethod]
        public void DeveInstanciarUmObjetoProdutoTest()
        {
            //arrange
            var produto = new Produto();

            //act

            //assert
            Assert.IsNotNull(produto);
            Assert.AreEqual(typeof(Produto), produto.GetType());
        }

        [TestMethod]
        public void DeveInstanciarUmObjetoProdutoEaceitarPropriedadesTest()
        {
            //arrange
            var produto = new Produto
            {
                Id = Guid.NewGuid(),
                Nome = "Nome",
                Categoria = new Categoria(),
                CodigoBarras = "Codigo Barras",
                DataCriacao = new DateTime(),
                DataModificacao = new DateTime(),
                Descontinuado = false,
                PrecoUnitario = 0,
                QuantidadePorUnidade = 0,
                UnidadeMedida = "Unidade Medida",
                Estoques = new List<Estoque>()
            };

            //act
            var produto2 = produto;

            //assert
            Assert.IsNotNull(produto);
            Assert.AreEqual(typeof(Produto), produto.GetType());
            Assert.AreEqual(produto, produto2);
            Assert.AreEqual(produto.Id, produto2.Id);
            Assert.AreEqual(produto.Nome, produto2.Nome);
            Assert.AreEqual(produto.Categoria, produto2.Categoria);
            Assert.AreEqual(produto.CodigoBarras, produto2.CodigoBarras);
            Assert.AreEqual(produto.DataCriacao, produto2.DataCriacao);
            Assert.AreEqual(produto.DataModificacao, produto2.DataModificacao);
            Assert.AreEqual(produto.Descontinuado, produto2.Descontinuado);
            Assert.AreEqual(produto.PrecoUnitario, produto2.PrecoUnitario);
            Assert.AreEqual(produto.QuantidadePorUnidade, produto2.QuantidadePorUnidade);
            Assert.AreEqual(produto.UnidadeMedida, produto2.UnidadeMedida);
            Assert.AreEqual(produto.Estoques, produto2.Estoques);
        }


        [TestMethod]
        public void DeveInstanciarUmObjetoCategoriaComProdutosTest()
        {
            //arrange
            var produto = new Produto();

            //act

            //assert
            Assert.IsNotNull(produto.Estoques);
            Assert.AreEqual(0, produto.Estoques.Count);
            Assert.AreEqual(typeof(List<Estoque>), produto.Estoques.GetType());
        }


        [TestMethod]
        public void DeveInstanciarUmObjetoCategoriaEAdicionarProdutosTest()
        {
            //arrange
            var produto = new Produto();

            //act
            produto.Estoques.Add(new Estoque());
            produto.Estoques.Add(new Estoque());

            //assert
            Assert.IsNotNull(produto.Estoques);
            Assert.AreEqual(2, produto.Estoques.Count);
            Assert.AreEqual(typeof(List<Estoque>), produto.Estoques.GetType());
        }
    }
}
