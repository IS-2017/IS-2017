using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace WebServiceHRM
{
    class Conexionmysql
    {
        public static OdbcConnection ObtenerConexion()
        {
            OdbcConnection miconexion = new OdbcConnection("dsn=dsn_ws;");
           // OdbcConnection miconexion = new OdbcConnection("dsn=ServidorHRM;");
            miconexion.Open();
            return miconexion;
        }

        public static OdbcConnection Desconectar()
        {
            OdbcConnection miconexion = new OdbcConnection("dsn=dsn_ws;");
            //OdbcConnection miconexion = new OdbcConnection("dsn=ServidorHRM;");
            miconexion.Close();
            return miconexion;
        }

        public static void EjecutarMySql(String Query)
        {
            OdbcCommand MiComando = new OdbcCommand(Query, ObtenerConexion());
            int FilasAfectadas = MiComando.ExecuteNonQuery();
        }
    }
}
