﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
namespace Hoteleria
{
    class conexion
    {

        public OdbcConnection probarConexion()
        {
            OdbcConnection conn = new OdbcConnection("Dsn=Navegador");// creacion de la conexion via ODBC

            try
            {

                conn.Open();
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("no conecto");
            }
            return conn;
        }

    }
}
