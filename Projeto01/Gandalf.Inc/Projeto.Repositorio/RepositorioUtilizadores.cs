using Newtonsoft.Json;
using Projeto.Modelo;
using Projeto.Repositorio.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Repositorio
{
    public class RepositorioUtilizadores : IRepositorio<Utilizador, UtilizadorDto>
    {
        const string caminhoDatabase = @"c:\temp\GandalfDB\Utilizadores.txt";
        private List<Utilizador> _utilizadores { get; set; }
        public RepositorioUtilizadores()
        {
            if (!Directory.Exists(@"c:\temp\GandalfDB"))
            {
                Directory.CreateDirectory(@"c:\temp\GandalfDB");
            }

            if (!File.Exists(caminhoDatabase))
            {
                File.Create(caminhoDatabase);
            }
            else
            {
                var json = File.ReadAllText(caminhoDatabase);
                _utilizadores = JsonConvert.DeserializeObject<List<Utilizador>>(json);
            }

            if(_utilizadores == null)
                _utilizadores = new List<Utilizador>();
        }

        public bool Apagar(Utilizador entidade)
        {
            return _utilizadores.Remove(entidade);
        }

        public Utilizador? Atualizar(Utilizador dadosAtuais, UtilizadorDto dadosNovos)
        {
            var utilizador = _utilizadores.FirstOrDefault(dadosAtuais);

            utilizador.Senha = dadosNovos.Senha;
            utilizador.Login = dadosNovos.Login;
            utilizador.Nome = dadosNovos.Nome;

            return utilizador;
        }

        public Utilizador? Criar(UtilizadorDto entidade)
        {
            var utilizador = new Utilizador
            {
                Login = entidade.Login,
                Senha = entidade.Senha,
                Nome = entidade.Nome
            };
            _utilizadores.Add(utilizador);

            return utilizador;
        }

        public List<Utilizador> Listar()
        {
            return _utilizadores;
        }

        public Utilizador? Obter(UtilizadorDto entidade)
        {
            var utilizador = _utilizadores?.FirstOrDefault(x => x.Senha == entidade.Senha && x.Login == entidade.Login);
            return utilizador;
        }

        public Utilizador? ObterPorLoginESenha(string nomeUsuario, string palavraPasse)
        {
            var utilizador = _utilizadores?.FirstOrDefault(x => x.Login == nomeUsuario && x.Senha == palavraPasse);
            return utilizador;
        }

        public Utilizador? ObterPorId(Guid Id)
        {
            var utilizador = _utilizadores?.FirstOrDefault(x => x.Id == Id);
            return utilizador;
        }

        public Utilizador? ObterPorNome(string Nome)
        {
            var utilizador = _utilizadores?.FirstOrDefault(x => x.Nome == Nome);
            return utilizador;
        }

        public void Salvar()
        {
            //TODO: Ler de arquivo de configuracao
            var json = JsonConvert.SerializeObject(_utilizadores);
            File.WriteAllText(caminhoDatabase, json);
        }
    }
}
