namespace Sapataria.PadroesDeProjeto.Builder.Exemplo
{
    public class SeguroVida : ApoliceBuilder
    {
        public SeguroVida()
        {
            apolice.NomeDoTipoDeProposta = "Apolice Vida";
        }

        public override void CalcularValorCobertura()
        {
            apolice.ValorDeCobertura = apolice.ValorNominalDoBem * 1.8M;
        }

        public override void InformarCondicoesEspeciais()
        {
            apolice.Condicoes = "Esse bem só paga 180% do valor";
        }
    }
}
