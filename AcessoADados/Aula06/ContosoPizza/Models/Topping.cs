using System.ComponentModel.DataAnnotations;

namespace ContosoPizza.Models;

public class Topping
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }

    [Range(1,10000)]
    public int Calories { get; set; }
    public bool IsVegan { get; set; }
}