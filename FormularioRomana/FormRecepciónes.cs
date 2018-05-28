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
    public partial class FormRecepciónes : Form
    {
        public FormRecepciónes()
        {
            InitializeComponent();
        }

        private void recepcionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
         

        }

        private void FormRecepciónes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'genesisDataSet.Traer_Resumen_Recepcion' Puede moverla o quitarla según sea necesario.
            this.traer_Resumen_RecepcionTableAdapter.Fill(this.genesisDataSet.Traer_Resumen_Recepcion);
            // TODO: esta línea de código carga datos en la tabla 'genesisDataSet.Recepciones' Puede moverla o quitarla según sea necesario.
            //  this.recepcionesTableAdapter.Fill(this.genesisDataSet.Recepciones);
            // TODO: esta línea de código carga datos en la tabla 'genesisDataSet.Recepciones' Puede moverla o quitarla según sea necesario.
            // this.recepcionesTableAdapter.Traer_Resumen_Recepcion();
          

        }

        private void recepcionesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
        }
    }
}
