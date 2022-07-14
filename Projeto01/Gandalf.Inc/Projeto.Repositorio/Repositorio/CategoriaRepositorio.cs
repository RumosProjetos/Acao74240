using Newtonsoft.Json;
using Projeto.Modelo;
using System.Configuration;

namespace Projeto.Repositorio.Repositorio
{
    public class CategoriaRepositorio : IRepositorio<Categoria>
    {
        private IList<Categoria> _categorias;

        public CategoriaRepositorio(IList<Categoria> categorias)
        {
            _categorias = categorias;
        }

        public void Apagar(Guid Id)
        {
            var categoria = _categorias.FirstOrDefault(c => c.Id == Id);
            if (categoria != null)
            {
                _categorias.Remove(categoria);
            }
        }

        public void Atualizar(Categoria TEntidade)
        {
            var categoria = _categorias.FirstOrDefault(c => c.Id == TEntidade.Id);
            if (categoria != null)
            {
                _categorias.Remove(categoria);
                _categorias.Add(TEntidade);//Cuidado, solução temporária
            }
        }

        public void Carregar(string path)
        {
            if (File.Exists(path))
            {
                var conteudo = File.ReadAllText(path);
                if (!string.IsNullOrWhiteSpace(conteudo))
                {
                    _categorias = JsonConvert.DeserializeObject<List<Categoria>>(conteudo);
                }                
            }            
        }

        public void InserirNovo(Categoria TEntidade)
        {
            if (TEntidade != null)
            {
                _categorias.Add(TEntidade);
            }
        }

        public Categoria? ObterPorId(Guid Id)
        {
            var categoria = _categorias.FirstOrDefault(c => c.Id == Id);
            return categoria;
        }

        public IList<Categoria>? ObterTodos()
        {
            return _categorias.ToList();
        }

        public void Salvar()
        {
            var json = JsonConvert.SerializeObject(_categorias);
            var caminho = ConfigurationManager.AppSettings["Categorias"];
            var path = Path.GetDirectoryName(caminho);
            if (caminho != null && !Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            File.WriteAllText(path, json);  
        }
    }
}
