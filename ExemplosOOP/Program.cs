//---Propriedades de forma explícita
var joao = new PessoaSingular();
joao.Nome = "João da Silva";
joao.DataNascimento = new DateTime(2000,02,25);
var idade = joao.ObterIdade();
Console.WriteLine(joao.ToString());









//-----Escrita declarativa
var maria = new PessoaSingular {
    Nome = "Maria da Silva",
    DataNascimento = new DateTime(2001,10,10)
};
maria.Nome = "Maria da Silva Xavier";
var idadeMaria = maria.ObterIdade();
Console.WriteLine("A Maria tem: " + idadeMaria);


//---Exemplo com construtor novo
var pedro = new PessoaSingular("Pedro da Silva");
Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.ObterIdade()); //0001/01/01


//---Exemplo construtor com DateTime
var nadia = new PessoaSingular("Nadia da Silva", new DateTime(2021,05,05));
var idadeNadia = nadia.ObterIdade();
Console.WriteLine("A Nadia tem: " + idadeNadia);

var marta = new PessoaSingular(new DateTime(2021,05,05));
var idadeMarta = nadia.ObterIdade();
Console.WriteLine("A Marta tem: " + idadeMarta);
marta.Nome = null;
Console.WriteLine(marta.Nome);