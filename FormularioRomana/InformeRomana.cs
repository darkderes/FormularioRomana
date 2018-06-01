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
    public partial class InformeRomana : Form
    {
        int recep = 0;
        public InformeRomana(int recepcion)
        {
            InitializeComponent();
            recep = recepcion;
        }

        private void InformeRomana_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'GenesisDataSet.Informe_Romana' Puede moverla o quitarla según sea necesario.
            this.Informe_RomanaTableAdapter.Fill(this.GenesisDataSet.Informe_Romana,recep);
            // TODO: esta línea de código carga datos en la tabla 'GenesisDataSet.Informe_Recepcion_Cuerpo' Puede moverla o quitarla según sea necesario.
            this.Informe_Recepcion_CuerpoTableAdapter.Fill(this.GenesisDataSet.Informe_Recepcion_Cuerpo,recep);
            // TODO: esta línea de código carga datos en la tabla 'GenesisDataSet.Informe_Recepcion_Cabecera' Puede moverla o quitarla según sea necesario.
            this.Informe_Recepcion_CabeceraTableAdapter.Fill(this.GenesisDataSet.Informe_Recepcion_Cabecera,recep);

            this.reportViewer1.RefreshReport();
        }
    }
}
