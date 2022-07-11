
namespace Projeto.Modelo
{
    public class tblSalesDetail
    {
        public int SalesDetailID { get; set; }

        public int SalesID { get; set; }

        public int Seq { get; set; }

        public int Product { get; set; }

        public int Quantity { get; set; }

        public int UnitPrice { get; set; }

        public decimal LineTotal { get; set; }

        public DateTime? DateCreated { get; set; }

        public virtual Venda tblSale { get; set; }
    }
}
