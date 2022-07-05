using Sapataria.Modelo.Estrutura.Pessoas;

namespace Sapataria.Modelo.Repositorio
{
    public class RepositorioFuncionario : IRepositorio<Funcionario>
    {
        private List<Funcionario> funcionarios { get; set; }

        public RepositorioFuncionario()
        {
            funcionarios = new List<Funcionario>();
        }

        public void Adicionar(Funcionario item)
        {
            funcionarios.Add(item);
        }

        public Funcionario ObterPorNome(string nome)
        {
            foreach (var item in funcionarios)
            {
                if(item.Nome == nome)
                {
                    return item;
                }
            }

            return new Funcionario();
        }

        public Funcionario ObterPorIdentificador(int identificador)
        {
            foreach (var item in funcionarios)
            {
                if (item.Id == identificador)
                {
                    return item;
                }
            }

            return new Funcionario();
        }

        public Funcionario Obter(Funcionario item)
        {
            foreach (var funcionario in funcionarios)
            {
                if (funcionario == item)
                {
                    return funcionario;
                }
            }

            return new Funcionario();
        }

        public void Atualizar(Funcionario item)
        {
            throw new NotImplementedException();
        }

        public void Apagar(Funcionario item)
        {
            funcionarios.Remove(item);
        }

        public void Salvar()
        {
            throw new NotImplementedException();
        }

        public List<Funcionario> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
