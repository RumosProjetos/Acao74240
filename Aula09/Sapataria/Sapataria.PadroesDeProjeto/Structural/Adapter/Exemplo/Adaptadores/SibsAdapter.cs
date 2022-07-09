using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapataria.PadroesDeProjeto.Structural.Adapter.Exemplo.Adaptadores
{
    /// <summary>
    /// Nossa implementacao do adapter para a nossa aplicacao
    /// </summary>
    public class SibsAdapter : PagamentoAdapter
    {    
        public override void Pagar()
        {
            var sibs = new Gateways.SIBS
            {
                NIF = Convert.ToInt32(NumeroFiscal.Replace(".", "").Trim()),
                IBAN = Convert.ToDouble("PT500033123456709".Replace("PT50", "")), //Esse valor vem de arquivo de configuracao ou de um DB, martelamos apenas para exemplo
                Credenciais = "Credenciais"//Arquivo de configuracao    
            };

            sibs.PagarEmEuros(ValorPago);
        }
    }
}
