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
            this.variedadTableAdapter.TraerVariedad(this.genesisDataSet.Variedad);
            this.productoTableAdapter.FillProductosByProceso(this.genesisDataSet.Producto, 1);
            // TODO: esta línea de código carga datos en la tabla 'genesisDataSet.Traer_Resumen_Recepcion' Puede moverla o quitarla según sea necesario.
            this.traer_Resumen_RecepcionTableAdapter.Fill(this.genesisDataSet.Traer_Resumen_Recepcion);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var recepcion = new Form1();
            recepcion.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
          //  short? productor = null;
            short? productor = (!string.IsNullOrEmpty(cod_ProductorTextBox.Text)) ? Convert.ToInt16(cod_ProductorTextBox.Text) : (short?)null;
            short? variedad = (!string.IsNullOrEmpty(CmbVariedad.SelectedValue.ToString())&&(CmbVariedad.SelectedIndex != 0)) ? Convert.ToInt16(CmbVariedad.SelectedValue.ToString()) : (short?)null;
            short? producto = (!string.IsNullOrEmpty(productosComboBox.SelectedValue.ToString())&&(productosComboBox.SelectedIndex != 0)) ? Convert.ToInt16(productosComboBox.SelectedValue.ToString()) : (short?)null;
           // variedad = (CmbVariedad.SelectedIndex == 0) ? (short?)null: variedad;
         /*   if (variedad == 0)
            {
                variedad = null;
            }*/
            try
            {
                traer_Resumen_RecepcionTableAdapter.FiltroRecepcion(this.genesisDataSet.Traer_Resumen_Recepcion,productor,variedad,producto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void traerVariedadToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.variedadTableAdapter.TraerVariedad(this.genesisDataSet.Variedad);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
