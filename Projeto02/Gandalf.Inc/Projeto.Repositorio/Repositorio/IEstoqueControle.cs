using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Repositorio.Repositorio
{
    public interface IEstoqueControle
    {
        int ObterQuantidadeEmEstoque(Produto produto);
    }
}
