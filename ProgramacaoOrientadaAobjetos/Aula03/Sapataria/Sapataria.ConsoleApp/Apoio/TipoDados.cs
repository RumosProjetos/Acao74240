using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapataria.ConsoleApp.Apoio
{
    public  class TipoDados
    {
        //TiposNuméricos
        public int Inteiro { get; set; } // -2147483648  até 2147483647 >> 2^32 
        public long InteiroLongo { get; set; } // -9223372036854775808  até 9223372036854775807 >> 2^32 
        public float NumerosComVirgula { get; set; } // -3,4028235E+38 até 3,4028235E+38
        public double NumerosLongosComVirgula { get; set; } // -1,7976931348623157E+308 até 1,7976931348623157E+308
        public decimal ValoresMonetarios { get; set; } //-79228162514264337593543950335 até 79228162514264337593543950335
        public char Caracter { get; set; } //'a' até 'z' - 0 até 65535


        //Tipos especiais
        public DateOnly Datas { get; set; }
        public bool VerdadeiroFalso { get; set; }
        
        //Tipos texto
        public string DadosTexto { get; set; } //Tamanho da Ram disponível (anteriormente) 2GB
        public StringBuilder TextoGrande { get; set; }

        //Tipos de Coleção
        public int[] MeuArrayVetor { get; set; }
        public int[][] MinhaMatrizBidimensional { get; set; }
        public int[][][] MinhaMatrizTridimensional { get; set; }
        public List<int> MinhaLista { get; set; }
        public Queue<int> MinhaFilaDePessoas { get; set; } //Primeira que entra, primeiro sair (FIFO)
        public Stack<int> MinhaPilhaDePratos { get; set; }// ùltimo que entra primeiro a sair 
        public Dictionary<string, string> DicionarioChaveValor { get; set; }// Colecao baseada em chaves



        ERRO get; set; init; 
    }
}
