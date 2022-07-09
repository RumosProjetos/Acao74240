namespace Sapataria.PadroesDeProjeto.Builder.Exemplo
{
    public abstract class ApoliceBuilder
    {
        public ApoliceBuilder()
        {
            apolice = new ApoliceSeguro();
        }

        protected ApoliceSeguro apolice;
        public ApoliceSeguro ObterApoliceSeguro() => apolice; //Métodos Concretos
        public void InicializarPropostaSeguro(decimal valorNominal)
        {
            apolice.ValorNominalDoBem = valorNominal;
            Console.WriteLine(apolice.NomeDoTipoDeProposta);
        }
        
        public abstract void CalcularValorCobertura();
        public abstract void InformarCondicoesEspeciais();
    }
}
