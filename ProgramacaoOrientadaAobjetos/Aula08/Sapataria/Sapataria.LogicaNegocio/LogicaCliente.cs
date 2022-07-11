using Sapataria.Modelo.Estrutura.Pessoas;
using Sapataria.Modelo.Repositorio;

namespace Sapataria.LogicaNegocio
{
    public class LogicaCliente
    {
        #region Métodos Privados
        //RN01 - Cliente Tem que ter mais de 18 anos
        private bool EhMaiorDeIdade(DateTime dataNascimento)
        {
            const int idadeMinima = 18;
            var resultado = DateTime.Now.Year - dataNascimento.Year >= idadeMinima;
            return resultado;
        }

        //RN02 - Nif tem que ser válido
        private bool PossuiNifValido(string nif)
        {
            var resultado = !string.IsNullOrWhiteSpace(nif) && nif.Length == 9 && nif.All(x => char.IsDigit(x));
            return resultado;
        }

        //RN03 - Nome é obrigatório
        private bool PossuiNome(string nome)
        {
            var resultado = !string.IsNullOrWhiteSpace(nome);
            return resultado;
        }

        #endregion

        #region Métodos Públicos
        public bool EstaValido(Cliente cliente)
        {
            var resultado = EhMaiorDeIdade(cliente.DataNascimento) &&
                            PossuiNifValido(cliente.NumeroIdentificacaoFiscal) &&
                            PossuiNome(cliente.Nome);
            return resultado;
        }



        public void AdicionarCliente(Cliente cliente)
        {
            var repositorio = new RepositorioCliente();
            repositorio.Adicionar(cliente);
            repositorio.Salvar();
        }

        public void ListarClientes()
        {
            var repositorio = new RepositorioCliente();
            repositorio.Listar();
        }


        #endregion
    }
}
