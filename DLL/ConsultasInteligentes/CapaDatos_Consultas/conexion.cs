﻿using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos_Consultas
{
    public class conexion
    {
        private OdbcConnection OdbcConnection;

        public OdbcConnection Conectar()
        {
            OdbcConnection = new OdbcConnection("Dsn=HSC");

            try
            {
                OdbcConnection.Open();
            }
            catch
            {
                MessageBox.Show("Error en la conexion");
            }
            return OdbcConnection;

        }
    }
}
