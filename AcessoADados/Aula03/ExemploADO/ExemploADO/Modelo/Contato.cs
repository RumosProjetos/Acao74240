using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploADO.Modelo
{
    public class Contato
    {
        public Guid Id { get; set; }
        public string Tipo { get; set; }
        public string Telefone { get; set; }
        public Guid PessoaId { get; set; }
        public string EnderecoEletronico { get; set; }

        public string NomePessoa { get; set; }
    }
}
