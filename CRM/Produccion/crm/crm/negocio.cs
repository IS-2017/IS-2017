using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crm
{
    class negocio : entidades
    {
            public void InsertarProducto(Producto producto)
            {
                if (string.IsNullOrWhiteSpace(producto.nombre) || string.IsNullOrWhiteSpace(producto.marca) || string.IsNullOrWhiteSpace(Convert.ToString(producto.existencia)) || string.IsNullOrWhiteSpace(Convert.ToString(producto.precio)) || string.IsNullOrWhiteSpace(Convert.ToString(producto.categoria)) || string.IsNullOrWhiteSpace(Convert.ToString(producto.ingreso)))
                {
                    MessageBox.Show("Hay campos que estan vacios");     //si hace falta algun campo no se realiza la transaccion
                }
                else
                {
                    datos cdatos = new datos();     //Se crea un objeto de capa de datos
                    cdatos.insertarproducto(producto.nombre, producto.existencia, producto.marca, producto.precio, producto.ingreso, producto.categoria);      //se llama la funcion de DinsertarPersona con los datos del objeto persona
                }
            }

            public void EliminarProducto(Producto producto)
            {
                if (string.IsNullOrWhiteSpace(producto.codigo))
                {
                    MessageBox.Show("No ha seleccionado la fila a eliminar");
                }
                else
                {
                    MessageBox.Show("seleccionada fila para eliminar");
                    datos edatos = new datos();     //Se crea un objeto de capa de datos
                    edatos.eliminarproducto(producto.codigo);
                }

            }

            public void EliminarBodega(Bodega bodega)
            {
                if (string.IsNullOrWhiteSpace(bodega.codigo))
                {
                    MessageBox.Show("No ha seleccionado la fila a eliminar");
                }
                else
                {
                    MessageBox.Show("seleccionada fila para eliminar");
                    datos edatos = new datos();     //Se crea un objeto de capa de datos
                    edatos.eliminarbodega(bodega.codigo);
                }

            }

            public void InsertarBodega(Bodega bodega)
            {
                if (string.IsNullOrWhiteSpace(bodega.tamanio) || string.IsNullOrWhiteSpace(bodega.ubicacion))
                {
                    MessageBox.Show("Hay campos que estan vacios");     //si hace falta algun campo no se realiza la transaccion
                }
                else
                {
                    datos cdatos = new datos();     //Se crea un objeto de capa de datos
                    cdatos.insertarbodega(bodega.tamanio, bodega.ubicacion);
                }
            }

            public System.Data.DataTable consultar()
            {
                return datos.ObtenerRegistros();        //se llama la funcion ObtenerRegistros
            }

            public System.Data.DataTable consultarbod()
            {
                return datos.ObtenerRegistrosbod();
            }

            public System.Data.DataTable consultacat()
            {
                return datos.ObtenerCat();              //se llama la funcion ObtenerCat
            }
            public void InsertarAbono(Abono abono)
            {
                if (string.IsNullOrWhiteSpace(abono.id_factura) || string.IsNullOrWhiteSpace(abono.id_cliente) || string.IsNullOrWhiteSpace(Convert.ToString(abono.forma_pago)) || string.IsNullOrWhiteSpace(Convert.ToString(abono.abono)) || string.IsNullOrWhiteSpace(Convert.ToString(abono.fecha)))
                {
                    MessageBox.Show("Hay campos que estan vacios");     //si hace falta algun campo no se realiza la transaccion
                }
                else
                {
                    datos cdatos = new datos();     //Se crea un objeto de capa de datos
                    cdatos.insertarabono(abono.id_factura, abono.id_cliente, abono.forma_pago, abono.abono, abono.fecha);      //se llama la funcion de DinsertarPersona con los datos del objeto persona
                }
            }
            public void InsertarIncidencia(Cliente cliente)
            {
                datos idatos = new datos(); //Se crea un objeto de capa de datos
                                            //idatos.insertarabono
            }

            public System.Data.DataTable consultar2()
            {
                return datos.ObtenerRegistros2();        //se llama la funcion ObtenerRegistros
            }

            /*public System.Data.DataTable consultac()
            {
                //return datos.ObtenerClientes();         //se llama la funcion ObtenerClientes
            }*/
        
    }
}
