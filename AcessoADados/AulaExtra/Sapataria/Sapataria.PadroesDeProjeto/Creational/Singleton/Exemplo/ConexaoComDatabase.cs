namespace Sapataria.PadroesDeProjeto.Creational.Singleton.Exemplo
{
    public class ConexaoComDatabase
    {
        public string NomeServidor { get; set; } //Server=10.20.10.21;Initial Catalog=SapatariaDB;User=meuUsuario;pass=!"#!"#
        public string NomeBaseDados { get; set; }

        public string Usuario { get; set; }
        public string Senha { get; set; }


        private static ConexaoComDatabase _minhaConexaoEscondida { get; set; }

        public static ConexaoComDatabase MinhaConexaoExposta => _minhaConexaoEscondida ?? (_minhaConexaoEscondida = new ConexaoComDatabase());
    }
}
