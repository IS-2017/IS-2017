using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuncionesNavegador;

namespace crm
{
    public partial class inventario : Form
    {
        string id_form= "116";
        public inventario()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            txt_nombre.Clear();
            txt_existencia.Clear();
            txt_marca.Clear();
            txt_precio.Clear();
            //txt_categoria.Clear();
            txt_fecha.Clear();

        }

        private void habilitar()
        {
            txt_nombre.Enabled = true;
            txt_marca.Enabled = true;
            txt_existencia.Enabled = true;
            txt_precio.Enabled = true;
            //txt_categoria.Enabled = true;
        }

        private void deshabilitar()
        {
            txt_nombre.Enabled = false;
            txt_marca.Enabled = false;
            txt_existencia.Enabled = false;
            txt_precio.Enabled = false;
            //txt_categoria.Enabled = false;
        }


        private void llenarcbo()
        {
            negocio cnegocio = new negocio();
            cbo_cat.ValueMember = "id";
            cbo_cat.DisplayMember = "nombre";
            cbo_cat.DataSource = cnegocio.consultacat();
            txt_fecha.Enabled = false;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            habilitar();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            entidades.Producto producto = new entidades.Producto();  //Creamos un objeto de la capa de Entidades para poder acceder a sus objetos
            negocio cnegocio = new negocio();                       //Creamos un objeto de la capa de negocio para poder acceder a sus funciones
            producto.nombre = txt_nombre.Text;                                //Llenamos el objeto persona con la informacion de los cuadros de texto/
            producto.marca = txt_marca.Text;
            producto.existencia = Convert.ToInt32(txt_existencia.Text);
            producto.precio = Convert.ToDouble(txt_precio.Text);
            //producto.categoria = Convert.ToInt32(txt_categoria.Text);
            producto.ingreso = DateTime.Today;
            producto.categoria = Convert.ToInt32(cbo_cat.SelectedIndex + 1);
            cnegocio.InsertarProducto(producto);                                    //Llamamos a la funcion Ninsertar a traves del objeto de la capa de negocio y le enviamos como parametro nuestro objeto persona
            limpiar();
            deshabilitar();

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            entidades.Producto producto = new entidades.Producto();
            Int32 selectedRowCount =
            dgv_producto.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                producto.codigo = Convert.ToString(dgv_producto.CurrentRow.Cells[0].Value);
                negocio neg = new negocio();
                neg.EliminarProducto(producto);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Anterior(dgv_producto);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Siguiente(dgv_producto);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Primero(dgv_producto);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Ultimo(dgv_producto);
        }

        private void inventario_Load(object sender, EventArgs e)
        {

        }
    }
}
