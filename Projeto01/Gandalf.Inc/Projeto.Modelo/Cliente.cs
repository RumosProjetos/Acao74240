namespace Projeto.Modelo
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public DateTime? DataCriacao { get; set; }
        public string? Morada { get; set; }
    }
}
