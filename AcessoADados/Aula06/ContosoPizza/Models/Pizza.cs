using System.ComponentModel.DataAnnotations;

namespace ContosoPizza.Models;

public class Pizza
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100, ErrorMessage = "Nome Muito Grande")]
    [MinLength(5, ErrorMessage = "Nome Muito Pequeno")]
    public string? Name { get; set; }

    [Range(0, 50, ErrorMessage = "Valor acima do permitido")]
    public decimal? Price { get; set; }


    public Sauce? Sauce { get; set; }
    
    public ICollection<Topping>? Toppings { get; set; }
}