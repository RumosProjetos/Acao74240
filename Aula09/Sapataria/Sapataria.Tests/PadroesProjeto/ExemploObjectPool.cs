using Sapataria.PadroesDeProjeto.Creational.ObjectPool;

namespace Sapataria.Tests.PadroesProjeto
{
    [TestClass]
    public class ExemploObjectPool
    {
        [TestMethod]
        public void DeveCriarFilaDeObjetos()
        {
            //arrange
            var pedidos = new Dictionary<PedidoPagamento, bool>();
            pedidos.Add(new PedidoPagamento { Id = Guid.NewGuid(), ValorNominal = 1}, false);
            pedidos.Add(new PedidoPagamento { Id = Guid.NewGuid(), ValorNominal = 2 }, false);
            pedidos.Add(new PedidoPagamento { Id = Guid.NewGuid(), ValorNominal = 3 }, false);            
            var fila = new SIBS(false, pedidos);


            //act
            var pedido4 = new PedidoPagamento { Id = Guid.NewGuid(), ValorNominal = 4 };
            fila.Enfileirar(pedido4);
            var quantidadeAntesDoProcessamento = fila.ObterPosicoesOcupadasNaFila;

            fila.RemoverDaFila(pedido4);
            var quantidadeDepoisDoProcessamento = fila.ObterPosicoesOcupadasNaFila;


            //assert		
            Assert.AreEqual(4, quantidadeAntesDoProcessamento);
            Assert.AreEqual(3, quantidadeDepoisDoProcessamento);
        }
    }
}
