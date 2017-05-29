using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuncionesNavegador;
using MySql.Data.MySqlClient;
using System.Data.Odbc;
using System.Windows.Forms;

namespace contrato_trabajo
{
    public partial class frm_capacitaciones : Form
    {
        #region Variables Globales - Cristian Estrada
        OdbcConnection con = new OdbcConnection("dsn=hotelsancarlos;server=localhost;database=hotelsancarlos;uid=root;password=");
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        Boolean Editar = false;
        String Codigo;
        String atributo;
        DataGridView data;
        string mega = "X";
        string global_ubicacion;
        string global_empre;
        #endregion

        #region Cargar datos al form - Cristian Estrada
        public frm_capacitaciones(DataGridView dt, string actividad, string objetivo, string recurso, string fecha_inicio, string fecha_fin, string horario_inicio, string horario_fin, string ubicacion, string id_emps, bool Editar1)
        {
            try {
                this.data = dt;
                this.Editar = Editar1;
                atributo = "id_capacitacion_pk";
                //this.Codigo = id_capacitacion_pk;
                InitializeComponent();
                this.txt_act.Text = actividad;
                this.txt_obj.Text = objetivo;
                this.txt_recu.Text = recurso;
                this.txt_finicio.Text = fecha_inicio; dateTimePicker1.Text = txt_finicio.Text;
                this.txt_ffin.Text = fecha_fin; dateTimePicker2.Text = txt_ffin.Text;
                this.cbo_hin.Text = horario_inicio;
                this.cbo_hfin.Text = horario_fin;
                global_ubicacion = ubicacion;
                global_empre = id_emps;
                //MessageBox.Show(Convert.ToString(ubicacion));
                //MessageBox.Show(Convert.ToString(id_emps));

                llenaridempresa();
                nivel();
                llenarempleados(actividad);
                llenar(ubicacion);
                llenar2(id_emps);
            }
            catch
            {

            }


        }
        #endregion

        #region llenar combox empresa - Cristian Estrada
        private void llenaridempresa()
        {

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
        #endregion

        #region llenar ubicacion actual - Cristian Estrada
        public void llenar(string ubicar)
        {
            string ubi;
            OdbcConnection Conexion2;
            OdbcCommand Query2 = new OdbcCommand();
            OdbcDataReader consultar2;
            //string selectedItem = cbo_empres.SelectedValue.ToString();
            //string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
            string sql = "dsn=hotelsancarlos;server=localhost;database=hotelsancarlos;uid=root;password=";
            //string sql = "server = 127.0.0.1; database = hotelsancarlos; uid = root; pwd =; ";
            Conexion2 = new OdbcConnection();
            Conexion2.ConnectionString = sql;
            Conexion2.Open();
            Query2.CommandText = "select  nombre_ubi from ubicacion where id_ubicacion_pk = '" + ubicar + "'";
            Query2.Connection = Conexion2;
            consultar2 = Query2.ExecuteReader();
            while (consultar2.Read())
            {

                ubi = consultar2.GetString(0);
                cbo_ubi.Text = ubi;
                
               // MessageBox.Show(Convert.ToString(ubi));
            }
        }
        #endregion

        #region llenar empleados actuales - Cristian Estrada
        public void llenar2(string empres)
        {

            string empr;
            OdbcConnection Conexion2;
            OdbcCommand Query2 = new OdbcCommand();
            OdbcDataReader consultar2;
            //string selectedItem = cbo_empres.SelectedValue.ToString();
            //string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
            string sql = "dsn=hotelsancarlos;server=localhost;database=hotelsancarlos;uid=root;password=";
            //string sql = "server = 127.0.0.1; database = hotelsancarlos; uid = root; pwd =; ";
            Conexion2 = new OdbcConnection();
            Conexion2.ConnectionString = sql;
            Conexion2.Open();
            Query2.CommandText = "select nombre_empresa from empresa where id_empresa_pk = '" + empres + "'";
            Query2.Connection = Conexion2;
            consultar2 = Query2.ExecuteReader();
            while (consultar2.Read())
            {

                empr = consultar2.GetString(0);
                cbo_empres.Text = empr;

                //MessageBox.Show(Convert.ToString(empr));
            }
        }
        #endregion

        #region llenar combox empleado - Cristian Estrada
        public void llenarempleados(string act)
        {
            string cadena_act;
            OdbcConnection Conexion2;
            OdbcCommand Query2 = new OdbcCommand();
            OdbcDataReader consultar2;
            //string selectedItem = cbo_empres.SelectedValue.ToString();
            //string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
            string sql = "dsn=hotelsancarlos;server=localhost;database=hotelsancarlos;uid=root;password=";
            //string sql = "server = 127.0.0.1; database = hotelsancarlos; uid = root; pwd =; ";
            Conexion2 = new OdbcConnection();
            Conexion2.ConnectionString = sql;
            Conexion2.Open();
            Query2.CommandText = "SELECT id_empleado_pk from capacitacion where actividad = '" + act + "' AND estado <>'INACTIVO' and marca <>'S' ;";
            Query2.Connection = Conexion2;
            consultar2 = Query2.ExecuteReader();
            while (consultar2.Read())
            {

                cadena_act = consultar2.GetString(0);
                empleado(cadena_act);
               // MessageBox.Show(Convert.ToString(cadena_act));
            }
        }
        #endregion

        #region treeview empleados - Cristian Estrada
        public void empleado(string x)
        {
            //MessageBox.Show(Convert.ToString(x));
            foreach (TreeNode n in treeView1.Nodes)
            {

                foreach (TreeNode n_child in n.Nodes)
                {
                    string value2 = n_child.Tag.ToString();
                   // MessageBox.Show(Convert.ToString(value2));
                    txt_emple.Text = value2;
                    if (value2 == x)
                    {
                        n_child.Checked = true;
                    }
                }
            }
        }
        #endregion

        #region llenar ubicacion combox - Cristian Estrada
        public void llenarubicacion()
        {
            Ayuda.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select id_ubicacion_pk, nombre_ubi from ubicacion";
            //OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexionmysql.ObtenerConexion());
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Ayuda.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "ubicacion");
            cbo_ubi.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_ubi.ValueMember = ("id_ubicacion_pk");
            //se indica el valor a desplegar en el combobox
            cbo_ubi.DisplayMember = ("nombre_ubi");
            Ayuda.Desconectar();
        }
        #endregion

        #region lista de areas de trabajo - Cristian Estrada

        public void nivel()
        {
            DataTable dt = new DataTable();
            OdbcDataAdapter da = new OdbcDataAdapter("SELECT * FROM area_trabajo where estado <> 'INACTIVO'", con);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                TreeNode parent = new TreeNode(dr["puesto"].ToString());
                string value = dr["id_area_trabajo_pk"].ToString();
                parent.Tag = dr["id_area_trabajo_pk"].ToString();
                //MessageBox.Show(value);
                parent.Expand();
                treeView1.Nodes.Add(parent);
                sublevel(parent, value);
            }
        }
        #endregion

        #region listar los empleados de las areas - Cristian Estrada

        public void sublevel(TreeNode parent, string value)
        {
            DataTable dt = new DataTable();
            string selectedItem = cbo_empres.SelectedValue.ToString();
            OdbcDataAdapter da = new OdbcDataAdapter("SELECT * FROM empleado where id_empresa_pk ='" + selectedItem + "' AND id_area_trabajo_pk = '" + value + "'", con);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                TreeNode child = new TreeNode(dr["nombre_emp"].ToString().Trim() + ' ' + dr["apellido_emp"].ToString().Trim());
                child.Tag = dr["id_empleado_pk"].ToString();
                string temp = dr["id_area_trabajo_pk"].ToString();
                // string value = dr["id_area_pk"].ToString();
                // MessageBox.Show(temp);
                child.Collapse();
                parent.Nodes.Add(child);
                // sublevel(child, temp);

            }
        }
        #endregion

        #region Boton Nuevo - Cristian Estrada
        private void btn_nuevo_Click(object sender, EventArgs e)
        {

            try
            {
                Editar = false;
                fn.ActivarControles(gpb_cap);
                fn.LimpiarComponentes(gpb_cap);
                treeView1.Enabled = true;
                foreach (TreeNode n in treeView1.Nodes)
                {
                    n.Checked = false;

                    foreach (TreeNode n_child in n.Nodes)
                    {
                        n_child.Checked = false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Carga de los datos - Cristian Estrada
        private void frm_capacitaciones_Load(object sender, EventArgs e)
        {
            llenaridempresa();
            //nivel();
            llenarubicacion();
            llenar(global_ubicacion);
            llenar2(global_empre);
            treeView1.Enabled = false;
            fn.InhabilitarComponentes(gpb_cap);

        }
        #endregion

        #region Boton Cancelar - Cristian Estrada
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.LimpiarComponentes(gpb_cap);
                fn.InhabilitarComponentes(gpb_cap);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Guardar - Cristian Estrada
        public void guardar()
        {
            try {
                foreach (TreeNode n in treeView1.Nodes)
                {
                    foreach (TreeNode n_child in n.Nodes)
                    {

                        if (n_child.Checked == true)
                        {

                            string selectItem = cbo_ubi.SelectedValue.ToString();
                            string selectItem2 = cbo_hin.Text.ToString();
                            string selectItem3 = cbo_hfin.Text.ToString();
                            string selectItem4 = cbo_empres.SelectedValue.ToString();
                            //n_child.Checked = false;
                            string value = n.Tag.ToString();
                            string value2 = n_child.Tag.ToString();

                            //txt_area.Text = value;
                            txt_emple.Text = value2;
                            txt_finicio.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                            txt_ffin.Text = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                            txt_ubi.Text = selectItem;
                            txt_hinicio.Text = selectItem2;
                            txt_hfin.Text = selectItem3;
                            txt_empresa.Text = selectItem4;

                            CapaNegocio fn = new CapaNegocio();
                            TextBox[] textbox = { txt_act, txt_emple, txt_ffin, txt_finicio, txt_hfin, txt_hinicio, txt_obj, txt_recu, txt_ubi, txt_empresa };
                            DataTable datos = fn.construirDataTable(textbox);
                            if (datos.Rows.Count == 0)
                            {
                                //MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string tabla = "capacitacion";
                                if (Editar)
                                {
                                    modificar();
                                    guardar_modificar();
                                    llenarempleados(txt_act.Text);
                                    fn.LimpiarComponentes(gpb_cap);
                                    fn.InhabilitarComponentes(gpb_cap);
                                    //fn.modificar(datos, tabla, atributo, Codigo);
                                }
                                else
                                {

                                    fn.insertar(datos, tabla);

                                }


                            }
                        }
                    }
                }

                fn.LimpiarComponentes(gpb_cap);
            }
            catch
            {

            }
        }
        #endregion

        #region Boton Guardar - Cristian Estrada
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateTimePicker1.Value == dateTimePicker2.Value)
                {
                    //MessageBox.Show("SON IGUALES");

                    txt_hfin.Text = cbo_hfin.Text;
                    txt_hinicio.Text = cbo_hin.Text;

                    TimeSpan first = TimeSpan.Parse(txt_hinicio.Text);
                    TimeSpan second = TimeSpan.Parse(txt_hfin.Text);
                    if (first.CompareTo(second) == 1)
                    {
                        //MessageBox.Show("Primero mayor");
                    }
                    if (first.CompareTo(second) == -1)
                    {
                        // MessageBox.Show("Segundo mayor");
                        guardar();
                        actualizar();
                        vaciar_tree();


                    }
                }
                else if (dateTimePicker1.Value < dateTimePicker2.Value)
                {
                    //MessageBox.Show("SEGUNDO MAYOR");
                    txt_hfin.Text = cbo_hfin.Text;
                    txt_hinicio.Text = cbo_hin.Text;

                    TimeSpan first2 = TimeSpan.Parse(txt_hinicio.Text);
                    TimeSpan second2 = TimeSpan.Parse(txt_hfin.Text);
                    if (first2.CompareTo(second2) == 1)
                    {
                        //   MessageBox.Show("Primero mayor");
                    }
                    if (first2.CompareTo(second2) == -1)
                    {
                        //MessageBox.Show("Segundo mayor");
                        guardar();
                        actualizar();
                        vaciar_tree();
                    }
                    if (first2.CompareTo(second2) == 0)
                    {
                        //MessageBox.Show("Iguales");
                    }


                }
                else if (dateTimePicker1.Value > dateTimePicker2.Value)
                {
                    //MessageBox.Show("PRIMERO MAYOR");
                }
                
                vaciar_tree();
            }
            catch
            {

            }
        }
        #endregion

        #region Treeview AfterCheck - Cristian Estrada
        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            bool cadena=false;
            foreach (TreeNode nodo_hijo in e.Node.Nodes)
            {
               
                    nodo_hijo.Checked = true;
                    cadena = true ;
            }

            if (cadena == true)
            {
                foreach (TreeNode n in treeView1.Nodes)
                {
                    if (n.Checked == false)
                    {

                        foreach (TreeNode nodo_hijo in n.Nodes)
                        {

                            nodo_hijo.Checked = false;
                            cadena = true;
                        }
                    }
                }
            }
        }
        #endregion

        #region Vaciar treeview - Cristian Estrada
        public void vaciar_tree()
        {
            foreach (TreeNode n in treeView1.Nodes)
            {
                n.Checked = false;

                foreach (TreeNode n_child in n.Nodes)
                {
                    n_child.Checked = false;
                }
            }
        }
        #endregion

        #region Boton para vaciar treeview - Cristian Estrada
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (TreeNode n in treeView1.Nodes)
            {
                n.Checked = false;
                
                foreach (TreeNode n_child in n.Nodes)
                    {
                        n_child.Checked = false;
                    }
            }
        }
        #endregion

        #region Boton Eliminar - Cristian Estrada

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo_ac = txt_act.Text;
                String atributo2 = "actividad ";
                //String campo = "estado";
               
                    var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {

                        CapaNegocio fn = new CapaNegocio();
                        string tabla = "capacitacion";
                        fn.eliminar(tabla,atributo2, codigo_ac);
                        fn.InhabilitarComponentes(gpb_cap);
                        fn.LimpiarComponentes(gpb_cap);

                    }

                string tabla2 = "capacitacion";
                fn.ActualizarGrid(data, "SELECT DISTINCT  actividad, objetivo, recursos, fecha_inicio, fecha_fin, horario_inicio, horario_fin, id_ubicacion_pk, id_empresa_pk FROM capacitacion WHERE estado <>'INACTIVO' ", tabla2);
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a eliminar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Boton editar - Cristian Estrada
        private void btn_editar_Click(object sender, EventArgs e)
        {
            fn.ActivarControles(gpb_cap);
            try
            {
                treeView1.Enabled = true;
                btn_guardar.Enabled = true;
                txt_act.Enabled= false;
                Editar = true;
                atributo = "actividad";
                Codigo = txt_act.Text;
                
                
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a editar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Modificar - Cristian Estrada
        string id_cap;
        public void modificar()
        {
            int modificacion = 0;
            foreach (TreeNode n in treeView1.Nodes)
            {
                foreach (TreeNode n_child in n.Nodes)
                {
                    string value2 = n_child.Tag.ToString();
                    //MessageBox.Show("VALUE2>> '" + value2 + "'");
                    string id_emp;
                    
                    OdbcConnection Conexion2;
                    OdbcCommand Query2 = new OdbcCommand();
                    OdbcDataReader consultar2;
                    //string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
                    string sql = "dsn=hotelsancarlos;server=localhost;database=hotelsancarlos;uid=root;password=";
                    //string sql = "server = 127.0.0.1; database = hotelsancarlos; uid = root; pwd =; ";
                    Conexion2 = new OdbcConnection();
                    Conexion2.ConnectionString = sql;
                    Conexion2.Open();
                    Query2.CommandText = "SELECT id_capacitacion_pk, id_empleado_pk from capacitacion where id_empleado_pk = '" +value2 + "' AND marca <>'S' and actividad LIKE '" + txt_act.Text + "';";
                    Query2.Connection = Conexion2;
                    consultar2 = Query2.ExecuteReader();
                    while (consultar2.Read())
                    {
                        id_cap = consultar2.GetString(0);
                        id_emp = consultar2.GetString(1);
                        //MessageBox.Show(Convert.ToString(id_emp));
                        
                               if (n_child.Checked==true && value2 == id_emp)
                                {
                                    //MessageBox.Show("MARCADO Y ESTA EN LA BASE DE DATOS");
                                    n_child.Checked = false;
                                    modificacion = 1;

                                } else if (n_child.Checked == false && value2 == id_emp)
                                {
                                    
                                   // MessageBox.Show("NO MARCADO Y ESTA EN LA BASE DE DATOS");
                                    String codigo2 = id_cap ;
                                    String atributo2 = "id_capacitacion_pk";
                                    CapaNegocio fn = new CapaNegocio();
                                    string tabla = "capacitacion";
                                    textBox1.Text = "S";
                                    TextBox[] textbox2 = { textBox1 };
                                    DataTable datos2 = fn.construirDataTable(textbox2);
                                    fn.modificar(datos2, tabla, atributo2, codigo2);
                            //n_child.Checked = false;
                        }
                    }
                }
            }
            
            foreach (TreeNode n in treeView1.Nodes)
            {
                foreach (TreeNode n_child in n.Nodes)
                {
                    if (n_child.Checked == true)
                    {
                        mega = "Y";

                    }
                }
            }

            if (modificacion == 1)
            {
                string selectItem = cbo_ubi.SelectedValue.ToString();
                string selectItem2 = cbo_hin.Text.ToString();
                string selectItem3 = cbo_hfin.Text.ToString();
                string selectItem4 = cbo_empres.SelectedValue.ToString();
                //n_child.Checked = false;
                
                txt_finicio.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                txt_ffin.Text = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                txt_ubi.Text = selectItem;
                txt_hinicio.Text = selectItem2;
                txt_hfin.Text = selectItem3;
                txt_empresa.Text = selectItem4;

                CapaNegocio fn = new CapaNegocio();
                TextBox[] textbox = { txt_act, txt_ffin, txt_finicio, txt_hfin, txt_hinicio, txt_obj, txt_recu, txt_ubi, txt_empresa};
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    //MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "capacitacion";
                    //MessageBox.Show("ENTRO");
                    fn.modificar(datos, tabla, atributo, Codigo);

                }
            }
        }
        #endregion

        #region Guardar las modificaciones - Cristian Estrada
        public void guardar_modificar()
        {
            foreach (TreeNode n in treeView1.Nodes)
            {
                foreach (TreeNode n_child in n.Nodes)
                {

                    if (n_child.Checked == true)
                    {

                        string selectItem = cbo_ubi.SelectedValue.ToString();
                        string selectItem2 = cbo_hin.Text.ToString();
                        string selectItem3 = cbo_hfin.Text.ToString();
                        //n_child.Checked = false;
                        string value = n.Tag.ToString();
                        string value2 = n_child.Tag.ToString();

                        txt_area.Text = value;
                        txt_emple.Text = value2;
                        txt_finicio.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                        txt_ffin.Text = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                        txt_ubi.Text = selectItem;
                        txt_hinicio.Text = selectItem2;
                        txt_hfin.Text = selectItem3;

                        CapaNegocio fn = new CapaNegocio();
                        TextBox[] textbox = { txt_act, txt_emple, txt_ffin, txt_finicio, txt_hfin, txt_hinicio, txt_obj, txt_recu, txt_ubi,txt_empresa};
                        DataTable datos = fn.construirDataTable(textbox);
                        if (datos.Rows.Count == 0)
                        {
                            //MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string tabla = "capacitacion";
                            if (mega == "Y")
                            {

                                fn.insertar(datos, tabla);
                              
                            }
                        }
                    }
                }
            }
        }
        #endregion
        #region Abrir from de ubicacion- Cristian Estrada
        private void button3_Click(object sender, EventArgs e)
        {
            frm_ubicacion comi_lin = new frm_ubicacion();
           
            comi_lin.StartPosition = FormStartPosition.CenterScreen;
            comi_lin.Show();
        }
        #endregion

        #region Boton Anterior - Cristian Estrada
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Anterior(data);
                TextBox[] textbox = { txt_act, txt_ffin, txt_finicio, txt_hfin, txt_hinicio, txt_obj, txt_recu, txt_ubi, txt_empresa };
                fn.llenartextbox(textbox, data);
                dateTimePicker1.Text = txt_finicio.Text;
                dateTimePicker2.Text = txt_ffin.Text;
                llenar2(txt_empresa.Text);
                cbo_hin.Text = txt_hinicio.Text;
                cbo_hfin.Text = txt_hfin.Text;
                vaciar_tree();
                llenar(txt_ubi.Text);
                llenarempleados(txt_act.Text);
            }
            catch {

            }
        }
        #endregion

        #region Boton Siguiente - Cristian Estrada
        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Siguiente(data);
                TextBox[] textbox = { txt_act, txt_ffin, txt_finicio, txt_hfin, txt_hinicio, txt_obj, txt_recu, txt_ubi, txt_empresa };
                fn.llenartextbox(textbox, data);
                dateTimePicker1.Text = txt_finicio.Text;
                dateTimePicker2.Text = txt_ffin.Text;
                cbo_hin.Text = txt_hinicio.Text;
                cbo_hfin.Text = txt_hfin.Text;
                vaciar_tree();
                llenar(txt_ubi.Text);
                llenar2(txt_empresa.Text);
                llenarempleados(txt_act.Text);
            }
            catch {
            }
        }
        #endregion

        #region Boton Primero - Cristian Estrada
        private void btn_primero_Click(object sender, EventArgs e)
        {
            try {
                fn.Primero(data);
                TextBox[] textbox = { txt_act, txt_ffin, txt_finicio, txt_hfin, txt_hinicio, txt_obj, txt_recu, txt_ubi, txt_empresa };
                fn.llenartextbox(textbox, data);
                dateTimePicker1.Text = txt_finicio.Text;
                dateTimePicker2.Text = txt_ffin.Text;
                cbo_hin.Text = txt_hinicio.Text;
                cbo_hfin.Text = txt_hfin.Text;
                vaciar_tree();
                llenar(txt_ubi.Text);
                llenar2(txt_empresa.Text);
                llenarempleados(txt_act.Text);
            }
            catch
            {

            }
        }
        #endregion

        #region Boton Ultimo - Cristian Estrada
        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            try {
                fn.Ultimo(data);
                TextBox[] textbox = { txt_act, txt_ffin, txt_finicio, txt_hfin, txt_hinicio, txt_obj, txt_recu, txt_ubi, txt_empresa };
                fn.llenartextbox(textbox, data);
                dateTimePicker1.Text = txt_finicio.Text;
                dateTimePicker2.Text = txt_ffin.Text;
                cbo_hin.Text = txt_hinicio.Text;
                cbo_hfin.Text = txt_hfin.Text;
                vaciar_tree();
                llenar(txt_ubi.Text);
                llenar2(txt_empresa.Text);
                llenarempleados(txt_act.Text);
            }
            catch
            {

            }
        }
        #endregion

        #region Buscar empleados en el treeview - Cristian Estrada
        private void cbo_empres_SelectedIndexChanged(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            nivel();
            llenarempleados(txt_act.Text);
        }

        private List<TreeNode> CurrentNodeMatches = new List<TreeNode>();

        private int LastNodeIndex = 0;

        private string LastSearchText;


        private void SearchNodes(string SearchText, TreeNode StartNode)
        {
            TreeNode node = null;
            while (StartNode != null)
            {
                if (StartNode.Text.ToLower().Contains(SearchText.ToLower()))
                {
                    CurrentNodeMatches.Add(StartNode);
                };
                if (StartNode.Nodes.Count != 0)
                {
                    SearchNodes(SearchText, StartNode.Nodes[0]);//Recursive Search 
                };
                StartNode = StartNode.NextNode;
            };

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string searchText = this.textBox2.Text;
            if (String.IsNullOrEmpty(searchText))
            {
                return;
            };


            if (LastSearchText != searchText)
            {
                //It's a new Search
                CurrentNodeMatches.Clear();
                LastSearchText = searchText;
                LastNodeIndex = 0;
                SearchNodes(searchText, treeView1.Nodes[0]);
            }

            if (LastNodeIndex >= 0 && CurrentNodeMatches.Count > 0 && LastNodeIndex < CurrentNodeMatches.Count)
            {
                TreeNode selectedNode = CurrentNodeMatches[LastNodeIndex];
                LastNodeIndex++;
                this.treeView1.SelectedNode = selectedNode;
                this.treeView1.SelectedNode.Expand();
                this.treeView1.Select();

            }
        }
        #endregion
        private void txt_ubi_TextChanged(object sender, EventArgs e)
        {

        }

        #region Metodo de actualizar - Cristian Estrada
        public void actualizar()
        {
            try {
                string tabla2 = "capacitacion";
                fn.ActualizarGrid(data, "SELECT DISTINCT  actividad, objetivo, recursos, fecha_inicio, fecha_fin, horario_inicio, horario_fin, id_ubicacion_pk, id_empresa_pk FROM capacitacion WHERE estado <>'INACTIVO' ", tabla2);
            }
            catch
            {

            }
        }
        #endregion

        #region Boton Actualizar - Cristian Estrada
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            actualizar();
        }
        #endregion
    }
}
