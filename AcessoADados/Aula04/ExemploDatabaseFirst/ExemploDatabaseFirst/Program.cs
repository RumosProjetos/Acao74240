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

            //var scooby = repo.ObterPorId(new Guid("25751ECD-B447-4FBD-BF59-A820A8D03C98"));
            //Console.WriteLine(scooby.Nome);

            var barney = new Pessoa { Nome = "Barney", DataNascimento = new DateTime(1960, 01, 01), Id = Guid.NewGuid() };
            repo.Criar(barney);

            //var enderecoFred = new List<Endereco> { new Endereco { Distrito = "Bedrock", CodigoPostal = "2000", CodigoPostalComplemento = "100", Rua = "Exemplo", Id = Guid.NewGuid() } };
            //var fred = new Pessoa { Nome = "Fred", DataNascimento = new DateTime(1960, 01, 01), Id = Guid.NewGuid(), Endereco = enderecoFred };
            //repo.Criar(fred);


            //var enderecoVilma = new List<Endereco> { new Endereco { Distrito = "Bedrock", CodigoPostal = "2000", CodigoPostalComplemento = "100", Rua = "Exemplo", Id = Guid.NewGuid() } };
            //var contatoVilma = new List<Contato> {
            //    new Contato { Telefone = "7777777", Tipo = "Telefone", EnderecoEletronico = "vilma@sapo.pt", Id = Guid.NewGuid() },
            //    new Contato { Telefone = "6666666", Tipo = "Telefone", EnderecoEletronico = "vilma@rumos.pt", Id = Guid.NewGuid() },
            //    new Contato { Telefone = "8888888", Tipo = "Telefone", EnderecoEletronico = "vilma@edp.pt", Id = Guid.NewGuid() },
            //};

            //var vilma = new Pessoa { Nome = "Vilma", DataNascimento = new DateTime(1960, 01, 01), Id = Guid.NewGuid(), Endereco = enderecoVilma, Contato = contatoVilma};
            //repo.Criar(vilma);


            //var enderecoVilma = new List<Endereco> { new Endereco { Distrito = "Bedrock", CodigoPostal = "2000", CodigoPostalComplemento = "100", Rua = "Exemplo", Id = Guid.NewGuid() } };
            //var contatoVilma = new List<Contato> {
            //    new Contato { Telefone = "1111111", Tipo = "Telefone", EnderecoEletronico = "vilma@sapo.pt", Id = Guid.NewGuid() },
            //    new Contato { Telefone = "2222222", Tipo = "Telefone", EnderecoEletronico = "vilma@rumos.pt", Id = Guid.NewGuid() },
            //    new Contato { Telefone = "3333333", Tipo = "Telefone", EnderecoEletronico = "vilma@edp.pt", Id = Guid.NewGuid() },
            //};

            //var vilma = new Pessoa { Nome = "Beth", DataNascimento = new DateTime(1960, 01, 01), Id = Guid.NewGuid(), Endereco = enderecoVilma, Contato = contatoVilma };
            //repo.Criar(vilma);


            //var idVilma = new Guid("E080AE37-D5FB-4DEE-B23C-E235D4368505");
            //repo.Apagar(idVilma);


            //var idFred = repo.ObterPorNome("Fred").Id;
            //repo.Atualizar(idFred, new Pessoa { DataNascimento = new DateTime(1960, 9, 30), Nome = "Fred Flintstone" });
        }
    }
}
