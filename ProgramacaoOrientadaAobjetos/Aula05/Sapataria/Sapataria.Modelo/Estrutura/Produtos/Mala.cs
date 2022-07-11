using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapataria.Modelo.Estrutura.Produtos
{
    internal class Mala : Produto
    {
        public override void ExemploSobrescrita()
        {
            throw new NotImplementedException();
        }

        public int Capacidade { get; set; }
    }
}
