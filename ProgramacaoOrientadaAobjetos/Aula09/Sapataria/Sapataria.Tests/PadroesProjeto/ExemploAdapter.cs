using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sapataria.PadroesDeProjeto.Structural.Adapter.Exemplo.Adaptadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapataria.Tests.PadroesProjeto
{
    [TestClass]
    public class ExemploAdapter
    {
        [TestMethod]
        public void DeveProcessarPagamentoIndependementeDoGatewayTest()
        {
            //arrange
            var pagamentos = new List<PagamentoAdapter>();
            pagamentos.Add(new BubblesAdapter());
            pagamentos.Add(new MercadoPagoAdapter());
            pagamentos.Add(new PaypalAdapter());
            pagamentos.Add(new SibsAdapter { NumeroFiscal = "999.999.999"});
            pagamentos.Add(new SibsAdapter { NumeroFiscal = "999.999.999" });
            pagamentos.Add(new SibsAdapter { NumeroFiscal = "999.999.999" });
            /*...*/

            //act
            foreach (var item in pagamentos)
            {
                item.Pagar();
            }


            //assert		
            foreach (var item in pagamentos)
            {
                Assert.IsNotNull(item.DataPagamento);
            }
        }
    }
}
