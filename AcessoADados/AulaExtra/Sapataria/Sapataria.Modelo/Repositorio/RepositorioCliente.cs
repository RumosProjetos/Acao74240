using Sapataria.Modelo.Estrutura.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Text.Json;

namespace Sapataria.Modelo.Repositorio
{
    public class RepositorioCliente : IRepositorio<Cliente>
    {
        const string connexao = @"mongodb://cosmos-rumos-mongodb-ukw:zFR46etO3s51YgW2iumkgYBmU1BorNkQyXCkVrKpeU612QNhHTyVvWnBhtEHHnpF8Jke24DuX0qgKft2Vq73yA==@cosmos-rumos-mongodb-ukw.mongo.cosmos.azure.com:10255/?ssl=true&replicaSet=globaldb&retrywrites=false&maxIdleTimeMS=120000&appName=@cosmos-rumos-mongodb-ukw@";
        private readonly MongoClient client;
        private readonly IMongoCollection<Cliente> _clientes;

        public RepositorioCliente()
        {
            client = new MongoClient(connexao);
            var db = client.GetDatabase("sapataria_do_marcelo");
            _clientes = db.GetCollection<Cliente>("clientes");
        }

        public void Adicionar(Cliente item)
        {
            _clientes.InsertOne(item);
        }

        public void Apagar(string id)
        {
            var filter = Builders<Cliente>.Filter.Eq("id", id);
            _clientes.DeleteOne(filter);
        }

        public void Atualizar(string id, Cliente item)
        {
            var filter = Builders<Cliente>.Filter.Eq("id", id);
            var update = Builders<Cliente>.Update.Set("morada", item.Morada);

            _clientes.UpdateOne(filter, update);
        }

        public List<Cliente> Listar()
        {
            var clientes = _clientes.AsQueryable().ToList();
            return clientes;
        }

        public Cliente ObterPorId(string id)
        {
            var cliente = _clientes.AsQueryable().Where(p => p.Id == id).FirstOrDefault();
            return cliente;
        }
    }
}
