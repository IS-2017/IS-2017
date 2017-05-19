using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_ventas
{
    class entidades
    {
        public class Cliente
        {
            public string codigo { get; set; }       //ATRIBUTOS DEL OBJETO CLIENTE
            public string nit { get; set; }
            public string nombre { get; set; }
            public string apellido { get; set; }
            public string direccion { get; set; }
            public string telefono { get; set; }
            public Int32 tipoprecio { get; set; }

            public Cliente() { }                   //CONSTRUCTOR VACIO

            public Cliente(string codigo, string nit, string nombre, string apellido, string direccion, string telefono, Int32 tipo)      //CONSTRUCTOR CON PARAMETROS
            {
                this.codigo = codigo;
                this.nit = nit;
                this.nombre = nombre;
                this.apellido = apellido;
                this.direccion = direccion;
                this.telefono = telefono;
                this.tipoprecio = tipo;
            }
        } //class cliente

        public class Catalogo
        {
            public string codigo { get; set; }       //ATRIBUTOS DEL OBJETO CATALOGO
            public string nombre { get; set; }


            public Catalogo() { }                   //CONSTRUCTOR VACIO

            public Catalogo(string codigo, string nombre)      //CONSTRUCTOR CON PARAMETROS
            {
                this.codigo = codigo;
                this.nombre = nombre;
            }
        } //class catalogo

        public class Producto
        {
            public string codigo { get; set; }       //ATRIBUTOS DEL OBJETO PRODUCTO
            public string nombre { get; set; }
            public string marca { get; set; }
            public double costo { get; set; }

            public Producto() { }                   //CONSTRUCTOR VACIO

            public Producto(string codigo, string nombre, string marca, double costo)      //CONSTRUCTOR CON PARAMETROS
            {
                this.codigo = codigo;
                this.nombre = nombre;
                this.marca = marca;
                this.costo = costo;
            }
        }

    }
}
