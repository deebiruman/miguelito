﻿namespace Prototipo
{
    partial class MenuContaform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuContaform));
            this.Fiscal_Btn = new System.Windows.Forms.PictureBox();
            this.firma_btn = new System.Windows.Forms.PictureBox();
            this.social_btn = new System.Windows.Forms.PictureBox();
            this.Sello_Btn = new System.Windows.Forms.PictureBox();
            this.transparentPanel1 = new Prototipo.TransparentPanel();
            this.minibtn = new System.Windows.Forms.Button();
            this.cerrarbtn = new System.Windows.Forms.Button();
            this.dragControl1 = new Prototipo.DragControl();
            this.Fondo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Fiscal_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firma_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.social_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sello_Btn)).BeginInit();
            this.transparentPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // Fiscal_Btn
            // 
            this.Fiscal_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Fiscal_Btn.BackgroundImage = global::Prototipo.Properties.Resources.boton_declaracion;
            this.Fiscal_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Fiscal_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fiscal_Btn.Location = new System.Drawing.Point(0, 199);
            this.Fiscal_Btn.Name = "Fiscal_Btn";
            this.Fiscal_Btn.Size = new System.Drawing.Size(240, 64);
            this.Fiscal_Btn.TabIndex = 12;
            this.Fiscal_Btn.TabStop = false;
            this.Fiscal_Btn.Click += new System.EventHandler(this.pictureBox2_Click);
            this.Fiscal_Btn.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.Fiscal_Btn.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // firma_btn
            // 
            this.firma_btn.BackColor = System.Drawing.Color.Transparent;
            this.firma_btn.BackgroundImage = global::Prototipo.Properties.Resources.boton_firma;
            this.firma_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.firma_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firma_btn.Location = new System.Drawing.Point(0, 303);
            this.firma_btn.Name = "firma_btn";
            this.firma_btn.Size = new System.Drawing.Size(240, 64);
            this.firma_btn.TabIndex = 13;
            this.firma_btn.TabStop = false;
            this.firma_btn.Click += new System.EventHandler(this.firma_btn_Click);
            this.firma_btn.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            this.firma_btn.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            // 
            // social_btn
            // 
            this.social_btn.BackColor = System.Drawing.Color.Transparent;
            this.social_btn.BackgroundImage = global::Prototipo.Properties.Resources.boton_segurosocial;
            this.social_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.social_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.social_btn.Location = new System.Drawing.Point(0, 407);
            this.social_btn.Name = "social_btn";
            this.social_btn.Size = new System.Drawing.Size(240, 64);
            this.social_btn.TabIndex = 14;
            this.social_btn.TabStop = false;
            this.social_btn.Click += new System.EventHandler(this.social_btn_Click);
            this.social_btn.MouseEnter += new System.EventHandler(this.pictureBox4_MouseEnter);
            this.social_btn.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            // 
            // Sello_Btn
            // 
            this.Sello_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Sello_Btn.BackgroundImage = global::Prototipo.Properties.Resources.botones;
            this.Sello_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Sello_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sello_Btn.Location = new System.Drawing.Point(0, 97);
            this.Sello_Btn.Name = "Sello_Btn";
            this.Sello_Btn.Size = new System.Drawing.Size(240, 64);
            this.Sello_Btn.TabIndex = 11;
            this.Sello_Btn.TabStop = false;
            this.Sello_Btn.Click += new System.EventHandler(this.Sello_Btn_Click);
            this.Sello_Btn.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.Sello_Btn.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // transparentPanel1
            // 
            this.transparentPanel1.Controls.Add(this.minibtn);
            this.transparentPanel1.Controls.Add(this.cerrarbtn);
            this.transparentPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.transparentPanel1.Location = new System.Drawing.Point(0, 0);
            this.transparentPanel1.Name = "transparentPanel1";
            this.transparentPanel1.Size = new System.Drawing.Size(1000, 51);
            this.transparentPanel1.TabIndex = 10;
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
            this.minibtn.Location = new System.Drawing.Point(898, 0);
            this.minibtn.Name = "minibtn";
            this.minibtn.Size = new System.Drawing.Size(51, 51);
            this.minibtn.TabIndex = 2;
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
            this.cerrarbtn.Location = new System.Drawing.Point(949, 0);
            this.cerrarbtn.Name = "cerrarbtn";
            this.cerrarbtn.Size = new System.Drawing.Size(51, 51);
            this.cerrarbtn.TabIndex = 1;
            this.cerrarbtn.Text = "X";
            this.cerrarbtn.UseVisualStyleBackColor = true;
            this.cerrarbtn.Click += new System.EventHandler(this.cerrarbtn_Click);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectoControl = this.transparentPanel1;
            // 
            // Fondo
            // 
            this.Fondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Fondo.Location = new System.Drawing.Point(742, 359);
            this.Fondo.Name = "Fondo";
            this.Fondo.Size = new System.Drawing.Size(278, 278);
            this.Fondo.TabIndex = 16;
            this.Fondo.TabStop = false;
            // 
            // MenuContaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Prototipo.Properties.Resources.fondo_seleccion;
            this.ClientSize = new System.Drawing.Size(1000, 624);
            this.Controls.Add(this.Fondo);
            this.Controls.Add(this.Sello_Btn);
            this.Controls.Add(this.Fiscal_Btn);
            this.Controls.Add(this.social_btn);
            this.Controls.Add(this.firma_btn);
            this.Controls.Add(this.transparentPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuContaform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EL PANA MIGUEL.EXE";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Fiscal_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firma_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.social_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sello_Btn)).EndInit();
            this.transparentPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Fondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TransparentPanel transparentPanel1;
        private System.Windows.Forms.Button cerrarbtn;
        private System.Windows.Forms.Button minibtn;
        private DragControl dragControl1;
        private System.Windows.Forms.PictureBox Fiscal_Btn;
        private System.Windows.Forms.PictureBox firma_btn;
        private System.Windows.Forms.PictureBox social_btn;
        private System.Windows.Forms.PictureBox Sello_Btn;
        private System.Windows.Forms.PictureBox Fondo;
    }
}