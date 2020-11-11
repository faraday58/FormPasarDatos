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
    public partial class FormEnviar : Form
    {
        public delegate void DelegadoEnviar(string Dato);
        public event DelegadoEnviar Enviar;

        public FormEnviar()
        {
            InitializeComponent();
        }

        private void btnEnviaDato_Click(object sender, EventArgs e)
        {
            Enviar(txtbEnviaDato.Text);
        }
    }
}
