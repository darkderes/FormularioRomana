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
         

            this.romanaTableAdapter.Fill(this.genesisDataSet.Romana);
            try
            {
                this.estadosTableAdapter.FiltroEstadoByProceso(this.genesisDataSet.Estados); //Trae los datos de los estados en base a Codigo de proceso
                this.productoTableAdapter.FiltroProductoByEstado(this.genesisDataSet.Producto, 1);
                this.productoresTableAdapter.Fill(this.genesisDataSet.Productores);
                this.variedadTableAdapter.Fill(this.genesisDataSet.Variedad);
                this.basesPalletTableAdapter.Fill(this.genesisDataSet1.BasesPallet);
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
                if ((TxtBultos.Text.Length > 0) && (Txt_NumGuia.Text.Length > 0)&&(is_numero))
                {
                   
                    if ((comboBox2.Text == "Con Pelón")||((comboBox2.Text=="Seca")&&(bultos <= 24)))
                    {
                        id = Convert.ToInt32(recepcionesTableAdapter1.Insertar_Recepciones(Convert.ToInt16(cod_ProductorTextBox.Text), Convert.ToInt16(comboBox3.SelectedValue.ToString()), Convert.ToInt16(comboBox2.SelectedValue.ToString()), Convert.ToInt16(productosComboBox.SelectedValue.ToString()), Txt_NumGuia.Text, bultos, "16448502-1"));
                        MessageBox.Show("Recepción ingresada", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        groupBox1.Enabled = false;
                        tabControl1.Visible = true;
                        label1.Visible = true;
                        Lbl_Recepcion.Visible = true;
                        Lbl_Recepcion.Text = id.ToString();
                    }
                    else
                    if (comboBox2.Text == "Seca")
                    {
                        double pesajes = 0;
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
                        //if (bultos2 <= 80)
                        //{
                        //    if (bultos2 % pesajes == 0)
                        //    {
                        //        int aux = Convert.ToInt32(bultos2 / pesajes);
                        //        MessageBox.Show(aux.ToString());
                        //    }
                        //    else
                        //    {
                        //        int aux = Convert.ToInt32(bultos / pesajes);
                        //        int aux1 = Convert.ToInt32((aux * (pesajes - 1)));
                        //        int aux2 = Convert.ToInt32(bultos - aux1);
                        //        MessageBox.Show("Pesajes :" + (pesajes - 1).ToString() + " De " + (aux).ToString() + " 1 Pesaje de " + aux2);
                        //    }
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Error");
                        //}
                    }
                    if(comboBox2.Text == "Con Pelón")
                    {
                        try
                        {
                            tabControl1.Controls.Remove(tabControl1.TabPages[1]);
                        }
                        catch (IndexOutOfRangeException ex)
                        {
                            MessageBox.Show(ex.Message,"Anakena",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            //  throw IndexOutOfRangeException e;
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
                        LblCantidadEnvases.Text = cantidad_acum.ToString();
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
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            decimal peso_bruto = 0;
            peso_bruto = Convert.ToDecimal(Txt_Peso_Bruto.Text) / bultos ;
            try
            {
                tarja_RecepcionTableAdapter.sp_llenar_peso_recepcion(Convert.ToInt32(Lbl_Recepcion.Text),peso_bruto);
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
                Txt_Humedad.ReadOnly = true;
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
             cod_ProductorTextBox.Text = rc.codigo.ToString();
            productoresTableAdapter.FiltroProductorByCodigo(genesisDataSet.Productores,(short)rc.codigo);
        }

        private void cod_ProductorTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
