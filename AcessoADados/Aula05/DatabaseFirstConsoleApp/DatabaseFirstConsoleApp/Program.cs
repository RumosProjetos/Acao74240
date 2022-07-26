using DatabaseFirstConsoleApp.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var repo = new PessoaRepositorio();
            var pessoasDoBanco = repo.ObterTodos();
            var pessoasOrdenadas = repo.ObterTodosEmOrdemAlfabetica();
            foreach (var p in pessoasOrdenadas)
            {
                Console.WriteLine($"A Pessoa se chama: {p.Nome}");
            }

            var pessoaTeste = repo.ObterPorId(new Guid("85b5bf28-6685-4e7e-a627-8a7509d34e54"));
            Console.WriteLine($"A Pessoa Escolhida se chama: {pessoaTeste.Nome}");

          


            Console.ReadLine();
        }
    }
}
