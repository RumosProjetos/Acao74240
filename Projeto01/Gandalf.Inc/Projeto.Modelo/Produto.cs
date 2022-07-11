namespace Projeto.Modelo
{
    public class Produto
    {
        public Produto() => Estoques = new List<Estoque>();
        public Guid Id { get; set; }
        public string CodigoBarras { get; set; }
        public string NomeProduto { get; set; }
        public string UnidadeMedida { get; set; }
        public decimal QuantidadePorUnidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public bool? Descontinuado { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataModificacao { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual List<Estoque> Estoques { get; set; }
    }
}
