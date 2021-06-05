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

namespace Prototipo
{
    public partial class FirmaEform : Form
    {
        Conexion con = new Conexion();
        int poc;

        public FirmaEform()
        {
            InitializeComponent();
            (new Core.DropShadow()).ApplyShadows(this);
            con.alerta_Fe(dgvfirma_E);
            con.alerta_FeX(dgvfirma_EX);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FirmaE_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'firmaDS.firma_electronica' Puede moverla o quitarla según sea necesario.
         //   this.firma_electronicaTableAdapter.Fill(this.firmaDS.firma_electronica);
            // TODO: esta línea de código carga datos en la tabla 'firmaDS.firma_electronica' Puede moverla o quitarla según sea necesario.
            //    this.firma_electronicaTableAdapter2.Fill(this.firmaDS.firma_electronica);
            // TODO: esta línea de código carga datos en la tabla 'miguelitoDataSet9.firma_electronica' Puede moverla o quitarla según sea necesario.
            //    this.firma_electronicaTableAdapter1.Fill(this.miguelitoDataSet9.firma_electronica);
            // TODO: esta línea de código carga datos en la tabla 'miguelitoDataSet5.firma_electronica' Puede moverla o quitarla según sea necesario.
            //  this.firma_electronicaTableAdapter.Fill(this.miguelitoDataSet5.firma_electronica);
            // TODO: esta línea de código carga datos en la tabla 'miguelitoDataSet4.firma_electrónica' Puede moverla o quitarla según sea necesario.
            //this.firma_electrónicaTableAdapter2.Fill(this.miguelitoDataSet4.firma_electrónica);
            // TODO: esta línea de código carga datos en la tabla 'el_Pana_MiguelDataSet5.firma_electrónica' Puede moverla o quitarla según sea necesario.
            //this.firma_electrónicaTableAdapter1.Fill(this.el_Pana_MiguelDataSet5.firma_electrónica);
            // TODO: esta línea de código carga datos en la tabla 'el_Pana_MiguelDataSet1.firma_electrónica' Puede moverla o quitarla según sea necesario.
            //this.firma_electrónicaTableAdapter.Fill(this.el_Pana_MiguelDataSet1.firma_electrónica);
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
                    val_fecha.Visible = true;
                }
                else
                {
                    if (con.Registrado_Fe(Convert.ToInt32(clientetxt.Text)) == 0)
                    {
                        MessageBox.Show(con.Insertar_Fe(Convert.ToInt32(clientetxt.Text), this.fecha_In.Text, this.fecha_Fn.Text));
                        con.Cargar_Fe(firmaEdgv);
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
                    con.eliminar_Fe(Convert.ToInt32(clientetxt.Text));
                    con.Cargar_Fe(firmaEdgv);

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
                MessageBox.Show(con.actualizar_Fe(Convert.ToInt32(clientetxt.Text), fecha_In.Text, fecha_Fn.Text));
                con.Cargar_Fe(firmaEdgv);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = firmaEdgv.CurrentRow.Index;
            clientetxt.Text = firmaEdgv[0, poc].Value.ToString();
            fecha_In.Text = firmaEdgv[1, poc].Value.ToString();
            fecha_Fn.Text = firmaEdgv[2, poc].Value.ToString();
        }

        private void dgvfirma_E_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = dgvfirma_E.CurrentRow.Index;
            clientetxt.Text = dgvfirma_E[0, poc].Value.ToString();
            fecha_In.Text = dgvfirma_E[1, poc].Value.ToString();
            fecha_Fn.Text = dgvfirma_E[2, poc].Value.ToString();
        }

        private void dgvfirma_EX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = dgvfirma_EX.CurrentRow.Index;
            clientetxt.Text = dgvfirma_EX[0, poc].Value.ToString();
            fecha_In.Text = dgvfirma_EX[1, poc].Value.ToString();
            fecha_Fn.Text = dgvfirma_EX[2, poc].Value.ToString();
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

        private void clientetxt_Leave(object sender, EventArgs e)
        {
            string texto = clientetxt.Text;

            if (Conexion.Minimo_validacion(texto, "MIN") == 1)
            {

            }
            else
            {
                long_id.Visible = true;
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