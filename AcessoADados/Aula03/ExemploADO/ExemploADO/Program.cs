﻿using ExemploADO.Modelo;
using ExemploADO.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExemploRepositorioContatos();
            ExemploRepositorioPessoas();

            Console.ReadLine();
        }

        private static void ExemploRepositorioContatos()
        {
            var repo = new ContatoRepositorio();
            var contatoSelecionado = repo.ObterPorId(new Guid("D568CEDF-0EFB-47D7-89F0-BB46B164C921"));

            repo.Apagar(new Guid("BA90405C-7829-4EB9-898E-EA9891A5EA36"));

            
            var contatoNovo = new Contato {
                PessoaId = new Guid("EC4DDD9F-25D8-4B40-AF95-018406A5DE75"), //ScoobyDoo.Id (Chave primária)
                Telefone = "11111111",
                EnderecoEletronico = "pessoa@email.com",
                Tipo = "Telefone"
            };
            repo.Criar(contatoNovo);

            var idContatoScoobyDoo = new Guid("25751ECD-B447-4FBD-BF59-A820A8D03C98");
            var dadosNovosDeContato = new Contato
            {
                Telefone = "22222222",
                EnderecoEletronico = "scoobydoo@email.com",
                Tipo = "Telefone"
            };

            repo.Atualizar(idContatoScoobyDoo, dadosNovosDeContato);

            var contatos = repo.ObterTodos();

            Console.WriteLine(contatoSelecionado.Telefone);
        }

        private static void ExemploRepositorioPessoas()
        {
            var repo = new PessoaRepositorio();

            var pessoas = repo.ObterTodos();
            foreach (var p in pessoas)
            {
                Console.WriteLine($"A pessoa se chama: {p.Nome}");
            }


            var idPessoaEscolhida = new Guid("FB33F9C3-3EDA-48B1-AE12-EB1CB7FFB7EE");
            var pessoaEscolhida = repo.ObterPorId(idPessoaEscolhida);
            Console.WriteLine($"A Pessoa Escolhida foi o {pessoaEscolhida.Nome}");


            for (int i = 0; i < 10; i++)
            {
                var pessoaNova = new Pessoa { Nome = "Joaquim", Posicao = i, DataNascimento = new DateTime(2022, 07, 12) };
                repo.Criar(pessoaNova);
            }


            if (pessoaEscolhida != null && pessoaEscolhida.Id != null)
            {
                repo.Apagar(idPessoaEscolhida);
            }



            var idPessoaAatualizaar = new Guid("EC4DDD9F-25D8-4B40-AF95-018406A5DE75");
            repo.Atualizar(idPessoaAatualizaar, new Pessoa { Nome = "ScoobyDoo", DataNascimento = new DateTime(1960, 01, 01) });
        }
    }
}
