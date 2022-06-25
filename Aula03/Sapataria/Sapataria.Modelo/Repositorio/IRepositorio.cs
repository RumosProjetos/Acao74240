namespace Sapataria.Modelo.Repositorio
{
    public interface IRepositorio <T>
    {
        //Interface Não tem implementacao
        //Não pode ser instanciado
        public void Adicionar(T item);//Create
        public T ObterPorNome(string nome);//Read
        public T ObterPorIdentificador(int identificador);//Read
        public T Obter(T item);//Read
        public void Atualizar(T item);//Update
        public void Apagar(T item);//Delete
    }
}
