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
    public partial class frm_cliente : Form
    {

        public frm_cliente()
        {
            InitializeComponent();
        }

        private void llenarcbo()
        {
            negocio cnegocio = new negocio();
            cbo_tprecio.ValueMember = "id_tprecio";
            cbo_tprecio.DisplayMember = "tipo";
            cbo_tprecio.DataSource = cnegocio.consultacat();
        }

        private void frm_cliente_Load(object sender, EventArgs e)
        {
            llenarcbo();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            entidades.Cliente cliente = new entidades.Cliente();  //Creamos un objeto de la capa de Entidades para poder acceder a sus objetos
            negocio cnegocio = new negocio();                       //Creamos un objeto de la capa de negocio para poder acceder a sus funciones
            cliente.nit = txt_nit.Text;
            cliente.nombre = txt_nombre.Text;
            cliente.apellido = txt_apellido.Text;
            cliente.direccion = txt_direccion.Text;
            cliente.telefono = txt_telefono.Text;
            cliente.tipoprecio = Convert.ToInt32(cbo_tprecio.SelectedIndex + 1);
            cnegocio.InsertarCliente(cliente);                                    //Llamamos a la funcion Ninsertar a traves del objeto de la capa de negocio y le enviamos como parametro nuestro objeto persona
           
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            
        }
    }
            
}

