using Sapataria.PadroesDeProjeto.Creational.FactoryMethod.Exemplo;

namespace Sapataria.PadroesDeProjeto.Creational.FactoryMethod
{
    internal class ExemploUso
    {
        public void Exemplo()
        {
            ICalculoApoliceSeguro calc = new ApoliceVida();
            calc.Calcular();
        }
    }
}
