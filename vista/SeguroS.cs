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
    public partial class SeguroSform : Form
    {
        Conexion con = new Conexion();
        int poc;

        public SeguroSform()
        {
            InitializeComponent();
            (new Core.DropShadow()).ApplyShadows(this);
            con.alerta_Ss(dgvsguro_S);
            con.alerta_SsX(dgvsguro_SX);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SeguroS_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'seguroDS.seguro_social' Puede moverla o quitarla según sea necesario.
            this.seguro_socialTableAdapter.Fill(this.seguroDS.seguro_social);
            // TODO: esta línea de código carga datos en la tabla 'seguroDS.seguro_social' Puede moverla o quitarla según sea necesario.
            //    this.seguro_socialTableAdapter3.Fill(this.seguroDS.seguro_social);
            // TODO: esta línea de código carga datos en la tabla 'miguelitoDataSet7.seguro_social' Puede moverla o quitarla según sea necesario.
            //    this.seguro_socialTableAdapter2.Fill(this.miguelitoDataSet7.seguro_social);
            // TODO: esta línea de código carga datos en la tabla 'miguelitoDataSet3.seguro_social' Puede moverla o quitarla según sea necesario.
            // this.seguro_socialTableAdapter1.Fill(this.miguelitoDataSet3.seguro_social);
            // TODO: esta línea de código carga datos en la tabla 'el_Pana_MiguelDataSet3.seguro_social' Puede moverla o quitarla según sea necesario.
            // this.seguro_socialTableAdapter.Fill(this.el_Pana_MiguelDataSet3.seguro_social);

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
                        MessageBox.Show(con.Insertar_Ss(Convert.ToInt32(clientetxt.Text), this.fecha_In.Text, this.fecha_Fn.Text));
                        con.Cargar_Ss(seguroSdgv);
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
                    con.eliminar_Ss(Convert.ToInt32(clientetxt.Text));
                    con.Cargar_Ss(seguroSdgv);

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
                MessageBox.Show(con.actualizar_Ss(Convert.ToInt32(clientetxt.Text), fecha_In.Text, fecha_Fn.Text));
                con.Cargar_Ss(seguroSdgv);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = seguroSdgv.CurrentRow.Index;
            clientetxt.Text = seguroSdgv[0, poc].Value.ToString();
            fecha_In.Text = seguroSdgv[1, poc].Value.ToString();
            fecha_Fn.Text = seguroSdgv[2, poc].Value.ToString();
        }

        private void dgvsguro_S_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = dgvsguro_S.CurrentRow.Index;
            clientetxt.Text = dgvsguro_S[0, poc].Value.ToString();
            fecha_In.Text = dgvsguro_S[1, poc].Value.ToString();
            fecha_Fn.Text = dgvsguro_S[2, poc].Value.ToString();
        }

        private void dgvsguro_SX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = dgvsguro_SX.CurrentRow.Index;
            clientetxt.Text = dgvsguro_SX[0, poc].Value.ToString();
            fecha_In.Text = dgvsguro_SX[1, poc].Value.ToString();
            fecha_Fn.Text = dgvsguro_SX[2, poc].Value.ToString();
        }

        private void clientetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan numeros");
                e.Handled = true;
                return;
            }
        }

        private void clientetxt_Leave(object sender, EventArgs e)
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
    }
}