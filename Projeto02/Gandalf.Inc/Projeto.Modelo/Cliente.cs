namespace Projeto.Modelo
{
    public class Cliente : Pessoa
    {
        public Guid ClienteId { get; set; }
        public virtual List<Venda>? Vendas { get; set; }
    }
}
