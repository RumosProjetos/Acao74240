

namespace Projeto.Modelo
{
    public class tblPos
    {
         public tblPos()
        {
            tblSales = new List<Venda>();
        }

        
        public int PosID { get; set; }



        public string Store { get; set; }

        [StringLength(25)]
        public string StoreLocation { get; set; }

        public virtual tblStore tblStore { get; set; }

         public virtual List<Venda> tblSales { get; set; }
    }
}
