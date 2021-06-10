using System;
using System.Windows.Forms;

namespace Prototipo
{
    public partial class PantallaNform : Form
    {
        Conexion con = new Conexion();

        //datos_para_el_Label_de_bienvenida
        public static string nombreusuario_logged;

        //-------------------------Factory Method--------------------------
        public PantallaNform()
        {
            InitializeComponent();
            (new Core.DropShadow()).ApplyShadows(this);
        }

        private void cerrarbttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minibtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void entrarbtn_Click(object sender, EventArgs e)
        {
            /*
            String UssTadeo = "Tadeo";
            String PassTadeo = "Tadeo";
            String UssMiguel = "Miguel";
            String PassMiguel = "Miguel";
            if (usuariotxt.Text == UssMiguel & contratxt.Text == PassMiguel)
            {
                //establecer nombre del usuario loguineado;
                nombreusuario_logged = "Miguel";
                
                MenuAdminform f2 = new MenuAdminform();
                Hide();
                f2.ShowDialog();
                Show();
            }
            else if (usuariotxt.Text == UssTadeo & contratxt.Text == PassTadeo)
            {
                //establecer nombre del usuario loguineado;
                nombreusuario_logged = "Tadeo";
                
                MenuContaform f3 = new MenuContaform();
                Hide();
                f3.ShowDialog();
                Show();
            }
            else
            {
                if (usuariotxt.Text == "" & contratxt.Text == "")
                {
                    MessageBox.Show("Introduzca los datos");
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos");
                }
            }
            */
            MenuAdminform f2 = new MenuAdminform();
            Hide();
            f2.ShowDialog();
            Show();
        }
    }
}