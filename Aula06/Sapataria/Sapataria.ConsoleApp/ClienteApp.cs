using Sapataria.ConsoleApp.Infraestrutura;
using Sapataria.LogicaNegocio;
using Sapataria.Modelo.Estrutura.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapataria.ConsoleApp
{
    public class ClienteApp
    {
        public ClienteApp()
        {
            Console.WriteLine($"1 - {Constantes.separador}");
            var mensagem = (DateTime.Now.Hour >= 12) ? "Boa Tarde" : "Bom Dia";
            var mensagemBoasVindas = $"{mensagem} - {Constantes.cadastroClientes}";
            Console.WriteLine(mensagemBoasVindas);

            ExibirMenuClientes();

            var operacao = Console.ReadLine();

            while (operacao != null && operacao != Constantes.sair)
            {
                switch (operacao)
                {
                    case Constantes.novo:
                        AdicionarCliente();
                        break;
                    case Constantes.busca:
                        var obj2 = new ProdutoApp();
                        break;
                    case Constantes.listagem:
                        break;
                    case Constantes.edicao:
                        break;
                    case Constantes.remocao:
                        break;
                    case Constantes.sair:
                        break;
                    default:
                        break;
                }

                ExibirMenuClientes();
                if (Console.ReadLine() == Constantes.sair)
                    break;
            }

        }

        private void ExibirMenuClientes()
        {
            Console.WriteLine($"{Constantes.separador}");
            Console.WriteLine($"{Constantes.cadastroClientes}");
            Console.WriteLine($"Digite : \"{Constantes.novo}\" para Adicionar Cliente ");
            Console.WriteLine($"Digite : \"{Constantes.busca}\" para Buscar Cliente ");
            Console.WriteLine($"Digite : \"{Constantes.listagem}\" para Relatório de Clientes");
            Console.WriteLine($"Digite : \"{Constantes.edicao}\" para Alterar Cliente");
            Console.WriteLine($"Digite : \"{Constantes.remocao}\" para Remover Cliente");
            Console.WriteLine($"Digite : \"{Constantes.sair}\" para Voltar ao Menu anterior");
            Console.WriteLine($"{Constantes.separador}");
        }



        //CRUD
        public void AdicionarCliente()
        {
            Console.WriteLine(Constantes.separadorInterno);
            var cliente = new Cliente();

            Console.WriteLine("Nome: ");
            cliente.Nome = Console.ReadLine();

            Console.WriteLine("NIF: ");
            cliente.NumeroIdentificacaoFiscal = Console.ReadLine();

            //yyyy,mm,dd
            Console.WriteLine("Data Nascimento (AAAA,MM,DD): ");
            try
            {
                cliente.DataNascimento = DateTime.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                cliente.DataNascimento = new DateTime(); //bug mínimo apenas para didática
            }
            


            var logicaCliente = new LogicaCliente();
            if (logicaCliente.EstaValido(cliente))
            {
                logicaCliente.AdicionarCliente(cliente);
                Console.WriteLine(Constantes.adicionadoSucesso);
            }
            else
            {
                Console.WriteLine(Constantes.dadosInvalidos);
            }
        }

        public void RecuperarCliente()
        {
            Console.WriteLine("Recuperacao de Clientes");
        }

        public void ListarClientes()
        {
            Console.WriteLine("Listagem de Clientes");
        }

        public void EditarCliente()
        {
            Console.WriteLine("Edição de Clientes");
        }
        public void ApagarCliente()
        {
            Console.WriteLine("Remoção de Clientes");
        }
    }

}
