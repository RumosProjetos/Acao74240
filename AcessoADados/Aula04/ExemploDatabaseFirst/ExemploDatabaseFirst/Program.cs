using ExemploDatabaseFirst.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploDatabaseFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var repo = new PessoaRepositorio();
            //var pessoas = repo.ObterTodos();
            //var pessoas = repo.ObterOsPrimeiros(15);


            //foreach (var p in pessoas)
            //{
            //    Console.WriteLine(p.Nome);
            //}

            var scooby = repo.ObterPorId(new Guid("25751ECD-B447-4FBD-BF59-A820A8D03C98"));
            Console.WriteLine(scooby.Nome);
        }
    }
}
