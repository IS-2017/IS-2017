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
using System.Collections;

namespace contrato_trabajo
{
    public partial class frm_grid_funcion : Form
    {
        #region variables - Otto Hernandez
        String id_funcion, sueldo_funcion, descripcion_funcion, nombre_funcion, id_perfil_reclutamiento_fk;
        ArrayList columnas;
        Boolean Editar1;
        CapaNegocio fn = new CapaNegocio();
        #endregion

        #region inicializar form - Otto Hernandez
        public frm_grid_funcion()
        {
            InitializeComponent();
        }

        private void frm_grid_funcion_Load(object sender, EventArgs e)
        {
            try
            {
                string tabla = "funcion";
                fn.ActualizarGrid(this.dgv_funcion_busq, "Select * from funcion WHERE estado <> 'INACTIVO' ", tabla);
                //fn.ActualizarGrid(this.dgv_funcion_busq, "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE table_name = 'funcion'", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region boton busqueda - Otto Hernandez
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "funcion";
                //op.ejecutar(dgv_rec_busq, tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region boton actualizar - Otto Hernandez
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "funcion";
                fn.ActualizarGrid(this.dgv_funcion_busq, "Select * from funcion WHERE estado <> 'INACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Botones Navegacion - Otto Hernandez
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Anterior(dgv_funcion_busq);
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
                fn.Siguiente(dgv_funcion_busq);
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
                fn.Primero(dgv_funcion_busq);
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
                fn.Ultimo(dgv_funcion_busq);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Doble click datagrid - Otto Hernandez
        private void dgv_funcion_busq_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Editar1 = true;
                id_funcion = this.dgv_funcion_busq.CurrentRow.Cells[0].Value.ToString();
                sueldo_funcion = this.dgv_funcion_busq.CurrentRow.Cells[1].Value.ToString();
                descripcion_funcion = this.dgv_funcion_busq.CurrentRow.Cells[2].Value.ToString();
                nombre_funcion = this.dgv_funcion_busq.CurrentRow.Cells[3].Value.ToString();
                id_perfil_reclutamiento_fk = this.dgv_funcion_busq.CurrentRow.Cells[5].Value.ToString();
                frm_funcion a = new frm_funcion(dgv_funcion_busq, id_funcion, sueldo_funcion, descripcion_funcion, nombre_funcion, id_perfil_reclutamiento_fk, Editar1);
                a.MdiParent = this.ParentForm;
                a.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region KeyUp - Otto Hernandez
        private void txt_nombre_busq_funcion_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string tabla = "funcion";
                fn.ActualizarGrid(this.dgv_funcion_busq, "select * from funcion where nombre_funcion like '" + txt_nombre_busq_funcion.Text + "%' and estado <> 'INACTIVO'", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region boton nuevo - Otto Hernandez
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar1 = false;
                frm_funcion a = new frm_funcion(dgv_funcion_busq, id_funcion, sueldo_funcion, descripcion_funcion, nombre_funcion, id_perfil_reclutamiento_fk, Editar1);
                a.MdiParent = this.ParentForm;
                a.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

    }
}
