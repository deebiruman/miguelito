namespace Prototipo
{
    partial class Clientesform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientesform));
            this.label6 = new System.Windows.Forms.Label();
            this.clientetxt = new System.Windows.Forms.TextBox();
            this.nombretxt = new System.Windows.Forms.TextBox();
            this.domitxt = new System.Windows.Forms.TextBox();
            this.teletxt = new System.Windows.Forms.TextBox();
            this.correotxt = new System.Windows.Forms.TextBox();
            this.clientelbl = new System.Windows.Forms.Label();
            this.nombrelbl = new System.Windows.Forms.Label();
            this.domilbl = new System.Windows.Forms.Label();
            this.telelbl = new System.Windows.Forms.Label();
            this.correolbl = new System.Windows.Forms.Label();
            this.moralrbtn = new System.Windows.Forms.RadioButton();
            this.fisicarbtn = new System.Windows.Forms.RadioButton();
            this.rfclbl = new System.Windows.Forms.Label();
            this.rfctxt = new System.Windows.Forms.TextBox();
            this.curplbl = new System.Windows.Forms.Label();
            this.curptxt = new System.Windows.Forms.TextBox();
            this.clientesdgv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rFCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.agregarbtn = new System.Windows.Forms.Button();
            this.modificarbtn = new System.Windows.Forms.Button();
            this.eliminarbtn = new System.Windows.Forms.Button();
            this.excelbtn = new System.Windows.Forms.Button();
            this.val_id = new System.Windows.Forms.Label();
            this.long_id = new System.Windows.Forms.Label();
            this.long_nom = new System.Windows.Forms.Label();
            this.long_dom = new System.Windows.Forms.Label();
            this.val_tel = new System.Windows.Forms.Label();
            this.val_correo = new System.Windows.Forms.Label();
            this.val_curp = new System.Windows.Forms.Label();
            this.val_rfc = new System.Windows.Forms.Label();
            this.transparentPanel1 = new Prototipo.TransparentPanel();
            this.cerrarbtn = new System.Windows.Forms.Button();
            this.dragControl1 = new Prototipo.DragControl();
            this.ClearAll = new System.Windows.Forms.Button();
            this.clientesDataSet = new Prototipo.clientesDataSet();
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter1 = new Prototipo.clientesDataSetTableAdapters.clientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clientesdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.transparentPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Ebrima", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 50);
            this.label6.TabIndex = 46;
            this.label6.Text = "Clientes";
            // 
            // clientetxt
            // 
            this.clientetxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clientetxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientetxt.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientetxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clientetxt.Location = new System.Drawing.Point(34, 188);
            this.clientetxt.MaxLength = 12;
            this.clientetxt.Name = "clientetxt";
            this.clientetxt.Size = new System.Drawing.Size(162, 22);
            this.clientetxt.TabIndex = 1;
            this.clientetxt.TextChanged += new System.EventHandler(this.clientetxt_TextChanged);
            this.clientetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.clientetxt.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // nombretxt
            // 
            this.nombretxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nombretxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombretxt.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombretxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nombretxt.Location = new System.Drawing.Point(34, 258);
            this.nombretxt.MaxLength = 50;
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(162, 22);
            this.nombretxt.TabIndex = 2;
            this.nombretxt.TextChanged += new System.EventHandler(this.nombretxt_TextChanged);
            this.nombretxt.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // domitxt
            // 
            this.domitxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.domitxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.domitxt.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domitxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.domitxt.Location = new System.Drawing.Point(34, 328);
            this.domitxt.MaxLength = 50;
            this.domitxt.Name = "domitxt";
            this.domitxt.Size = new System.Drawing.Size(162, 22);
            this.domitxt.TabIndex = 3;
            this.domitxt.TextChanged += new System.EventHandler(this.domitxt_TextChanged);
            this.domitxt.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // teletxt
            // 
            this.teletxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.teletxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.teletxt.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teletxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.teletxt.Location = new System.Drawing.Point(34, 398);
            this.teletxt.MaxLength = 10;
            this.teletxt.Name = "teletxt";
            this.teletxt.Size = new System.Drawing.Size(162, 22);
            this.teletxt.TabIndex = 4;
            this.teletxt.TextChanged += new System.EventHandler(this.teletxt_TextChanged);
            this.teletxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            this.teletxt.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // correotxt
            // 
            this.correotxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.correotxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.correotxt.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correotxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.correotxt.Location = new System.Drawing.Point(34, 472);
            this.correotxt.MaxLength = 50;
            this.correotxt.Name = "correotxt";
            this.correotxt.Size = new System.Drawing.Size(162, 22);
            this.correotxt.TabIndex = 5;
            this.correotxt.TextChanged += new System.EventHandler(this.correotxt_TextChanged);
            this.correotxt.Leave += new System.EventHandler(this.textBox5_Leave);
            // 
            // clientelbl
            // 
            this.clientelbl.AutoSize = true;
            this.clientelbl.BackColor = System.Drawing.Color.Transparent;
            this.clientelbl.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientelbl.Location = new System.Drawing.Point(30, 164);
            this.clientelbl.Name = "clientelbl";
            this.clientelbl.Size = new System.Drawing.Size(117, 21);
            this.clientelbl.TabIndex = 52;
            this.clientelbl.Text = "ID del Cliente:";
            // 
            // nombrelbl
            // 
            this.nombrelbl.AutoSize = true;
            this.nombrelbl.BackColor = System.Drawing.Color.Transparent;
            this.nombrelbl.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrelbl.Location = new System.Drawing.Point(30, 234);
            this.nombrelbl.Name = "nombrelbl";
            this.nombrelbl.Size = new System.Drawing.Size(77, 21);
            this.nombrelbl.TabIndex = 53;
            this.nombrelbl.Text = "Nombre:";
            // 
            // domilbl
            // 
            this.domilbl.AutoSize = true;
            this.domilbl.BackColor = System.Drawing.Color.Transparent;
            this.domilbl.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domilbl.Location = new System.Drawing.Point(30, 304);
            this.domilbl.Name = "domilbl";
            this.domilbl.Size = new System.Drawing.Size(89, 21);
            this.domilbl.TabIndex = 54;
            this.domilbl.Text = "Domicilio:";
            // 
            // telelbl
            // 
            this.telelbl.AutoSize = true;
            this.telelbl.BackColor = System.Drawing.Color.Transparent;
            this.telelbl.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telelbl.Location = new System.Drawing.Point(30, 374);
            this.telelbl.Name = "telelbl";
            this.telelbl.Size = new System.Drawing.Size(82, 21);
            this.telelbl.TabIndex = 55;
            this.telelbl.Text = "Telefono:";
            // 
            // correolbl
            // 
            this.correolbl.AutoSize = true;
            this.correolbl.BackColor = System.Drawing.Color.Transparent;
            this.correolbl.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correolbl.Location = new System.Drawing.Point(30, 448);
            this.correolbl.Name = "correolbl";
            this.correolbl.Size = new System.Drawing.Size(65, 21);
            this.correolbl.TabIndex = 56;
            this.correolbl.Text = "Correo:";
            // 
            // moralrbtn
            // 
            this.moralrbtn.AutoSize = true;
            this.moralrbtn.BackColor = System.Drawing.Color.White;
            this.moralrbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moralrbtn.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moralrbtn.ForeColor = System.Drawing.Color.Black;
            this.moralrbtn.Location = new System.Drawing.Point(34, 514);
            this.moralrbtn.Name = "moralrbtn";
            this.moralrbtn.Size = new System.Drawing.Size(73, 25);
            this.moralrbtn.TabIndex = 6;
            this.moralrbtn.TabStop = true;
            this.moralrbtn.Text = "Moral";
            this.moralrbtn.UseVisualStyleBackColor = false;
            this.moralrbtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // fisicarbtn
            // 
            this.fisicarbtn.AutoSize = true;
            this.fisicarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fisicarbtn.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fisicarbtn.Location = new System.Drawing.Point(124, 514);
            this.fisicarbtn.Name = "fisicarbtn";
            this.fisicarbtn.Size = new System.Drawing.Size(70, 25);
            this.fisicarbtn.TabIndex = 7;
            this.fisicarbtn.TabStop = true;
            this.fisicarbtn.Text = "Fisica";
            this.fisicarbtn.UseVisualStyleBackColor = true;
            this.fisicarbtn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rfclbl
            // 
            this.rfclbl.AutoSize = true;
            this.rfclbl.BackColor = System.Drawing.Color.Transparent;
            this.rfclbl.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rfclbl.Location = new System.Drawing.Point(230, 448);
            this.rfclbl.Name = "rfclbl";
            this.rfclbl.Size = new System.Drawing.Size(42, 21);
            this.rfclbl.TabIndex = 59;
            this.rfclbl.Text = "RFC:";
            // 
            // rfctxt
            // 
            this.rfctxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rfctxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rfctxt.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rfctxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rfctxt.Location = new System.Drawing.Point(234, 472);
            this.rfctxt.MaxLength = 13;
            this.rfctxt.Name = "rfctxt";
            this.rfctxt.Size = new System.Drawing.Size(162, 22);
            this.rfctxt.TabIndex = 8;
            this.rfctxt.TextChanged += new System.EventHandler(this.rfctxt_TextChanged);
            this.rfctxt.Leave += new System.EventHandler(this.textBox6_Leave);
            // 
            // curplbl
            // 
            this.curplbl.AutoSize = true;
            this.curplbl.BackColor = System.Drawing.Color.Transparent;
            this.curplbl.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curplbl.Location = new System.Drawing.Point(430, 448);
            this.curplbl.Name = "curplbl";
            this.curplbl.Size = new System.Drawing.Size(56, 21);
            this.curplbl.TabIndex = 61;
            this.curplbl.Text = "CURP:";
            // 
            // curptxt
            // 
            this.curptxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.curptxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.curptxt.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curptxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.curptxt.Location = new System.Drawing.Point(434, 472);
            this.curptxt.MaxLength = 18;
            this.curptxt.Name = "curptxt";
            this.curptxt.Size = new System.Drawing.Size(162, 22);
            this.curptxt.TabIndex = 9;
            this.curptxt.TextChanged += new System.EventHandler(this.curptxt_TextChanged);
            this.curptxt.Leave += new System.EventHandler(this.textBox7_Leave_1);
            // 
            // clientesdgv
            // 
            this.clientesdgv.AutoGenerateColumns = false;
            this.clientesdgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.clientesdgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientesdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientesdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.clientesdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.rFCDataGridViewTextBoxColumn,
            this.curpDataGridViewTextBoxColumn});
            this.clientesdgv.DataSource = this.clientesBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clientesdgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.clientesdgv.EnableHeadersVisualStyles = false;
            this.clientesdgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            this.clientesdgv.Location = new System.Drawing.Point(225, 164);
            this.clientesdgv.MultiSelect = false;
            this.clientesdgv.Name = "clientesdgv";
            this.clientesdgv.ReadOnly = true;
            this.clientesdgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientesdgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(22)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.clientesdgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.clientesdgv.Size = new System.Drawing.Size(745, 260);
            this.clientesdgv.TabIndex = 0;
            this.clientesdgv.TabStop = false;
            this.clientesdgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.clientesdgv.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_clientes";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_clientes";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre_cl";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre_cl";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "domicilio_cl";
            this.dataGridViewTextBoxColumn3.HeaderText = "domicilio_cl";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "telefono_cl";
            this.dataGridViewTextBoxColumn4.HeaderText = "telefono_cl";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "correo_cl";
            this.dataGridViewTextBoxColumn5.HeaderText = "correo_cl";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // rFCDataGridViewTextBoxColumn
            // 
            this.rFCDataGridViewTextBoxColumn.DataPropertyName = "RFC";
            this.rFCDataGridViewTextBoxColumn.HeaderText = "RFC";
            this.rFCDataGridViewTextBoxColumn.Name = "rFCDataGridViewTextBoxColumn";
            this.rFCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // curpDataGridViewTextBoxColumn
            // 
            this.curpDataGridViewTextBoxColumn.DataPropertyName = "curp";
            this.curpDataGridViewTextBoxColumn.HeaderText = "curp";
            this.curpDataGridViewTextBoxColumn.Name = "curpDataGridViewTextBoxColumn";
            this.curpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Prototipo.Properties.Resources.usuarios;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(784, 430);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 216);
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // agregarbtn
            // 
            this.agregarbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(197)))), ((int)(((byte)(61)))));
            this.agregarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarbtn.FlatAppearance.BorderSize = 0;
            this.agregarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.agregarbtn.Location = new System.Drawing.Point(150, 570);
            this.agregarbtn.Name = "agregarbtn";
            this.agregarbtn.Size = new System.Drawing.Size(52, 40);
            this.agregarbtn.TabIndex = 10;
            this.agregarbtn.Text = "✔️";
            this.agregarbtn.UseVisualStyleBackColor = false;
            this.agregarbtn.Click += new System.EventHandler(this.agregarbtn_Click);
            // 
            // modificarbtn
            // 
            this.modificarbtn.BackColor = System.Drawing.Color.Gold;
            this.modificarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificarbtn.FlatAppearance.BorderSize = 0;
            this.modificarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.modificarbtn.Location = new System.Drawing.Point(34, 570);
            this.modificarbtn.Name = "modificarbtn";
            this.modificarbtn.Size = new System.Drawing.Size(52, 40);
            this.modificarbtn.TabIndex = 12;
            this.modificarbtn.Text = "✏️";
            this.modificarbtn.UseVisualStyleBackColor = false;
            this.modificarbtn.Click += new System.EventHandler(this.modificarbtn_Click);
            // 
            // eliminarbtn
            // 
            this.eliminarbtn.BackColor = System.Drawing.Color.IndianRed;
            this.eliminarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarbtn.FlatAppearance.BorderSize = 0;
            this.eliminarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.eliminarbtn.Location = new System.Drawing.Point(92, 570);
            this.eliminarbtn.Name = "eliminarbtn";
            this.eliminarbtn.Size = new System.Drawing.Size(52, 40);
            this.eliminarbtn.TabIndex = 11;
            this.eliminarbtn.Text = "✖️";
            this.eliminarbtn.UseVisualStyleBackColor = false;
            this.eliminarbtn.Click += new System.EventHandler(this.eliminarbtn_Click);
            // 
            // excelbtn
            // 
            this.excelbtn.BackColor = System.Drawing.Color.Green;
            this.excelbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.excelbtn.FlatAppearance.BorderSize = 0;
            this.excelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excelbtn.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excelbtn.ForeColor = System.Drawing.Color.White;
            this.excelbtn.Location = new System.Drawing.Point(634, 462);
            this.excelbtn.Name = "excelbtn";
            this.excelbtn.Size = new System.Drawing.Size(120, 42);
            this.excelbtn.TabIndex = 13;
            this.excelbtn.Text = "Exportar Excel";
            this.excelbtn.UseVisualStyleBackColor = false;
            this.excelbtn.Click += new System.EventHandler(this.excelbtn_Click);
            // 
            // val_id
            // 
            this.val_id.AutoSize = true;
            this.val_id.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val_id.ForeColor = System.Drawing.Color.Red;
            this.val_id.Location = new System.Drawing.Point(30, 147);
            this.val_id.Name = "val_id";
            this.val_id.Size = new System.Drawing.Size(162, 17);
            this.val_id.TabIndex = 78;
            this.val_id.Text = "Sólo se permiten números";
            this.val_id.Visible = false;
            // 
            // long_id
            // 
            this.long_id.AutoSize = true;
            this.long_id.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.long_id.ForeColor = System.Drawing.Color.Red;
            this.long_id.Location = new System.Drawing.Point(30, 213);
            this.long_id.Name = "long_id";
            this.long_id.Size = new System.Drawing.Size(135, 17);
            this.long_id.TabIndex = 79;
            this.long_id.Text = "Longitud mínima de 8";
            this.long_id.Visible = false;
            // 
            // long_nom
            // 
            this.long_nom.AutoSize = true;
            this.long_nom.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.long_nom.ForeColor = System.Drawing.Color.Red;
            this.long_nom.Location = new System.Drawing.Point(30, 281);
            this.long_nom.Name = "long_nom";
            this.long_nom.Size = new System.Drawing.Size(135, 17);
            this.long_nom.TabIndex = 80;
            this.long_nom.Text = "Longitud mínima de 8";
            this.long_nom.Visible = false;
            // 
            // long_dom
            // 
            this.long_dom.AutoSize = true;
            this.long_dom.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.long_dom.ForeColor = System.Drawing.Color.Red;
            this.long_dom.Location = new System.Drawing.Point(30, 351);
            this.long_dom.Name = "long_dom";
            this.long_dom.Size = new System.Drawing.Size(135, 17);
            this.long_dom.TabIndex = 81;
            this.long_dom.Text = "Longitud mínima de 8";
            this.long_dom.Visible = false;
            // 
            // val_tel
            // 
            this.val_tel.AutoSize = true;
            this.val_tel.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val_tel.ForeColor = System.Drawing.Color.Red;
            this.val_tel.Location = new System.Drawing.Point(30, 421);
            this.val_tel.Name = "val_tel";
            this.val_tel.Size = new System.Drawing.Size(162, 17);
            this.val_tel.TabIndex = 82;
            this.val_tel.Text = "Sólo se permiten números";
            this.val_tel.Visible = false;
            // 
            // val_correo
            // 
            this.val_correo.AutoSize = true;
            this.val_correo.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val_correo.ForeColor = System.Drawing.Color.Red;
            this.val_correo.Location = new System.Drawing.Point(30, 497);
            this.val_correo.Name = "val_correo";
            this.val_correo.Size = new System.Drawing.Size(107, 17);
            this.val_correo.TabIndex = 83;
            this.val_correo.Text = "Correo no válido";
            this.val_correo.Visible = false;
            // 
            // val_curp
            // 
            this.val_curp.AutoSize = true;
            this.val_curp.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val_curp.ForeColor = System.Drawing.Color.Red;
            this.val_curp.Location = new System.Drawing.Point(430, 497);
            this.val_curp.Name = "val_curp";
            this.val_curp.Size = new System.Drawing.Size(98, 17);
            this.val_curp.TabIndex = 85;
            this.val_curp.Text = "CURP no válido";
            this.val_curp.Visible = false;
            // 
            // val_rfc
            // 
            this.val_rfc.AutoSize = true;
            this.val_rfc.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val_rfc.ForeColor = System.Drawing.Color.Red;
            this.val_rfc.Location = new System.Drawing.Point(230, 497);
            this.val_rfc.Name = "val_rfc";
            this.val_rfc.Size = new System.Drawing.Size(88, 17);
            this.val_rfc.TabIndex = 84;
            this.val_rfc.Text = "RFC no válido";
            this.val_rfc.Visible = false;
            // 
            // transparentPanel1
            // 
            this.transparentPanel1.Controls.Add(this.cerrarbtn);
            this.transparentPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.transparentPanel1.Location = new System.Drawing.Point(0, 0);
            this.transparentPanel1.Name = "transparentPanel1";
            this.transparentPanel1.Size = new System.Drawing.Size(1000, 49);
            this.transparentPanel1.TabIndex = 15;
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
            this.cerrarbtn.Location = new System.Drawing.Point(949, 0);
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
            // ClearAll
            // 
            this.ClearAll.BackColor = System.Drawing.Color.Silver;
            this.ClearAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearAll.FlatAppearance.BorderSize = 0;
            this.ClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearAll.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearAll.ForeColor = System.Drawing.Color.Black;
            this.ClearAll.Location = new System.Drawing.Point(234, 566);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(120, 42);
            this.ClearAll.TabIndex = 87;
            this.ClearAll.Text = "Borrar Todo";
            this.ClearAll.UseVisualStyleBackColor = false;
            this.ClearAll.Visible = false;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // clientesDataSet
            // 
            this.clientesDataSet.DataSetName = "clientesDataSet";
            this.clientesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "clientes";
            this.clientesBindingSource1.DataSource = this.clientesDataSet;
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // Clientesform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 624);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.val_curp);
            this.Controls.Add(this.val_rfc);
            this.Controls.Add(this.val_correo);
            this.Controls.Add(this.val_tel);
            this.Controls.Add(this.long_dom);
            this.Controls.Add(this.long_nom);
            this.Controls.Add(this.long_id);
            this.Controls.Add(this.val_id);
            this.Controls.Add(this.excelbtn);
            this.Controls.Add(this.eliminarbtn);
            this.Controls.Add(this.modificarbtn);
            this.Controls.Add(this.agregarbtn);
            this.Controls.Add(this.clientesdgv);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.curplbl);
            this.Controls.Add(this.curptxt);
            this.Controls.Add(this.rfctxt);
            this.Controls.Add(this.rfclbl);
            this.Controls.Add(this.fisicarbtn);
            this.Controls.Add(this.moralrbtn);
            this.Controls.Add(this.correolbl);
            this.Controls.Add(this.telelbl);
            this.Controls.Add(this.domilbl);
            this.Controls.Add(this.nombrelbl);
            this.Controls.Add(this.clientelbl);
            this.Controls.Add(this.correotxt);
            this.Controls.Add(this.teletxt);
            this.Controls.Add(this.domitxt);
            this.Controls.Add(this.nombretxt);
            this.Controls.Add(this.clientetxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.transparentPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Clientesform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.transparentPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DragControl dragControl1;
        private TransparentPanel transparentPanel1;
        private System.Windows.Forms.Button cerrarbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox clientetxt;
        private System.Windows.Forms.TextBox nombretxt;
        private System.Windows.Forms.TextBox domitxt;
        private System.Windows.Forms.TextBox teletxt;
        private System.Windows.Forms.TextBox correotxt;
        private System.Windows.Forms.Label clientelbl;
        private System.Windows.Forms.Label nombrelbl;
        private System.Windows.Forms.Label domilbl;
        private System.Windows.Forms.Label telelbl;
        private System.Windows.Forms.Label correolbl;
        private System.Windows.Forms.RadioButton moralrbtn;
        private System.Windows.Forms.RadioButton fisicarbtn;
        private System.Windows.Forms.Label rfclbl;
        private System.Windows.Forms.TextBox rfctxt;
        private System.Windows.Forms.Label curplbl;
        private System.Windows.Forms.TextBox curptxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView clientesdgv;
      //  private modelo.miguelitoDataSetTableAdapters.clientesTableAdapter clientesTableAdapter1;
        private System.Windows.Forms.Button agregarbtn;
        private System.Windows.Forms.Button modificarbtn;
        private System.Windows.Forms.Button eliminarbtn;
        private System.Windows.Forms.Button excelbtn;
        private System.Windows.Forms.Label val_curp;
        private System.Windows.Forms.Label val_rfc;
        private System.Windows.Forms.Label val_correo;
        private System.Windows.Forms.Label val_tel;
        private System.Windows.Forms.Label long_dom;
        private System.Windows.Forms.Label long_nom;
        private System.Windows.Forms.Label long_id;
        private System.Windows.Forms.Label val_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn rFCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn curpDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ClearAll;
        private clientesDataSet clientesDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private clientesDataSetTableAdapters.clientesTableAdapter clientesTableAdapter1;
    }
}