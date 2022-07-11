using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapataria.PadroesDeProjeto.Creational.FactoryMethod.Exemplo
{
    public class ApoliceAutomovel : ICalculoApoliceSeguro
    {
        public string Pais { get; set; }

        public decimal Calcular()
        {
            var resultado = 0M;
            if (Pais == "Portugal")
            {
                Console.WriteLine("VAlor calculado para Portugal");
                resultado = Convert.ToDecimal(2000);
            }
            else
            {
                Console.WriteLine("VAlor calculado para Exterior");
                resultado = Convert.ToDecimal(3000);
            }

            return resultado;
        }
    }
}
