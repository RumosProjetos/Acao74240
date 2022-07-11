namespace Sapataria.Modelo.Estrutura.Produtos
{
    //public - Todos podem enxergar
    //private - Só pode ser vista dentro da classe
    //protected - Só a classe e as filhas conseguem ver
    //internal (package) - Só visível dentro do mesmo namespace 
    //sealed (final) - Não pode ser herdada

    public sealed class Sapato : Produto
    {
        public int Tamanho { get; set; }
        public Cor cor { get; set; }
        public string Material { get; set; }

        private string InformacaoInterna { get; set; }

        public Sapato()
        {
            InformacaoInterna = "Exemplo interno";
            PropriedadeProtegida = "Exemplo protected";
        }

        //Permite Substituir no filho

        //TODO: Verificar local correto desse método
        public override void Exemplo()
        {
            Console.WriteLine("Sou a classe sapato");
        }


        //TODO: Verificar local correto desse método
        public override void ExemploSobrescrita()
        {
            Console.WriteLine("Sou o ExemploSobrescrita da classe sapato");
        }
    }
}
