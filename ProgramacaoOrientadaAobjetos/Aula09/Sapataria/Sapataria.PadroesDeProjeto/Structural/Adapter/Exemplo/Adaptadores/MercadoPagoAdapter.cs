namespace Sapataria.PadroesDeProjeto.Structural.Adapter.Exemplo.Adaptadores
{
    public class MercadoPagoAdapter : PagamentoAdapter
    {
        public override void Pagar()
        {
            var mercadoPago = new Gateways.MercadoPago();
            mercadoPago.PagarEmReais(ValorPago, DataPagamento);
            DataPagamento = DateTime.Now;
        }
    }
}
