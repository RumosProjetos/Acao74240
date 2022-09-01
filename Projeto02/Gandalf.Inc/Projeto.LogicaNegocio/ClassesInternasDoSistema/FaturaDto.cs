namespace Projeto.LogicaNegocio.ClassesInternasDoSistema
{
    public class FaturaDto
    {
        public string? NomeDaLoja { get; set; }
        public string? EnderecoDaLoja { get; set; }
        public Guid IdentificaoDaLoja { get; set; }
        public DateTime? DataDaVenda { get; set; }
        public string? NomeCliente { get; set; }
        public List<ProdutoFaturaDto>? DetalhesProdutos { get; set; }
        public decimal TotalDaVenda { get; set; }
    }
}

