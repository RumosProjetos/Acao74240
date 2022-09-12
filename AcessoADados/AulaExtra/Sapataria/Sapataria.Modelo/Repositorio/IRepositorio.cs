namespace Sapataria.Modelo.Repositorio
{
    public interface IRepositorio <T>
    {
        public void Adicionar(T item);//Create
        public T ObterPorId(string id);//Read
        public void Atualizar(string id, T item);//Update
        public void Apagar(string id);//Delete
        public List<T> Listar();
    }
}
