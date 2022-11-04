using System.Text;

namespace Projeto.Validadores.Validacoes
{
    /// <summary>
    /// Exemplo de Abstract Factory 
    /// https://sourcemaking.com/design_patterns/abstract_factory
    /// </summary>
    public abstract class Validador : IValidavel
    {
        #region Métodos Protected
        protected virtual bool PossuiNumeroMinimoElementos(string parametros, int posicoes)
        {
            var resultado = parametros.Length >= posicoes;
            return resultado;
        }

        protected virtual bool OsElementosNaoSaoTodosIguaisEntreSi(string parametros)
        {
            var elementosDiferentes = parametros.ToCharArray().ToList();
            var resultado = elementosDiferentes.Distinct().Count() > 1;

            return resultado;
        }

        protected virtual bool VerificarDigitos(string parametros, int posicaoDigito)
        {
            var digitoVerificadorCalculado = CalcularDigitoVerificador(parametros, posicaoDigito);
            var digitoVerificadorInformado = Convert.ToInt32(parametros[posicaoDigito].ToString());
            var resultado = digitoVerificadorInformado == digitoVerificadorCalculado;

            return resultado;
        }

        protected virtual int CalcularDigitoVerificador(string parametros, int posicaoDigito)
        {
            var somatorio = 0;
            var multiplicador = posicaoDigito + 1;

            for (var i = 0; i < posicaoDigito; i++)
            {
                var elemento = Convert.ToInt32(parametros[i].ToString());
                var va = elemento * multiplicador;
                somatorio += va;
                multiplicador--;
            }

            var resto = somatorio % 11;
            var digitoVerificadorCalculado = 0;

            if (resto >= 2)
                digitoVerificadorCalculado = 11 - resto;
            return digitoVerificadorCalculado;
        }

        #endregion Métodos Protected

        #region Métodos Abstratos

        /// <summary>
        /// Exemplo de Factory Method. Valida se determinado documento está válido
        /// https://sourcemaking.com/design_patterns/factory_method
        /// </summary>
        /// <param name="parametros"></param>
        /// <returns></returns>
        public abstract bool EstaValido(string parametros);

        /// <summary>
        /// Exemplo de Factory Method. Gera valores aleatórios para testes
        /// https://sourcemaking.com/design_patterns/factory_method
        /// </summary>
        /// <param name="parametros"></param>
        /// <returns></returns>
        public abstract string GerarValorParaTestes(bool formatado = false);

        /// <summary>
        /// Exemplo de Factory Method. Formata no padrão esperado
        /// https://sourcemaking.com/design_patterns/factory_method
        /// </summary>
        /// <param name="parametros"></param>
        /// <returns></returns>
        public abstract string ToStringFormatado(string parametros);
        #endregion Métodos Abstratos

        #region Métodos Públicos
        public virtual string ToStringFormatado(StringBuilder parametros)
        {
            return ToStringFormatado(parametros.ToString());
        }
        #endregion
    }
}
