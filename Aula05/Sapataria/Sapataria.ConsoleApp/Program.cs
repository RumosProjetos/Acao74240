﻿// See https://aka.ms/new-console-template for more information
using Sapataria.Modelo.Estrutura.Pessoas;
using Sapataria.Modelo.Estrutura.Produtos;
using Sapataria.Modelo.Infraestrutura;
using Sapataria.Modelo.Repositorio;




var repo = new RepositorioCliente();
var cli1 = new Cliente("Maria");
cli1.NumeroIdentificacaoFiscal = "123456789";
repo.Adicionar(cli1);

var cli2 = new Cliente("Joao");
cli2.NumeroIdentificacaoFiscal = "987654321";
repo.Adicionar(cli2);
var clienteLocalizado = repo.ObterPorNome("Joao");

Console.WriteLine(clienteLocalizado.Nome.ToUpper());




Console.WriteLine("OI " + "Mundo");
Console.WriteLine(1 + 1); //2
Console.WriteLine(1.1 + 1.1); //2.2
Console.WriteLine(1 + "1"); //11
Console.WriteLine(1.1 + 1000); //1001.1


var joao = new Cliente("Joao");
var maria = new Cliente("Maria");

Console.WriteLine(joao + maria);


var conceicao = new Funcionario();
conceicao.Nome = "Conceicao";
conceicao.DataNascimento = new DateTime(2000, 01, 01);
Console.WriteLine(conceicao.ObterIdade());

Console.WriteLine(conceicao.ImprimirDados());
Console.WriteLine(conceicao.ImprimirTodosOsDados());



var impressora = new ImpressoraNovoFornecedor();
impressora.Imprimir(conceicao.ToString());




var sapatoAdidas = new Sapato();
sapatoAdidas.Exemplo();
sapatoAdidas.ExemploSobrescrita();
//sapatoAdidas.InformacaoInterna = ""; -- Propriedade Private
//sapatoAdidas.PropriedadeProtegida = "asdasd";

var conserto = new Reparo();
conserto.Exemplo();
conserto.ExemploSobrescrita();




for (int i = 0; i < 10000; i++)
{
    Console.WriteLine(clienteLocalizado.Nome.ToUpper());
    Thread.Sleep(5000);

}

Console.ReadLine();