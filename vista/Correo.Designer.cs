
namespace Prototipo.vista
{
    partial class Correoform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Correoform));
            this.titulolbl = new System.Windows.Forms.Label();
            this.clientelbl = new System.Windows.Forms.Label();
            this.clienteCorreotxt = new System.Windows.Forms.TextBox();
            this.correolbl = new System.Windows.Forms.Label();
            this.correotxt = new System.Windows.Forms.TextBox();
            this.asuntolbl = new System.Windows.Forms.Label();
            this.asuntotxt = new System.Windows.Forms.TextBox();
            this.nombrelbl = new System.Windows.Forms.Label();
            this.nombreCorreotxt = new System.Windows.Forms.TextBox();
            this.enviarbtn = new System.Windows.Forms.Button();
            this.cuerpotxt = new System.Windows.Forms.TextBox();
            this.val_correo = new System.Windows.Forms.Label();
            this.long_nom = new System.Windows.Forms.Label();
            this.long_id = new System.Windows.Forms.Label();
            this.val_id = new System.Windows.Forms.Label();
            this.asuslbl = new System.Windows.Forms.Label();
            this.transparentPanel1 = new Prototipo.TransparentPanel();
            this.cerrarbtn = new System.Windows.Forms.Button();
            this.dragControl1 = new Prototipo.DragControl();
            this.transparentPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titulolbl
            // 
            this.titulolbl.AutoSize = true;
            this.titulolbl.BackColor = System.Drawing.Color.Transparent;
            this.titulolbl.Font = new System.Drawing.Font("Ebrima", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulolbl.Location = new System.Drawing.Point(25, 67);
            this.titulolbl.Name = "titulolbl";
            this.titulolbl.Size = new System.Drawing.Size(157, 50);
            this.titulolbl.TabIndex = 50;
            this.titulolbl.Text = "Correos";
            // 
            // clientelbl
            // 
            this.clientelbl.AutoSize = true;
            this.clientelbl.BackColor = System.Drawing.Color.Transparent;
            this.clientelbl.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientelbl.Location = new System.Drawing.Point(30, 164);
            this.clientelbl.Name = "clientelbl";
            this.clientelbl.Size = new System.Drawing.Size(115, 21);
            this.clientelbl.TabIndex = 57;
            this.clientelbl.Text = "ID del cliente:";
            // 
            // clienteCorreotxt
            // 
            this.clienteCorreotxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clienteCorreotxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clienteCorreotxt.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteCorreotxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clienteCorreotxt.Location = new System.Drawing.Point(34, 188);
            this.clienteCorreotxt.MaxLength = 12;
            this.clienteCorreotxt.Name = "clienteCorreotxt";
            this.clienteCorreotxt.Size = new System.Drawing.Size(180, 22);
            this.clienteCorreotxt.TabIndex = 1;
            this.clienteCorreotxt.TextChanged += new System.EventHandler(this.clienteCorreotxt_TextChanged);
            this.clienteCorreotxt.Leave += new System.EventHandler(this.clienteCorreotxt_Leave);
            // 
            // correolbl
            // 
            this.correolbl.AutoSize = true;
            this.correolbl.BackColor = System.Drawing.Color.Transparent;
            this.correolbl.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correolbl.Location = new System.Drawing.Point(490, 164);
            this.correolbl.Name = "correolbl";
            this.correolbl.Size = new System.Drawing.Size(65, 21);
            this.correolbl.TabIndex = 59;
            this.correolbl.Text = "Correo:";
            // 
            // correotxt
            // 
            this.correotxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.correotxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.correotxt.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correotxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.correotxt.Location = new System.Drawing.Point(494, 188);
            this.correotxt.MaxLength = 50;
            this.correotxt.Name = "correotxt";
            this.correotxt.Size = new System.Drawing.Size(200, 22);
            this.correotxt.TabIndex = 3;
            this.correotxt.TextChanged += new System.EventHandler(this.correotxt_TextChanged);
            this.correotxt.Leave += new System.EventHandler(this.correotxt_Leave);
            // 
            // asuntolbl
            // 
            this.asuntolbl.AutoSize = true;
            this.asuntolbl.BackColor = System.Drawing.Color.Transparent;
            this.asuntolbl.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asuntolbl.Location = new System.Drawing.Point(30, 234);
            this.asuntolbl.Name = "asuntolbl";
            this.asuntolbl.Size = new System.Drawing.Size(68, 21);
            this.asuntolbl.TabIndex = 61;
            this.asuntolbl.Text = "Asunto:";
            // 
            // asuntotxt
            // 
            this.asuntotxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.asuntotxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.asuntotxt.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asuntotxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.asuntotxt.Location = new System.Drawing.Point(34, 258);
            this.asuntotxt.MaxLength = 50;
            this.asuntotxt.Name = "asuntotxt";
            this.asuntotxt.Size = new System.Drawing.Size(660, 22);
            this.asuntotxt.TabIndex = 4;
            this.asuntotxt.TextChanged += new System.EventHandler(this.asuntotxt_TextChanged);
            this.asuntotxt.Leave += new System.EventHandler(this.asuntotxt_Leave);
            // 
            // nombrelbl
            // 
            this.nombrelbl.AutoSize = true;
            this.nombrelbl.BackColor = System.Drawing.Color.Transparent;
            this.nombrelbl.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrelbl.Location = new System.Drawing.Point(260, 164);
            this.nombrelbl.Name = "nombrelbl";
            this.nombrelbl.Size = new System.Drawing.Size(77, 21);
            this.nombrelbl.TabIndex = 71;
            this.nombrelbl.Text = "Nombre:";
            // 
            // nombreCorreotxt
            // 
            this.nombreCorreotxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nombreCorreotxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombreCorreotxt.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreCorreotxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nombreCorreotxt.Location = new System.Drawing.Point(264, 188);
            this.nombreCorreotxt.MaxLength = 50;
            this.nombreCorreotxt.Name = "nombreCorreotxt";
            this.nombreCorreotxt.Size = new System.Drawing.Size(180, 22);
            this.nombreCorreotxt.TabIndex = 2;
            this.nombreCorreotxt.TextChanged += new System.EventHandler(this.nombreCorreotxt_TextChanged);
            this.nombreCorreotxt.Leave += new System.EventHandler(this.nombreCorreotxt_Leave);
            // 
            // enviarbtn
            // 
            this.enviarbtn.BackColor = System.Drawing.Color.Tomato;
            this.enviarbtn.FlatAppearance.BorderSize = 0;
            this.enviarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enviarbtn.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enviarbtn.ForeColor = System.Drawing.Color.White;
            this.enviarbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.enviarbtn.Location = new System.Drawing.Point(576, 569);
            this.enviarbtn.Name = "enviarbtn";
            this.enviarbtn.Size = new System.Drawing.Size(119, 42);
            this.enviarbtn.TabIndex = 6;
            this.enviarbtn.Text = "Enviar";
            this.enviarbtn.UseVisualStyleBackColor = false;
            this.enviarbtn.Click += new System.EventHandler(this.enviarbtn_Click);
            // 
            // cuerpotxt
            // 
            this.cuerpotxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cuerpotxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cuerpotxt.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuerpotxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cuerpotxt.Location = new System.Drawing.Point(35, 319);
            this.cuerpotxt.MaxLength = 500;
            this.cuerpotxt.Multiline = true;
            this.cuerpotxt.Name = "cuerpotxt";
            this.cuerpotxt.Size = new System.Drawing.Size(660, 244);
            this.cuerpotxt.TabIndex = 5;
            // 
            // val_correo
            // 
            this.val_correo.AutoSize = true;
            this.val_correo.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val_correo.ForeColor = System.Drawing.Color.Red;
            this.val_correo.Location = new System.Drawing.Point(490, 213);
            this.val_correo.Name = "val_correo";
            this.val_correo.Size = new System.Drawing.Size(107, 17);
            this.val_correo.TabIndex = 84;
            this.val_correo.Text = "Correo no válido";
            this.val_correo.Visible = false;
            // 
            // long_nom
            // 
            this.long_nom.AutoSize = true;
            this.long_nom.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.long_nom.ForeColor = System.Drawing.Color.Red;
            this.long_nom.Location = new System.Drawing.Point(260, 213);
            this.long_nom.Name = "long_nom";
            this.long_nom.Size = new System.Drawing.Size(135, 17);
            this.long_nom.TabIndex = 85;
            this.long_nom.Text = "Longitud mínima de 8";
            this.long_nom.Visible = false;
            // 
            // long_id
            // 
            this.long_id.AutoSize = true;
            this.long_id.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.long_id.ForeColor = System.Drawing.Color.Red;
            this.long_id.Location = new System.Drawing.Point(32, 213);
            this.long_id.Name = "long_id";
            this.long_id.Size = new System.Drawing.Size(135, 17);
            this.long_id.TabIndex = 86;
            this.long_id.Text = "Longitud mínima de 8";
            this.long_id.Visible = false;
            // 
            // val_id
            // 
            this.val_id.AutoSize = true;
            this.val_id.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val_id.ForeColor = System.Drawing.Color.Red;
            this.val_id.Location = new System.Drawing.Point(30, 147);
            this.val_id.Name = "val_id";
            this.val_id.Size = new System.Drawing.Size(162, 17);
            this.val_id.TabIndex = 87;
            this.val_id.Text = "Sólo se permiten números";
            this.val_id.Visible = false;
            // 
            // asuslbl
            // 
            this.asuslbl.AutoSize = true;
            this.asuslbl.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asuslbl.ForeColor = System.Drawing.Color.Red;
            this.asuslbl.Location = new System.Drawing.Point(30, 283);
            this.asuslbl.Name = "asuslbl";
            this.asuslbl.Size = new System.Drawing.Size(135, 17);
            this.asuslbl.TabIndex = 88;
            this.asuslbl.Text = "Longitud mínima de 8";
            this.asuslbl.Visible = false;
            // 
            // transparentPanel1
            // 
            this.transparentPanel1.Controls.Add(this.cerrarbtn);
            this.transparentPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.transparentPanel1.Location = new System.Drawing.Point(0, 0);
            this.transparentPanel1.Name = "transparentPanel1";
            this.transparentPanel1.Size = new System.Drawing.Size(730, 49);
            this.transparentPanel1.TabIndex = 16;
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
            this.cerrarbtn.Location = new System.Drawing.Point(679, 0);
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
            // Correoform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(730, 624);
            this.Controls.Add(this.asuslbl);
            this.Controls.Add(this.val_id);
            this.Controls.Add(this.long_id);
            this.Controls.Add(this.long_nom);
            this.Controls.Add(this.val_correo);
            this.Controls.Add(this.cuerpotxt);
            this.Controls.Add(this.enviarbtn);
            this.Controls.Add(this.nombrelbl);
            this.Controls.Add(this.nombreCorreotxt);
            this.Controls.Add(this.asuntolbl);
            this.Controls.Add(this.asuntotxt);
            this.Controls.Add(this.correolbl);
            this.Controls.Add(this.correotxt);
            this.Controls.Add(this.clientelbl);
            this.Controls.Add(this.clienteCorreotxt);
            this.Controls.Add(this.titulolbl);
            this.Controls.Add(this.transparentPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Correoform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "correo";
            this.Load += new System.EventHandler(this.Correoform_Load);
            this.transparentPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TransparentPanel transparentPanel1;
        private System.Windows.Forms.Button cerrarbtn;
        private System.Windows.Forms.Label titulolbl;
        private System.Windows.Forms.Label clientelbl;
        private System.Windows.Forms.Label correolbl;
        private System.Windows.Forms.Label asuntolbl;
        //private DeclaracionDSTableAdapters.declaracion_fiscalTableAdapter declaracion_fiscalTableAdapter;
        //private ClientesDS clientesDS;
        private System.Windows.Forms.Label nombrelbl;
        public System.Windows.Forms.TextBox clienteCorreotxt;
        public System.Windows.Forms.TextBox correotxt;
        public System.Windows.Forms.TextBox nombreCorreotxt;
        private System.Windows.Forms.Button enviarbtn;
        private System.Windows.Forms.Label val_correo;
        private System.Windows.Forms.Label long_nom;
        private System.Windows.Forms.Label long_id;
        private System.Windows.Forms.Label val_id;
        private System.Windows.Forms.Label asuslbl;
        public System.Windows.Forms.TextBox cuerpotxt;
        public System.Windows.Forms.TextBox asuntotxt;
        private DragControl dragControl1;
    }
}