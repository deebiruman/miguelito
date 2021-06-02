using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo
{
    public partial class DeclaracionFform : Form
    {

        Conexion con = new Conexion();
        int poc;

        public DeclaracionFform()
        {
            InitializeComponent();
            (new Core.DropShadow()).ApplyShadows(this);
            con.alerta_Df(dgvdeclaracion_F);
            con.alerta_DfX(dgvdeclaracion_FX);
        }

        private void cerrarbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeclaracionF_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'declaracionDS.declaracion_fiscal' Puede moverla o quitarla según sea necesario.
            this.declaracion_fiscalTableAdapter.Fill(this.declaracionDS.declaracion_fiscal);
            // TODO: esta línea de código carga datos en la tabla 'miguelitoDataSet10.declaracion_fiscal' Puede moverla o quitarla según sea necesario.
            //     this.declaracion_fiscalTableAdapter1.Fill(this.miguelitoDataSet10.declaracion_fiscal);
            // TODO: esta línea de código carga datos en la tabla 'miguelitoDataSet6.declaracion_fiscal' Puede moverla o quitarla según sea necesario.
            //    this.declaracion_fiscalTableAdapter.Fill(this.miguelitoDataSet6.declaracion_fiscal);
            // TODO: esta línea de código carga datos en la tabla 'miguelitoDataSet1.declaración_físcal' Puede moverla o quitarla según sea necesario.
            // this.declaración_físcalTableAdapter.Fill(this.miguelitoDataSet1.declaración_físcal);
            // TODO: esta línea de código carga datos en la tabla 'el_Pana_MiguelDataSet4.declaración_fiscal' Puede moverla o quitarla según sea necesario.
            // this.declaración_fiscalTableAdapter.Fill(this.el_Pana_MiguelDataSet4.declaración_fiscal);

        }

        private void agregarbtn_Click(object sender, EventArgs e)
        {
            Conexion.Stop = 0;
            Conexion.Verificador_vacio = 2;

            con.VerificarVacio(textBox1.Text, "id cliente, minimo 8 caracteres", 10);

            if (Conexion.Verificador_vacio == 1)
            {
                if (fecha_In.Value > fecha_Fn.Value)
                {
                    MessageBox.Show("Introduzca bien la fecha");
                }
                else
                {
                    if (con.Registrado_Df(Convert.ToInt32(textBox1.Text)) == 0)
                    {
                        MessageBox.Show(con.Insertar_Df(Convert.ToInt32(textBox1.Text), this.fecha_In.Text, this.fecha_Fn.Text, this.declaracion.Text, this.seguros.Text, this.dospor.Text));
                        con.Cargar_Df(declaracionFdgv);
                        textBox1.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Cliente ya registrado");
                        textBox1.Text = "";
                    }
                }
            }
        }

        private void eliminarbtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" | textBox1.TextLength <= 4)
            {
                MessageBox.Show("Introduzca completamente el id del cliente, minimo 5 caracteres");
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Seguro que quieres eliminar este cliente?", "eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    con.eliminar_Df(Convert.ToInt32(textBox1.Text));
                    con.Cargar_Df(declaracionFdgv);

                    textBox1.Text = "";
                }
                else if (resultado == DialogResult.No)
                {

                }
            }
        }

        private void modificarbtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Introduzca el id del cliente");
            }
            else
            {
                MessageBox.Show(con.actualizar_Df(Convert.ToInt32(textBox1.Text), fecha_In.Text, fecha_Fn.Text, declaracion.Text, seguros.Text, dospor.Text));
                con.Cargar_Df(declaracionFdgv);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = declaracionFdgv.CurrentRow.Index;
            textBox1.Text = declaracionFdgv[0, poc].Value.ToString();
            fecha_In.Text = declaracionFdgv[1, poc].Value.ToString();
            fecha_Fn.Text = declaracionFdgv[2, poc].Value.ToString();
            declaracion.Text = declaracionFdgv[3, poc].Value.ToString();
            seguros.Text = declaracionFdgv[4, poc].Value.ToString();
            dospor.Text = declaracionFdgv[5, poc].Value.ToString();
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

        private void dgvdeclaracion_F_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = dgvdeclaracion_F.CurrentRow.Index;
            textBox1.Text = dgvdeclaracion_F[0, poc].Value.ToString();
            fecha_In.Text = dgvdeclaracion_F[1, poc].Value.ToString();
            fecha_Fn.Text = dgvdeclaracion_F[2, poc].Value.ToString();
            declaracion.Text = dgvdeclaracion_F[3, poc].Value.ToString();
            seguros.Text = dgvdeclaracion_F[4, poc].Value.ToString();
            dospor.Text = dgvdeclaracion_F[5, poc].Value.ToString();
        }

        private void dgvdeclaracion_FX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = dgvdeclaracion_FX.CurrentRow.Index;
            textBox1.Text = dgvdeclaracion_FX[0, poc].Value.ToString();
            fecha_In.Text = dgvdeclaracion_FX[1, poc].Value.ToString();
            fecha_Fn.Text = dgvdeclaracion_FX[2, poc].Value.ToString();
            declaracion.Text = dgvdeclaracion_FX[3, poc].Value.ToString();
            seguros.Text = dgvdeclaracion_FX[4, poc].Value.ToString();
            dospor.Text = dgvdeclaracion_FX[5, poc].Value.ToString();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            string texto = textBox1.Text;

            if (Conexion.Minimo_validacion(texto, "MIN") == 1)
            {

            }
            else
            {
                MessageBox.Show("Longitud minima de 8");
            }
        }
    }
}