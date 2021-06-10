using Prototipo.vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace Prototipo.vista
{
    public partial class Correoform : Form
    {
        Conexion con = new Conexion();
        int poc;
        public string correo_cl;
        public string nombre_cl;

        MailMessage correos = new MailMessage();
        SmtpClient envios = new SmtpClient();

        public Correoform()
        {
            InitializeComponent();
            (new Core.DropShadow()).ApplyShadows(this);
        }

        private void cerrarbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Correoform_Load(object sender, EventArgs e)
        {
            
        }

        private void enviarbtn_Click(object sender, EventArgs e)
        {
            Conexion.Stop = 0;
            Conexion.Verificador_vacio = 2;

            con.VerificarVacio(clienteCorreotxt.Text, "id cliente, minimo 8 caracteres", 10);
            con.VerificarVacio(nombreCorreotxt.Text, "nombre cliente, minimo 8 caracteres", 20);
            con.VerificarVacio(correotxt.Text, "correo cliente valido", 30);
            con.VerificarVacio(asuntotxt.Text, "asunto correo, minimo 8 caracteres", 40);
            con.VerificarVacio(cuerpotxt.Text, "cuerpo correo, minimo 8 caracteres", 50);

            if (Conexion.Verificador_vacio == 1)
            {
                try
                {
                    correos.Body = cuerpotxt.Text;
                    correos.Subject = asuntotxt.Text;
                    correos.IsBodyHtml = true;
                    correos.To.Add(correotxt.Text.Trim());

                    correos.From = new MailAddress("yeyotadeoae@gmail.com");
                    envios.Credentials = new NetworkCredential("yeyotadeoae@gmail.com", "tayeyo1998");

                    envios.Host = "smtp.gmail.com";
                    envios.Port = 587;
                    envios.EnableSsl = true;

                    envios.Send(correos);
                    MessageBox.Show("El mensaje fue enviado correctamente");
                }
                catch (Exception)
                {
                    MessageBox.Show("No se envio el correo correctamente");
                }

            }
        }

        private void correotxt_TextChanged(object sender, EventArgs e)
        {
            string texto = correotxt.Text;
            string tipo = "Correo";

            if (Conexion.Minimo_validacion(texto, tipo) == 1)
            {
                val_correo.Visible = false;
            }
        }

        private void correotxt_Leave(object sender, EventArgs e)
        {
            string texto = correotxt.Text;
            string tipo = "Correo";

            if (Conexion.Minimo_validacion(texto, tipo) == 1)
            {

            }
            else
            {
                val_correo.Visible = true;
                correotxt.SelectAll();
            }
        }

        private void clienteCorreotxt_TextChanged(object sender, EventArgs e)
        {
            string texto = clienteCorreotxt.Text;
            val_id.Visible = false;

            if (Conexion.Minimo_validacion(texto, "MIN") == 1)
            {
                long_id.Visible = false;
            }
        }

        private void clienteCorreotxt_Leave(object sender, EventArgs e)
        {
            string texto = clienteCorreotxt.Text;

            if (Conexion.Minimo_validacion(texto, "MIN") == 1)
            {

            }
            else if (clienteCorreotxt.Text == "")
            {
                long_id.Visible = false;
            }
            else
            {
                long_id.Visible = true;
                clienteCorreotxt.SelectAll();
            }
        }

        private void nombreCorreotxt_TextChanged(object sender, EventArgs e)
        {
            string texto = nombreCorreotxt.Text;

            if (Conexion.Minimo_validacion(texto, "MIN") == 1)
            {
                long_nom.Visible = false;
            }
        }

        private void nombreCorreotxt_Leave(object sender, EventArgs e)
        {
            string texto = nombreCorreotxt.Text;

            if (Conexion.Minimo_validacion(texto, "MIN") == 1)
            {

            }
            else if (nombreCorreotxt.Text == "")
            {
                long_nom.Visible = false;
            }
            else
            {
                long_id.Visible = true;
                nombreCorreotxt.SelectAll();
            }
        }

        private void asuntotxt_TextChanged(object sender, EventArgs e)
        {
            string texto = asuntotxt.Text;

            if (Conexion.Minimo_validacion(texto, "MIN") == 1)
            {
                asuslbl.Visible = false;
            }
        }

        private void asuntotxt_Leave(object sender, EventArgs e)
        {
            string texto = asuntotxt.Text;

            if (Conexion.Minimo_validacion(texto, "MIN") == 1)
            {

            }
            else if (asuntotxt.Text == "")
            {
                asuslbl.Visible = false;
            }
            else
            {
                long_id.Visible = true;
                asuntotxt.SelectAll();
            }
        }
    }
}
