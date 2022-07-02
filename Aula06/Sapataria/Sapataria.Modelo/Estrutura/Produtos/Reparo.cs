namespace Sapataria.Modelo.Estrutura.Produtos
{
    public class Reparo : Produto
    {
        public string TipoDefeito { get; set; }

        public override void ExemploSobrescrita()
        {
            Console.WriteLine("Sou o ExemploSobrescrita da classe Reparo");
        }
    }
}
