using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.Website.Models
{
    public partial class Pessoa
    {
        public Pessoa()
        {
            VendaClientes = new HashSet<Venda>();
            VendaUtilizadors = new HashSet<Venda>();
        }


        public Guid Id { get; set; }


        public Guid? UtilizadorId { get; set; }
        public string? Login { get; set; }

        [DataType(DataType.Password)]
        public string? Senha { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression("\\d{9}", ErrorMessage = "Telefone Inválido")]
        public string? Telefone { get; set; }
        public string Nome { get; set; } = null!;

        [Display(Name = "Data de Criação")]
        public DateTime? DataCriacao { get; set; }
        public string? Morada { get; set; }
        public string? Cidade { get; set; }

        [Display(Name = "Endereço de Email")]
        [DataType(DataType.EmailAddress)]
        public string? EnderecoEletronico { get; set; }


        [Display(Name = "NIF")]
        [Required]
        [RegularExpression("\\d{9}", ErrorMessage = "NIF Inválido")]
        public string NumeroIdentificacaoFiscal { get; set; } = null!;

         public Guid? ClienteId { get; set; }
        public string Discriminator { get; set; } = null!;

        public virtual ICollection<Venda> VendaClientes { get; set; }
        public virtual ICollection<Venda> VendaUtilizadors { get; set; }
    }
}
