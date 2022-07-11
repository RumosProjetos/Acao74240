namespace ExemplosOOP.Model
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public Pessoa() { }


        //verb + noum
        //Verbo + Substantivo
        public int ObterIdade()
        {
            var idade = DateTime.Now.Year - DataNascimento.Year;
            return idade;
        }

        //RegraNegocio:  RN01 - Nenhum cliente pode ter mais de 100 anos
        public bool ValidarIdade()
        {
            var ehValido = ObterIdade() <= 100;
            return ehValido;
        }


        public override string ToString()
        {
            //var resultado = "Nome: " + Nome + " DataNascimento: " + DataNascimento.ToString() + " Idade: " + ObterIdade();
            var resultado = $"Nome: {Nome} DataNascimento: {DataNascimento} Idade: {ObterIdade()}"; //String Interpolation C# 6.0
            return resultado;
        }

    }
}