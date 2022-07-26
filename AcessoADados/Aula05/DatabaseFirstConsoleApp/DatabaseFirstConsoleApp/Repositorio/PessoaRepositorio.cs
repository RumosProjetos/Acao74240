using DatabaseFirstConsoleApp.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstConsoleApp.Repositorio
{
    public class PessoaRepositorio : IRepositorio<Pessoa>
    {
        private readonly MinhaConexao db;

        public PessoaRepositorio()
        {
            db = new MinhaConexao();
        }

        public List<Pessoa> ObterTodos()
        {
            var resultado = db.Pessoa.ToList();
            return resultado;
        }

        public List<Pessoa> ObterTodosEmOrdemAlfabetica()
        {
            //var resultadoOrdenadoEmMemoria = db.Pessoa.ToList().OrderBy(p => p.Nome);  //ordenacao acontece em memória - Select * from tabela - Pode ser mais rápido
            var resultadoOrdenadoNoDatabase = db.Pessoa.OrderBy(p => p.Nome).ToList(); //ordenacao acontece no sqlserver - Select * from tabela order by campo

            return resultadoOrdenadoNoDatabase;
        }



        public Pessoa ObterPorId(Guid id)
        {
            //85b5bf28-6685-4e7e-a627-8a7509d34e54
            var resultado = db.Pessoa.FirstOrDefault(p => p.Id == id);
            return resultado;
        }


        public Pessoa ObterPorNomeUsandoLambda(string nome)
        {
            var resultado = db.Pessoa.FirstOrDefault(p => p.Nome == nome);
            return resultado;
        }

        public Pessoa ObterPorNomeUsandoLinqAntigo(string nome)
        {
            var resultado = from p in db.Pessoa 
                            where p.Nome == nome 
                            select p;

            return resultado.FirstOrDefault();
        }

        public Pessoa ObterPorNomePorPosicaoAgenda(string nome)
        {
            var resultado = db.Pessoa.OrderBy(p => p.PosicaoAgenda).FirstOrDefault(p => p.Nome == nome);
            return resultado;
        }

        public List<Pessoa> ObterTodosMaioresDe(int idade)
        {
            var anoNascimentoCalculado = DateTime.Now.AddYears(-idade).Year; //Calcular o ano de nascimento
            var resultado = db.Pessoa.Where(p => p.DataNascimento.Value.Year >= anoNascimentoCalculado).ToList();
            return resultado;
        }

        public void CriarNovo(Pessoa entidade)
        {
            db.Pessoa.Add(entidade);
            db.SaveChanges();
        }

        public void Apagar(Guid id)
        {
            var pessoaAapagar = db.Pessoa.FirstOrDefault(p => p.Id == id);
            
            if(pessoaAapagar != null && pessoaAapagar.Id != Guid.Empty)
            {
                db.Pessoa.Remove(pessoaAapagar);
                db.SaveChanges();
            }            
        }

        public void AtualizarNome(Guid id, string nome)
        {
            var pessoaAatualizar = db.Pessoa.FirstOrDefault(p => p.Id == id);
            if (pessoaAatualizar != null && pessoaAatualizar.Id != Guid.Empty)
            {
                pessoaAatualizar.Nome = nome;
                db.SaveChanges();
            }
        }
    }
}
