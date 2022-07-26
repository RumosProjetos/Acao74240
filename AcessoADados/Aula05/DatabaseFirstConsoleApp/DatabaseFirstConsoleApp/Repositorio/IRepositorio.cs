using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstConsoleApp.Repositorio
{
    public interface IRepositorio<T>
    {
        List<T> ObterTodos();
        List<T> ObterTodosMaioresDe(int idade);
        List<T> ObterTodosEmOrdemAlfabetica();
        T ObterPorId(Guid id);
        T ObterPorNomeUsandoLambda(string nome);
        T ObterPorNomeUsandoLinqAntigo(string nome);
        T ObterPorNomePorPosicaoAgenda(string nome);

        void CriarNovo(T entidade);
        void Apagar(Guid id);
        void AtualizarNome(Guid id, string nome);
    }
}
