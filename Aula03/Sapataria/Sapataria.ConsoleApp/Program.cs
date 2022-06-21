// See https://aka.ms/new-console-template for more information
using Sapataria.Modelo;



Console.WriteLine("OI " + "Mundo");
Console.WriteLine(1 + 1); //2
Console.WriteLine(1.1 + 1.1); //2.2
Console.WriteLine(1 + "1"); //11
Console.WriteLine(1.1 + 1000); //1001.1


var joao = new Cliente("Joao");
var maria = new Cliente("Maria");

Console.WriteLine(joao + maria);


var conceicao = new Funcionario();
Console.WriteLine(conceicao.ObterIdade());

