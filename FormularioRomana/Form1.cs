using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioRomana
{
    public partial class Form1 : Form
    {
        int cantidad_acum = 0;
        int cantidad = 0;
        int recepciones = 0;
        short productor = 0;
        short envases = 0;
        short bases_pallet = 0;
        int id = 0;
        int bultos;
        int btn_envases = 0;
        int btn_calidad = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
             Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.Gray, 1);
            gfx.DrawLine(p, 0, 5, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, 0, 5, 10, 5);
            gfx.DrawLine(p, 62, 5, e.ClipRectangle.Width - 2, 5);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2);
            }
            catch (Exception)
            {

              //  throw;
            }
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
   
            
            // TODO: esta línea de código carga datos en la tabla 'genesisDataSet.Traer_Resumen_Recepcion' Puede moverla o quitarla según sea necesario.
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;


            this.romanaTableAdapter.Fill(this.genesisDataSet.Romana);
            try
            {
                this.estadosTableAdapter.FiltroEstadoByProceso(this.genesisDataSet.Estados); //Trae los datos de los estados en base a Codigo de proceso
                this.productoTableAdapter.FiltroProductoByEstado(this.genesisDataSet.Producto, 1);
                this.productoresTableAdapter.Fill(this.genesisDataSet.Productores);
                this.variedadTableAdapter.Fill(this.genesisDataSet.Variedad);
                this.basesPalletTableAdapter.Fill(this.genesisDataSet1.BasesPallet);
                CmbBaseBins.SelectedIndex = 2;
                traer_Envases_ProcesoTableAdapter.Fill(genesisDataSet.Traer_Envases_Proceso,Convert.ToInt16(1));
                productosComboBox.Enabled = false;
                cod_ProductorTextBox.Text = "1";
             
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            
        }
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {

                Boolean is_numero = int.TryParse(TxtBultos.Text, out bultos);
                if ((TxtBultos.Text.Length > 0) && (Txt_NumGuia.Text.Length > 0) && (is_numero))
                {

                    if ((comboBox2.Text == "Con Pelón") || ((comboBox2.Text == "Seca") && (bultos <= 24)))
                    {
                        id = Convert.ToInt32(recepcionesTableAdapter1.Insertar_Recepciones(Convert.ToInt16(cod_ProductorTextBox.Text), Convert.ToInt16(comboBox3.SelectedValue.ToString()), Convert.ToInt16(comboBox2.SelectedValue.ToString()), Convert.ToInt16(productosComboBox.SelectedValue.ToString()), Txt_NumGuia.Text, bultos, "16448502-1"));
                        MessageBox.Show("Recepción ingresada", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        groupBox1.Enabled = false;
                        tabControl1.Visible = true;
                        label1.Visible = true;
                        Lbl_Recepcion.Visible = true;
                        Lbl_Recepcion.Text = id.ToString();
                        if (comboBox2.Text == "Con Pelón")
                        {
                            try
                            {
                                tabControl1.Controls.Remove(tabControl1.TabPages["tabPage4"]);
                                tabControl1.Controls.Remove(tabControl1.TabPages["tabPage3"]);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        if (comboBox2.Text == "Seca")
                        {
                            try
                            {
                                tabControl1.Controls.Remove(tabControl1.TabPages["tabPage4"]);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                    }
                    else
                    if (comboBox2.Text == "Seca")
                    {
                        double pesajes = 0;
                        groupBox1.Enabled = false;
                        if (bultos > 24 && bultos <= 50)
                        {
                            pesajes = 2;
                        }
                        else
                        if (bultos > 51 && bultos <= 75)
                        {
                            pesajes = 3;
                        }
                        else
                        if (bultos > 76 && bultos <= 80)
                        {
                            pesajes = 4;
                        }
                        if (bultos <= 80)
                        {
                            tabControl1.TabPages[1].Text = "Descripcion de Envases";
                            if (bultos % pesajes == 0)
                            {
                                int aux = Convert.ToInt32(bultos / pesajes);
                                for (int i = 0; i < pesajes; i++)
                                {
                                    id = Convert.ToInt32(recepcionesTableAdapter1.Insertar_Recepciones(Convert.ToInt16(cod_ProductorTextBox.Text), Convert.ToInt16(comboBox3.SelectedValue.ToString()), Convert.ToInt16(comboBox2.SelectedValue.ToString()), Convert.ToInt16(productosComboBox.SelectedValue.ToString()), Txt_NumGuia.Text, aux, "16448502-1"));
                                }

                                MessageBox.Show("Se han ingresado : " + (pesajes).ToString() + " De " + (aux).ToString());
                                traer_Resumen_RecepcionTableAdapter.Fill(genesisDataSet.Traer_Resumen_Recepcion, Convert.ToInt16(cod_ProductorTextBox.Text), Convert.ToInt16(comboBox3.SelectedValue.ToString()), Convert.ToInt16(comboBox2.SelectedValue.ToString()), Txt_NumGuia.Text);
                                tabControl1.Visible = true;
                            }
                            else
                            {
                                int aux = Convert.ToInt32(bultos / pesajes);
                                int aux1 = Convert.ToInt32((aux * (pesajes - 1)));
                                int aux2 = Convert.ToInt32(bultos - aux1);

                                for (int i = 0; i < pesajes - 1; i++)
                                {
                                    id = Convert.ToInt32(recepcionesTableAdapter1.Insertar_Recepciones(Convert.ToInt16(cod_ProductorTextBox.Text), Convert.ToInt16(comboBox3.SelectedValue.ToString()), Convert.ToInt16(comboBox2.SelectedValue.ToString()), Convert.ToInt16(productosComboBox.SelectedValue.ToString()), Txt_NumGuia.Text, aux, "16448502-1"));
                                }

                                id = Convert.ToInt32(recepcionesTableAdapter1.Insertar_Recepciones(Convert.ToInt16(cod_ProductorTextBox.Text), Convert.ToInt16(comboBox3.SelectedValue.ToString()), Convert.ToInt16(comboBox2.SelectedValue.ToString()), Convert.ToInt16(productosComboBox.SelectedValue.ToString()), Txt_NumGuia.Text, aux2, "16448502-1"));
                                MessageBox.Show("Se han ingresado : " + (pesajes - 1).ToString() + " Pesajes De " + (aux).ToString() + " bultos 1 Pesaje de " + aux2 + " Bultos");
                                traer_Resumen_RecepcionTableAdapter.Fill(genesisDataSet.Traer_Resumen_Recepcion, Convert.ToInt16(cod_ProductorTextBox.Text), Convert.ToInt16(comboBox3.SelectedValue.ToString()), Convert.ToInt16(comboBox2.SelectedValue.ToString()), Txt_NumGuia.Text);
                                tabControl1.Visible = true;
                            }
                            groupBox3.Visible = false;
                            traer_Resumen_RecepcionDataGridView.Visible = false;

                            tabControl1.Controls.Remove(tabControl1.TabPages["tabPage1"]);
                            tabControl1.Controls.Remove(tabControl1.TabPages["tabPage2"]);
                            tabControl1.Controls.Remove(tabControl1.TabPages["tabPage3"]);
                            int Num_proceso = traer_Resumen_RecepcionDataGridView.RowCount;

                            if (Num_proceso == 2)
                            {
                                panel1.Visible = true;
                                panel2.Visible = true;
                                LblRecepcion1.Text = traer_Resumen_RecepcionDataGridView.Rows[0].Cells[nameof(dataGridViewTextBoxColumn11)].Value.ToString();
                                LblRecepcion2.Text = traer_Resumen_RecepcionDataGridView.Rows[1].Cells[nameof(dataGridViewTextBoxColumn11)].Value.ToString();
                                LblBultos1.Text = "Bultos : " + traer_Resumen_RecepcionDataGridView.Rows[0].Cells[nameof(dataGridViewTextBoxColumn21)].Value.ToString();
                                LblBultos2.Text = "Bultos : " + traer_Resumen_RecepcionDataGridView.Rows[1].Cells[nameof(dataGridViewTextBoxColumn21)].Value.ToString();
                            }
                            else
                            if (Num_proceso == 3)
                            {
                                panel1.Visible = true;
                                panel2.Visible = true;
                                panel3.Visible = true;
                                LblRecepcion1.Text = traer_Resumen_RecepcionDataGridView.Rows[0].Cells[nameof(dataGridViewTextBoxColumn11)].Value.ToString();
                                LblRecepcion2.Text = traer_Resumen_RecepcionDataGridView.Rows[1].Cells[nameof(dataGridViewTextBoxColumn11)].Value.ToString();
                                LblRecepcion3.Text = traer_Resumen_RecepcionDataGridView.Rows[2].Cells[nameof(dataGridViewTextBoxColumn11)].Value.ToString();
                                LblBultos1.Text = "Bultos : " + traer_Resumen_RecepcionDataGridView.Rows[0].Cells[nameof(dataGridViewTextBoxColumn21)].Value.ToString();
                                LblBultos2.Text = "Bultos : " + traer_Resumen_RecepcionDataGridView.Rows[1].Cells[nameof(dataGridViewTextBoxColumn21)].Value.ToString();
                                LblBultos3.Text = "Bultos : " + traer_Resumen_RecepcionDataGridView.Rows[2].Cells[nameof(dataGridViewTextBoxColumn21)].Value.ToString();
                            }
                            else
                            if (Num_proceso == 4)
                            {
                                panel1.Visible = true;
                                panel2.Visible = true;
                                panel3.Visible = true;
                                panel4.Visible = true;
                                LblRecepcion1.Text = traer_Resumen_RecepcionDataGridView.Rows[0].Cells[nameof(dataGridViewTextBoxColumn11)].Value.ToString();
                                LblRecepcion2.Text = traer_Resumen_RecepcionDataGridView.Rows[1].Cells[nameof(dataGridViewTextBoxColumn11)].Value.ToString();
                                LblRecepcion3.Text = traer_Resumen_RecepcionDataGridView.Rows[2].Cells[nameof(dataGridViewTextBoxColumn11)].Value.ToString();
                                LblRecepcion4.Text = traer_Resumen_RecepcionDataGridView.Rows[3].Cells[nameof(dataGridViewTextBoxColumn11)].Value.ToString();
                                LblBultos1.Text = "Bultos : " + traer_Resumen_RecepcionDataGridView.Rows[0].Cells[nameof(dataGridViewTextBoxColumn21)].Value.ToString();
                                LblBultos2.Text = "Bultos : " + traer_Resumen_RecepcionDataGridView.Rows[1].Cells[nameof(dataGridViewTextBoxColumn21)].Value.ToString();
                                LblBultos3.Text = "Bultos : " + traer_Resumen_RecepcionDataGridView.Rows[2].Cells[nameof(dataGridViewTextBoxColumn21)].Value.ToString();
                                LblBultos4.Text = "Bultos : " + traer_Resumen_RecepcionDataGridView.Rows[3].Cells[nameof(dataGridViewTextBoxColumn21)].Value.ToString();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Debe ingresar numero de guia y/0 bultos al sistema", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(comboBox2.Text != "")
                this.productoTableAdapter.FiltroProductoByEstado(this.genesisDataSet.Producto,Convert.ToInt16(comboBox2.SelectedValue.ToString()));            
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
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

        private void cod_ProductorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            short productor = 0;
            Boolean Isnum = short.TryParse(cod_ProductorTextBox.Text,out productor);
            if(Isnum)
            {
            productoresTableAdapter.FiltroProductorByCodigo(genesisDataSet.Productores, productor);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int bultos = Convert.ToInt32(TxtBultos.Text);
            bool isnumber = Int32.TryParse(Txt_Cantidad.Text,out cantidad);
            cantidad_acum +=cantidad;
            if (isnumber)
            {
                if (cantidad_acum <= bultos)
                {
                    try
                    {
                        this.detalleRecepcionesTableAdapter.InsertarDetalleRecepciones(Convert.ToInt32(Lbl_Recepcion.Text), Convert.ToInt16(cod_ProductorTextBox.Text), Txt_NumGuia.Text,cantidad, Convert.ToInt16(CmbEnvase.SelectedValue.ToString()), Convert.ToInt16(CmbBaseBins.SelectedValue.ToString()));//insertar datos a tabla DetalleRecepciones
                        this.traer_Detalle_RecepcionTableAdapter.Fill(this.genesisDataSet.Traer_Detalle_Recepcion, new System.Nullable<int>(((int)(System.Convert.ChangeType(Lbl_Recepcion.Text, typeof(int))))), new System.Nullable<short>(((short)(System.Convert.ChangeType(cod_ProductorTextBox.Text, typeof(short))))), Txt_NumGuia.Text);//Trae datos de procedimiento almacenado traer_Detalle_Recepcion
                        LblCantidadEnvases.Text = num_envases().ToString();
                        for (int i = 0; i < cantidad; i++)
                        {         
                          this.tarja_RecepcionTableAdapter.Insertar_Tarja_Recepcion(Convert.ToInt16(Lbl_Recepcion.Text),Convert.ToInt16(cod_ProductorTextBox.Text),Convert.ToInt16(comboBox3.SelectedValue.ToString()),Convert.ToInt16(comboBox2.SelectedValue.ToString()),Convert.ToInt16(productosComboBox.SelectedValue.ToString()),Convert.ToInt16(CmbEnvase.SelectedValue.ToString()),1,23.5,Convert.ToInt16(CmbBaseBins.SelectedValue.ToString()),25.5,null,null,null,null,null);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message,"Anakena",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        cantidad_acum = cantidad_acum - cantidad;
                    }
                  
                }
                else
                {
                    cantidad_acum = cantidad_acum - cantidad;
                    MessageBox.Show("La cantidad de envases no puede ser mayor a los bultos", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("La cantidad de envases debe ser mayor a 0", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                Txt_Peso_Bruto.Text = (Convert.ToInt32(Txt_Con_Carga.Text) - Convert.ToInt32(Txt_Sin_Carga.Text)).ToString();
                this.romanaTableAdapter.Insertar_Romana(Convert.ToInt32(Lbl_Recepcion.Text), Convert.ToInt16(cod_ProductorTextBox.Text), Txt_NumGuia.Text, Convert.ToInt32(Txt_Con_Carga.Text), Convert.ToInt32(Txt_Sin_Carga.Text), Convert.ToInt32(Txt_Peso_Bruto.Text));
                MessageBox.Show("Datos de romana ingresados o actualizados correctamente");
                Btn_Romana.Enabled = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TxtBultos.Text) == Convert.ToInt32(LblCantidadEnvases.Text))
            {
                Printing();
            }
            else
            { MessageBox.Show("No se puede imprimir ", "Anakena"); }
        }

        private void traer_Detalle_RecepcionDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                recepciones = Convert.ToInt32(traer_Detalle_RecepcionDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value.ToString());
                productor = Convert.ToInt16(traer_Detalle_RecepcionDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value.ToString());
                envases = Convert.ToInt16(traer_Detalle_RecepcionDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn6"].Value.ToString());
                bases_pallet = Convert.ToInt16(traer_Detalle_RecepcionDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn8"].Value.ToString());
                cantidad = Convert.ToInt32(traer_Detalle_RecepcionDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"].Value.ToString());
            }
            catch (Exception)
            {
            }
    
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                 detalleRecepcionesTableAdapter.BorrarDetalle_Recepcion(recepciones,productor,envases,bases_pallet);
                this.traer_Detalle_RecepcionTableAdapter.Fill(this.genesisDataSet.Traer_Detalle_Recepcion, new System.Nullable<int>(((int)(System.Convert.ChangeType(Lbl_Recepcion.Text, typeof(int))))), new System.Nullable<short>(((short)(System.Convert.ChangeType(cod_ProductorTextBox.Text, typeof(short))))), Txt_NumGuia.Text);
                cantidad_acum = cantidad_acum - cantidad;
                LblCantidadEnvases.Text = cantidad_acum.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Anakena",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        public void Printing()
        {
            try
            {
                PrintDialog x = new PrintDialog();
                if (x.ShowDialog() == DialogResult.OK)
                {
                    string selectedPrinter = x.PrinterSettings.PrinterName;
                  
                }
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(documentoAimprimir);
                // Especifica que impresora se utilizara!!
                pd.PrinterSettings.PrinterName = x.PrinterSettings.PrinterName;
                PageSettings pa = new PageSettings();
                pa.Margins = new Margins(0, 0, 0, 0);
                pd.DefaultPageSettings.Margins = pa.Margins;
                PaperSize ps = new PaperSize("Custom", 200, 112);
                pd.DefaultPageSettings.PaperSize = ps;
                pd.Print();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Printing " + exp.Message);
            }
        }
        private void documentoAimprimir(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {

                using (Graphics g = e.Graphics)
                {
                    using (Font fnt = new Font("Arial", 6))//Formato
                    {
                        string caption = string.Format("Titulo1:{0}","Prueba");//Texto de la etiqueta
                        g.DrawString(caption, fnt, System.Drawing.Brushes.Black, 5, 20);//posicion del texto
                        caption = string.Format("Titulo2:{0}","Texto2");
                        g.DrawString(caption, fnt, System.Drawing.Brushes.Black, 50, 20);
                        caption = string.Format("Titulo3:{0}","Texto3");
                        g.DrawString(caption, fnt, System.Drawing.Brushes.Black, 5, 31);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Printpage" + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Txt_Peso_Bruto.Text = (Convert.ToInt32(Txt_Con_Carga.Text) - Convert.ToInt32(Txt_Sin_Carga.Text)).ToString();
                this.romanaTableAdapter.Insertar_Romana(Convert.ToInt32(Lbl_Recepcion.Text), Convert.ToInt16(cod_ProductorTextBox.Text), Txt_NumGuia.Text, Convert.ToInt32(Txt_Con_Carga.Text), Convert.ToInt32(Txt_Sin_Carga.Text), Convert.ToInt32(Txt_Peso_Bruto.Text));
                MessageBox.Show("Datos de romana ingresados o actualizados correctamente");
                Btn_Romana.Enabled = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                tarja_RecepcionTableAdapter.sp_llenar_peso_recepcion(Convert.ToInt32(Lbl_Recepcion.Text),bultos);
                Informe_Recepcion x = new Informe_Recepcion(id);
                x.ShowDialog();
                MessageBox.Show("recepción formalizada correctamente", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Anakena", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
          
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
               this.humedad_RecepcionTableAdapter.Insertar_Humedad_Recepcion(Convert.ToInt16(Lbl_Recepcion.Text),Convert.ToDecimal(Txt_Humedad.Text.Replace('.',',')));
              //  Txt_Humedad.ReadOnly = true;
                MessageBox.Show("Humedad ingresada correctamente","Anakena",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormBusquedaProductores rc = new FormBusquedaProductores();
            rc.ShowDialog();
            if (rc.codigo.ToString() !=  "0")
            {
                cod_ProductorTextBox.Text = rc.codigo.ToString();
                productoresTableAdapter.FiltroProductorByCodigo(genesisDataSet.Productores, (short)rc.codigo);
            }
            else
            {
                MessageBox.Show("Debe seleccionar algun productor", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.productoresTableAdapter.Fill(this.genesisDataSet.Productores);
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

        private void button13_Click_1(object sender, EventArgs e)
        {
            InformeRomana r = new InformeRomana(id);
            r.ShowDialog();
        }

        private void traer_Resumen_RecepcionDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cantidad = 0;
            Lbl_Recepcion.Text = traer_Resumen_RecepcionDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn11)].Value.ToString();
            TxtBultos.Text = traer_Resumen_RecepcionDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn21)].Value.ToString();
            this.traer_Detalle_RecepcionTableAdapter.Fill(this.genesisDataSet.Traer_Detalle_Recepcion, new System.Nullable<int>(((int)(System.Convert.ChangeType(Lbl_Recepcion.Text, typeof(int))))), new System.Nullable<short>(((short)(System.Convert.ChangeType(cod_ProductorTextBox.Text, typeof(short))))), Txt_NumGuia.Text);
            label1.Visible = true;
            Lbl_Recepcion.Visible = true;
            LblCantidadEnvases.Text = num_envases().ToString();
            tabControl1.SelectedIndex = 1;
            
        }
        public int num_envases()
        {
            int acum = 0;
            for(int i = 0;i < traer_Detalle_RecepcionDataGridView.RowCount;i++)
            {
                acum = acum + Convert.ToInt32(traer_Detalle_RecepcionDataGridView.Rows[i].Cells[nameof(dataGridViewTextBoxColumn5)].Value.ToString());
            }
            return acum;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            try
            {
                if (Convert.ToInt32(Txt_Con_Carga2.Text) > Convert.ToInt32(Txt_Sin_Carga2.Text))
                {
                    Txt_Peso_Bruto2.Text = (Convert.ToInt32(Txt_Con_Carga2.Text) - Convert.ToInt32(Txt_Sin_Carga2.Text)).ToString();
                    romana_SecaTableAdapter.InsertarRomanaSeca(Convert.ToInt16(cod_ProductorTextBox.Text), Txt_NumGuia.Text, Convert.ToInt32(Txt_Con_Carga2.Text), Convert.ToInt32(Txt_Sin_Carga2.Text), Convert.ToInt32(Txt_Peso_Bruto2.Text));
                    double Envase_c_carga = 0;
                    double Acum_c_carga = 0;
                    double Envase_s_carga = 0;
                    double Acum_s_carga = 0;
                    double envase_bruto = 0;
                    double acum_bruto = 0;
                    Envase_c_carga = Convert.ToDouble(Txt_Con_Carga2.Text) / bultos;
                    Envase_s_carga = Convert.ToDouble(Txt_Sin_Carga2.Text) / bultos;
                    envase_bruto = Envase_c_carga - Envase_s_carga;
                    for (int i = 0; i < traer_Resumen_RecepcionDataGridView.RowCount; i++)
                    {
                        Acum_c_carga = Acum_c_carga + Convert.ToInt32(Convert.ToDouble(traer_Resumen_RecepcionDataGridView.Rows[i].Cells[nameof(dataGridViewTextBoxColumn21)].Value.ToString()) * Envase_c_carga);
                        Acum_s_carga = Acum_s_carga + Convert.ToInt32(Convert.ToDouble(traer_Resumen_RecepcionDataGridView.Rows[i].Cells[nameof(dataGridViewTextBoxColumn21)].Value.ToString()) * Envase_s_carga);
                        acum_bruto = acum_bruto + Convert.ToInt32(Convert.ToDouble(traer_Resumen_RecepcionDataGridView.Rows[i].Cells[nameof(dataGridViewTextBoxColumn21)].Value.ToString()) * envase_bruto);
                        if (i != traer_Resumen_RecepcionDataGridView.RowCount - 1)
                        {
                            this.romanaTableAdapter.Insertar_Romana(Convert.ToInt32(traer_Resumen_RecepcionDataGridView.Rows[i].Cells[nameof(dataGridViewTextBoxColumn11)].Value.ToString()), Convert.ToInt16(cod_ProductorTextBox.Text), Txt_NumGuia.Text, Convert.ToInt32(Convert.ToDouble(traer_Resumen_RecepcionDataGridView.Rows[i].Cells[nameof(dataGridViewTextBoxColumn21)].Value.ToString()) * Envase_c_carga), Convert.ToInt32(Convert.ToDouble(traer_Resumen_RecepcionDataGridView.Rows[i].Cells[nameof(dataGridViewTextBoxColumn21)].Value.ToString()) * Envase_s_carga), Convert.ToInt32(Convert.ToDouble(traer_Resumen_RecepcionDataGridView.Rows[i].Cells[nameof(dataGridViewTextBoxColumn21)].Value.ToString()) * envase_bruto));
                        }
                        else
                        {
                            resultado = this.romanaTableAdapter.Insertar_Romana(Convert.ToInt32(traer_Resumen_RecepcionDataGridView.Rows[i].Cells[nameof(dataGridViewTextBoxColumn11)].Value.ToString()), Convert.ToInt16(cod_ProductorTextBox.Text), Txt_NumGuia.Text, (Convert.ToInt32(Convert.ToDouble(traer_Resumen_RecepcionDataGridView.Rows[i].Cells[nameof(dataGridViewTextBoxColumn21)].Value.ToString()) * Envase_c_carga)) + Convert.ToInt32((Convert.ToInt32(Txt_Con_Carga2.Text) - Acum_c_carga)), Convert.ToInt32(Convert.ToDouble(traer_Resumen_RecepcionDataGridView.Rows[i].Cells[nameof(dataGridViewTextBoxColumn21)].Value.ToString()) * Envase_s_carga) + Convert.ToInt32(Convert.ToInt32(Txt_Sin_Carga2.Text) - Acum_s_carga), Convert.ToInt32(Convert.ToDouble(traer_Resumen_RecepcionDataGridView.Rows[i].Cells[nameof(dataGridViewTextBoxColumn21)].Value.ToString()) * envase_bruto) + Convert.ToInt32(Convert.ToInt32(Txt_Peso_Bruto2.Text) - acum_bruto));
                        }
                    }

                    MessageBox.Show("Datos de romana ingresados o actualizados correctamente", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Btn_Romana2.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Pesaje sin carga no puede ser mayor al pesaje sin carga", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btn_envases = 1;
   
            Lbl_Recepcion.Text = LblRecepcion1.Text;
            TxtBultos.Text = traer_Resumen_RecepcionDataGridView.Rows[0].Cells[nameof(dataGridViewTextBoxColumn21)].Value.ToString();
            this.traer_Detalle_RecepcionTableAdapter.Fill(this.genesisDataSet.Traer_Detalle_Recepcion, new System.Nullable<int>(((int)(System.Convert.ChangeType(Lbl_Recepcion.Text, typeof(int))))), new System.Nullable<short>(((short)(System.Convert.ChangeType(cod_ProductorTextBox.Text, typeof(short))))), Txt_NumGuia.Text);
            label1.Visible = true;
            Lbl_Recepcion.Visible = true;
            LblCantidadEnvases.Text = num_envases().ToString();
            cantidad_acum = num_envases();
            tabControl1.TabPages.Add(tabPage1);
            tabControl1.TabPages.Remove(tabPage4);
            Btn_Back.Visible = true;
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage4);
            tabControl1.TabPages.Remove(tabPage1);
            if (btn_envases == 1)
            {
                if ((traer_Detalle_RecepcionDataGridView.RowCount > 0) && (TxtBultos.Text == LblCantidadEnvases.Text))
                {
                    button4.BackColor = Color.MediumSeaGreen;
                }
                else
                if ((traer_Detalle_RecepcionDataGridView.RowCount > 0) && (TxtBultos.Text != LblCantidadEnvases.Text))
                {
                    button4.BackColor = Color.DarkGoldenrod;
                }
                else
                {
                    button4.BackColor = Color.IndianRed;
                }
            }
            else
            if (btn_envases == 2)
            {
                if ((traer_Detalle_RecepcionDataGridView.RowCount > 0) && (TxtBultos.Text == LblCantidadEnvases.Text))
                {
                    button17.BackColor = Color.MediumSeaGreen;
                }
                else
                if ((traer_Detalle_RecepcionDataGridView.RowCount > 0) && (TxtBultos.Text != LblCantidadEnvases.Text))
                {
                    button17.BackColor = Color.DarkGoldenrod;
                }
                else
                {
                    button17.BackColor = Color.IndianRed;
                }
            }
            else
            if (btn_envases == 3)
            {
                if ((traer_Detalle_RecepcionDataGridView.RowCount > 0) && (TxtBultos.Text == LblCantidadEnvases.Text))
                {
                    button20.BackColor = Color.MediumSeaGreen;
                }
                else
                if ((traer_Detalle_RecepcionDataGridView.RowCount > 0) && (TxtBultos.Text != LblCantidadEnvases.Text))
                {
                    button20.BackColor = Color.DarkGoldenrod;
                }
                else
                {
                    button20.BackColor = Color.IndianRed;
                }
            }
            else
            if (btn_envases == 4)
            {
                if ((traer_Detalle_RecepcionDataGridView.RowCount > 0) && (TxtBultos.Text == LblCantidadEnvases.Text))
                {
                    button23.BackColor = Color.MediumSeaGreen;
                }
                else
                if ((traer_Detalle_RecepcionDataGridView.RowCount > 0) && (TxtBultos.Text != LblCantidadEnvases.Text))
                {
                    button23.BackColor = Color.DarkGoldenrod;
                }
                else
                {
                    button23.BackColor = Color.IndianRed;
                }
            }
            Txt_Cantidad.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            btn_envases = 2;
      
            Lbl_Recepcion.Text = LblRecepcion2.Text;
            TxtBultos.Text = traer_Resumen_RecepcionDataGridView.Rows[1].Cells[nameof(dataGridViewTextBoxColumn21)].Value.ToString();
            this.traer_Detalle_RecepcionTableAdapter.Fill(this.genesisDataSet.Traer_Detalle_Recepcion, new System.Nullable<int>(((int)(System.Convert.ChangeType(Lbl_Recepcion.Text, typeof(int))))), new System.Nullable<short>(((short)(System.Convert.ChangeType(cod_ProductorTextBox.Text, typeof(short))))), Txt_NumGuia.Text);
            label1.Visible = true;
            Lbl_Recepcion.Visible = true;
            LblCantidadEnvases.Text = num_envases().ToString();
            cantidad_acum = num_envases();
            tabControl1.TabPages.Add(tabPage1);
            tabControl1.TabPages.Remove(tabPage4);
            Btn_Back.Visible = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            btn_envases = 3;
            Lbl_Recepcion.Text = LblRecepcion3.Text;
            TxtBultos.Text = traer_Resumen_RecepcionDataGridView.Rows[2].Cells[nameof(dataGridViewTextBoxColumn21)].Value.ToString();
            this.traer_Detalle_RecepcionTableAdapter.Fill(this.genesisDataSet.Traer_Detalle_Recepcion, new System.Nullable<int>(((int)(System.Convert.ChangeType(Lbl_Recepcion.Text, typeof(int))))), new System.Nullable<short>(((short)(System.Convert.ChangeType(cod_ProductorTextBox.Text, typeof(short))))), Txt_NumGuia.Text);
            label1.Visible = true;
            Lbl_Recepcion.Visible = true;
            LblCantidadEnvases.Text = num_envases().ToString();
            cantidad_acum = num_envases();
            tabControl1.TabPages.Add(tabPage1);
            tabControl1.TabPages.Remove(tabPage4);
            Btn_Back.Visible = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            btn_envases = 4;
            Lbl_Recepcion.Text = LblRecepcion4.Text;
            TxtBultos.Text = traer_Resumen_RecepcionDataGridView.Rows[3].Cells[nameof(dataGridViewTextBoxColumn21)].Value.ToString();
            this.traer_Detalle_RecepcionTableAdapter.Fill(this.genesisDataSet.Traer_Detalle_Recepcion, new System.Nullable<int>(((int)(System.Convert.ChangeType(Lbl_Recepcion.Text, typeof(int))))), new System.Nullable<short>(((short)(System.Convert.ChangeType(cod_ProductorTextBox.Text, typeof(short))))), Txt_NumGuia.Text);
            label1.Visible = true;
            Lbl_Recepcion.Visible = true;
            LblCantidadEnvases.Text = num_envases().ToString();
            cantidad_acum = num_envases();
            tabControl1.TabPages.Add(tabPage1);
            tabControl1.TabPages.Remove(tabPage4);
            Btn_Back.Visible = true;
        }

        private void button13_Click_2(object sender, EventArgs e)
        {
            btn_calidad = 1;
            Lbl_Recepcion.Text = LblRecepcion1.Text;
            TxtBultos.Text = traer_Resumen_RecepcionDataGridView.Rows[0].Cells[nameof(dataGridViewTextBoxColumn21)].Value.ToString();
            humedad_RecepcionTableAdapter.FillByProceso(genesisDataSet.Humedad_Recepcion, Convert.ToInt16(LblRecepcion1.Text));
            Txt_Humedad.Text = humedad_RecepcionDataGridView.RowCount > 0 ? humedad_RecepcionDataGridView.Rows[0].Cells[nameof(dataGridViewTextBoxColumn30)].Value.ToString() : "0,0";
            label1.Visible = true;
            Lbl_Recepcion.Visible = true;
            tabControl1.TabPages.Add(tabPage3);
            tabControl1.TabPages.Remove(tabPage4);
            Btn_Back_Calidad.Visible = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            btn_calidad = 2;
            Lbl_Recepcion.Text = LblRecepcion2.Text;
            TxtBultos.Text = traer_Resumen_RecepcionDataGridView.Rows[1].Cells[nameof(dataGridViewTextBoxColumn21)].Value.ToString();
            humedad_RecepcionTableAdapter.FillByProceso(genesisDataSet.Humedad_Recepcion, Convert.ToInt16(LblRecepcion2.Text));
            Txt_Humedad.Text = humedad_RecepcionDataGridView.RowCount > 0 ? humedad_RecepcionDataGridView.Rows[0].Cells[nameof(dataGridViewTextBoxColumn30)].Value.ToString() : "0,0";
            label1.Visible = true;
            Lbl_Recepcion.Visible = true;
            tabControl1.TabPages.Add(tabPage3);
            tabControl1.TabPages.Remove(tabPage4);
            Btn_Back_Calidad.Visible = true;

        }

        private void button19_Click(object sender, EventArgs e)
        {
            btn_calidad = 3;
            Lbl_Recepcion.Text = LblRecepcion3.Text;
            TxtBultos.Text = traer_Resumen_RecepcionDataGridView.Rows[2].Cells[nameof(dataGridViewTextBoxColumn21)].Value.ToString();
            humedad_RecepcionTableAdapter.FillByProceso(genesisDataSet.Humedad_Recepcion, Convert.ToInt16(LblRecepcion3.Text));
            Txt_Humedad.Text = humedad_RecepcionDataGridView.RowCount > 0 ? humedad_RecepcionDataGridView.Rows[0].Cells[nameof(dataGridViewTextBoxColumn30)].Value.ToString() : "0,0";
            label1.Visible = true;
            Lbl_Recepcion.Visible = true;
            tabControl1.TabPages.Add(tabPage3);
            tabControl1.TabPages.Remove(tabPage4);
            Btn_Back_Calidad.Visible = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            btn_calidad = 4;
            Lbl_Recepcion.Text = LblRecepcion4.Text;
            TxtBultos.Text = traer_Resumen_RecepcionDataGridView.Rows[3].Cells[nameof(dataGridViewTextBoxColumn21)].Value.ToString();
            humedad_RecepcionTableAdapter.FillByProceso(genesisDataSet.Humedad_Recepcion, Convert.ToInt16(LblRecepcion4.Text));
            Txt_Humedad.Text = humedad_RecepcionDataGridView.RowCount > 0 ? humedad_RecepcionDataGridView.Rows[0].Cells[nameof(dataGridViewTextBoxColumn30)].Value.ToString() : "0,0";
            label1.Visible = true;
            Lbl_Recepcion.Visible = true;
            tabControl1.TabPages.Add(tabPage3);
            tabControl1.TabPages.Remove(tabPage4);
            Btn_Back_Calidad.Visible = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage4);
            tabControl1.TabPages.Remove(tabPage3);
            double humedad;
            double.TryParse(Txt_Humedad.Text, out humedad);
            if (humedad > 0) { button13.BackColor = Color.MediumSeaGreen; } else { button13.BackColor = Color.IndianRed; }
            if (btn_calidad == 1)
            {
                if (humedad > 0) { button13.BackColor = Color.MediumSeaGreen; } else { button13.BackColor = Color.IndianRed; }
            }
            else
            if (btn_calidad == 2)
            {
                if (humedad > 0) { button16.BackColor = Color.MediumSeaGreen; } else { button16.BackColor = Color.IndianRed; }
            }
            else
            if (btn_calidad == 3)
            {
                if (humedad > 0) { button19.BackColor = Color.MediumSeaGreen; } else { button19.BackColor = Color.IndianRed; }
            }
            else
            if (btn_calidad == 4)
            {
                if (humedad > 0) { button22.BackColor = Color.MediumSeaGreen; } else { button22.BackColor = Color.IndianRed; }
            }
        }

        private void Btn_Romana2_Click(object sender, EventArgs e)
        {
            InformeRomana2 rom = new InformeRomana2(Convert.ToInt32(cod_ProductorTextBox.Text),Convert.ToInt32(Txt_NumGuia.Text));
            rom.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            recepciones = 0;
            for (int i = 0; i < traer_Resumen_RecepcionDataGridView.RowCount; i++)
            {
                int.TryParse(traer_Resumen_RecepcionDataGridView.Rows[i].Cells[nameof(dataGridViewTextBoxColumn11)].Value.ToString(),out recepciones);
                int.TryParse(traer_Resumen_RecepcionDataGridView.Rows[i].Cells[nameof(dataGridViewTextBoxColumn21)].Value.ToString(), out bultos);
                tarja_RecepcionTableAdapter.sp_llenar_peso_recepcion(recepciones,bultos);
                Informe_Recepcion x = new Informe_Recepcion(recepciones);
                x.ShowDialog();
                MessageBox.Show("recepción formalizada correctamente", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
