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
            //var secado = new FormSecado();
            //secado.ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
           
        }
    }
}
