﻿namespace Sapataria.Modelo.Estrutura.Pessoas
{
    public class CodigoPostal
    {
        public string Codigo { get; set; }
        public string Complemento { get; set; }

        public override string ToString()
        {
            return $"{Codigo}-{Complemento}";
        }
    }
}