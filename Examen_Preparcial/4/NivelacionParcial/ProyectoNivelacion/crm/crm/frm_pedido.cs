using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crm
{
    public partial class frm_pedido : Form
    {
        public frm_pedido()
        {
            InitializeComponent();
        }
        CapaDatosPersonas capadatos = new CapaDatosPersonas();

        private void frm_pedido_Load(object sender, EventArgs e)
        {
            DataTable dt_prod = capadatos.SeleccionarListaProductos();



            cmb_producto.DataSource = dt_prod;
            cmb_producto.DisplayMember = "producto";
            cmb_producto.ValueMember = "valor";


            // datable de proveedores

            DataTable dt_prov = capadatos.SeleccionarListaProveedores();



            cmb_proveedor.DataSource = dt_prov;
            cmb_proveedor.DisplayMember = "empresa";
            cmb_proveedor.ValueMember = "telefono";

            dgv_detalle_bd.DataSource = dt_prov;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            // Datagrid a nivel de usuario
            dgv_detalle_usuario.Rows.Add(txt_cantidad.Text, cmb_producto.Text, cmb_producto.SelectedValue.ToString(),cmb_proveedor.Text, cmb_proveedor.SelectedValue.ToString());

            //// Datagrid a nivel base de datos
            //dgv_detalle_bd.Rows.Add("mp", cmb_materia_prima.SelectedValue.ToString(), txt_cantidad.Text, cmb_medida.SelectedValue.ToString(),
            //cmb_proceso.SelectedValue.ToString(), valor, costo);
        }

        private void btn_quitar_Click(object sender, EventArgs e)
        {
            dgv_detalle_usuario.Rows.RemoveAt(dgv_detalle_usuario.CurrentRow.Index);

        }


        // ingresar el pedido
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            capadatos.InsertarNuevoEncabezadoDetalle(txt_encargado.Text.Trim()); // insercion de encabezado

            DataTable dt_uvalor = capadatos.SeleccionUltimoDatoDetalle();
            DataRow fila = dt_uvalor.Rows[0];
            String ultimovalor = fila["max(id_enca_pedido)"].ToString();
            lbl_id.Text = ultimovalor;

            // Llenar datatable con lo que hay en datagrid
            DataTable dt = new DataTable();
            dt.Columns.Add("cantidad", typeof(string));
            dt.Columns.Add("producto", typeof(string));
            dt.Columns.Add("precio", typeof(string));
            dt.Columns.Add("proveedor", typeof(string));
            dt.Columns.Add("telefono", typeof(string));

            foreach (DataGridViewRow dgv in dgv_detalle_usuario.Rows)
            {
                dt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value, dgv.Cells[4].Value);


            }
            // Insercion en la base de datos del datatable de detalle
            foreach (DataRow row in dt.Rows)
            {
                string cf = ":)";
                if (row[0].ToString() != "" || row[1].ToString() != "" || row[2].ToString() != "" || row[3].ToString() != "" || row[4].ToString() != "")
                {
                    capadatos.InsertarNuevoDetallePedido(ultimovalor, row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());
                    
                    DataTable dt_cant = capadatos.SeleccionarCantidadInventario(row[1].ToString());
                    //MessageBox.Show(row[0].ToString());

                    //dataGridView1.DataSource = dt_cant;
                    DataRow fila_cant = dt_cant.Rows[0];

                    int cantidad = Convert.ToInt32(fila_cant["cantidad"].ToString());

                    int cantidad_actualizada = cantidad + Convert.ToInt32(row[0].ToString());

                    capadatos.ModificarCantidadSumarExistencias(row[1].ToString(), Convert.ToString(cantidad_actualizada));
                    MessageBox.Show("Agregado con exito", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cantidad_actualizada = 0;
                }

            }
            


        }
    }
}
