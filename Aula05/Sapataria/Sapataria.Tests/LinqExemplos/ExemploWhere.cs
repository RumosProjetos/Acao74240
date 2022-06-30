﻿using Sapataria.Modelo.Estrutura.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapataria.Tests.LinqExemplos
{
    public class ExemploWhere : LinqTests
    {

        #region Exemplos Clausula Where
        /// <summary>
        /// Limpa os recursos que foram utilizados durante a execucao dos testes
        /// </summary>
        [TestCleanup]
        public void LimparTestes()
        {
            //File.Delete(@"c:\temp\log.txt");
        }


        /// <summary>
        /// Verificar se é possível obter pelo nome
        /// </summary>
        [TestMethod]
        [TestCategory("Método")]
        public void ExemploFiltragemLinqTest()
        {
            //arrange
            //Mudamos para a preparacao PrepararOsTestes()

            //act
            var listaResultado = lista.Where(cli => cli.Nome.StartsWith("J"));

            //assert
            Assert.IsNotNull(lista);
            Assert.AreEqual(2, listaResultado.Count());
        }


        /// <summary>
        /// Verificar se é possível obter pelo nome
        /// </summary>
        [TestMethod]
        [TestCategory("Query")]
        public void ExemploFiltragemLinqComQueryTest()
        {
            //arrange
            //Mudamos para a preparacao PrepararOsTestes()


            //act
            var listaResultado = from cli in lista
                                 where cli.Nome.StartsWith("J")
                                    && cli.Nome.EndsWith("o")
                                    && cli.Sexo == Sexo.Feminino
                                 select cli;

            //assert
            Assert.IsNotNull(lista);
            Assert.AreEqual(0, listaResultado.Count());
        }


        /// <summary>
        /// Listar pessoas que moram em lisboa
        /// </summary>
        [TestMethod]
        public void ExemploFiltragemLinqComMetodoEObjetoComplexoTest()
        {
            //arrange

            //act
            var listaResultado = lista.Where(x => x.Morada.Distrito == "Lisboa");


            //assert
            Assert.IsNotNull(lista);
            Assert.AreEqual(1, listaResultado.Count());
            Assert.AreEqual("Joao", listaResultado.FirstOrDefault().Nome);
        }
        #endregion




    }
}
