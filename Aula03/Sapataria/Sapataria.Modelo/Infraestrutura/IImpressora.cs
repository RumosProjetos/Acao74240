namespace Sapataria.Modelo.Infraestrutura
{
    public interface IImpressora 
    {
        public void Imprimir(byte[] dados);
        public void Imprimir(string dados);
    }
}
