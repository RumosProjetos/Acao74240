namespace Sapataria.Modelo.Estrutura.Produtos
{
    public class Reparo : Produto
    {
        public string TipoDefeito { get; set; }


        //TODO: Verificar local correto desse método
        public override void ExemploSobrescrita()
        {
            Console.WriteLine("Sou o ExemploSobrescrita da classe Reparo");
        }
    }
}
