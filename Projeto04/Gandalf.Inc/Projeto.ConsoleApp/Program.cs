using Microsoft.Extensions.Configuration;
using Projeto.Data;
using Projeto.Modelo;
using Projeto.Repositorio;
using Projeto.Repositorio.Repositorio;
using Projeto.Repositorio.RepositorioEF;

var builder = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json", optional: false);

IConfiguration config = builder.Build();
var conexao = config.GetConnectionString("GandalfConnection");

var db = new GandalfContext(conexao);


//var loja = new Loja {   
//    Id = Guid.NewGuid(),
//    Nome = "Faro 01",
//    Endereco = "Rua da Liberdade, 356, Faro"
//};

//db.Lojas.Add(loja);
//db.SaveChanges();


var clienteNovo = new Cliente {
    Id = Guid.NewGuid(),
    Nome = "Marcelo",
    NumeroIdentificacaoFiscal = "123456789"
};


var usuarioNovo = new Utilizador
{
    Id = Guid.NewGuid(),
    Nome = "Marcelo",
    NumeroIdentificacaoFiscal = "123456789",
    Telefone = "123456789"
};



IRepositorio<Cliente> repo = new ClienteRepositorioEF(conexao);
repo.InserirNovo(clienteNovo);
repo.Salvar("");



db.Utilizadores.Add(usuarioNovo);
db.SaveChanges();








var contagem = db.Pessoas.ToList().Count();

Console.WriteLine(conexao);
