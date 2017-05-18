﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace PreParcial
{
    class Conexion
    {
        public static OdbcConnection ObtenerConexion()
        {
            OdbcConnection miconexion = new OdbcConnection("dsn=hotelsancarlos;server=localhost;database=hotelsancarlos;uid=root;password=");
            //MySqlConnection miconexion = new MySqlConnection("server=127.0.0.1; database=hotelsancarlos; uid=root; pwd=;");
            miconexion.Open();
            return miconexion;
        }
        public static OdbcConnection Desconectar()
        {
            OdbcConnection miconexion = new OdbcConnection("dsn=hotelsancarlos;server=localhost;database=hotelsancarlos;uid=root;password=");
            //MySqlConnection miconexion = new MySqlConnection("server=127.0.0.1; database=hotelsancarlos; uid=root; pwd=;");
            miconexion.Close();
            return miconexion;
        }

        public static void EjecutarMySql(String Query)
        {

            //MySqlCommand MiComando = new MySqlCommand(Query, ObtenerConexion());
            OdbcCommand MiComando = new OdbcCommand(Query, ObtenerConexion());
            int FilasAfectadas = MiComando.ExecuteNonQuery();
            if (FilasAfectadas > 0)
            {
                //MessageBox.Show("Operacion Realizada Exitosamente", "La base de datos ha sido modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //MessageBox.Show("No se pudo realizar la modificacion de la base de datos", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
