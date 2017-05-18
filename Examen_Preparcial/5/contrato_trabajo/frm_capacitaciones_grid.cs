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

namespace contrato_trabajo
{
    public partial class frm_capacitaciones_grid : Form
    {
        public frm_capacitaciones_grid()
        {
            InitializeComponent();
        }
        Boolean Editar1;
        CapaNegocio fn = new CapaNegocio();
        String id_capacitacion_pk, objetivo, actividad, recursos, dirigido, fecha_inicio, fecha_fin, horario_inicio, horario_fin, id_ubicacion_pk, id_empresa_pk;

        #region Boton de actualizar Empresa - Cristian Estradda
        private void button1_Click(object sender, EventArgs e)
        {
            try {
                string tabla = "capacitacion";
                string selectedItem = cbo_empres.SelectedValue.ToString();
                fn.ActualizarGrid(this.dgv_capacitacion, "SELECT DISTINCT  actividad, objetivo, recursos, fecha_inicio, fecha_fin, horario_inicio, horario_fin, id_ubicacion_pk, id_empresa_pk FROM capacitacion WHERE  id_empresa_pk ='" + selectedItem + "'  and estado <> 'INACTIVO'", tabla);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton de filtrar - Cristian Estrada
        private void button2_Click(object sender, EventArgs e)
        {
            string date1 = dtp_fechade.Value.ToString("yyyy-MM-dd");
            string date2 = dtp_fechahasta.Value.ToString("yyyy-MM-dd");
            string tabla = "capacitacion";
            string selectedItem = cbo_empres.SelectedValue.ToString();
            fn.ActualizarGrid(this.dgv_capacitacion, "SELECT DISTINCT  actividad, objetivo, recursos, fecha_inicio, fecha_fin, horario_inicio, horario_fin, id_ubicacion_pk, id_empresa_pk FROM capacitacion WHERE  id_empresa_pk ='" + selectedItem + "' and estado <> 'INACTIVO' and fecha_inicio BETWEEN '" + date1 + "' AND '" + date2 + "'", tabla);
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

        #region Datagridview-capacitaciones - Cristian Estrada
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar1 = true;
            //id_capacitacion_pk = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            actividad = this.dgv_capacitacion.CurrentRow.Cells[0].Value.ToString();
            objetivo = this.dgv_capacitacion.CurrentRow.Cells[1].Value.ToString();

            recursos = this.dgv_capacitacion.CurrentRow.Cells[2].Value.ToString();

            fecha_inicio = this.dgv_capacitacion.CurrentRow.Cells[3].Value.ToString();
            fecha_fin = this.dgv_capacitacion.CurrentRow.Cells[4].Value.ToString();
            horario_inicio = this.dgv_capacitacion.CurrentRow.Cells[5].Value.ToString();
            horario_fin = this.dgv_capacitacion.CurrentRow.Cells[6].Value.ToString();
            id_ubicacion_pk = this.dgv_capacitacion.CurrentRow.Cells[7].Value.ToString();
            id_empresa_pk = this.dgv_capacitacion.CurrentRow.Cells[8].Value.ToString();
            frm_capacitaciones a = new frm_capacitaciones(dgv_capacitacion,  actividad, objetivo, recursos, fecha_inicio, fecha_fin, horario_inicio, horario_fin, id_ubicacion_pk, id_empresa_pk, Editar1);
            a.StartPosition = FormStartPosition.CenterScreen;
            a.MdiParent = this.ParentForm;
            a.Show();
        }

        #endregion

        #region Boton Nuevo - Cristian Estrada
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar1 = false;
                frm_capacitaciones a = new frm_capacitaciones(dgv_capacitacion, actividad, objetivo, recursos, fecha_inicio, fecha_fin, horario_inicio, horario_fin, id_ubicacion_pk, id_empresa_pk, Editar1);
                a.StartPosition = FormStartPosition.CenterScreen;
                a.MdiParent = this.ParentForm;
                a.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Actualizar - Cristian Estrada
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try {
                string tabla = "capacitacion";
                fn.ActualizarGrid(this.dgv_capacitacion, "SELECT DISTINCT  actividad, objetivo, recursos, fecha_inicio, fecha_fin, horario_inicio, horario_fin, id_ubicacion_pk, id_empresa_pk FROM capacitacion WHERE estado <>'INACTIVO' ", tabla);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Anterior - Cristian Estrada
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Anterior(dgv_capacitacion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Siguiente - Cristian Estrad

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Siguiente(dgv_capacitacion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Primero - Cristian Estrada
        private void btn_primero_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Primero(dgv_capacitacion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Ultimo - Cristian Estrada
        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Ultimo(dgv_capacitacion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Carga de Datos Form - Cristian Estrada
        private void frm_capacitaciones_grid_Load(object sender, EventArgs e)
        {
            try {
                string tabla = "capacitacion";
                fn.ActualizarGrid(this.dgv_capacitacion, "SELECT DISTINCT  actividad, objetivo, recursos, fecha_inicio, fecha_fin, horario_inicio, horario_fin, id_ubicacion_pk, id_empresa_pk FROM capacitacion WHERE estado <> 'INACTIVO'", tabla);
                llenaridempresa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
