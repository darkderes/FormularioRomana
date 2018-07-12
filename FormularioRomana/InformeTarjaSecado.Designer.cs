namespace FormularioRomana
{
    partial class InformeTarjaSecado
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
            this.Informe_Tarja_SecadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GenesisDataSet = new FormularioRomana.GenesisDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Informe_Tarja_SecadoTableAdapter = new FormularioRomana.GenesisDataSetTableAdapters.Informe_Tarja_SecadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Informe_Tarja_SecadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenesisDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Informe_Tarja_SecadoBindingSource
            // 
            this.Informe_Tarja_SecadoBindingSource.DataMember = "Informe_Tarja_Secado";
            this.Informe_Tarja_SecadoBindingSource.DataSource = this.GenesisDataSet;
            // 
            // GenesisDataSet
            // 
            this.GenesisDataSet.DataSetName = "GenesisDataSet";
            this.GenesisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Informe_Tarja_SecadoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FormularioRomana.InformeTarjaSecado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(862, 982);
            this.reportViewer1.TabIndex = 0;
            // 
            // Informe_Tarja_SecadoTableAdapter
            // 
            this.Informe_Tarja_SecadoTableAdapter.ClearBeforeFill = true;
            // 
            // InformeTarjaSecado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 982);
            this.Controls.Add(this.reportViewer1);
            this.Name = "InformeTarjaSecado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformeTarjaSecado";
            this.Load += new System.EventHandler(this.InformeTarjaSecado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Informe_Tarja_SecadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenesisDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Informe_Tarja_SecadoBindingSource;
        private GenesisDataSet GenesisDataSet;
        private GenesisDataSetTableAdapters.Informe_Tarja_SecadoTableAdapter Informe_Tarja_SecadoTableAdapter;
    }
}