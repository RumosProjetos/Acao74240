using Sapataria.Modelo.Estrutura.Pessoas;

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
                if (cliente.Equals(item))
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


        /// <summary>
        /// Persiste a lista que está na memória em um arquivo texto
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void Salvar()
        {
            var diretorio = @"c:\temp";
            var caminho = @"c:\temp\clientes.txt";
            if (Directory.Exists(diretorio) == false)
            {
                Directory.CreateDirectory(diretorio);
            }

            var dadosClientes = new List<string>();
            foreach (var item in clientes)
            {
                dadosClientes.Add(item.ToString());
            }

            File.AppendAllLines(caminho, dadosClientes);
        }

        public List<Cliente> Listar()
        {
            var resultado = new List<Cliente>();
            var caminho = @"c:\temp\clientes.txt";
            if (File.Exists(caminho))
            {
                var linhas = File.ReadAllLines(caminho);
                foreach (var item in linhas)
                {
                    var cliente = new Cliente();
                    var dados = item.Split(";");
                    cliente.Id = Convert.ToInt32(dados[0]);
                    cliente.Nome = dados[1];
                    cliente.NumeroIdentificacaoFiscal = dados[2];
                    cliente.Sexo = (Sexo)Convert.ToInt32(dados[3]);
                    cliente.DataNascimento = DateTime.Parse(dados[4]);

                    resultado.Add(cliente);
                }
            }

            return resultado;

        }
    }
}
