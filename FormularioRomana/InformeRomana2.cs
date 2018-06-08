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
            // TODO: esta línea de código carga datos en la tabla 'GenesisDataSet.Informe_Recepcion_Cabecera2' Puede moverla o quitarla según sea necesario.
            this.Informe_Recepcion_Cabecera2TableAdapter.Fill(this.GenesisDataSet.Informe_Recepcion_Cabecera2,productor,guia2);

            this.reportViewer1.RefreshReport();
        }
    }
}
