using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projeto.Modelo;
using Projeto.Repositorio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Repositorio.Repositorio.Tests
{
    /*
     a6e3e9b1-6d7c-491c-92d6-c20a4652e32d
54aff385-d7d0-4a3b-9380-677a5c10d556
     
     */

    [TestClass()]
    public class CategoriaRepositorioTests
    {
        List<Categoria> _listaParaTestes;
        [TestInitialize]
        public void Inicializador()
        {
            _listaParaTestes = new List<Categoria> {
                 new Categoria {Id = new Guid("fbb6741d-b294-4e22-9f4f-fc30d3c31101"), Nome = "Categoria 01", Descricao = "Categoria 01 Descricao"},
                 new Categoria {Id = new Guid("a60a4f8d-8d17-4c82-afbd-f23fefc823e9"), Nome = "Categoria 02", Descricao = "Categoria 02 Descricao"},
                 new Categoria {Id = new Guid("cfc72565-b115-4c94-93a6-ab7daf845420"), Nome = "Categoria 03", Descricao = "Categoria 03 Descricao"},
            };
        }



        [TestMethod()]
        public void DeveObterTodosAsCategoriasDoRepositorioTest()
        {
            //Arrange
            var repo = new CategoriaRepositorio(_listaParaTestes);

            //Act
            var categorias = repo.ObterTodos();

            //Assert
            Assert.IsNotNull(categorias);
            Assert.AreEqual(3, categorias.Count());
        }


        [TestMethod()]
        public void DeveObterCategoriasPorIdApartirDoRepositorioTest()
        {
            //Arrange
            var repo = new CategoriaRepositorio(_listaParaTestes);

            //Act
            var IdProcurado = new Guid("fbb6741d-b294-4e22-9f4f-fc30d3c31101");
            var categoria = repo.ObterPorId(IdProcurado);

            //Assert
            Assert.IsNotNull(categoria);
            Assert.AreEqual(IdProcurado, categoria.Id);
        }

        [TestMethod]
        public void DeveInserirNovaCategoriaTest()
        {
            //arrange
            var repo = new CategoriaRepositorio(_listaParaTestes);
            var categoriaNova = new Categoria { Id = new Guid("a6e3e9b1-6d7c-491c-92d6-c20a4652e32d"), Nome = "Categoria 04", Descricao = "Categoria 04 Descricao" };

            //act
            repo.InserirNovo(categoriaNova);
            var categorias = repo.ObterTodos();


            //assert		
            Assert.IsNotNull(categorias);
            Assert.AreEqual(4, categorias.Count());
        }


        [TestMethod]
        public void DeveApagarNovaCategoriaTest()
        {
            //arrange
            var repo = new CategoriaRepositorio(_listaParaTestes);
            var idProcurado = new Guid("fbb6741d-b294-4e22-9f4f-fc30d3c31101");

            //act
            repo.Apagar(idProcurado);
            var categorias = repo.ObterTodos();

            //assert		
            Assert.IsNotNull(categorias);
            Assert.AreEqual(2, categorias.Count());
        }


        [TestMethod]
        public void DeveAtualizarCategoriaTest()
        {
            //arrange
            var repo = new CategoriaRepositorio(_listaParaTestes);
            var idProcurado = new Guid("fbb6741d-b294-4e22-9f4f-fc30d3c31101");
            var categoria = new Categoria
            {
                Id = idProcurado,
                Nome = "Categoria X",
                Descricao = "Dados Alterados"
            };

            //act
            repo.Atualizar(categoria);
            var categoriaAtualizada = repo.ObterPorId(idProcurado);

            //assert		
            Assert.IsNotNull(categoriaAtualizada);
            Assert.AreEqual("Categoria X", categoriaAtualizada.Nome);
            Assert.AreEqual("Dados Alterados", categoriaAtualizada.Descricao);
        }

        [TestMethod]
        public void DeveSalvarOsDadosDasCategoriasEmArquivoTest()
        {
            //arrange
            var repo = new CategoriaRepositorio(_listaParaTestes);

            //act
            repo.Salvar();

            //assert		
            Assert.IsNotNull(repo);
        }

        /*
        void Salvar();
        void Carregar(); 
         */
    }
}