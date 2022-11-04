namespace Projeto.Repositorio
{
    /// <summary>
    /// Implementação do Padrão Repositório:
    /// Baseado em:
    /// https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application
    /// </summary>
    /// <typeparam name="T"></typeparam>    
    public interface IRepositorio<T>
    {
        IList<T>? ObterTodos();
        T? ObterPorId(Guid Id);
        void InserirNovo(T TEntidade);
        void Apagar(Guid Id);
        void Atualizar(T TEntidade);

        void Salvar(string path);
    }
}