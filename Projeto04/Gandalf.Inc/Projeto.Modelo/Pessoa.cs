using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.Modelo
{
    public abstract class Pessoa
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório")]
        [MaxLength(60)]
        public string? Nome { get; set; }
        public DateTime? DataCriacao { get; set; }

        [MaxLength(120, ErrorMessage = "O tamanho da morada excede o máximo de 120 caracteres")]
        public string? Morada { get; set; }

        [MaxLength(50)]
        public string? Cidade { get; set; }

        [MaxLength(150)]
        [DataType(DataType.EmailAddress)]
        public string? EnderecoEletronico { get; set; }

        [MaxLength(9), MinLength(9), Required(ErrorMessage = "NIF é obrigatório")]
        [RegularExpression("\\d{9}")]
        public string? NumeroIdentificacaoFiscal { get; set; }
    }
}