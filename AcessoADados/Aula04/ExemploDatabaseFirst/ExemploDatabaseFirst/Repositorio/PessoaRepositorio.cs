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
            var db = new CaminhoDB();
            var pessoa = db.Pessoa.FirstOrDefault(x => x.Id == id);
            if (pessoa != null)
            {
                //Normalmente não é necessário, mas temos um bug no nosso modelo.
                db.Endereco.RemoveRange(pessoa.Endereco);
                db.Contato.RemoveRange(pessoa.Contato);

                db.Pessoa.Remove(pessoa);
                db.SaveChanges();
            }
        }

        public void Atualizar(Guid id, Pessoa dados)
        {
            var db = new CaminhoDB();
            var pessoa = db.Pessoa.FirstOrDefault(x => x.Id == id);
            pessoa.Nome = dados.Nome;
            pessoa.DataNascimento = dados.DataNascimento;
            db.SaveChanges();
        }

        public void Criar(Pessoa dados)
        {
            var db = new CaminhoDB();
            db.Pessoa.Add(dados);
            //Commit 
            db.SaveChanges();

            //Em caso de Rollback
            //db.Dispose();
        }

        public List<Pessoa> ObterAsPessoasComIdadeMaiorDoQue(int idade)
        {
            var db = new CaminhoDB();
            //Exemplo LINQ tradicional
            var pessoas = from p in db.Pessoa
                          where p.Idade >= idade
                          select p;
            //Seria o mesmo que:
            //var pessoas = db.pessoa.where(p => p.Idade >= idade);

            return pessoas.ToList();
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

        public Pessoa ObterPorNome(string nome)
        {
            var db = new CaminhoDB();
            var pessoa = db.Pessoa.FirstOrDefault(p => p.Nome == nome);
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
