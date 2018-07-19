namespace FormularioRomana
{
    partial class FormAdmin_Secado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin_Secado));
            this.genesisDataSet = new FormularioRomana.GenesisDataSet();
            this.traer_Proceso_Secado_AdminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.traer_Proceso_Secado_AdminTableAdapter = new FormularioRomana.GenesisDataSetTableAdapters.Traer_Proceso_Secado_AdminTableAdapter();
            this.tableAdapterManager = new FormularioRomana.GenesisDataSetTableAdapters.TableAdapterManager();
            this.traer_Proceso_Secado_AdminDataGridView = new System.Windows.Forms.DataGridView();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.productosComboBox = new System.Windows.Forms.ComboBox();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genesisDataSet1 = new FormularioRomana.GenesisDataSet();
            this.label16 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.nom_ProductorComboBox = new System.Windows.Forms.ComboBox();
            this.productoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cod_ProductorTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbVariedad = new System.Windows.Forms.ComboBox();
            this.variedadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productoresTableAdapter = new FormularioRomana.GenesisDataSetTableAdapters.ProductoresTableAdapter();
            this.variedadTableAdapter = new FormularioRomana.GenesisDataSetTableAdapters.VariedadTableAdapter();
            this.productoTableAdapter = new FormularioRomana.GenesisDataSetTableAdapters.ProductoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.genesisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traer_Proceso_Secado_AdminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traer_Proceso_Secado_AdminDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genesisDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variedadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // genesisDataSet
            // 
            this.genesisDataSet.DataSetName = "GenesisDataSet";
            this.genesisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // traer_Proceso_Secado_AdminBindingSource
            // 
            this.traer_Proceso_Secado_AdminBindingSource.DataMember = "Traer_Proceso_Secado_Admin";
            this.traer_Proceso_Secado_AdminBindingSource.DataSource = this.genesisDataSet;
            // 
            // traer_Proceso_Secado_AdminTableAdapter
            // 
            this.traer_Proceso_Secado_AdminTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Paso_Recepcion_SecadoTableAdapter = null;
            this.tableAdapterManager.ProcesosTableAdapter = null;
            this.tableAdapterManager.ProductoresTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.RecepcionesTableAdapter = null;
            this.tableAdapterManager.Romana_SecaTableAdapter = null;
            this.tableAdapterManager.RomanaTableAdapter = null;
            this.tableAdapterManager.SecadoTableAdapter = null;
            this.tableAdapterManager.Tarja_RecepcionTableAdapter = null;
            this.tableAdapterManager.Tarja_SecadoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FormularioRomana.GenesisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VariedadTableAdapter = null;
            // 
            // traer_Proceso_Secado_AdminDataGridView
            // 
            this.traer_Proceso_Secado_AdminDataGridView.AllowUserToAddRows = false;
            this.traer_Proceso_Secado_AdminDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.traer_Proceso_Secado_AdminDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.traer_Proceso_Secado_AdminDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.traer_Proceso_Secado_AdminDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewTextBoxColumn11});
            this.traer_Proceso_Secado_AdminDataGridView.DataSource = this.traer_Proceso_Secado_AdminBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.traer_Proceso_Secado_AdminDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.traer_Proceso_Secado_AdminDataGridView.Location = new System.Drawing.Point(12, 172);
            this.traer_Proceso_Secado_AdminDataGridView.Name = "traer_Proceso_Secado_AdminDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.traer_Proceso_Secado_AdminDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.traer_Proceso_Secado_AdminDataGridView.RowHeadersVisible = false;
            this.traer_Proceso_Secado_AdminDataGridView.Size = new System.Drawing.Size(611, 220);
            this.traer_Proceso_Secado_AdminDataGridView.TabIndex = 1;
            this.traer_Proceso_Secado_AdminDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.traer_Proceso_Secado_AdminDataGridView_CellDoubleClick);
            this.traer_Proceso_Secado_AdminDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.traer_Proceso_Secado_AdminDataGridView_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Proceso";
            this.dataGridViewTextBoxColumn1.HeaderText = "Proceso";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cod_Productor";
            this.dataGridViewTextBoxColumn3.HeaderText = "Productor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cod_Variedad";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cod_Variedad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Des_Variedad";
            this.dataGridViewTextBoxColumn5.HeaderText = "Variedad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Cod_Estado";
            this.dataGridViewTextBoxColumn6.HeaderText = "Cod_Estado";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn7.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Cod_productos";
            this.dataGridViewTextBoxColumn8.HeaderText = "Cod_productos";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Productos";
            this.dataGridViewTextBoxColumn9.HeaderText = "Productos";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Estados";
            this.dataGridViewTextBoxColumn10.HeaderText = "Estados";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Rut_Usuario";
            this.dataGridViewTextBoxColumn11.HeaderText = "Rut_Usuario";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.productosComboBox);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.nom_ProductorComboBox);
            this.groupBox1.Controls.Add(this.cod_ProductorTextBox);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CmbVariedad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 113);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.radioButton6);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(292, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 31);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(183, 8);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(62, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Cerrado";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(119, 8);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(58, 17);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Abierto";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(58, 8);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(55, 17);
            this.radioButton6.TabIndex = 1;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Todas";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Estado";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // productosComboBox
            // 
            this.productosComboBox.DataSource = this.productoBindingSource;
            this.productosComboBox.DisplayMember = "Productos";
            this.productosComboBox.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productosComboBox.FormattingEnabled = true;
            this.productosComboBox.Location = new System.Drawing.Point(134, 76);
            this.productosComboBox.Name = "productosComboBox";
            this.productosComboBox.Size = new System.Drawing.Size(134, 21);
            this.productosComboBox.TabIndex = 22;
            this.productosComboBox.ValueMember = "Cod_Productos";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.genesisDataSet1;
            // 
            // genesisDataSet1
            // 
            this.genesisDataSet1.DataSetName = "GenesisDataSet";
            this.genesisDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(66, 81);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Productos";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(481, 38);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(5);
            this.button8.Size = new System.Drawing.Size(70, 27);
            this.button8.TabIndex = 8;
            this.button8.Text = "Buscar";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // nom_ProductorComboBox
            // 
            this.nom_ProductorComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.nom_ProductorComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.nom_ProductorComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.nom_ProductorComboBox.DataSource = this.productoresBindingSource;
            this.nom_ProductorComboBox.DisplayMember = "Des_Productor";
            this.nom_ProductorComboBox.Font = new System.Drawing.Font("Yu Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_ProductorComboBox.ForeColor = System.Drawing.Color.Black;
            this.nom_ProductorComboBox.FormattingEnabled = true;
            this.nom_ProductorComboBox.Location = new System.Drawing.Point(173, 23);
            this.nom_ProductorComboBox.Name = "nom_ProductorComboBox";
            this.nom_ProductorComboBox.Size = new System.Drawing.Size(196, 22);
            this.nom_ProductorComboBox.TabIndex = 19;
            this.nom_ProductorComboBox.ValueMember = "Cod_Productor";
            this.nom_ProductorComboBox.SelectedIndexChanged += new System.EventHandler(this.nom_ProductorComboBox_SelectedIndexChanged);
            // 
            // productoresBindingSource
            // 
            this.productoresBindingSource.DataMember = "Productores";
            this.productoresBindingSource.DataSource = this.genesisDataSet1;
            // 
            // cod_ProductorTextBox
            // 
            this.cod_ProductorTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod_ProductorTextBox.Location = new System.Drawing.Point(134, 23);
            this.cod_ProductorTextBox.Name = "cod_ProductorTextBox";
            this.cod_ProductorTextBox.Size = new System.Drawing.Size(33, 22);
            this.cod_ProductorTextBox.TabIndex = 18;
            this.cod_ProductorTextBox.TextChanged += new System.EventHandler(this.cod_ProductorTextBox_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(376, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 23);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Variedad";
            // 
            // CmbVariedad
            // 
            this.CmbVariedad.DataSource = this.variedadBindingSource;
            this.CmbVariedad.DisplayMember = "Variedad";
            this.CmbVariedad.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbVariedad.FormattingEnabled = true;
            this.CmbVariedad.Location = new System.Drawing.Point(134, 49);
            this.CmbVariedad.Name = "CmbVariedad";
            this.CmbVariedad.Size = new System.Drawing.Size(134, 21);
            this.CmbVariedad.TabIndex = 9;
            this.CmbVariedad.ValueMember = "Cod_Variedad";
            // 
            // variedadBindingSource
            // 
            this.variedadBindingSource.DataMember = "Variedad";
            this.variedadBindingSource.DataSource = this.genesisDataSet1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Productor";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(2, 398);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 12);
            this.panel1.TabIndex = 24;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SteelBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(455, 416);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(5);
            this.button4.Size = new System.Drawing.Size(77, 28);
            this.button4.TabIndex = 27;
            this.button4.Text = "MODIFICAR";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Firebrick;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(546, 416);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(5);
            this.button3.Size = new System.Drawing.Size(77, 28);
            this.button3.TabIndex = 26;
            this.button3.Text = "ELIMINAR ";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(366, 416);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5);
            this.button1.Size = new System.Drawing.Size(77, 28);
            this.button1.TabIndex = 25;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(634, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // productoresTableAdapter
            // 
            this.productoresTableAdapter.ClearBeforeFill = true;
            // 
            // variedadTableAdapter
            // 
            this.variedadTableAdapter.ClearBeforeFill = true;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // FormAdmin_Secado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 451);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.traer_Proceso_Secado_AdminDataGridView);
            this.Name = "FormAdmin_Secado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin_Secado";
            this.Load += new System.EventHandler(this.FormAdmin_Secado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genesisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traer_Proceso_Secado_AdminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traer_Proceso_Secado_AdminDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genesisDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.variedadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GenesisDataSet genesisDataSet;
        private System.Windows.Forms.BindingSource traer_Proceso_Secado_AdminBindingSource;
        private GenesisDataSetTableAdapters.Traer_Proceso_Secado_AdminTableAdapter traer_Proceso_Secado_AdminTableAdapter;
        private GenesisDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView traer_Proceso_Secado_AdminDataGridView;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox productosComboBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox nom_ProductorComboBox;
        private System.Windows.Forms.TextBox cod_ProductorTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbVariedad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private GenesisDataSet genesisDataSet1;
        private System.Windows.Forms.BindingSource productoresBindingSource;
        private GenesisDataSetTableAdapters.ProductoresTableAdapter productoresTableAdapter;
        private System.Windows.Forms.BindingSource variedadBindingSource;
        private GenesisDataSetTableAdapters.VariedadTableAdapter variedadTableAdapter;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private GenesisDataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
    }
}