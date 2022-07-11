namespace Validadores.FinancasPortuguesas
{
    public class PessoaColetiva : NumeroIdentificacaoFiscal
    {
        public override bool PossuiNumerosIniciaisValidos(int numerosIniciais)
        {
            var numerosValidos = new Dictionary<int, string>
            {
                {5, "Pessoa Coletiva"},
                {6, "Administração Pública"},
                {7, "Agrupador de Herança Indivisa, Pessoa Colectiva não Residente, Fundos de Investimento, Atribuição Oficiosa, Regime Excepcional"},
                {70, "Herança Indivisa"},
                {71, "Pessoa Colectiva não Residente"},
                {72, "Fundos de Investimento"},
                {77, "Atribuição Oficiosa"},
                {79, "Regime Excepcional"},
                {9, "Agrupador de Condominios e Sociedades Irregulares, Não Residentes, Sociedades Civis"},
                {90, "Condominios e Sociedades Irregulares"},
                {91, "Condominios e Sociedades Irregulares"},
                {98, "Não Residentes"},
                {99, "Sociedades Civis"}
            };

            var numerosValidosLista = numerosValidos.ContainsKey(numerosIniciais);
            return numerosValidosLista;
        }

        protected override string PosicaoInicialParaGeracao() => "5";
    }
}
