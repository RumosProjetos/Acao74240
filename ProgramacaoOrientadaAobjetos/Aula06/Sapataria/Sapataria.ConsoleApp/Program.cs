using Sapataria.ConsoleApp;
using Sapataria.ConsoleApp.Infraestrutura;

Console.WriteLine("Sapataria do Marcelo");
Console.WriteLine($"Digite : \"{Constantes.clientes}\" para Cadastro de Clientes ");
Console.WriteLine($"Digite : \"{Constantes.produtos}\" para Cadastro de Produtos ");
Console.WriteLine($"Digite : \"{Constantes.vendas}\" para Vendas ");
Console.WriteLine($"Digite : \"{Constantes.listagem}\" para Relatórios");
Console.WriteLine($"Digite : \"{Constantes.sair}\" para Sair");


var modulo = Console.ReadLine().ToLower();

while (modulo != null && modulo != Constantes.sair)
{
    switch (modulo)
    {
        case Constantes.clientes:
            var obj = new ClienteApp();
            break;
        case Constantes.produtos:
            var obj2 = new ProdutoApp();
            break;
        case Constantes.vendas:
            break;
        case Constantes.listagem:
            break;
        case Constantes.sair:
            break;
        default:
            break;
    }

    modulo = Console.ReadLine();
}

