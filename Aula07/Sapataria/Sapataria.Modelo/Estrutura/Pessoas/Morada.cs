using System.Text;

namespace Sapataria.Modelo.Estrutura.Pessoas
{
    public struct Morada
    {
        public string Rua { get; set; }
        public string NumeroPorta { get; set; }
        public string Complemento { get; set; }
        public string Distrito { get; set; }
        public CodigoPostal CodigoPostal { get; set; }
        public TipoMorada TipoMorada { get; set; }


        public override string ToString()
        {
            return $"{Rua};{NumeroPorta};{NumeroPorta};{Complemento};{Distrito};{CodigoPostal};{TipoMorada}";
        }
    }
}
