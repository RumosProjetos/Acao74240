namespace Projeto.Repositorio.Repositorio
{
    public class UtilizadorRepositorio : IRepositorio<Utilizador>, IUtilizadorLogin
    {
        private IList<Utilizador> _utilizadores;

        public UtilizadorRepositorio(IList<Utilizador> utilizadores)
        {
            _utilizadores = utilizadores;
        }

        public void Apagar(Guid Id)
        {
            var utilizador = _utilizadores.FirstOrDefault(c => c.Id == Id);
            if (utilizador != null)
            {
                _utilizadores.Remove(utilizador);
            }
        }

        public void Atualizar(Utilizador TEntidade)
        {
            var utilizador = _utilizadores.FirstOrDefault(c => c.Id == TEntidade.Id);
            if (utilizador != null)
            {
                _utilizadores.Remove(utilizador);
                _utilizadores.Add(TEntidade);//Cuidado, solução temporária
            }
        }

        public void Carregar(string caminho)
        {
            if (File.Exists(caminho))
            {
                var conteudo = File.ReadAllText(caminho);
                if (!string.IsNullOrWhiteSpace(conteudo))
                {
                    _utilizadores = JsonConvert.DeserializeObject<List<Utilizador>>(conteudo);
                }
            }
        }

        public void FecharSessao()
        {
            Console.WriteLine("Desligando o app");
        }

        public void InserirNovo(Utilizador TEntidade)
        {
            if (TEntidade != null)
            {
                _utilizadores.Add(TEntidade);
            }
        }

        public Utilizador? ObterPorId(Guid Id)
        {
            var utilizador = _utilizadores.FirstOrDefault(c => c.Id == Id);
            return utilizador;
        }

        public Utilizador ObterPorLoginESenha(string NomeUsuario, string PalavraPasse)
        {
            var utilizador = _utilizadores.FirstOrDefault(c => c.Nome == NomeUsuario && c.Senha == PalavraPasse);
            return utilizador;
        }

        public IList<Utilizador>? ObterTodos()
        {
            return _utilizadores.ToList();
        }

        public void Salvar(string caminho)
        {
            var json = JsonConvert.SerializeObject(_utilizadores);
           var path = Path.GetDirectoryName(caminho);
            if (caminho != null && !Directory.Exists(path))
            {
                Directory.CreateDirectory(caminho);
            }

            File.WriteAllText(caminho, json);
        }
    }
}
