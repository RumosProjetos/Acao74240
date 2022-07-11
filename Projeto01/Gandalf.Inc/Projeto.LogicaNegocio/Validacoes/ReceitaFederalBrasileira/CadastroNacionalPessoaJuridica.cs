using System.Text;
using System.Text.RegularExpressions;

namespace Validadores.ReceitaFederalBrasileira
{
    public class CadastroNacionalPessoaJuridica : Validador
    {
        private const int TamanhoCnpj = 14;
        private const int PosicaoDigitoVerificador1 = 12;
        private const int PosicaoDigitoVerificador2 = 13;

        protected override bool VerificarDigitos(string parametros, int posicaoDigito)
        {
            var digitoVerificadorCalculado = CalcularDigitoVerificador(parametros, posicaoDigito);
            var digitoVerificadorInformado = Convert.ToInt32(parametros[posicaoDigito].ToString());
            var resultado = digitoVerificadorInformado == digitoVerificadorCalculado;

            return resultado;
        }

        protected override int CalcularDigitoVerificador(string parametros, int posicaoDigito)
        {
            //Fatores de Cáculo do CNPJ - DV1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            var fatores = new List<int> { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            //Fatores de Cáculo do CNPJ - DV2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            const int fatorParaCalculoSegundoDigitoVerificador = 6;
            if (posicaoDigito == PosicaoDigitoVerificador2)
                fatores.Insert(0, fatorParaCalculoSegundoDigitoVerificador);

            var somatorio = 0;

            for (var i = 0; i < posicaoDigito; i++)
            {
                var elemento = Convert.ToInt32(parametros[i].ToString());
                var va = elemento * fatores[i];
                somatorio += va;
            }

            var resto = somatorio % 11;
            var digitoVerificadorCalculado = 0;

            if (resto >= 2)
                digitoVerificadorCalculado = 11 - resto;
            return digitoVerificadorCalculado;
        }


        public override bool EstaValido(string parametros)
        {
            var expressaoRegular = new Regex("[^0-9]");
            var parametrosLimpos = expressaoRegular.Replace(parametros, string.Empty);

            if (!PossuiNumeroMinimoElementos(parametrosLimpos, TamanhoCnpj))
                return false;

            if (!OsElementosNaoSaoTodosIguaisEntreSi(parametrosLimpos))
                return false;

            var primeiroDigitoVerificadorCorreto = VerificarDigitos(parametrosLimpos, PosicaoDigitoVerificador1);
            var segundoDigitoVerificadorCorreto = VerificarDigitos(parametrosLimpos, PosicaoDigitoVerificador2);

            return primeiroDigitoVerificadorCorreto && segundoDigitoVerificadorCorreto;
        }

        public override string GerarValorParaTestes(bool formatado = false)
        {
            var valores = new StringBuilder();

            for (var i = 0; i < 8; i++)
            {
                var numeroAleatorio = new Random();
                Thread.Sleep(100);
                var numero = numeroAleatorio.Next(9);

                valores.Append(numero);
            }
            valores.Append("0001"); //A prmeira unidade de uma empresa sempre tem CNPJ terminando em 0001

            var digitoVerificador1 = CalcularDigitoVerificador(valores.ToString(), PosicaoDigitoVerificador1);
            valores.Append(digitoVerificador1);

            var digitoVerificador2 = CalcularDigitoVerificador(valores.ToString(), PosicaoDigitoVerificador2);
            valores.Append(digitoVerificador2);

            var resultado = formatado ? ToStringFormatado(valores) : valores.ToString();

            return resultado;
        }

        public override string ToStringFormatado(string parametros)
        {
            return string.Format(@"{0:00\.000\.000\/0000\-00}", Convert.ToInt64(parametros));
        }
    }

}
