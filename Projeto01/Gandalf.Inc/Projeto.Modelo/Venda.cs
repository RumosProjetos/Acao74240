

namespace Projeto.Modelo
{
    public class Venda
    {
        public Venda()
        {
            tblSalesDetails = new List<tblSalesDetail>();
        }

        public int SalesID { get; set; }
        public string SalesDocNum { get; set; }
        public string Store { get; set; }
        public int POSnum { get; set; }
        public int POSUser { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? Datemodified { get; set; }
        public bool? Paid { get; set; }
        public int CUstomer { get; set; }
        public virtual tblPos tblPos { get; set; }
        public virtual List<tblSalesDetail> tblSalesDetails { get; set; }
        public virtual Utilizador tblUser { get; set; }
    }
}
