using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapataria.Modelo
{
    public class Funcionario : Pessoa
    {
        public int CodigoFuncional { get; set; }
        public DateTime DataContratacao { get; set; }

        public new int ObterIdade()
        {
            var resultado = 18;
            return resultado;
        }
    }
}
