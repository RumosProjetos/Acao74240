using Sapataria.LogicaNegocio;
using Sapataria.Modelo.Estrutura.Pessoas;

namespace Sapataria.DesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            var clientes = new LogicaCliente();
            var lista = clientes.ListarClientes();
            foreach (var item in lista)
            {
                txtInformacoes.AppendText("\n"+ item.ToString());
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            var clientes = new LogicaCliente();
            clientes.AdicionarCliente(new Cliente { Nome = "Teste" });

            var pet = new Pet.ExemploProxy(new HttpClient());
            var floquinho = pet.GetPetByIdAsync(1).Result;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            File.AppendAllText(@"c:\temp\logAplicacao.log", DateTime.Now.ToString());
        }
    }
}