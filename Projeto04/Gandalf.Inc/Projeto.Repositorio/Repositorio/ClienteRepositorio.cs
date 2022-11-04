namespace Projeto.Repositorio.Repositorio
{
    public class ClienteRepositorio : IRepositorio<Cliente>
    {
        private IList<Cliente> _clientes;

        public ClienteRepositorio(IList<Cliente> clientes)
        {
            _clientes = clientes;
        }

        public void Apagar(Guid Id)
        {
            var cliente = _clientes.FirstOrDefault(c => c.Id == Id);
            if (cliente != null)
            {
                _clientes.Remove(cliente);
            }
        }

        public void Atualizar(Cliente TEntidade)
        {
            var cliente = _clientes.FirstOrDefault(c => c.Id == TEntidade.Id);
            if (cliente != null)
            {
                _clientes.Remove(cliente);
                _clientes.Add(TEntidade);//Cuidado, solução temporária
            }
        }

        public void Carregar(string caminho)
        {
            if (File.Exists(caminho))
            {
                var conteudo = File.ReadAllText(caminho);
                if (!string.IsNullOrWhiteSpace(conteudo))
                {
                    _clientes = JsonConvert.DeserializeObject<List<Cliente>>(conteudo);
                }
            }
        }

     

        public void InserirNovo(Cliente TEntidade)
        {
            if (TEntidade != null)
            {
                if (TEntidade.Id != Guid.Empty)
                {
                    TEntidade.Id = Guid.NewGuid();
                }
                _clientes.Add(TEntidade);
            }
        }

        public Cliente? ObterPorId(Guid Id)
        {
            var cliente = _clientes.FirstOrDefault(c => c.Id == Id);
            return cliente;
        }

        public IList<Cliente>? ObterTodos()
        {
            return _clientes.ToList();
        }

        public void Salvar(string caminho)
        {
            var json = JsonConvert.SerializeObject(_clientes);
            var path = Path.GetDirectoryName(caminho);
            if (caminho != null && !Directory.Exists(path))
            {
                Directory.CreateDirectory(caminho);
            }

            File.WriteAllText(caminho, json);
        }
    }
}

