using ExemploADO.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploADO
{
    public interface IRepositorio
    {
        List<Pessoa> ObterTodos();
        Pessoa ObterPorId(Guid id);
        void Criar(Pessoa pessoa);
        void Atualizar(Guid id, Pessoa pessoa);
        void Apagar(Guid id);
    }
}
