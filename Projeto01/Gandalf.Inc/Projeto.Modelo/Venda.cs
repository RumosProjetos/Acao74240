

namespace Projeto.Modelo
{
    public class Venda
    {
        public Venda() => tblSalesDetails = new List<DetalhesDaVenda>();

        public int SalesID { get; set; }
        public string SalesDocNum { get; set; }
        public string Store { get; set; }
        public int POSnum { get; set; }
        public int POSUser { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? Datemodified { get; set; }
        public bool? Paid { get; set; }
        public int CUstomer { get; set; }
        public virtual PontoDeVenda tblPos { get; set; }
        public virtual List<DetalhesDaVenda> tblSalesDetails { get; set; }
        public virtual Utilizador tblUser { get; set; }
    }
}
