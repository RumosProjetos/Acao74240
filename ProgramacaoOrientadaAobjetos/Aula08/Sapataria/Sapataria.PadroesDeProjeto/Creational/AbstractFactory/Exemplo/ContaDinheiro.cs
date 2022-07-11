namespace Sapataria.PadroesDeProjeto.AbstractFactory.Exemplo
{
    public class ContaDinheiro : ContaBancaria
    {
        public override void CobrarImposto()
        {
            Console.WriteLine("Logica Cobranca Dinheiro");
        }
    }
}