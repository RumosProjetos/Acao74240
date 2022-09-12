namespace Sapataria.Modelo.Estrutura.Produtos
{
    internal class Mala : Produto
    {
        public override void ExemploSobrescrita()
        {
            throw new NotImplementedException();
        }

        public int Capacidade { get; set; }
    }
}
