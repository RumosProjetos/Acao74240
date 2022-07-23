using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploDatabaseFirst
{
    public partial class Pessoa
    {
        public int Idade => DateTime.Now.Year - DataNascimento.Value.Year;
    }
}
