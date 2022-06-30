using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sapataria.Modelo.Estrutura.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapataria.Tests.LinqExemplos
{
    //Data Transfer Objects
    //POJO - Plain Old Java Objects
    //POCO - Plain Old CLR Objects
    internal class ClienteDto
    {
        public string NomeEspecifico { get; set; }
        public string MoradaEspecifico { get; set; }
    }


    [TestClass]
    public class ExemploProjecao : LinqTests
    {

        /// <summary>
        /// Projetar objeto e trocar nome para UpperCase
        /// </summary>
        [TestMethod]
        public void ExemploProjecaoNomeEmMaisculoTest()
        {
            //arrange

            //act
            var listaResultado = lista.Select(x => new Cliente
            {
                DataNascimento = x.DataNascimento,
                Id = x.Id,
                Morada = x.Morada,
                NumeroIdentificacaoFiscal = x.NumeroIdentificacaoFiscal,
                Sexo = x.Sexo,
                Nome = x.Nome.ToUpper()
            });

            var existeLetraMinuscula = listaResultado.Any(x => x.Nome.Any(y => char.IsLower(y)));

            //assert
            Assert.AreEqual(4, listaResultado.Count());
            Assert.IsFalse(existeLetraMinuscula);
        }


        /// <summary>
        /// Projetar apenas Nome e Sexo do Objeto
        /// </summary>
        [TestMethod]
        public void ExemploProjecaoNomeESexoTest()
        {
            //arrange

            //act
            //NÃO USAR TERNÁRIO EM COISAS QUE NÃO SÃO TERNÁRIOS
            var lsitaResultado = lista                
                .Select(x => 
                new { 
                    NomeCliente = x.Nome, 
                    SexoCliente = (x.Sexo == Sexo.Masculino) ? 
                                            "Homem" : 
                                            (x.Sexo == Sexo.Feminino) ? "Mulher" : "Indeterminado"
                });


            //assert
            Assert.IsNotNull(lsitaResultado);
            Assert.IsTrue(lsitaResultado.FirstOrDefault().NomeCliente != "");
        }



        /// <summary>
        /// Definição do objetivo do teste
        /// </summary>
        [TestMethod]
        public void ExemploProjecaoClienteDtoTest()
        {
            //arrange

            //act
            var lsitaResultado = lista.Select(x => new ClienteDto {
                NomeEspecifico = x.Nome.ToLower(),
                MoradaEspecifico = x.Morada.Distrito + x.Morada.NumeroPorta
            });


            //assert
            Assert.IsNotNull(lsitaResultado);
            Assert.IsTrue(lsitaResultado.FirstOrDefault().NomeEspecifico != "");

        }

    }
}
