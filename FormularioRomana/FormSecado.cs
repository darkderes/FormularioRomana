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
        public int cod_Variedad = 0; // trae codigo de variedad desde Administracion de procesod e secado
        int Esta_Proceso_Secado = 0;
        double acum__neto_Vaciado = 0;
        double tara_envase = 0;
        double tara_base = 0;
        double acum_neto_Tarjado = 0;
        int acceso = 0;
        public FormSecado(int acc)
        {
            InitializeComponent();
            acceso = acc;
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
                        if (acceso == 1)
                        { traer_Procesos_SecadoTableAdapter.Fill(genesisDataSet1.Traer_Procesos_Secado, Convert.ToInt16(cod_ProductorTextBox.Text), Convert.ToInt16(CmbVariedad.SelectedValue.ToString()),null, 1); }
                        else
                        { traer_Procesos_SecadoTableAdapter.Fill(genesisDataSet1.Traer_Procesos_Secado, Convert.ToInt16(cod_ProductorTextBox.Text),Convert.ToInt16(cod_Variedad),Convert.ToInt32(Lbl_Recepcion.Text), 2); }
                    }
                      
                    }
                
            }
            catch (Exception)
            {  }      
        }
        private void FormSecado_Load(object sender, EventArgs e)
        {
            if (acceso == 1)//accede si viene del boton ingreso
            {
                // TODO: esta línea de código carga datos en la tabla 'genesisDataSet.Paso_Recepcion_Secado' Puede moverla o quitarla según sea necesario.
                this.paso_Recepcion_SecadoTableAdapter.Fill(this.genesisDataSet.Paso_Recepcion_Secado);
                // TODO: esta línea de código carga datos en la tabla 'genesisDataSet1.Producto' Puede moverla o quitarla según sea necesario.
                this.productoTableAdapter.FillProductosByProceso(this.genesisDataSet1.Producto, 2);
                // TODO: esta línea de código carga datos en la tabla 'genesisDataSet2.BasesPallet' Puede moverla o quitarla según sea necesario.
                this.basesPalletTableAdapter.Fill(this.genesisDataSet2.BasesPallet);
                this.productoresTableAdapter.Fill(this.genesisDataSet.Productores);
                cod_ProductorTextBox.Text = "1";
                traer_Envases_ProcesoTableAdapter.Fill(genesisDataSet2.Traer_Envases_Proceso, Convert.ToInt16(2));
                CmbBaseBins.SelectedIndex = 2;
                productosComboBox.SelectedIndex = 1;
            }
            else
            if(acceso == 2)// accede si viene desde grilla
            {

                try
                {
                    if (acceso == 1)
                    { traer_Procesos_SecadoTableAdapter.Fill(genesisDataSet1.Traer_Procesos_Secado, Convert.ToInt16(cod_ProductorTextBox.Text), Convert.ToInt16(CmbVariedad.SelectedValue.ToString()), null, 1); }
                    else
                    if (acceso == 2)
                    {
                        traer_Procesos_SecadoTableAdapter.Fill(genesisDataSet1.Traer_Procesos_Secado, Convert.ToInt16(cod_ProductorTextBox.Text), Convert.ToInt16(cod_Variedad), Convert.ToInt32(Lbl_Recepcion.Text), 2);
                        traer_Tarjas_Vaciados_SecadoTableAdapter.Fill(genesisDataSet1.Traer_Tarjas_Vaciados_Secado, Convert.ToInt16(Lbl_Recepcion.Text));
                        foreach (DataGridViewRow row in dataGridView2.Rows)
                        {
                            acum__neto_Vaciado = acum__neto_Vaciado + Convert.ToDouble(row.Cells[nameof(Peso_Neto_Final)].Value.ToString());
                        }
                        Lbl_Kilos_Vaciados.Text = Math.Round(acum__neto_Vaciado, 2).ToString();
                        Lbl_Total_Vaciados.Text = Lbl_Kilos_Vaciados.Text;
                        traer_Tarjas_Vaciados_SecadoTableAdapter.Fill(genesisDataSet1.Traer_Tarjas_Vaciados_Secado, Convert.ToInt16(Lbl_Recepcion.Text));
                        Lbl_Tarjas_Totales.Text = dataGridView1.RowCount.ToString();
                        Lbl_TarjasVaciadas.Text = dataGridView2.RowCount.ToString();
                        Lbl_Tarjas_Seleccionados.Text = "0";
                        acum_celda = 0;
                        Kilos_Vacias_entrada.Text = Lbl_Kilos_Vaciados.Text;
                        this.kilos_Secar_Por_ProcesosTableAdapter.Fill(this.genesisDataSet.Kilos_Secar_Por_Procesos, new System.Nullable<int>(((int)(System.Convert.ChangeType(Lbl_Recepcion.Text, typeof(int))))));
                        Lbl_Kilos_a_Vaciar.Text = kilos_Secar_Por_ProcesosDataGridView.Rows[0].Cells[nameof(dataGridViewTextBoxColumn14)].Value.ToString();
                        Lbl_Diferencia.Text = (Convert.ToDouble(Lbl_Kilos_a_Vaciar.Text)-(Convert.ToDouble(Lbl_Kilos_Vaciados.Text))).ToString();
                        if (comboBox1.Items.Count > 0)
                        {
                            traer_Tarjas_SecadoTableAdapter.Fill(genesisDataSet1.Traer_Tarjas_Secado, Convert.ToInt16(comboBox1.Text));
                            Lbl_Tarjas_Totales.Text = dataGridView1.RowCount.ToString();
                            Lbl_TarjasVaciadas.Text = dataGridView2.RowCount.ToString();
                        }
                        this.productoTableAdapter.FillProductosByProceso(this.genesisDataSet1.Producto, 2);
                        // TODO: esta línea de código carga datos en la tabla 'genesisDataSet2.BasesPallet' Puede moverla o quitarla según sea necesario.
                        this.basesPalletTableAdapter.Fill(this.genesisDataSet2.BasesPallet);
                        this.productoresTableAdapter.Fill(this.genesisDataSet.Productores);
                        traer_Envases_ProcesoTableAdapter.Fill(genesisDataSet2.Traer_Envases_Proceso, Convert.ToInt16(2));
                        CmbBaseBins.SelectedIndex = 2;
                        productosComboBox.SelectedIndex = 1;
                        this.traer_Tarjas_SecasTableAdapter.Fill(this.genesisDataSet.Traer_Tarjas_Secas, new System.Nullable<short>(((short)(System.Convert.ChangeType(Lbl_Recepcion.Text, typeof(short))))));

                        try { 

                              foreach (DataGridViewRow row in traer_Tarjas_SecasDataGridView.Rows)
                              {
                                   acum_neto_Tarjado = acum_neto_Tarjado + Convert.ToDouble(row.Cells[nameof(dataGridViewTextBoxColumn32)].Value.ToString());
                              }

                                    Lbl_Neto_tarjado.Text = acum_neto_Tarjado.ToString();
                                    Lbl_Total_Secados.Text = Lbl_Neto_tarjado.Text;
                                    Porc_Rendimiento.Text = Math.Round(((Convert.ToDouble(Lbl_Total_Secados.Text) / Convert.ToDouble(Lbl_Total_Vaciados.Text)) * 100), 0).ToString();
                                    Porc_Merma.Text = (100 - Convert.ToDouble(Porc_Rendimiento.Text)).ToString();
                                    Lbl_Merma.Text = (Convert.ToDouble(Lbl_Total_Vaciados.Text) - Convert.ToDouble(Lbl_Total_Secados.Text)).ToString();
                          
                        }
                        catch (System.Exception ex)
                        {
                            System.Windows.Forms.MessageBox.Show(ex.Message);
                        }
                    }
                }
                catch (Exception)
                { }
            }
            
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
                if (acceso == 1)
                { traer_Procesos_SecadoTableAdapter.Fill(genesisDataSet1.Traer_Procesos_Secado, Convert.ToInt16(cod_ProductorTextBox.Text), Convert.ToInt16(CmbVariedad.SelectedValue.ToString()), null, 1); }
                else
                 if (acceso == 2)
                {
                    traer_Procesos_SecadoTableAdapter.Fill(genesisDataSet1.Traer_Procesos_Secado, Convert.ToInt16(cod_ProductorTextBox.Text), 5, Convert.ToInt32(Lbl_Recepcion.Text), 2);
                    if (dataGridView2.RowCount > 0)
                    {
                        foreach (DataGridViewRow row in dataGridView2.Rows)
                        {
                            acum__neto_Vaciado = acum__neto_Vaciado + Convert.ToDouble(row.Cells[nameof(Peso_Neto_Final)].Value.ToString());
                        }
                        Lbl_Kilos_Vaciados.Text = Math.Round(acum__neto_Vaciado, 2).ToString();
                        Lbl_Total_Vaciados.Text = Lbl_Kilos_Vaciados.Text;
                    }
                }
            }
            catch (Exception)
            { }    
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (acceso == 1)
            {
                acum__neto_Vaciado = 0;
                try
                {
                    this.verificar_Proceso_SecadoTableAdapter.Fill(this.genesisDataSet.Verificar_Proceso_Secado, new System.Nullable<short>(((short)(System.Convert.ChangeType(cod_ProductorTextBox.Text, typeof(short))))), new System.Nullable<short>(((short)(System.Convert.ChangeType(CmbVariedad.SelectedValue.ToString(), typeof(short))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBox1.Text, typeof(int))))));
                    if (verificar_Proceso_SecadoDataGridView.RowCount > 0)
                    {
                        MessageBox.Show("Ya existe un proceso de secado vinculado n° lote", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Esta_Proceso_Secado = 1;
                        label9.Visible = true;
                        Lbl_Recepcion.Visible = true;
                        Lbl_Recepcion.Text = verificar_Proceso_SecadoDataGridView.Rows[0].Cells[nameof(dataGridViewTextBoxColumn11)].Value.ToString();
                        traer_Tarjas_Vaciados_SecadoTableAdapter.Fill(genesisDataSet1.Traer_Tarjas_Vaciados_Secado, Convert.ToInt16(Lbl_Recepcion.Text));
                        if (dataGridView2.RowCount > 0)
                        {
                            foreach (DataGridViewRow row in dataGridView2.Rows)
                            {
                                acum__neto_Vaciado = acum__neto_Vaciado + Convert.ToDouble(row.Cells[nameof(Peso_Neto_Final)].Value.ToString());
                            }
                            Lbl_Kilos_Vaciados.Text = Math.Round(acum__neto_Vaciado, 2).ToString();
                            Lbl_Total_Vaciados.Text = Lbl_Kilos_Vaciados.Text;
                        }
                        try
                        {
                            this.traer_Tarjas_SecasTableAdapter.Fill(this.genesisDataSet.Traer_Tarjas_Secas, new System.Nullable<short>(((short)(System.Convert.ChangeType(Lbl_Recepcion.Text, typeof(short))))));
                            foreach (DataGridViewRow row in traer_Tarjas_SecasDataGridView.Rows)
                            {
                                acum_neto_Tarjado = acum_neto_Tarjado + Convert.ToDouble(row.Cells[nameof(dataGridViewTextBoxColumn32)].Value.ToString());
                            }

                            Lbl_Neto_tarjado.Text = acum_neto_Tarjado.ToString();
                            Lbl_Total_Secados.Text = Lbl_Neto_tarjado.Text;
                            Porc_Rendimiento.Text = Math.Round(((Convert.ToDouble(Lbl_Total_Secados.Text) / Convert.ToDouble(Lbl_Total_Vaciados.Text)) * 100), 0).ToString();
                            Porc_Merma.Text = (100 - Convert.ToDouble(Porc_Rendimiento.Text)).ToString();
                            Lbl_Merma.Text = (Convert.ToDouble(Lbl_Total_Vaciados.Text) - Convert.ToDouble(Lbl_Total_Secados.Text)).ToString();
                            Esta_Proceso_Secado = 1;
                        }
                        catch (System.Exception ex)
                        {
                            System.Windows.Forms.MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    if ((verificar_Proceso_SecadoDataGridView.RowCount > 0) && (Lbl_Recepcion.Visible == false))
                    {
                        Esta_Proceso_Secado = 0;
                    }
                    else
                    if ((verificar_Proceso_SecadoDataGridView.RowCount > 0) && (Lbl_Recepcion.Visible == true))
                    {
                        Esta_Proceso_Secado = 2;
                    }
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
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
                traer_Tarjas_Vaciados_SecadoTableAdapter.Fill(genesisDataSet1.Traer_Tarjas_Vaciados_Secado, Convert.ToInt16(id));
                Lbl_Tarjas_Totales.Text = dataGridView1.RowCount.ToString();
                label9.Visible = true;
                Lbl_Recepcion.Visible = true;
                Lbl_Recepcion.Text = id.ToString();
                Lbl_Tarjas_Totales.Text = dataGridView1.Rows.Count.ToString();
                Lbl_TarjasVaciadas.Text = dataGridView2.RowCount.ToString();
                Lbl_Tarjas_Seleccionados.Text = "0";
                acum_celda = 0;
                Esta_Proceso_Secado = 1;
                // TODO: esta línea de código carga datos en la tabla 'genesisDataSet.Paso_Recepcion_Secado' Puede moverla o quitarla según sea necesario.
                this.paso_Recepcion_SecadoTableAdapter.InsertPasoRecepcionSecado(id,Convert.ToInt32(comboBox1.Text));
                Kilos_Vacias_entrada.Text = Lbl_Kilos_Vaciados.Text;
            }
            else
             if (Esta_Proceso_Secado == 1)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[nameof(Tarjas_check)].Value) == true)
                    {

                        recepcionesTableAdapter.Proceso_Final_Recepcion(row.Cells[1].Value.ToString(), Convert.ToInt16(Lbl_Recepcion.Text), "SE");
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
                this.paso_Recepcion_SecadoTableAdapter.InsertPasoRecepcionSecado(Convert.ToInt32(Lbl_Recepcion.Text), Convert.ToInt32(comboBox1.Text));

            }
       //     else
       //if (Esta_Proceso_Secado == 2)
       //     {
       //         MessageBox.Show("Entra Ok");
       //     }
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


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           try
            {
                this.traer_Tara_Envases_BaseTableAdapter.Fill(this.genesisDataSet.Traer_Tara_Envases_Base, new System.Nullable<short>(((short)(System.Convert.ChangeType(CmbEnvase.SelectedValue.ToString(), typeof(short))))), new System.Nullable<short>(((short)(System.Convert.ChangeType(CmbBaseBins.SelectedValue.ToString(), typeof(short))))));
                tara_envase = Convert.ToDouble(traer_Tara_Envases_BaseDataGridView.Rows[0].Cells[nameof(dataGridViewTextBoxColumn12)].Value.ToString());
                tara_base = Convert.ToDouble(traer_Tara_Envases_BaseDataGridView.Rows[0].Cells[nameof(dataGridViewTextBoxColumn13)].Value.ToString());
                Kg_Neto.Text = (Convert.ToDouble(Kg_Bruto.Text.Replace('.',',')) - tara_envase - tara_base).ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            acum_neto_Tarjado = 0;
            int tarja = 0;

            try
            {
                if (acceso == 1)
                { tarja = Convert.ToInt32(this.tarja_SecadoTableAdapter.Insertar_Tarja_Secado(Convert.ToInt16(Lbl_Recepcion.Text), Convert.ToInt16(cod_ProductorTextBox.Text), Convert.ToInt16(CmbVariedad.SelectedValue.ToString()), 5, Convert.ToInt16(productosComboBox.SelectedValue.ToString()), Convert.ToInt16(CmbEnvase.SelectedValue.ToString()), 1, tara_envase, Convert.ToInt16(CmbBaseBins.SelectedValue.ToString()), tara_base, Convert.ToDecimal(Kg_Bruto.Text.Replace('.', ',')), Convert.ToDecimal(Kg_Neto.Text), null, null)); }
                else
                if (acceso == 2)
                { tarja = Convert.ToInt32(this.tarja_SecadoTableAdapter.Insertar_Tarja_Secado(Convert.ToInt16(Lbl_Recepcion.Text), Convert.ToInt16(cod_ProductorTextBox.Text), Convert.ToInt16(cod_Variedad), 5, Convert.ToInt16(productosComboBox.SelectedValue.ToString()), Convert.ToInt16(CmbEnvase.SelectedValue.ToString()), 1, tara_envase, Convert.ToInt16(CmbBaseBins.SelectedValue.ToString()), tara_base, Convert.ToDecimal(Kg_Bruto.Text.Replace('.', ',')), Convert.ToDecimal(Kg_Neto.Text), null, null)); }

                 this.traer_Tarjas_SecasTableAdapter.Fill(this.genesisDataSet.Traer_Tarjas_Secas, new System.Nullable<short>(((short)(System.Convert.ChangeType(Lbl_Recepcion.Text, typeof(short))))));

                foreach (DataGridViewRow row in traer_Tarjas_SecasDataGridView.Rows)
                {
                    acum_neto_Tarjado = acum_neto_Tarjado + Convert.ToDouble(row.Cells[nameof(dataGridViewTextBoxColumn32)].Value.ToString());
                }

                Lbl_Neto_tarjado.Text = acum_neto_Tarjado.ToString();
                if (MessageBox.Show("Tarja ingresado correctamente" + Environment.NewLine + "  Desea imprimir la tarja ??", "Anakena", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    InformeTarjaSecado S = new InformeTarjaSecado("SE"+tarja.ToString());
                    S.ShowDialog();
                }
                else
                { }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }


        private void CmbBaseBins_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Kg_Bruto.TextLength > 0)
            {
                this.traer_Tara_Envases_BaseTableAdapter.Fill(this.genesisDataSet.Traer_Tara_Envases_Base, new System.Nullable<short>(((short)(System.Convert.ChangeType(CmbEnvase.SelectedValue.ToString(), typeof(short))))), new System.Nullable<short>(((short)(System.Convert.ChangeType(CmbBaseBins.SelectedValue.ToString(), typeof(short))))));
                tara_envase = Convert.ToDouble(traer_Tara_Envases_BaseDataGridView.Rows[0].Cells[nameof(dataGridViewTextBoxColumn12)].Value.ToString());
                tara_base = Convert.ToDouble(traer_Tara_Envases_BaseDataGridView.Rows[0].Cells[nameof(dataGridViewTextBoxColumn13)].Value.ToString());
                Kg_Neto.Text = (Convert.ToDouble(Kg_Bruto.Text.Replace('.', ',')) - tara_envase - tara_base).ToString();
            }
        }

        private void CmbEnvase_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Kg_Bruto.TextLength > 0)
            {
                this.traer_Tara_Envases_BaseTableAdapter.Fill(this.genesisDataSet.Traer_Tara_Envases_Base, new System.Nullable<short>(((short)(System.Convert.ChangeType(CmbEnvase.SelectedValue.ToString(), typeof(short))))), new System.Nullable<short>(((short)(System.Convert.ChangeType(CmbBaseBins.SelectedValue.ToString(), typeof(short))))));
                tara_envase = Convert.ToDouble(traer_Tara_Envases_BaseDataGridView.Rows[0].Cells[nameof(dataGridViewTextBoxColumn12)].Value.ToString());
                tara_base = Convert.ToDouble(traer_Tara_Envases_BaseDataGridView.Rows[0].Cells[nameof(dataGridViewTextBoxColumn13)].Value.ToString());
                Kg_Neto.Text = (Convert.ToDouble(Kg_Bruto.Text.Replace('.', ',')) - tara_envase - tara_base).ToString();
            }
        }

        private void traer_Tarjas_SecasDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 20)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w =35;
                var h =16;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2 ;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                
                e.Graphics.DrawImage(Properties.Resources.Print2, new Rectangle(x, y, w, h));
                e.Handled = true;            
            }
        }

        private void traer_Tarjas_SecasDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int fila = e.RowIndex;
            int columna = e.ColumnIndex;
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 20)
            {
                InformeTarjaSecado S = new InformeTarjaSecado(traer_Tarjas_SecasDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn16)].Value.ToString());
                S.ShowDialog();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Lbl_Diferencia.Text == "0")
            {
                if (traer_Tarjas_SecasDataGridView.RowCount > 0)
                {
                    try
                    {
                             this.secadoTableAdapter.Cierre_Proceso_Secado(1,Convert.ToInt32(Lbl_Recepcion.Text));
                              MessageBox.Show("Proceso cerrado correctamente","Anakena",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    catch (Exception) { }
                   
                }
                else
                {
                    MessageBox.Show("Falta tarjas por vacias en algun lote de recepcion ", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Falta tarjas por vacias en algun lote de recepcion ","Anakena",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
