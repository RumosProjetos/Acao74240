namespace Projeto.Repositorio
{
    public interface IRepositorio <T, U> where T : class 
    {
        T? Criar(U entidade);
        T? ObterPorId(Guid Id);
        T? ObterPorNome(string Nome);
        T? Obter(U entidade);
        List<T> Listar();
        T? Atualizar(T dadosAtuais, U dadosNovos);
        bool Apagar(T entidade);
        void Salvar();
    }
}