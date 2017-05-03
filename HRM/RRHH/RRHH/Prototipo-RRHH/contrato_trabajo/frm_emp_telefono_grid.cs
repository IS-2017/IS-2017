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
    public partial class frm_emp_telefono_grid : Form
    {
        #region Variables Form Empleado Telefono Grid
        //=======================================================================================================================
        //--------------------------------------Variables--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        String codigo_emp, id_telefono, numero1, numero2, numero3, descripcion;
        CapaNegocio fn = new CapaNegocio();
        operaciones op = new operaciones();
        Boolean Editar1;
        Boolean tipo_accion;
        #endregion

        #region Visualizar Form Empleado Telefono Grid
        //=======================================================================================================================
        //---------------------------------------- Visualizar Form --------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        public frm_emp_telefono_grid(String id_empleado)
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
        //----------------------------------------- Carga del Form --------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void frm_emp_telefono_grid_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_datos_gridview();
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
                Cargar_datos_gridview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Cargar_datos_gridview()
        {
            string tabla = "emp_telefono";
            fn.ActualizarGrid(this.dgv_telefono, "SELECT id_telefono_emp_pk, numero_telefono1_emp, descripcion_tel, estado, id_empleado_pk FROM `emp_telefono` WHERE id_empleado_pk = '" + codigo_emp + "' and estado = 'ACTIVO' ", tabla);
        }
        #endregion

        #region Boton Buscar
        //=======================================================================================================================
        //------------------------------------------------ Buscar --------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "emp_telefono";
                op.ejecutar(dgv_telefono, tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Nuevo
        //=======================================================================================================================
        //------------------------------------------------ Nuevo --------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar1 = false;
                frm_emp_telefonos telefonos = new frm_emp_telefonos(dgv_telefono, id_telefono, numero1, numero2, numero3, descripcion, codigo_emp, Editar1, tipo_accion);
                telefonos.MdiParent = this.ParentForm;
                telefonos.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Funciones a Realizar 
        //=======================================================================================================================
        //------------------------------------------------ Funciones ------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void dgv_telefono_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Editar1 = true;
                tipo_accion = true;
                id_telefono = this.dgv_telefono.CurrentRow.Cells[0].Value.ToString();
                numero1 = this.dgv_telefono.CurrentRow.Cells[1].Value.ToString();
                descripcion = this.dgv_telefono.CurrentRow.Cells[2].Value.ToString();

                frm_emp_telefonos emp_telefono = new frm_emp_telefonos(dgv_telefono, id_telefono, numero1, numero2, numero3, descripcion, codigo_emp, Editar1, tipo_accion);
                emp_telefono.MdiParent = this.ParentForm;
                emp_telefono.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Botones de Navegacion
        //=======================================================================================================================
        //------------------------------------------------ Navegacion ------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Anterior(dgv_telefono);
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
                fn.Siguiente(dgv_telefono);
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
                fn.Primero(dgv_telefono);
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
                fn.Ultimo(dgv_telefono);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
