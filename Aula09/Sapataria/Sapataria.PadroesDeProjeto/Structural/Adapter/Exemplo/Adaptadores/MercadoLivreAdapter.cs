namespace Sapataria.PadroesDeProjeto.Structural.Adapter.Exemplo.Adaptadores
{
    public class MercadoLivreAdapter : PagamentoAdapter
    {
        public override void Pagar()
        {
            var mercadoLivre = new Gateways.MercadoLivre();
            mercadoLivre.PagarEmReais(ValorPago, DataPagamento);
        }
    }
}
