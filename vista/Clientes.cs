using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Prototipo
{
    public partial class Clientesform : Form
    {
        Conexion con = new Conexion();
        int poc;

        public Clientesform()
        {
            InitializeComponent();
            (new Core.DropShadow()).ApplyShadows(this);
            rfctxt.Hide();
            curptxt.Hide();
            rfclbl.Hide();
            curplbl.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            rfctxt.MaxLength = 13;
            rfctxt.Show();
            rfclbl.Show();

            curptxt.Enabled = false;
            curplbl.Enabled = false;

            curptxt.Clear();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            rfctxt.MaxLength = 12;
            rfctxt.Show();
            rfclbl.Show();
            curptxt.Show();
            curplbl.Show();

            curptxt.Enabled = true;
            curplbl.Enabled = true;

            // textBox6.Hide();
            // label5.Hide();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clientesDS.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.clientesDS.clientes);
            // TODO: esta línea de código carga datos en la tabla 'miguelitoDataSet1.clientes' Puede moverla o quitarla según sea necesario.
            //  this.clientesTableAdapter1.Fill(this.miguelitoDataSet1.clientes);
            // TODO: esta línea de código carga datos en la tabla 'miguelitoDataSet.clientes' Puede moverla o quitarla según sea necesario.
            //  this.clientesTableAdapter1.Fill(this.miguelitoDataSet.clientes);
            // TODO: esta línea de código carga datos en la tabla 'el_Pana_MiguelDataSet.clientes' Puede moverla o quitarla según sea necesario.
            //this.clientesTableAdapter.Fill(this.el_Pana_MiguelDataSet.clientes);
        }

        //---------------------------Mediator------------------------
        private void agregarbtn_Click(object sender, EventArgs e)
        {
            Conexion.Stop = 0;
            Conexion.Verificador_vacio = 2;
            
            if (moralrbtn.Checked == false & fisicarbtn.Checked == false)
            {
                MessageBox.Show("Se tiene que selecionar el tipo de cliente");
            }
            else
            {
                if (moralrbtn.Checked)
                {
                    con.VerificarVacio(clientetxt.Text, "id cliente, minimo 8 caracteres", 10);
                    con.VerificarVacio(nombretxt.Text, "nombre cliente, minimo 8 caracteres", 20);
                    con.VerificarVacio(domitxt.Text, "domicilio cliente, minimo 8 caracteres", 30);
                    con.VerificarVacio(teletxt.Text, "telefono cliente, minimo 8 caracteres", 40);
                    con.VerificarVacio(correotxt.Text, "correo cliente valido", 50);
                    con.VerificarVacio(rfctxt.Text, "RFC cliente, minimo 13 caracteres", 60);

                    if (Conexion.Verificador_vacio == 1)
                    {
                        if (con.Registrado_cl(Convert.ToInt32(clientetxt.Text)) == 0)
                        {
                            MessageBox.Show(con.Insertar_Cl(Convert.ToInt32(clientetxt.Text), nombretxt.Text, domitxt.Text, teletxt.Text, correotxt.Text, rfctxt.Text, curptxt.Text));
                            con.Cargar_Cl(clientesdgv);
                            clientetxt.Text = "";
                            nombretxt.Text = "";
                            domitxt.Text = "";
                            teletxt.Text = "";
                            correotxt.Text = "";
                            rfctxt.Text = "";
                            curptxt.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Cliente ya registrado");
                            clientetxt.Text = "";
                            nombretxt.Text = "";
                            domitxt.Text = "";
                            teletxt.Text = "";
                            correotxt.Text = "";
                            rfctxt.Text = "";
                            curptxt.Text = "";
                        }
                    }
                }
                if (fisicarbtn.Checked)
                {
                    con.VerificarVacio(clientetxt.Text, "id cliente, minimo 8 caracteres", 10);
                    con.VerificarVacio(nombretxt.Text, "nombre cliente, minimo 8 caracteres", 20);
                    con.VerificarVacio(domitxt.Text, "domicilio cliente, minimo 8 caracteres", 30);
                    con.VerificarVacio(teletxt.Text, "telefono cliente, minimo 8 caracteres", 40);
                    con.VerificarVacio(correotxt.Text, "correo cliente valido", 50);
                    con.VerificarVacio(rfctxt.Text, "RFC cliente, minimo 12 caracteres", 60);
                    con.VerificarVacio(curptxt.Text, "CURP cliente valido", 70);

                    if (Conexion.Verificador_vacio == 1)
                    {
                        if (con.Registrado_cl(Convert.ToInt32(clientetxt.Text)) == 0)
                        {
                            MessageBox.Show(con.Insertar_Cl(Convert.ToInt32(clientetxt.Text), nombretxt.Text, domitxt.Text, teletxt.Text, correotxt.Text, rfctxt.Text, curptxt.Text));
                            con.Cargar_Cl(clientesdgv);
                            clientetxt.Text = "";
                            nombretxt.Text = "";
                            domitxt.Text = "";
                            teletxt.Text = "";
                            correotxt.Text = "";
                            rfctxt.Text = "";
                            curptxt.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Cliente ya registrado");
                            clientetxt.Text = "";
                            nombretxt.Text = "";
                            domitxt.Text = "";
                            teletxt.Text = "";
                            correotxt.Text = "";
                            rfctxt.Text = "";
                            curptxt.Text = "";
                        }
                    }
                }
            }
        }

        private void eliminarbtn_Click(object sender, EventArgs e)
        {

            if (clientetxt.Text == "")
            {
                MessageBox.Show("Introduzca el id del cliente");
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Seguro que quieres eliminar este cliente?", "eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    con.eliminar_Cl(Convert.ToInt32(clientetxt.Text));
                    con.Cargar_Cl(clientesdgv);

                    clientetxt.Text = "";
                    nombretxt.Text = "";
                    domitxt.Text = "";
                    teletxt.Text = "";
                    correotxt.Text = "";
                    rfctxt.Text = "";
                    curptxt.Text = "";
                }
                else if(resultado == DialogResult.No)
                {

                }
            }
        }

        private void modificarbtn_Click(object sender, EventArgs e)
        {
            if (clientetxt.Text == "")
            {
                MessageBox.Show("Introduzca el id del cliente");
            }
            else
            {
                MessageBox.Show(con.actualizar_Cl(Convert.ToInt32(clientetxt.Text), nombretxt.Text, domitxt.Text, teletxt.Text, correotxt.Text, rfctxt.Text, curptxt.Text));
                con.Cargar_Cl(clientesdgv);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = clientesdgv.CurrentRow.Index;
            clientetxt.Text = clientesdgv[0, poc].Value.ToString();
            nombretxt.Text = clientesdgv[1, poc].Value.ToString();
            domitxt.Text = clientesdgv[2, poc].Value.ToString();
            teletxt.Text = clientesdgv[3, poc].Value.ToString();
            correotxt.Text = clientesdgv[4, poc].Value.ToString();
            rfctxt.Text = clientesdgv[5, poc].Value.ToString();
            curptxt.Text = clientesdgv[6, poc].Value.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan numeros");
                e.Handled = true;
                return;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan numeros");
                e.Handled = true;
                return;
            }
        }

        //------------------Factory Method-------------------
        //------------------Template Method------------------
        public void exportarexcel(DataGridView tabla)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);

            int indicecolumna = 0;
            
            foreach (DataGridViewColumn col in tabla.Columns)
            {
                indicecolumna++;

                excel.Cells[1, indicecolumna] = col.Name;
            }
            int indicefila = 0;

            foreach (DataGridViewRow row in tabla.Rows)
            {
                indicefila++;
                indicecolumna = 0;

                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    indicecolumna++;

                    excel.Cells[indicefila + 1, indicecolumna] = row.Cells[col.Name].Value;
                }
            }
            excel.Visible = true;
        }

        private void excelbtn_Click(object sender, EventArgs e)
        {
            exportarexcel(clientesdgv);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            clientetxt.Enabled = false;
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            string texto = correotxt.Text;
            string tipo = "Correo";

            if (Conexion.Minimo_validacion(texto,tipo) == 1)
            {
                
            }
            else
            {
                MessageBox.Show("Correo no válido");
                correotxt.SelectAll();
                correotxt.Focus();
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            string texto = rfctxt.Text;
            string tipo = "RFC";

            if (Conexion.Minimo_validacion(texto, tipo) == 1)
            {
                
            }
            else
            {
                MessageBox.Show("RFC no válido");
                rfctxt.SelectAll();
                rfctxt.Focus();
            }
        }

        private void textBox7_Leave_1(object sender, EventArgs e)
        {
            string texto = curptxt.Text;

            if (Conexion.Minimo_validacion(texto, "CURP") == 1)
            {

            }
            else
            {
                MessageBox.Show("CURP no válido");
                curptxt.SelectAll();
                curptxt.Focus();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            string texto = clientetxt.Text;

            if (Conexion.Minimo_validacion(texto, "MIN") == 1)
            {
                
            }
            else
            {
                MessageBox.Show("Longitud minima de 8");
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            string texto = nombretxt.Text;

            if (Conexion.Minimo_validacion(texto, "MIN") == 1)
            {

            }
            else
            {
                MessageBox.Show("Longitud minima de 8");
                nombretxt.SelectAll();
                nombretxt.Focus();
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            string texto = domitxt.Text;

            if (Conexion.Minimo_validacion(texto, "MIN") == 1)
            {

            }
            else
            {
                MessageBox.Show("Longitud minima de 8");
                domitxt.SelectAll();
                domitxt.Focus();
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            string texto = teletxt.Text;

            if (Conexion.Minimo_validacion(texto, "Telefono") == 1)
            {

            }
            else
            {
                MessageBox.Show("Longitud minima de 10");
                teletxt.SelectAll();
                teletxt.Focus();
            }
        }
    }
}