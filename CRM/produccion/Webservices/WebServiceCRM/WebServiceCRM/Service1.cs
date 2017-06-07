using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.Odbc;

namespace WebServiceCRM
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Service1 : IService1
    {
        public string ObtenerBodega(int ID)
        {
            OdbcConnection con = Conexion.ObtenerConexionODBC();
            if (con != null)
            {
                try
                {
                    DataTable dt = new DataTable("midt");
                    string consulta = "select nombre_bodega from bodega where id_bodega_pk = "+ID;
                    OdbcCommand com = new OdbcCommand(consulta, con);
                    OdbcDataAdapter ad = new OdbcDataAdapter(com);
                    ad.Fill(dt);
                    DataRow row = dt.Rows[0];
                    string nombre_bodega= row[0].ToString();
                    return nombre_bodega;
                }
                catch { return "Error en el proceso de extraccion de los datos"; }

            }
            else
            {
                return "No es posible conectar con la base de datos";
            }
            
        }

        public DataSet ObtenerDetalleFactura()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            OdbcConnection con = Conexion.ObtenerConexionODBC();
            OdbcCommand com = new OdbcCommand("select id_factura, id_producto, cantidad from detalle_factura", con);
            OdbcDataAdapter ad = new OdbcDataAdapter(com);
            ad.Fill(dt);
            ds.Tables.Add(dt);
            return ds;
        }


        public DataSet ObtenerEncabezadoFactura()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            OdbcConnection con = Conexion.ObtenerConexionODBC();
            OdbcCommand com = new OdbcCommand("select id_factura, fecha, total, estado, id_empleado_pk from factura_encabezado", con);
            OdbcDataAdapter ad = new OdbcDataAdapter(com);
            ad.Fill(dt);
            ds.Tables.Add(dt);
            return ds;
        }

        public DataSet ObtenerPrecio()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            OdbcConnection con = Conexion.ObtenerConexionODBC();
            OdbcCommand com = new OdbcCommand("select id_bien, precio from precio", con);
            OdbcDataAdapter ad = new OdbcDataAdapter(com);
            ad.Fill(dt);
            ds.Tables.Add(dt);
            return ds;
        }

        public DataSet ObtenerProductos()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            OdbcConnection con = Conexion.ObtenerConexionODBC();
            OdbcCommand com = new OdbcCommand("select id_producto, descripcion, nombre from producto",con);
            OdbcDataAdapter ad = new OdbcDataAdapter(com);
            ad.Fill(dt);
            ds.Tables.Add(dt);
            return ds;
        }

        public DataSet PruebaCristian()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            OdbcConnection con = Conexion.ObtenerConexionODBC();
            OdbcCommand com = new OdbcCommand("select * from producto", con);
            OdbcDataAdapter ad = new OdbcDataAdapter(com);
            ad.Fill(dt);
            ds.Tables.Add(dt);
            return ds;
        }

        public DataSet ObtenerProducto(string id_empleado, string fecha1, string fecha2)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            OdbcConnection con = Conexion.ObtenerConexionODBC();
            OdbcCommand com = new OdbcCommand("SELECT FE.id_factura, PR.nombre, PR.cporcentaje, DF.precioUnidad, DF.cantidad FROM detalle_factura DF, factura_encabezado FE, precio P, producto PR WHERE (DF.id_factura = FE.id_factura AND PR.id_producto = DF.id_producto AND FE.id_empleado_pk = '" + id_empleado + "') AND FE.fecha BETWEEN '" + fecha1 + "' AND '" + fecha2 + "';", con);
            OdbcDataAdapter ad = new OdbcDataAdapter(com);
            ad.Fill(dt);
            ds.Tables.Add(dt);
            return ds;
        }

        public DataSet ObtenerMarca(string empleado, string fecha1, string fecha2)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            OdbcConnection con = Conexion.ObtenerConexionODBC();
            OdbcCommand com = new OdbcCommand("SELECT FE.id_factura, PR.nombre, M.nombre_marca, M.porcentaje, DF.precioUnidad, DF.cantidad " +
            "FROM detalle_factura DF, factura_encabezado FE, precio P, producto PR, marca M WHERE (DF.id_factura = FE.id_factura AND PR.id_producto = DF.id_producto AND M.id_marca = PR.id_marca AND FE.id_empleado_pk = '" + empleado + "') AND FE.fecha BETWEEN '" + fecha1 + "' AND '" + fecha2 + "';" , con);
            OdbcDataAdapter ad = new OdbcDataAdapter(com);
            ad.Fill(dt);
            ds.Tables.Add(dt);
            return ds;
        }

        public DataSet ObtenerVendedor(string empleado, string fecha1, string fecha2)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            OdbcConnection con = Conexion.ObtenerConexionODBC();
            OdbcCommand com = new OdbcCommand("SELECT id_factura, total FROM factura_encabezado " +
            "WHERE id_empleado_pk = '" + empleado + "' AND fecha BETWEEN '" + fecha1 + "' AND '" + fecha2+ "';", con);
            OdbcDataAdapter ad = new OdbcDataAdapter(com);
            ad.Fill(dt);
            ds.Tables.Add(dt);
            return ds;
        }
    }
}
