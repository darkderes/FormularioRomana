namespace FormularioRomana
{
    partial class FormBusquedaProductores
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
            this.genesisDataSet = new FormularioRomana.GenesisDataSet();
            this.productoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoresTableAdapter = new FormularioRomana.GenesisDataSetTableAdapters.ProductoresTableAdapter();
            this.tableAdapterManager = new FormularioRomana.GenesisDataSetTableAdapters.TableAdapterManager();
            this.productoresDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_Productor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.genesisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // genesisDataSet
            // 
            this.genesisDataSet.DataSetName = "GenesisDataSet";
            this.genesisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoresBindingSource
            // 
            this.productoresBindingSource.DataMember = "Productores";
            this.productoresBindingSource.DataSource = this.genesisDataSet;
            // 
            // productoresTableAdapter
            // 
            this.productoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BasesPalletTableAdapter = null;
            this.tableAdapterManager.DetalleRecepcionesTableAdapter = null;
            this.tableAdapterManager.Envases_ProcesosTableAdapter = null;
            this.tableAdapterManager.EnvasesTableAdapter = null;
            this.tableAdapterManager.EstadosTableAdapter = null;
            this.tableAdapterManager.Humedad_RecepcionTableAdapter = null;
            this.tableAdapterManager.ProcesosTableAdapter = null;
            this.tableAdapterManager.ProductoresTableAdapter = this.productoresTableAdapter;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.RecepcionesTableAdapter = null;
            this.tableAdapterManager.RomanaTableAdapter = null;
            this.tableAdapterManager.Tarja_RecepcionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FormularioRomana.GenesisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VariedadTableAdapter = null;
            // 
            // productoresDataGridView
            // 
            this.productoresDataGridView.AllowUserToAddRows = false;
            this.productoresDataGridView.AutoGenerateColumns = false;
            this.productoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.productoresDataGridView.DataSource = this.productoresBindingSource;
            this.productoresDataGridView.Location = new System.Drawing.Point(22, 54);
            this.productoresDataGridView.Name = "productoresDataGridView";
            this.productoresDataGridView.RowHeadersVisible = false;
            this.productoresDataGridView.Size = new System.Drawing.Size(568, 407);
            this.productoresDataGridView.TabIndex = 1;
            this.productoresDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productoresDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cod_Productor";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Rut_Productor";
            this.dataGridViewTextBoxColumn2.HeaderText = "Rut";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Productor";
            this.dataGridViewTextBoxColumn3.HeaderText = "Productor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 500;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Des_Productor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Des_Productor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // Txt_Productor
            // 
            this.Txt_Productor.Location = new System.Drawing.Point(158, 12);
            this.Txt_Productor.Name = "Txt_Productor";
            this.Txt_Productor.Size = new System.Drawing.Size(275, 20);
            this.Txt_Productor.TabIndex = 2;
            this.Txt_Productor.TextChanged += new System.EventHandler(this.Txt_Productor_TextChanged);
            // 
            // FormBusquedaProductores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 498);
            this.Controls.Add(this.Txt_Productor);
            this.Controls.Add(this.productoresDataGridView);
            this.Name = "FormBusquedaProductores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBusquedaProductores";
            this.Load += new System.EventHandler(this.FormBusquedaProductores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genesisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoresDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GenesisDataSet genesisDataSet;
        private System.Windows.Forms.BindingSource productoresBindingSource;
        private GenesisDataSetTableAdapters.ProductoresTableAdapter productoresTableAdapter;
        private GenesisDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView productoresDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox Txt_Productor;
    }
}