

namespace Projeto.Modelo
{
    public class tblStock
    {
        
        public int StockID { get; set; }

        public int Product { get; set; }


        public string Store { get; set; }

        public int Quantity { get; set; }

        public int QuantityBase { get; set; }


        public string SaleUnit { get; set; }

        public int? QtySaleUnit { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public DateTime? CreatedDate { get; set; }

        public virtual Produto tblProduct { get; set; }

        public virtual tblStore tblStore { get; set; }
    }
}
