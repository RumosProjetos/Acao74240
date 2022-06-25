namespace Sapataria.Modelo.Estrutura.Produtos
{
    public sealed class Sapato : Produto
    {
        public int Tamanho { get; set; }
        public Cor cor { get; set; }
        public string Material { get; set; }



        //Permite Substituir no filho
        public override void Exemplo()
        {
            Console.WriteLine("Sou a classe sapato");
        }

        public override void ExemploSobrescrita()
        {
            Console.WriteLine("Sou o ExemploSobrescrita da classe sapato");
        }
    }
}
