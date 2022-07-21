using ExemploADO.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace ExemploADO
{
    public class PessoaRepositorio : IRepositorio<Pessoa>
    {
        public void Apagar(Guid id)
        {
            var comando = "DELETE FROM Pessoa WHERE id = @id";
            var stringConexao = ConfigurationManager.ConnectionStrings["Agenda"].ToString();

            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                var meuComando = new SqlCommand(comando, conexao);
                meuComando.Parameters.Add(new SqlParameter("id", id));
             
                var linhasAfetadas = meuComando.ExecuteNonQuery();

                if (linhasAfetadas <= 0)
                {
                    throw new Exception("Ops falhou");
                }
            }
        }

        public void Atualizar(Guid id, Pessoa pessoa)
        {
            var comando = "UPDATE Pessoa SET Nome = @nome, DataNascimento = @dataNascimento WHERE id = @id";
            var stringConexao = ConfigurationManager.ConnectionStrings["Agenda"].ToString();

            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                var meuComando = new SqlCommand(comando, conexao);
                meuComando.Parameters.Add(new SqlParameter("id", id));
                meuComando.Parameters.Add(new SqlParameter("nome", pessoa.Nome));
                meuComando.Parameters.Add(new SqlParameter("dataNascimento", pessoa.DataNascimento));

                var linhasAfetadas = meuComando.ExecuteNonQuery();

                if (linhasAfetadas <= 0)
                {
                    throw new Exception("Ops falhou");
                }
            }
        }


        /// <summary>
        /// Obter ConnectionString a partir de App.Setting
        /// </summary>
        /// <param name="pessoa"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Criar(Pessoa pessoa)
        {
            var comando = "SET IDENTITY_INSERT Pessoa ON; INSERT INTO Pessoa (Nome, DataNascimento, PosicaoAgenda) VALUES (@nome, @dataNascimento, @posicao)";
            var stringConexao = ConfigurationManager.ConnectionStrings["Agenda"].ToString();

            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                var meuComando = new SqlCommand(comando, conexao);
                meuComando.Parameters.Add(new SqlParameter("nome", pessoa.Nome));
                meuComando.Parameters.Add(new SqlParameter("dataNascimento", pessoa.DataNascimento));
                meuComando.Parameters.Add(new SqlParameter("posicao", pessoa.Posicao));

                var linhasAfetadas = meuComando.ExecuteNonQuery();

                if (linhasAfetadas <= 0)
                {
                    throw new Exception("Ops falhou");
                }
            }
        }


        /// <summary>
        /// Exemplo de uso de parametro
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Pessoa ObterPorId(Guid id)
        {
            var comando = "SELECT * FROM Pessoa WHERE Id = @id";
            var resultado = new Pessoa();
            var stringDeConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Aula03;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";

            using (var conexao = new SqlConnection(stringDeConexao))
            {
                conexao.Open();
                var meuComando = new SqlCommand(comando, conexao);
                meuComando.Parameters.Add(new SqlParameter("id", id));
                var dados = meuComando.ExecuteReader();

                while (dados.Read())
                {
                    var pessoa = new Pessoa
                    {
                        Id = new Guid(dados["Id"].ToString()),
                        Nome = dados["Nome"].ToString(),
                        Posicao = Convert.ToInt32(dados["PosicaoAgenda"])
                    };

                    resultado = pessoa;
                }
            }


            return resultado;
        }




        /// <summary>
        /// Cuidado, pior forma possível de obter dados
        /// </summary>
        /// <returns></returns>
        public List<Pessoa> ObterTodos()
        {
            var comando = "SELECT Id, Nome, DataNascimento, PosicaoAgenda FROM Pessoa";
            var resultado = new List<Pessoa>();

            //Realiza a conexão com o SQLServer
            var conexao = new SqlConnection();
            var stringDeConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Aula03;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";
            conexao.ConnectionString = stringDeConexao;
            conexao.Open();

            //Passa um comando para o Servidor
            var meuComando = new SqlCommand();
            meuComando.Connection = conexao;
            meuComando.CommandText = comando;

            //Para trazer várias informações execute Reader   
            var leituraDados = meuComando.ExecuteReader();

            while (leituraDados.Read())
            {
                var pessoa = new Pessoa();
                pessoa.Id = new Guid(leituraDados["Id"].ToString());
                pessoa.Nome = leituraDados["Nome"].ToString();
                pessoa.Posicao = Convert.ToInt32(leituraDados["PosicaoAgenda"]);

                resultado.Add(pessoa);
            }

            conexao.Close();

            return resultado;
        }
    }
}
