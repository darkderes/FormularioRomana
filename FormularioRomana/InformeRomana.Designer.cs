namespace FormularioRomana
{
    partial class InformeRomana
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Informe_Recepcion_CabeceraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GenesisDataSet = new FormularioRomana.GenesisDataSet();
            this.Informe_Recepcion_CuerpoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Informe_RomanaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Informe_Recepcion_CabeceraTableAdapter = new FormularioRomana.GenesisDataSetTableAdapters.Informe_Recepcion_CabeceraTableAdapter();
            this.Informe_Recepcion_CuerpoTableAdapter = new FormularioRomana.GenesisDataSetTableAdapters.Informe_Recepcion_CuerpoTableAdapter();
            this.Informe_RomanaTableAdapter = new FormularioRomana.GenesisDataSetTableAdapters.Informe_RomanaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Informe_Recepcion_CabeceraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenesisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Informe_Recepcion_CuerpoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Informe_RomanaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Informe_Recepcion_CabeceraBindingSource
            // 
            this.Informe_Recepcion_CabeceraBindingSource.DataMember = "Informe_Recepcion_Cabecera";
            this.Informe_Recepcion_CabeceraBindingSource.DataSource = this.GenesisDataSet;
            // 
            // GenesisDataSet
            // 
            this.GenesisDataSet.DataSetName = "GenesisDataSet";
            this.GenesisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Informe_Recepcion_CuerpoBindingSource
            // 
            this.Informe_Recepcion_CuerpoBindingSource.DataMember = "Informe_Recepcion_Cuerpo";
            this.Informe_Recepcion_CuerpoBindingSource.DataSource = this.GenesisDataSet;
            // 
            // Informe_RomanaBindingSource
            // 
            this.Informe_RomanaBindingSource.DataMember = "Informe_Romana";
            this.Informe_RomanaBindingSource.DataSource = this.GenesisDataSet;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Informe_Recepcion_CabeceraBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.Informe_Recepcion_CuerpoBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.Informe_RomanaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FormularioRomana.InformeRomana.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(805, 550);
            this.reportViewer1.TabIndex = 0;
            // 
            // Informe_Recepcion_CabeceraTableAdapter
            // 
            this.Informe_Recepcion_CabeceraTableAdapter.ClearBeforeFill = true;
            // 
            // Informe_Recepcion_CuerpoTableAdapter
            // 
            this.Informe_Recepcion_CuerpoTableAdapter.ClearBeforeFill = true;
            // 
            // Informe_RomanaTableAdapter
            // 
            this.Informe_RomanaTableAdapter.ClearBeforeFill = true;
            // 
            // InformeRomana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 546);
            this.Controls.Add(this.reportViewer1);
            this.Name = "InformeRomana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformeRomana";
            this.Load += new System.EventHandler(this.InformeRomana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Informe_Recepcion_CabeceraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenesisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Informe_Recepcion_CuerpoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Informe_RomanaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Informe_Recepcion_CabeceraBindingSource;
        private GenesisDataSet GenesisDataSet;
        private GenesisDataSetTableAdapters.Informe_Recepcion_CabeceraTableAdapter Informe_Recepcion_CabeceraTableAdapter;
        private System.Windows.Forms.BindingSource Informe_Recepcion_CuerpoBindingSource;
        private GenesisDataSetTableAdapters.Informe_Recepcion_CuerpoTableAdapter Informe_Recepcion_CuerpoTableAdapter;
        private System.Windows.Forms.BindingSource Informe_RomanaBindingSource;
        private GenesisDataSetTableAdapters.Informe_RomanaTableAdapter Informe_RomanaTableAdapter;
    }
}