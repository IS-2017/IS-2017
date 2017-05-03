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

namespace contrato_trabajo
{
    public partial class frm_jornada_grid : Form
    {

        #region Variables del Form Jornada Grid
        //=======================================================================================================================
        //--------------------------------------Variables--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        CapaNegocio fn = new CapaNegocio();
        operaciones op = new operaciones();
        Boolean Editar1;
        Boolean tipo_accion;
        String id_jornadatrabajo_pk, forma_cobro, nombre_jornada, horas_trabajo, jdiaria_dias, jhora_diario, estado;
        #endregion

        #region Iniciar Form Jornada Grid
        //=======================================================================================================================
        //--------------------------------------Iniciar Form--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        public frm_jornada_grid()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Carga del Form
        //=======================================================================================================================
        //--------------------------------------Load del Form------------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void frm_jornada_grid_Load(object sender, EventArgs e)
        {
            try
            {
                Actualizar_grid_jornada();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Actualizar
        //=======================================================================================================================
        //--------------------------------------Actualizar--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Actualizar_grid_jornada();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Actualizar_grid_jornada()
        {
            try
            {
                string tabla = "emp_jornadatrabajo";
                fn.ActualizarGrid(this.dgv_jornadas, "SELECT id_jornadatrabajo_pk, forma_cobro, nombre_jornada, horas_trabajo, jdiaria_dias, jhora_diario, estado FROM `emp_jornadatrabajo` WHERE estado = 'ACTIVO' ", tabla);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        #endregion

        #region Boton Buscar
        //=======================================================================================================================
        //--------------------------------------Buscar--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "emp_jornadatrabajo";
                op.ejecutar(dgv_jornadas, tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Nuevo
        //=======================================================================================================================
        //--------------------------------------Nuevo--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar1 = false;
                frm_jornada jornada = new frm_jornada(dgv_jornadas, id_jornadatrabajo_pk, forma_cobro, nombre_jornada, horas_trabajo, jdiaria_dias, jhora_diario, estado, Editar1, tipo_accion);
                jornada.MdiParent = this.ParentForm;
                jornada.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Doble-Clic Celda GridView
        //=======================================================================================================================
        //--------------------------------------Doble Clic en Celda del Grid-----------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void dgv_jornadas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Editar1 = true;
                tipo_accion = true;
                id_jornadatrabajo_pk = this.dgv_jornadas.CurrentRow.Cells[0].Value.ToString();
                forma_cobro = this.dgv_jornadas.CurrentRow.Cells[1].Value.ToString();
                nombre_jornada = this.dgv_jornadas.CurrentRow.Cells[2].Value.ToString();
                horas_trabajo = this.dgv_jornadas.CurrentRow.Cells[3].Value.ToString();
                jdiaria_dias = this.dgv_jornadas.CurrentRow.Cells[4].Value.ToString();
                jhora_diario = this.dgv_jornadas.CurrentRow.Cells[5].Value.ToString();
                estado = this.dgv_jornadas.CurrentRow.Cells[6].Value.ToString();

                frm_jornada jornada = new frm_jornada(dgv_jornadas, id_jornadatrabajo_pk, forma_cobro, nombre_jornada, horas_trabajo, jdiaria_dias, jhora_diario, estado, Editar1, tipo_accion);
                jornada.MdiParent = this.ParentForm;
                jornada.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Botones de Navegacion
        //=======================================================================================================================
        //--------------------------------------Navegacion--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_primero_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Primero(dgv_jornadas);
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
                fn.Ultimo(dgv_jornadas);
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
                fn.Siguiente(dgv_jornadas);
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
                fn.Anterior(dgv_jornadas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

    }
}
