namespace Projeto.Modelo
{
    public class Estoque
    {
        public Guid Id { get; set; }
        public int Quantidade { get; set; }
        public int QuantidadeMinima { get; set; }
        public DateTime? DataModificacao { get; set; }
        public DateTime? DataCriacao { get; set; }
        public virtual Produto? Produto { get; set; }
        public virtual Loja? Loja { get; set; }
    }
}
