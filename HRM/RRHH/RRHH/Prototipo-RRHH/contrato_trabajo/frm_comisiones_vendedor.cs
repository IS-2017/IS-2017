using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FuncionesNavegador;
using System.Data.Odbc;
namespace contrato_trabajo
{
    public partial class frm_comisiones_vendedor : Form
    {
        #region Inicio - Cristian Estrada
        public frm_comisiones_vendedor()
        {
            InitializeComponent();
        }
        #endregion

        #region Variables - Cristian Estrada
        CapaNegocio fn = new CapaNegocio();
        String Codigo;
        Boolean Editar;
        String atributo;
       

        
        int id;
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
                dtp_fecha1.Enabled = false;
                dtp_fecha2.Enabled = false;
                btn_generar.Enabled = false;
                llenarcargo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                //dgv_comisiones.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Llenar combox de empresa - Cristian Estrada
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

        #region llenar cargo - Cristian Estrada
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

        #region Llenar combox de vendedor - Cristian Estrada
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

        #region Cargar de datos en el form - Cristian Estrada
        private void frm_comisiones_vendedor_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(gpb_com_ven);
            fn.InhabilitarComponentes(this);
            llenaridempresa();
            llenarcargo();
            llenarvendedor();
        }
        #endregion

        #region cambios de empresa en el combox - Cristian Estrada
        private void btn_emp_Click(object sender, EventArgs e)
        {
            cbo_empleado.Text = "  ";
            llenarvendedor();

        }
        
        private void cbo_empres_Click(object sender, EventArgs e)
        {
            
            
        }

        private void cbo_empres_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_empleado.Text = "  ";
            llenarvendedor();
        }
        #endregion

        #region radio de rango de fechas - Cristian Estrada
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dtp_fecha1.Enabled = true;
            dtp_fecha2.Enabled = true;
            btn_generar.Enabled = true;
        }
        #endregion

        #region Boton de generar- Cristian Estrada
        private void button1_Click(object sender, EventArgs e)
        {
            //dgv_comisiones.Rows.Clear();
            //dgv_comisiones.Refresh();

            //por_empleado();
            //factura();
            

            comision_total();
            comision();
            totales();
        }
        #endregion

        #region empleados - Cristian Estrada
        decimal porc_emp;

        
        public void por_empleado()
        {
            try {
                int cont1 = 0;
                string selectedItem2 = cbo_empleado.SelectedValue.ToString();
                OdbcConnection Conexion2;
                OdbcCommand Query = new OdbcCommand();
                OdbcDataReader consultar2;
                //string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
                string sql = "dsn=hotelsancarlos;server=localhost;database=hotelsancarlos;uid=root;password=";
                //string sql = "server = 127.0.0.1; database = hotelsancarlos; uid = root; pwd =; ";
                Conexion2 = new OdbcConnection();
                Conexion2.ConnectionString = sql;
                Conexion2.Open();
                Query.CommandText = "SELECT porcentaje From empleado where estado <> 'INACTIVO' AND id_empleado_pk = '" + selectedItem2 + "';";
                Query.Connection = Conexion2;
                consultar2 = Query.ExecuteReader();
                while (consultar2.Read())
                {

                    if (cont1 == 0)
                    {

                        porc_emp = consultar2.GetDecimal(0);
                        txt_comsx.Text = Convert.ToString(porc_emp);

                        //dataGridView1.Rows[0].Cells[2].Value = porc_emp;
                        // MessageBox.Show(Convert.ToString(id));
                    }
                    else
                    {

                        porc_emp = consultar2.GetDecimal(0);

                        //dataGridView1.Rows[cont1].Cells[2].Value = porc_emp;
                    }
                    cont1++;
                }
            }
            catch
            {

            }
        }
        #endregion

        #region datos de factura - Cristian Estrada

        #endregion

        #region calculos de comisiones - Cristian Estrada
        public void comision()
        {
            decimal totalcomision = 0;
            for (int fila = 0; fila < dataGridView1.RowCount - 1; fila++)
            {

                totalcomision += Convert.ToDecimal(dataGridView1.Rows[fila].Cells[3].Value);

            }

            txt_total_com.Text = Convert.ToString(totalcomision);
        }

        public void totales()
        {
            decimal totalventa = 0;
            for (int fila = 0; fila < dataGridView1.RowCount - 1; fila++)
            {

                totalventa += Convert.ToDecimal(dataGridView1.Rows[fila].Cells[1].Value);

            }
            txt_venta.Text = Convert.ToString(totalventa);
        }
        #endregion

        #region Guardar detalle de comision - Cristian Estrada
        public void guardar_detalle()
        {
            
                string selectedItem = cbo_empres.SelectedValue.ToString();
                string selectedItem2 = cbo_empleado.SelectedValue.ToString();
                txt_fecax.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                textBox8.Text = selectedItem;
                // textBox9.Text = selectedItem;
                txt_vnd.Text = selectedItem2;

                CapaNegocio fn = new CapaNegocio();
                TextBox[] textbox = { txt_total_com, txt_venta, txt_fecax, textBox8, txt_vnd };
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
                    fn.LimpiarComponentes(this);
                }
            
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try {
                for (int fila = 0; fila <dataGridView1.RowCount - 1; fila++)
                {
                    string selectedItem = cbo_empres.SelectedValue.ToString();
                    string selectedItem2 = cbo_empleado.SelectedValue.ToString();
                    txt_empsx.Text = selectedItem;
                    txt_id_fac_d.Text = Convert.ToString(dataGridView1.Rows[fila].Cells[0].Value);
                    txt_porc_c.Text = Convert.ToString(dataGridView1.Rows[fila].Cells[2].Value);
                    txt_tv.Text = Convert.ToString(dataGridView1.Rows[fila].Cells[1].Value);
                    txt_fecax.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    txt_tc.Text = Convert.ToString(dataGridView1.Rows[fila].Cells[3].Value);
                    txt_vnd.Text = selectedItem2;

                    CapaNegocio fn = new CapaNegocio();
                    TextBox[] textbox = { txt_empsx, txt_id_fac_d, txt_porc_c, txt_tv, txt_fecax, txt_tc, txt_vnd };
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

                           
                            fn.insertar(datos, tabla);
                           
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
        public void llenar1()
        {
            //try
            //{
            //    string tabla = "factura_encabezado";
            //    string date1 = dtp_fecha1.Value.ToString("yyyy-MM-dd");
            //    string date2 = dtp_fecha2.Value.ToString("yyyy-MM-dd");
            //    string selectedItem = cbo_empleado.SelectedValue.ToString();
            //    fn.ActualizarGrid(this.dataGridView1, "SELECT id_factura, total FROM factura_encabezado WHERE id_empleado_pk = '" + selectedItem + "' AND fecha BETWEEN '" + date1 + "' AND '" + date2 + "';", tabla);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

         
                string selectedItem2 = cbo_empleado.SelectedValue.ToString();
                string fecha2 = dtp_fecha2.Value.ToString("yyyy-MM-dd");
                string fecha1 = dtp_fecha1.Value.ToString("yyyy-MM-dd");
                ServiceReference1.Service1Client ar = new ServiceReference1.Service1Client();
                //ar.PruebaCristian2(selectedItem2, fecha1, fecha2);
                DataSet ds = ar.ObtenerVendedor(selectedItem2, fecha1, fecha2);
                dataGridView1.DataSource = ds.Tables[0];
           
        }
        public void columnaporcentaje()
        {


            DataGridViewTextBoxColumn dgv = new DataGridViewTextBoxColumn();
            dgv.HeaderText = "Porcentaje";
            dgv.Width = 100;
            dataGridView1.Columns.Add(dgv);
        }
        public void columnacomision()
        {


            DataGridViewTextBoxColumn dgv = new DataGridViewTextBoxColumn();
            dgv.HeaderText = "Comision";
            dgv.Width = 100;
            dataGridView1.Columns.Add(dgv);
        }
        public void llenarpor()
        {


            for (int fila = 0; fila < dataGridView1.RowCount - 1; fila++)
            {

                dataGridView1.Rows[fila].Cells[2].Value = txt_comsx.Text;

            }
        }
        public void comision_total()
        {
            decimal total_c = 0;
            for (int fila = 0; fila < dataGridView1.RowCount - 1; fila++)
            {
                total_c = Convert.ToDecimal(dataGridView1.Rows[fila].Cells[1].Value) * (Convert.ToDecimal(dataGridView1.Rows[fila].Cells[2].Value) / 100);
                dataGridView1.Rows[fila].Cells[3].Value = total_c;

            }

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            //try
            //{
            //    string selectedItem2 = cbo_empleado.SelectedValue.ToString();
            //    string fecha2 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            //    string fecha1 = dtp_fecha1.Value.ToString("yyyy-MM-dd");
            //    ServiceReference1.Service1Client ar = new ServiceReference1.Service1Client();
            //    ar.PruebaCristian2(selectedItem2, fecha1, fecha2);
            //    DataSet ds = ar.PruebaCristian3(selectedItem2, fecha2, fecha1);
            //    dataGridView1.DataSource = ds.Tables[0];
            //}
            //catch
            //{

            //}
            borracolumnas();
            llenar1();
            validar_factura();
            columnaporcentaje();
            columnacomision();
            por_empleado();
            llenarpor();

        }
        int contt = 1;
        public void borracolumnas()
        {
            //dgv_reclu.Columns.RemoveAt(4);
            int Total = int.Parse(dataGridView1.ColumnCount.ToString());
            //MessageBox.Show(Convert.ToString(Total));
            //int cont = 0;
            //for (int i = 0; i <= Total; i++)
            //{
            //    MessageBox.Show(Convert.ToString(i));
            //    dataGridView1.Columns.RemoveAt(i);
            //    cont++;
            //}


            if (contt > 1 && Total == 4)
            {
                dataGridView1.Columns.RemoveAt(3);
                dataGridView1.Columns.RemoveAt(2);

            }

        }
        private void cbo_empleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Total = int.Parse(dataGridView1.ColumnCount.ToString());
            if (contt > 1 && Total == 4)
            {

                borracolumnas();
                llenar1();
            }
            contt++;
        }
        public void validar_factura()
        {
            int id;
            OdbcConnection Conexion2;
            OdbcCommand Query2 = new OdbcCommand();
            OdbcDataReader consultar2;
            //string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
            string sql = "dsn=hotelsancarlos;server=localhost;database=hotelsancarlos;uid=root;password=";
            //string sql = "server = 127.0.0.1; database = hotelsancarlos; uid = root; pwd =; ";
            Conexion2 = new OdbcConnection();
            Conexion2.ConnectionString = sql;
            Conexion2.Open();
            Query2.CommandText = "SELECT id_fac_empresa_pk from com_venta where estado <>'INACTIVO';";
            Query2.Connection = Conexion2;
            consultar2 = Query2.ExecuteReader();
            while (consultar2.Read())
            {

                id = consultar2.GetInt32(0);
                for (int fila = 0; fila < dataGridView1.RowCount - 1; fila++)
                {
                    if (Convert.ToInt32(dataGridView1.Rows[fila].Cells[0].Value) == id)
                    {
                        int fil = dataGridView1.CurrentRow.Index;
                        dataGridView1.Rows.RemoveAt(fil);
                    }
                }
                // MessageBox.Show(Convert.ToString(cadena_act));
            }
        }
    }
}
