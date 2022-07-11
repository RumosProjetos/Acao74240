namespace Sapataria.PadroesDeProjeto.AbstractFactory.Exemplo
{
    public class ContaImoveis : ContaBancaria
    {
        public override void CobrarImposto()
        {
            Console.WriteLine("Logica Cobranca Imoveis - Regra Nova");
        }
    }
}