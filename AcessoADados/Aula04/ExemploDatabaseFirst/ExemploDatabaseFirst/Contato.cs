//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExemploDatabaseFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contato
    {
        public System.Guid Id { get; set; }
        public string Tipo { get; set; }
        public string Telefone { get; set; }
        public System.Guid PessoaId { get; set; }
        public string EnderecoEletronico { get; set; }
    
        public virtual Pessoa Pessoa { get; set; }
    }
}
