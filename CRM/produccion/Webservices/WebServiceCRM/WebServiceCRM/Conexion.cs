using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace WebServiceCRM
{
    class Conexion
    {




        public static OdbcConnection ObtenerConexionODBC()
        {

            try
            {
                OdbcConnection con = new OdbcConnection();
                //con.ConnectionString = "dsn=prueba2; database="+database+"; UID="+role+"; PWD="+password+"; ";
                //con.ConnectionString = "dsn=crm; UID=" + user + "; PWD=" + password + "; ";
                con.ConnectionString = "dsn=ServidorCrm;";
                con.Open();
                return con;
            }
            catch
            {

                return null;
            }
        }




    }
}
