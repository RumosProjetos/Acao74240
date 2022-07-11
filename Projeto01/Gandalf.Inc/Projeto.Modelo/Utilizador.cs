

namespace Projeto.Modelo
{
    public class Utilizador
    {
        public Utilizador()
        {
            Vendas = new List<Venda>();
        }

        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string UserNumber { get; set; }
        public string UserPw { get; set; }
        public List<Venda> Vendas { get; set; }
    }
}
