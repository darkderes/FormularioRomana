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
    public partial class FormPrincipal : MetroFramework.Forms.MetroForm
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
            // TODO: esta línea de código carga datos en la tabla 'genesisDataSet.Variedad' Puede moverla o quitarla según sea necesario.
            this.variedadTableAdapter.Fill(this.genesisDataSet.Variedad);
            // TODO: esta línea de código carga datos en la tabla 'genesisDataSet.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.genesisDataSet.Producto);

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            FormRecepciónes x = new FormRecepciónes();
            x.ShowDialog();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            FormAdmin_Secado x = new FormAdmin_Secado();
            x.ShowDialog();
        }
    }
}
