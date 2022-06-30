using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sapataria.Modelo.Estrutura.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapataria.Tests.LinqExemplos
{
    [TestClass]
    public class ExemploQuantificador : LinqTests
    {

        /// <summary>
        /// Validar se pelo menos 1 elemento da lista não tem sexo definido
        /// </summary>
        [TestMethod]
        public void ExemploLinqProcurarClienteSexoIndefinido()
        {
            //arrange

            //act
            var existePeloMenos1SemSexo = clientes.Any(x => x.Sexo == Sexo.Indeterminado); //Qualquer 1

            //assert
            Assert.IsTrue(existePeloMenos1SemSexo);
        }


        /// <summary>
        /// VAlidar se todos os clientes possuem nome
        /// </summary>
        [TestMethod]
        public void ExemploLinqProcurarCLientesSemDataNascimento()
        {
            //arrange

            //act   //são todos
            var todosOsClientesPossuemNome = clientes.All(x => string.IsNullOrWhiteSpace(x.Nome) == false);
            var todosOsCLientesPossuemIdade = clientes.All(x => x.DataNascimento != null && x.DataNascimento > new DateTime());

            //assert
            Assert.IsNotNull(todosOsClientesPossuemNome);
            Assert.IsTrue(todosOsClientesPossuemNome);

            Assert.IsNotNull(todosOsCLientesPossuemIdade);
            Assert.IsFalse(todosOsCLientesPossuemIdade);

        }
    }
}
