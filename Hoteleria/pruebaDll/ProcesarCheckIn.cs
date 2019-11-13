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
        OdbcConnection connAux = new OdbcConnection("Dsn=navegador");
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
            codigo.CommandText = ("SELECT * FROM tbl_habitaciones WHERE KidNumeroHabitacion=" + noHabitacion);
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
            lb_fecha.Text = "Fecha: " + fecha.ToString("dd/MM/yyyy");
        }

        private void Button1_Click(object sender, EventArgs e)
        {            
            conn.Open();
            OdbcCommand codigo = new OdbcCommand();
            codigo.Connection = conn;                 
            codigo.CommandText = ("INSERT INTO `tbl_check_in`(`KidCliente`, `KidEmpleado`, `fecha`, `estado`) "
                + "VALUES (" + 1 + ", " + 1 + ", '" + fechaHoy + "', " + 1 + ")");
            try
            {                                               
                codigo.ExecuteNonQuery();
                try
                {
                    connAux.Open();
                    OdbcCommand codigoAux = new OdbcCommand();
                    codigoAux.Connection = connAux;                    
                    codigoAux.CommandText = ("UPDATE `tbl_habitaciones` SET `disponibilidad`=3 WHERE KidNumeroHabitacion=" + noHabitacion);                    
                    try
                    {
                        codigoAux.ExecuteNonQuery();
                        MessageBox.Show("Check In realizado correctamente! ");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(" Error al ejecutar UPDATE. \n\n Error: " + ex);
                    }
                    conn.Close();
                    HSC_CheckIn nuevo = new HSC_CheckIn(sIdUsuario);
                    this.Close();
                    nuevo.Show();
                    connAux.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" No se realizó el Check In. \n\n Error: " + ex);
                    connAux.Close();
                }                
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(" Error al hacer el INSERT. \n\n Error: " + ex.ToString());
                conn.Close();
            }            
        }

        private void ProcesarCheckIn_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            HSC_CheckIn nuevo = new HSC_CheckIn(sIdUsuario);
            this.Close();
            nuevo.Show();
        }
    }
}
