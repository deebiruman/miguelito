﻿namespace Prototipo
{
    partial class FirmaEform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirmaEform));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clientelbl = new System.Windows.Forms.Label();
            this.clientetxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.firmaEdgv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaelectronicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmaDS = new Prototipo.FirmaDS();
            this.fecha_Fn = new System.Windows.Forms.DateTimePicker();
            this.fecha_In = new System.Windows.Forms.DateTimePicker();
            this.eliminarbtn = new System.Windows.Forms.Button();
            this.modificarbtn = new System.Windows.Forms.Button();
            this.agregarbtn = new System.Windows.Forms.Button();
            this.dgvfirma_E = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvfirma_EX = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.transparentPanel1 = new Prototipo.TransparentPanel();
            this.cerrarbtn = new System.Windows.Forms.Button();
            this.dragControl1 = new Prototipo.DragControl();
            this.firma_electronicaTableAdapter = new Prototipo.FirmaDSTableAdapters.firma_electronicaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.firmaEdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaelectronicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfirma_E)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfirma_EX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.transparentPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 21);
            this.label3.TabIndex = 51;
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
            this.label2.TabIndex = 50;
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
            this.clientelbl.TabIndex = 49;
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
            this.label4.Size = new System.Drawing.Size(323, 50);
            this.label4.TabIndex = 45;
            this.label4.Text = "Firma Electronica";
            // 
            // firmaEdgv
            // 
            this.firmaEdgv.AutoGenerateColumns = false;
            this.firmaEdgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.firmaEdgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firmaEdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.firmaEdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.firmaEdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.firmaEdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.firmaEdgv.DataSource = this.firmaelectronicaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.firmaEdgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.firmaEdgv.EnableHeadersVisualStyles = false;
            this.firmaEdgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            this.firmaEdgv.Location = new System.Drawing.Point(225, 164);
            this.firmaEdgv.MultiSelect = false;
            this.firmaEdgv.Name = "firmaEdgv";
            this.firmaEdgv.ReadOnly = true;
            this.firmaEdgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.firmaEdgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.firmaEdgv.Size = new System.Drawing.Size(477, 258);
            this.firmaEdgv.TabIndex = 56;
            this.firmaEdgv.TabStop = false;
            this.firmaEdgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_clientes";
            this.dataGridViewTextBoxColumn6.HeaderText = "id_clientes";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 145;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 145;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "fecha_in";
            this.dataGridViewTextBoxColumn7.HeaderText = "fecha_in";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 145;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 145;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "fecha_fn";
            this.dataGridViewTextBoxColumn8.HeaderText = "fecha_fn";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 145;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 145;
            // 
            // firmaelectronicaBindingSource
            // 
            this.firmaelectronicaBindingSource.DataMember = "firma_electronica";
            this.firmaelectronicaBindingSource.DataSource = this.firmaDS;
            // 
            // firmaDS
            // 
            this.firmaDS.DataSetName = "FirmaDS";
            this.firmaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.fecha_Fn.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
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
            this.fecha_In.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // eliminarbtn
            // 
            this.eliminarbtn.BackColor = System.Drawing.Color.IndianRed;
            this.eliminarbtn.FlatAppearance.BorderSize = 0;
            this.eliminarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.eliminarbtn.Location = new System.Drawing.Point(93, 403);
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
            this.modificarbtn.Location = new System.Drawing.Point(34, 403);
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
            this.agregarbtn.Location = new System.Drawing.Point(151, 403);
            this.agregarbtn.Name = "agregarbtn";
            this.agregarbtn.Size = new System.Drawing.Size(52, 40);
            this.agregarbtn.TabIndex = 4;
            this.agregarbtn.Text = "✔️";
            this.agregarbtn.UseVisualStyleBackColor = false;
            this.agregarbtn.Click += new System.EventHandler(this.agregarbtn_Click);
            // 
            // dgvfirma_E
            // 
            this.dgvfirma_E.AutoGenerateColumns = false;
            this.dgvfirma_E.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvfirma_E.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvfirma_E.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvfirma_E.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvfirma_E.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfirma_E.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9});
            this.dgvfirma_E.DataSource = this.firmaelectronicaBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvfirma_E.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvfirma_E.EnableHeadersVisualStyles = false;
            this.dgvfirma_E.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            this.dgvfirma_E.Location = new System.Drawing.Point(225, 447);
            this.dgvfirma_E.MultiSelect = false;
            this.dgvfirma_E.Name = "dgvfirma_E";
            this.dgvfirma_E.ReadOnly = true;
            this.dgvfirma_E.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvfirma_E.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvfirma_E.Size = new System.Drawing.Size(145, 301);
            this.dgvfirma_E.TabIndex = 57;
            this.dgvfirma_E.TabStop = false;
            this.dgvfirma_E.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfirma_E_CellClick);
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "id_clientes";
            this.dataGridViewTextBoxColumn9.HeaderText = "Documentos expirados";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dgvfirma_EX
            // 
            this.dgvfirma_EX.AutoGenerateColumns = false;
            this.dgvfirma_EX.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvfirma_EX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvfirma_EX.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvfirma_EX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvfirma_EX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfirma_EX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12});
            this.dgvfirma_EX.DataSource = this.firmaelectronicaBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvfirma_EX.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvfirma_EX.EnableHeadersVisualStyles = false;
            this.dgvfirma_EX.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            this.dgvfirma_EX.Location = new System.Drawing.Point(394, 447);
            this.dgvfirma_EX.MultiSelect = false;
            this.dgvfirma_EX.Name = "dgvfirma_EX";
            this.dgvfirma_EX.ReadOnly = true;
            this.dgvfirma_EX.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvfirma_EX.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvfirma_EX.Size = new System.Drawing.Size(145, 301);
            this.dgvfirma_EX.TabIndex = 58;
            this.dgvfirma_EX.TabStop = false;
            this.dgvfirma_EX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfirma_EX_CellClick);
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "id_clientes";
            this.dataGridViewTextBoxColumn12.HeaderText = "Documentos por expirar";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Prototipo.Properties.Resources.firma;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(551, 569);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 216);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // transparentPanel1
            // 
            this.transparentPanel1.Controls.Add(this.cerrarbtn);
            this.transparentPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.transparentPanel1.Location = new System.Drawing.Point(0, 0);
            this.transparentPanel1.Name = "transparentPanel1";
            this.transparentPanel1.Size = new System.Drawing.Size(735, 49);
            this.transparentPanel1.TabIndex = 52;
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
            this.cerrarbtn.Location = new System.Drawing.Point(684, 0);
            this.cerrarbtn.Name = "cerrarbtn";
            this.cerrarbtn.Size = new System.Drawing.Size(51, 49);
            this.cerrarbtn.TabIndex = 50;
            this.cerrarbtn.Text = "X";
            this.cerrarbtn.UseVisualStyleBackColor = true;
            this.cerrarbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectoControl = this.transparentPanel1;
            // 
            // firma_electronicaTableAdapter
            // 
            this.firma_electronicaTableAdapter.ClearBeforeFill = true;
            // 
            // FirmaEform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(735, 772);
            this.Controls.Add(this.dgvfirma_EX);
            this.Controls.Add(this.dgvfirma_E);
            this.Controls.Add(this.eliminarbtn);
            this.Controls.Add(this.modificarbtn);
            this.Controls.Add(this.agregarbtn);
            this.Controls.Add(this.fecha_In);
            this.Controls.Add(this.fecha_Fn);
            this.Controls.Add(this.firmaEdgv);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.transparentPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientelbl);
            this.Controls.Add(this.clientetxt);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FirmaEform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firma Electronica";
            this.Load += new System.EventHandler(this.FirmaE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.firmaEdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaelectronicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfirma_E)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfirma_EX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.transparentPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label clientelbl;
        private System.Windows.Forms.TextBox clientetxt;
        private System.Windows.Forms.Label label4;
        private TransparentPanel transparentPanel1;
        private System.Windows.Forms.Button cerrarbtn;
        private DragControl dragControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView firmaEdgv;
        //private modelo.El_Pana_MiguelDataSet1TableAdapters.firma_electrónicaTableAdapter firma_electrónicaTableAdapter;
        private System.Windows.Forms.DateTimePicker fecha_In;
        //private modelo.miguelitoDataSet5TableAdapters.firma_electronicaTableAdapter firma_electronicaTableAdapter;
        private System.Windows.Forms.DateTimePicker fecha_Fn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechafnDataGridViewTextBoxColumn;
        //private modelo.miguelitoDataSet9TableAdapters.firma_electronicaTableAdapter firma_electronicaTableAdapter1;
        private System.Windows.Forms.Button eliminarbtn;
        private System.Windows.Forms.Button modificarbtn;
        private System.Windows.Forms.Button agregarbtn;
        private System.Windows.Forms.DataGridView dgvfirma_E;
        private System.Windows.Forms.DataGridView dgvfirma_EX;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientesDataGridViewTextBoxColumn1;
        private FirmaDS firmaDS;
        private System.Windows.Forms.BindingSource firmaelectronicaBindingSource;
        private FirmaDSTableAdapters.firma_electronicaTableAdapter firma_electronicaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        //private FirmaDSTableAdapters.firma_electronicaTableAdapter firma_electronicaTableAdapter2;
    }
}