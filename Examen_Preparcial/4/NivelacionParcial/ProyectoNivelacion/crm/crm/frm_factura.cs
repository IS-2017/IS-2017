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
    public partial class frm_factura : Form
    {
        public frm_factura()
        {
            InitializeComponent();
        }

        CapaDatosPersonas capadatos = new CapaDatosPersonas();


        private void btn_agregar_Click(object sender, EventArgs e)
        {
            // SeleccionarClienteSegunNit
            dgv_detalle_usuario.Rows.Add(txt_cantidad.Text.Trim(),cmb_producto.Text,cmb_producto.SelectedValue.ToString());

            // suma de totales
            double suma = 0;
            foreach (DataGridViewRow celda in dgv_detalle_usuario.Rows)
            {
                suma += Convert.ToDouble(celda.Cells["precio"].Value);
            }
            lbl_total.Text = suma.ToString();
        }

        private void txt_nit_TextChanged(object sender, EventArgs e)
        {
            //DataTable dt_clts = capadatos.SeleccionarClienteSegunNit(txt_nit.Text.Trim());
            ////MessageBox.Show(row[0].ToString());

            ////dataGridView1.DataSource = dt_cant;
            //DataRow fila_cant = dt_clts.Rows[0];

            //txt_nombre.Text = fila_cant["nombres"].ToString();
            //txt_apellidos.Text = fila_cant["apellidos"].ToString();
        }

        private void txt_nit_Enter(object sender, EventArgs e)
        {
            if (txt_nit.Text.Trim() != "")
            {
                DataTable dt_clts = capadatos.SeleccionarClienteSegunNit(txt_nit.Text.Trim());
                //MessageBox.Show(row[0].ToString());

                //dataGridView1.DataSource = dt_cant;
                DataRow fila_cant = dt_clts.Rows[0];

                txt_nombre.Text = fila_cant["nombres"].ToString();
                txt_apellidos.Text = fila_cant["apellidos"].ToString();
            }
            else { MessageBox.Show("hola"); }
        }

        private void txt_nit_TabIndexChanged(object sender, EventArgs e)
        {
            //DataTable dt_clts = capadatos.SeleccionarClienteSegunNit(txt_nit.Text.Trim());
            ////MessageBox.Show(row[0].ToString());

            ////dataGridView1.DataSource = dt_cant;
            //DataRow fila_cant = dt_clts.Rows[0];

            //txt_nombre.Text = fila_cant["nombres"].ToString();
            //txt_apellidos.Text = fila_cant["apellidos"].ToString();
            
        }

        private void frm_factura_Load(object sender, EventArgs e)
        {
            DataTable dt_prod = capadatos.SeleccionarListaProductos();



            cmb_producto.DataSource = dt_prod;
            cmb_producto.DisplayMember = "producto";
            cmb_producto.ValueMember = "valor";
        }

        private void btn_quitar_Click(object sender, EventArgs e)
        {
            dgv_detalle_usuario.Rows.RemoveAt(dgv_detalle_usuario.CurrentRow.Index);

        }


        // ACEPTAR
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            capadatos.InsertarNuevoEncabezadoFactura(txt_nombre.Text.Trim(),txt_apellidos.Text.Trim(),lbl_total.Text); // insercion de encabezado

            DataTable dt_uvalor = capadatos.SeleccionUltimoDatoDetalleFactura();
            DataRow fila = dt_uvalor.Rows[0];
            String ultimovalor = fila["max(id_enca_factura)"].ToString();
            lbl_id.Text = ultimovalor;

            // Llenar datatable con lo que hay en datagrid
            DataTable dt = new DataTable();
            dt.Columns.Add("cantidad", typeof(string));
            dt.Columns.Add("producto", typeof(string));
            dt.Columns.Add("precio", typeof(string));
       

            foreach (DataGridViewRow dgv in dgv_detalle_usuario.Rows)
            {
                dt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2].Value);


            }
            // Insercion en la base de datos del datatable de detalle
            foreach (DataRow row in dt.Rows)
            {
                string cf = ":)";
                if (row[0].ToString() != "" || row[1].ToString() != "" || row[2].ToString() != "" )
                {
                    capadatos.InsertarNuevoDetalleFactura(ultimovalor, row[0].ToString(), row[1].ToString(), row[2].ToString());

                    DataTable dt_cant = capadatos.SeleccionarCantidadInventario(row[1].ToString());
                    //MessageBox.Show(row[0].ToString());

                    //dataGridView1.DataSource = dt_cant;
                    DataRow fila_cant = dt_cant.Rows[0];

                    int cantidad = Convert.ToInt32(fila_cant["cantidad"].ToString());

                    int cantidad_actualizada = cantidad - Convert.ToInt32(row[0].ToString());

                    capadatos.ModificarCantidadSumarExistencias(row[1].ToString(), Convert.ToString(cantidad_actualizada));
                    cantidad_actualizada = 0;
                }
                MessageBox.Show("Agregado con exito", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
