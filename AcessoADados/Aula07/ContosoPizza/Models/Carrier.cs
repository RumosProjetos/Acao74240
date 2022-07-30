using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoPizza.Models
{
    [Table("Entregadores")]
    public class Carrier
    {
        //public int Id { get; set; } //Por CoC seria a chave, mas nosso ProductOwner é doido e ele que assina o cheque...


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ModeloDoCarro { get; set; }

        [Required]
        [MaxLength(150)]
        public string NomeEntregador { get; set; }

        public virtual List<Pizza> PizzasEntregues { get; set; }

        [Column("DataDeAssinaturaDeContrato")]  //Evitar espaços no nome do campo... senão dá trabalho no Select
        public DateTime? DataContratacao { get; set; }

        [Column("FolgaDoEntregador")]
        public DiasDeTrabalho DiaDeFolga { get; set; }
    }

    public enum DiasDeTrabalho
    {
        Domingo = 1000,
        Segunda = 2002,
        Terca = 3015,
        Quarta = 40000,
        Quinta = 5000000,
        Sexta = 6,
        Sabado = 70
    }
}
