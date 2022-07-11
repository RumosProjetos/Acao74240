namespace Sapataria.Infraestrutura.Impressao
{
    public class ImpressoraPDF : IImpressora
    {
        public void Imprimir(byte[] dados)
        {
            File.WriteAllBytes(@"c:\temp\exemplopdf.pdf", dados);
        }

        public void Imprimir(string dados)
        {
            File.WriteAllText(@"c:\temp\exemplopdf.pdf", dados);
        }
    }
}
