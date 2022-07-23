using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploDatabaseFirst.Repositorio
{
    public class PessoaRepositorio : IRepositorio<Pessoa>
    {
        public void Apagar(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Guid id, Pessoa dados)
        {
            throw new NotImplementedException();
        }

        public void Criar(Pessoa dados)
        {
            throw new NotImplementedException();
        }

        public List<Pessoa> ObterOsPrimeiros(int quantidadeDeLinhas)
        {
            //Select top 10 * from Pessoa -- SQLSERVER
            //Select * from Pessoa WHERE ROWNO <= 10 -- ORACLE
            
            var db = new CaminhoDB();
            var pessoas = db.Pessoa.OrderBy(p => p.PosicaoAgenda).Take(quantidadeDeLinhas).ToList();
            return pessoas;
        }

        public Pessoa ObterPorId(Guid id)
        {
            var db = new CaminhoDB();
            var pessoa = db.Pessoa.FirstOrDefault(p => p.Id == id);
            return pessoa;
        }

        public List<Pessoa> ObterTodos()
        {
            var db = new CaminhoDB();
            //Select * from Pessoa
            var pessoas = db.Pessoa.ToList();
            return pessoas;
        }
    }
}
