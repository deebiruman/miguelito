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
    public partial class MenuAdminform : Form
    {
        Conexion con = new Conexion();     

        public MenuAdminform()
        {
            InitializeComponent();
            (new Core.DropShadow()).ApplyShadows(this);

            //establecer valor del label bienvenida
            Bienvenida_Label.Text = "Bienvenido, " + PantallaNform.nombreusuario_logged;

            notificacion_FE();
            notificacion_SD();
            notificacion_Ss();
            notificacion_Df();
        }
        
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Sello_btn.Size = new Size(275, 113);
            Sello_btn.Location = new Point(0, 72);

            this.Sello_btn.Image = Image.FromFile(Application.StartupPath + "\\" + "sello_hover.png");

            Sello_btn.SizeMode = PictureBoxSizeMode.Zoom;

            Fondo.Image= Image.FromFile(Application.StartupPath + "\\" + "sello.png");
            Fondo.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Sello_btn.Size = new Size(239, 64);
            Sello_btn.Location = new Point(0, 97);

            this.Sello_btn.Image = Image.FromFile(Application.StartupPath + "\\" + "boton_sellodigital.png");
            Sello_btn.SizeMode = PictureBoxSizeMode.Zoom;

            Fondo.Image = null;
        }

        //DECLARACION FISCAL

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            Fiscal_btn.Size = new Size(275, 113);
            Fiscal_btn.Location = new Point(0, 174);

            this.Fiscal_btn.Image = Image.FromFile(Application.StartupPath + "\\" + "fiscal_hover.png");

           Fiscal_btn.SizeMode = PictureBoxSizeMode.Zoom;

            Fondo.Image = Image.FromFile(Application.StartupPath + "\\" + "fiscal.png");
            Fondo.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Fiscal_btn.Size = new Size(239, 64);
            Fiscal_btn.Location = new Point(0, 199);

            this.Fiscal_btn.Image = Image.FromFile(Application.StartupPath + "\\" + "boton_declaracion.png");
            Fiscal_btn.SizeMode = PictureBoxSizeMode.Zoom;

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

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            cliente_btn.Size = new Size(275, 113);
            cliente_btn.Location = new Point(0, 492);

            this.cliente_btn.Image = Image.FromFile(Application.StartupPath + "\\" + "cliente_hover.png");

            cliente_btn.SizeMode = PictureBoxSizeMode.Zoom;

            Fondo.Image = Image.FromFile(Application.StartupPath + "\\" + "usuarios.png");
            Fondo.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            cliente_btn.Size = new Size(239, 64);
            cliente_btn.Location = new Point(0, 517);

            this.cliente_btn.Image = Image.FromFile(Application.StartupPath + "\\" + "boton_cliente.png");
            cliente_btn.SizeMode = PictureBoxSizeMode.Zoom;
            Fondo.Image = null;
        }

        private void Sello_Btn_Click(object sender, EventArgs e)
        {
            SelloD sd = new SelloD();
            sd.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DeclaracionFform df = new DeclaracionFform();
            df.Show();
        }

        private void firma_btn_Click(object sender, EventArgs e)
        {
            FirmaEform fe = new FirmaEform();
            fe.Show();
        }

        private void social_btn_Click(object sender, EventArgs e)
        {
            SeguroSform ss = new SeguroSform();
            ss.Show();
        }

        private void cliente_btn_Click(object sender, EventArgs e)
        {
            Clientesform cl = new Clientesform();
            cl.Show();
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

        }

        #region notificaciones 
        //FIRMA ELECTRONICA

        private void notificacion_FE()
        {
            int id_actual = 0;

            id_actual = con.noty_Fe(id_actual);

            notyFe.ShowBalloonTip(1000, "Documento proximo a expirar", "La firma electronica del usuario " + id_actual, ToolTipIcon.None);
        }

        private void notyFe_BalloonTipClicked(object sender, EventArgs e)
        {
            FirmaEform fe = new FirmaEform();
            fe.Show();
        }

        private void notyFe_Click(object sender, EventArgs e)
        {
            FirmaEform fe = new FirmaEform();
            fe.Show();
        }

        //SELLO DIGITAL

        private void notificacion_SD()
        {
            int id_actual = 0;

            id_actual = con.noty_Sd(id_actual);

            notyFe.ShowBalloonTip(1000, "Documento proximo a expirar", "El sello digial del usuario " + id_actual, ToolTipIcon.None);
        }

        private void notySd_BalloonTipClicked_1(object sender, EventArgs e)
        {
            SelloD sd = new SelloD();
            sd.Show();
        }

        private void notySd_Click(object sender, EventArgs e)
        {
            SelloD sd = new SelloD();
            sd.Show();
        }


        //SEGURO SOCIAL

        private void notificacion_Ss()
        {
            int id_actual = 0;

            id_actual = con.noty_Ss(id_actual);

            notyFe.ShowBalloonTip(1000, "Documento proximo a expirar", "El seguro social del usuario " + id_actual, ToolTipIcon.None);
        }

        private void notySs_BalloonTipClicked(object sender, EventArgs e)
        {
            SeguroSform ss = new SeguroSform();
            ss.Show();
        }

        private void notySs_Click(object sender, EventArgs e)
        {
            SeguroSform ss = new SeguroSform();
            ss.Show();
        }

        //DECLARACION FISCAL

        private void notificacion_Df()
        {
            int id_actual = 0;

            id_actual = con.noty_Df(id_actual);

            notyFe.ShowBalloonTip(1000, "Documento proximo a expirar", "La declaracion fiscal del usuario " + id_actual, ToolTipIcon.None);
        }

        private void notyDf_BalloonTipClicked(object sender, EventArgs e)
        {
            DeclaracionFform df = new DeclaracionFform();
            df.Show();
        }

        private void notyDf_Click(object sender, EventArgs e)
        {
            DeclaracionFform df = new DeclaracionFform();
            df.Show();
        }

        #endregion
    }
}