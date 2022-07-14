using Projeto.Modelo;
using Projeto.Repositorio.Repositorio;

namespace Projeto.Tests.LogicaNegocio
{
    public class SessaoUtilizador
    {
        private readonly IList<Utilizador> _utilizadores;
        public SessaoUtilizador(string nomeUsuario, string palavraPasse, PontoDeVenda pontoDeVenda, IList<Utilizador> utilizadores)
        {
            NomeUsuario = nomeUsuario;
            PalavraPasse = palavraPasse;
            PontoDeVenda = pontoDeVenda;
            _utilizadores = utilizadores;
        }

        private string NomeUsuario { get; init; }
        private string PalavraPasse { get; init; }         
        private PontoDeVenda PontoDeVenda { get; init; }
        public DateTime ValidadeDaSessao { get; set; }


        public bool ValidarUtilizador()
        {
            Utilizador utilizador = null;
            if (!string.IsNullOrWhiteSpace(NomeUsuario) && !string.IsNullOrWhiteSpace(PalavraPasse))
            {
                var repo = new UtilizadorRepositorio(_utilizadores);
                utilizador = repo.ObterPorLoginESenha(NomeUsuario, PalavraPasse);

                if (utilizador != null)
                {
                    ValidadeDaSessao = DateTime.Now.AddMinutes(30);
                }
            }

            return utilizador != null;
        }
    }
}