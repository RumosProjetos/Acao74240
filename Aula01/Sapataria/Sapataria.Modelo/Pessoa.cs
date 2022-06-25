namespace Sapataria.Modelo
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }        
        public string NumeroIdentificacaoFiscal { get; set; }
        public Sexo Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade => ObterIdade();


        public virtual int ObterIdade()
        {
            var resultado = DateTime.Now.Year - DataNascimento.Year;
            return resultado;
        }
    }
}