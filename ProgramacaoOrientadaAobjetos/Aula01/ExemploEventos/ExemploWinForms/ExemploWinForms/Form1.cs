using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var valor1 = txtValor01.Text;
            var valor2 = txtValor2.Text;
            lblResultado.Text = (Convert.ToInt16(valor1) + Convert.ToInt16(valor2)).ToString();
        }
    }
}
