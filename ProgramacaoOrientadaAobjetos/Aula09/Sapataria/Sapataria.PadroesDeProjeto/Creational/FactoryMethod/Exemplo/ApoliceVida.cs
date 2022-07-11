namespace Sapataria.PadroesDeProjeto.Creational.FactoryMethod.Exemplo
{
    public class ApoliceVida : ICalculoApoliceSeguro
    {
        public int Idade { get; set; }

        public decimal Calcular()
        {
            Console.WriteLine();
            return Convert.ToDecimal(Idade * 0.25);
        }
    }
}
