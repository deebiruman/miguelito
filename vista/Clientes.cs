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
            if (moralrbtn.Checked)
            {
                curptxt.Hide();
                curplbl.Hide();
                val_curp.Hide();

                rfctxt.MaxLength = 12;
                rfctxt.Show();
                rfclbl.Show();

                curptxt.Enabled = false;
                curplbl.Enabled = false;

                curptxt.Clear();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (fisicarbtn.Checked)
            {
                rfctxt.MaxLength = 13;
                rfctxt.Show();
                rfclbl.Show();
                curptxt.Show();
                curplbl.Show();

                curptxt.Enabled = true;
                curplbl.Enabled = true;
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clientesDataSet.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter1.Fill(this.clientesDataSet.clientes);
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
                val_id.Visible = true;
                e.Handled = true;
                return;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                val_tel.Visible = true;
                e.Handled = true;
                return;
            }
        }

        //------------------Factory Method-------------------
        //------------------Template Method------------------
        public void exportarexcel(DataGridView tabla)
        {
            con.ExportarDataGridViewExcel(clientesdgv); void DataSetsToExcel(List<DataGridView> dataSets, string fileName)
            {
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                Microsoft.Office.Interop.Excel.Sheets xlSheets = null;
                Microsoft.Office.Interop.Excel.Worksheet xlWorksheet = null;

                foreach (DataGridView dataSet in dataSets)
                {
                    //System.Data.DataGrid dataTable = dataSet.Tables[0];
                    int rowNo = dataSet.RowCount;
                    int columnNo = dataSet.ColumnCount;

                    int contadorFinal = 0;

                    int i = 0;
                    int j = 0;
                    int startrow = 2;
                    int startcolumn = 2;

                    //Create Excel Sheets
                    xlSheets = xlWorkbook.Sheets;
                    xlWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)xlSheets.Add(xlSheets[1], Type.Missing, Type.Missing, Type.Missing);
                    xlWorksheet.Name = dataSet.Name;

                    //Titulos
                    xlApp.Range["A1"].Value = "ID Cliente";
                    xlApp.ActiveCell.Offset[1, 0].Select();

                    xlApp.Range["B1"].Value = "Nombre cliente";
                    xlApp.ActiveCell.Offset[1, 0].Select();

                    xlApp.Range["C1"].Value = "Telefono";
                    xlApp.ActiveCell.Offset[1, 0].Select();

                    xlApp.Range["D1"].Value = "Domicilio";
                    xlApp.ActiveCell.Offset[1, 0].Select();

                    xlApp.Range["E1"].Value = "Correo electrónico";
                    xlApp.ActiveCell.Offset[1, 0].Select();

                    xlApp.Range["F1"].Value = "RFC";
                    xlApp.ActiveCell.Offset[1, 0].Select();

                    xlApp.Range["G1"].Value = "CURP";
                    xlApp.ActiveCell.Offset[1, 0].Select();

                    for (j = 0; j < dataSet.Columns.Count; j++)
                    {
                        try
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[startrow, startcolumn + j];
                            myRange.Value2 = dataSet.Columns[j].HeaderText;
                        }
                        catch
                        {
                            ;
                        }
                    }

                    //Write datagridview content
                    int indicefila = 1;
                    int indicecolumna = 1;

                    foreach (DataGridViewRow row in dataSet.Rows)
                    {
                        indicefila++;
                        indicecolumna = 0;

                        foreach (DataGridViewColumn col in dataSet.Columns)
                        {
                            indicecolumna++;

                            xlWorksheet.Cells[indicefila + 1, indicecolumna] = row.Cells[col.Name].Value;

                            xlWorksheet.Columns.AutoFit();
                            xlWorksheet.Rows.AutoFit();

                            contadorFinal += 1;
                        }
                    }

                    xlApp.Range["A2"].Delete();
                    xlApp.Range["B2"].Delete();
                    xlApp.Range["C2"].Delete();
                    xlApp.Range["D2"].Delete();
                    xlApp.Range["E2"].Delete();
                    xlApp.Range["F2"].Delete();
                    xlApp.Range["G2"].Delete();
                    xlApp.Range["H2"].Delete();

                    xlWorksheet.Range["A1:G" + contadorFinal].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                }


     //Remove the Default Worksheet
     ((Microsoft.Office.Interop.Excel.Worksheet)xlApp.ActiveWorkbook.Sheets[xlApp.ActiveWorkbook.Sheets.Count]).Delete();


                xlWorkbook.SaveAs(fileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);

                xlWorkbook.Close();
                xlApp.Quit();
                GC.Collect();
            }
             void ExportarDataGridViewExcel(DataGridView grd_cliente)
             {
                string nombrearchivo;

                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";

                 if (fichero.ShowDialog() == DialogResult.OK)
                 {
                     List<DataGridView> dataSets = new List<DataGridView>();
                     dataSets.Add(grd_cliente);

                     nombrearchivo = fichero.FileName;
                     DataSetsToExcel(dataSets, nombrearchivo);
                 }
             }
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

            if (Conexion.Minimo_validacion(texto, tipo) == 1)
            {
                correotxt.Text = "";

            }
            else if (correotxt.Text == "")
            {
                val_correo.Visible = false;
            }
            else
            {
                val_correo.Visible = true;
                correotxt.SelectAll();
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            string texto = rfctxt.Text;
            string tipo = "RFC";

            if (Conexion.Minimo_validacion(texto, tipo) == 1)
            {

            }
            else if (rfctxt.Text == "")
            {
                val_rfc.Visible = false;
            }
            else
            {
                val_rfc.Visible = true;
                rfctxt.SelectAll();
            }
        }

        private void textBox7_Leave_1(object sender, EventArgs e)
        {
            string texto = curptxt.Text;

            if (Conexion.Minimo_validacion(texto, "CURP") == 1)
            {

            }
            else if (curptxt.Text == "")
            {
                val_curp.Visible = false;
            }
            else
            {
                val_curp.Visible = true;
                curptxt.SelectAll();
            }
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

        private void textBox2_Leave(object sender, EventArgs e)
        {
            string texto = nombretxt.Text;

            if (Conexion.Minimo_validacion(texto, "MIN") == 1)
            {

            }
            else if (nombretxt.Text == "")
            {
                long_nom.Visible = false;
            }
            else
            {
                long_nom.Visible = true;
                nombretxt.SelectAll();
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            string texto = domitxt.Text;

            if (Conexion.Minimo_validacion(texto, "MIN") == 1)
            {

            }
            else if (domitxt.Text == "")
            {
                long_dom.Visible = false;
            }
            else
            {
                long_dom.Visible = true;
                domitxt.SelectAll();
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            string texto = teletxt.Text;

            if (Conexion.Minimo_validacion(texto, "Telefono") == 1)
            {

            }
            else if (teletxt.Text == "")
            {
                val_tel.Visible = false;
            }
            else
            {
                val_tel.Visible = true;
                teletxt.SelectAll();
            }
        }

        private void clientetxt_TextChanged(object sender, EventArgs e)
        {
            string texto = clientetxt.Text;
            val_id.Visible = false;
            ClearAll.Show();

            if (Conexion.Minimo_validacion(texto, "MIN") == 1)
            {
                long_id.Visible = false;
            }
        }

        private void nombretxt_TextChanged(object sender, EventArgs e)
        {
            string texto = nombretxt.Text;
            ClearAll.Show();


            if (Conexion.Minimo_validacion(texto, "MIN") == 1)
            {
                long_nom.Visible = false;
            }
        }

        private void domitxt_TextChanged(object sender, EventArgs e)
        {
            string texto = domitxt.Text;
            ClearAll.Show();

            if (Conexion.Minimo_validacion(texto, "MIN") == 1)
            {
                long_dom.Visible = false;
            }
        }

        private void teletxt_TextChanged(object sender, EventArgs e)
        {
            string texto = teletxt.Text;
            val_tel.Visible = false;
            ClearAll.Show();

            if (Conexion.Minimo_validacion(texto, "Telefono") == 1)
            {
                val_tel.Visible = false;
            }
        }

        private void correotxt_TextChanged(object sender, EventArgs e)
        {
            string texto = correotxt.Text;
            string tipo = "Correo";
            ClearAll.Show();

            if (Conexion.Minimo_validacion(texto, tipo) == 1)
            {
                val_correo.Visible = false;
            }
        }

        private void rfctxt_TextChanged(object sender, EventArgs e)
        {
            string texto = rfctxt.Text;
            string tipo = "RFC";
            ClearAll.Show();

            if (Conexion.Minimo_validacion(texto, tipo) == 1)
            {
                val_rfc.Visible = false;
            }
        }

        private void curptxt_TextChanged(object sender, EventArgs e)
        {
            string texto = curptxt.Text;
            ClearAll.Show();

            if (Conexion.Minimo_validacion(texto, "CURP") == 1)
            {
                val_curp.Visible = false;
            }
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            clientetxt.Enabled = true;

            clientetxt.Text = "";
            nombretxt.Text = "";
            domitxt.Text = "";
            teletxt.Text = "";
            correotxt.Text = "";
            rfctxt.Text = "";
            curptxt.Text = "";

            val_correo.Visible = false;
            val_curp.Visible = false;
            val_id.Visible = false;
            val_rfc.Visible = false;
            val_tel.Visible = false;
            long_dom.Visible = false;
            long_id.Visible = false;
            long_nom.Visible = false;

            ClearAll.Hide();
        }
    }
}