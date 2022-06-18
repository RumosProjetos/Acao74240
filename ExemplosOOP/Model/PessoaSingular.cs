using ExemplosOOP.Model;

public class PessoaSingular : Pessoa
{
    public List<Pessoa> Filhos { get; set; }

    public PessoaSingular()
    {

    }

    public PessoaSingular(string nome)
    {
        Nome = nome;
    }

    public PessoaSingular(DateTime dataNascimento)
    {
        DataNascimento = dataNascimento;
    }

    public PessoaSingular(string nome, DateTime dataNascimento)
    {
        Nome = nome;
        DataNascimento = dataNascimento;
    }
}

