

namespace Projeto.Modelo
{
    public class tblPaymentType
    {
         public tblPaymentType()
        {
            tblPayments = new List<Pagamento>();
        }

        
        public int PaymentTypeID { get; set; }


        public string PaymentType { get; set; }

         public virtual List<Pagamento> tblPayments { get; set; }
    }
}
