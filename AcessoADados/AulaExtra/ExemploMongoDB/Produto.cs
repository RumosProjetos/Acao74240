public class Produto
{
    public String? Id { get; set; }
    public String? Nome { get; set; }
    public Categoria? Categoria { get; set; }
    public int QuantidadeEstoque { get; set; }
    public decimal Preco { get; set; }
    public string? CodigoBarras { get; set; }
    // public Byte[]? Fotografia { get; set; }

    // public int Tamanho { get; set; }    
}