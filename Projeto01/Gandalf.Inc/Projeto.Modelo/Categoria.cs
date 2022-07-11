namespace Projeto.Modelo
{
    public class Categoria
    {
        public Categoria() => Produtos = new List<Produto>();
        public Guid Id { get; set; }
        public string? Descricao { get; set; }
        public virtual List<Produto> Produtos { get; set; }
    }
}
