using Sapataria.PadroesDeProjeto.AbstractFactory.Exemplo;

namespace Sapataria.PadroesDeProjeto.AbstractFactory
{
    public class ExemploUso
    {
        public void Exemplo()
        {
            var lista = new List<ContaBancaria>
            {
                new ContaDinheiro(),
                new ContaDinheiro(),
                new ContaImoveis()
            };

            foreach (var item in lista)
            {
                item.CobrarImposto();
                item.ExemploMetodoConcreto();
            }
        }
    }
}
