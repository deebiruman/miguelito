namespace Prototipo
{
    partial class DeclaracionFform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeclaracionFform));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.transparentPanel1 = new Prototipo.TransparentPanel();
            this.cerrarbtn = new System.Windows.Forms.Button();
            this.dragControl1 = new Prototipo.DragControl();
            this.clientelbl = new System.Windows.Forms.Label();
            this.fechaCrealbl = new System.Windows.Forms.Label();
            this.fechaCadulbl = new System.Windows.Forms.Label();
            this.declaralbl = new System.Windows.Forms.Label();
            this.seguroSlbl = new System.Windows.Forms.Label();
            this.dosporlbl = new System.Windows.Forms.Label();
            this.declaracionFdgv = new System.Windows.Forms.DataGridView();
            this.idclientesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechafnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.declaracionfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segurosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dospDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.declaracionfiscalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.declaracionDS = new Prototipo.DeclaracionDS();
            this.fecha_In = new System.Windows.Forms.DateTimePicker();
            this.fecha_Fn = new System.Windows.Forms.DateTimePicker();
            this.dospor = new System.Windows.Forms.DateTimePicker();
            this.seguros = new System.Windows.Forms.DateTimePicker();
            this.declaracion = new System.Windows.Forms.DateTimePicker();
            this.eliminarbtn = new System.Windows.Forms.Button();
            this.modificarbtn = new System.Windows.Forms.Button();
            this.agregarbtn = new System.Windows.Forms.Button();
            this.dgvdeclaracion_F = new System.Windows.Forms.DataGridView();
            this.idclientesDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdeclaracion_FX = new System.Windows.Forms.DataGridView();
            this.idclientesDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.declaracion_fiscalTableAdapter = new Prototipo.DeclaracionDSTableAdapters.declaracion_fiscalTableAdapter();
            this.long_id = new System.Windows.Forms.Label();
            this.val_fecha = new System.Windows.Forms.Label();
            this.val_id = new System.Windows.Forms.Label();
            this.transparentPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.declaracionFdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.declaracionfiscalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.declaracionDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeclaracion_F)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeclaracion_FX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Location = new System.Drawing.Point(34, 188);
            this.textBox1.MaxLength = 12;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Ebrima", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(332, 50);
            this.label7.TabIndex = 49;
            this.label7.Text = "Declaración Fiscal";
            // 
            // transparentPanel1
            // 
            this.transparentPanel1.Controls.Add(this.cerrarbtn);
            this.transparentPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.transparentPanel1.Location = new System.Drawing.Point(0, 0);
            this.transparentPanel1.Name = "transparentPanel1";
            this.transparentPanel1.Size = new System.Drawing.Size(909, 49);
            this.transparentPanel1.TabIndex = 50;
            // 
            // cerrarbtn
            // 
            this.cerrarbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cerrarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrarbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.cerrarbtn.FlatAppearance.BorderSize = 0;
            this.cerrarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrarbtn.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cerrarbtn.Location = new System.Drawing.Point(858, 0);
            this.cerrarbtn.Name = "cerrarbtn";
            this.cerrarbtn.Size = new System.Drawing.Size(51, 49);
            this.cerrarbtn.TabIndex = 50;
            this.cerrarbtn.Text = "X";
            this.cerrarbtn.UseVisualStyleBackColor = true;
            this.cerrarbtn.Click += new System.EventHandler(this.cerrarbtn_Click);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectoControl = this.transparentPanel1;
            // 
            // clientelbl
            // 
            this.clientelbl.AutoSize = true;
            this.clientelbl.BackColor = System.Drawing.Color.Transparent;
            this.clientelbl.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientelbl.Location = new System.Drawing.Point(30, 164);
            this.clientelbl.Name = "clientelbl";
            this.clientelbl.Size = new System.Drawing.Size(115, 21);
            this.clientelbl.TabIndex = 51;
            this.clientelbl.Text = "ID del cliente:";
            // 
            // fechaCrealbl
            // 
            this.fechaCrealbl.AutoSize = true;
            this.fechaCrealbl.BackColor = System.Drawing.Color.Transparent;
            this.fechaCrealbl.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaCrealbl.Location = new System.Drawing.Point(30, 236);
            this.fechaCrealbl.Name = "fechaCrealbl";
            this.fechaCrealbl.Size = new System.Drawing.Size(150, 21);
            this.fechaCrealbl.TabIndex = 52;
            this.fechaCrealbl.Text = "Fecha de creación:";
            // 
            // fechaCadulbl
            // 
            this.fechaCadulbl.AutoSize = true;
            this.fechaCadulbl.BackColor = System.Drawing.Color.Transparent;
            this.fechaCadulbl.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaCadulbl.Location = new System.Drawing.Point(30, 304);
            this.fechaCadulbl.Name = "fechaCadulbl";
            this.fechaCadulbl.Size = new System.Drawing.Size(164, 21);
            this.fechaCadulbl.TabIndex = 53;
            this.fechaCadulbl.Text = "Fecha de caducidad:";
            // 
            // declaralbl
            // 
            this.declaralbl.AutoSize = true;
            this.declaralbl.BackColor = System.Drawing.Color.Transparent;
            this.declaralbl.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.declaralbl.Location = new System.Drawing.Point(30, 374);
            this.declaralbl.Name = "declaralbl";
            this.declaralbl.Size = new System.Drawing.Size(105, 21);
            this.declaralbl.TabIndex = 54;
            this.declaralbl.Text = "Declaración:";
            // 
            // seguroSlbl
            // 
            this.seguroSlbl.AutoSize = true;
            this.seguroSlbl.BackColor = System.Drawing.Color.Transparent;
            this.seguroSlbl.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seguroSlbl.Location = new System.Drawing.Point(30, 448);
            this.seguroSlbl.Name = "seguroSlbl";
            this.seguroSlbl.Size = new System.Drawing.Size(116, 21);
            this.seguroSlbl.TabIndex = 55;
            this.seguroSlbl.Text = "Seguro social:";
            // 
            // dosporlbl
            // 
            this.dosporlbl.AutoSize = true;
            this.dosporlbl.BackColor = System.Drawing.Color.Transparent;
            this.dosporlbl.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dosporlbl.Location = new System.Drawing.Point(30, 514);
            this.dosporlbl.Name = "dosporlbl";
            this.dosporlbl.Size = new System.Drawing.Size(121, 21);
            this.dosporlbl.TabIndex = 56;
            this.dosporlbl.Text = "Dos porciento:";
            // 
            // declaracionFdgv
            // 
            this.declaracionFdgv.AutoGenerateColumns = false;
            this.declaracionFdgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.declaracionFdgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.declaracionFdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.declaracionFdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.declaracionFdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.declaracionFdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclientesDataGridViewTextBoxColumn,
            this.fechainDataGridViewTextBoxColumn,
            this.fechafnDataGridViewTextBoxColumn,
            this.declaracionfDataGridViewTextBoxColumn,
            this.segurosDataGridViewTextBoxColumn,
            this.dospDataGridViewTextBoxColumn});
            this.declaracionFdgv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.declaracionFdgv.DataSource = this.declaracionfiscalBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.declaracionFdgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.declaracionFdgv.EnableHeadersVisualStyles = false;
            this.declaracionFdgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            this.declaracionFdgv.Location = new System.Drawing.Point(222, 164);
            this.declaracionFdgv.MultiSelect = false;
            this.declaracionFdgv.Name = "declaracionFdgv";
            this.declaracionFdgv.ReadOnly = true;
            this.declaracionFdgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.declaracionFdgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.declaracionFdgv.Size = new System.Drawing.Size(643, 344);
            this.declaracionFdgv.TabIndex = 66;
            this.declaracionFdgv.TabStop = false;
            this.declaracionFdgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idclientesDataGridViewTextBoxColumn
            // 
            this.idclientesDataGridViewTextBoxColumn.DataPropertyName = "id_clientes";
            this.idclientesDataGridViewTextBoxColumn.HeaderText = "id_clientes";
            this.idclientesDataGridViewTextBoxColumn.Name = "idclientesDataGridViewTextBoxColumn";
            this.idclientesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechainDataGridViewTextBoxColumn
            // 
            this.fechainDataGridViewTextBoxColumn.DataPropertyName = "fecha_in";
            this.fechainDataGridViewTextBoxColumn.HeaderText = "fecha_in";
            this.fechainDataGridViewTextBoxColumn.Name = "fechainDataGridViewTextBoxColumn";
            this.fechainDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechafnDataGridViewTextBoxColumn
            // 
            this.fechafnDataGridViewTextBoxColumn.DataPropertyName = "fecha_fn";
            this.fechafnDataGridViewTextBoxColumn.HeaderText = "fecha_fn";
            this.fechafnDataGridViewTextBoxColumn.Name = "fechafnDataGridViewTextBoxColumn";
            this.fechafnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // declaracionfDataGridViewTextBoxColumn
            // 
            this.declaracionfDataGridViewTextBoxColumn.DataPropertyName = "declaracion_f";
            this.declaracionfDataGridViewTextBoxColumn.HeaderText = "declaracion_f";
            this.declaracionfDataGridViewTextBoxColumn.Name = "declaracionfDataGridViewTextBoxColumn";
            this.declaracionfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // segurosDataGridViewTextBoxColumn
            // 
            this.segurosDataGridViewTextBoxColumn.DataPropertyName = "seguro_s";
            this.segurosDataGridViewTextBoxColumn.HeaderText = "seguro_s";
            this.segurosDataGridViewTextBoxColumn.Name = "segurosDataGridViewTextBoxColumn";
            this.segurosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dospDataGridViewTextBoxColumn
            // 
            this.dospDataGridViewTextBoxColumn.DataPropertyName = "dos_p";
            this.dospDataGridViewTextBoxColumn.HeaderText = "dos_p";
            this.dospDataGridViewTextBoxColumn.Name = "dospDataGridViewTextBoxColumn";
            this.dospDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // declaracionfiscalBindingSource
            // 
            this.declaracionfiscalBindingSource.DataMember = "declaracion_fiscal";
            this.declaracionfiscalBindingSource.DataSource = this.declaracionDS;
            // 
            // declaracionDS
            // 
            this.declaracionDS.DataSetName = "DeclaracionDS";
            this.declaracionDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fecha_In
            // 
            this.fecha_In.CustomFormat = "yyyy/MM/dd";
            this.fecha_In.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_In.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha_In.Location = new System.Drawing.Point(34, 260);
            this.fecha_In.Name = "fecha_In";
            this.fecha_In.Size = new System.Drawing.Size(160, 22);
            this.fecha_In.TabIndex = 2;
            // 
            // fecha_Fn
            // 
            this.fecha_Fn.CustomFormat = "yyyy/MM/dd";
            this.fecha_Fn.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.fecha_Fn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha_Fn.Location = new System.Drawing.Point(34, 328);
            this.fecha_Fn.Name = "fecha_Fn";
            this.fecha_Fn.Size = new System.Drawing.Size(160, 22);
            this.fecha_Fn.TabIndex = 3;
            this.fecha_Fn.ValueChanged += new System.EventHandler(this.fecha_Fn_ValueChanged);
            // 
            // dospor
            // 
            this.dospor.CustomFormat = "yyyy/MM/dd";
            this.dospor.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.dospor.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dospor.Location = new System.Drawing.Point(34, 538);
            this.dospor.Name = "dospor";
            this.dospor.Size = new System.Drawing.Size(160, 22);
            this.dospor.TabIndex = 6;
            // 
            // seguros
            // 
            this.seguros.CustomFormat = "yyyy/MM/dd";
            this.seguros.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.seguros.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.seguros.Location = new System.Drawing.Point(34, 472);
            this.seguros.Name = "seguros";
            this.seguros.Size = new System.Drawing.Size(160, 22);
            this.seguros.TabIndex = 5;
            // 
            // declaracion
            // 
            this.declaracion.CustomFormat = "yyyy/MM/dd";
            this.declaracion.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.declaracion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.declaracion.Location = new System.Drawing.Point(34, 398);
            this.declaracion.Name = "declaracion";
            this.declaracion.Size = new System.Drawing.Size(160, 22);
            this.declaracion.TabIndex = 4;
            // 
            // eliminarbtn
            // 
            this.eliminarbtn.BackColor = System.Drawing.Color.IndianRed;
            this.eliminarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarbtn.FlatAppearance.BorderSize = 0;
            this.eliminarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.eliminarbtn.Location = new System.Drawing.Point(92, 599);
            this.eliminarbtn.Name = "eliminarbtn";
            this.eliminarbtn.Size = new System.Drawing.Size(52, 40);
            this.eliminarbtn.TabIndex = 8;
            this.eliminarbtn.Text = "✖️";
            this.eliminarbtn.UseVisualStyleBackColor = false;
            this.eliminarbtn.Click += new System.EventHandler(this.eliminarbtn_Click);
            // 
            // modificarbtn
            // 
            this.modificarbtn.BackColor = System.Drawing.Color.Gold;
            this.modificarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificarbtn.FlatAppearance.BorderSize = 0;
            this.modificarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.modificarbtn.Location = new System.Drawing.Point(34, 599);
            this.modificarbtn.Name = "modificarbtn";
            this.modificarbtn.Size = new System.Drawing.Size(52, 40);
            this.modificarbtn.TabIndex = 9;
            this.modificarbtn.Text = "✏️";
            this.modificarbtn.UseVisualStyleBackColor = false;
            this.modificarbtn.Click += new System.EventHandler(this.modificarbtn_Click);
            // 
            // agregarbtn
            // 
            this.agregarbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(197)))), ((int)(((byte)(61)))));
            this.agregarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarbtn.FlatAppearance.BorderSize = 0;
            this.agregarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.agregarbtn.Location = new System.Drawing.Point(150, 599);
            this.agregarbtn.Name = "agregarbtn";
            this.agregarbtn.Size = new System.Drawing.Size(52, 40);
            this.agregarbtn.TabIndex = 7;
            this.agregarbtn.Text = "✔️";
            this.agregarbtn.UseVisualStyleBackColor = false;
            this.agregarbtn.Click += new System.EventHandler(this.agregarbtn_Click);
            // 
            // dgvdeclaracion_F
            // 
            this.dgvdeclaracion_F.AutoGenerateColumns = false;
            this.dgvdeclaracion_F.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvdeclaracion_F.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdeclaracion_F.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdeclaracion_F.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvdeclaracion_F.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdeclaracion_F.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclientesDataGridViewTextBoxColumn2});
            this.dgvdeclaracion_F.DataSource = this.declaracionfiscalBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdeclaracion_F.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvdeclaracion_F.EnableHeadersVisualStyles = false;
            this.dgvdeclaracion_F.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            this.dgvdeclaracion_F.Location = new System.Drawing.Point(222, 527);
            this.dgvdeclaracion_F.MultiSelect = false;
            this.dgvdeclaracion_F.Name = "dgvdeclaracion_F";
            this.dgvdeclaracion_F.ReadOnly = true;
            this.dgvdeclaracion_F.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdeclaracion_F.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvdeclaracion_F.Size = new System.Drawing.Size(175, 301);
            this.dgvdeclaracion_F.TabIndex = 67;
            this.dgvdeclaracion_F.TabStop = false;
            this.dgvdeclaracion_F.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdeclaracion_F_CellClick);
            // 
            // idclientesDataGridViewTextBoxColumn2
            // 
            this.idclientesDataGridViewTextBoxColumn2.DataPropertyName = "id_clientes";
            this.idclientesDataGridViewTextBoxColumn2.HeaderText = "Documentos expirados";
            this.idclientesDataGridViewTextBoxColumn2.Name = "idclientesDataGridViewTextBoxColumn2";
            this.idclientesDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dgvdeclaracion_FX
            // 
            this.dgvdeclaracion_FX.AutoGenerateColumns = false;
            this.dgvdeclaracion_FX.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvdeclaracion_FX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdeclaracion_FX.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdeclaracion_FX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvdeclaracion_FX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdeclaracion_FX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclientesDataGridViewTextBoxColumn3});
            this.dgvdeclaracion_FX.DataSource = this.declaracionfiscalBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdeclaracion_FX.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvdeclaracion_FX.EnableHeadersVisualStyles = false;
            this.dgvdeclaracion_FX.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            this.dgvdeclaracion_FX.Location = new System.Drawing.Point(427, 527);
            this.dgvdeclaracion_FX.MultiSelect = false;
            this.dgvdeclaracion_FX.Name = "dgvdeclaracion_FX";
            this.dgvdeclaracion_FX.ReadOnly = true;
            this.dgvdeclaracion_FX.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdeclaracion_FX.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvdeclaracion_FX.Size = new System.Drawing.Size(175, 301);
            this.dgvdeclaracion_FX.TabIndex = 68;
            this.dgvdeclaracion_FX.TabStop = false;
            this.dgvdeclaracion_FX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdeclaracion_FX_CellClick);
            // 
            // idclientesDataGridViewTextBoxColumn3
            // 
            this.idclientesDataGridViewTextBoxColumn3.DataPropertyName = "id_clientes";
            this.idclientesDataGridViewTextBoxColumn3.HeaderText = "Documentos por expirar";
            this.idclientesDataGridViewTextBoxColumn3.Name = "idclientesDataGridViewTextBoxColumn3";
            this.idclientesDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Prototipo.Properties.Resources.fiscal;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(664, 599);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 268);
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // declaracion_fiscalTableAdapter
            // 
            this.declaracion_fiscalTableAdapter.ClearBeforeFill = true;
            // 
            // long_id
            // 
            this.long_id.AutoSize = true;
            this.long_id.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.long_id.ForeColor = System.Drawing.Color.Red;
            this.long_id.Location = new System.Drawing.Point(31, 213);
            this.long_id.Name = "long_id";
            this.long_id.Size = new System.Drawing.Size(135, 17);
            this.long_id.TabIndex = 69;
            this.long_id.Text = "Longitud mínima de 8";
            this.long_id.Visible = false;
            // 
            // val_fecha
            // 
            this.val_fecha.AutoSize = true;
            this.val_fecha.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val_fecha.ForeColor = System.Drawing.Color.Red;
            this.val_fecha.Location = new System.Drawing.Point(33, 353);
            this.val_fecha.Name = "val_fecha";
            this.val_fecha.Size = new System.Drawing.Size(147, 17);
            this.val_fecha.TabIndex = 75;
            this.val_fecha.Text = "Introduzca bien la fecha";
            this.val_fecha.Visible = false;
            // 
            // val_id
            // 
            this.val_id.AutoSize = true;
            this.val_id.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val_id.ForeColor = System.Drawing.Color.Red;
            this.val_id.Location = new System.Drawing.Point(33, 147);
            this.val_id.Name = "val_id";
            this.val_id.Size = new System.Drawing.Size(162, 17);
            this.val_id.TabIndex = 76;
            this.val_id.Text = "Sólo se permiten números";
            this.val_id.Visible = false;
            // 
            // DeclaracionFform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(909, 854);
            this.Controls.Add(this.val_id);
            this.Controls.Add(this.val_fecha);
            this.Controls.Add(this.long_id);
            this.Controls.Add(this.dgvdeclaracion_FX);
            this.Controls.Add(this.dgvdeclaracion_F);
            this.Controls.Add(this.eliminarbtn);
            this.Controls.Add(this.modificarbtn);
            this.Controls.Add(this.agregarbtn);
            this.Controls.Add(this.declaracion);
            this.Controls.Add(this.seguros);
            this.Controls.Add(this.dospor);
            this.Controls.Add(this.fecha_Fn);
            this.Controls.Add(this.fecha_In);
            this.Controls.Add(this.declaracionFdgv);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dosporlbl);
            this.Controls.Add(this.seguroSlbl);
            this.Controls.Add(this.declaralbl);
            this.Controls.Add(this.fechaCadulbl);
            this.Controls.Add(this.fechaCrealbl);
            this.Controls.Add(this.clientelbl);
            this.Controls.Add(this.transparentPanel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeclaracionFform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Declaracion Fiscal";
            this.Load += new System.EventHandler(this.DeclaracionF_Load);
            this.transparentPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.declaracionFdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.declaracionfiscalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.declaracionDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeclaracion_F)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeclaracion_FX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private TransparentPanel transparentPanel1;
        private System.Windows.Forms.Button cerrarbtn;
        private DragControl dragControl1;
        private System.Windows.Forms.Label clientelbl;
        private System.Windows.Forms.Label fechaCrealbl;
        private System.Windows.Forms.Label fechaCadulbl;
        private System.Windows.Forms.Label declaralbl;
        private System.Windows.Forms.Label seguroSlbl;
        private System.Windows.Forms.Label dosporlbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView declaracionFdgv;
        //private modelo.El_Pana_MiguelDataSet4 el_Pana_MiguelDataSet4;
        //private modelo.El_Pana_MiguelDataSet4TableAdapters.declaración_fiscalTableAdapter declaración_fiscalTableAdapter;
        private System.Windows.Forms.DateTimePicker fecha_In;
        private System.Windows.Forms.DateTimePicker fecha_Fn;
        private System.Windows.Forms.DateTimePicker dospor;
        private System.Windows.Forms.DateTimePicker seguros;
        private System.Windows.Forms.DateTimePicker declaracion;
        //private modelo.miguelitoDataSet10TableAdapters.declaracion_fiscalTableAdapter declaracion_fiscalTableAdapter1;
        private System.Windows.Forms.Button eliminarbtn;
        private System.Windows.Forms.Button modificarbtn;
        private System.Windows.Forms.Button agregarbtn;
        private System.Windows.Forms.DataGridView dgvdeclaracion_F;
        private System.Windows.Forms.DataGridView dgvdeclaracion_FX;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DeclaracionDS declaracionDS;
        private System.Windows.Forms.BindingSource declaracionfiscalBindingSource;
        private DeclaracionDSTableAdapters.declaracion_fiscalTableAdapter declaracion_fiscalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechafnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn declaracionfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn segurosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dospDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientesDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientesDataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label long_id;
        private System.Windows.Forms.Label val_fecha;
        private System.Windows.Forms.Label val_id;
    }
}