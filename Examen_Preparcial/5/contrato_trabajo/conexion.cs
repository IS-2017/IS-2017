using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;

namespace contrato_trabajo
{
    class conexion
    {
        public static OdbcConnection ObtenerConexion()
        {
            OdbcConnection con = new OdbcConnection("dsn=crm;server=localhost; Uid=root; pwd=;");
            con.Open();
            return con;
        }
        public static OdbcConnection DesconectarConexion()
        {
            OdbcConnection con = new OdbcConnection();
            con.ConnectionString = "dsn=crm;server=localhost; Uid=root; pwd=;";
            con.Close();
            return con;
        }  
    }
}
