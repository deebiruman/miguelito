using System;
using System.Drawing;
using System.Windows.Forms;

namespace Prototipo
{
    public partial class Form1 : Form
    {
        Conexion con = new Conexion();


        //-------------------------Factory Method--------------------------
        public Form1()
        {
            InitializeComponent();
            (new Core.DropShadow()).ApplyShadows(this);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void entrarbtn_Click(object sender, EventArgs e)
        {
            String UssTadeo = "Tadeo";
            String PassTadeo = "Tadeo";
            String UssMiguel = "Miguel";
            String PassMiguel = "Miguel";
            if (textBox1.Text == UssMiguel & textBox2.Text == PassMiguel)
            {
                Form2 f2 = new Form2();
                Hide();
                f2.ShowDialog();
                Show();
            }
            else if (textBox1.Text == UssTadeo & textBox2.Text == PassTadeo)
            {
                Form3 f3 = new Form3();
                Hide();
                f3.ShowDialog();
                Show();
            }
            else
            {
                if (textBox1.Text == "" & textBox2.Text == "")
                {
                    MessageBox.Show("Introduzca los datos");
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos");
                }
            }
        }
    }
}