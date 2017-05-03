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
    public partial class frm_emp_correos_grid : Form
    {
        #region Variables del Form Empleado Correo Grid
        //=======================================================================================================================
        //--------------------------------------Variables--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        String codigo_emp, id_correo, correo1, descripcion;
        CapaNegocio fn = new CapaNegocio();
        operaciones op = new operaciones();
        Boolean Editar1;
        Boolean tipo_accion;
        #endregion

        #region Visualizar Contenido en Form Empleado Correo Grid
        //=======================================================================================================================
        //------------------------------------------ Visualizar Form ------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        public frm_emp_correos_grid(String id_empleado)
        {
            try
            {
                InitializeComponent();
                codigo_emp = id_empleado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Cargar al Inicio del Form
        //=======================================================================================================================
        //------------------------------------------ Cargar Form --------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void frm_emp_correos_grid_Load(object sender, EventArgs e)
        {
            try
            {
                string tabla = "emp_correo_electronico";
                fn.ActualizarGrid(this.dgv_correo, "SELECT id_correo_electronico_emp, correo_electronico1_emp, descripcion_correo, estado, id_empleado_pk FROM `emp_correo_electronico` WHERE id_empleado_pk = '" + codigo_emp + "' and estado = 'ACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Actualizar
        //=======================================================================================================================
        //--------------------------------------------- Actualizar --------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "emp_correo_electronico";
                fn.ActualizarGrid(this.dgv_correo, "SELECT id_correo_electronico_emp, correo_electronico1_emp, descripcion_correo, estado, id_empleado_pk FROM `emp_correo_electronico` WHERE id_empleado_pk = '" + codigo_emp + "' and estado = 'ACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Buscar
        //=======================================================================================================================
        //--------------------------------------------- Buscar --------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "emp_correo_electronico";
                op.ejecutar(dgv_correo, tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Nuevo
        //=======================================================================================================================
        //--------------------------------------------- Nuevo --------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar1 = false;
                frm_emp_correos correos = new frm_emp_correos(dgv_correo, id_correo, correo1, descripcion, codigo_emp, Editar1, tipo_accion);
                correos.MdiParent = this.ParentForm;
                correos.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Funciones a Realizar 
        //=======================================================================================================================
        //--------------------------------------------- Funciones --------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void dgv_correo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Editar1 = true;
                tipo_accion = true;

                id_correo = this.dgv_correo.CurrentRow.Cells[0].Value.ToString();
                correo1 = this.dgv_correo.CurrentRow.Cells[1].Value.ToString();
                descripcion = this.dgv_correo.CurrentRow.Cells[2].Value.ToString();

                frm_emp_correos correos = new frm_emp_correos(dgv_correo, id_correo, correo1, descripcion, codigo_emp, Editar1, tipo_accion);
                correos.MdiParent = this.ParentForm;
                correos.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Botones de Navegacion
        //=======================================================================================================================
        //--------------------------------------------- Navegacion --------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Anterior(dgv_correo);
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
                fn.Siguiente(dgv_correo);
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
                fn.Primero(dgv_correo);
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
                fn.Ultimo(dgv_correo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

    }
}
