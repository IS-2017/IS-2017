using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using FuncionesNavegador;
namespace contrato_trabajo
{
    public partial class frm_asistencia_cap : Form
    {

        #region Inicio - Cristian Estrada
        public frm_asistencia_cap()
        {
            InitializeComponent();
        }
        #endregion

        #region Variables - Cristian Estrada
        CapaNegocio fn = new CapaNegocio();
        String Codigo;
        Boolean Editar;
        String atributo;

        #endregion
        private void label1_Click(object sender, EventArgs e)
        {

        }

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

        #region llenar combox capacitacion - Cristian Estrada
        public void llenarcap()
        {
            try {
                string selectedItem = cbo_empres.SelectedValue.ToString();
                Ayuda.ObtenerConexion();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "SELECT DISTINCT actividad from capacitacion Where  id_empresa_pk ='" + selectedItem + "' and marca_asistencia <> 'N' and estado <>'INACTIVO'";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, Ayuda.ObtenerConexion());
                //se indica con quu tabla se llena
                dad.Fill(ds, "capacitacion");
                cbo_cap.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_cap.ValueMember = ("actividad");
                //se indica el valor a desplegar en el combobox
                cbo_cap.DisplayMember = ("actividad");
                Ayuda.Desconectar();
            }
            catch
            {

            }
        }
        #endregion
        #region combox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region llenar empleados - Cristian Estrada
        public void empleados()
        {
            try {
                int cont1 = 0;
                int emp;
                string nom_emp;
                string ape_emp;
                string conca;


                // int ca = Convert.ToInt32(dataGridView1.Rows[fila].Cells[7].Value);

                OdbcCommand Query = new OdbcCommand();
                OdbcConnection Conexion;
                OdbcDataReader consultar;
                //string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
                string sql = "dsn=hotelsancarlos;server=localhost;database=hotelsancarlos;uid=root;password=";
                Conexion = new OdbcConnection();
                Conexion.ConnectionString = sql;
                Conexion.Open();
                Query.CommandText = "SELECT C.id_empleado_pk, E.nombre_emp, E.apellido_emp FROM capacitacion C, empleado E WHERE C.actividad = '" + cbo_cap.Text + "'  AND E.id_empleado_pk = C.id_empleado_pk AND C.marca <> 'S' and C.estado <>'INACTIVO'; ";
                Query.Connection = Conexion;
                consultar = Query.ExecuteReader();

                while (consultar.Read())
                {
                    dgv_asistencia.Rows.Add(1);
                    if (cont1 == 0)
                    {

                        emp = consultar.GetInt32(0);
                        //proce_pro = consultar.GetDecimal(1);
                        nom_emp = consultar.GetString(1);
                        ape_emp = consultar.GetString(2);
                        conca = nom_emp + " " + ape_emp;
                        dgv_asistencia.Rows[0].Cells[0].Value = emp;
                        dgv_asistencia.Rows[0].Cells[1].Value = conca;
                        //MessageBox.Show(Convert.ToString(precio_pro));



                    }
                    else
                    {
                        emp = consultar.GetInt32(0);
                        //proce_pro = consultar.GetDecimal(1);
                        nom_emp = consultar.GetString(1);
                        ape_emp = consultar.GetString(2);
                        conca = nom_emp + " " + ape_emp;
                        dgv_asistencia.Rows[cont1].Cells[0].Value = emp;
                        dgv_asistencia.Rows[cont1].Cells[1].Value = conca;

                    }
                    cont1 = cont1 + 1;
                }
            }
            catch
            {

            }
            
        }
        #endregion

        #region Cargar datos en los combox - Cristian Estrada
        private void frm_asistencia_cap_Load(object sender, EventArgs e)
        {
            llenaridempresa();
            llenarcomboasis();
            llenarcomboeva();
            llenarcap();
        }
        #endregion

        #region Empleados - Cristian Estrada
        private void button2_Click(object sender, EventArgs e)
        {
            dgv_asistencia.Rows.Clear();
            empleados();

        }
        #endregion

        #region Combox Index - Cristian Estrada
        private void cbo_empres_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarcap();
        }
        #endregion

        #region Columna de asistencia - Cristian Estrada
        public void llenarcomboasis()
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            cmb.Name = "Asistencia";
            cmb.Items.Add("100");
            cmb.Items.Add("0");
            dgv_asistencia.Columns.Add(cmb);
        }
        #endregion

        #region Columna Evaluacion - Cristian Estrada
        public void llenarcomboeva()
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            cmb.Name = "Evaluacion";
            cmb.Items.Add("100");
            cmb.Items.Add("75");
            cmb.Items.Add("50");
            cmb.Items.Add("25");
            //cmb.Items.Add("0");
            dgv_asistencia.Columns.Add(cmb);
        }
        #endregion

        #region llenar asistencia - Cristian Estrada

        public void asistencia_100()
        {
            for (int fila = 0; fila < dgv_asistencia.RowCount - 1; fila++)
            {
                //MessageBox.Show(Convert.ToString(dataGridView1.Rows[fila].Cells[3].Value));
                //dataGridView1.Rows[fila].Cells[3].Value = "100";
                if (Convert.ToString(dgv_asistencia.Rows[fila].Cells[2].Value) == "0")
                {

                }
                else
                {
                    dgv_asistencia.Rows[fila].Cells[2].Value = "100";
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            asistencia_100();
        }
        #endregion

        #region llenar al 100 - Cristian Estrada
        public void evaluacion_100()
        {
            for (int fila = 0; fila < dgv_asistencia.RowCount - 1; fila++)
            {
                //dataGridView1.Rows[fila].Cells[3].Value = "100";
                if (Convert.ToString(dgv_asistencia.Rows[fila].Cells[3].Value) == "25" || Convert.ToString(dgv_asistencia.Rows[fila].Cells[3].Value) == "75" ||
                    Convert.ToString(dgv_asistencia.Rows[fila].Cells[3].Value) == "0" || Convert.ToString(dgv_asistencia.Rows[fila].Cells[3].Value) == "50")
                {

                }
                else
                {
                    dgv_asistencia.Rows[fila].Cells[3].Value = "100";
                }

            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            evaluacion_100();
        }
        #endregion

        #region llenar al 75 - Cristian Estrada
        private void button4_Click(object sender, EventArgs e)
        {
            for (int fila = 0; fila < dgv_asistencia.RowCount - 1; fila++)
            {
                //dataGridView1.Rows[fila].Cells[3].Value = "100";
                if (Convert.ToString(dgv_asistencia.Rows[fila].Cells[3].Value) == "25" || Convert.ToString(dgv_asistencia.Rows[fila].Cells[3].Value) == "100" ||
                    Convert.ToString(dgv_asistencia.Rows[fila].Cells[3].Value) == "0" || Convert.ToString(dgv_asistencia.Rows[fila].Cells[3].Value) == "50")
                {

                }
                else
                {
                    dgv_asistencia.Rows[fila].Cells[3].Value = "75";
                }

            }
        }
        #endregion

        #region llenar combox empresa - Cristian Estrada
        private void button6_Click(object sender, EventArgs e)
        {
            for (int fila = 0; fila < dgv_asistencia.RowCount - 1; fila++)
            {
                //dataGridView1.Rows[fila].Cells[3].Value = "100";
                if (Convert.ToString(dgv_asistencia.Rows[fila].Cells[3].Value) == "25" || Convert.ToString(dgv_asistencia.Rows[fila].Cells[3].Value) == "75" ||
                    Convert.ToString(dgv_asistencia.Rows[fila].Cells[3].Value) == "0" || Convert.ToString(dgv_asistencia.Rows[fila].Cells[3].Value) == "100")
                {

                }
                else
                {
                    dgv_asistencia.Rows[fila].Cells[3].Value = "50";
                }

            }
        }
        #endregion

        #region llenar 25 - Cristian Estrada
        private void button7_Click(object sender, EventArgs e)
        {
            for (int fila = 0; fila < dgv_asistencia.RowCount - 1; fila++)
            {
                //dataGridView1.Rows[fila].Cells[3].Value = "100";
                if (Convert.ToString(dgv_asistencia.Rows[fila].Cells[3].Value) == "100" || Convert.ToString(dgv_asistencia.Rows[fila].Cells[3].Value) == "75" ||
                    Convert.ToString(dgv_asistencia.Rows[fila].Cells[3].Value) == "0" || Convert.ToString(dgv_asistencia.Rows[fila].Cells[3].Value) == "50")
                {

                }
                else
                {
                    dgv_asistencia.Rows[fila].Cells[3].Value = "25";
                }

            }
        }
        #endregion

        #region Guardar - Cristian Estrada
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try {
                asistencia_100();
                evaluacion_100();
                for (int fila = 0; fila < dgv_asistencia.RowCount - 1; fila++)
                {
                    string selectedItem = cbo_empres.SelectedValue.ToString();
                    string selectedItem2 = cbo_cap.Text;
                    txt_empresa.Text = selectedItem;

                    txt_fecha.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                    txt_cap.Text = selectedItem2;
                    txt_asis.Text = dgv_asistencia.Rows[fila].Cells[2].Value.ToString();
                    txt_evalu.Text = dgv_asistencia.Rows[fila].Cells[3].Value.ToString();

                    CapaNegocio fn = new CapaNegocio();
                    TextBox[] textbox = { txt_cap, txt_empresa, txt_fecha, txt_evalu, txt_asis };
                    DataTable datos = fn.construirDataTable(textbox);
                    if (datos.Rows.Count == 0)
                    {
                        //MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string tabla = "asistencia_cap";
                        if (Editar)
                        {
                            fn.modificar(datos, tabla, atributo, Codigo);
                        }
                        else
                        {

                            txt_marca_asis.Text = "N";
                            fn.insertar(datos, tabla);
                            atributo = "actividad";
                            string tabla2 = "capacitacion";
                            Codigo = txt_cap.Text;
                            //CapaNegocio fn = new CapaNegocio();
                            TextBox[] textbox2 = { txt_marca_asis };
                            DataTable datos2 = fn.construirDataTable(textbox2);
                            fn.modificar(datos2, tabla2, atributo, Codigo);

                        }
                        fn.LimpiarComponentes(gpb_asistencia);
                       
                    }
                }
                dgv_asistencia.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region vaciar - Cristian Estrada
        private void button8_Click_1(object sender, EventArgs e)
        {
            for (int fila = 0; fila < dgv_asistencia.RowCount - 1; fila++)
            {
                //MessageBox.Show(Convert.ToString(dataGridView1.Rows[fila].Cells[3].Value));
                dgv_asistencia.Rows[fila].Cells[2].Value = "";
                

            }
        }

        #endregion
        #region Boton Nuevo - Cristian Estrada
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.ActivarControles(gpb_asistencia);
                fn.LimpiarComponentes(gpb_asistencia);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region buscar empleados - Cristian Estrada
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int fila = 0; fila < dgv_asistencia.RowCount - 1; fila++)
            {
                
                string valor = Convert.ToString(dgv_asistencia.Rows[fila].Cells[1].Value);

                if (valor == this.txt_buscar_em.Text)
                {
                    dgv_asistencia.Rows[fila].DefaultCellStyle.BackColor = Color.Red;
                } else if (this.txt_buscar_em.Text == "")
                {
                    for (int fila2 = 0; fila < dgv_asistencia.RowCount - 1; fila++)
                    {
                        //MessageBox.Show(Convert.ToString(dataGridView1.Rows[fila].Cells[3].Value));
                        
                        dgv_asistencia.Rows[fila2].DefaultCellStyle.BackColor = Color.White;

                    }
                }
            }
        }
        #endregion
    }
}
