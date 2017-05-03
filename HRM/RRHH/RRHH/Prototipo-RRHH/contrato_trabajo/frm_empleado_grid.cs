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
using dllconsultas;
using MySql.Data.MySqlClient;
using System.Data.Odbc;


namespace contrato_trabajo
{
    public partial class frm_empleado_grid : Form
    {
        public frm_empleado_grid()
        {
            InitializeComponent();
            //string tabla = "empleado";
            //fn.ActualizarGrid(this.dgv_lista_emps, "Select `id_empleado_pk`, `nombre_emp`, `telefono_movil_emp`, `no_afiliacionIGSS_emp`, `dpi_emp` from empleado WHERE estado = 'ACTIVO' ", tabla);
        }

        CapaNegocio fn = new CapaNegocio();
        operaciones op = new operaciones();
        Boolean Editar;
        Boolean tipo_accion;
        String id_empleado_pk, nombre_emp, apellido_emp, dpi_emp, telefono_hogar_emp, telefono_movil_emp, no_afiliacionIGSS_emp, fecha_de_alta_emp, fecha_de_baja_emp, estadolaboral;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string tabla = "empleado";
                fn.ActualizarGrid(this.dgv_lista_emps, "Select `id_empleado_pk`, `nombre_emp`, `apellido_emp`, `no_afiliacionIGSS_emp`, `dpi_emp` from empleado WHERE estado = 'ACTIVO' AND estadolaboral LIKE '%alta%' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string tabla = "empleado";
                fn.ActualizarGrid(this.dgv_lista_emps, "Select `id_empleado_pk`, `nombre_emp`, `apellido_emp`, `no_afiliacionIGSS_emp`, `dpi_emp` from empleado WHERE estado = 'ACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string tabla = "empleado";
                fn.ActualizarGrid(this.dgv_lista_emps, "Select `id_empleado_pk`, `nombre_emp`, `apellido_emp`, `no_afiliacionIGSS_emp`, `dpi_emp` from empleado WHERE estado = 'ACTIVO' AND (estadolaboral LIKE '%baja%' OR estadolaboral LIKE '%suspens%') ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Ultimo(dgv_lista_emps);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbo_empres_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string tabla = "nomina";
                fn.ActualizarGrid(this.dgv_lista_emps, "Select `id_empleado_pk`, `nombre_emp`, `apellido_emp`, `no_afiliacionIGSS_emp`, `dpi_emp` from empleado WHERE estado = 'ACTIVO' and id_empresa_pk = '" + cbo_empres.SelectedValue + "' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Primero(dgv_lista_emps);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Siguiente(dgv_lista_emps);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Anterior(dgv_lista_emps);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "empleado";
                op.ejecutar(dgv_lista_emps, tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                id_empleado_pk = null;
                frm_empleado empleados = new frm_empleado(dgv_lista_emps, id_empleado_pk, Editar, tipo_accion);
                empleados.MdiParent = this.ParentForm;
                empleados.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "empleado";
                fn.ActualizarGrid(this.dgv_lista_emps, "Select `id_empleado_pk`, `nombre_emp`, `apellido_emp`, `no_afiliacionIGSS_emp`, `dpi_emp` from empleado WHERE estado = 'ACTIVO' ", tabla);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_lista_emps_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Editar = true;
                tipo_accion = true;
                id_empleado_pk = this.dgv_lista_emps.CurrentRow.Cells[0].Value.ToString();
                frm_empleado empleado = new frm_empleado(dgv_lista_emps, id_empleado_pk, Editar, tipo_accion);
                empleado.MdiParent = this.ParentForm;
                empleado.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void frm_empleado_grid_Load(object sender, EventArgs e)
        {       
            try
            {
                string tabla = "empleado";
                fn.ActualizarGrid(this.dgv_lista_emps, "Select `id_empleado_pk`, `nombre_emp`, `apellido_emp`, `no_afiliacionIGSS_emp`, `dpi_emp` from empleado WHERE estado = 'ACTIVO' ", tabla);
                llenaridempresa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void llenaridempresa()
        {    
            //se realiza la conexión a la base de datos
            Conexionmysql.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select id_empresa_pk, nombre_empresa from empresa Where estado <>'INACTIVO'";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "empresa");
            cbo_empres.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_empres.ValueMember = ("id_empresa_pk");
            //se indica el valor a desplegar en el combobox
            cbo_empres.DisplayMember = ("nombre_empresa");
            Conexionmysql.Desconectar();
        }
    }
}
