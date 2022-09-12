﻿namespace Sapataria.Infraestrutura.Impressao
{
    public class ImpressoraNovoFornecedor : IImpressora
    {
        public void Imprimir(byte[] dados)
        {
            File.WriteAllBytes(@"c:\temp\exemplotxt.txt", dados);
        }

        public void Imprimir(string dados)
        {
            File.WriteAllText(@"c:\temp\exemplotxt.txt", dados);
        }
    }
}
