﻿using Sapataria.PadroesDeProjeto.Creational.FactoryMethod.Exemplo;

namespace Sapataria.Tests.PadroesProjeto
{
    [TestClass]
    public class ExemploFactoryMethod
    {
        [TestMethod]
        public void DeveCalcularValorSeguroDeVida()
        {
            //arrange
            ICalculoApoliceSeguro calc = new ApoliceVida { Idade = 10 };

            //act
            var valor = calc.Calcular();

            //assert		
            Assert.AreEqual(2.5M, valor);
        }


        [TestMethod]
        public void DeveCalcularValorSeguroAutomovelPortugal()
        {
            //arrange
            ICalculoApoliceSeguro calc = new ApoliceAutomovel{ Pais = "Portugal" };

            //act
            var valor = calc.Calcular();

            //assert		
            Assert.AreEqual(2000M, valor);
        }


        [TestMethod]
        public void DeveCalcularValorSeguroAutomovelEstrangeiro()
        {
            //arrange
            ICalculoApoliceSeguro calc = new ApoliceAutomovel { Pais = "Brasil" };

            //act
            var valor = calc.Calcular();

            //assert		
            Assert.AreEqual(3000M, valor);
        }
    }
}
