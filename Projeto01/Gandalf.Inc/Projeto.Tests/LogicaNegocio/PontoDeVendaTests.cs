using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Tests.LogicaNegocio
{
    [TestClass]
    public class PontoDeVendaTests
    {
        //RN01 -  Each POS must have a login.
        [TestMethod]
        public void DeveExistirLoginNoPontoDeVendaTest()
        {
            //arrange
            var sessaoUtilizador = new SessaoUtilizador("Login", "PalavraPasse", new PontoDeVenda());

            //act

            //assert		
            Assert.IsNotNull(sessaoUtilizador);    
        }

        //RN01 -  Each POS must have a login.
        [TestMethod]
        public void DeveRetornarErroSeNaoExistirLoginNoPontoDeVendaTest()
        {
            //arrange
            var sessaoUtilizador = new SessaoUtilizador("", "", new PontoDeVenda());

            //act
            var resultado = sessaoUtilizador.ValidarUtilizador();

            //assert		
            Assert.IsNotNull(sessaoUtilizador);
            Assert.IsFalse(resultado);
        }

        //RN01 -  Each POS must have a login.
        [TestMethod]
        public void DeveRetornarDadosSeExistirUtilizadorComCredenciaisSelecionadasPontoDeVendaTest()
        {
            //arrange
            var sessaoUtilizador = new SessaoUtilizador("Login", "Senha", new PontoDeVenda());

            //act
            var resultado = sessaoUtilizador.ValidarUtilizador();

            //assert		
            Assert.IsNotNull(sessaoUtilizador);
            Assert.IsFalse(resultado);
        }
    }
}
