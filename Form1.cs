using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPasarDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRecibir_Click(object sender, EventArgs e)
        {
            FormEnviar formEnviar = new FormEnviar();
            formEnviar.Enviar += RecibirDato;
            formEnviar.ShowDialog();
        }

        public void RecibirDato(string Dato)
        {
            lbRecibir.Text = Dato;
        }
    }
}
