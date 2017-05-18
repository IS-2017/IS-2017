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
using MySql.Data.MySqlClient;
using System.Data.Odbc;

namespace contrato_trabajo
{
    public partial class frm_comisiones_producto : Form
    {
        #region Inicio - Cristian Estrada
        public frm_comisiones_producto()
        {
            InitializeComponent();
        }
        #endregion

        #region Variables - Cristian Estrada
        CapaNegocio fn = new CapaNegocio();
        String Codigo;
        Boolean Editar;
        String atributo;
        int id_fact;
        decimal total;
        #endregion

        #region Boton Nuevo - Cristian Estrada
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.ActivarControles(gpb_com_ven);
                fn.LimpiarComponentes(gpb_com_ven);
                dateTimePicker2.Enabled = false;
                dateTimePicker3.Enabled = false;
                llenarcargo();
                btn_generar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Carga de datos al form - Cristian Estrada
        private void frm_comisiones_producto_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(gpb_com_ven);
            fn.InhabilitarComponentes(this);
            llenaridempresa();
            llenarcargo();
            llenarvendedor();
            dgv_comision.Columns[2].Visible = false;
            dgv_comision.Columns[1].Visible = false;
            dgv_comision.Columns[6].Visible = false;
        }
        #endregion

        #region Boton Cancelar - Cristian Estrada
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.LimpiarComponentes(gpb_com_ven);
                fn.InhabilitarComponentes(gpb_com_ven);
                dgv_comision.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region llenar combox empresa - Cristian Estrada
        private void llenaridempresa()
        {
            try {
                //se realiza la conexión a la base de datos
                Ayuda.ObtenerConexion();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_empresa_pk, nombre_empresa from empresa Where estado <>'INACTIVO'";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, Ayuda.ObtenerConexion());
                //se indica con quu tabla se llena
                dad.Fill(ds, "empresa");
                cbo_empres.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_empres.ValueMember = ("id_empresa_pk");
                //se indica el valor a desplegar en el combobox
                cbo_empres.DisplayMember = ("nombre_empresa");
                Ayuda.Desconectar();
            }
            catch
            {

            }
        }
        #endregion
        #region llenar cargo  - Cristian Estrada
        private void llenarcargo()
        {
            try {
                string cadena_id;
                OdbcConnection Conexion2;
                OdbcCommand Query2 = new OdbcCommand();
                OdbcDataReader consultar2;
                //string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
                string sql = "dsn=hotelsancarlos;server=localhost;database=hotelsancarlos;uid=root;password=";
                //string sql = "server = 127.0.0.1; database = hotelsancarlos; uid = root; pwd =; ";
                Conexion2 = new OdbcConnection();
                Conexion2.ConnectionString = sql;
                Conexion2.Open();
                Query2.CommandText = "SELECT id_puesto_laboral_pk from puesto_laboral where nombre_puesto ='VENDEDOR' AND estado <>'INACTIVO';";
                Query2.Connection = Conexion2;
                consultar2 = Query2.ExecuteReader();
                while (consultar2.Read())
                {

                    cadena_id = consultar2.GetString(0);
                    txt_id_puesto_lb.Text = cadena_id;
                    // MessageBox.Show(Convert.ToString(cadena_act));
                }
            }
            catch
            {

            }
        }
        #endregion

        #region llenar combox vendedor - Cristian Estrada
        private void llenarvendedor()
        {

            try {
                string selectedItem = cbo_empres.SelectedValue.ToString();

                //se realiza la conexión a la base de datos
                Ayuda.ObtenerConexion();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql=
                String Query = "select id_empleado_pk, nombre_emp, apellido_emp FROM empleado where id_empresa_pk ='" + selectedItem + "' AND estado <> 'INACTIVO' AND id_puesto_laboral_pk = '" + txt_id_puesto_lb.Text + "'";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, Ayuda.ObtenerConexion());
                //se indica con quu tabla se llena
                dad.Fill(ds, "empleado");
                cbo_empleado.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_empleado.ValueMember = ("id_empleado_pk");
                //se indica el valor a desplegar en el combobox
                cbo_empleado.DisplayMember = ("nombre_emp");
                Ayuda.Desconectar();
            }
            catch
            {

            }
        }
        #endregion

        #region Datos de factura - Cristian Estrada
        public void factura()
        {
            try {
                int cont1 = 0;
                //dataGridView1.Columns[1].Visible = false;
                string selectedItem = cbo_empres.SelectedValue.ToString();
                string selectedItem2 = cbo_empleado.SelectedValue.ToString();
                string date1 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                string date2 = dateTimePicker3.Value.ToString("yyyy-MM-dd");
                OdbcConnection Conexion2;
                OdbcCommand Query2 = new OdbcCommand();
                OdbcDataReader consultar2;
                //string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
                string sql = "dsn=hotelsancarlos;server=localhost;database=hotelsancarlos;uid=root;password=";
                //string sql = "server = 127.0.0.1; database = hotelsancarlos; uid = root; pwd =; ";
                Conexion2 = new OdbcConnection();
                Conexion2.ConnectionString = sql;
                Conexion2.Open();
                Query2.CommandText = "SELECT id_fac_empresa_pk,total From factura where id_empleado_pk = '" + selectedItem2 + "'And id_empresa_pk ='" + selectedItem + "' AND estado <> 'INACTIVO' AND marca_comision <>'S' AND fecha_emision BETWEEN '" + date1 + "' AND '" + date2 + "';";
                Query2.Connection = Conexion2;
                consultar2 = Query2.ExecuteReader();
                while (consultar2.Read())
                {
                    dgv_comision.Rows.Add(1);
                    if (cont1 == 0)
                    {
                        id_fact = consultar2.GetInt32(0);
                        total = consultar2.GetDecimal(1);
                        dgv_comision.Rows[0].Cells[0].Value = id_fact;
                        dgv_comision.Rows[0].Cells[1].Value = total;
                        // MessageBox.Show(Convert.ToString(id));
                    }
                    else
                    {

                        id_fact = consultar2.GetInt32(0);
                        total = consultar2.GetDecimal(1);
                        dgv_comision.Rows[cont1].Cells[0].Value = id_fact;
                        dgv_comision.Rows[cont1].Cells[1].Value = total;
                    }
                    cont1++;
                }
            }
            catch
            {

            }
        }

        int id_precio;
        int cantidad = 0;
        public void factura_detalle()
        {
            try {
                int cont1 = 0;

                for (int fila = 0; fila < dgv_comision.RowCount; fila++)
                {
                    int ca = Convert.ToInt32(dgv_comision.Rows[fila].Cells[0].Value);
                    string selectedItem = cbo_empres.SelectedValue.ToString();
                    string selectedItem2 = cbo_empleado.SelectedValue.ToString();
                    OdbcCommand Query = new OdbcCommand();
                    OdbcConnection Conexion;
                    OdbcDataReader consultar;
                    //string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
                    string sql = "dsn=hotelsancarlos;server=localhost;database=hotelsancarlos;uid=root;password=";
                    //string sql = "server = 127.0.0.1; database = hotelsancarlos; uid = root; pwd =; ";
                    Conexion = new OdbcConnection();
                    Conexion.ConnectionString = sql;
                    Conexion.Open();
                    Query.CommandText = "SELECT id_precio, cantidad From factura_detalle where id_fac_empresa_pk ='" + Convert.ToString(ca) + "';";
                    Query.Connection = Conexion;
                    consultar = Query.ExecuteReader();

                    while (consultar.Read())
                    {
                        if (cont1 == 0)
                        {

                            id_precio = consultar.GetInt32(0);
                            cantidad = consultar.GetInt32(1);
                            //MessageBox.Show(Convert.ToString(cadena2));
                            dgv_comision.Rows[0].Cells[2].Value = id_precio;
                            dgv_comision.Rows[0].Cells[5].Value = cantidad;
                        }
                        else
                        {

                            id_precio = consultar.GetInt32(0);
                            cantidad = consultar.GetInt32(1);
                            //MessageBox.Show(Convert.ToString(cadena2));
                            dgv_comision.Rows[cont1].Cells[2].Value = id_precio;
                            dgv_comision.Rows[cont1].Cells[5].Value = cantidad;
                        }
                        cont1 = cont1 + 1;
                    }
                }
            }
            catch
            {

            }
        }
        #endregion

        #region datos de precio - Cristian Estrada
        decimal precio_pro = 0;
        int id_bien = 0;

        public void precio()
        {
            try {
                int cont1 = 0;

                for (int fila = 0; fila < dgv_comision.RowCount; fila++)
                {
                    int ca = Convert.ToInt32(dgv_comision.Rows[fila].Cells[2].Value);

                    OdbcCommand Query = new OdbcCommand();
                    OdbcConnection Conexion;
                    OdbcDataReader consultar;
                    //string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
                    string sql = "dsn=hotelsancarlos;server=localhost;database=hotelsancarlos;uid=root;password=";
                    //string sql = "server = 127.0.0.1; database = hotelsancarlos; uid = root; pwd =; ";
                    Conexion = new OdbcConnection();
                    Conexion.ConnectionString = sql;
                    Conexion.Open();
                    Query.CommandText = "SELECT precio, id_bien_pk From precio where id_precio ='" + Convert.ToString(ca) + "';";
                    Query.Connection = Conexion;
                    consultar = Query.ExecuteReader();

                    while (consultar.Read())
                    {
                        if (cont1 == 0)
                        {

                            precio_pro = consultar.GetDecimal(0);
                            id_bien = consultar.GetInt32(1);
                            //MessageBox.Show(Convert.ToString(id_bien));
                            dgv_comision.Rows[0].Cells[4].Value = precio_pro;
                            dgv_comision.Rows[0].Cells[6].Value = id_bien;
                        }
                        else
                        {

                            precio_pro = consultar.GetDecimal(0);
                            id_bien = consultar.GetInt32(1);
                            // MessageBox.Show(Convert.ToString(id_bien));
                            dgv_comision.Rows[cont1].Cells[4].Value = precio_pro;
                            dgv_comision.Rows[cont1].Cells[6].Value = id_bien;
                        }
                        cont1 = cont1 + 1;
                    }
                }
            }
            catch
            {

            }
        }
        #endregion

        #region datos del producto - Cristian Estrada
        decimal proce_pro = 0;
        string descrp;
        public void bien()
        {

            int cont1 = 0;

            for (int fila = 0; fila < dgv_comision.RowCount; fila++)
            {
                int ca = Convert.ToInt32(dgv_comision.Rows[fila].Cells[6].Value);

                OdbcCommand Query = new OdbcCommand();
                OdbcConnection Conexion;
                OdbcDataReader consultar;
                //string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
				string sql = "dsn=hotelsancarlos;server=localhost;database=hotelsancarlos;uid=root;password=";
                //string sql = "server = 127.0.0.1; database = hotelsancarlos; uid = root; pwd =; ";
                Conexion = new OdbcConnection();
                Conexion.ConnectionString = sql;
                Conexion.Open();

                Query.CommandText = "SELECT descripcion, porcentaje_comision From bien where id_bien_pk ='" + Convert.ToString(ca) + "';";
                Query.Connection = Conexion;
                consultar = Query.ExecuteReader();

                while (consultar.Read())
                {
                    if (cont1 == 0)
                    {

                        descrp = consultar.GetString(0);
                        proce_pro = consultar.GetDecimal(1);
                        dgv_comision.Rows[0].Cells[3].Value = descrp;
                        //MessageBox.Show(Convert.ToString(precio_pro));
                        dgv_comision.Rows[0].Cells[7].Value = proce_pro;

                    }
                    else
                    {
                        descrp = consultar.GetString(0);
                        proce_pro = consultar.GetDecimal(1);
                        dgv_comision.Rows[cont1].Cells[3].Value = descrp;
                        //MessageBox.Show(Convert.ToString(precio_pro));
                        dgv_comision.Rows[cont1].Cells[7].Value = proce_pro;

                    }
                    cont1 = cont1 + 1;
                }
            }
        }
        #endregion

        #region Calculos de la comisiones - Cristian Estrada
        public void comision()
        {

            decimal total_comision = 0;
            for (int fila = 0; fila < dgv_comision.RowCount - 1; fila++)
            {

                total_comision = Convert.ToDecimal(dgv_comision.Rows[fila].Cells[8].Value) * ((Convert.ToDecimal(dgv_comision.Rows[fila].Cells[7].Value) / 100));
                dgv_comision.Rows[fila].Cells[9].Value = total_comision;
            }

        }

        public void totales()
        {
            decimal total_venta = 0;

            for (int fila = 0; fila < dgv_comision.RowCount - 1; fila++)
            {

                total_venta = Convert.ToDecimal(dgv_comision.Rows[fila].Cells[4].Value) * Convert.ToDecimal(dgv_comision.Rows[fila].Cells[5].Value);
                dgv_comision.Rows[fila].Cells[8].Value = total_venta;
            }

            //txt_total_com.Text = Convert.ToString(total_comi);
            //txt_venta.Text = Convert.ToString(total_venta);

        }
        public void comision_total()
        {
            decimal comision_t = 0;
            for (int fila = 0; fila < dgv_comision.RowCount - 1; fila++)
            {

                comision_t += Convert.ToDecimal(dgv_comision.Rows[fila].Cells[9].Value);

            }
            txt_total_com.Text = Convert.ToString(comision_t);

        }
        public void venta_total()
        {
            decimal venta_t = 0;
            for (int fila = 0; fila < dgv_comision.RowCount - 1; fila++)
            {

                venta_t += Convert.ToDecimal(dgv_comision.Rows[fila].Cells[8].Value);

            }
            txt_venta.Text = Convert.ToString(venta_t);
        }
        #endregion

        #region Boton de generar - Cristian Estrada
        private void button1_Click(object sender, EventArgs e)
        {
            dgv_comision.Rows.Clear();
            dgv_comision.Refresh();
            factura();
            factura_detalle();
            precio();
            bien();
            totales();
            comision();
            venta_total();
            comision_total();
        }
        #endregion

        #region Cambio de la emrpesa - Cristian Estrada
        private void cbo_empres_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_empleado.Text = "  ";
            llenarvendedor();
        }
        #endregion

        #region rango de fechas - Cristian Estrada
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Enabled = true;
            dateTimePicker3.Enabled = true;
            btn_generar.Enabled = true;
        }
        #endregion

        #region Guardar detalle de la comision - Cristian Estrada
        public void guardar_detalle()
        {
            string selectedItem = cbo_empres.SelectedValue.ToString();
            string selectedItem2 = cbo_empleado.SelectedValue.ToString();
            textBox5.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            textBox8.Text = selectedItem;
            textBox9.Text = selectedItem;
            textBox7.Text = selectedItem2;

            CapaNegocio fn = new CapaNegocio();
            TextBox[] textbox = { txt_total_com, txt_venta, textBox5, textBox8,  textBox7 };
            DataTable datos = fn.construirDataTable(textbox);
            if (datos.Rows.Count == 0)
            {
                //MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string tabla = "detalle_com_ventas";
                if (Editar)
                {
                    fn.modificar(datos, tabla, atributo, Codigo);
                }
                else
                {
                    fn.insertar(datos, tabla);
                }
                fn.LimpiarComponentes(gpb_com_ven);
                dgv_comision.Rows.Clear();
            }
        }
        #endregion

        #region Inicio - Cristian Estrada
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try {
                for (int fila = 0; fila < dgv_comision.RowCount - 1; fila++)
                {
                    string selectedItem = cbo_empres.SelectedValue.ToString();
                    string selectedItem2 = cbo_empleado.SelectedValue.ToString();
                    textBox1.Text = selectedItem;
                    txt_if_fac_de.Text = Convert.ToString(dgv_comision.Rows[fila].Cells[0].Value);
                    txt_por_com.Text = Convert.ToString(dgv_comision.Rows[fila].Cells[7].Value);
                    txt_tv.Text = Convert.ToString(dgv_comision.Rows[fila].Cells[8].Value);
                    textBox5.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    txt_tc.Text = Convert.ToString(dgv_comision.Rows[fila].Cells[9].Value);
                    textBox7.Text = selectedItem2;

                    CapaNegocio fn = new CapaNegocio();
                    TextBox[] textbox = { textBox1, txt_if_fac_de, txt_por_com, txt_tv, textBox5, txt_tc, textBox7 };
                    DataTable datos = fn.construirDataTable(textbox);
                    if (datos.Rows.Count == 0)
                    {
                        //MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string tabla = "com_venta";
                        if (Editar)
                        {
                            fn.modificar(datos, tabla, atributo, Codigo);
                        }
                        else
                        {

                            txt_mar_c.Text = "S";
                            fn.insertar(datos, tabla);
                            atributo = "id_fac_empresa_pk";
                            string tabla2 = "factura";
                            Codigo = txt_if_fac_de.Text;
                            //CapaNegocio fn = new CapaNegocio();
                            TextBox[] textbox2 = { txt_mar_c };
                            DataTable datos2 = fn.construirDataTable(textbox2);
                            fn.modificar(datos2, tabla2, atributo, Codigo);

                        }
                        fn.LimpiarComponentes(this);
                    }
                }

                guardar_detalle();
            }
            catch
            {

            }
        }
        #endregion

        private void cbo_empleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_comision.Rows.Clear();
        }
    }
}
