using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using seguridad;
using System.Data.Odbc;
using FuncionesNavegador;

namespace proyecto_ventas
{
    public partial class frm_listadoprecio : Form
    {
        public frm_listadoprecio()
        {
            InitializeComponent();
            llenar_encabezado();
            llenar_tipo();
        }

        public void llenar_encabezado()
        {
            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.HeaderText = "Bien";
            c1.Width = 100;
            c1.ReadOnly = true;

            dgv_bien.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.HeaderText = "Costo";
            c2.Width = 50;
            c2.ReadOnly = true;

            dgv_bien.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.HeaderText = "Precio";
            c3.Width = 50;
            c3.ReadOnly = true;

            dgv_bien.Columns.Add(c3);

        }

        public void llenar_tipo()
        {
            cbo_catalogo.Items.Clear();
            string scad = "SELECT * FROM tipo_precio";
            OdbcCommand mcd = new OdbcCommand(scad, seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader mdr = mcd.ExecuteReader();

            while (mdr.Read())
            {

                cbo_catalogo.Items.Add(mdr.GetString(1));

            }
        }

        public void llenar_bien()
        {
            //OBTENIENDO ID DE CATALOGO DE PRECIOS
            dgv_bien.Rows.Clear();
            int codigo = 0;
            codigo = obtener();
            //LLENANDO DATAGRID CON BIENES Y SU PRECIO
            string scad = "SELECT producto.nombre_producto, producto.costo_producto, precio.precio FROM producto INNER JOIN precio ON producto.id_producto = precio.id_producto and precio.id_tprecio= " + codigo;
            OdbcCommand mcd = new OdbcCommand(scad, seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader mdr = mcd.ExecuteReader();

            while (mdr.Read())
            {

                dgv_bien.Rows.Add(mdr.GetString(0), mdr.GetDecimal(1), mdr.GetDecimal(2));

            }
        }

        public int obtener()
        {
            string scad2 = "SELECT id_tprecio from tipo_precio where tipo='" + cbo_catalogo.Text + "'";
            OdbcCommand mcd2 = new OdbcCommand(scad2, seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader mdr2 = mcd2.ExecuteReader();
            int codtipo = 0;

            while (mdr2.Read())
            {
                codtipo = mdr2.GetInt16(0);
            }
            return codtipo;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_precio1.Text))
                MessageBox.Show("Campo obligatorio vacío", "Campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else
            {
                int codigo = obtener();
                MessageBox.Show("Cambiando precio...");
                string scad = "select * from producto";
                OdbcCommand mcd = new OdbcCommand(scad, seguridad.Conexion.ObtenerConexionODBC());
                OdbcDataReader mdr = mcd.ExecuteReader();
                int j = 1;

                OdbcCommand mcd2 = new OdbcCommand("delete from precio where id_tprecio=(" + codigo + ")", seguridad.Conexion.ObtenerConexionODBC());
                OdbcDataReader mdr2 = mcd2.ExecuteReader();
                while (mdr.Read())
                {

                    float costo = Convert.ToInt32(mdr.GetDouble(3));
                    float costo2 = Convert.ToInt32(txt_precio1.Text);
                    float mult = costo * (costo2 / 100);
                    float total = mult + (Convert.ToInt32(costo));


                    OdbcCommand mcd1 = new OdbcCommand("insert into precio (precio, id_producto, id_tprecio) values(" + total + "," + j + "," + codigo + ")", seguridad.Conexion.ObtenerConexionODBC());
                    OdbcDataReader mdr1 = mcd1.ExecuteReader();
                    j++;
                    costo = 0;
                    costo2 = 0;
                    mult = 0;
                    total = 0;
                }
                MessageBox.Show("Precios modificados... presione Actualizar");
                //}else { MessageBox.Show("Debe ingresar un valor de ganancia"); }
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            llenar_bien();
        }

        private void frm_listadoprecio_Load(object sender, EventArgs e)
        {

        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
            fn.Anterior(dgv_bien);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
            fn.Siguiente(dgv_bien);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
            fn.Primero(dgv_bien);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
            fn.Ultimo(dgv_bien);
        }
    }
}
