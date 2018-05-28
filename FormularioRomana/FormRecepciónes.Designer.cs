namespace FormularioRomana
{
    partial class FormRecepciónes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.genesisDataSet = new FormularioRomana.GenesisDataSet();
            this.traer_Resumen_RecepcionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.traer_Resumen_RecepcionTableAdapter = new FormularioRomana.GenesisDataSetTableAdapters.Traer_Resumen_RecepcionTableAdapter();
            this.tableAdapterManager = new FormularioRomana.GenesisDataSetTableAdapters.TableAdapterManager();
            this.traer_Resumen_RecepcionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.genesisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traer_Resumen_RecepcionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traer_Resumen_RecepcionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // genesisDataSet
            // 
            this.genesisDataSet.DataSetName = "GenesisDataSet";
            this.genesisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // traer_Resumen_RecepcionBindingSource
            // 
            this.traer_Resumen_RecepcionBindingSource.DataMember = "Traer_Resumen_Recepcion";
            this.traer_Resumen_RecepcionBindingSource.DataSource = this.genesisDataSet;
            // 
            // traer_Resumen_RecepcionTableAdapter
            // 
            this.traer_Resumen_RecepcionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BasesPalletTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DetalleRecepcionesTableAdapter = null;
            this.tableAdapterManager.Envases_ProcesosTableAdapter = null;
            this.tableAdapterManager.EnvasesTableAdapter = null;
            this.tableAdapterManager.EstadosTableAdapter = null;
            this.tableAdapterManager.Humedad_RecepcionTableAdapter = null;
            this.tableAdapterManager.ProcesosTableAdapter = null;
            this.tableAdapterManager.ProductoresTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.RecepcionesTableAdapter = null;
            this.tableAdapterManager.RomanaTableAdapter = null;
            this.tableAdapterManager.Tarja_RecepcionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FormularioRomana.GenesisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VariedadTableAdapter = null;
            // 
            // traer_Resumen_RecepcionDataGridView
            // 
            this.traer_Resumen_RecepcionDataGridView.AllowUserToAddRows = false;
            this.traer_Resumen_RecepcionDataGridView.AutoGenerateColumns = false;
            this.traer_Resumen_RecepcionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.traer_Resumen_RecepcionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.traer_Resumen_RecepcionDataGridView.DataSource = this.traer_Resumen_RecepcionBindingSource;
            this.traer_Resumen_RecepcionDataGridView.Location = new System.Drawing.Point(12, 52);
            this.traer_Resumen_RecepcionDataGridView.Name = "traer_Resumen_RecepcionDataGridView";
            this.traer_Resumen_RecepcionDataGridView.Size = new System.Drawing.Size(1046, 220);
            this.traer_Resumen_RecepcionDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Fecha";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cod_Recepcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cod_Recepcion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cod_Productor";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cod_Productor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Productor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Productor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cod_Variedad";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cod_Variedad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Des_Variedad";
            this.dataGridViewTextBoxColumn6.HeaderText = "Des_Variedad";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Cod_Estado";
            this.dataGridViewTextBoxColumn7.HeaderText = "Cod_Estado";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn8.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Cod_Productos";
            this.dataGridViewTextBoxColumn9.HeaderText = "Cod_Productos";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Productos";
            this.dataGridViewTextBoxColumn10.HeaderText = "Productos";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Num_Guia";
            this.dataGridViewTextBoxColumn11.HeaderText = "Num_Guia";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Bultos";
            this.dataGridViewTextBoxColumn12.HeaderText = "Bultos";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Rut_Usuario";
            this.dataGridViewTextBoxColumn13.HeaderText = "Rut_Usuario";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // FormRecepciónes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 354);
            this.Controls.Add(this.traer_Resumen_RecepcionDataGridView);
            this.Name = "FormRecepciónes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRecepciónes";
            this.Load += new System.EventHandler(this.FormRecepciónes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genesisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traer_Resumen_RecepcionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traer_Resumen_RecepcionDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GenesisDataSet genesisDataSet;
        private System.Windows.Forms.BindingSource traer_Resumen_RecepcionBindingSource;
        private GenesisDataSetTableAdapters.Traer_Resumen_RecepcionTableAdapter traer_Resumen_RecepcionTableAdapter;
        private GenesisDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView traer_Resumen_RecepcionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}