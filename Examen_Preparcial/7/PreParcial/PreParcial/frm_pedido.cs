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
using System.Data.Odbc;

namespace PreParcial
{
    public partial class frm_pedido : Form
    {
        public frm_pedido()
        {
            InitializeComponent();
        }
        CapaNegocio fn = new CapaNegocio();
        String Codigo;
        Boolean Editar;
        String atributo;

        public void llenarproducto()
        {
            Conexion.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql=
            String Query = "select id_producto_pk, nombre_producto FROM producto where estado <> 'INACTIVO' ";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexion.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "producto");
            cbo_pro.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_pro.ValueMember = ("id_producto_pk");
            //se indica el valor a desplegar en el combobox
            cbo_pro.DisplayMember = ("nombre_producto");
            Conexion.Desconectar();

        }

        public void llenarcliente()
        {
            Conexion.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql=
            String Query = "select id_cliente_pk, nombre FROM cliente where estado <> 'INACTIVO' ";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexion.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "cliente");
            cbo_cl.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_cl.ValueMember = ("id_cliente_pk");
            //se indica el valor a desplegar en el combobox
            cbo_cl.DisplayMember = ("nombre");
            Conexion.Desconectar();

        }
        /*
        public void llenarcantidad()
        {
            string selectedItem = cbo_pro.SelectedValue.ToString();
            Conexion.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql=
            String Query = "select id_inventario_pk, cantidad FROM bien where id_producto_pk = '" + selectedItem + "' and estado <> 'INACTIVO' ";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexion.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "bien");
            cbo_cant.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_cant.ValueMember = ("id_inventario_pk");
            //se indica el valor a desplegar en el combobox
            cbo_cant.DisplayMember = ("cantidad");
            Conexion.Desconectar();

        }*/

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.ActivarControles(groupBox1);
                fn.LimpiarComponentes(groupBox1);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            for (int fila = 0; fila < dataGridView1.RowCount - 1; fila++)
            {
                string selectedItem = cbo_pro.SelectedValue.ToString();
                txt_pro.Text = Convert.ToString(dataGridView1.Rows[fila].Cells[0].Value);
                string selectedItem2 = cbo_cl.SelectedValue.ToString();
                txt_cliente.Text = selectedItem2;
                txt_d.Text = Convert.ToString(dataGridView1.Rows[fila].Cells[4].Value);
                txt_c.Text = Convert.ToString(dataGridView1.Rows[fila].Cells[3].Value);

                CapaNegocio fn = new CapaNegocio();
                TextBox[] textbox = { txt_d, txt_c,txt_cliente,txt_pro, txt_pedido};
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    //MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "pedido";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);
                    }
                    else
                    {

                       
                        fn.insertar(datos, tabla);
                      

                    }
                   // fn.LimpiarComponentes(this);
                }
            }
            dataGridView1.Rows.Clear();
        }
        int cont = 0;
        public void llenar()
        {
            string selectedItem = cbo_pro.SelectedValue.ToString();
            OdbcConnection Conexion2;
            OdbcCommand Query2 = new OdbcCommand();
            OdbcDataReader consultar2;
            //string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
            string sql = "dsn=hotelsancarlos;server=localhost;database=hotelsancarlos;uid=root;password=";
            //string sql = "server = 127.0.0.1; database = hotelsancarlos; uid = root; pwd =; ";
            Conexion2 = new OdbcConnection();
            Conexion2.ConnectionString = sql;
            Conexion2.Open();
            Query2.CommandText = "SELECT P.precio FROM precio P, bien B, producto Pr Where B.id_producto_pk = '" + selectedItem + "' AND P.id_inventario_pk = B.id_inventario_pk AND P.estado <>'INACTIVO';";
            Query2.Connection = Conexion2;
            consultar2 = Query2.ExecuteReader();
            while (consultar2.Read())
            {


                dataGridView1.Rows[cont].Cells[2].Value = Convert.ToString(consultar2.GetDecimal(0));
                // MessageBox.Show(Convert.ToString(cadena_act));
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            disp();
            
            //fn.LimpiarComponentes(groupBox1);
            
        }

        private void frm_pedido_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(groupBox1);
            llenarcliente();
            llenarproducto();
            //llenarcantidad();
        }

        public void disponibilidad()
        {
            int id = 0;
            string selectedItem = cbo_pro.SelectedValue.ToString();
            OdbcConnection Conexion2;
            OdbcCommand Query2 = new OdbcCommand();
            OdbcDataReader consultar2;
            //string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
            string sql = "dsn=hotelsancarlos;server=localhost;database=hotelsancarlos;uid=root;password=";
            //string sql = "server = 127.0.0.1; database = hotelsancarlos; uid = root; pwd =; ";
            Conexion2 = new OdbcConnection();
            Conexion2.ConnectionString = sql;
            Conexion2.Open();
            Query2.CommandText = "Select B.cantidad FROM bien B, producto PR where B.id_producto_pk = '" + selectedItem + "' and PR.estado <>'INACTIVO';";
            Query2.Connection = Conexion2;
            consultar2 = Query2.ExecuteReader();
            while (consultar2.Read())
            {

                id = consultar2.GetInt32(0);
                txt_compara.Text = Convert.ToString(id);
                // MessageBox.Show(Convert.ToString(cadena_act));
            }
        }
       
        public void disp()
        {
            disponibilidad();

            if (Convert.ToInt32(txt_ca.Text) > Convert.ToInt32(txt_compara.Text))
            {
                MessageBox.Show("CANTIDAD NO DISPONIBLE");

            }
            else
            {
                //MessageBox.Show("si");
                string c = txt_ca.Text;
                dataGridView1.Rows.Add(1);
                string selectedItem = cbo_pro.SelectedValue.ToString();
                dataGridView1.Rows[cont].Cells[0].Value = selectedItem;
                dataGridView1.Rows[cont].Cells[1].Value = cbo_pro.Text;
                llenar();

                dataGridView1.Rows[cont].Cells[3].Value = c;
                dataGridView1.Rows[cont].Cells[4].Value = txt_descr.Text;
                cont++;
                txt_ca.Text = "";
                txt_descr.Text = "";
            }
        }

        private void txt_ca_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
