using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioRomana
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void recepcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var recepciones = new FormRecepciónes();
            recepciones.ShowDialog();
        }

        private void secadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var admin_Secado = new FormAdmin_Secado();
            admin_Secado.ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
          
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            FormAdmin_Secado x = new FormAdmin_Secado();
            x.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAdmin_Secado s = new FormAdmin_Secado();
            s.ShowDialog();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            FormRecepciónes x = new FormRecepciónes();
             x.ShowDialog();
        }
    }
}
