using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crm
{
    public class entidades
    {
        public class Producto
        {
            public string codigo { get; set; }       //ATRIBUTOS DEL OBJETO PRODUCTO
            public string nombre { get; set; }
            public Int32 existencia { get; set; }
            public string marca { get; set; }
            public double precio { get; set; }
            public DateTime ingreso { get; set; }
            public Int32 categoria { get; set; }

            public Producto() { }                   //CONSTRUCTOR VACIO

            public Producto(string codigo, string nombre, Int32 existencia, string marca, double precio, DateTime ingreso, Int32 categoria)      //CONSTRUCTOR CON PARAMETROS
            {
                this.codigo = codigo;
                this.nombre = nombre;
                this.existencia = existencia;
                this.marca = marca;
                this.precio = precio;
                this.ingreso = ingreso;
                this.categoria = categoria;
            }
        } //class producto

        public class Categoria
        {
            public string codigo { get; set; }       //ATRIBUTOS DEL OBJETO PERSONA
            public string nombre { get; set; }

            public Categoria() { }                   //CONSTRUCTOR VACIO

            public Categoria(string codigo, string nombre)      //CONSTRUCTOR CON PARAMETROS
            {
                this.codigo = codigo;
                this.nombre = nombre;
            }
        } //class categoria

        public class Bodega
        {
            public string codigo { get; set; }       //ATRIBUTOS DEL OBJETO BODEGA
            public string ubicacion { get; set; }
            public string tamanio { get; set; }

            public Bodega() { }                   //CONSTRUCTOR VACIO

            public Bodega(string codigo, string ubicacion, string tamanio)      //CONSTRUCTOR CON PARAMETROS
            {
                this.codigo = codigo;
                this.ubicacion = ubicacion;
                this.tamanio = tamanio;
            }
        } //class categoria
        public class Abono
        {
            public string id_abono { get; set; }       //ATRIBUTOS DEL OBJETO PERSONA
            public string id_factura { get; set; }
            //public string serie { get; set; }
            public string id_cliente { get; set; }
            public double saldo_factura { get; set; }
            public string forma_pago { get; set; }
            public double abono { get; set; }
            public string fecha { get; set; }

            public Abono() { }                   //CONSTRUCTOR VACIO

            public Abono(string id_abono, string id_factura, string id_cliente, double saldo_factura, string forma_pago, double abono, string fecha)      //CONSTRUCTOR CON PARAMETROS
            {
                this.id_abono = id_abono;
                this.id_factura = id_factura;
                //this.serie = serie;
                this.id_cliente = id_cliente;
                this.saldo_factura = saldo_factura;
                this.forma_pago = forma_pago;
                this.abono = abono;
                this.fecha = fecha;
            }
        } //class abono

        public class Cliente
        {
            public string nombres { get; set; }
            public DateTime fecha { get; set; }
            public string incidencia { get; set; }
            public string apellidos { get; set; }

            public Cliente() { }
            public Cliente(string nombres, string apellidos, string incidencias, DateTime fecha)
            {
                this.nombres = nombres;
                this.apellidos = apellidos;
                this.incidencia = incidencia;
                this.fecha = fecha;
            }
        }
        public class factura
        {
            public int id_factura { get; set; }
            public string nombre_cliente { get; set; }
            public string saldo_factura { get; set; }
            public string forma_pago { get; set; }
            public int id_cliente { get; set; }
            public factura() { }

            public factura(int id_factura, string nombre_cliente, string saldo_factura, string forma_pago, int id_cliente)
            {
                this.id_factura = id_factura;
                this.nombre_cliente = nombre_cliente;
                this.saldo_factura = saldo_factura;
                this.forma_pago = forma_pago;
                this.id_cliente = id_cliente;
            }
        }
    }
}
