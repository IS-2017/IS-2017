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
    public partial class frm_factura : Form
    {
        public frm_factura()
        {
            InitializeComponent();
        }
        CapaNegocio fn = new CapaNegocio();
        String Codigo;
        Boolean Editar;
        String atributo;

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


        public void llenarempresa()
        {
            Conexion.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql=
            String Query = "select id_empresa_pk, nombre_empresa FROM empresa where estado <> 'INACTIVO' ";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexion.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "empresa");
            cbo_empre.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_empre.ValueMember = ("id_empresa_pk");
            //se indica el valor a desplegar en el combobox
            cbo_empre.DisplayMember = ("nombre_empresa");
            Conexion.Desconectar();
        }

        public void llenarpedido()
        {
            Conexion.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql=
            String Query = "select DISTINCT nombre FROM pedido where marca <> 'X' ";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexion.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "pedido");
            cbo_pedido.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_pedido.ValueMember = ("nombre");
            //se indica el valor a desplegar en el combobox
            cbo_pedido.DisplayMember = ("nombre");
            Conexion.Desconectar();
        }



        private void frm_factura_Load(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToShortTimeString();
            fn.InhabilitarComponentes(groupBox1);
            llenarempresa();
            llenarpedido();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void llenar()
        {
            int cont1 = 0;
            string selectedItem = cbo_pedido.SelectedValue.ToString();
            int cant = 0;
            int cadena;
            OdbcConnection Conexion2;
            OdbcCommand Query2 = new OdbcCommand();
            OdbcDataReader consultar2;
            //string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
            string sql = "dsn=hotelsancarlos;server=localhost;database=hotelsancarlos;uid=root;password=";
            //string sql = "server = 127.0.0.1; database = hotelsancarlos; uid = root; pwd =; ";
            Conexion2 = new OdbcConnection();
            Conexion2.ConnectionString = sql;
            Conexion2.Open();
            Query2.CommandText = "SELECT cantidad, id_producto_pk FROM pedido Where nombre = '" + cbo_pedido.Text + "' ;";
            Query2.Connection = Conexion2;
            consultar2 = Query2.ExecuteReader();
            while (consultar2.Read())
            {


                dataGridView1.Rows.Add(1);
                if (cont1 == 0)
                {

                    cant = consultar2.GetInt32(0);
                    cadena = consultar2.GetInt32(1);
                    //MessageBox.Show(Convert.ToString(cadena2));
                    dataGridView1.Rows[0].Cells[2].Value = cant;
                    dataGridView1.Rows[0].Cells[0].Value = cadena;
                }
                else
                {

                    cant = consultar2.GetInt32(0);
                    cadena = consultar2.GetInt32(1);
                    //MessageBox.Show(Convert.ToString(cadena2));
                    dataGridView1.Rows[cont1].Cells[2].Value = cant;
                    dataGridView1.Rows[cont1].Cells[0].Value = cadena;
                }
                cont1 = cont1 + 1;
                // MessageBox.Show(Convert.ToString(cadena_act));
            }
        }

        public void llenarproducto()
        {
            int cont1 = 0;
            for (int fila = 0; fila < dataGridView1.RowCount; fila++)
            {
                int ca = Convert.ToInt32(dataGridView1.Rows[fila].Cells[0].Value);
                string producto;
                OdbcCommand Query = new OdbcCommand();
                OdbcConnection Conexion;
                OdbcDataReader consultar;
                //string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
                string sql = "dsn=hotelsancarlos;server=localhost;database=hotelsancarlos;uid=root;password=";
                //string sql = "server = 127.0.0.1; database = hotelsancarlos; uid = root; pwd =; ";
                Conexion = new OdbcConnection();
                Conexion.ConnectionString = sql;
                Conexion.Open();
                Query.CommandText = "SELECT nombre_producto From producto where id_producto_pk ='" + Convert.ToString(ca) + "';";
                Query.Connection = Conexion;
                consultar = Query.ExecuteReader();

                while (consultar.Read())
                {
                    if (cont1 == 0)
                    {

                        producto = consultar.GetString(0);
                        
                        //MessageBox.Show(Convert.ToString(cadena2));
                        dataGridView1.Rows[0].Cells[1].Value = producto;
                       
                    }
                    else
                    {

                        producto = consultar.GetString(0);

                        //MessageBox.Show(Convert.ToString(cadena2));
                        dataGridView1.Rows[cont1].Cells[1].Value = producto;
                    }
                    cont1 = cont1 + 1;
                }
            }
        }

        public void llenarprecio()
        {
            int cont1 = 0;
            for (int fila = 0; fila < dataGridView1.RowCount ; fila++)
            {
                int ca = Convert.ToInt32(dataGridView1.Rows[fila].Cells[0].Value);
                decimal precio;
                OdbcCommand Query = new OdbcCommand();
                OdbcConnection Conexion;
                OdbcDataReader consultar;
                //string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
                string sql = "dsn=hotelsancarlos;server=localhost;database=hotelsancarlos;uid=root;password=";
                //string sql = "server = 127.0.0.1; database = hotelsancarlos; uid = root; pwd =; ";
                Conexion = new OdbcConnection();
                Conexion.ConnectionString = sql;
                Conexion.Open();
                Query.CommandText = "SELECT DISTINCT P.precio FROM precio P, bien B, producto Pr Where B.id_producto_pk = '" + ca + "' AND P.id_inventario_pk = B.id_inventario_pk AND P.estado <> 'INACTIVO'; ";
                Query.Connection = Conexion;
                consultar = Query.ExecuteReader();

                while (consultar.Read())
                {
                    if (cont1 == 0)
                    {

                        precio = consultar.GetDecimal(0);

                        //MessageBox.Show(Convert.ToString(cadena2));
                        dataGridView1.Rows[0].Cells[3].Value = precio;

                    }
                    else
                    {

                        precio = consultar.GetDecimal(0);

                        //MessageBox.Show(Convert.ToString(cadena2));
                        dataGridView1.Rows[cont1].Cells[3].Value = precio;
                    }
                    cont1 = cont1 + 1;
                }
            }
        }
        private void cbo_pedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            llenar();
            llenarproducto();
            llenarprecio();
            subtotal();
            venta_total();
        }

        public void subtotal()
        {
            decimal subtotal = 0;
            for (int fila = 0; fila < dataGridView1.RowCount - 1; fila++)
            {
                subtotal = Convert.ToDecimal(dataGridView1.Rows[fila].Cells[2].Value) * Convert.ToDecimal(dataGridView1.Rows[fila].Cells[3].Value);
                dataGridView1.Rows[fila].Cells[4].Value = subtotal;

            }
           

        }

        public void venta_total()
        {
            decimal venta_t = 0;
            for (int fila = 0; fila < dataGridView1.RowCount - 1; fila++)
            {

                venta_t += Convert.ToDecimal(dataGridView1.Rows[fila].Cells[4].Value);

            }
            txt_total.Text = Convert.ToString(venta_t);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        string cadena2;
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToShortTimeString();
            cadena2 = textBox1.Text;
            //for (int fila = 0; fila < dataGridView1.RowCount - 1; fila++)
            //{
                string selectedItem = cbo_empre.SelectedValue.ToString();
                txt_sub.Text = txt_total.Text;
                txt_fecha.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                txt_fechav.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                txt_emp.Text = selectedItem;
                CapaNegocio fn = new CapaNegocio();
                TextBox[] textbox = { textBox1, txt_total,txt_sub, txt_fecha, txt_fechav, txt_emp};
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    //MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "factura";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);
                    }
                    else
                    {

                        
                        fn.insertar(datos, tabla);
                        marca();
                        inventario();

                    }
                    fn.LimpiarComponentes(this);
                }
            //}

            
        }
       
        public void marca()
        {
            int cont1 = 0;
            string producto;
            OdbcCommand Query = new OdbcCommand();
            OdbcConnection Conexion;
            OdbcDataReader consultar;
            //string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
            string sql = "dsn=hotelsancarlos;server=localhost;database=hotelsancarlos;uid=root;password=";
            //string sql = "server = 127.0.0.1; database = hotelsancarlos; uid = root; pwd =; ";
            Conexion = new OdbcConnection();
            Conexion.ConnectionString = sql;
            Conexion.Open();
            Query.CommandText = "SELECT id_pedido_pk From pedido where nombre ='" + cbo_pedido.Text + "';";
            Query.Connection = Conexion;
            consultar = Query.ExecuteReader();

            while (consultar.Read())
            {
                txt_marca.Text = "X";

                atributo = "id_pedido_pk";
                string tabla2 = "pedido";
                
                Codigo = Convert.ToString(consultar.GetInt32(0));
                
                //CapaNegocio fn = new CapaNegocio();
                TextBox[] textbox2 = { txt_marca };
                DataTable datos2 = fn.construirDataTable(textbox2);
                fn.modificar(datos2, tabla2, atributo, Codigo);
            }
        }
        public void inventario()
        {
            int cont1 = 0;
            int total_inve = 0;
            for (int fila = 0; fila < dataGridView1.RowCount; fila++)
            {
                int ca = Convert.ToInt32(dataGridView1.Rows[fila].Cells[0].Value);
                string producto;
                int cantidad = 0;
                OdbcCommand Query = new OdbcCommand();
                OdbcConnection Conexion;
                OdbcDataReader consultar;
                //string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
                string sql = "dsn=hotelsancarlos;server=localhost;database=hotelsancarlos;uid=root;password=";
                //string sql = "server = 127.0.0.1; database = hotelsancarlos; uid = root; pwd =; ";
                Conexion = new OdbcConnection();
                Conexion.ConnectionString = sql;
                Conexion.Open();
                Query.CommandText = "SELECT cantidad From bien where id_producto_pk ='" + Convert.ToString(ca) + "';";
                Query.Connection = Conexion;
                consultar = Query.ExecuteReader();

                while (consultar.Read())
                {
                    cantidad = consultar.GetInt32(0);
                    total_inve = Convert.ToInt32(cantidad) - Convert.ToInt32(dataGridView1.Rows[fila].Cells[2].Value);
                    txt_inventa.Text = Convert.ToString(total_inve);
                    atributo = "id_producto_pk";
                    string tabla2 = "bien";
                    Codigo = Convert.ToString(ca);
                    //CapaNegocio fn = new CapaNegocio();
                    TextBox[] textbox2 = { txt_inventa };
                    DataTable datos2 = fn.construirDataTable(textbox2);
                    fn.modificar(datos2, tabla2, atributo, Codigo);
                }
            }
        }

        
        
    }
}
