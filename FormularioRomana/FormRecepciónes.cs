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
        short? formalizada = null;
        short? humedad = null;
        public FormRecepciónes()
        {
            InitializeComponent();
        }

        private void recepcionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void FormRecepciónes_Load(object sender, EventArgs e)
        {    radioButton1.Checked = true;
            radioButton6.Checked = true;
            this.productoresTableAdapter.FillByProductores(this.genesisDataSet1.Productores);
            this.variedadTableAdapter.TraerVariedad(this.genesisDataSet.Variedad);
            this.productoTableAdapter.FillProductosByProceso(this.genesisDataSet.Producto, 1);
            this.traer_Resumen_Recepcion_FiltroTableAdapter.Fill(genesisDataSet.Traer_Resumen_Recepcion_Filtro,null,null,null,formalizada,humedad);
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var recepcion = new Form1();
            recepcion.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
        
            short? productor = (!string.IsNullOrEmpty(cod_ProductorTextBox.Text)) ? Convert.ToInt16(cod_ProductorTextBox.Text) : (short?)null;
            short? variedad = (!string.IsNullOrEmpty(CmbVariedad.SelectedValue.ToString())&&(CmbVariedad.SelectedIndex != 0)) ? Convert.ToInt16(CmbVariedad.SelectedValue.ToString()) : (short?)null;
            short? producto = (!string.IsNullOrEmpty(productosComboBox.SelectedValue.ToString())&&(productosComboBox.SelectedIndex != 0)) ? Convert.ToInt16(productosComboBox.SelectedValue.ToString()) : (short?)null;
            if (radioButton6.Checked)
            {
                formalizada = null;
            }
            else
            if (radioButton5.Checked)
            {
                formalizada = 1;
            }
            else
            if (radioButton4.Checked)
            {
                formalizada = 0;
            }
            if (radioButton1.Checked)
            {
                humedad = null;
            }
            else
             if (radioButton2.Checked)
            {
                humedad = 1;
            }
            else
            if (radioButton3.Checked)
            {
                humedad = 0;
            }

            try
            {
                this.traer_Resumen_Recepcion_FiltroTableAdapter.Fill(this.genesisDataSet.Traer_Resumen_Recepcion_Filtro, productor,variedad,producto,(short?)formalizada,humedad);

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

        private void button2_Click(object sender, EventArgs e)
        {
            FormBusquedaProductores productores = new FormBusquedaProductores();
            productores.ShowDialog();
            cod_ProductorTextBox.Text = productores.codigo.ToString();
            productoresTableAdapter.FiltroProductorByCodigo(genesisDataSet1.Productores, (short)productores.codigo);
        }

        private void fillByProductoresToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productoresTableAdapter.FillByProductores(this.genesisDataSet.Productores);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void cod_ProductorTextBox_TextChanged(object sender, EventArgs e)
        {
            short productor = 0;
            Boolean Isnum = short.TryParse(cod_ProductorTextBox.Text, out productor);
            if (Isnum)
            {
                productoresTableAdapter.FiltroProductorByCodigo(genesisDataSet1.Productores, productor);
            }
        }

        private void nom_ProductorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cod_ProductorTextBox.Text = nom_ProductorComboBox.SelectedValue.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void traer_Resumen_Recepcion_FiltroDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn15"].Value.ToString() == "No")
            {

                traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
            }
            else
            {
                traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
            }
        }
    }
}
