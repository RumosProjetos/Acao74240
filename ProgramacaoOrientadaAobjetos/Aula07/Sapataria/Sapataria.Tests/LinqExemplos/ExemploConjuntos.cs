using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapataria.Tests.LinqExemplos
{
    [TestClass]
    public class ExemploConjuntos
    {

        /// <summary>
        /// Definição do objetivo do teste
        /// </summary>
        [TestMethod]
        public void MyTestMethod()
        {
            //arrange
            var listaNumerosSorteados = new List<int> { 10,11,42,45,55,59};
            var bilheteRui = new List<int> { 10, 42, 45, 55, 9, 5 };

            //act
            var numerosEmComum = listaNumerosSorteados.Intersect(bilheteRui);
            var contagemNumerosCoum = numerosEmComum.Count();

            var numerosNaoComuns = listaNumerosSorteados.Except(bilheteRui);

            var conjuntoTotal = listaNumerosSorteados.Union(bilheteRui);

            //assert
            Assert.IsNotNull(numerosEmComum);
            Assert.AreEqual(4, contagemNumerosCoum);

            Assert.AreEqual(2, numerosNaoComuns.Count());


        }
    }
}
