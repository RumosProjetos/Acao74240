namespace Projeto.Repositorio.Repositorio
{
    public interface IBuscaProdutos
    {
        Produto? ObterProdutoPorNome(string nome);
        Produto? ObterProdutoPorMarca(string marca);
        Produto? ObterProdutoPorCategoria(Categoria categoria);
    }
}
