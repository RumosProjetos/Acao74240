using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapataria.Tests.LinqExemplos
{
    [TestClass]
    public class ExemploOrdenacao : LinqTests
    {

        /// <summary>
        /// Ordernar por nome
        /// </summary>
        [TestMethod]
        public void ExemploOrdenacaoTestes()
        {
            //arrange

            //act
            var listaOrdenada = clientes.OrderBy(x => x.Nome);

            //assert
            Assert.IsNotNull(listaOrdenada);
            Assert.AreEqual("Sasha", clientes.FirstOrDefault().Nome);
            Assert.AreEqual("Sasha", listaOrdenada.LastOrDefault().Nome);
        }




        /// <summary>
        /// Ordernar por nome e depois por data de nascimento
        /// onde eu quero a mais nova
        /// </summary>
        [TestMethod]
        public void ExemploOrdenacaoDuasCondicoesTestes()
        {
            //arrange

            //act
            var listaOrdenada = clientes.Where(x => x.Nome.StartsWith("M"))
                                     .OrderBy(x => x.Nome)
                                     .ThenByDescending(x => x.Idade); //primeiro a mais velha

            //assert
            Assert.IsNotNull(listaOrdenada);
            Assert.AreEqual("Sasha", clientes.FirstOrDefault().Nome);
            Assert.AreEqual("Maria", listaOrdenada.FirstOrDefault().Nome);
            Assert.AreEqual("Maria", listaOrdenada.LastOrDefault().Nome);

            Assert.AreEqual("Leiria (mais velha)", listaOrdenada.FirstOrDefault().Morada.Distrito);
        }


    }
}
