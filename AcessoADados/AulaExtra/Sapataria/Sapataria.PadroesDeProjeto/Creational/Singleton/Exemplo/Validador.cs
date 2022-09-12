namespace Sapataria.PadroesDeProjeto.Creational.Singleton.Exemplo
{
    public class Validador
    {
        public string NomeDocumento { get; set; }

        private static Validador _validadorInterno { get; set; }


        public static Validador ValidadorOnLine
        {
            get
            {
                if (_validadorInterno == null)
                {
                    _validadorInterno = new Validador();
                }

                return _validadorInterno;
            }
        }
    }
}
