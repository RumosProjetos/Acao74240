using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Repositorio.Repositorio
{
    public class RepositorioProduto : IRepositorio<Produto>, IBuscaProdutos
    {
        private IList<Produto> _produtos;
        public RepositorioProduto(IList<Produto> produtos)
        {
            _produtos = produtos;
        }

        public void Apagar(Guid Id)
        {
            var produto = _produtos.FirstOrDefault(c => c.Id == Id);
            if (produto != null)
            {
                _produtos.Remove(produto);
            }
        }

        public void Atualizar(Produto TEntidade)
        {
            var produto = _produtos.FirstOrDefault(c => c.Id == TEntidade.Id);
            if (produto != null)
            {
                _produtos.Remove(produto);
                _produtos.Add(TEntidade);//Cuidado, solução temporária
            }
        }

        public void Carregar(string caminho)
        {
            if (File.Exists(caminho))
            {
                var conteudo = File.ReadAllText(caminho);
                if (!string.IsNullOrWhiteSpace(conteudo))
                {
                    _produtos = JsonConvert.DeserializeObject<List<Produto>>(conteudo);
                }
            }
        }

        public void InserirNovo(Produto TEntidade)
        {
            if (TEntidade != null)
            {
                if (TEntidade.Id != Guid.Empty)
                {
                    TEntidade.Id = Guid.NewGuid();
                }
                _produtos.Add(TEntidade);
            }
        }

        public Produto? ObterPorId(Guid Id)
        {
            var produto = _produtos.FirstOrDefault(c => c.Id == Id);
            return produto;
        }

        public Produto? ObterProdutoPorCategoria(Categoria categoria)
        {
            var produto = _produtos.FirstOrDefault(c => c.Categoria == categoria);
            return produto;
        }

        public Produto? ObterProdutoPorMarca(string marca)
        {
            var produto = _produtos.FirstOrDefault(c => c.Marca == marca);
            return produto;
        }

        public Produto? ObterProdutoPorNome(string nome)
        {
            var produto = _produtos.FirstOrDefault(c => c.Nome == nome);
            return produto;
        }

        public IList<Produto>? ObterTodos()
        {
            return _produtos.ToList();
        }

        public void Salvar(string caminho)
        {
            var json = JsonConvert.SerializeObject(_produtos);
            var path = Path.GetDirectoryName(caminho);
            if (caminho != null && !Directory.Exists(path))
            {
                Directory.CreateDirectory(caminho);
            }

            File.WriteAllText(caminho, json);
        }
    }
}
