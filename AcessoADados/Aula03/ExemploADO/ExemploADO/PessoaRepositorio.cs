using ExemploADO.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploADO
{
    public class PessoaRepositorio : IRepositorio
    {
        public void Apagar(Guid id)
        {
            var comando = "DELETE FROM Pessoa WHERE id = @id";
            throw new NotImplementedException();
        }

        public void Atualizar(Guid id, Pessoa pessoa)
        {
            var comando = "UPDATE Pessoa SET Nome = @nome, DataNascimento = @dataNascimento WHERE id = @id";
            throw new NotImplementedException();
        }

        public void Criar(Pessoa pessoa)
        {
            var comando = "INSERT INTO Pessoa (Nome, DataNascimento) VALUES (@nome, @dataNascimento)";
            throw new NotImplementedException();
        }

        public Pessoa ObterPorId(Guid id)
        {
            var comando = "SELECT * FROM Pessoa WHERE Id = @id";
            throw new NotImplementedException();
        }

        public List<Pessoa> ObterTodos()
        {
            var comando = "SELECT * FROM Pessoa";
            throw new NotImplementedException();
        }
    }
}
