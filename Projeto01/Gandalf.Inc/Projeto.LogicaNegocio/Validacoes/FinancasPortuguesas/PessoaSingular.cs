namespace Validadores.FinancasPortuguesas
{
    public class PessoaSingular : NumeroIdentificacaoFiscal
    {
        public override bool PossuiNumerosIniciaisValidos(int numerosIniciais)
        {
            var numerosValidos = new Dictionary<int, string>
            {
                {1, "Pessoa Singular"},
                {2, "Pessoa Singular"},
                {3, "Pessoa Singular"},
                {4, "Agrupador de Pessoa Singular Não Residente"},
                {45, "Pessoa Singular Não Residente"},
                {8, "Empresário em Nome Individual (extinto)"}
            };

            var numerosValidosLista = numerosValidos.ContainsKey(numerosIniciais);
            return numerosValidosLista;
        }

        protected override string PosicaoInicialParaGeracao() => "1";
    }
}
