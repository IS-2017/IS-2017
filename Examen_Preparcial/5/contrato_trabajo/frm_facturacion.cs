using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace contrato_trabajo
{
    public partial class frm_facturacion : Form
    {
        public frm_facturacion()
        {
            InitializeComponent();
        }

        private void frm_facturacion_Load(object sender, EventArgs e)
        {
            llenarcboProducto();
            llenarcboCliente();
            txt_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        #region Combobox - Otto Hernandez
        public void llenarcboProducto()
        {
            try
            {
                //se realiza la conexión a la base de datos
                Ayuda.ObtenerConexion();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_producto, nombre_producto, cantidad_producto, precio_producto from producto";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, Ayuda.ObtenerConexion());
                //se indica con quu tabla se llena
                dad.Fill(ds, "producto");
                cbo_producto.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_producto.ValueMember = ("precio_producto");
                //cbo_producto. = ("precio_producto");
                //se indica el valor a desplegar en el combobox
                DataTable dt = ds.Tables[0];
                cbo_producto.DataSource = dt;
                cbo_producto.DisplayMember = "nombre_producto";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void llenarcboCliente()
        {
            try
            {
                //se realiza la conexión a la base de datos
                Ayuda.ObtenerConexion();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_cliente, nombre_cliente, nit_cliente from cliente";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, Ayuda.ObtenerConexion());
                //se indica con quu tabla se llena
                dad.Fill(ds, "cliente");
                cbo_cliente.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_cliente.ValueMember = ("id_cliente");
                //se indica el valor a desplegar en el combobox
                DataTable dt = ds.Tables[0];
                dt.Columns.Add("NewColumn", typeof(string));
                foreach (DataRow dr in dt.Rows)
                {
                    dr["nombre_cliente"] = dr["id_cliente"].ToString() + "|" + dr["nombre_cliente"].ToString() + "|" + dr["nit_cliente"].ToString();
                }
                cbo_cliente.DataSource = dt;
                cbo_cliente.DisplayMember = "nombre_cliente";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void btn_quitar_Click(object sender, EventArgs e)
        {
            dgv_detalle_factura.Rows.RemoveAt(dgv_detalle_factura.CurrentRow.Index);
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            dgv_detalle_factura.Rows.Add(txt_cantidad1.Text.Trim(), cbo_producto.Text, cbo_producto.SelectedValue.ToString());
            double suma = 0;
            foreach (DataGridViewRow celda in dgv_detalle_factura.Rows)
            {
                suma += Convert.ToDouble(celda.Cells["precio_factura"].Value);
            }
            lbl_tot.Text = suma.ToString();
        }

        public DataTable Seleccionultimoencabezado()
        {
            DataTable carga = new DataTable();
            string cadena = "select max(id_enc_factura) from encabezado_factura";
            OdbcCommand cmd = new OdbcCommand(cadena, seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
            adap.Fill(carga);
            return carga;
        }

        public void InsertarDetalleFactura(string id_encabezado, string cantidad, string producto, string precio)
        {
            String cadena = "insert into factura (id_enc_factura,cantidad_factura,nombre_producto,precio_factura)values('" + id_encabezado + "','" + cantidad + "','" + producto + "','" + precio + "')";
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand cmd = new OdbcCommand(cadena, seguridad.Conexion.ObtenerConexionODBC());
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable SeleccionarCantidadInventario(string producto)
        {
            String cadena = "select cantidad_producto from producto where nombre_producto ='" + producto + "';";
            DataTable contenedor = new DataTable();
            OdbcCommand cmd = new OdbcCommand(cadena, seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
            adap.Fill(contenedor);
            return contenedor;

        }

        public void ModificarCantidadSumarExistencias(string producto, string cantidad)
        {
            String cadena = "update producto set cantidad_producto = '" + cantidad + "' where nombre_producto='" + producto + "'";
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand cmd = new OdbcCommand(cadena, seguridad.Conexion.ObtenerConexionODBC());
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void InsertarNuevoEncabezadoFactura(string cliente, string total)
        {
            String cadena = "insert into encabezado_factura(id_cliente,total_enc_factura,fecha_enc_factura)values('" + cliente + "','" + total + "', sysdate())";
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand cmd = new OdbcCommand(cadena, seguridad.Conexion.ObtenerConexionODBC());
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            InsertarNuevoEncabezadoFactura(txt_cliente.Text.Trim(), lbl_tot.Text);

            DataTable dt_uvalor = Seleccionultimoencabezado();
            DataRow fila = dt_uvalor.Rows[0];
            String ultimovalor = fila["max(id_enc_factura)"].ToString();
            //lbl_id.Text = ultimovalor;

            // Llenar datatable con lo que hay en datagrid
            DataTable dt = new DataTable();
            dt.Columns.Add("cantidad", typeof(string));
            dt.Columns.Add("producto", typeof(string));
            dt.Columns.Add("precio", typeof(string));


            foreach (DataGridViewRow dgv in dgv_detalle_factura.Rows)
            {
                dt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2].Value);

            }
            // Insercion en la base de datos del datatable de detalle
            foreach (DataRow row in dt.Rows)
            {
                string cf = ":)";
                if (row[0].ToString() != "" || row[1].ToString() != "" || row[2].ToString() != "")
                {
                    InsertarDetalleFactura(ultimovalor, row[0].ToString(), row[1].ToString(), row[2].ToString());

                    DataTable dt_cant = SeleccionarCantidadInventario(row[1].ToString());
                    //MessageBox.Show(row[0].ToString());

                    //dataGridView1.DataSource = dt_cant;
                    DataRow fila_cant = dt_cant.Rows[0];

                    int cantidad = Convert.ToInt32(fila_cant["cantidad_producto"].ToString());

                    int cantidad_actualizada = cantidad - Convert.ToInt32(row[0].ToString());

                    ModificarCantidadSumarExistencias(row[1].ToString(), Convert.ToString(cantidad_actualizada));
                    cantidad_actualizada = 0;
                }
                MessageBox.Show("Agregado con exito", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void cbo_producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_precio1.Text = cbo_producto.SelectedValue.ToString();
        }
    }
}
