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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Informe_Recepcion_Cabecera2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GenesisDataSet = new FormularioRomana.GenesisDataSet();
            this.Informe_Romana_SecaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Informe_Romana_RecepcionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Informe_Recepcion_Cabecera2TableAdapter = new FormularioRomana.GenesisDataSetTableAdapters.Informe_Recepcion_Cabecera2TableAdapter();
            this.Informe_Romana_SecaTableAdapter = new FormularioRomana.GenesisDataSetTableAdapters.Informe_Romana_SecaTableAdapter();
            this.Informe_Romana_RecepcionesTableAdapter = new FormularioRomana.GenesisDataSetTableAdapters.Informe_Romana_RecepcionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Informe_Recepcion_Cabecera2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenesisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Informe_Romana_SecaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Informe_Romana_RecepcionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Informe_Recepcion_Cabecera2BindingSource
            // 
            this.Informe_Recepcion_Cabecera2BindingSource.DataMember = "Informe_Recepcion_Cabecera2";
            this.Informe_Recepcion_Cabecera2BindingSource.DataSource = this.GenesisDataSet;
            // 
            // GenesisDataSet
            // 
            this.GenesisDataSet.DataSetName = "GenesisDataSet";
            this.GenesisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Informe_Romana_SecaBindingSource
            // 
            this.Informe_Romana_SecaBindingSource.DataMember = "Informe_Romana_Seca";
            this.Informe_Romana_SecaBindingSource.DataSource = this.GenesisDataSet;
            // 
            // Informe_Romana_RecepcionesBindingSource
            // 
            this.Informe_Romana_RecepcionesBindingSource.DataMember = "Informe_Romana_Recepciones";
            this.Informe_Romana_RecepcionesBindingSource.DataSource = this.GenesisDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Informe_Recepcion_Cabecera2BindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.Informe_Romana_SecaBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.Informe_Romana_RecepcionesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FormularioRomana.InformeRomana2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(697, 560);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Informe_Recepcion_Cabecera2TableAdapter
            // 
            this.Informe_Recepcion_Cabecera2TableAdapter.ClearBeforeFill = true;
            // 
            // Informe_Romana_SecaTableAdapter
            // 
            this.Informe_Romana_SecaTableAdapter.ClearBeforeFill = true;
            // 
            // Informe_Romana_RecepcionesTableAdapter
            // 
            this.Informe_Romana_RecepcionesTableAdapter.ClearBeforeFill = true;
            // 
            // InformeRomana2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 560);
            this.Controls.Add(this.reportViewer1);
            this.Name = "InformeRomana2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformeRomana2";
            this.Load += new System.EventHandler(this.InformeRomana2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Informe_Recepcion_Cabecera2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenesisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Informe_Romana_SecaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Informe_Romana_RecepcionesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Informe_Recepcion_Cabecera2BindingSource;
        private GenesisDataSet GenesisDataSet;
        private GenesisDataSetTableAdapters.Informe_Recepcion_Cabecera2TableAdapter Informe_Recepcion_Cabecera2TableAdapter;
        private System.Windows.Forms.BindingSource Informe_Romana_SecaBindingSource;
        private GenesisDataSetTableAdapters.Informe_Romana_SecaTableAdapter Informe_Romana_SecaTableAdapter;
        private System.Windows.Forms.BindingSource Informe_Romana_RecepcionesBindingSource;
        private GenesisDataSetTableAdapters.Informe_Romana_RecepcionesTableAdapter Informe_Romana_RecepcionesTableAdapter;
    }
}