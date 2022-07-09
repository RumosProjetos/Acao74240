using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sapataria.PadroesDeProjeto.Creational.Singleton.Exemplo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapataria.Tests.PadroesProjeto
{
    [TestClass]
    public class ExemploSingleton
    {
        [TestMethod]
        public void DeveTrazerOMesmoValorDosDadosEmDuasPseudoInstanciasDoSingletonTest()
        {
            //arrange
            var validador = Validador.ValidadorOnLine;
            validador.NomeDocumento = "Exemplo 1";
            var validadorOutraInstancia = Validador.ValidadorOnLine;

            //act
            var dados = validadorOutraInstancia.NomeDocumento;

            //assert		
            Assert.AreEqual(validador.NomeDocumento, validadorOutraInstancia.NomeDocumento);    
        }



        [TestMethod]
        public void DeveTrazerOMesmoValorDosDadosEmDuasConectionStringsDiferentesSingletonTest()
        {
            //arrange
            var stringConexao = ConexaoComDatabase.MinhaConexaoExposta;
            stringConexao.NomeServidor = "10.20.10.21";
            stringConexao.NomeBaseDados = "SapatariaDB";
            stringConexao.Usuario = "meuUsuario";
            stringConexao.Senha = "!#!#";

            //act
            var segundaConexaoComOsMesmosDados = ConexaoComDatabase.MinhaConexaoExposta;

            //assert		
            Assert.AreEqual(stringConexao, segundaConexaoComOsMesmosDados); //Para esse exemplo, poderia ficar só com esse, pois são de fato o mesmo objeto (singleton)

            //Outros casos adicionais e opcionais de testes para esse caso
            Assert.AreEqual(stringConexao.NomeServidor, segundaConexaoComOsMesmosDados.NomeServidor);
            Assert.AreEqual(stringConexao.NomeBaseDados, segundaConexaoComOsMesmosDados.NomeBaseDados);
            Assert.AreEqual(stringConexao.Usuario, segundaConexaoComOsMesmosDados.Usuario);
            Assert.AreEqual(stringConexao.Senha, segundaConexaoComOsMesmosDados.Senha);            
        }

    }
}
