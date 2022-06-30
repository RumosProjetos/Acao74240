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
    public class LinqTests
    {
        public List<Cliente> lista;

        [TestInitialize]
        public void PrepararOsTestes()
        {
            lista = new List<Cliente>();
            lista.Add(new Cliente("Joao") { Sexo = Sexo.Masculino, Morada = new Morada { Distrito = "Lisboa" } });
            lista.Add(new Cliente("Maria") { Sexo = Sexo.Feminino, Morada = new Morada { Distrito = "Porto" } });
            lista.Add(new Cliente("José") { Sexo = Sexo.Masculino, Morada = new Morada { Distrito = "Porto" } });
            lista.Add(new Cliente("Sasha") { Sexo = Sexo.Indeterminado, Morada = new Morada { Distrito = "Porto" } });
            ///File.WriteAllText(@"c:\temp\log.txt", "Oi mundo");
        }


    }
}
