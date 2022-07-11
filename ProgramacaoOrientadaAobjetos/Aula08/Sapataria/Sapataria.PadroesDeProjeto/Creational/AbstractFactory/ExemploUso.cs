using Sapataria.PadroesDeProjeto.AbstractFactory.Exemplo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
