﻿


// New instance of CosmosClient class
var conexao = @"mongodb://cosmos-rumos-mongodb-ukw:zFR46etO3s51YgW2iumkgYBmU1BorNkQyXCkVrKpeU612QNhHTyVvWnBhtEHHnpF8Jke24DuX0qgKft2Vq73yA==@cosmos-rumos-mongodb-ukw.mongo.cosmos.azure.com:10255/?ssl=true&replicaSet=globaldb&retrywrites=false&maxIdleTimeMS=120000&appName=@cosmos-rumos-mongodb-ukw@";
var client = new MongoClient(conexao);

// Database reference with creation if it does not already exist
var db = client.GetDatabase("sapataria");


// Container reference with creation if it does not alredy exist
var _products = db.GetCollection<Produto>("produtos_novo");


var sapato = new Produto{
    Id = Guid.NewGuid().ToString(),
    Nome = "Nike",
    QuantidadeEstoque = 100,
    Categoria = new Categoria {
        Id = Guid.NewGuid().ToString(),
        Nome = "Tênis"
    }
};


_products.InsertOne(sapato);




 var sapatosAdidas = _products.Find(x => x.Categoria.Nome == "Tênis" && x.Nome == "Adidas");

 foreach (var item in sapatosAdidas.ToList())
 {
    System.Console.WriteLine(item.Nome);   
 }



var products = _products.AsQueryable().Where(p => p.Categoria.Nome == "Tênis");
Console.WriteLine("Multiple products:");
foreach (var prod in products)
{
    Console.WriteLine(prod.Nome);
}


Console.WriteLine("Terminou");