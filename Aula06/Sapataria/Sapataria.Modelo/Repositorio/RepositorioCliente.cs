using Sapataria.Modelo.Estrutura.Pessoas;
using Sapataria.Modelo.Infraestrutura;

namespace Sapataria.Modelo.Repositorio
{
    public class RepositorioCliente : IRepositorio<Cliente>
    {
        private List<Cliente> clientes { get; set; }
        public RepositorioCliente()
        {
            clientes = new List<Cliente>();
        }


        public void Adicionar(Cliente item)
        {
            clientes.Add(item);
        }

        public void Apagar(Cliente item)
        {
            clientes.Remove(item);
        }

        public void Atualizar(Cliente item)
        {
            throw new NotImplementedException();
        }

        public Cliente Obter(Cliente item)
        {
            foreach (var cliente in clientes)
            {
                if(cliente.Equals(item))
                    return cliente;
            }

            return new Cliente();
        }

        public Cliente ObterPorIdentificador(int identificador)
        {
            foreach (var cliente in clientes)
            {
                if (cliente.Id == identificador)
                    return cliente;
            }

            return new Cliente();
        }

        public Cliente ObterPorNome(string nome)
        {
            foreach (var cliente in clientes)
            {
                if (cliente.Nome == nome)
                    return cliente;
            }

            return new Cliente();
        }
        //761 - SQLServer
        /*
        3 - Select c.*
        1 - from clientes as c
        2 - where c.nome = @nome
        4 - order by c.nome
         */

        public Cliente ObterPorNomeUsandoLinq(string nome)
        {
            var resultado = from c in clientes
                            where c.Nome == nome
                            orderby c.Nome
                            select c;

            return resultado.ToList()[0];
        }

        
        public Cliente ObterPorNomeUsandoLinqLambdaExpression(string nome)
        {
            var resultado = clientes.FirstOrDefault(x => x.Nome == nome);
            return resultado;
        }


        public string ObterNif(string nome)
        {
            var resultado = from c in clientes
                            where c.Nome == nome
                            orderby c.Nome
                            select c.NumeroIdentificacaoFiscal;

            return resultado.ToList()[0];
        }


        public Cliente ObterFormatado(string nome, string nif)
        {
            var resultado = clientes
                        .Where(x => x.Nome == nome && x.NumeroIdentificacaoFiscal == nif)
                        .OrderBy(x => x.Nome)
                        .OrderByDescending(x => x.NumeroIdentificacaoFiscal)
                        .ThenBy(x => x.DataNascimento)
                        .Select(x => new Cliente
                        {
                            Nome = nome.ToUpper(),
                            DataNascimento = DateTime.Now,
                            Id = x.Id,
                            Morada = x.Morada,
                            NumeroIdentificacaoFiscal = x.NumeroIdentificacaoFiscal,
                            Sexo = x.Sexo
                        });

            return resultado.FirstOrDefault();
        }
    }
}
