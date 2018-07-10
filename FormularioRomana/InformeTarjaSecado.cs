using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioRomana
{
    public partial class InformeTarjaSecado : Form
    {
        String tarjas;
        public InformeTarjaSecado(String tarja)
        {
            tarjas = tarja;   
            InitializeComponent();
        }

        private void InformeTarjaSecado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'GenesisDataSet.Informe_Tarja_Secado' Puede moverla o quitarla según sea necesario.
            this.Informe_Tarja_SecadoTableAdapter.Fill(this.GenesisDataSet.Informe_Tarja_Secado,tarjas,imageToByteArray(GenerarCodigoBarra()));
            this.reportViewer1.RefreshReport();
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        public Image GenerarCodigoBarra()
        {
            BarcodeLib.Barcode b = new BarcodeLib.Barcode();
            Image img = b.Encode(BarcodeLib.TYPE.CODE128, tarjas, Color.Black, Color.White, 290, 120);
            return img;
        }
    }
}
