namespace Projeto.Repositorio.Repositorio
{
    public class EstoqueRepositorio : IRepositorio<Estoque>, IEstoqueControle
    {
        private IList<Estoque> _estoques;

        public EstoqueRepositorio(IList<Estoque> estoques)
        {
            _estoques = estoques;
        }

        public void Apagar(Guid Id)
        {
            var estoque = _estoques.FirstOrDefault(c => c.Id == Id);
            if (estoque != null)
            {
                _estoques.Remove(estoque);
            }
        }

        public void Atualizar(Estoque TEntidade)
        {
            var estoque = _estoques.FirstOrDefault(c => c.Id == TEntidade.Id);
            if (estoque != null)
            {
                _estoques.Remove(estoque);
                _estoques.Add(TEntidade);//Cuidado, solução temporária
            }
        }

        public void Carregar(string caminho)
        {
            if (File.Exists(caminho))
            {
                var conteudo = File.ReadAllText(caminho);
                if (!string.IsNullOrWhiteSpace(conteudo))
                {
                    _estoques = JsonConvert.DeserializeObject<List<Estoque>>(conteudo);
                }
            }
        }



        public void InserirNovo(Estoque TEntidade)
        {
            if (TEntidade != null)
            {
                if (TEntidade.Id != Guid.Empty)
                {
                    TEntidade.Id = Guid.NewGuid();
                }
                _estoques.Add(TEntidade);
            }
        }

        public Estoque? ObterPorId(Guid Id)
        {
            var estoque = _estoques.FirstOrDefault(c => c.Id == Id);
            return estoque;
        }

        public int ObterQuantidadeEmEstoque(Produto produto)
        {
            return _estoques.Where(x => x.Produto == produto).Sum(x => x.Quantidade);
        }

        public IList<Estoque>? ObterTodos()
        {
            return _estoques.ToList();
        }

        public void Salvar(string caminho)
        {
            var json = JsonConvert.SerializeObject(_estoques);
            var path = Path.GetDirectoryName(caminho);
            if (caminho != null && !Directory.Exists(path))
            {
                Directory.CreateDirectory(caminho);
            }

            File.WriteAllText(caminho, json);
        }
    }
}

