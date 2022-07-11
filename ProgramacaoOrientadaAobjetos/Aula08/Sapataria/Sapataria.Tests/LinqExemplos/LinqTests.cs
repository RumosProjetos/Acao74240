using Sapataria.Modelo.Estrutura.Pessoas;

namespace Sapataria.Tests.LinqExemplos
{
    [TestClass]
    public class LinqTests
    {
        public List<Cliente> clientes;
        public List<Funcionario> funcionarios;

        [TestInitialize]
        public void PrepararOsTestes()
        {
            clientes = new List<Cliente>
            {
                new Cliente("Sasha") { Sexo = Sexo.Indeterminado, Morada = new Morada { Distrito = "Porto" } },
                new Cliente("Joao") { Sexo = Sexo.Masculino, Morada = new Morada { Distrito = "Lisboa" } },
                new Cliente("Maria") { Sexo = Sexo.Feminino, DataNascimento = new DateTime(2022, 06, 29), Morada = new Morada { Distrito = "Porto (mais nova)" } },
                new Cliente("Maria") { Sexo = Sexo.Feminino, DataNascimento = new DateTime(2000, 01, 01), Morada = new Morada { Distrito = "Leiria (mais velha)" } },
                new Cliente("José") { Sexo = Sexo.Masculino, Morada = new Morada { Distrito = "Porto" } },
                new Cliente("José") { Sexo = Sexo.Masculino, Morada = new Morada { Distrito = "Porto" } },
                new Cliente("José") { Sexo = Sexo.Masculino, Morada = new Morada { Distrito = "Porto" } }
            };
            ///File.WriteAllText(@"c:\temp\log.txt", "Oi mundo");
            ///

            funcionarios = new List<Funcionario>
            {
                new Funcionario { Nome = "Cida" },
                new Funcionario { Nome = "Pedrão" },
                new Funcionario { Nome = "Sasha" , Salario = 1000}
            };
        }


    }
}
