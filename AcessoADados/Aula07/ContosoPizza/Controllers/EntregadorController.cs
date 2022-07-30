using ContosoPizza.Data;
using ContosoPizza.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntregadorController : ControllerBase
    {
        PizzaContext _context;

        public EntregadorController(PizzaContext context)
        {
            _context = context;
        }

        [HttpPost]
        public void CriarEntregador(Carrier dados)
        {
            _context.Carriers.Add(dados);
            _context.SaveChanges();
        }


        [HttpPost("Martelado")]
        public void CriarEntregadorComDadosMartelados()
        {
            var dados = new Carrier
            {
                DiaDeFolga = DiasDeTrabalho.Quinta,
                NomeEntregador = "Manda Chuva",
                DataContratacao = DateTime.Now
            };

            _context.Carriers.Add(dados);
            _context.SaveChanges();
        }

    }
}
