using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace contrato_trabajo
{
    class conexion
    {
        public static OdbcConnection ObtenerConexion()
        {
            OdbcConnection con = new OdbcConnection("dns=;server=localhost; database=gerencial; Uid=root; pwd=1234;");
            con.Open();
            return con;
        }


    }
}
