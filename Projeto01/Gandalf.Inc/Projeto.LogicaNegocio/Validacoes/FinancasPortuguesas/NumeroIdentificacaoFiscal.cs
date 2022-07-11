using System.Text;
using System.Text.RegularExpressions;

namespace Validadores.FinancasPortuguesas
{
    public abstract class NumeroIdentificacaoFiscal : Validador
    {
        /// <summary>
        /// O NIF tem 9 dígitos, sendo o último o digito de controlo.Para ser calculado o digito de controlo:
        /// Multiplique o 8.º dígito por 2, o 7.º dígito por 3, o 6.º dígito por 4, o 5.º dígito por 5, o 4.º dígito por 6, o 3.º dígito por 7, o 2.º dígito por 8 e o 1.º dígito por 9;
        /// Some os resultados;
        /// Calcule o resto da divisão do número por 11;
        /// Se o resto for 0 (zero) ou 1 (um), o dígito de controlo será 0 (zero);
        /// Se for outro qualquer algarismo X, o dígito de controlo será o resultado da subtracção 11 - X.
        /// </summary>
        /// <param name="parametros"></param>
        /// <returns></returns>
        public override bool EstaValido(string parametros)
        {
            const int tamanhoNif = 9;
            var expressaoRegular = new Regex("[^0-9]");
            var parametrosLimpos = expressaoRegular.Replace(parametros, string.Empty);

            if (!PossuiNumeroMinimoElementos(parametrosLimpos, tamanhoNif))
                return false;

            if (!OsElementosNaoSaoTodosIguaisEntreSi(parametrosLimpos))
                return false;

            int.TryParse(parametros.Substring(0, 1), out var numeroInicial);
            if (!PossuiNumerosIniciaisValidos(numeroInicial))
                return false;

            const int posicaoPrimeiroDigito = 8;
            var digitoVerificadorCorreto = VerificarDigitos(parametrosLimpos, posicaoPrimeiroDigito);

            return digitoVerificadorCorreto;
        }

        public override string GerarValorParaTestes(bool formatado = false)
        {
            var valores = new StringBuilder(PosicaoInicialParaGeracao());
            const int tamanhoNifSemDv = 8;

            for (var i = 1; i < tamanhoNifSemDv; i++)
            {
                var numeroAleatorio = new Random();
                Thread.Sleep(100);
                var numero = numeroAleatorio.Next(9);

                valores.Append(numero);
            }

            const int posicaoDigitoVerificador = 8;
            var digitoVerificador = CalcularDigitoVerificador(valores.ToString(), posicaoDigitoVerificador);
            valores.Append(digitoVerificador);

            var resultado = formatado ? ToStringFormatado(valores) : valores.ToString();

            return resultado;
        }

        public override string ToStringFormatado(string parametros)
        {
            return string.Format(@"{0:000\ 000\ 000}", Convert.ToInt64(parametros));
        }

        protected abstract string PosicaoInicialParaGeracao();
        public abstract bool PossuiNumerosIniciaisValidos(int numeroInicial);
    }
}
