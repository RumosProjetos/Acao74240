


namespace Projeto.Modelo
{
    public class tblStore
    {
        public tblStore()
        {
            tblPos = new List<tblPos>();
            tblStocks = new List<tblStock>();
        }

        public string StoreID { get; set; }

        public string Store { get; set; }

        public string StoreAddress { get; set; }

        public bool? Active { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public DateTime? CreatedDate { get; set; }

        public virtual List<tblPos> tblPos { get; set; }

        public virtual List<tblStock> tblStocks { get; set; }
    }
}
