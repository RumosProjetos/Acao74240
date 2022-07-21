using Dapper;
using ExemploADO.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploADO.Repositorios
{
    public class ContatoRepositorio : IRepositorio<Contato>
    {
        public void Apagar(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Guid id, Contato dados)
        {
            throw new NotImplementedException();
        }

        public void Criar(Contato dados)
        {
            throw new NotImplementedException();
        }

        public Contato ObterPorId(Guid id)
        {
            var stringConexao = ConfigurationManager.ConnectionStrings["Agenda"].ToString();
            var resultado = new Contato();

            using (var connection = new SqlConnection(stringConexao))
            {
                var comando = "SELECT c.*, p.nome AS NomePessoa FROM Contato c LEFT JOIN Pessoa p ON p.Id = c.PessoaId WHERE c.Id = @id";
                resultado = connection.QuerySingle<Contato>(comando, new { Id = id });
            }

            return resultado;
        }

        public List<Contato> ObterTodos()
        {
            var stringConexao = ConfigurationManager.ConnectionStrings["Agenda"].ToString();
            var resultado = new List<Contato>();

            using (var connection = new SqlConnection(stringConexao))
            {
                var comando = "SELECT c.*, p.nome AS NomePessoa FROM Contato c LEFT JOIN Pessoa p ON p.Id = c.PessoaId";
                resultado = connection.Query<Contato>(comando).ToList();
            }

            return resultado;
        }
    }
}
