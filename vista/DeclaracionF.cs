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
            con.correo_Df(dgvdeclaracion);
        }

        private void cerrarbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeclaracionF_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'declaracionDataSet.declaracion_fiscal' Puede moverla o quitarla según sea necesario.
            this.declaracion_fiscalTableAdapter1.Fill(this.declaracionDataSet.declaracion_fiscal);
        }

        private void agregarbtn_Click(object sender, EventArgs e)
        {
            Conexion.Stop = 0;
            Conexion.Verificador_vacio = 2;

            con.VerificarVacio(clientetxt.Text, "id cliente, minimo 8 caracteres", 10);

            if (Conexion.Verificador_vacio == 1)
            {
                if (fecha_In.Value > fecha_Fn.Value)
                {
                    MessageBox.Show("Introduzca bien la fecha");
                }
                else
                {
                    if (con.Registrado_Df(Convert.ToInt32(clientetxt.Text)) == 0)
                    {
                        MessageBox.Show(con.Insertar_Df(Convert.ToInt32(clientetxt.Text), this.fecha_In.Text, this.fecha_Fn.Text, this.declaracion.Text, this.seguros.Text, this.dospor.Text));
                        con.Cargar_Df(declaracionFdgv);
                        clientetxt.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Cliente ya registrado");
                        clientetxt.Text = "";
                    }
                }
            }
        }

        private void eliminarbtn_Click(object sender, EventArgs e)
        {
            if (clientetxt.Text == "" | clientetxt.TextLength <= 4)
            {
                MessageBox.Show("Introduzca completamente el id del cliente, minimo 5 caracteres");
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Seguro que quieres eliminar este cliente?", "eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    con.eliminar_Df(Convert.ToInt32(clientetxt.Text));
                    con.Cargar_Df(declaracionFdgv);

                    clientetxt.Text = "";
                }
                else if (resultado == DialogResult.No)
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
                MessageBox.Show(con.actualizar_Df(Convert.ToInt32(clientetxt.Text), fecha_In.Text, fecha_Fn.Text, declaracion.Text, seguros.Text, dospor.Text));
                con.Cargar_Df(declaracionFdgv);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = declaracionFdgv.CurrentRow.Index;
            clientetxt.Text = declaracionFdgv[0, poc].Value.ToString();
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
                val_id.Visible = true;
                e.Handled = true;
                return;
            }
        }

        private void dgvdeclaracion_F_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = dgvdeclaracion_F.CurrentRow.Index;
            clientetxt.Text = dgvdeclaracion_F[0, poc].Value.ToString();
            fecha_In.Text = dgvdeclaracion_F[1, poc].Value.ToString();
            fecha_Fn.Text = dgvdeclaracion_F[2, poc].Value.ToString();
            declaracion.Text = dgvdeclaracion_F[3, poc].Value.ToString();
            seguros.Text = dgvdeclaracion_F[4, poc].Value.ToString();
            dospor.Text = dgvdeclaracion_F[5, poc].Value.ToString();
        }

        private void dgvdeclaracion_FX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = dgvdeclaracion_FX.CurrentRow.Index;
            clientetxt.Text = dgvdeclaracion_FX[0, poc].Value.ToString();
            fecha_In.Text = dgvdeclaracion_FX[1, poc].Value.ToString();
            fecha_Fn.Text = dgvdeclaracion_FX[2, poc].Value.ToString();
            declaracion.Text = dgvdeclaracion_FX[3, poc].Value.ToString();
            seguros.Text = dgvdeclaracion_FX[4, poc].Value.ToString();
            dospor.Text = dgvdeclaracion_FX[5, poc].Value.ToString();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            string texto = clientetxt.Text;

            if (Conexion.Minimo_validacion(texto, "MIN") == 1)
            {

            }
            else if (clientetxt.Text == "")
            {
                long_id.Visible = false;
            }
            else
            {
                long_id.Visible = true;
                clientetxt.SelectAll();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string texto = clientetxt.Text;
            val_id.Visible = false;

            if (Conexion.Minimo_validacion(texto, "MIN") == 1)
            {
                long_id.Visible = false;
            }
        }

        private void fecha_Fn_ValueChanged(object sender, EventArgs e)
        {
            if (fecha_Fn.Value > fecha_In.Value)
            {
                val_fecha.Visible = false;
            }
        }

        private void correobtn_Click(object sender, EventArgs e)
        {
            Correoform Cf = new Correoform();
            Cf.Show();
        }

        private void dgvdeclaracion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Correoform Cf = new Correoform();
            Cf.Show();
            poc = dgvdeclaracion.CurrentRow.Index;
            Cf.clienteCorreotxt.Text = dgvdeclaracion[0, poc].Value.ToString();
            Cf.correotxt.Text = con.correo_Dfx(Cf.correo_cl, Convert.ToInt32(Cf.clienteCorreotxt.Text));
            Cf.nombreCorreotxt.Text = con.correo_Dfy(Cf.correo_cl, Convert.ToInt32(Cf.clienteCorreotxt.Text), Cf.nombre_cl);
            Cf.asuntotxt.Text = "Declaración Fiscal";
            Cf.cuerpotxt.Text = "Buen día estimado o estimada " + con.correo_Dfy(Cf.correo_cl, Convert.ToInt32(Cf.clienteCorreotxt.Text), Cf.nombre_cl) + " con identificación " + dgvdeclaracion[0, poc].Value.ToString() + " este es un correo recordatorio ya que se acerca la fecha para hacer su declaración fiscal," +
                " a usted le toca el día " + dgvdeclaracion[3, poc].Value.ToString() + " por ello le recomendamos hacer el para antes de la fecha. Por su atención, Gracias";
        }
    }
}