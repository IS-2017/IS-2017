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
    public partial class frm_tipoprecio : Form
    {
        public frm_tipoprecio()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            entidades.Catalogo catalogo = new entidades.Catalogo();  //Creamos un objeto de la capa de Entidades para poder acceder a sus objetos
            negocio cnegocio = new negocio();                       //Creamos un objeto de la capa de negocio para poder acceder a sus funciones
            catalogo.nombre = txt_catalogo.Text;
            cnegocio.InsertarCatalogo(catalogo);                                    //Llamamos a la funcion Ninsertar a traves del objeto de la capa de negocio y le enviamos como parametro nuestro objeto persona
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            negocio cnegocio = new negocio();           //Creamos un objeto de la capa de negocio para poder acceder a sus funciones
            dgv_catalogo.DataSource = cnegocio.consultacat();
        }

        private void frm_tipoprecio_Load(object sender, EventArgs e)
        {

        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
            fn.Anterior(dgv_catalogo);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
            fn.Siguiente(dgv_catalogo);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
            fn.Primero(dgv_catalogo);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
            fn.Ultimo(dgv_catalogo);
        }
    }
}
