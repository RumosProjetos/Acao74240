using Projeto.LogicaNegocio.ClassesInternasDoSistema;
using Projeto.Modelo;
using Projeto.Repositorio.Repositorio;
using System.Text;

namespace Projeto.LogicaNegocio
{
    public class ModuloVendas
    {
        List<Venda> _vendas;
        List<Cliente> _clientes;
        List<Estoque> _estoques;
        Utilizador _utilizador;


        public ModuloVendas(List<Venda> vendas, List<Cliente> clientes, Utilizador utilizador, List<Estoque> estoques)
        {
            _vendas = vendas;
            _clientes = clientes;
            _utilizador = utilizador;
            _estoques = estoques;
        }

        public SituacaoVenda ValidarVenda(Venda venda)
        {
            var resultado = new SituacaoVenda { Validado = true };
            var repoEstoques = new EstoqueRepositorio(_estoques);
            foreach (var detalhe in venda.DetalhesDasVendas)
            {
                var produto = detalhe.Produto;
                
                //verificar quantidade de estoque
                var quantidadeEmEstoque = repoEstoques.ObterQuantidadeEmEstoque(produto);

                //comparar com a quantidade desejada
                if(quantidadeEmEstoque < detalhe.Quantidade)
                {
                    resultado.Validado = false;
                    resultado.Mensagem = "Produto fora de estoque";
                }
            }
            
            return resultado;
        }


        public void RegistarVendas(Venda venda)
        {
            var repoVendas = new VendaRepositorio(_vendas);
            var repoClientes = new ClienteRepositorio(_clientes);

            var cliente = repoClientes.ObterPorId(venda.Cliente.Id);
            if (cliente == null)
            {
                repoClientes.InserirNovo(venda.Cliente);
            }

            repoVendas.InserirNovo(venda);
        }

        /// <summary>
        /// Gera a fatura no formato:
        ///             Loja do Marcelo
        ///             Filial do Barreio
        ///             NIF da Loja
        ///             Data e Hora da Venda
        ///             Dados do Cliente
        ///             ---------------------------------------------------
        ///             Sapato Vermelho        10         5    |Parcial| 50
        ///             Casaco Azul				1        45	   |Parcial| 45	
        ///             Calças					2		 20	   |Parcial| 40
        ///             ....................................................
        ///             Total											135 
        /// </summary>
        /// <param name="venda"></param>
        /// <returns></returns>
        public string GerarFaturaEmTexto(Venda venda)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Loja: {venda.Loja.Nome}");
            sb.AppendLine($"Filial: {venda.Loja.Endereco}");
            sb.AppendLine($"Identificação: {venda.Loja.Id}");
            sb.AppendLine($"Data e hora: {venda.DataCriacao}");
            sb.AppendLine($"Dados do Cliente: {venda.Cliente.Nome}");
            sb.AppendLine("---------------------------------------------------");

            foreach (var detalhe in venda.DetalhesDasVendas)
            {
                sb.AppendLine($"{detalhe.Produto.Nome} \t {detalhe.Produto.PrecoUnitario} \t {detalhe.Produto.QuantidadePorUnidade} \t |Parcial| \t {detalhe.Produto.PrecoParcial}");
            }
            sb.AppendLine("....................................................");
            sb.AppendLine($"{venda.TotalDaVenda}");

            return sb.ToString();
        }

        public FaturaDto GerarFatura(Venda venda)
        {
            var fatura = new FaturaDto
            {
                DataDaVenda = venda.DataCriacao,
                EnderecoDaLoja = venda.Loja.Endereco,
                IdentificaoDaLoja = venda.Loja.Id,
                NomeCliente = venda.Cliente.Nome,
                NomeDaLoja = venda.Loja.Nome,
                TotalDaVenda = venda.TotalDaVenda,
                DetalhesProdutos = (venda.DetalhesDasVendas.Select(
                    x => new ProdutoFaturaDto {
                        NomeProduto = x.Produto.Nome,
                        PrecoParcialProduto = x.Produto.PrecoParcial,
                        PrecoUnitarioProduto = x.Produto.PrecoUnitario,
                        QuantidadePorUnidadePorProduto = x.Produto.QuantidadePorUnidade
                    }
                    )).ToList()
            };

            return fatura;
        }
    }
}
