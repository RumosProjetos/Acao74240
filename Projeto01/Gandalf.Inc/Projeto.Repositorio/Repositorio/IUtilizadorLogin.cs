namespace Projeto.Repositorio.Repositorio
{
    public interface IUtilizadorLogin
    {
        Utilizador ObterPorLoginESenha(string NomeUsuario, string PalavraPasse);
        void FecharSessao();
        //Outros métodos exclusivos do utilizador
    }
}
