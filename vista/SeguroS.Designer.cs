namespace Prototipo
{
    partial class SeguroSform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeguroSform));
            this.transparentPanel1 = new Prototipo.TransparentPanel();
            this.cerrarbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clientelbl = new System.Windows.Forms.Label();
            this.clientetxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dragControl1 = new Prototipo.DragControl();
            this.seguroSdgv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segurosocialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seguroDS = new Prototipo.SeguroDS();
            this.fecha_In = new System.Windows.Forms.DateTimePicker();
            this.fecha_Fn = new System.Windows.Forms.DateTimePicker();
            this.eliminarbtn = new System.Windows.Forms.Button();
            this.modificarbtn = new System.Windows.Forms.Button();
            this.agregarbtn = new System.Windows.Forms.Button();
            this.dgvsguro_S = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvsguro_SX = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.seguro_socialTableAdapter = new Prototipo.SeguroDSTableAdapters.seguro_socialTableAdapter();
            this.transparentPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seguroSdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segurosocialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seguroDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsguro_S)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsguro_SX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // transparentPanel1
            // 
            this.transparentPanel1.Controls.Add(this.cerrarbtn);
            this.transparentPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.transparentPanel1.Location = new System.Drawing.Point(0, 0);
            this.transparentPanel1.Name = "transparentPanel1";
            this.transparentPanel1.Size = new System.Drawing.Size(763, 49);
            this.transparentPanel1.TabIndex = 62;
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
            this.cerrarbtn.Location = new System.Drawing.Point(712, 0);
            this.cerrarbtn.Name = "cerrarbtn";
            this.cerrarbtn.Size = new System.Drawing.Size(51, 49);
            this.cerrarbtn.TabIndex = 50;
            this.cerrarbtn.Text = "X";
            this.cerrarbtn.UseVisualStyleBackColor = true;
            this.cerrarbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 21);
            this.label3.TabIndex = 61;
            this.label3.Text = "Fecha de Caducidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 21);
            this.label2.TabIndex = 60;
            this.label2.Text = "Fecha de creación:";
            // 
            // clientelbl
            // 
            this.clientelbl.AutoSize = true;
            this.clientelbl.BackColor = System.Drawing.Color.Transparent;
            this.clientelbl.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientelbl.Location = new System.Drawing.Point(30, 164);
            this.clientelbl.Name = "clientelbl";
            this.clientelbl.Size = new System.Drawing.Size(115, 21);
            this.clientelbl.TabIndex = 59;
            this.clientelbl.Text = "ID del cliente:";
            // 
            // clientetxt
            // 
            this.clientetxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clientetxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientetxt.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientetxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clientetxt.Location = new System.Drawing.Point(34, 188);
            this.clientetxt.MaxLength = 12;
            this.clientetxt.Name = "clientetxt";
            this.clientetxt.Size = new System.Drawing.Size(162, 22);
            this.clientetxt.TabIndex = 1;
            this.clientetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clientetxt_KeyPress);
            this.clientetxt.Leave += new System.EventHandler(this.clientetxt_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ebrima", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 50);
            this.label4.TabIndex = 55;
            this.label4.Text = "Seguro Social";
            // 
            // dragControl1
            // 
            this.dragControl1.SelectoControl = this.transparentPanel1;
            // 
            // seguroSdgv
            // 
            this.seguroSdgv.AutoGenerateColumns = false;
            this.seguroSdgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.seguroSdgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.seguroSdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.seguroSdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.seguroSdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seguroSdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.seguroSdgv.Cursor = System.Windows.Forms.Cursors.Default;
            this.seguroSdgv.DataSource = this.segurosocialBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.seguroSdgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.seguroSdgv.EnableHeadersVisualStyles = false;
            this.seguroSdgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            this.seguroSdgv.Location = new System.Drawing.Point(244, 164);
            this.seguroSdgv.MultiSelect = false;
            this.seguroSdgv.Name = "seguroSdgv";
            this.seguroSdgv.ReadOnly = true;
            this.seguroSdgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.seguroSdgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.seguroSdgv.Size = new System.Drawing.Size(477, 258);
            this.seguroSdgv.TabIndex = 66;
            this.seguroSdgv.TabStop = false;
            this.seguroSdgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_clientes";
            this.dataGridViewTextBoxColumn4.HeaderText = "id_clientes";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 145;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 145;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "fecha_in";
            this.dataGridViewTextBoxColumn5.HeaderText = "fecha_in";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 145;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 145;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "fecha_fn";
            this.dataGridViewTextBoxColumn6.HeaderText = "fecha_fn";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 145;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 145;
            // 
            // segurosocialBindingSource
            // 
            this.segurosocialBindingSource.DataMember = "seguro_social";
            this.segurosocialBindingSource.DataSource = this.seguroDS;
            // 
            // seguroDS
            // 
            this.seguroDS.DataSetName = "SeguroDS";
            this.seguroDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fecha_In
            // 
            this.fecha_In.CalendarFont = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_In.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fecha_In.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fecha_In.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fecha_In.CustomFormat = "yyyy/MM/dd";
            this.fecha_In.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_In.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha_In.Location = new System.Drawing.Point(34, 260);
            this.fecha_In.Name = "fecha_In";
            this.fecha_In.Size = new System.Drawing.Size(162, 22);
            this.fecha_In.TabIndex = 2;
            // 
            // fecha_Fn
            // 
            this.fecha_Fn.CustomFormat = "yyyy/MM/dd";
            this.fecha_Fn.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_Fn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha_Fn.Location = new System.Drawing.Point(34, 339);
            this.fecha_Fn.Name = "fecha_Fn";
            this.fecha_Fn.Size = new System.Drawing.Size(162, 22);
            this.fecha_Fn.TabIndex = 3;
            // 
            // eliminarbtn
            // 
            this.eliminarbtn.BackColor = System.Drawing.Color.IndianRed;
            this.eliminarbtn.FlatAppearance.BorderSize = 0;
            this.eliminarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.eliminarbtn.Location = new System.Drawing.Point(92, 404);
            this.eliminarbtn.Name = "eliminarbtn";
            this.eliminarbtn.Size = new System.Drawing.Size(52, 40);
            this.eliminarbtn.TabIndex = 5;
            this.eliminarbtn.Text = "✖️";
            this.eliminarbtn.UseVisualStyleBackColor = false;
            this.eliminarbtn.Click += new System.EventHandler(this.eliminarbtn_Click);
            // 
            // modificarbtn
            // 
            this.modificarbtn.BackColor = System.Drawing.Color.Gold;
            this.modificarbtn.FlatAppearance.BorderSize = 0;
            this.modificarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.modificarbtn.Location = new System.Drawing.Point(34, 404);
            this.modificarbtn.Name = "modificarbtn";
            this.modificarbtn.Size = new System.Drawing.Size(52, 40);
            this.modificarbtn.TabIndex = 6;
            this.modificarbtn.Text = "✏️";
            this.modificarbtn.UseVisualStyleBackColor = false;
            this.modificarbtn.Click += new System.EventHandler(this.modificarbtn_Click);
            // 
            // agregarbtn
            // 
            this.agregarbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(197)))), ((int)(((byte)(61)))));
            this.agregarbtn.FlatAppearance.BorderSize = 0;
            this.agregarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.agregarbtn.Location = new System.Drawing.Point(150, 404);
            this.agregarbtn.Name = "agregarbtn";
            this.agregarbtn.Size = new System.Drawing.Size(52, 40);
            this.agregarbtn.TabIndex = 4;
            this.agregarbtn.Text = "✔️";
            this.agregarbtn.UseVisualStyleBackColor = false;
            this.agregarbtn.Click += new System.EventHandler(this.agregarbtn_Click);
            // 
            // dgvsguro_S
            // 
            this.dgvsguro_S.AutoGenerateColumns = false;
            this.dgvsguro_S.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvsguro_S.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvsguro_S.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsguro_S.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvsguro_S.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsguro_S.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10});
            this.dgvsguro_S.DataSource = this.segurosocialBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvsguro_S.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvsguro_S.EnableHeadersVisualStyles = false;
            this.dgvsguro_S.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            this.dgvsguro_S.Location = new System.Drawing.Point(414, 441);
            this.dgvsguro_S.MultiSelect = false;
            this.dgvsguro_S.Name = "dgvsguro_S";
            this.dgvsguro_S.ReadOnly = true;
            this.dgvsguro_S.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsguro_S.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvsguro_S.Size = new System.Drawing.Size(144, 278);
            this.dgvsguro_S.TabIndex = 67;
            this.dgvsguro_S.TabStop = false;
            this.dgvsguro_S.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsguro_S_CellClick);
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "id_clientes";
            this.dataGridViewTextBoxColumn10.HeaderText = "Documentos por expirar";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dgvsguro_SX
            // 
            this.dgvsguro_SX.AutoGenerateColumns = false;
            this.dgvsguro_SX.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvsguro_SX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvsguro_SX.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsguro_SX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvsguro_SX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsguro_SX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7});
            this.dgvsguro_SX.DataSource = this.segurosocialBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvsguro_SX.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvsguro_SX.EnableHeadersVisualStyles = false;
            this.dgvsguro_SX.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            this.dgvsguro_SX.Location = new System.Drawing.Point(244, 441);
            this.dgvsguro_SX.MultiSelect = false;
            this.dgvsguro_SX.Name = "dgvsguro_SX";
            this.dgvsguro_SX.ReadOnly = true;
            this.dgvsguro_SX.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsguro_SX.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvsguro_SX.Size = new System.Drawing.Size(144, 278);
            this.dgvsguro_SX.TabIndex = 68;
            this.dgvsguro_SX.TabStop = false;
            this.dgvsguro_SX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsguro_SX_CellClick);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "id_clientes";
            this.dataGridViewTextBoxColumn7.HeaderText = "Documentos expirados";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Prototipo.Properties.Resources.instituto;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(564, 553);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 216);
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // seguro_socialTableAdapter
            // 
            this.seguro_socialTableAdapter.ClearBeforeFill = true;
            // 
            // SeguroSform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(763, 748);
            this.Controls.Add(this.dgvsguro_SX);
            this.Controls.Add(this.dgvsguro_S);
            this.Controls.Add(this.eliminarbtn);
            this.Controls.Add(this.modificarbtn);
            this.Controls.Add(this.agregarbtn);
            this.Controls.Add(this.fecha_Fn);
            this.Controls.Add(this.fecha_In);
            this.Controls.Add(this.seguroSdgv);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.transparentPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientelbl);
            this.Controls.Add(this.clientetxt);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SeguroSform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seguro Social";
            this.Load += new System.EventHandler(this.SeguroS_Load);
            this.transparentPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seguroSdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segurosocialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seguroDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsguro_S)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsguro_SX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TransparentPanel transparentPanel1;
        private System.Windows.Forms.Button cerrarbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label clientelbl;
        private System.Windows.Forms.TextBox clientetxt;
        private System.Windows.Forms.Label label4;
        private DragControl dragControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView seguroSdgv;
        //private modelo.El_Pana_MiguelDataSet3TableAdapters.seguro_socialTableAdapter seguro_socialTableAdapter;
        private System.Windows.Forms.DateTimePicker fecha_In;
        private System.Windows.Forms.DateTimePicker fecha_Fn;
        //private modelo.miguelitoDataSet7TableAdapters.seguro_socialTableAdapter seguro_socialTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechafnDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button eliminarbtn;
        private System.Windows.Forms.Button modificarbtn;
        private System.Windows.Forms.Button agregarbtn;
        private System.Windows.Forms.DataGridView dgvsguro_S;
        private System.Windows.Forms.DataGridView dgvsguro_SX;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientesDataGridViewTextBoxColumn1;
        private SeguroDS seguroDS;
        private System.Windows.Forms.BindingSource segurosocialBindingSource;
        private SeguroDSTableAdapters.seguro_socialTableAdapter seguro_socialTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        //  private SeguroDSTableAdapters.seguro_socialTableAdapter seguro_socialTableAdapter3;
    }
}