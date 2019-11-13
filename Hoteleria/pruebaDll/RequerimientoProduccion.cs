using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Hoteleria
{
    public partial class RequerimientoProduccion : Form
    {
        conexion conec = new conexion();
        OdbcConnection conc = new OdbcConnection("Dsn=HSC");
        string usuario = "";

        public RequerimientoProduccion(string user)
        {
            InitializeComponent();
            usuario = user;
            dtpSolicitud.Format = DateTimePickerFormat.Custom;
            dtpSolicitud.CustomFormat = "yyyy-MM-dd";
            llenartbl();
            llenarCombos();
        }
        public void ejecutarQuery(string query)// ejecuta un query en la BD
        {
            try
            {
                OdbcCommand consulta = new OdbcCommand(query, conec.probarConexion());
                consulta.ExecuteNonQuery();
            }
            catch (OdbcException ex) { Console.WriteLine(ex.ToString()); }

        }
        private void TableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {   

        }
        void llenarCombos()
        {
            //llenado de comboBox CLASIFICACION
            try
            {
                cmbPlatillo.Items.Clear();

                conc.Open();
                OdbcCommand command = new OdbcCommand("SELECT * FROM tbl_platillos", conc);
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbPlatillo.Refresh();
                    cmbPlatillo.Items.Add(reader.GetValue(0).ToString() + " - " + reader.GetValue(2).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conc.Close();
            try
            {
                cmbBebidas.Items.Clear();

                conc.Open();
                OdbcCommand command = new OdbcCommand("SELECT * FROM tbl_bebidas", conc);
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbBebidas.Refresh();
                    cmbBebidas.Items.Add(reader.GetValue(0).ToString() + " - " + reader.GetValue(2).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conc.Close();


            try
            {
                cmbPlatillo.Items.Clear();

                conc.Open();
                OdbcCommand command = new OdbcCommand("SELECT * FROM tbl_platillos", conc);
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbPlatillo.Refresh();
                    cmbPlatillo.Items.Add(reader.GetValue(0).ToString() + " - " + reader.GetValue(2).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conc.Close();
            try
            {
               

                conc.Open();
                OdbcCommand command = new OdbcCommand("SELECT KidEncabezado FROM tbl_produccion_encabezado", conc);
                OdbcDataReader reader = command.ExecuteReader();
              

                while (reader.Read())
                {
                    
                    string resul = reader.GetValue(0).ToString();

                    int resul2 = Convert.ToInt32(resul);

                     if (resul2 >= 1) {

                        resul2 = resul2 + 1;

                        string text = Convert.ToString(resul2);
                      lblnosoli.Text = text;


                                        }
                                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conc.Close();
           /* string cont2 = Convert.ToString(cont);
            lblnosoli.Text = cont2;*/
           
        }
        void llenartbl() {
       
            OdbcCommand cod = new OdbcCommand();
            cod.Connection = conc;
            cod.CommandText = ("SELECT A.nombre, A.fecha, A.concepto, B.cantidad, C.nombrePlatillo, D.nombreBebida FROM tbl_produccion_encabezado as A, tbl_produccion_detalle as B, tbl_platillos as C, tbl_bebidas as D  WHERE A.estado = 1 AND B.estado=1 AND A.KidEncabezado = B.KidEncabezado AND B.KidPlatillo = C.KidPlatillo AND B.KidBebida = D.KidBebida;  ");
            try
            {
                OdbcDataAdapter eje = new OdbcDataAdapter();
                eje.SelectCommand = cod;
                DataTable datos = new DataTable();
                eje.Fill(datos);
                datosProduccion.DataSource = datos;
                eje.Update(datos);
                conc.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR" + e.ToString());
                conc.Close();
            }



        }

        private void Button1_Click(object sender, EventArgs e)
        {

               

            string insertarSoli = "INSERT INTO tbl_produccion_encabezado (nombre,  fecha, concepto) VALUES ('" + txtNombre.Text
               + "','" + dtpSolicitud.Text + "','" + txtConcepto.Text + "')";
            
            string insertardet = "INSERT INTO tbl_produccion_detalle (Kidplatillo, KidBebida, kidEncabezado, cantidad) VALUES ('" + cmbPlatillo.Text[0]
               + "','" + cmbBebidas.Text[0] + "','" + lblnosoli.Text +"','" + txtCantidad.Text + "')";



            ejecutarQuery(insertarSoli);

            ejecutarQuery(insertardet);


            txtCantidad.Clear();
            txtConcepto.Clear();
            txtNombre.Clear();
                cmbBebidas.Text = "";
                cmbPlatillo.Text = "";
                llenartbl();
                llenarCombos();
                
            
       
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
    }
}
