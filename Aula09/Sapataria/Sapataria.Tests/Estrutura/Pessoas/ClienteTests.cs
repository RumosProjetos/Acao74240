namespace Sapataria.Modelo.Estrutura.Pessoas.Tests
{
    [TestClass()]
    public class ClienteTests
    {
        [TestMethod()]
        public void DeveObterUmAnoDeIdadeSeOClienteNasceuHa12MesesTest()
        {
            //Arrange
            var cliente = new Cliente();
            cliente.DataNascimento = DateTime.Now.AddYears(-1);

            //Act
            var idade = cliente.ObterIdade();

            //Assert
            Assert.AreEqual(1, idade);
        }
    }
}