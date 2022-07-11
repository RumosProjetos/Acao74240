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
    }
}
