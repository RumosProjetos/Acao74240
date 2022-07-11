namespace Sapataria.PadroesDeProjeto.AbstractFactory.Exemplo
{
    public abstract class ContaBancaria
    {
        public abstract void CobrarImposto();

        public void ExemploMetodoConcreto()
        {
            Console.WriteLine("Oi, sou o método concreto da classe abstrata");
        }
    }
}