namespace Sapataria.Modelo.Repositorio
{
    public interface IRepositorio <T>
    {
        //Interface Não tinha implementacao  até a versão 7.3 do C#
        //isso mudou na versão 8.0 https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-8.0/default-interface-methods

        //Não pode ser instanciado
        public void Adicionar(T item);//Create
        public T ObterPorNome(string nome);//Read
        public T ObterPorIdentificador(int identificador);//Read
        public T Obter(T item);//Read
        public void Atualizar(T item);//Update
        public void Apagar(T item);//Delete


        /// <summary>
        /// Valor default
        /// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-8.0/default-interface-methods
        /// </summary>
        public void Exemplo()
        {
            ///
        }
    }
}
