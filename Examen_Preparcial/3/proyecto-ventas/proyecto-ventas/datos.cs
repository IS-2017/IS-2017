using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using seguridad;
using System.Data;

namespace proyecto_ventas
{
    class datos
    {
        seguridad.bitacora bita = new seguridad.bitacora();
        /*-----------------------------------------------VARIABLES GLOBALES------------------------------------------------------------*/
        #region Variables Globales
        private static OdbcCommand mySqlComando;
        private static OdbcDataAdapter mySqlDAdAdaptador;
        #endregion

        #region Funciones de Manipulacion de Datos
        public void insertarcliente(string nit, string nombre, string apellido, string direccion, string telefono, Int32 tipo)
        {
            try
            {
                mySqlComando = new OdbcCommand(
                string.Format("Insert into cliente (nit_cliente, nombre_cliente, apellido_cliente, direccion_cliente, telefono_cliente, id_tprecio) values ('{0}','{1}','{2}','{3}','{4}','{5}')", nit, nombre, apellido, direccion, telefono, tipo),
                seguridad.Conexion.ObtenerConexionODBC());
                mySqlComando.ExecuteNonQuery();                 //se ejecuta el query
                MessageBox.Show("Se inserto con exito");        //si el try-catch no encontro algun error se muestra el mensaje de transaccion exitosa
            }
            catch (OdbcException e)
            {
                MessageBox.Show("Error de insercion");          //si el try-catch encontro algun error indica mensaje de fracaso
            }

        } //insertar cliente

        public void insertarcatalogo(string nombre)
        {
            try
            {
                mySqlComando = new OdbcCommand(
                string.Format("Insert into tipo_precio (tipo) values ('{0}')", nombre),
                seguridad.Conexion.ObtenerConexionODBC());
                mySqlComando.ExecuteNonQuery();                 //se ejecuta el query
                MessageBox.Show("Se inserto con exito");        //si el try-catch no encontro algun error se muestra el mensaje de transaccion exitosa
            }
            catch (OdbcException e)
            {
                MessageBox.Show("Error de insercion");          //si el try-catch encontro algun error indica mensaje de fracaso
            }

        } //insertar catalogo

        public void insertarproducto(string nombre, string marca, double costo)
        {
            try
            {
                mySqlComando = new OdbcCommand(
                string.Format("Insert into producto (nombre_producto, marca_producto, costo_producto) values ('{0}','{1}','{2}')", nombre, marca, costo),
                seguridad.Conexion.ObtenerConexionODBC());
                mySqlComando.ExecuteNonQuery();                 //se ejecuta el query
                MessageBox.Show("Se inserto con exito");        //si el try-catch no encontro algun error se muestra el mensaje de transaccion exitosa
            }
            catch (OdbcException e)
            {
                MessageBox.Show("Error de insercion");          //si el try-catch encontro algun error indica mensaje de fracaso
            }

        } //insertar catalogo

        #endregion

        public static DataTable ObtenerCat()
        {
            DataTable dtCatalogo = new DataTable();
            try
            {
                mySqlComando = new OdbcCommand(
                    string.Format("SELECT * FROM tipo_precio"),      //query de consultas de catalogo
                    seguridad.Conexion.ObtenerConexionODBC()              //llamada a clase conexion
                    );
                //-------------------------------------------------------------------------//
                mySqlDAdAdaptador = new OdbcDataAdapter();         //Llenando DataTable Catalogo
                mySqlDAdAdaptador.SelectCommand = mySqlComando;
                mySqlDAdAdaptador.Fill(dtCatalogo);
                //------------------------------------------------------------------------//
            }
            catch (Exception ex)
            {
                MessageBox.Show("No es posible acceder a los registros en catalogo de productos");
            }
            return dtCatalogo;
        }

        public static DataTable ObtenerProd()
        {
            DataTable dtProducto = new DataTable();
            try
            {
                mySqlComando = new OdbcCommand(
                    string.Format("SELECT * FROM producto"),      //query de consultas de catalogo
                    seguridad.Conexion.ObtenerConexionODBC()              //llamada a clase conexion
                    );
                //-------------------------------------------------------------------------//
                mySqlDAdAdaptador = new OdbcDataAdapter();         //Llenando DataTable Catalogo
                mySqlDAdAdaptador.SelectCommand = mySqlComando;
                mySqlDAdAdaptador.Fill(dtProducto);
                //------------------------------------------------------------------------//
            }
            catch (Exception ex)
            {
                MessageBox.Show("No es posible acceder a los registros en catalogo de productos");
            }
            return dtProducto;
        }

    }
}
