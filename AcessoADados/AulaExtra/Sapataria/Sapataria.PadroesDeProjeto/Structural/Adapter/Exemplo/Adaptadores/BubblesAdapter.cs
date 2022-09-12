using ExemploDeSimplicacao = Sapataria.PadroesDeProjeto.Structural.Adapter.Exemplo.Gateways.Bubbles;

namespace Sapataria.PadroesDeProjeto.Structural.Adapter.Exemplo.Adaptadores
{
    public class BubblesAdapter : PagamentoAdapter
    {
        public override void Pagar()
        {
            var pagamento = new ExemploDeSimplicacao();
            pagamento.PagarEmRupias(ValorPago);
            DataPagamento = DateTime.Now;
        }
    }
}
