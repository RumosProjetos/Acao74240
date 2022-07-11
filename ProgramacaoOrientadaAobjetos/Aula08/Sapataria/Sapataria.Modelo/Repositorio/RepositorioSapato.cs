using Sapataria.Modelo.Estrutura.Produtos;

namespace Sapataria.Modelo.Repositorio
{
    public class RepositorioSapato : IRepositorio<Sapato>
    {
        private List<Sapato> sapatos { get; set; }
        public RepositorioSapato()
        {
            sapatos = new List<Sapato>();
        }

        public void Adicionar(Sapato item)
        {
            sapatos.Add(item);
        }

        public void Apagar(Sapato item)
        {
            sapatos.Remove(item);
        }

        public void Atualizar(Sapato item)
        {
            throw new NotImplementedException();
        }

        public Sapato Obter(Sapato item)
        {
            foreach (var sapato in sapatos)
            {
                if (sapato == item)
                    return sapato;
            }

            return new Sapato();
        }

        public Sapato ObterPorIdentificador(int identificador)
        {
            foreach (var sapato in sapatos)
            {
                if (sapato.Id == identificador)
                    return sapato;
            }

            return new Sapato();
        }

        public Sapato ObterPorNome(string nome)
        {
            foreach (var sapato in sapatos)
            {
                if (sapato.Nome == nome)
                    return sapato;
            }

            return new Sapato();
        }

        public void Salvar()
        {
            throw new NotImplementedException();
        }

        public List<Sapato> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
