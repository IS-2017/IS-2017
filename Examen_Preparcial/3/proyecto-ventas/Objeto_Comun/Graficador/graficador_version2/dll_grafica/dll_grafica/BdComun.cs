using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.Odbc;

namespace Graf1
{
    public class BdComun
    {
        
            public static OdbcConnection ObtenerConexion()
            {
                OdbcConnection conectar = new OdbcConnection("DSN=graficador; UID=root; PWD=;");

                conectar.Open();
                return conectar;
            
        }
    }
}
