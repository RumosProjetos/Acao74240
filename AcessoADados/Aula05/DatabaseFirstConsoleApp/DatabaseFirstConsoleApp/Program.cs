using DatabaseFirstConsoleApp.Modelo;
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


            var pessoa = new Pessoa { Id = Guid.NewGuid(), Nome = "Dona Maria", DataNascimento = new DateTime(1965, 01, 01) };
            repo.CriarNovo(pessoa);

            repo.AtualizarNome(new Guid("6295AFF3-E222-44CE-84C9-4FD0693CDA1C"), "João Maria");

            repo.Apagar(new Guid("6295AFF3-E222-44CE-84C9-4FD0693CDA1C"));

            Console.ReadLine();
        }
    }
}
