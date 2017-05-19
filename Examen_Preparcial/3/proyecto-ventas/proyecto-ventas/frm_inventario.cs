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

namespace proyecto_ventas
{
    public partial class frm_inventario : Form
    {
        public frm_inventario()
        {
            InitializeComponent();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            negocio cnegocio = new negocio();           //Creamos un objeto de la capa de negocio para poder acceder a sus funciones
            dgv_inventario.DataSource = cnegocio.consultaprod();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            entidades.Producto producto = new entidades.Producto();  //Creamos un objeto de la capa de Entidades para poder acceder a sus objetos
            negocio cnegocio = new negocio();                       //Creamos un objeto de la capa de negocio para poder acceder a sus funciones
            producto.nombre = txt_nombre.Text;
            producto.marca = txt_marca.Text;
            producto.costo = Convert.ToDouble(txt_costo.Text);
            cnegocio.InsertarProducto(producto);                                    //Llamamos a la funcion Ninsertar a traves del objeto de la capa de negocio y le enviamos como parametro nuestro objeto persona

        }

        private void frm_inventario_Load(object sender, EventArgs e)
        {

        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Anterior(dgv_inventario);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Siguiente(dgv_inventario);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Primero(dgv_inventario);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Ultimo(dgv_inventario);
        }
    }
}
