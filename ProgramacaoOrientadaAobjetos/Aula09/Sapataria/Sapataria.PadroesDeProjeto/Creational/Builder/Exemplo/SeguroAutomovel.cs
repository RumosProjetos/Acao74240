namespace Sapataria.PadroesDeProjeto.Builder.Exemplo
{
    public class SeguroAutomovel : ApoliceBuilder
    {
        public SeguroAutomovel()
        {
            apolice.NomeDoTipoDeProposta = "Apolice Auto";
        }

        public override void CalcularValorCobertura()
        {
            apolice.ValorDeCobertura = apolice.ValorNominalDoBem * 0.9M;
        }

        public override void InformarCondicoesEspeciais()
        {
            apolice.Condicoes = "Esse bem só paga 90% do valor";
        }
    }
}
