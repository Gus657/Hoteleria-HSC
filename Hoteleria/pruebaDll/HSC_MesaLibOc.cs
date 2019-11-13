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
    public partial class HSC_MesaLibOc : Form
    {
        OdbcConnection conn = new OdbcConnection("Dsn=HSC");
        OdbcConnection connAux = new OdbcConnection("Dsn=HSC");
        string sIdUsuario;        
        char Area;
        int noMesa;
        string area;
        public HSC_MesaLibOc(int no, string usuario, char ar, string are)
        {
            InitializeComponent();
            sIdUsuario = usuario;
            gbox_habitacion.Text = "Detalles de la Mesa " + no;
            noMesa = no;
            Area = ar;
            area = are;
            llenarHabitacion();
           
            llenarFecha();
        }


        void llenarHabitacion()
        {
            conn.Open();
            OdbcCommand codigo = new OdbcCommand();
            codigo.Connection = conn;
            codigo.CommandText = ("SELECT * FROM tbl_mesas WHERE KidNumeroMesa=" + noMesa + " AND KidArea= " + Area);
            try
            {
                OdbcDataReader resultadoSQL = codigo.ExecuteReader(CommandBehavior.CloseConnection);
                while (resultadoSQL.Read())
                {
                    string op = resultadoSQL.GetValue(3).ToString();
                    switch (op) {

                        case "1":
                            lb_detalles.Text = "Numero Mesa:    \t\t" + resultadoSQL.GetValue(0).ToString() + " \n" +
                                                      "Area:      \t\t" + area + "\n" +
                                                      "Capacidad: \t\t" + resultadoSQL.GetValue(2).ToString() + "\n" +
                                                      "Disponible";
                            break;
                        case "2":
                            lb_detalles.Text = "Numero Mesa:    \t\t" + resultadoSQL.GetValue(0).ToString() + " \n" +
                                                      "Area:      \t\t" + area + "\n" +
                                                      "Capacidad: \t\t" + resultadoSQL.GetValue(2).ToString() + "\n" +
                                                      "Mantenimiento";
                            break;
                        case "3":

                            lb_detalles.Text = "Numero Mesa:    \t\t" + resultadoSQL.GetValue(0).ToString() + " \n" +
                                                    "Area:      \t\t" + area + "\n" +
                                                    "Capacidad: \t\t" + resultadoSQL.GetValue(2).ToString() + "\n" +
                                                    "Ocupado";
                            break;


                    }



                }
                   resultadoSQL.Close();

                    }        

                    catch (Exception e)
                    {
                        MessageBox.Show("ERROR" + e.ToString());
                        conn.Close();
                    }


        
                conn.Close();
            }
    

        void llenarFecha()
        {

            lb_fecha.Text = area;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        
                try
                {
                    connAux.Open();
                    OdbcCommand codigoAux = new OdbcCommand();
                    codigoAux.Connection = connAux;
                    codigoAux.CommandText = ("UPDATE `tbl_mesas` SET `estadoMesa`=3 WHERE KidNumeroMesa=" + noMesa);
                    try
                    {
                        codigoAux.ExecuteNonQuery();
                        MessageBox.Show(" realizado correctamente! ");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(" Error al ejecutar UPDATE. \n\n Error: " + ex);
                    }
                    conn.Close();
                    HSC_ControlMesas nuevo = new HSC_ControlMesas(sIdUsuario);
                    this.Close();
                    nuevo.Show();
                    connAux.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" No se Actualizó el estado de la mesa \n\n Error: " + ex);
                    connAux.Close();
                }
            
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                connAux.Open();
                OdbcCommand codigoAux = new OdbcCommand();
                codigoAux.Connection = connAux;
                codigoAux.CommandText = ("UPDATE `tbl_mesas` SET `estadoMesa`=1 WHERE KidNumeroMesa=" + noMesa);
                try
                {
                    codigoAux.ExecuteNonQuery();
                    MessageBox.Show(" realizado correctamente! ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Error al ejecutar UPDATE. \n\n Error: " + ex);
                }
                conn.Close();
                HSC_ControlMesas nuevo = new HSC_ControlMesas(sIdUsuario);
                this.Close();
                nuevo.Show();
                connAux.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" No se Actualizó el estado de la mesa \n\n Error: " + ex);
                connAux.Close();
            }
        }

        private void HSC_MesaLibOc_Load(object sender, EventArgs e)
        {

        }
    }
}
