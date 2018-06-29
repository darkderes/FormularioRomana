namespace FormularioRomana
{
    partial class FormSecado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSecado));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.traerProcesosSecadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genesisDataSet1 = new FormularioRomana.GenesisDataSet();
            this.button8 = new System.Windows.Forms.Button();
            this.nom_ProductorComboBox = new System.Windows.Forms.ComboBox();
            this.productoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genesisDataSet = new FormularioRomana.GenesisDataSet();
            this.cod_ProductorTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbVariedad = new System.Windows.Forms.ComboBox();
            this.traerVariedadSecadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.productoresTableAdapter = new FormularioRomana.GenesisDataSetTableAdapters.ProductoresTableAdapter();
            this.tableAdapterManager = new FormularioRomana.GenesisDataSetTableAdapters.TableAdapterManager();
            this.traer_Variedad_SecadoTableAdapter = new FormularioRomana.GenesisDataSetTableAdapters.Traer_Variedad_SecadoTableAdapter();
            this.traer_Procesos_SecadoTableAdapter = new FormularioRomana.GenesisDataSetTableAdapters.Traer_Procesos_SecadoTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.traerTarjasSecadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.traer_Tarjas_SecadoTableAdapter = new FormularioRomana.GenesisDataSetTableAdapters.Traer_Tarjas_SecadoTableAdapter();
            this.Tarjas_check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tarjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.variedadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.Lbl_Tarjas_Totales = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Lbl_Tarjas_Seleccionados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traerProcesosSecadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genesisDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genesisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traerVariedadSecadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traerTarjasSecadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(806, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.nom_ProductorComboBox);
            this.groupBox1.Controls.Add(this.cod_ProductorTextBox);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CmbVariedad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(189, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 120);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Lotes";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.traerProcesosSecadoBindingSource;
            this.comboBox1.DisplayMember = "Num_Proceso";
            this.comboBox1.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(116, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.ValueMember = "Num_Proceso";
            // 
            // traerProcesosSecadoBindingSource
            // 
            this.traerProcesosSecadoBindingSource.DataMember = "Traer_Procesos_Secado";
            this.traerProcesosSecadoBindingSource.DataSource = this.genesisDataSet1;
            // 
            // genesisDataSet1
            // 
            this.genesisDataSet1.DataSetName = "GenesisDataSet";
            this.genesisDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(318, 75);
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
            this.nom_ProductorComboBox.Location = new System.Drawing.Point(155, 24);
            this.nom_ProductorComboBox.Name = "nom_ProductorComboBox";
            this.nom_ProductorComboBox.Size = new System.Drawing.Size(196, 22);
            this.nom_ProductorComboBox.TabIndex = 19;
            this.nom_ProductorComboBox.ValueMember = "Cod_Productor";
            this.nom_ProductorComboBox.SelectedIndexChanged += new System.EventHandler(this.nom_ProductorComboBox_SelectedIndexChanged);
            // 
            // productoresBindingSource
            // 
            this.productoresBindingSource.DataMember = "Productores";
            this.productoresBindingSource.DataSource = this.genesisDataSet;
            // 
            // genesisDataSet
            // 
            this.genesisDataSet.DataSetName = "GenesisDataSet";
            this.genesisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cod_ProductorTextBox
            // 
            this.cod_ProductorTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod_ProductorTextBox.Location = new System.Drawing.Point(116, 24);
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
            this.button2.Location = new System.Drawing.Point(358, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 23);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Variedad";
            // 
            // CmbVariedad
            // 
            this.CmbVariedad.DataSource = this.traerVariedadSecadoBindingSource;
            this.CmbVariedad.DisplayMember = "Des_Variedad";
            this.CmbVariedad.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbVariedad.FormattingEnabled = true;
            this.CmbVariedad.Location = new System.Drawing.Point(116, 50);
            this.CmbVariedad.Name = "CmbVariedad";
            this.CmbVariedad.Size = new System.Drawing.Size(134, 21);
            this.CmbVariedad.TabIndex = 9;
            this.CmbVariedad.ValueMember = "Cod_Variedad";
            this.CmbVariedad.SelectedIndexChanged += new System.EventHandler(this.CmbVariedad_SelectedIndexChanged);
            // 
            // traerVariedadSecadoBindingSource
            // 
            this.traerVariedadSecadoBindingSource.DataMember = "Traer_Variedad_Secado";
            this.traerVariedadSecadoBindingSource.DataSource = this.genesisDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Productor";
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
            this.tableAdapterManager.Romana_SecaTableAdapter = null;
            this.tableAdapterManager.RomanaTableAdapter = null;
            this.tableAdapterManager.Tarja_RecepcionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FormularioRomana.GenesisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VariedadTableAdapter = null;
            // 
            // traer_Variedad_SecadoTableAdapter
            // 
            this.traer_Variedad_SecadoTableAdapter.ClearBeforeFill = true;
            // 
            // traer_Procesos_SecadoTableAdapter
            // 
            this.traer_Procesos_SecadoTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tarjas_check,
            this.tarjaDataGridViewTextBoxColumn,
            this.loteDataGridViewTextBoxColumn,
            this.variedadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.traerTarjasSecadoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(337, 353);
            this.dataGridView1.TabIndex = 24;
            // 
            // traerTarjasSecadoBindingSource
            // 
            this.traerTarjasSecadoBindingSource.DataMember = "Traer_Tarjas_Secado";
            this.traerTarjasSecadoBindingSource.DataSource = this.genesisDataSet1;
            // 
            // traer_Tarjas_SecadoTableAdapter
            // 
            this.traer_Tarjas_SecadoTableAdapter.ClearBeforeFill = true;
            // 
            // Tarjas_check
            // 
            this.Tarjas_check.HeaderText = "Todas";
            this.Tarjas_check.Name = "Tarjas_check";
            this.Tarjas_check.Width = 50;
            // 
            // tarjaDataGridViewTextBoxColumn
            // 
            this.tarjaDataGridViewTextBoxColumn.DataPropertyName = "Tarja";
            this.tarjaDataGridViewTextBoxColumn.HeaderText = "Tarja";
            this.tarjaDataGridViewTextBoxColumn.Name = "tarjaDataGridViewTextBoxColumn";
            this.tarjaDataGridViewTextBoxColumn.Width = 80;
            // 
            // loteDataGridViewTextBoxColumn
            // 
            this.loteDataGridViewTextBoxColumn.DataPropertyName = "Lote";
            this.loteDataGridViewTextBoxColumn.HeaderText = "Lote";
            this.loteDataGridViewTextBoxColumn.Name = "loteDataGridViewTextBoxColumn";
            this.loteDataGridViewTextBoxColumn.Width = 80;
            // 
            // variedadDataGridViewTextBoxColumn
            // 
            this.variedadDataGridViewTextBoxColumn.DataPropertyName = "Variedad";
            this.variedadDataGridViewTextBoxColumn.HeaderText = "Variedad";
            this.variedadDataGridViewTextBoxColumn.Name = "variedadDataGridViewTextBoxColumn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tarjas de entrada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(561, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Vaciado Tarjas";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(436, 245);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView2.Size = new System.Drawing.Size(337, 353);
            this.dataGridView2.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(361, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 33);
            this.button1.TabIndex = 28;
            this.button1.Text = "->";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(361, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 33);
            this.button3.TabIndex = 29;
            this.button3.Text = "<-";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 222);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(167, 17);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.Text = "Seleccionar/Desmarcar todas";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(436, 222);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(167, 17);
            this.checkBox2.TabIndex = 31;
            this.checkBox2.Text = "Seleccionar/Desmarcar todas";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Lbl_Tarjas_Totales
            // 
            this.Lbl_Tarjas_Totales.AutoSize = true;
            this.Lbl_Tarjas_Totales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tarjas_Totales.Location = new System.Drawing.Point(109, 602);
            this.Lbl_Tarjas_Totales.Name = "Lbl_Tarjas_Totales";
            this.Lbl_Tarjas_Totales.Size = new System.Drawing.Size(16, 16);
            this.Lbl_Tarjas_Totales.TabIndex = 32;
            this.Lbl_Tarjas_Totales.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 602);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Total tarjas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(166, 601);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Tarjas seleccionadas:";
            // 
            // Lbl_Tarjas_Seleccionados
            // 
            this.Lbl_Tarjas_Seleccionados.AutoSize = true;
            this.Lbl_Tarjas_Seleccionados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tarjas_Seleccionados.Location = new System.Drawing.Point(328, 602);
            this.Lbl_Tarjas_Seleccionados.Name = "Lbl_Tarjas_Seleccionados";
            this.Lbl_Tarjas_Seleccionados.Size = new System.Drawing.Size(16, 16);
            this.Lbl_Tarjas_Seleccionados.TabIndex = 34;
            this.Lbl_Tarjas_Seleccionados.Text = "0";
            // 
            // FormSecado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 640);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Lbl_Tarjas_Seleccionados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Lbl_Tarjas_Totales);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormSecado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSecado";
            this.Load += new System.EventHandler(this.FormSecado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traerProcesosSecadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genesisDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genesisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traerVariedadSecadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traerTarjasSecadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox nom_ProductorComboBox;
        private System.Windows.Forms.TextBox cod_ProductorTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbVariedad;
        private System.Windows.Forms.Label label3;
        private GenesisDataSet genesisDataSet;
        private System.Windows.Forms.BindingSource productoresBindingSource;
        private GenesisDataSetTableAdapters.ProductoresTableAdapter productoresTableAdapter;
        private GenesisDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource traerVariedadSecadoBindingSource;
        private GenesisDataSetTableAdapters.Traer_Variedad_SecadoTableAdapter traer_Variedad_SecadoTableAdapter;
        private System.Windows.Forms.BindingSource traerProcesosSecadoBindingSource;
        private GenesisDataSet genesisDataSet1;
        private GenesisDataSetTableAdapters.Traer_Procesos_SecadoTableAdapter traer_Procesos_SecadoTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource traerTarjasSecadoBindingSource;
        private GenesisDataSetTableAdapters.Traer_Tarjas_SecadoTableAdapter traer_Tarjas_SecadoTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Tarjas_check;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn variedadDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label Lbl_Tarjas_Totales;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Lbl_Tarjas_Seleccionados;
    }
}