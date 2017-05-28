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
    public partial class frm_puesto_lab_grid : Form
    {
        #region Variables Form Puesto Laboral Grid
        //=======================================================================================================================
        //------------------------------------------------ Variables ------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        CapaNegocio fn = new CapaNegocio();
        operaciones op = new operaciones();
        Boolean Editar1;
        Boolean tipo_accion;
        String id_puesto_laboral_pk, nombre_puesto, descripcion, salario_base, estado;
        #endregion

        #region Visualizar Form Puesto Laboral
        //=======================================================================================================================
        //------------------------------------------------ Form Puesto Laboral---------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        public frm_puesto_lab_grid()
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

        #region Cargar Componentes del Form
        //=======================================================================================================================
        //------------------------------------------------ Cargar Form-----------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void frm_puesto_lab_grid_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_gridview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Actualizar
        //=======================================================================================================================
        //------------------------------------------------ Actualizar ------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Cargar_gridview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Cargar_gridview()
        {
            string tabla = "puesto_laboral";
            fn.ActualizarGrid(this.dgv_puesto, "SELECT id_puesto_laboral_pk, nombre_puesto, descripcion, salario_base, estado FROM `puesto_laboral` WHERE estado = 'ACTIVO' ", tabla);
        }
        #endregion

        #region Boton Buscar
        //=======================================================================================================================
        //------------------------------------------------ Buscar ------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "puesto_laboral";
                op.ejecutar(dgv_puesto, tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Nuevo
        //=======================================================================================================================
        //------------------------------------------------ Nuevo---- ------------------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar1 = false;
                frm_puesto_lab puesto = new frm_puesto_lab(dgv_puesto, id_puesto_laboral_pk, nombre_puesto, descripcion, salario_base, estado, Editar1, tipo_accion);
                puesto.MdiParent = this.ParentForm;
                puesto.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Doble-clic Celda en GridView
        //=======================================================================================================================
        //------------------------------------------------ Doble-clic en Celda--------------------------------------------------
        //=======================================================================================================================
        //programador:Javier Figueroa Pereira
        private void dgv_puesto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Editar1 = true;
                tipo_accion = true;

                id_puesto_laboral_pk = this.dgv_puesto.CurrentRow.Cells[0].Value.ToString();
                nombre_puesto = this.dgv_puesto.CurrentRow.Cells[1].Value.ToString();
                descripcion = this.dgv_puesto.CurrentRow.Cells[2].Value.ToString();
                salario_base = this.dgv_puesto.CurrentRow.Cells[3].Value.ToString();
                estado = this.dgv_puesto.CurrentRow.Cells[4].Value.ToString();

                frm_puesto_lab puesto = new frm_puesto_lab(dgv_puesto, id_puesto_laboral_pk, nombre_puesto, descripcion, salario_base, estado, Editar1, tipo_accion);
                puesto.MdiParent = this.ParentForm;
                puesto.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                frm_reporte_puestos puesto = new frm_reporte_puestos();
                puesto.MdiParent = mdi_contenedor.ActiveForm.ParentForm;
                puesto.Show();
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
                fn.Anterior(dgv_puesto);
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
                fn.Siguiente(dgv_puesto);
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
                fn.Primero(dgv_puesto);
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
                fn.Ultimo(dgv_puesto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
