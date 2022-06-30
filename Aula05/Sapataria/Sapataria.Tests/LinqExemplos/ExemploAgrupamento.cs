using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapataria.Tests.LinqExemplos
{
    [TestClass]
    public class ExemploAgrupamento : LinqTests
    {
        internal class ContadorDto
        {
            public string Key { get; set; }
            public int Contagem { get; set; }
        }



        /*
             var query = petsList.GroupBy(
        pet => Math.Floor(pet.Age),
        pet => pet.Age,
        (baseAge, ages) => new
        {
            Key = baseAge,
            Count = ages.Count(),
            Min = ages.Min(),
            Max = ages.Max()
        });
         */

        /// <summary>
        /// Agrupar todos pelo nome e contar quantas pessoas tem o nome
        /// </summary>
        [TestMethod]
        public void ExemploGroupByTests()
        {
            //arrange

            //act
            var query = clientes.GroupBy(
                x => x.Nome,
                 (nome, acumulador) => new ContadorDto
                 {
                     Key = nome, //vem do objeto
                     Contagem = acumulador.Count() //calculado
                 });

            //assert
            Assert.IsNotNull(query);
            Assert.AreEqual(1, query.Where(x => x.Contagem == 2).Count());
            Assert.AreEqual("Maria", query.Where(x => x.Contagem == 2).FirstOrDefault().Key);
            Assert.AreEqual("José", query.Where(x => x.Contagem == 3).FirstOrDefault().Key);
        }



        /// <summary>
        /// Buscar cliente que também é funcionario pelo nome
        /// </summary>
        [TestMethod]
        public void ExemploJoinBuscarClienteQueEhFuncionarioQueryTest()
        {
            //arrange

            /*
             Select c.nome, f.salario
             from cliente c
             inner join funcionario f on c.nome = f.nome
            
             Select c.nome, f.salario
             from cliente c, funcionario f
             where c.nome = f.nome
             */

            //act
            var clientesFuncionarios = from c in clientes
                                       from f in funcionarios
                                       where c.Nome == f.Nome
                                       select new
                                       {
                                           c.Nome,
                                           f.Salario
                                       };

            //assert
            Assert.IsNotNull(clientesFuncionarios);
            Assert.AreEqual(1, clientesFuncionarios.Count());
            Assert.AreEqual("Sasha", clientesFuncionarios.FirstOrDefault().Nome);
        }


        /// <summary>
        /// Buscar cliente que também é funcionario pelo nome
        /// </summary>
        [TestMethod]
        public void ExemploJoinBuscarClienteQueEhFuncionarioMethodoTest()
        {
            //arrange

            /*
             Select c.nome, f.salario
             from cliente c
             inner join funcionario f on c.nome = f.nome
            
             Select c.nome, f.salario
             from cliente c, funcionario f
             where c.nome = f.nome
             */

            //act
            var clientesFuncionarios = clientes
                .Join(funcionarios, c => c.Nome, f => f.Nome,
                (c, f) => new
                {
                    c.Nome,
                    f.Salario
                });


            //assert
            Assert.IsNotNull(clientesFuncionarios);
            Assert.AreEqual(1, clientesFuncionarios.Count());
            Assert.AreEqual("Sasha", clientesFuncionarios.FirstOrDefault().Nome);
        }
    }

}
