using System.ComponentModel.DataAnnotations;

namespace ContosoPizza.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required]
        [MaxLength(100)]
        [MinLength(5)]
        public string? Name { get; set; }

        [Required]
        [MaxLength(100)]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }


        [DataType(DataType.CreditCard)]
        public string? CreditCard { get; set; }


        public Pizza? FavoritePizza { get; set; }
    }
}

