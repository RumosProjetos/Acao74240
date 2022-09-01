using System.ComponentModel.DataAnnotations;

namespace Projeto.Modelo
{
    public class Utilizador : Pessoa
    {
        public Utilizador() => Vendas = new List<Venda>();

        public Guid UtilizadorId { get; set; }
        public string? Login { get; set; }
        public string? Senha { get; set; }
        
        [MaxLength(9), MinLength(9), Required(ErrorMessage = "Telefone é obrigatório")]
        [RegularExpression("\\d{9}")]
        public string? Telefone { get; set; }
        public virtual List<Venda> Vendas { get; set; }
    }
}
