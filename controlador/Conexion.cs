using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.IO;
//---------------Flyweight----------------

//----------------Memento-----------------
namespace Prototipo
{ 
    class Conexion
    {
        private static int verificador_vacio = 6;
        private static int stop = 0;
        private static int min_pass = 0;

        //--------------Validaciones----------------
        #region validaciones
        public static int Verificador_vacio
        {
            get
            {
                return verificador_vacio;
            }
            set
            {
                verificador_vacio = value;
            }
        }

        public static int Stop
        {
            get
            {
                return stop;
            }
            set
            {
                stop = value;
            }
        }

        public void VerificarVacio(string texto, string completar, int textbox_actual)
        {
            if (verificador_vacio == 0)
            {
                if (textbox_actual == stop)
                {
                    MessageBox.Show("Debe ingresar el " + completar);
                }
                else
                {
                    verificador_vacio = 0;
                }
            }
            else
            {
                if (texto == "")
                {
                    MessageBox.Show("Debe ingresar el " + completar);

                    stop = textbox_actual;

                    verificador_vacio = 0;
                }
                else
                {
                    verificador_vacio = 1;
                }
            }
        }

        public static int Minimo_validacion(string texto, string tipo)
        {
            string RFC = "^([A-Z\\s]{4})\\d{6}([A-Z\\w]{3})$|^([A-Z\\s]{4})\\d{6}([A-Z\\w]{2})\\d$|^([A-Z\\s]{4})\\d{7}([A-Z\\w]{2})$|^([A-Z\\s]{4})\\d{7}([A-Z\\w]{1})$";
            string CURP = "^([A-Z][AEIOUX][A-Z]{2}\\d{2}(?:0[1-9]|1[0-2])(?:0[1-9]|[12]\\d|3[01])[HM](?:AS|B[CS]|C[CLMSH]|D[FG]|G[TR]|HG|JC|M[CNS]|N[ETL]|OC|PL|Q[TR]|S[PLR]|T[CSL]|VZ|YN|ZS)[B-DF-HJ-NP-TV-Z]{3}[A-Z\\d])(\\d)$";
            string MIN = "^.{8,50}$";
            string Telefono = "^.{10,10}$";
            string Correo = "^(([\\w-]+\\.)+[\\w-]+|([a-zA-Z]{1}|[\\w-]{2,}))@(([a-zA-Z]+[\\w-]+\\.){1,2}[a-zA-Z]{2,4})$";

            if (tipo == "Correo")
            {
                if (Regex.IsMatch(texto, Correo))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else if (tipo == "RFC")
            {
                if (Regex.IsMatch(texto, RFC))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else if (tipo == "Telefono")
            {
                if (Regex.IsMatch(texto, Telefono))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else if(tipo == "MIN")
            {
                if (Regex.IsMatch(texto, MIN))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else if(tipo == "CURP")
            {
                if (Regex.IsMatch(texto, CURP))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
        #endregion

        //--------------Adapter---------------
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;

        public Conexion()
        {
            try
            {
                con = new SqlConnection(@"Data Source=25.106.128.31;Initial Catalog=miguelito;Persist Security Info=True;User ID=sa;Password=123");
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto" + ex.ToString());
            }
        }

        public Conexion(Conexion @object)
        {
        }

        public void DataSetsToExcel(List<DataGridView> dataSets, string fileName)
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

        public void ExportarDataGridViewExcel(DataGridView grd_cliente)
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

        //----------------Abstract Factory-----------------
        //---------------Decorator------------
        //-------------Builder-------------
        #region clientes
        /*-------------------------------------clientes------------------------------------------------------------------*/

        public string Insertar_Cl(int id_clientes, string nombre_cl, string domicilio_cl, string telefono_cl, string correo_cl, string RFC, string curp)
        {
            string salida = "Se agrego correctamente";
            try
            {
                cmd = new SqlCommand("Insert Into clientes(id_clientes,nombre_cl,domicilio_cl,telefono_cl,correo_cl,RFC,curp) values(" + id_clientes + ",'" + nombre_cl + "','" + domicilio_cl + "','" + telefono_cl + "','" + correo_cl + "','" + RFC + "','" + curp + "')", con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "no se agrego nada" + ex.ToString();
            }
            return salida;
        }

        public int Registrado_cl(int id_clientes)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from clientes where id_clientes=" + id_clientes + "", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar" + ex.ToString());
            }
            return contador;
        }

        public void Cargar_Cl(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from clientes", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar" + ex.ToString());
            }
        }

        public void eliminar_Cl(int id_clientes)
        {
            try
            {
                cmd = new SqlCommand("Delete from clientes where id_clientes=" + id_clientes + "", con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede eliminar");
            }
        }

        public void llenar_Cl(int id_clientes, TextBox nombre_cl, TextBox domicilio_cl, TextBox telefono_cl, TextBox correo_cl, TextBox RFC, TextBox curp)
        {
            try
            {
                cmd = new SqlCommand("Select * from clientes where id_clientes=" + id_clientes + "", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    nombre_cl.Text = dr["nombre_cl"].ToString();
                    domicilio_cl.Text = dr["domicilio_cl"].ToString();
                    telefono_cl.Text = dr["telefono_cl"].ToString();
                    correo_cl.Text = dr["correo_cl"].ToString();
                    RFC.Text = dr["RFC"].ToString();
                    curp.Text = dr["curp"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos:" + ex.ToString());
            }
        }

        public string actualizar_Cl(int id_clientes, string nombre_cl, string domicilio_cl, string telefono_cl, string correo_cl, string RFC, string curp)
        {
            string salida = "Se actualizo el registro";
            try
            {
                cmd = new SqlCommand("update clientes SET nombre_cl='" + nombre_cl + "' , domicilio_cl='" + domicilio_cl + "' , telefono_cl='" + telefono_cl + "', correo_cl= '" + correo_cl + "', RFC= '" + RFC + "', curp= '" + curp + "' where id_clientes=" + id_clientes + "", con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se Modifico el registro: " + ex.ToString();

            }
            return salida;
        }

        public void Modificar_Cl(int id, string txtnombre_cl, string txtdomicilio_cl, string txttelefono_cl, string txtcorreo_cl, string txtRFC, string txtcurp)
        {
            try
            {
                cmd = new SqlCommand("Select * from clientes where id_clientes=" + id + "", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtnombre_cl = dr["nombre_cl"].ToString();
                    txtdomicilio_cl = dr["domicilio_cl"].ToString();
                    txttelefono_cl = dr["telefono_cl"].ToString();
                    txtcorreo_cl = dr["correo_cl"].ToString();
                    txtRFC = dr["RFC"].ToString();
                    txtcurp = dr["curp"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo modificar" + ex.ToString());
            }
        }
        #endregion
        #region firma electronica
        /*-------------------------------------firma electronica------------------------------------------------------------------*/

        public string Insertar_Fe(int id_clientes, string fecha_in, string fecha_fn)
        {
            string salida = "Se agrego correctamente";
            try
            {
                cmd = new SqlCommand("Insert Into firma_electronica(id_clientes,fecha_in,fecha_fn) values(" + id_clientes + ",'" + fecha_in + "','" + fecha_fn + "')", con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                salida = "no se agrego nada";
            }
            return salida;
        }

        public int Registrado_Fe(int id_clientes)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from firma_electronica where id_clientes=" + id_clientes + "", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar" + ex.ToString());
            }
            return contador;
        }

        public void Cargar_Fe(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from firma_electronica", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar" + ex.ToString());
            }
        }

        public void eliminar_Fe(int id_clientes)
        {
            try
            {
                cmd = new SqlCommand("Delete from firma_electronica where id_clientes=" + id_clientes + "", con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede eliminar" + ex.ToString());
            }
        }

        public string actualizar_Fe(int id_clientes, string fecha_in, string fecha_fn)
        {
            string salida = "Se actualizo el registro";
            try
            {
                cmd = new SqlCommand("update firma_electronica SET fecha_in='" + fecha_in + "' , fecha_fn='" + fecha_fn + "' where id_clientes=" + id_clientes + "", con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se Modifico el registro: " + ex.ToString();
            }
            return salida;
        }

        public void alerta_Fe(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from firma_electronica where DATEDIFF(day, GetDate(), fecha_fn) <= 1", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se encontro fecha proxima" + ex.ToString());
            }
        }

        public void alerta_FeX(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from firma_electronica where DATEDIFF(day, GetDate(), fecha_fn) >= 1", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se encontro fecha proxima" + ex.ToString());
            }
        }

        public int noty_Fe(int id_clientes)
        {
            int id = 0;
            try
            {
                cmd = new SqlCommand("Select id_clientes from firma_electronica where DATEDIFF(day, GetDate(), fecha_fn) >= 1", con);
                id = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar" + ex.ToString());
            }
            return id;
        }

        #endregion
        #region sello digital
        /*-------------------------------------sello digital------------------------------------------------------------------*/

        public string Insertar_Sd(int id_clientes, string fecha_in, string fecha_fn)
        {
            string salida = "Se agrego correctamente";
            try
            {
                cmd = new SqlCommand("Insert Into sello_digital(id_clientes,fecha_in,fecha_fn) values(" + id_clientes + ",'" + fecha_in + "','" + fecha_fn + "')", con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                salida = "no se agrego nada";
            }
            return salida;
        }

        public int Registrado_Sd(int id)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from sello_digital where id_clientes=" + id + "", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar" + ex.ToString());
            }
            return contador;
        }

        public void Cargar_Sd(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from sello_digital", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar" + ex.ToString());
            }
        }

        public string actualizar_Sd(int id_clientes, string fecha_in, string fecha_fn)
        {
            string salida = "Se actualizo el registro";
            try
            {
                cmd = new SqlCommand("update sello_digital SET fecha_in='" + fecha_in + "' , fecha_fn='" + fecha_fn + "' where id_clientes=" + id_clientes + "", con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se Modifico el registro: " + ex.ToString();

            }
            return salida;
        }

        public void eliminar_Sd(int id_clientes)
        {
            try
            {
                cmd = new SqlCommand("Delete from sello_digital where id_clientes=" + id_clientes + "", con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede eliminar" + ex.ToString());
            }
        }

        public void alerta_Sd(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from sello_digital where DATEDIFF(day, GetDate(), fecha_fn) >= 1", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se encontro fecha proxima" + ex.ToString());
            }
        }

        public void alerta_SdX(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from sello_digital where DATEDIFF(day, GetDate(), fecha_fn) <= 1", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se encontro fecha proxima" + ex.ToString());
            }
        }

        public int noty_Sd(int id_clientes)
        {
            int id = 0;
            try
            {
                cmd = new SqlCommand("Select id_clientes from sello_digital where DATEDIFF(day, GetDate(), fecha_fn) >= 1", con);
                id = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar" + ex.ToString());
            }
            return id;
        }
        #endregion
        #region seguro social
        /*-------------------------------------seguro social------------------------------------------------------------------*/

        public string Insertar_Ss(int id_clientes, string fecha_in, string fecha_fn)
        {
            string salida = "Se agrego correctamente";
            try
            {
                cmd = new SqlCommand("Insert Into seguro_social(id_clientes,fecha_in,fecha_fn) values(" + id_clientes + ",'" + fecha_in + "','" + fecha_fn + "')", con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                salida = "no se agrego nada";
            }
            return salida;
        }

        public int Registrado_Ss(int id)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from seguro_social where id_clientes=" + id + "", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar" + ex.ToString());
            }
            return contador;
        }

        public void Cargar_Ss(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from seguro_social", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar" + ex.ToString());
            }
        }

        public string actualizar_Ss(int id_clientes, string fecha_in, string fecha_fn)
        {
            string salida = "Se actualizo el registro";
            try
            {
                cmd = new SqlCommand("update seguro_social SET fecha_in='" + fecha_in + "' , fecha_fn='" + fecha_fn + "' where id_clientes=" + id_clientes + "", con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se Modifico el registro: " + ex.ToString();

            }
            return salida;
        }

        public void eliminar_Ss(int id_clientes)
        {
            try
            {
                cmd = new SqlCommand("Delete from seguro_social where id_clientes=" + id_clientes + "", con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede eliminar" + ex.ToString());
            }
        }

        public void alerta_Ss(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from seguro_social where DATEDIFF(day, GetDate(), fecha_fn) >= 1", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se encontro fecha proxima" + ex.ToString());
            }
        }

        public void alerta_SsX(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from seguro_social where DATEDIFF(day, GetDate(), fecha_fn) <= 1", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se encontro fecha proxima" + ex.ToString());
            }
        }

        public int noty_Ss(int id_clientes)
        {
            int id = 0;
            try
            {
                cmd = new SqlCommand("Select id_clientes from seguro_social where DATEDIFF(day, GetDate(), fecha_fn) >= 1", con);
                id = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar" + ex.ToString());
            }
            return id;
        }
        #endregion
        #region declaracion fiscal
        /*-------------------------------------declaracion fiscal------------------------------------------------------------------*/

        public string Insertar_Df(int id_clientes, string fecha_in, string fecha_fn, string declaracion_f, string seguro_s, string dos_p)
        {
            string salida = "Se agrego correctamente";
            try
            {
                cmd = new SqlCommand("Insert Into declaracion_fiscal(id_clientes,fecha_in,fecha_fn,declaracion_f,seguro_s,dos_p) values(" + id_clientes + ",'" + fecha_in + "','" + fecha_fn + "','" + declaracion_f + "','" + seguro_s + "','" + dos_p + "')", con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                salida = "no se agrego nada";
            }
            return salida;
        }

        public int Registrado_Df(int id)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from declaracion_fiscal where id_clientes=" + id + "", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar" + ex.ToString());
            }
            return contador;
        }

        public void Cargar_Df(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from declaracion_fiscal", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar" + ex.ToString());
            }
        }

        public void eliminar_Df(int id_clientes)
        {
            try
            {
                cmd = new SqlCommand("Delete from declaracion_fiscal where id_clientes=" + id_clientes + "", con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede eliminar" + ex.ToString());
            }
        }

        public string actualizar_Df(int id_clientes, string fecha_in, string fecha_fn, string declaracion_f, string seguro_s, string dos_p)
        {
            string salida = "Se actualizo el registro";
            try
            {
                cmd = new SqlCommand("update declaracion_fiscal SET fecha_in='" + fecha_in + "' , fecha_fn='" + fecha_fn + "' , declaracion_f='" + declaracion_f + "' , seguro_s='" + seguro_s + "' , dos_p='" + dos_p + "' where id_clientes=" + id_clientes + "", con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se Modifico el registro: " + ex.ToString();

            }
            return salida;
        }

        public void alerta_Df(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from declaracion_fiscal where DATEDIFF(day, GetDate(), fecha_fn) <= 1", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se encontro fecha proxima" + ex.ToString());
            }
        }

        public void alerta_DfX(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from declaracion_fiscal where DATEDIFF(day, GetDate(), fecha_fn) >= 1", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se encontro fecha proxima" + ex.ToString());
            }
        }

        public void correo_Df(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from declaracion_fiscal where DATEDIFF(day, GetDate(), declaracion_f) >= 1", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se encontro fecha proxima" + ex.ToString());
            }
        }

        public string correo_Dfx(string correo_cl, int id_clientes)
        {
            try
            {
                cmd = new SqlCommand("Select correo_cl from clientes where id_clientes =" + id_clientes +"", con);
                correo_cl = Convert.ToString(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar xd" + ex.ToString());
            }
            return correo_cl;
        }

        public string correo_Dfy(string correo_cl, int id_clientes, string nombre_cl)
        {
            try
            {
                cmd = new SqlCommand("Select nombre_cl from clientes where id_clientes =" + id_clientes + "", con);
                nombre_cl = Convert.ToString(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar xd" + ex.ToString());
            }
            return nombre_cl;
        }

        public int noty_Df(int id_clientes)
        {
            int id = 0;
            try
            {
                cmd = new SqlCommand("Select id_clientes from declaracion_fiscal where DATEDIFF(day, GetDate(), fecha_fn) >= 1", con);
                id = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar" + ex.ToString());
            }
            return id;
        }
    }
    #endregion
}