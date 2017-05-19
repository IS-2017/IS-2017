using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_ventas
{
    class negocio : entidades
    {
        public void InsertarCliente(Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.nombre) || string.IsNullOrWhiteSpace(cliente.apellido) || string.IsNullOrWhiteSpace(cliente.nit) || string.IsNullOrWhiteSpace(cliente.direccion) || string.IsNullOrWhiteSpace(Convert.ToString(cliente.tipoprecio)) || string.IsNullOrWhiteSpace(cliente.telefono))
            {
                MessageBox.Show("Hay campos que estan vacios");     //si hace falta algun campo no se realiza la transaccion
            }
            else
            {
                datos cdatos = new datos();     //Se crea un objeto de capa de datos
                cdatos.insertarcliente(cliente.nit, cliente.nombre, cliente.apellido, cliente.direccion, cliente.telefono, cliente.tipoprecio);      //se llama la funcion de DinsertarPersona con los datos del objeto persona
            }
        }

        public void InsertarCatalogo(Catalogo catalogo)
        {
            if (string.IsNullOrWhiteSpace(catalogo.nombre))
            {
                MessageBox.Show("Hay campos que estan vacios");     //si hace falta algun campo no se realiza la transaccion
            }
            else
            {
                datos cdatos = new datos();     //Se crea un objeto de capa de datos
                cdatos.insertarcatalogo(catalogo.nombre);      //se llama la funcion de DinsertarPersona con los datos del objeto persona
            }
        }

        public void InsertarProducto(Producto producto)
        {
            if (string.IsNullOrWhiteSpace(producto.nombre)||string.IsNullOrWhiteSpace(producto.marca)|| string.IsNullOrWhiteSpace(Convert.ToString(producto.costo)))
            {
                MessageBox.Show("Hay campos que estan vacios");     //si hace falta algun campo no se realiza la transaccion
            }
            else
            {
                datos cdatos = new datos();     //Se crea un objeto de capa de datos
                cdatos.insertarproducto(producto.nombre, producto.marca, producto.costo);      //se llama la funcion de DinsertarPersona con los datos del objeto persona
            }
        }

        public System.Data.DataTable consultacat()
        {
            return datos.ObtenerCat();              //se llama la funcion ObtenerCat
        }

        public System.Data.DataTable consultaprod()
        {
            return datos.ObtenerProd();              //se llama la funcion ObtenerCat
        }

    }
}
