using Sapataria.PadroesDeProjeto.Creational.Singleton.Exemplo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapataria.PadroesDeProjeto.Creational.Singleton
{
    public class ExemploUso
    {
        public void Exemplo()
        {
            var validador = new Validador
            {
                NomeDocumento = "Teste"
            };


            var validador2 = new Validador
            {
                
            };



            var teste = validador2.NomeDocumento;


        }
    }
}
