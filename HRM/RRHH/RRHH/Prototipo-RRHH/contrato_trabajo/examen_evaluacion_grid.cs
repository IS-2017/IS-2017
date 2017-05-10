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

namespace contrato_trabajo
{
    public partial class examen_evaluacion_grid : Form
    {
        #region Variables - Otto Hernandez
        String id_examen_evaluacion_pk, nombre_examen_evaluacion, nota_maxima_examen_evaluacion, id_area_trabajo_pk;
        Boolean Editar1;
        CapaNegocio fn = new CapaNegocio();
        #endregion

        #region Inicializar - Otto Hernandez
        public examen_evaluacion_grid()
        {
            InitializeComponent();
        }

        private void examen_evaluacion_grid_Load(object sender, EventArgs e)
        {
            try
            {
                string tabla = "examen_evaluacion";
                fn.ActualizarGrid(this.dgv_examen_busq, "Select * from examen_evaluacion WHERE estado <> 'INACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Nuevo - Otto Hernandez
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar1 = false;
                examen_evaluacion a = new examen_evaluacion(dgv_examen_busq, id_examen_evaluacion_pk, nombre_examen_evaluacion, nota_maxima_examen_evaluacion, id_area_trabajo_pk,Editar1);
                a.MdiParent = this.ParentForm;
                a.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton buscar - Otto Hernandez
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "examen_evaluacion";
                //op.ejecutar(dgv_rec_busq, tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Actualizar - Otto Hernandez
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "examen_evaluacion";
                fn.ActualizarGrid(this.dgv_examen_busq, "Select * from examen_evaluacion WHERE estado <> 'INACTIVO' ", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton anterior - Otto Hernandez
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Anterior(dgv_examen_busq);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Siguiente - Otto Hernandez
        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Siguiente(dgv_examen_busq);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton Primero - Otto Hernandez
        private void btn_primero_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Primero(dgv_examen_busq);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Boton Ultimo - Otto Hernandez
        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            try
            {
                fn.Primero(dgv_examen_busq);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Doble Click Datagrid - Otto Hernandez
        private void dgv_examen_busq_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Editar1 = true;
                id_examen_evaluacion_pk = this.dgv_examen_busq.CurrentRow.Cells[0].Value.ToString();
                nombre_examen_evaluacion = this.dgv_examen_busq.CurrentRow.Cells[1].Value.ToString();
                nota_maxima_examen_evaluacion = this.dgv_examen_busq.CurrentRow.Cells[2].Value.ToString();
                id_area_trabajo_pk = this.dgv_examen_busq.CurrentRow.Cells[4].Value.ToString();
                examen_evaluacion a = new examen_evaluacion(dgv_examen_busq, id_examen_evaluacion_pk, nombre_examen_evaluacion, nota_maxima_examen_evaluacion, id_area_trabajo_pk,Editar1);
                a.MdiParent = this.ParentForm;
                a.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region KeyUp Busqueda - Otto Hernandez
        private void txt_nombre_busq_ex_ev_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string tabla = "examen_evaluacion";
                fn.ActualizarGrid(this.dgv_examen_busq, "select * from examen_evaluacion where nombre_candidato like '" + txt_nombre_busq_ex_ev.Text + "%' and estado <> 'INACTIVO'", tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
