

namespace Projeto.Modelo
{
    public class Produto
    {
        public Produto()
        {
            tblStocks = new List<tblStock>();
        }


        public int ProductID { get; set; }
        public string Barcode { get; set; }
        public string ProductName { get; set; }
        public string Family { get; set; }
        public string UnitMeasure { get; set; }
        public decimal QtyPerUnit { get; set; }

        public decimal UnitPrice { get; set; }

        public bool? Discontinued { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        public virtual Categoria tblFamily { get; set; }

        public virtual List<tblStock> tblStocks { get; set; }
    }
}
