using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeDiseno;
using System.Data.Odbc;

namespace Hoteleria
{
    public partial class HSC_CheckIn : Form
    {
        OdbcConnection conn = new OdbcConnection("Dsn=navegador");
        int auxColor;
        int auxCodH;
        int max;

        string sIdUsuario;
        string[] listaBotones;
        public HSC_CheckIn(string usuario, int no, int estado)
        {
            InitializeComponent();
            //cambiarEstado1(no, estado);
            sIdUsuario = usuario;
            cantidad();
            //int auxCant = 14;
            listaBotones = new string[max];
            //crearBoton(auxCant);
            datosHabitaciones();
        }

        void cantidad()
        {
            conn.Open();
            OdbcCommand codigo = new OdbcCommand();
            codigo.Connection = conn;
            codigo.CommandText = ("SELECT COUNT(KidNumeroHabitacion) FROM `tbl_habitaciones` WHERE estado=1");
            
            try
            {
                OdbcDataReader resultadoSQL = codigo.ExecuteReader(CommandBehavior.CloseConnection);
                while (resultadoSQL.Read())
                {
                    max = Convert.ToInt32(resultadoSQL.GetString(0));
                    max++;
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

        void datosHabitaciones()
        {
            conn.Open();
            OdbcCommand codigo = new OdbcCommand();
            codigo.Connection = conn;
            codigo.CommandText = ("SELECT * FROM tbl_habitaciones WHERE estado=1");
            try
            {
                OdbcDataReader resultadoSQL = codigo.ExecuteReader(CommandBehavior.CloseConnection);

                Button[] boton = new Button[max];
                string nombreBoton;
                int aux = 0;
                int aux2 = 0;
                int contador = 1;
                while (resultadoSQL.Read())
                {

                    auxCodH = Convert.ToInt32(resultadoSQL.GetString(0));
                    auxColor = Convert.ToInt32(resultadoSQL.GetString(5));
                    //MessageBox.Show("auxCodH: " + auxCodH);
                    try
                    {
                        //MessageBox.Show("contador: " + contador);
                        if (contador >= 1 && contador <= 4)
                        {
                            boton[contador] = new Button();
                            boton[contador].Width = 120;
                            boton[contador].Height = 60;

                            nombreBoton = "lb_Habitacion" + auxCodH;
                            boton[contador].Name = nombreBoton;
                            listaBotones[contador] = boton[contador].Name;

                            if (auxColor == 1)
                            {
                                boton[contador].BackColor = Color.FromArgb(128, 255, 128);
                            }
                            if (auxColor == 2)
                            {
                                boton[contador].BackColor = Color.Cyan;
                            }
                            if (auxColor == 3)
                            {
                                boton[contador].BackColor = Color.FromArgb(255, 128, 128);
                            }

                            boton[contador].Text = String.Format("{0}", "Habitación " + auxCodH);
                            boton[contador].Top = 82 + (contador * 75);
                            boton[contador].Left = 50;
                            this.Controls.Add(boton[contador]);
                        }
                        else if (contador >= 5 && contador <= 9)
                        {
                            boton[contador] = new Button();
                            boton[contador].Width = 120;
                            boton[contador].Height = 60;

                            nombreBoton = "lb_Habitacion" + auxCodH;
                            boton[contador].Name = nombreBoton;
                            listaBotones[contador] = boton[contador].Name;

                            if (auxColor == 1)
                            {
                                boton[contador].BackColor = Color.FromArgb(128, 255, 128);
                            }
                            if (auxColor == 2)
                            {
                                boton[contador].BackColor = Color.Cyan;
                            }
                            if (auxColor == 3)
                            {
                                boton[contador].BackColor = Color.FromArgb(255, 128, 128);
                            }

                            boton[contador].Text = String.Format("{0}", "Habitación " + auxCodH);
                            boton[contador].Top = 82 + (aux * 75);
                            boton[contador].Left = 200;
                            aux++;
                            this.Controls.Add(boton[contador]);
                        }
                        else if (contador >= 10 && contador <= 14)
                        {
                            boton[contador] = new Button();
                            boton[contador].Width = 120;
                            boton[contador].Height = 60;

                            nombreBoton = "lb_Habitacion" + auxCodH;
                            boton[contador].Name = nombreBoton;
                            listaBotones[contador] = boton[contador].Name;

                            if (auxColor == 1)
                            {
                                boton[contador].BackColor = Color.FromArgb(128, 255, 128);
                            }
                            if (auxColor == 2)
                            {
                                boton[contador].BackColor = Color.Cyan;
                            }
                            if (auxColor == 3)
                            {
                                boton[contador].BackColor = Color.FromArgb(255, 128, 128);
                            }

                            boton[contador].Text = String.Format("{0}", "Habitación " + auxCodH);
                            boton[contador].Top = 82 + (aux2 * 75);
                            boton[contador].Left = 350;
                            aux2++;
                            this.Controls.Add(boton[contador]);
                        }
                        else if (contador >= 15)
                        {
                            MessageBox.Show(" Hay mas de 15 Habitaciones Registradas. \n Contacte al ADMINISTRADOR!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("GRAFICAR BOTONES. Error: " + ex);
                    }
                    contador++;
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
       
        private void Btn_Habitacion1_Click(object sender, EventArgs e)
        {
            ProcesarCheckIn nuevo = new ProcesarCheckIn(1, sIdUsuario);
            this.Close();
            nuevo.Show();
        }

        private void Btn_Habitacion2_Click(object sender, EventArgs e)
        {
            ProcesarCheckIn nuevo = new ProcesarCheckIn(2, sIdUsuario);
            this.Close();
            nuevo.Show();
        }

        private void HSC_CheckIn_Load(object sender, EventArgs e)
        {

        }
    }
}
