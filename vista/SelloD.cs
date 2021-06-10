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
    public partial class SelloD : Form
    {

        Conexion con = new Conexion();
        int poc;

        public SelloD()
        {
            InitializeComponent();
            (new Core.DropShadow()).ApplyShadows(this);
            con.alerta_Sd(dgvseguro_D);
            con.alerta_SdX(dgvseguro_DX);
        }

        private void cerrarbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelloD_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'selloDataSet.sello_digital' Puede moverla o quitarla según sea necesario.
            this.sello_digitalTableAdapter1.Fill(this.selloDataSet.sello_digital);
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
                    if (con.Registrado_Fe(Convert.ToInt32(clientetxt.Text)) == 0)
                    {
                        MessageBox.Show(con.Insertar_Sd(Convert.ToInt32(clientetxt.Text), this.fecha_In.Text, this.fecha_Fn.Text));
                        con.Cargar_Sd(SelloDdgv);
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
            if (clientetxt.Text == "")
            {
                MessageBox.Show("Introduzca el id del cliente");
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Seguro que quieres eliminar este cliente?", "eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    con.eliminar_Sd(Convert.ToInt32(clientetxt.Text));
                    con.Cargar_Sd(SelloDdgv);

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
                MessageBox.Show(con.actualizar_Sd(Convert.ToInt32(clientetxt.Text), fecha_In.Text, fecha_Fn.Text));
                con.Cargar_Sd(SelloDdgv);
            }
        }

        private void SelloDdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = SelloDdgv.CurrentRow.Index;
            clientetxt.Text = SelloDdgv[0, poc].Value.ToString();
            fecha_In.Text = SelloDdgv[1, poc].Value.ToString();
            fecha_Fn.Text = SelloDdgv[2, poc].Value.ToString();
        }

        private void dgvseguro_D_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = dgvseguro_D.CurrentRow.Index;
            clientetxt.Text = dgvseguro_D[0, poc].Value.ToString();
            fecha_In.Text = dgvseguro_D[1, poc].Value.ToString();
            fecha_Fn.Text = dgvseguro_D[2, poc].Value.ToString();
        }

        private void dgvseguro_DX_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            poc = dgvseguro_DX.CurrentRow.Index;
            clientetxt.Text = dgvseguro_DX[0, poc].Value.ToString();
            fecha_In.Text = dgvseguro_DX[1, poc].Value.ToString();
            fecha_Fn.Text = dgvseguro_DX[2, poc].Value.ToString();
        }

        private void clientetxt_Leave(object sender, EventArgs e)
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

        private void clientetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                val_id.Visible = true;
                e.Handled = true;
                return;
            }
        }

        private void clientetxt_TextChanged(object sender, EventArgs e)
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
    }
}