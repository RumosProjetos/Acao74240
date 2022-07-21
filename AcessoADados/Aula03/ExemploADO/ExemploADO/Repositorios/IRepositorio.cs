using ExemploADO.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploADO
{
    public interface IRepositorio<T>
    {
        List<T> ObterTodos();
        T ObterPorId(Guid id);
        void Criar(T dados);
        void Atualizar(Guid id, T dados);
        void Apagar(Guid id);
    }
}
