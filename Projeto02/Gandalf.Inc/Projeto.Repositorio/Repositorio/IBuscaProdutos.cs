using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Repositorio.Repositorio
{
    public interface IBuscaProdutos
    {
        Produto? ObterProdutoPorNome(string nome);
        Produto? ObterProdutoPorMarca(string marca);
        Produto? ObterProdutoPorCategoria(Categoria categoria);
    }
}
