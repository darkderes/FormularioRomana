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
        int acum_celda  = 0;
        int Esta_Proceso_Secado = 0;
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
            {  }      
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
            {  }
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
            catch (Exception)
            { }    
        }
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                this.verificar_Proceso_SecadoTableAdapter.Fill(this.genesisDataSet.Verificar_Proceso_Secado, new System.Nullable<short>(((short)(System.Convert.ChangeType(cod_ProductorTextBox.Text, typeof(short))))), new System.Nullable<short>(((short)(System.Convert.ChangeType(CmbVariedad.SelectedValue.ToString(), typeof(short))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBox1.Text, typeof(int))))));
                if (verificar_Proceso_SecadoDataGridView.RowCount > 0)
                {
                    MessageBox.Show("Ya existe un proceso de secado vinculado a un lote", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Esta_Proceso_Secado = 1;
                    label9.Visible = true;
                    Lbl_Recepcion.Visible = true;
                    Lbl_Recepcion.Text = verificar_Proceso_SecadoDataGridView.Rows[0].Cells[nameof(dataGridViewTextBoxColumn11)].Value.ToString();
                    traer_Tarjas_Vaciados_SecadoTableAdapter.Fill(genesisDataSet1.Traer_Tarjas_Vaciados_Secado, Convert.ToInt16(Lbl_Recepcion.Text));               
                }
                else
                {
                    Esta_Proceso_Secado = 0;
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            if (comboBox1.Items.Count > 0)
            {
                traer_Tarjas_SecadoTableAdapter.Fill(genesisDataSet1.Traer_Tarjas_Secado, Convert.ToInt16(comboBox1.Text));
                Lbl_Tarjas_Totales.Text = dataGridView1.RowCount.ToString();
                Lbl_TarjasVaciadas.Text = dataGridView2.RowCount.ToString();
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells[nameof(Tarjas_check)].Value = true;
                    acum_celda = dataGridView1.RowCount;
                    Lbl_Tarjas_Seleccionados.Text = acum_celda.ToString();
                }
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells[nameof(Tarjas_check)].Value = false;
                    acum_celda = 0;
                    Lbl_Tarjas_Seleccionados.Text = "0";
                }
            }
        }
        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {     
            if (e.RowIndex == -1)
                return;
            if (Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[nameof(Tarjas_check)].Value) == true)
            {
                acum_celda = acum_celda + 1;
            }
            else
            {
                acum_celda = acum_celda - 1;
            }
            Lbl_Tarjas_Seleccionados.Text = acum_celda.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Esta_Proceso_Secado == 0)//verifiaca si existe un proceso de secado vinculado a un lote 
            {
                int id = Convert.ToInt32(this.secadoTableAdapter.Crear_Proceso_Secado(Convert.ToInt16(cod_ProductorTextBox.Text), Convert.ToInt16(CmbVariedad.SelectedValue.ToString()), 5, 9, "16448502-1"));
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[nameof(Tarjas_check)].Value) == true)
                    {
                        recepcionesTableAdapter.Proceso_Final_Recepcion(row.Cells[1].Value.ToString(), id, "SE");
                    }
                }
                traer_Tarjas_SecadoTableAdapter.Fill(genesisDataSet1.Traer_Tarjas_Secado, Convert.ToInt16(comboBox1.Text));
                traer_Tarjas_Vaciados_SecadoTableAdapter.Fill(genesisDataSet1.Traer_Tarjas_Vaciados_Secado,Convert.ToInt16(id));
                Lbl_Tarjas_Totales.Text = dataGridView1.RowCount.ToString();
                label9.Visible = true;
                Lbl_Recepcion.Visible = true;
                Lbl_Recepcion.Text = id.ToString();
                Lbl_Tarjas_Totales.Text = dataGridView1.Rows.Count.ToString();
                Lbl_TarjasVaciadas.Text = dataGridView2.RowCount.ToString();
                Lbl_Tarjas_Seleccionados.Text = "0";
                acum_celda = 0;
                Esta_Proceso_Secado = 1;
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[nameof(Tarjas_check)].Value) == true)
                    {
                        recepcionesTableAdapter.Proceso_Final_Recepcion(row.Cells[1].Value.ToString(),Convert.ToInt16(Lbl_Recepcion.Text), "SE");
                    }
                }
                traer_Tarjas_SecadoTableAdapter.Fill(genesisDataSet1.Traer_Tarjas_Secado, Convert.ToInt16(comboBox1.Text));
                traer_Tarjas_Vaciados_SecadoTableAdapter.Fill(genesisDataSet1.Traer_Tarjas_Vaciados_Secado, Convert.ToInt16(Lbl_Recepcion.Text));
                Lbl_Tarjas_Totales.Text = dataGridView1.RowCount.ToString();
                label9.Visible = true;
                Lbl_Recepcion.Visible = true;
                Lbl_Tarjas_Totales.Text = dataGridView1.Rows.Count.ToString();
                Lbl_TarjasVaciadas.Text = dataGridView2.RowCount.ToString();
                Lbl_Tarjas_Seleccionados.Text = "0";
                acum_celda = 0;
                Esta_Proceso_Secado = 1;
            }       
        }
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (Convert.ToBoolean(row.Cells[nameof(CheckTarjas)].Value) == true)
                {
                    recepcionesTableAdapter.Proceso_Final_Recepcion(row.Cells[1].Value.ToString(),null,null);                
                }
            }
            traer_Tarjas_Vaciados_SecadoTableAdapter.Fill(genesisDataSet1.Traer_Tarjas_Vaciados_Secado, Convert.ToInt16(Lbl_Recepcion.Text));
            traer_Tarjas_SecadoTableAdapter.Fill(genesisDataSet1.Traer_Tarjas_Secado, Convert.ToInt16(comboBox1.Text));
            Lbl_Tarjas_Seleccionados.Text = "0";
            Lbl_Tarjas_Totales.Text = dataGridView1.RowCount.ToString();
            Lbl_TarjasVaciadas.Text = dataGridView2.RowCount.ToString();
        }
        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    row.Cells[nameof(CheckTarjas)].Value = true;
                    acum_celda = dataGridView2.RowCount;
                    Lbl_Tarjas_Seleccionados.Text = acum_celda.ToString();
                }
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    row.Cells[nameof(CheckTarjas)].Value = false;
                    acum_celda = 0;
                    Lbl_Tarjas_Seleccionados.Text = "0";
                }
            }
        }
    }
}
