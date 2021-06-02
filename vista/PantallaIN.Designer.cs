namespace Prototipo
{
    partial class PantallaNform
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaNform));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usuariotxt = new System.Windows.Forms.TextBox();
            this.contratxt = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.entrarbtn = new System.Windows.Forms.Button();
            this.transparentPanel1 = new Prototipo.TransparentPanel();
            this.minibtn = new System.Windows.Forms.Button();
            this.cerrarbtn = new System.Windows.Forms.Button();
            this.dragControl1 = new Prototipo.DragControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.transparentPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ebrima", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(609, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio de sesión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(614, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(614, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña:";
            // 
            // usuariotxt
            // 
            this.usuariotxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.usuariotxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usuariotxt.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariotxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usuariotxt.Location = new System.Drawing.Point(618, 235);
            this.usuariotxt.Name = "usuariotxt";
            this.usuariotxt.Size = new System.Drawing.Size(189, 22);
            this.usuariotxt.TabIndex = 1;
            // 
            // contratxt
            // 
            this.contratxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.contratxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contratxt.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contratxt.Location = new System.Drawing.Point(618, 316);
            this.contratxt.Name = "contratxt";
            this.contratxt.PasswordChar = '•';
            this.contratxt.Size = new System.Drawing.Size(189, 22);
            this.contratxt.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Prototipo.Properties.Resources.LOGO1;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(706, 560);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(316, 39);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Prototipo.Properties.Resources.login_screen_picture;
            this.pictureBox4.Location = new System.Drawing.Point(-35, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(584, 624);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(847, 602);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "El Pana Miguel_dev release v1.0";
            // 
            // entrarbtn
            // 
            this.entrarbtn.BackColor = System.Drawing.Color.Tomato;
            this.entrarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.entrarbtn.FlatAppearance.BorderSize = 0;
            this.entrarbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.entrarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entrarbtn.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrarbtn.ForeColor = System.Drawing.Color.White;
            this.entrarbtn.Location = new System.Drawing.Point(618, 378);
            this.entrarbtn.Name = "entrarbtn";
            this.entrarbtn.Size = new System.Drawing.Size(130, 44);
            this.entrarbtn.TabIndex = 3;
            this.entrarbtn.Text = "ENTRAR";
            this.entrarbtn.UseVisualStyleBackColor = false;
            this.entrarbtn.Click += new System.EventHandler(this.entrarbtn_Click);
            // 
            // transparentPanel1
            // 
            this.transparentPanel1.Controls.Add(this.minibtn);
            this.transparentPanel1.Controls.Add(this.cerrarbtn);
            this.transparentPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.transparentPanel1.Location = new System.Drawing.Point(0, 0);
            this.transparentPanel1.Name = "transparentPanel1";
            this.transparentPanel1.Size = new System.Drawing.Size(1022, 51);
            this.transparentPanel1.TabIndex = 12;
            // 
            // minibtn
            // 
            this.minibtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minibtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minibtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.minibtn.FlatAppearance.BorderSize = 0;
            this.minibtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minibtn.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minibtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minibtn.Location = new System.Drawing.Point(920, 0);
            this.minibtn.Name = "minibtn";
            this.minibtn.Size = new System.Drawing.Size(51, 51);
            this.minibtn.TabIndex = 4;
            this.minibtn.Text = "_";
            this.minibtn.UseVisualStyleBackColor = true;
            this.minibtn.Click += new System.EventHandler(this.minibtn_Click);
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
            this.cerrarbtn.Location = new System.Drawing.Point(971, 0);
            this.cerrarbtn.Name = "cerrarbtn";
            this.cerrarbtn.Size = new System.Drawing.Size(51, 51);
            this.cerrarbtn.TabIndex = 5;
            this.cerrarbtn.Text = "X";
            this.cerrarbtn.UseVisualStyleBackColor = true;
            this.cerrarbtn.Click += new System.EventHandler(this.cerrarbttn_Click);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectoControl = this.transparentPanel1;
            // 
            // PantallaNform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1022, 624);
            this.Controls.Add(this.entrarbtn);
            this.Controls.Add(this.transparentPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.contratxt);
            this.Controls.Add(this.usuariotxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaNform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.transparentPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usuariotxt;
        private System.Windows.Forms.TextBox contratxt;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private TransparentPanel transparentPanel1;
        private System.Windows.Forms.Button cerrarbtn;
        private System.Windows.Forms.Button minibtn;
        private DragControl dragControl1;
        private System.Windows.Forms.Button entrarbtn;
    }
}

