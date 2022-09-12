using Sapataria.Modelo.Estrutura.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapataria.Modelo.Repositorio
{
    public class RepositorioCliente : IRepositorio<Cliente>
    {
        public void Adicionar(Cliente item)
        {
            throw new NotImplementedException();
        }

        public void Apagar(string id)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(string id, Cliente item)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> Listar()
        {
            throw new NotImplementedException();
        }

        public Cliente ObterPorId(string id)
        {
            throw new NotImplementedException();
        }
    }
}
