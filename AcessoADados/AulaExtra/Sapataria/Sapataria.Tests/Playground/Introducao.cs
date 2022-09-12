using Sapataria.Infraestrutura.Impressao;
using Sapataria.Modelo.Estrutura.Pessoas;
using Sapataria.Modelo.Estrutura.Produtos;
using Sapataria.Modelo.Repositorio;

namespace Sapataria.Tests.Playground
{
    internal class Introducao
    {


        public void Exemplo02()
        {

            Console.WriteLine("OI " + "Mundo");
            Console.WriteLine(1 + 1); //2
            Console.WriteLine(1.1 + 1.1); //2.2
            Console.WriteLine(1 + "1"); //11
            Console.WriteLine(1.1 + 1000); //1001.1


            var joao = new Cliente("Joao");
            var maria = new Cliente("Maria");

            Console.WriteLine(joao + maria);
        }

        public void Exemplo03()
        {

            var conceicao = new Funcionario();
            conceicao.Nome = "Conceicao";
            conceicao.DataNascimento = new DateTime(2000, 01, 01);
            Console.WriteLine(conceicao.ObterIdade());

            Console.WriteLine(conceicao.ImprimirDados());
            Console.WriteLine(conceicao.ImprimirTodosOsDados());



            var impressora = new ImpressoraNovoFornecedor();
            impressora.Imprimir(conceicao.ToString());
        }


        public void Exemplo04()
        {
            var sapatoAdidas = new Sapato();
            sapatoAdidas.Exemplo();
            sapatoAdidas.ExemploSobrescrita();
            //sapatoAdidas.InformacaoInterna = ""; -- Propriedade Private
            //sapatoAdidas.PropriedadeProtegida = "asdasd";

            var conserto = new Reparo();
            conserto.Exemplo();
            conserto.ExemploSobrescrita();
        }


    }

}




