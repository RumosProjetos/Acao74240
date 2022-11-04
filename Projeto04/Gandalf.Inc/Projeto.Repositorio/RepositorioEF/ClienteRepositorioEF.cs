using Projeto.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Repositorio.RepositorioEF
{
    public class ClienteRepositorioEF : IRepositorio<Cliente>
    {
        private readonly GandalfContext db;
        public ClienteRepositorioEF(string conectionString)
        {
            db = new GandalfContext(conectionString);
        }

        public void Apagar(Guid Id)
        {
            var cliente = db.Clientes.FirstOrDefault(x => x.Id == Id);
            if(cliente != null)
            {
                db.Clientes.Remove(cliente);
            }                
        }

        public void Atualizar(Cliente TEntidade)
        {
            var cliente = db.Clientes.FirstOrDefault(x => x.Id == TEntidade.Id);
            cliente = TEntidade;
        }

    
        public void InserirNovo(Cliente TEntidade)
        {
            if(TEntidade != null)
            {
                db.Clientes.Add(TEntidade);
            }            
        }

        public Cliente? ObterPorId(Guid Id)
        {
            var cliente = db.Clientes.FirstOrDefault(x => x.Id == Id);
            return cliente;
        }

        public IList<Cliente>? ObterTodos()
        {
            return db.Clientes.ToList();
        }


        public void Salvar(string path)
        {
            db.SaveChanges();
        }
    }
}
