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
        string estado = null;
        int bultos;
        string guia;
        short productor;
        int fila;
        int recepcion;

        public FormRecepciónes()
        {
            InitializeComponent();
        }
        private void FormRecepciónes_Load(object sender, EventArgs e)
        {
            try
            {
                radioButton1.Checked = true;
                radioButton6.Checked = true;
                this.productoresTableAdapter.FillByProductores(this.genesisDataSet1.Productores);
                this.variedadTableAdapter.TraerVariedad(this.genesisDataSet.Variedad);
                this.productoTableAdapter.FillProductosByProceso(this.genesisDataSet.Producto, 1);
                this.traer_Resumen_Recepcion_FiltroTableAdapter.Fill(genesisDataSet.Traer_Resumen_Recepcion_Filtro, null, null, null, formalizada, humedad);
            }
            catch (Exception)
            {
                throw;
            }           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var recepcion = new Form1(1);
            recepcion.ShowDialog();
            this.traer_Resumen_Recepcion_FiltroTableAdapter.Fill(genesisDataSet.Traer_Resumen_Recepcion_Filtro, null, null, null, formalizada, humedad);
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
            int i = productores.codigo;
            cod_ProductorTextBox.Text = i.ToString();
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
        private void traer_Resumen_Recepcion_FiltroDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if((e.RowIndex >= 0)&&(e.ColumnIndex > 0))                
            {
                try
                {
                    if ((!string.IsNullOrEmpty(traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn15)].Value.ToString()))||(!string.IsNullOrWhiteSpace(traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn15)].Value.ToString())))
                    {
                        if (traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn15)].Value.ToString() == "No")
                        {
                            traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
                            if ((traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn7)].Value.ToString() == "2")&& (traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn14)].Value.ToString() == "0"))
                            {
                                traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn14)].Style.BackColor = Color.Bisque;
                            }
                              
                        }
                           
                        
                        else
                        {
                            traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
                        }
                    }
                   
                }
                catch (System.IndexOutOfRangeException ex)
                {
                    //  throw new System.ArgumentOutOfRangeException("index parameter is out of range.", ex);
                }
                catch (System.NullReferenceException ex)
                {

                }
                               
            }
        }

        private void traer_Resumen_Recepcion_FiltroDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                fila = e.RowIndex;
                guia = traer_Resumen_Recepcion_FiltroDataGridView.Rows[fila].Cells[nameof(dataGridViewTextBoxColumn11)].Value.ToString();
                short.TryParse(traer_Resumen_Recepcion_FiltroDataGridView.Rows[fila].Cells[nameof(dataGridViewTextBoxColumn3)].Value.ToString(), out productor);
            }
            else
            {
                MessageBox.Show("Debe selecciona una fila", "Anakena", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void traer_Resumen_Recepcion_FiltroDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            timer1.Stop();
            guia = traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn11)].Value.ToString();
            short.TryParse(traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn3)].Value.ToString(), out productor);
            estado = traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn8)].Value.ToString();
            int.TryParse(traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn12)].Value.ToString(), out bultos);

            if ((estado == "Con Pelón") && (traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn15)].Value.ToString() == "Si"))// recepciones con pelon formalizada
            {
                Form1 d = new Form1(0);
                d.Lbl_Recepcion.Text = traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn2)].Value.ToString();
                d.cod_ProductorTextBox.Text = productor.ToString();
                d.nom_ProductorComboBox.Text = traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn4)].Value.ToString();
                d.Txt_NumGuia.Text = traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn11)].Value.ToString();
                d.comboBox3.Text = traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn6)].Value.ToString();
                d.comboBox2.Text = estado;
                d.productosComboBox.Text = traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn10)].Value.ToString();
                d.TxtBultos.Text = bultos.ToString();
                d.Lbl_Recepcion.Visible = true;
                d.label1.Visible = true;
                d.ShowDialog();
            }
            else
            if ((estado == "Con Pelón") && (traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn15)].Value.ToString() == "No"))// recepciones con pelon sin formalizar
            {
                Form1 d = new Form1(2);
                d.Lbl_Recepcion.Text = traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn2)].Value.ToString();
                d.cod_ProductorTextBox.Text = productor.ToString();
                d.nom_ProductorComboBox.Text = traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn4)].Value.ToString();
                d.Txt_NumGuia.Text = traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn11)].Value.ToString();
                d.TxtBultos.Text = bultos.ToString();
                d.Lbl_Recepcion.Visible = true;
                d.label1.Visible = true;
                d.producto = Convert.ToInt16(traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn9)].Value.ToString());
                d.variedad = Convert.ToInt16(traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn5)].Value.ToString());
                d.estado = Convert.ToInt16(traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn7)].Value.ToString());
                d.ShowDialog();
                this.traer_Resumen_Recepcion_FiltroTableAdapter.Fill(genesisDataSet.Traer_Resumen_Recepcion_Filtro, null, null, null, formalizada, humedad);
            }
            else
            if ((estado == "Seca") && (traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn15)].Value.ToString() == "Si"))
            {
                Form1 d = new Form1(3);
                d.Lbl_Recepcion.Text = traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn2)].Value.ToString();
                d.cod_ProductorTextBox.Text = productor.ToString();
                d.nom_ProductorComboBox.Text = traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn4)].Value.ToString();
                d.Txt_NumGuia.Text = traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn11)].Value.ToString();
                d.comboBox3.Text = traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn6)].Value.ToString();
                d.comboBox2.Text = estado;
                d.productosComboBox.Text = traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn10)].Value.ToString();
                d.TxtBultos.Text = bultos.ToString();
                d.Lbl_Recepcion.Visible = true;
                d.label1.Visible = true;
                d.ShowDialog();
            }
            else
            if ((estado == "Seca") && (traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn15)].Value.ToString() == "No"))
            {
                this.traer_Cantidad_RecepcionesTableAdapter.Fill(this.genesisDataSet.Traer_Cantidad_Recepciones, guia, new System.Nullable<short>(((short)(System.Convert.ChangeType(productor, typeof(short))))));
                if (traer_Cantidad_RecepcionesDataGridView.RowCount > 0)
                {
                    if (Convert.ToInt32(traer_Cantidad_RecepcionesDataGridView.Rows[0].Cells[nameof(dataGridViewTextBoxColumn17)].Value.ToString()) == 1)
                    {
                        Form1 d = new Form1(4);
                        d.Lbl_Recepcion.Text = traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn2)].Value.ToString();
                        d.cod_ProductorTextBox.Text = productor.ToString();
                        d.nom_ProductorComboBox.Text = traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn4)].Value.ToString();
                        d.Txt_NumGuia.Text = traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn11)].Value.ToString();
                        d.TxtBultos.Text = bultos.ToString();
                        d.Lbl_Recepcion.Visible = true;
                        d.label1.Visible = true;
                        d.producto = Convert.ToInt16(traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn9)].Value.ToString());
                        d.variedad = Convert.ToInt16(traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn5)].Value.ToString());
                        d.estado = Convert.ToInt16(traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn7)].Value.ToString());
                        d.ShowDialog();
                        this.traer_Resumen_Recepcion_FiltroTableAdapter.Fill(genesisDataSet.Traer_Resumen_Recepcion_Filtro, null, null, null, formalizada, humedad);
                    }
                    else
                    {
                        Form1 d = new Form1(5);
                        d.cod_ProductorTextBox.Text = productor.ToString();
                        d.nom_ProductorComboBox.Text = traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn4)].Value.ToString();
                        d.Txt_NumGuia.Text = traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn11)].Value.ToString();
                        d.TxtBultos.Text = traer_Cantidad_RecepcionesDataGridView.Rows[0].Cells[nameof(dataGridViewTextBoxColumn18)].Value.ToString();
                        d.Lbl_Recepcion.Visible = true;
                        d.label1.Visible = true;
                        d.producto = Convert.ToInt16(traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn9)].Value.ToString());
                        d.variedad = Convert.ToInt16(traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn5)].Value.ToString());
                        d.estado = Convert.ToInt16(traer_Resumen_Recepcion_FiltroDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn7)].Value.ToString());
                        d.ShowDialog();
                        this.traer_Resumen_Recepcion_FiltroTableAdapter.Fill(genesisDataSet.Traer_Resumen_Recepcion_Filtro, null, null, null, formalizada, humedad);
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.traer_Resumen_Recepcion_FiltroTableAdapter.Fill(genesisDataSet.Traer_Resumen_Recepcion_Filtro, null, null, null, formalizada, humedad);
        }

   

        private void button3_Click(object sender, EventArgs e)
        {
            if(fila >= 0)
            { 
                 Boolean IsRecepcion = int.TryParse(traer_Resumen_Recepcion_FiltroDataGridView.Rows[fila].Cells[nameof(dataGridViewTextBoxColumn2)].Value.ToString(),out recepcion);
                if (IsRecepcion)
                {
                    this.traer_Cantidad_RecepcionesTableAdapter.Fill(this.genesisDataSet.Traer_Cantidad_Recepciones, guia, new System.Nullable<short>(((short)(System.Convert.ChangeType(productor, typeof(short))))));
                    if (traer_Resumen_Recepcion_FiltroDataGridView.Rows[fila].Cells[nameof(dataGridViewTextBoxColumn15)].Value.ToString() == "No")
                    {
                        if ((traer_Cantidad_RecepcionesDataGridView.RowCount > 0)&&(Convert.ToInt16(traer_Cantidad_RecepcionesDataGridView.Rows[0].Cells[nameof(dataGridViewTextBoxColumn17)].Value.ToString())>1))
                        {
                            if (MessageBox.Show("Existen mas de una recepcion vinculada al mismo numero de productor y guia,Desea eliminar todas las recepciones ???", "ANAKENA", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                MessageBox.Show("Entra");
                            }
                        }
                    }
                    else
                    if (traer_Resumen_Recepcion_FiltroDataGridView.Rows[fila].Cells[nameof(dataGridViewTextBoxColumn15)].Value.ToString() == "Si")
                    {
                            
                    }
                }
            }
        }
    }
}
