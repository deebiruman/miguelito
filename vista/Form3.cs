using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//-----------------------Facade------------------------

namespace Prototipo
{
    public partial class Form3 : Form
    {
        Conexion con = new Conexion();

        public Form3()
        {
            InitializeComponent();
            (new Core.DropShadow()).ApplyShadows(this);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Sello_Btn.Size = new Size(275, 113);
            Sello_Btn.Location = new Point(0, 72);

            this.Sello_Btn.Image = Image.FromFile(Application.StartupPath + "\\" + "sello_hover.png");

            Sello_Btn.SizeMode = PictureBoxSizeMode.Zoom;

            Fondo.Image= Image.FromFile(Application.StartupPath + "\\" + "sello.png");
            Fondo.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Sello_Btn.Size = new Size(239, 64);
            Sello_Btn.Location = new Point(0, 97);

            this.Sello_Btn.Image = Image.FromFile(Application.StartupPath + "\\" + "boton_sellodigital.png");
            Sello_Btn.SizeMode = PictureBoxSizeMode.Zoom;

            Fondo.Image = null;
        }

        //DECLARACION FISCAL

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            Fiscal_Btn.Size = new Size(275, 113);
            Fiscal_Btn.Location = new Point(0, 174);

            this.Fiscal_Btn.Image = Image.FromFile(Application.StartupPath + "\\" + "fiscal_hover.png");

           Fiscal_Btn.SizeMode = PictureBoxSizeMode.Zoom;

            Fondo.Image = Image.FromFile(Application.StartupPath + "\\" + "fiscal.png");
            Fondo.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Fiscal_Btn.Size = new Size(239, 64);
            Fiscal_Btn.Location = new Point(0, 199);

            this.Fiscal_Btn.Image = Image.FromFile(Application.StartupPath + "\\" + "boton_declaracion.png");
            Fiscal_Btn.SizeMode = PictureBoxSizeMode.Zoom;

            Fondo.Image = null;
        }
        // FIRMA ELECTRONICA

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            firma_btn.Size = new Size(275, 113);
            firma_btn.Location = new Point(0, 278);

            this.firma_btn.Image = Image.FromFile(Application.StartupPath + "\\" + "firma_hover.png");

           firma_btn.SizeMode = PictureBoxSizeMode.Zoom;

            Fondo.Image = Image.FromFile(Application.StartupPath + "\\" + "firma.png");
            Fondo.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            firma_btn.Size = new Size(239, 64);
            firma_btn.Location = new Point(0, 303);

            this.firma_btn.Image = Image.FromFile(Application.StartupPath + "\\" + "boton_firma.png");
            firma_btn.SizeMode = PictureBoxSizeMode.Zoom;

            Fondo.Image = null;
        }

        //SEGURO SOCIAL

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            social_btn.Size = new Size(275, 113);
            social_btn.Location = new Point(0, 382);

            this.social_btn.Image = Image.FromFile(Application.StartupPath + "\\" + "social_hover.png");

            social_btn.SizeMode = PictureBoxSizeMode.Zoom;

            Fondo.Image = Image.FromFile(Application.StartupPath + "\\" + "instituto.png");
            Fondo.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            social_btn.Size = new Size(239, 64);
            social_btn.Location = new Point(0, 407);

            this.social_btn.Image = Image.FromFile(Application.StartupPath + "\\" + "boton_social.png");
            social_btn.SizeMode = PictureBoxSizeMode.Zoom;
            Fondo.Image = null;
        }

        //CLIENTES

        private void Sello_Btn_Click(object sender, EventArgs e)
        {
            SelloD sd = new SelloD();
            sd.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DeclaracionF df = new DeclaracionF();
            df.Show();
        }

        private void firma_btn_Click(object sender, EventArgs e)
        {
            FirmaE fe = new FirmaE();
            fe.Show();
        }

        private void social_btn_Click(object sender, EventArgs e)
        {
            SeguroS ss = new SeguroS();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'miguelitoDataSet19.declaracion_fiscal' Puede moverla o quitarla según sea necesario.
            //this.declaracion_fiscalTableAdapter.Fill(this.miguelitoDataSet19.declaracion_fiscal);
            // TODO: esta línea de código carga datos en la tabla 'miguelitoDataSet18.sello_digital' Puede moverla o quitarla según sea necesario.
            //this.sello_digitalTableAdapter.Fill(this.miguelitoDataSet18.sello_digital);
            // TODO: esta línea de código carga datos en la tabla 'miguelitoDataSet17.seguro_social' Puede moverla o quitarla según sea necesario.
            //this.seguro_socialTableAdapter1.Fill(this.miguelitoDataSet17.seguro_social);
            // TODO: esta línea de código carga datos en la tabla 'miguelitoDataSet16.seguro_social' Puede moverla o quitarla según sea necesario.
            //this.seguro_socialTableAdapter.Fill(this.miguelitoDataSet16.seguro_social);
            // TODO: esta línea de código carga datos en la tabla 'miguelitoDataSet14.firma_electronica' Puede moverla o quitarla según sea necesario.
            //this.firma_electronicaTableAdapter.Fill(this.miguelitoDataSet14.firma_electronica);
        }
    }
}