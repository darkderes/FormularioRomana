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
    public partial class FormSecado : Form
    {
        public FormSecado()
        {
            InitializeComponent();
        }

        private void cod_ProductorTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                short productor = 0;
                Boolean Isnum = short.TryParse(cod_ProductorTextBox.Text, out productor);
                if (Isnum)
                {
                    productoresTableAdapter.FiltroProductorByCodigo(genesisDataSet.Productores, productor);
                    traer_Variedad_SecadoTableAdapter.Fill(genesisDataSet.Traer_Variedad_Secado, productor);
                    if (CmbVariedad.Items.Count > 0)
                    {
                        traer_Procesos_SecadoTableAdapter.Fill(genesisDataSet1.Traer_Procesos_Secado, Convert.ToInt16(cod_ProductorTextBox.Text), Convert.ToInt16(CmbVariedad.SelectedValue.ToString()));
                    }
                }
            }
            catch (Exception)
            {
                //   throw;
            }
        }

        private void FormSecado_Load(object sender, EventArgs e)
        {
            this.productoresTableAdapter.Fill(this.genesisDataSet.Productores);
            cod_ProductorTextBox.Text = "1";
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

        private void button2_Click(object sender, EventArgs e)
        {
            FormBusquedaProductores productores = new FormBusquedaProductores();
            productores.ShowDialog();
            int i = productores.codigo;
            cod_ProductorTextBox.Text = i.ToString();
            productoresTableAdapter.FiltroProductorByCodigo(genesisDataSet.Productores, (short)productores.codigo);
            CmbVariedad.Refresh();
        }

        private void CmbVariedad_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                  traer_Procesos_SecadoTableAdapter.Fill(genesisDataSet1.Traer_Procesos_Secado, Convert.ToInt16(cod_ProductorTextBox.Text), Convert.ToInt16(CmbVariedad.SelectedValue.ToString()));
            }
            catch (Exception ex)
            {
            }
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count > 0)
            {
                traer_Tarjas_SecadoTableAdapter.Fill(genesisDataSet1.Traer_Tarjas_Secado, Convert.ToInt16(comboBox1.Text));
                Lbl_Tarjas_Totales.Text = dataGridView1.RowCount.ToString();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    row.Cells[nameof(Tarjas_check)].Value = true;

                }
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    row.Cells[nameof(Tarjas_check)].Value = false;

                }
            }
        }
    }
}
