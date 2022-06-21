namespace Sapataria.Modelo
{
    public struct Morada
    {
        public string Rua { get; set; }
        public string NumeroPorta { get; set; }
        public string Complemento { get; set; }
        public string Distrito { get; set; }
        public CodigoPostal CodigoPostal { get; set; }
        public TipoMorada TipoMorada { get; set; }
    }
}