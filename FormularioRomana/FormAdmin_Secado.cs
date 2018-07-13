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
    public partial class FormAdmin_Secado : Form
    {
        short? Iscerrada = null;
        public FormAdmin_Secado()
        {
            InitializeComponent();
        }

        private void FormAdmin_Secado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'genesisDataSet1.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.FillProductosByProceso(this.genesisDataSet1.Producto, 2);
            // TODO: esta línea de código carga datos en la tabla 'genesisDataSet1.Variedad' Puede moverla o quitarla según sea necesario.
            this.variedadTableAdapter.TraerVariedad(this.genesisDataSet1.Variedad);
            // TODO: esta línea de código carga datos en la tabla 'genesisDataSet1.Productores' Puede moverla o quitarla según sea necesario.
            this.productoresTableAdapter.FillByProductores(this.genesisDataSet1.Productores);
            // TODO: esta línea de código carga datos en la tabla 'genesisDataSet.Traer_Proceso_Secado_Admin' Puede moverla o quitarla según sea necesario.
            this.traer_Proceso_Secado_AdminTableAdapter.Fill(this.genesisDataSet.Traer_Proceso_Secado_Admin,null,null,null,null);
            radioButton6.Checked = true;

        }

        private void traer_Proceso_Secado_AdminDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if ((traer_Proceso_Secado_AdminDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn10)].Value.ToString() == "1"))
            {
                traer_Proceso_Secado_AdminDataGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
            }
            else
            {
                traer_Proceso_Secado_AdminDataGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var secado = new FormSecado(1);
            secado.Show();
        }

        private void nom_ProductorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cod_ProductorTextBox.Text = nom_ProductorComboBox.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message,"Anakena",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void cod_ProductorTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                short productor = 0;
                Boolean Isnum = short.TryParse(cod_ProductorTextBox.Text, out productor);
                if (Isnum)
                {
                    productoresTableAdapter.FiltroProductorByCodigo(genesisDataSet1.Productores, productor);
                }
            }
            catch (Exception)
            {

                //   throw;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            short? productor = (!string.IsNullOrEmpty(cod_ProductorTextBox.Text)) ? Convert.ToInt16(cod_ProductorTextBox.Text) : (short?)null;
            short? variedad = (!string.IsNullOrEmpty(CmbVariedad.SelectedValue.ToString()) && (CmbVariedad.SelectedIndex != 0)) ? Convert.ToInt16(CmbVariedad.SelectedValue.ToString()) : (short?)null;
            short? producto = (!string.IsNullOrEmpty(productosComboBox.SelectedValue.ToString()) && (productosComboBox.SelectedIndex != 0)) ? Convert.ToInt16(productosComboBox.SelectedValue.ToString()) : (short?)null;
            if (radioButton6.Checked == true)
            {
                Iscerrada = null;
            }
            else
            if (radioButton5.Checked == true)
            {
                Iscerrada = 0;
            }
            else
            if (radioButton4.Checked == true)
            {
                Iscerrada = 1;
            }
            this.traer_Proceso_Secado_AdminTableAdapter.Fill(this.genesisDataSet.Traer_Proceso_Secado_Admin,productor, variedad,producto,Iscerrada);
        }

        private void traer_Proceso_Secado_AdminDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            FormSecado s = new FormSecado(2);
            s.Lbl_Recepcion.Text = traer_Proceso_Secado_AdminDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn1)].Value.ToString();
            s.Lbl_Recepcion.Visible = true;
            s.label9.Visible = true;
            s.CmbVariedad.Text = traer_Proceso_Secado_AdminDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn5)].Value.ToString();
            s.cod_Variedad = Convert.ToInt32(traer_Proceso_Secado_AdminDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn4)].Value.ToString());
            s.cod_ProductorTextBox.Text = traer_Proceso_Secado_AdminDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn3)].Value.ToString();
            s.Show();
        }
    }
}
