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
    public partial class InformeRomana2 : Form
    {
        int guia2;
        int productor;
        public InformeRomana2(int pro,int guia)
        {
            InitializeComponent();
            guia2 = guia;
            productor = pro;
        }

        private void InformeRomana2_Load(object sender, EventArgs e)
        {
            try
            {
           // TODO: esta línea de código carga datos en la tabla 'GenesisDataSet.Informe_Romana_Seca' Puede moverla o quitarla según sea necesario.
            this.Informe_Romana_SecaTableAdapter.Fill(this.GenesisDataSet.Informe_Romana_Seca,productor,guia2);
            // TODO: esta línea de código carga datos en la tabla 'GenesisDataSet.Informe_Recepcion_Cabecera2' Puede moverla o quitarla según sea necesario.
            this.Informe_Recepcion_Cabecera2TableAdapter.Fill(this.GenesisDataSet.Informe_Recepcion_Cabecera2,productor,guia2);
                Informe_Romana_RecepcionesTableAdapter.Fill(GenesisDataSet.Informe_Romana_Recepciones, productor, guia2.ToString());
            this.reportViewer1.RefreshReport();
            }
            catch (Exception)
            {

                throw;
            }
        
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
