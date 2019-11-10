using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;

namespace Hoteleria
{
    class conexionAdmin
    {
        public Tuple<OdbcConnection, OdbcTransaction> ObtenerConexion()
        {
            OdbcConnection conn = new OdbcConnection("Dsn=cine");
            conn.Open();
            OdbcTransaction transaction = conn.BeginTransaction();
            return Tuple.Create(conn, transaction);
        }
    }
}
