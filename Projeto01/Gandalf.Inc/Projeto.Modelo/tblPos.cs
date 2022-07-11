

namespace Projeto.Modelo
{
    public class PontoDeVenda
    {
         public PontoDeVenda() => vendas = new List<Venda>();
«       public Guid Id { get; set; }
        public string LocalizacaoLoja { get; set; }
        public virtual Loja Loja { get; set; }
         public virtual List<Venda> Vendas { get; set; }
    }
}
