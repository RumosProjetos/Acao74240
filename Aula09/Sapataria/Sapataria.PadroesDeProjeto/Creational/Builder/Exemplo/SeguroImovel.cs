namespace Sapataria.PadroesDeProjeto.Builder.Exemplo
{
    public class SeguroImovel : ApoliceBuilder
    {
        public SeguroImovel()
        {
            apolice.NomeDoTipoDeProposta = "Apolice Imovel";
        }

        public override void CalcularValorCobertura()
        {
            apolice.ValorDeCobertura = apolice.ValorNominalDoBem * 1.1M;
        }

        public override void InformarCondicoesEspeciais()
        {
            apolice.Condicoes = "Esse bem só paga 110% do valor";
        }
    }
}
