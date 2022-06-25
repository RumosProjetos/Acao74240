namespace Sapataria.Modelo.Estrutura.Produtos
{
    public abstract class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Fornecedor { get; set; }


        //Permite Substituir no filho
        public virtual void Exemplo()
        {
            Console.WriteLine("Sou a classe abstrata");
        }


        public abstract void ExemploSobrescrita();
    }
}
