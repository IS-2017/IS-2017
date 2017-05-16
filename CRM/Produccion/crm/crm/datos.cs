using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Data;

namespace crm
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
        public void insertarproducto(string nombre, Int32 existencia, string marca, double precio, DateTime ingreso, Int32 id_categoria)
        {
            try
            {
                mySqlComando = new OdbcCommand(
                string.Format("Insert into producto (nombre, existencia, marca, precio, fecha_ingreso, id_categoria) values ('{0}','{1}','{2}','{3}','{4}','{5}')", nombre, existencia, marca, precio, ingreso, id_categoria),
                Conexion.ObtenerConexion()
                );
                mySqlComando.ExecuteNonQuery();                 //se ejecuta el query
                MessageBox.Show("Se inserto con exito");        //si el try-catch no encontro algun error se muestra el mensaje de transaccion exitosa
            }
            catch (OdbcException e)
            {
                MessageBox.Show("Error de insercion");          //si el try-catch encontro algun error indica mensaje de fracaso
            }

        } //insertar producto

        #region
        public void insertarbodega(string ubicacion, string tamanio)
        {
            try
            {
                mySqlComando = new OdbcCommand(
                string.Format("Insert into bodega (ubicacion, tamanio) values ('{0}','{1}')", ubicacion, tamanio),
                Conexion.ObtenerConexion()
                );
                mySqlComando.ExecuteNonQuery();                 //se ejecuta el query
                MessageBox.Show("Se inserto con exito");        //si el try-catch no encontro algun error se muestra el mensaje de transaccion exitosa
            }
            catch (OdbcException e)
            {
                MessageBox.Show("Error de insercion");          //si el try-catch encontro algun error indica mensaje de fracaso
            }

        } //insertar bodega


        public static DataTable ObtenerCat()
        {
            DataTable dtCategoria = new DataTable();
            try
            {
                mySqlComando = new OdbcCommand(
                    string.Format("SELECT * FROM categoria"),      //query de consultas de categoria
                    Conexion.ObtenerConexion()              //llamada a clase conexion
                    );
                //-------------------------------------------------------------------------//
                mySqlDAdAdaptador = new OdbcDataAdapter();         //Llenando DataTable Categoria
                mySqlDAdAdaptador.SelectCommand = mySqlComando;
                mySqlDAdAdaptador.Fill(dtCategoria);
                //------------------------------------------------------------------------//
            }
            catch (Exception ex)
            {
                MessageBox.Show("No es posible acceder a los registros en categoria producto");
            }
            return dtCategoria;
        }

        public static DataTable ObtenerBod()
        {
            DataTable dtBodega = new DataTable();
            try
            {
                mySqlComando = new OdbcCommand(
                    string.Format("SELECT * FROM bodega"),      //query de consultas de categoria
                    Conexion.ObtenerConexion()              //llamada a clase conexion
                    );
                //-------------------------------------------------------------------------//
                mySqlDAdAdaptador = new OdbcDataAdapter();         //Llenando DataTable Categoria
                mySqlDAdAdaptador.SelectCommand = mySqlComando;
                mySqlDAdAdaptador.Fill(dtBodega);
                //------------------------------------------------------------------------//
            }
            catch (Exception ex)
            {
                MessageBox.Show("No es posible acceder a los registros en bodega");
            }
            return dtBodega;
        }

        public static DataTable ObtenerRegistros()
        {

            DataTable dtProducto = new DataTable();         //se crea el objeto dtProducto
            try
            {
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT * FROM producto"),
                     Conexion.ObtenerConexion()
                 );                                                  //se realiza el query para la consulta de todos los registros de la tabla persona           
                mySqlDAdAdaptador = new OdbcDataAdapter();          //se crea un sqlDataAdaptor 
                mySqlDAdAdaptador.SelectCommand = mySqlComando;      //ejecutamos el query de consulta
                mySqlDAdAdaptador.Fill(dtProducto);                 //poblamos el sqlDataAdaptor con el resultado del query

            }
            catch (Exception Ex)
            {
                MessageBox.Show("No es posible obtener el registro", "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return dtProducto; //retornamos el sqlDataAdaptor con los datos del query
        } //mostrar registros

        public static DataTable ObtenerRegistrosbod()
        {
            DataTable dtBodega = new DataTable();         //se crea el objeto dtProducto
            try
            {
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT * FROM bodega"),
                     Conexion.ObtenerConexion()
                 );                                                  //se realiza el query para la consulta de todos los registros de la tabla persona           
                mySqlDAdAdaptador = new OdbcDataAdapter();          //se crea un sqlDataAdaptor 
                mySqlDAdAdaptador.SelectCommand = mySqlComando;      //ejecutamos el query de consulta
                mySqlDAdAdaptador.Fill(dtBodega);                 //poblamos el sqlDataAdaptor con el resultado del query

            }
            catch (Exception Ex)
            {
                MessageBox.Show("No es posible obtener el registro", "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return dtBodega; //retornamos el sqlDataAdaptor con los datos del query
        } //mostrar registros

        public static DataTable ObtenerRegistros2()
        {
            DataTable dtAbono = new DataTable();
            try
            {
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT * FROM abonos"),
                     Conexion.ObtenerConexion()
                 );                                                  //se realiza el query para la consulta de todos los registros de la tabla persona           
                mySqlDAdAdaptador = new OdbcDataAdapter();          //se crea un sqlDataAdaptor 
                mySqlDAdAdaptador.SelectCommand = mySqlComando;      //ejecutamos el query de consulta
                mySqlDAdAdaptador.Fill(dtAbono);                 //poblamos el sqlDataAdaptor con el resultado del query

            }
            catch (Exception Ex)
            {
                MessageBox.Show("No es posible obtener el registro", "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return dtAbono; //retornamos el sqlDataAdaptor con los datos del query

        }


        public void eliminarproducto(string codigo)
        {
            try
            {
                OdbcCommand comando = new OdbcCommand(string.Format("delete from producto where id='{0}'",
                Convert.ToInt32(codigo)), Conexion.ObtenerConexion()
                );
                comando.ExecuteNonQuery();                 //se ejecuta el query
                MessageBox.Show("Registro eliminado con exito");
            }
            catch (OdbcException e)
            {
                MessageBox.Show("Error de eliminacion");          //si el try-catch encontro algun error indica mensaje de fracaso
            }

        } //eliminar producto

        public void eliminarbodega(string codigo)
        {
            try
            {
                OdbcCommand comando = new OdbcCommand(string.Format("delete from bodega where id='{0}'",
                Convert.ToInt32(codigo)), Conexion.ObtenerConexion()
                );
                comando.ExecuteNonQuery();                 //se ejecuta el query
                MessageBox.Show("Registro eliminado con exito");
            }
            catch (OdbcException e)
            {
                MessageBox.Show("Error de eliminacion");          //si el try-catch encontro algun error indica mensaje de fracaso
            }

        } //eliminar bodega
        #endregion
        public void insertarabono(string id_factura, string id_cliente, string forma_pago, double abono, string fecha)
        {
            try
            {
                mySqlComando = new OdbcCommand(
                string.Format("Insert into abonos (id_factura, id_cliente, forma_pago, abono, fecha) values ('{0}','{1}','{2}','{3}','{4}')", id_factura, id_cliente, forma_pago, abono, fecha),
                seguridad.Conexion.ObtenerConexionODBC()
                );                                              //se realiza el query con los datos que ser recibieron del objeto persona
                mySqlComando.ExecuteNonQuery();                 //se ejecuta el query
                MessageBox.Show("Se inserto con exito");        //si el try-catch no encontro algun error se muestra el mensaje de transaccion exitosa
            }
            catch (OdbcException e)
            {
                MessageBox.Show("Error de insercion");          //si el try-catch encontro algun error indica mensaje de fracaso
            }

        } //insertar abono


        #endregion
        public static DataTable ObtenerClientes(string nombres)
        {
            DataTable dtCliente = new DataTable();
            try
            {
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT nombres,apellidos,incidencia FROM tbl_cliente where nombres ='{0}'", nombres),
                     Conexion.ObtenerConexion()
                 );                                                  //se realiza el query para la consulta de todos los registros de la tabla persona           
                mySqlDAdAdaptador = new OdbcDataAdapter();          //se crea un sqlDataAdaptor 
                mySqlDAdAdaptador.SelectCommand = mySqlComando;      //ejecutamos el query de consulta
                mySqlDAdAdaptador.Fill(dtCliente);                 //poblamos el sqlDataAdaptor con el resultado del query

            }
            catch (Exception Ex)
            {
                MessageBox.Show("No es posible obtener el cliente", "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return dtCliente; //retornamos el sqlDataAdaptor con los datos del query


        }
        public static List<entidades.factura> Buscar(int id_factura)

        {

            List<entidades.factura> _lista = new List<entidades.factura>();



            mySqlComando = new OdbcCommand(String.Format(

           "SELECT factura_encabezado.id_factura, tbl_cliente.nombres , factura_encabezado.forma_pago, factura_encabezado.total, factura_encabezado.id_cliente FROM factura_encabezado, tbl_cliente WHERE factura_encabezado.id_cliente = tbl_cliente.id_cliente AND factura_encabezado.id_factura ={0}", id_factura), Conexion.ObtenerConexion());

            OdbcDataReader _reader = mySqlComando.ExecuteReader();

            while (_reader.Read())

            {

                entidades.factura factura = new entidades.factura();

                factura.id_factura = _reader.GetInt32(0);

                factura.nombre_cliente = _reader.GetString(1);

                factura.saldo_factura = _reader.GetString(2);

                factura.saldo_factura = _reader.GetString(3);
                factura.id_cliente = _reader.GetInt32(4);

                //factura.observ_prov = _reader.GetString(4);

                //proveedor.nit_prov = _reader.GetString(5);


                _lista.Add(factura);

            }

            return _lista;

        }
        /*public static List<entidades.Cliente> Buscar2(int nombres)

        {

            List<entidades.Cliente> _lista = new List<entidades.Cliente>();



            MySqlCommand _comando = new MySqlCommand(String.Format(

           "SELECT factura_encabezado.id_factura, tbl_cliente.nombres , factura_encabezado.forma_pago, factura_encabezado.total, factura_encabezado.id_cliente FROM factura_encabezado, tbl_cliente WHERE factura_encabezado.id_cliente = tbl_cliente.id_cliente AND factura_encabezado.id_factura ={0}", id_factura), claseConexion.funobtenerConexion());

            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())

            {

                entidades.factura factura = new entidades.factura();

                factura.id_factura = _reader.GetInt32(0);

                factura.nombre_cliente = _reader.GetString(1);

                factura.saldo_factura = _reader.GetString(2);

                factura.saldo_factura = _reader.GetString(3);
                factura.id_cliente = _reader.GetInt32(4);

                //factura.observ_prov = _reader.GetString(4);

                //proveedor.nit_prov = _reader.GetString(5);


                _lista.Add(factura);

            }

            return _lista;

        }*/
        public static entidades.factura ObtenerFactura(int id_factura)

        {

            entidades.factura fact = new entidades.factura();
            OdbcConnection conexion = Conexion.ObtenerConexion();
            //OdbcConnection conexion = claseConexion.ObtenerConexionODBC();
            mySqlComando = new OdbcCommand(string.Format("SELECT factura_encabezado.id_factura, tbl_cliente.nombres , factura_encabezado.forma_pago, factura_encabezado.total, factura_encabezado.id_cliente FROM factura_encabezado, tbl_cliente WHERE factura_encabezado.id_cliente = tbl_cliente.id_cliente AND factura_encabezado.id_factura ={0}", id_factura), Conexion.ObtenerConexion());

            //OdbcCommand _comando = new OdbcCommand(String.Format("SELECT factura_encabezado.id_factura, tbl_cliente.nombres , factura_encabezado.forma_pago, factura_encabezado.total FROM factura_encabezado, tbl_cliente WHERE factura_encabezado.id_cliente = tbl_cliente.id_cliente AND factura_encabezado.id_factura ={0}", id_factura), conexion);

            OdbcDataReader _reader = mySqlComando.ExecuteReader();

            while (_reader.Read())

            {

                fact.id_factura = _reader.GetInt32(0);
                fact.nombre_cliente = _reader.GetString(1);
                fact.forma_pago = _reader.GetString(2);
                fact.saldo_factura = _reader.GetString(3);
                fact.id_cliente = _reader.GetInt32(4);
                //bien.cantidad = _reader.GetString(3);            
            }

            conexion.Close();
            return fact;

        }
    }
}
