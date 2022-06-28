namespace Sapataria.Modelo.Estrutura.Pessoas
{
    public abstract class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NumeroIdentificacaoFiscal { get; set; }
        public Sexo Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade => ObterIdade();


        public virtual int ObterIdade()
        {
            var resultado = DateTime.Now.Year - DataNascimento.Year;
            return resultado;
        }

        public bool ValidarNif()
        {
            var resultado = true;

            //	- RN01 : NIF possui exatamente 9 números
            if (NumeroIdentificacaoFiscal.Length != 9)
                resultado = false;

            // -RN02 : NIF não possui letras
            for (int i = 0; i < NumeroIdentificacaoFiscal.Length; i++)
            {
                //12345678A                
                if (char.IsDigit(NumeroIdentificacaoFiscal[i]) == false)
                {
                    resultado = false;
                }
            }

            //RN03 : Clientes são pessoas singulares, logo, NIF TEM que começar com 1, 2 ou 3
            //var valoresAceites = new int[4] { 1, 2, 3, 4 };
            if (NumeroIdentificacaoFiscal[0] != 1 &&
                NumeroIdentificacaoFiscal[0] != 2 &&
                NumeroIdentificacaoFiscal[0] != 3 &&
                NumeroIdentificacaoFiscal[0] != 4)
            {
                resultado = false;
            }


            return resultado;
        }
    }
}