namespace Projeto.Repositorio.Repositorio
{
    public class VendaRepositorio : IRepositorio<Venda>
    {
        private IList<Venda> _vendas;

        public VendaRepositorio(IList<Venda> vendas)
        {
            _vendas = vendas;
        }

        public void Apagar(Guid Id)
        {
            var utilizador = _vendas.FirstOrDefault(c => c.Id == Id);
            if (utilizador != null)
            {
                _vendas.Remove(utilizador);
            }
        }

        public void Atualizar(Venda TEntidade)
        {
            var utilizador = _vendas.FirstOrDefault(c => c.Id == TEntidade.Id);
            if (utilizador != null)
            {
                _vendas.Remove(utilizador);
                _vendas.Add(TEntidade);//Cuidado, solução temporária
            }
        }

        public void Carregar(string caminho)
        {
            if (File.Exists(caminho))
            {
                var conteudo = File.ReadAllText(caminho);
                if (!string.IsNullOrWhiteSpace(conteudo))
                {
                    _vendas = JsonConvert.DeserializeObject<List<Venda>>(conteudo);
                }
            }
        }



        public void InserirNovo(Venda TEntidade)
        {
            if (TEntidade != null)
            {
                _vendas.Add(TEntidade);
            }
        }

        public Venda? ObterPorId(Guid Id)
        {
            var utilizador = _vendas.FirstOrDefault(c => c.Id == Id);
            return utilizador;
        }

        public IList<Venda>? ObterTodos()
        {
            return _vendas.ToList();
        }

        public void Salvar(string caminho)
        {
            var json = JsonConvert.SerializeObject(_vendas);
            var path = Path.GetDirectoryName(caminho);
            if (caminho != null && !Directory.Exists(path))
            {
                Directory.CreateDirectory(caminho);
            }

            File.WriteAllText(caminho, json);
        }
    }
}