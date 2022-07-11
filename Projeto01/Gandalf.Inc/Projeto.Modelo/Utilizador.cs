

namespace Projeto.Modelo
{
    public class Utilizador
    {
        public Utilizador()
        {
            tblSales = new List<Venda>();
        }
        
        public Guid ID { get; set; }
        public string UserName { get; set; }
        public string UserNumber { get; set; }
        public string UserPw { get; set; }
        public List<Venda> tblSales { get; set; }
    }
}
