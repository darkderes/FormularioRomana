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
    public partial class Informe_Recepcion : Form
    {
        int recep;
        public Informe_Recepcion(int recepcion)
        {
            InitializeComponent();
            recep = recepcion;
        }

        private void Informe_Recepcion_Load(object sender, EventArgs e)
        {
            this.Informe_Recepcion_CabeceraTableAdapter.Fill(this.GenesisDataSet.Informe_Recepcion_Cabecera,recep);
            this.Informe_Recepcion_CuerpoTableAdapter.Fill(this.GenesisDataSet.Informe_Recepcion_Cuerpo,recep);
            this.reportViewer1.RefreshReport();
        }
    }
}
