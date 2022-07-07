using Sapataria.Modelo.Estrutura.Pessoas;

namespace Sapataria.Tests.Playground
{
    [TestClass]
    public class ManipulacaoArquivosTest
    {
        [TestMethod]
        public void DeveriaLerConteudoDeArquivoTest()
        {
            //Cuidado, esse teste nºao é um bom exemplo de indempotência (não pode ser repetido sempre)
            //arrange
            var caminho = @"c:\temp\teste.txt";

            //act
            var conteudo = File.ReadAllText(caminho);

            //assert
            Assert.IsNotNull(conteudo);
        }


        [TestMethod]
        public void DeveriaLerConteudoDeArquivoLinesTest()
        {
            //Cuidado, esse teste nºao é um bom exemplo de indempotência (não pode ser repetido sempre)
            //arrange
            var caminho = @"c:\temp\teste.txt";

            //act
            var conteudo = File.ReadAllLines(caminho);

            //assert
            Assert.IsNotNull(conteudo);
        }


        [TestMethod]
        public void DeveriaEscreverConteudoDeArquivoTest()
        {
            //arrange
            var caminho = @"c:\temp\teste.txt";

            //act
            File.WriteAllText(caminho, "exemploConteudo");
            var conteudo = File.ReadAllLines(caminho);

            //assert
            Assert.IsNotNull(conteudo);
        }


        [TestMethod]
        public void DeveriaEscreverConteudoDeArquivoLinhasTest()
        {
            //arrange
            var caminho = @"c:\temp\teste.txt";

            //act
            File.WriteAllLines(caminho, new string[] { "linha01", "linha2"});
            var conteudo = File.ReadAllLines(caminho);

            //assert
            Assert.IsNotNull(conteudo);
        }

        [TestMethod]
        public void DeveriaCompletarConteudoDeArquivoLinhasTest()
        {
            //arrange
            var caminho = @"c:\temp\teste.txt";

            //act
            File.AppendAllLines(caminho, new string[] { "linha01", "linha2" });
            var conteudo = File.ReadAllLines(caminho);

            //assert
            Assert.IsNotNull(conteudo);
        }


        [TestMethod]
        public void DeveriaRecuperarInformacoesBasicasDeArquivoTest()
        {
            //arrange
            var caminho = @"c:\temp\teste.txt";
            Directory.CreateDirectory(@"c:\temp\");
            DateTime dataCriacao = new DateTime();
            File.AppendAllLines(caminho, new string[] { "linha01", "linha2" });

            //act
            if (File.Exists(caminho))
            {
                dataCriacao = File.GetCreationTime(caminho);
                File.Delete(caminho);
            }
                        

            //assert
            Assert.AreNotEqual(new DateTime(), dataCriacao);
        }


        [TestMethod]
        public void DeveriaRecuperarInformacoesAvancadasDeArquivoTest()
        {
            //arrange
            var caminho = @"c:\temp\teste.txt";
            DateTime dataCriacao = new DateTime();
            Directory.CreateDirectory(@"c:\temp\");
            File.AppendAllLines(caminho, new string[] { "linha01", "linha2" });

            //act
            if (File.Exists(caminho))
            {
                dataCriacao = File.GetCreationTime(caminho);
                var informacoes = new FileInfo(caminho);

                File.Delete(caminho);
            }


            //assert
            Assert.AreNotEqual(new DateTime(), dataCriacao);
        }



        [TestMethod]
        public void DeveriaCriarPastaSeNaoExistirTest()
        {
            //arrange
            var caminho = @"c:\temp22\temp33";

            //act
            if (!Directory.Exists(caminho))
            {
                Directory.CreateDirectory(caminho);
            }
            var resultado = Directory.Exists(caminho);

            //assert
            Assert.IsTrue(resultado);
        }


        [TestMethod]
        public void DeveriaRecuperarArquivosDeUmDiretorioTest()
        {
            //arrange
            var caminho = @"c:\tmp\";
            var resultado = new List<string>();


            //act
            if (Directory.Exists(caminho))
            {
                resultado =  Directory.GetFiles(caminho).OrderByDescending(x => x).ToList();
            }

            foreach (var item in resultado)
            {
                var conteudo = File.ReadAllText(item);
            }
            

            //assert
            Assert.IsNotNull(resultado);
        }



        [TestMethod]
        public void DeveriaEscreverConteudoDeObjetoClienteEmArquivoTest()
        {
            //arrange
            var caminho = @"c:\temp\teste_cliente.txt";
            var listaClientes = new List<Cliente>();

            for (int i = 0; i < 100; i++)
            {
                var cliente = new Cliente();
                cliente.Nome = "José da Silva" + i;
                cliente.DataNascimento = new DateTime(2000, 01, 01);
                cliente.NumeroIdentificacaoFiscal = "123456789";
                cliente.Morada = new Morada
                {
                    CodigoPostal = new CodigoPostal { Codigo = "2830", Complemento = "044" },
                    Distrito = "Setubal",
                    TipoMorada = TipoMorada.Residencia
                };


                listaClientes.Add(cliente);
            }


            
            var conteudo = Newtonsoft.Json.JsonConvert.SerializeObject(listaClientes);


            //act
            File.WriteAllText(caminho, conteudo);
            var conteudoJson = File.ReadAllLines(caminho);

            //assert
            Assert.IsNotNull(conteudoJson);
        }

        [TestMethod]
        public void DeveriaDesserializarJsonEmObjetoTest()
        {
            //arrange 
            var caminho = @"c:\temp\teste_cliente.txt";
            var listaClientes = new List<Cliente>();

            //act 
            var conteudo = File.ReadAllText(caminho);
            listaClientes = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Cliente>>(conteudo);
            var clientePreferencial = listaClientes.FirstOrDefault(x => x.Idade == 38);

            //Assert
            Assert.AreEqual("Jonatas", clientePreferencial.Nome);

        }

    }
}
