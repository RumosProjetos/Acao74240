using Projeto.Modelo;
using Projeto.Repositorio;

namespace Projeto.Tests.LogicaNegocio
{
    public class SessaoUtilizador
    {
        public SessaoUtilizador(string nomeUsuario, string palavraPasse, PontoDeVenda pontoDeVenda)
        {
            NomeUsuario = nomeUsuario;
            PalavraPasse = palavraPasse;
            PontoDeVenda = pontoDeVenda;
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
                var repo = new RepositorioUtilizadores();
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