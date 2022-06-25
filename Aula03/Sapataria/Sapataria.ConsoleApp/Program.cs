﻿// See https://aka.ms/new-console-template for more information
using Sapataria.Modelo.Estrutura.Pessoas;




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

