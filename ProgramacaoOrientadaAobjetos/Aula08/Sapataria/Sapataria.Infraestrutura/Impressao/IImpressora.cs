namespace Sapataria.Infraestrutura.Impressao
{
    public interface IImpressora
    {
        public void Imprimir(byte[] dados);
        public void Imprimir(string dados);
    }
}
