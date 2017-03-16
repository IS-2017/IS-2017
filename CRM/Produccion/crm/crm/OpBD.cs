using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;


namespace crm
{
    class OpBD
    {
        seguridad.bitacora bita = new seguridad.bitacora();
        

        public static DataTable SeleccionarPaises()
        {
            try
            {
                DataTable dt = new DataTable();
                OdbcConnection con = seguridad.Conexion.ObtenerConexionM();
                OdbcCommand comando = new OdbcCommand("select * from pais", con);
                OdbcDataAdapter ad = new OdbcDataAdapter(comando);
                ad.Fill(dt);
                return dt;
            }
            catch { return null; }
        }

        public static DataTable SeleccionarCategorias()
        {
            try
            {
                DataTable dt = new DataTable();
                OdbcConnection con = seguridad.Conexion.ObtenerConexionM();
                OdbcCommand comando = new OdbcCommand("select nombre_cat from categoria_neg", con);
                OdbcDataAdapter ad = new OdbcDataAdapter(comando);
                ad.Fill(dt);
                return dt;
            }
            catch { return null; }
        }
        public static DataTable SeleccionarCategoriascbo()
        {
            try
            {
                DataTable dt = new DataTable();
                OdbcConnection con = seguridad.Conexion.ObtenerConexionM();
                OdbcCommand comando = new OdbcCommand("select * from categoria_neg", con);
                OdbcDataAdapter ad = new OdbcDataAdapter(comando);
                ad.Fill(dt);
                return dt;
            }
            catch { return null; }
        }

        public static DataTable SeleccionarClientes()
        {
            try
            {
                DataTable dt = new DataTable();
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand comando = new OdbcCommand("select id_cliente, concat(nombres,' ',apellidos) as nom from tbl_cliente where estado = 'activo'", con);
                OdbcDataAdapter ad = new OdbcDataAdapter(comando);
                ad.Fill(dt);
                return dt;
            }
            catch { return null; }
        }

        public static DataTable SeleccionarEmpleados()
        {
            try
            {
                DataTable dt = new DataTable();
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand comando = new OdbcCommand("select id_empleado, concat(id_empleado,' - ',nombres,' ',apellidos) as Empleado from tbl_empleado where estado = 'activo'", con);
                OdbcDataAdapter ad = new OdbcDataAdapter(comando);
                ad.Fill(dt);
                return dt;
            }
            catch { return null; }
        }

        public static DataTable SeleccionarMonedas()
        {
            try
            {
                DataTable dt = new DataTable();
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand comando = new OdbcCommand("select id_moneda, concat(simbolo,' - ',nombre) as Moneda from moneda where estado = 'activo'", con);
                OdbcDataAdapter ad = new OdbcDataAdapter(comando);
                ad.Fill(dt);
                return dt;
            }
            catch { return null; }
        }


        public static DataTable SeleccionarEmpresas()
        {
            try
            {
                DataTable dt = new DataTable();
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand comando = new OdbcCommand("select id_empresa, nombre from empresa where estado = 'activo'", con);
                OdbcDataAdapter ad = new OdbcDataAdapter(comando);
                ad.Fill(dt);
                return dt;
            }
            catch { return null; }
        }

        public int InsertarNegocioClie(string titulo, int perem, string detalles, int moneda, decimal valor, int cat, int empleado, int etapa, string fecha)
        {
            try
            {

                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                string query = "insert into tbl_negocio(id_negocio, etapa_negocio, id_cliente, id_empleado, titulo, detalles, id_moneda, valor, fecha_est_cierre, fecha_inicio, id_cat, id_empresa, estado)" +
                   " values ( null ," + etapa + ", " + perem + "," + empleado + ",'" + titulo + "','" + detalles + "'," + moneda + ","+valor+",'"+fecha+"',curdate(),"+cat+",0,'activo')";
                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.ExecuteNonQuery();
                try
                {
                    bita.Insertar("Registro de negocio: " + titulo, "tbl_negocio");
                }
                catch { MessageBox.Show("Error en bitacora"); }

                con.Close();
                return 1;
            }
            catch { return 0; }
        }

        public int InsertarNegocioEmp(string titulo, int perem, string detalles, int moneda, decimal valor, int cat, int empleado, int etapa, string fecha)
        {
            try
            {

                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                string query = "insert into tbl_negocio(id_negocio, etapa_negocio, id_empresa, id_empleado, titulo, detalles, id_moneda, valor, fecha_est_cierre, fecha_inicio, id_cat, id_cliente ,estado)" +
                   " values ( null ," + etapa + ", " + perem + "," + empleado + ",'" + titulo + "','" + detalles + "'," + moneda + "," + valor + ",'" + fecha + "',curdate()," + cat + ",0,'activo')";
                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.ExecuteNonQuery();
                try
                {
                    bita.Insertar("Registro de negocio: " + titulo, "tbl_negocio");
                }
                catch { MessageBox.Show("Error en bitacora"); }

                con.Close();
                return 1;
            }
            catch { return 0; }
        }

        public int InsertarEmpresa(string nombre, string direccion, string correo, string tel1, string tel2, int pais)
        {
            try
            {

                OdbcConnection con = seguridad.Conexion.ObtenerConexionM();
                string query = "insert into empresa(id_empresa, nombre, direccion, correo, telefono1, telefono2, id_pais,estado)"+
                   " values ( null ,'" + nombre + "', '" + direccion + "','"+correo+"','"+tel1+"','"+tel2+"',"+pais+",'activo')";
                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.ExecuteNonQuery();
                try
                {
                    bita.Insertar("Registro de empresa: " + nombre, "empresa");
                }
                catch { MessageBox.Show("Error en bitacora"); }
                
                con.Close();
                return 1;
            }
            catch { return 0; }
        }

        public  int InsertarCategoria(string nombre)
        {
            try
            {

                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                string query = "insert into categoria_neg(id_cat, nombre_cat, estado)" +
                   " values ( null ,'" + nombre + "','activo')";
                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.ExecuteNonQuery();
                try
                {
                    bita.Insertar("Registro de categoria: " + nombre, "categoria_neg");
                }
                catch { MessageBox.Show("Error en bitacora"); }

                con.Close();
                return 1;
            }
            catch { return 0; }
        }



    }
}
