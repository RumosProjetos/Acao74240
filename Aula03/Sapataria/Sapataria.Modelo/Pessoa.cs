namespace Sapataria.Modelo
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string NumeroIdentificacaoFiscal { get; set; }
        public Sexo Sexo { get; set; }

    }
}