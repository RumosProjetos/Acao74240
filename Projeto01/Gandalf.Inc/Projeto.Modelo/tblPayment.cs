

namespace Projeto.Modelo
{
    public class Pagamento
    {
        public Guid ID { get; set; }

        public string SalesNumDoc { get; set; }

        public decimal PaidValue { get; set; }

        public int? PaymentType { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string Store { get; set; }

        public virtual tblPaymentType tblPaymentType { get; set; }
    }
}
