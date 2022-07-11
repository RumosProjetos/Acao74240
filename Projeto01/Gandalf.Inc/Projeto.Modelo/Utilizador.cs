namespace Projeto.Modelo
{
    public class Utilizador
    {
        public Utilizador() => Vendas = new List<Venda>();
        public Guid Id { get; set; }
        public string? Login { get; set; }
        public string? Senha { get; set; }
        public string? Nome { get; set; }
        public List<Venda> Vendas { get; set; }
    }
}
