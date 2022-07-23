using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploDatabaseFirst.Repositorio
{
    public interface IRepositorio<T>
    {
        List<T> ObterTodos();
        List<T> ObterOsPrimeiros(int quantidadeDeLinhas);
        T ObterPorId(Guid id);
        T ObterPorNome(string nome);
        void Criar(T dados);
        void Atualizar(Guid id, T dados);
        void Apagar(Guid id);
    }
}
