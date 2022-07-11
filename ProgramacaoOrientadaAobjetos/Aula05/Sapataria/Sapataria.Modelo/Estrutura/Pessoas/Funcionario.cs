using System.Text;

namespace Sapataria.Modelo.Estrutura.Pessoas
{
    public class Funcionario : Pessoa
    {
        public int CodigoFuncional { get; set; }
        public DateTime DataContratacao { get; set; }
        public string Departamento { get; set; }
        public decimal Salario { get; set; }

        public new int ObterIdade()
        {
            var resultado = 18;
            return resultado;
        }

        public string ImprimirTodosOsDados()
        {
            var sb = new StringBuilder();
            //BFNRT - Big Farms Need Red Tractors
            sb.AppendLine("Nome : " + Nome);
            sb.AppendLine("Numero de Identificação Fiscal : " + NumeroIdentificacaoFiscal);
            var sexo = "";

            if (Sexo == Sexo.Feminino)
            {
                sexo = "Feminino";
            }
            if (Sexo == Sexo.Masculino)
            {
                sexo = "Masculino";
            }
            sb.AppendLine("Sexo : " + sexo);
            sb.AppendLine("Data de Nascimento  : " + DataNascimento.ToString("dd/MM/yyyy"));
            sb.AppendLine("Idade  : " + Idade);

            sb.AppendLine("CodigoFuncional : " + CodigoFuncional);
            sb.AppendLine("DataContratacao : " + DataContratacao.ToString("dd/MM/yyyy"));
            sb.AppendLine("Departamento : " + Departamento);
            sb.AppendLine("Salario : " + Salario);

            return sb.ToString();
        }

        public string ImprimirDados()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Nome : " + Nome);
            sb.AppendLine("Salario : " + Salario);

            return sb.ToString();
        }
    }
}
