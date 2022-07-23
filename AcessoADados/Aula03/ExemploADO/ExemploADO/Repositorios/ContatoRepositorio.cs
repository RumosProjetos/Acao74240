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
            var stringConexao = ConfigurationManager.ConnectionStrings["Agenda"].ToString();
            using (var connection = new SqlConnection(stringConexao))
            {
                var comando = "DELETE FROM Contato WHERE Id = @id";
                connection.ExecuteScalar(comando, new { Id = id });
            }
        }

        public void Atualizar(Guid id, Contato dados)
        {
            var stringConexao = ConfigurationManager.ConnectionStrings["Agenda"].ToString();
            using (var connection = new SqlConnection(stringConexao))
            {
                var comando = "UPDATE CONTATO SET Tipo = @tipo, Telefone = @telefone, EnderecoEletronico = @email WHERE Id = @idContato";
                connection.ExecuteScalar(comando, new { tipo = dados.Tipo, telefone = dados.Telefone, email = dados.EnderecoEletronico, idContato = id});
            }
        }

        public void Criar(Contato dados)
        {
            var stringConexao = ConfigurationManager.ConnectionStrings["Agenda"].ToString();
            using (var connection = new SqlConnection(stringConexao))
            {
                var comando = "INSERT INTO Contato (Tipo, Telefone, PessoaId, EnderecoEletronico) VALUES (@tipo, @telefone, @pessoaId, @email)";
                connection.ExecuteScalar(comando, new { tipo = dados.Tipo, telefone = dados.Telefone, pessoaId = dados.PessoaId, email = dados.EnderecoEletronico });
            }
        }

        public Contato ObterPorId(Guid id)
        {
            var stringConexao = ConfigurationManager.ConnectionStrings["Agenda"].ToString();
            var resultado = new Contato();

            using (var connection = new SqlConnection(stringConexao))
            {
                var comando = "SELECT c.*, p.nome AS NomePessoa FROM Contato c LEFT JOIN Pessoa p ON p.Id = c.PessoaId WHERE c.Id = @id";
                try
                {
                    resultado = connection.QuerySingle<Contato>(comando, new { Id = id });
                }
                catch (Exception)
                {
                    //Apenas em modo didático
                }                
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
