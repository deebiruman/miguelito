﻿namespace Prototipo
{
    partial class SelloD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelloD));
            this.label4 = new System.Windows.Forms.Label();
            this.clientetxt = new System.Windows.Forms.TextBox();
            this.clientelbl = new System.Windows.Forms.Label();
            this.fechaCrealbl = new System.Windows.Forms.Label();
            this.fechaCadulbl = new System.Windows.Forms.Label();
            this.SelloDdgv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellodigitalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selloDS = new Prototipo.SelloDS();
            this.fecha_In = new System.Windows.Forms.DateTimePicker();
            this.fecha_Fn = new System.Windows.Forms.DateTimePicker();
            this.transparentPanel1 = new Prototipo.TransparentPanel();
            this.cerrarbtn = new System.Windows.Forms.Button();
            this.dragControl1 = new Prototipo.DragControl();
            this.eliminarbtn = new System.Windows.Forms.Button();
            this.modificarbtn = new System.Windows.Forms.Button();
            this.agregarbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvseguro_D = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvseguro_DX = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sello_digitalTableAdapter = new Prototipo.SelloDSTableAdapters.sello_digitalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SelloDdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellodigitalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selloDS)).BeginInit();
            this.transparentPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvseguro_D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvseguro_DX)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ebrima", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 50);
            this.label4.TabIndex = 38;
            this.label4.Text = "Sello Digital";
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
            // clientelbl
            // 
            this.clientelbl.AutoSize = true;
            this.clientelbl.BackColor = System.Drawing.Color.Transparent;
            this.clientelbl.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientelbl.Location = new System.Drawing.Point(30, 164);
            this.clientelbl.Name = "clientelbl";
            this.clientelbl.Size = new System.Drawing.Size(115, 21);
            this.clientelbl.TabIndex = 42;
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
            this.fechaCrealbl.TabIndex = 43;
            this.fechaCrealbl.Text = "Fecha de creación:";
            // 
            // fechaCadulbl
            // 
            this.fechaCadulbl.AutoSize = true;
            this.fechaCadulbl.BackColor = System.Drawing.Color.Transparent;
            this.fechaCadulbl.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaCadulbl.Location = new System.Drawing.Point(30, 315);
            this.fechaCadulbl.Name = "fechaCadulbl";
            this.fechaCadulbl.Size = new System.Drawing.Size(166, 21);
            this.fechaCadulbl.TabIndex = 44;
            this.fechaCadulbl.Text = "Fecha de Caducidad:";
            // 
            // SelloDdgv
            // 
            this.SelloDdgv.AutoGenerateColumns = false;
            this.SelloDdgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.SelloDdgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SelloDdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SelloDdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SelloDdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelloDdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.SelloDdgv.DataSource = this.sellodigitalBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SelloDdgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.SelloDdgv.EnableHeadersVisualStyles = false;
            this.SelloDdgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            this.SelloDdgv.Location = new System.Drawing.Point(218, 164);
            this.SelloDdgv.MultiSelect = false;
            this.SelloDdgv.Name = "SelloDdgv";
            this.SelloDdgv.ReadOnly = true;
            this.SelloDdgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SelloDdgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.SelloDdgv.Size = new System.Drawing.Size(477, 258);
            this.SelloDdgv.TabIndex = 47;
            this.SelloDdgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelloDdgv_CellClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_clientes";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_clientes";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 145;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 145;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fecha_in";
            this.dataGridViewTextBoxColumn3.HeaderText = "fecha_in";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 145;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 145;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fecha_fn";
            this.dataGridViewTextBoxColumn4.HeaderText = "fecha_fn";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 145;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 145;
            // 
            // sellodigitalBindingSource
            // 
            this.sellodigitalBindingSource.DataMember = "sello_digital";
            this.sellodigitalBindingSource.DataSource = this.selloDS;
            // 
            // selloDS
            // 
            this.selloDS.DataSetName = "SelloDS";
            this.selloDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fecha_In
            // 
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
            this.fecha_Fn.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.fecha_Fn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha_Fn.Location = new System.Drawing.Point(34, 339);
            this.fecha_Fn.Name = "fecha_Fn";
            this.fecha_Fn.Size = new System.Drawing.Size(162, 22);
            this.fecha_Fn.TabIndex = 3;
            // 
            // transparentPanel1
            // 
            this.transparentPanel1.Controls.Add(this.cerrarbtn);
            this.transparentPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.transparentPanel1.Location = new System.Drawing.Point(0, 0);
            this.transparentPanel1.Name = "transparentPanel1";
            this.transparentPanel1.Size = new System.Drawing.Size(726, 49);
            this.transparentPanel1.TabIndex = 37;
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
            this.cerrarbtn.Location = new System.Drawing.Point(675, 0);
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
            // eliminarbtn
            // 
            this.eliminarbtn.BackColor = System.Drawing.Color.IndianRed;
            this.eliminarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarbtn.FlatAppearance.BorderSize = 0;
            this.eliminarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.eliminarbtn.Location = new System.Drawing.Point(86, 412);
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
            this.modificarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificarbtn.FlatAppearance.BorderSize = 0;
            this.modificarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.modificarbtn.Location = new System.Drawing.Point(28, 412);
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
            this.agregarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarbtn.FlatAppearance.BorderSize = 0;
            this.agregarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.agregarbtn.Location = new System.Drawing.Point(144, 412);
            this.agregarbtn.Name = "agregarbtn";
            this.agregarbtn.Size = new System.Drawing.Size(52, 40);
            this.agregarbtn.TabIndex = 4;
            this.agregarbtn.Text = "✔️";
            this.agregarbtn.UseVisualStyleBackColor = false;
            this.agregarbtn.Click += new System.EventHandler(this.agregarbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Prototipo.Properties.Resources.sello;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(546, 488);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 216);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // dgvseguro_D
            // 
            this.dgvseguro_D.AutoGenerateColumns = false;
            this.dgvseguro_D.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvseguro_D.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvseguro_D.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvseguro_D.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvseguro_D.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvseguro_D.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6});
            this.dgvseguro_D.DataSource = this.sellodigitalBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvseguro_D.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvseguro_D.EnableHeadersVisualStyles = false;
            this.dgvseguro_D.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            this.dgvseguro_D.Location = new System.Drawing.Point(387, 442);
            this.dgvseguro_D.MultiSelect = false;
            this.dgvseguro_D.Name = "dgvseguro_D";
            this.dgvseguro_D.ReadOnly = true;
            this.dgvseguro_D.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvseguro_D.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvseguro_D.Size = new System.Drawing.Size(144, 239);
            this.dgvseguro_D.TabIndex = 58;
            this.dgvseguro_D.TabStop = false;
            this.dgvseguro_D.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvseguro_D_CellClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_clientes";
            this.dataGridViewTextBoxColumn6.HeaderText = "Documentos por expirar";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dgvseguro_DX
            // 
            this.dgvseguro_DX.AutoGenerateColumns = false;
            this.dgvseguro_DX.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvseguro_DX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvseguro_DX.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvseguro_DX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvseguro_DX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvseguro_DX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5});
            this.dgvseguro_DX.DataSource = this.sellodigitalBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvseguro_DX.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvseguro_DX.EnableHeadersVisualStyles = false;
            this.dgvseguro_DX.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            this.dgvseguro_DX.Location = new System.Drawing.Point(218, 442);
            this.dgvseguro_DX.MultiSelect = false;
            this.dgvseguro_DX.Name = "dgvseguro_DX";
            this.dgvseguro_DX.ReadOnly = true;
            this.dgvseguro_DX.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvseguro_DX.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvseguro_DX.Size = new System.Drawing.Size(144, 239);
            this.dgvseguro_DX.TabIndex = 59;
            this.dgvseguro_DX.TabStop = false;
            this.dgvseguro_DX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvseguro_DX_CellClick_1);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_clientes";
            this.dataGridViewTextBoxColumn5.HeaderText = "Documentos expirados";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // sello_digitalTableAdapter
            // 
            this.sello_digitalTableAdapter.ClearBeforeFill = true;
            // 
            // SelloD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(726, 705);
            this.Controls.Add(this.dgvseguro_DX);
            this.Controls.Add(this.dgvseguro_D);
            this.Controls.Add(this.eliminarbtn);
            this.Controls.Add(this.modificarbtn);
            this.Controls.Add(this.agregarbtn);
            this.Controls.Add(this.fecha_Fn);
            this.Controls.Add(this.fecha_In);
            this.Controls.Add(this.SelloDdgv);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fechaCadulbl);
            this.Controls.Add(this.fechaCrealbl);
            this.Controls.Add(this.clientelbl);
            this.Controls.Add(this.clientetxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.transparentPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelloD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sello Digital";
            this.Load += new System.EventHandler(this.SelloD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelloDdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellodigitalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selloDS)).EndInit();
            this.transparentPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvseguro_D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvseguro_DX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TransparentPanel transparentPanel1;
        private System.Windows.Forms.Button cerrarbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox clientetxt;
        private System.Windows.Forms.Label clientelbl;
        private System.Windows.Forms.Label fechaCrealbl;
        private System.Windows.Forms.Label fechaCadulbl;
        private DragControl dragControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView SelloDdgv;
        private System.Windows.Forms.DateTimePicker fecha_In;
        private System.Windows.Forms.DateTimePicker fecha_Fn;
        //private modelo.miguelitoDataSet8TableAdapters.sello_digitalTableAdapter sello_digitalTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechafnDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button eliminarbtn;
        private System.Windows.Forms.Button modificarbtn;
        private System.Windows.Forms.Button agregarbtn;
        private System.Windows.Forms.DataGridView dgvseguro_D;
        private System.Windows.Forms.DataGridView dgvseguro_DX;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        //private SelloDSTableAdapters.sello_digitalTableAdapter sello_digitalTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientesDataGridViewTextBoxColumn1;
        private SelloDS selloDS;
        private System.Windows.Forms.BindingSource sellodigitalBindingSource;
        private SelloDSTableAdapters.sello_digitalTableAdapter sello_digitalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}