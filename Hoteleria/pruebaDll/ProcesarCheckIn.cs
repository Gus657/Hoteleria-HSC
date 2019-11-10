using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;

namespace Hoteleria
{
    public partial class ProcesarCheckIn : Form
    {
        OdbcConnection conn = new OdbcConnection("Dsn=navegador");
        string sIdUsuario;
        string fechaHoy;
        int noHabitacion;        
        public ProcesarCheckIn(int no, string usuario)
        {
            InitializeComponent();
            sIdUsuario = usuario;
            gbox_habitacion.Text = "Detalles de la Habitación " + no;
            noHabitacion = no;
            llenarHabitacion();
            llenarComboCliente();
            llenarFecha();            
        }

        private void Lb_Habitacion_Click(object sender, EventArgs e)
        {

        }

        void llenarHabitacion()
        {
            conn.Open();
            OdbcCommand codigo = new OdbcCommand();
            codigo.Connection = conn;
            codigo.CommandText = ("SELECT * FROM tbl_habitaciones WHERE KidNumeroHabitacion=" + (noHabitacion + 100));
            try
            {                                
                OdbcDataReader resultadoSQL = codigo.ExecuteReader(CommandBehavior.CloseConnection);
                while (resultadoSQL.Read())
                {
                    lb_detalles.Text = "CÓDIGO:    \t\t" + resultadoSQL.GetString(0) + " \n" +
                        "TIPO:      \t\t" + resultadoSQL.GetString(1) + "\n" +
                        "CATEGORÍA: \t\t" + resultadoSQL.GetString(2) + "";
                    lb_precio.Text = "Precio: \t  Q" + resultadoSQL.GetString(3);
                }
                resultadoSQL.Close();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR" + e.ToString());
                conn.Close();
            }
        }

        void llenarComboCliente()
        {
            conn.Open();
            OdbcCommand codigo = new OdbcCommand();
            codigo.Connection = conn;
            codigo.CommandText = ("SELECT * FROM tbl_clientes");
            try
            {
                OdbcDataReader resultadoSQL = codigo.ExecuteReader(CommandBehavior.CloseConnection);
                while (resultadoSQL.Read())
                {
                    cb_clientes.Items.Add("" + resultadoSQL.GetString(0) + " - " + resultadoSQL.GetString(1) + " " +
                        resultadoSQL.GetString(2) + " - " + resultadoSQL.GetString(5));                    
                }
                resultadoSQL.Close();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR" + e.ToString());
                conn.Close();
            }
        }
        void llenarFecha()
        {
            DateTime fecha = DateTime.Today;
            fechaHoy = fecha.ToString("yyyy/MM/dd");
            lb_fecha.Text = "Fecha: " + fechaHoy;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //guardamos los datos ingresados
            int cod = Convert.ToInt32(txt_codigoCI.Text);
            conn.Open();
            OdbcCommand codigo = new OdbcCommand();
            codigo.Connection = conn;
            codigo.CommandText = ("INSERT INTO `tbl_check_in`(`KidCheckIn`, `KidCliente`, `KidEmpleado`, `fecha`, `estado`)"
                + "VALUES (" + cod + ", " + 7 + ", " + 1 + ", '" + fechaHoy + "', " + 1 + ")");
            try
            {                                               
                codigo.ExecuteNonQuery();


                MessageBox.Show("Check In realizado correctamente! ");               
                conn.Close();
                HSC_CheckIn nuevo = new HSC_CheckIn(sIdUsuario, noHabitacion, 3);
                this.Close();
                nuevo.Show();
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("ERROR" + ex.ToString());
                conn.Close();
            }            
        }

        private void ProcesarCheckIn_Load(object sender, EventArgs e)
        {

        }        
    }
}
