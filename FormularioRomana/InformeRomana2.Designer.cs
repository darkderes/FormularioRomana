namespace FormularioRomana
{
    partial class InformeRomana2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GenesisDataSet = new FormularioRomana.GenesisDataSet();
            this.Informe_Recepcion_Cabecera2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Informe_Recepcion_Cabecera2TableAdapter = new FormularioRomana.GenesisDataSetTableAdapters.Informe_Recepcion_Cabecera2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GenesisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Informe_Recepcion_Cabecera2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Informe_Recepcion_Cabecera2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FormularioRomana.InformeRomana2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(697, 560);
            this.reportViewer1.TabIndex = 0;
            // 
            // GenesisDataSet
            // 
            this.GenesisDataSet.DataSetName = "GenesisDataSet";
            this.GenesisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Informe_Recepcion_Cabecera2BindingSource
            // 
            this.Informe_Recepcion_Cabecera2BindingSource.DataMember = "Informe_Recepcion_Cabecera2";
            this.Informe_Recepcion_Cabecera2BindingSource.DataSource = this.GenesisDataSet;
            // 
            // Informe_Recepcion_Cabecera2TableAdapter
            // 
            this.Informe_Recepcion_Cabecera2TableAdapter.ClearBeforeFill = true;
            // 
            // InformeRomana2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 560);
            this.Controls.Add(this.reportViewer1);
            this.Name = "InformeRomana2";
            this.Text = "InformeRomana2";
            this.Load += new System.EventHandler(this.InformeRomana2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GenesisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Informe_Recepcion_Cabecera2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Informe_Recepcion_Cabecera2BindingSource;
        private GenesisDataSet GenesisDataSet;
        private GenesisDataSetTableAdapters.Informe_Recepcion_Cabecera2TableAdapter Informe_Recepcion_Cabecera2TableAdapter;
    }
}