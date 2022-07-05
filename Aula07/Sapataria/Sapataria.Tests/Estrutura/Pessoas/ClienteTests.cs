using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sapataria.Modelo.Estrutura.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapataria.Modelo.Estrutura.Pessoas.Tests
{
    [TestClass()]
    public class ClienteTests
    {
        [TestMethod()]
        public void DeveObterUmAnoDeIdadeSeOClienteNasceuHa12MesesTest()
        {
            //Arrange
            var cliente = new Cliente();
            cliente.DataNascimento = DateTime.Now.AddYears(-1);

            //Act
            var idade = cliente.ObterIdade();

            //Assert
            Assert.AreEqual(1, idade);
        }
    }
}