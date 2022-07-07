using Sapataria.PadroesDeProjeto.Creational.FactoryMethod.Exemplo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
