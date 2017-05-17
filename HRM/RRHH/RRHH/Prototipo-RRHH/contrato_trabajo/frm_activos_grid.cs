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
    public partial class frm_activos_grid : Form
    {
        #region Variables Utilizadas
        //=======================================================================================================================
        //--------------------------------------Variables--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        CapaNegocio fn = new CapaNegocio();
        operaciones op = new operaciones();
        Boolean Editar1;
        Boolean tipo_accion;
        String id_activos_emp_pk, nombre_activo, num_serie_activo, precio_activo, descripcion_activo, estado;
        #endregion

        #region Inicio del Form Activos Grid
        //=======================================================================================================================
        //--------------------------------------Inicializacion del Form--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        public frm_activos_grid()
        {
            InitializeComponent();
        }
        #endregion

        #region Carga del Form Activos Grid
        //=======================================================================================================================
        //--------------------------------------Load del Form--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void frm_activos_grid_Load(object sender, EventArgs e)
        {
            try
            {
                string tabla = "activos_empresa";
                fn.ActualizarGrid(this.dgv_activos, "SELECT id_activos_emp_pk, nombre_activo, num_serie_activo, precio_activo, descripcion_activo, estado FROM `activos_empresa` WHERE estado = 'ACTIVO' ", tabla);
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
                frm_activos activo = new frm_activos(dgv_activos, id_activos_emp_pk, nombre_activo, num_serie_activo, precio_activo, descripcion_activo, estado, Editar1, tipo_accion);
                activo.MdiParent = this.ParentForm;
                activo.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
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
                string tabla = "activos_empresa";
                op.ejecutar(dgv_activos, tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Actualizar
        //=======================================================================================================================
        //-------------------------------------- Actualizar-------------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "activos_empresa";
                fn.ActualizarGrid(this.dgv_activos, "SELECT id_activos_emp_pk, nombre_activo, num_serie_activo, precio_activo, descripcion_activo, estado FROM `activos_empresa` WHERE estado = 'ACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        #endregion

        #region Doble-Clic Celda GridView
        //=======================================================================================================================
        //--------------------------------------CellDobleClic--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void dgv_activos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Editar1 = true;
                tipo_accion = true;
                id_activos_emp_pk = this.dgv_activos.CurrentRow.Cells[0].Value.ToString();
                nombre_activo = this.dgv_activos.CurrentRow.Cells[1].Value.ToString();
                num_serie_activo = this.dgv_activos.CurrentRow.Cells[2].Value.ToString();
                precio_activo = this.dgv_activos.CurrentRow.Cells[3].Value.ToString();
                descripcion_activo = this.dgv_activos.CurrentRow.Cells[3].Value.ToString();
                estado = this.dgv_activos.CurrentRow.Cells[4].Value.ToString();
                frm_activos activo = new frm_activos(dgv_activos, id_activos_emp_pk, nombre_activo, num_serie_activo, precio_activo, descripcion_activo, estado, Editar1, tipo_accion);
                activo.MdiParent = this.ParentForm;
                activo.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Botones de Navegacion 
        //=======================================================================================================================
        //------------------------------------------------Navegacion--------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Anterior(dgv_activos);
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
                fn.Siguiente(dgv_activos);
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
                fn.Primero(dgv_activos);
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
                fn.Ultimo(dgv_activos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                frm_reporte_activos activo = new frm_reporte_activos();
                activo.MdiParent = this.ParentForm;
                activo.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
