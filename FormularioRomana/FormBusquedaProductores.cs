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
    public partial class FormBusquedaProductores : Form
    {
        public int codigo;
        public FormBusquedaProductores()
        {
            InitializeComponent();
        }
        private void FormBusquedaProductores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'genesisDataSet.Productores' Puede moverla o quitarla según sea necesario.
            this.productoresTableAdapter.Fill(this.genesisDataSet.Productores);
          

        }

        private void Txt_Productor_TextChanged(object sender, EventArgs e)
        {
            productoresTableAdapter.FiltroProductorByNombre(this.genesisDataSet.Productores,Txt_Productor.Text);
        }

        private void productoresDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool x = int.TryParse(productoresDataGridView.Rows[e.RowIndex].Cells[nameof(dataGridViewTextBoxColumn1)].Value.ToString(), out codigo);
            this.Close();
       
        }
    }
}
